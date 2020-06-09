# Flyweight

Use sharing to support large numbers of fine-grained objects efficiently.

Some objects states can be segregated into two pieces: extrinsic and intrinsic states. Intrinsic contains the information that does not change during an object lifecycle, while extrinsic consists of mutable information. As the intrinsic state does not change, it can be reused by different representations of the same object. A flyweight is an object that contains the intrinsic data of an object.

The flyweight reusability lets the application storing intrinsic data, so that it can be shared by multiple object instances.

The pattern structure consists of the following elements:

- Flyweight: interface that defines a method to receive an extrinsic state and use it to perform some operation.
- ConcreteFlyweight: implements the Flyweight interface and stores intrinsic data.
- UnsharedConcreteFlyweight*: stores both extrinsic and intrinsic states that are not shareable.
- FlyweightFactory: manages flyweight objects. When client requests a flyweight, it returns an existing one or create a new, if none exists.

*The pattern allows sharing intrinsic data, but it's not an obligation. It can provide unshared concrete instances. Although they're not shareable, they can consume extrinsic data, because they implement the Flyweight interface.

![Flyweight Pattern Diagram](Images/FlyweightPatternDiagram.png)

## Problem

![Http Communication Example](Images/HttpCommunicationExample.png)

## Show me the code

## Use cases

Use Flyweight Pattern when:

- An application handles lots of objects, making storage costs high.
- Many groups of objects can be replaced by a few shared ones, to reuse instrinsic states.


## Advantages

- 

## Disadvantages

- 

## Comparisons

## References

https://refactoring.guru/design-patterns/flyweight

Pluralsight Course: *C# Design Patterns: Flyweight*. By Harrison Ferrone.

Udemy Course: *Design Patterns in C# and .NET - Facade*. By Dmitri Nesteruk.

## Todo

Comparisons