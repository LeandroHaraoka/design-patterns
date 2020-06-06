# Decorator

Attach additional responsibilities to an object dynamically. Decorators provide a flexible alternative to subclassing for extending functionality.

It's used to add responsibilities to individual objects (not to an entire class). Different from inheritance, it provides flexibility for new behaviors to be added at runtime.

Components are often enclosed with a decorator that implements the component interface, so that its presence is transparent for the client. It performs some additional instructions and forwards the request to the component. Its transparency lets you nest decorators recursively to provide many additional instructions.

![Decorator Pattern Diagram](Images/DecoratorPatternDiagram.png)

## Problem

Suppose an application has a simple authentication management that stores tokens for its user. When a user saves a new token, its previous token is overriden. The problem is that the application is requiring some security and performance improvements. Because of that, you're asked to implement caching and cryptography features, to store encrypted tokens values.

To save a new token, you should encrypt it, set its value to a memory cache and also save in a database. To retrieve it, you should search first at the memory cache and after in database, then you should decrypt it.

We'll create decorators to perform cryptography and caching instructions. They will enclose TokenReader and TokenWriter class, in order to extend their behavior.

![Authentication Example](Images/AuthenticationExample.png)

## Show me the code

Both components and decorators should share the same interfaces.

```csharp
public interface ITokenWriter
{
    void Save(Guid userId, string accessToken);
}
```
```csharp
public interface ITokenReader
{
    string Read(Guid userId);
}
```

The following TokenWriter and TokenReader components are independents, they are able to write and read tokens by themselves.

```csharp
public class TokenWriter : ITokenWriter
{
    private readonly AuthenticationTokenContext _context;
    
    public TokenWriter(AuthenticationTokenContext context)
    {
        _context = context;
    }

    public void Save(Guid userId, string accessToken)
    {
        _context.Tokens[userId] = accessToken;
    }
}
```
```csharp
public class TokenReader : ITokenReader
{
    private readonly AuthenticationTokenContext _context;

    public TokenReader(AuthenticationTokenContext context)
    {
        _context = context;
    }

    public string Read(Guid userId)
    {
        _context.Tokens.TryGetValue(userId, out var accessToken);
        
        return accessToken;
    }
}
```
```csharp
public class AuthenticationTokenContext
{
    public readonly IDictionary<Guid, string> Tokens = new Dictionary<Guid, string>();
}
```

Up to now we're able to persist and retrieve token values. Now we need to implement the required improvements. First we'll create base decorators. They implement the same interfaces as the components do.

```csharp
public abstract class TokenWriterDecorator : ITokenWriter
{
    protected readonly ITokenWriter _tokenWriter;

    public TokenWriterDecorator(ITokenWriter tokenWriter)
    {
        _tokenWriter = tokenWriter;
    }

    public abstract void Save(Guid userId, string accessToken);
}
```
```csharp
public abstract class TokenReaderDecorator : ITokenReader
{
    protected readonly ITokenReader _tokenReader;

    public TokenReaderDecorator(ITokenReader tokenReader)
    {
        _tokenReader = tokenReader;
    }

    public abstract string Read(Guid userId);
}
```

For caching, we use the following decorators.

```csharp
public class TokenCacheWriter : TokenWriterDecorator
{
    private readonly IMemoryCache _memoryCache;

    public TokenCacheWriter(ITokenWriter tokenWriter, IMemoryCache memoryCache) 
        : base(tokenWriter)
    {
        _memoryCache = memoryCache;
    }

    public override void Save(Guid userId, string accessToken)
    {
        _memoryCache.Set(userId, accessToken);
        _tokenWriter.Save(userId, accessToken);
    }
}
```
```csharp
public class TokenCacheReader : TokenReaderDecorator
{
    private readonly IMemoryCache _memoryCache;

    public TokenCacheReader(ITokenReader tokenReader,IMemoryCache memoryCache) 
        : base(tokenReader)
    {
        _memoryCache = memoryCache;
    }

    public override string Read(Guid userId)
    {
        _memoryCache.TryGetValue<string>(userId, out var accessToken);
        return accessToken ?? _tokenReader.Read(userId);
    }
}
```

For cryptography, we use the following decorators.

```csharp
public class TokenCryptographyWriter : TokenWriterDecorator
{
    public TokenCryptographyWriter(ITokenWriter tokenWriter) : base(tokenWriter)
    {
    }

    public override void Save(Guid userId, string accessToken)
    {
        var encryptedToken = Convert.ToBase64String(Encoding.Unicode.GetBytes(accessToken));
        _tokenWriter.Save(userId, encryptedToken);
    }
}
```
```csharp
public class TokenCryptographyReader : TokenReaderDecorator
{
    public TokenCryptographyReader(ITokenReader tokenReader) : base(tokenReader)
    {
    }

    public override string Read(Guid userId)
    {
        var accessToken = _tokenReader.Read(userId);
        var decryptedToken = Encoding.Unicode.GetString(Convert.FromBase64String(accessToken));
        return decryptedToken;
    }
}
```

So, let's consume it. Following you can see a simplified setup done just to run the example.

```csharp
var context = new AuthenticationTokenContext();
var memoryCache = new MemoryCache(new MemoryCacheOptions());
var token = "ewzesdw4efa498we4fw4ef98a4f984we98f4w9e8f4";
var userId = Guid.NewGuid();
```

To save a token with all requirements previously described:

```csharp
var tokenWriter = 
    new TokenCryptographyWriter(
        new TokenCacheWriter(
            new TokenWriter(context), memoryCache));

tokenWriter.Save(userId, token);
```

Output:

![Save Token Output](Images/SaveTokenOutput.png)

To read a token:

```csharp
var tokenReader = 
    new TokenCryptographyReader(
        new TokenCacheReader(
            new TokenReader(context), memoryCache));
var retrievedToken = tokenReader.Read(userId);
```

Output:

![Retrieve Token Output](Images/RetrieveTokenOutput.png)

## Use cases

Use Decorator Pattern when:

- Individual objects should take/lose responsibilities dinamically without affecting others.
- Inheritance is not allowed/desired.

## Advantages

- Behaviors can be added, removed and combined at runtime.
- A complex object can be composed by many simple decorators that, when combined, provides the desired behavior, without creating complex classes.


## Disadvantages

- Increase the number of indirections. A code with many decorators may be boring to debug.

## Comparisons

## References

https://refactoring.guru/design-patterns/decorator

Pluralsight Course: *C# Design Patterns: Decorator*. By David Berry.

Pluralsight Course: *C# Design Strategies: Composition with the Decorator*. By Jon Skeet.

Udemy Course: *Design Patterns in C# and .NET - Decorator*. By Dmitri Nesteruk.

## Todo

Comparisons