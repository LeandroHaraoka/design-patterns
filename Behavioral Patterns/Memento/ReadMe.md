# Memento

Without violating encapsulation, capture and externalize an object's internal state so that the object can be restored to this state later.

The Memento Pattern lets the application save and restores its objects states, without exposing their implementations. Sometimes objects encapsulate their state, making it inacessible to other objects. Memento provides a way to restore it in these cases.

There are different ways to implement this pattern. The classic implementation consists in:

- An Originator object that requires save and restore functionallities. It uses the memento to restore previous states.
- A Memento object that stores the Originator state without providing external access to it.
- Caretaker stores all mementos objects, but never access its content.

You can also have an interface to deal with memento, to avoid coupling between memento and caretaker.

![Mediator Pattern Diagram](Images/MediatorDiagram.png)

## Problem


![Mediator Chat Example](Images/MediatorChat.png)

# Show me the Code

Output:

![Mediator Stock Exchange Output](Images/StockExchangeMediatorOutput.gif)

## Use Cases

Use Memento Pattern when:

- A snapshot of an object must be saved and can be restored in the future.
- You can not break the state encapsulation, but you need to access it.

## Advantages

- Allows an object state to be saved and restored in a way that does not break its encapsulation.
- The state management is removed from the originator and becomes a responsibility of the caretaker.

## Disadvantages

- State changes increases processing consumption.
- Caretaker may produce a high storage usage, maybe it's better to store the mementos in a database.
- Carataker may need to define how much history should be kept.

## Comparisons

Memento looks very similar to Command, but they have some differences.
- Memento stores states while Command stores requests.
- Memento allows states to be stored and restored while Command allows requests to be created and undone.
- Memento goal is to provide a caretaker that stores the state history. Command goal is to store information to perform and undo actions. It also stores the requests history, but it's a side benefit, 

Memento and Command can be used together. 
- Command should be used to perform actions that changes the object state. 
- Memento should be used to store the object state.
- To undo operations, you can revert a command action.
- To rollback to a previous state, you can use Memento's caretaker.

## References

https://refactoring.guru/design-patterns/memento

Pluralsight Course: *Design Patterns in Java: Behavioral - Memento Pattern*. By Bryan Hansen.

Pluralsight Course: *C# Design Patterns: Mediator*. By Steve Michelotti.

Udemy Course: *Design Patterns in C# and .NET - Mediator*. By Dmitri Nesteruk.