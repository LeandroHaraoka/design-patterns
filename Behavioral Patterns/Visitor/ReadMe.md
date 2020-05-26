# Visitor

Represent an operation to be performed on the elements of an object structure. Visitor lets you define a new operation without changing the classes of the elements on which it operates.

![Visitor Pattern Diagram](Images/VisitorPatternDiagram.png)

## Problem

## Show me the code

## Use cases

Use Visitor Pattern when:

- Your application contains a structure in which each element has its particular way if executing a common action.
- You want to provide a specific behavior to classes methods without polluting them.

## Advantages

- Adds particular behavior to a range of different classes, without adding complexity to them. All bevaviours are defined in a single point of the code.
- You can set specific behaviours only for classes in which they're necessary. The rest of the structure classes doesn't need be visitable.
- In contrast to the Strategy, Visitor allows setting a behavior at compile time, preventing a class from owning another class bevahior.

## Disadvantages

- When a new element is added to structure, you'll probably have to change the visitor interface and implementations to add the visitor specific method.
- Sometimes, this pattern can damage an object encapsulation, as the visitor may access the object methods and fields.

## Comparisons

### Strategy 

## References

https://refactoring.guru/design-patterns/template-method

https://www.dofactory.com/net/template-method-design-pattern

https://github.com/ExcelDataReader/ExcelDataReader

Pluralsight Course: *C# Design Patterns: Visitor*. By Harrison Ferrone.    
    
Pluralsight Course: *Design Patterns in Swift: Behavioral - Template Method*. By Karoly Nyisztor.

Udemy Course: *Design Patterns in C# and .NET - Template Method*. By Dmitri Nesteruk.

## Todo

Refatoring Guru comparisons
