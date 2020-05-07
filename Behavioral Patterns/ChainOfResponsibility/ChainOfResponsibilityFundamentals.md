# Chain Of Responsibility

Avoid coupling the sender of a request to its receiver by giving morethan one object a chance to handle the request. Chain the receivingobjects and pass the request along the chain until an objecthandles it.

## Problem

## Show me the code
Interface (contract)
    Abstract (default implementation)
    xptoHandler1
    xptoHandler2
    xptoHandler3



Loan Request
    (ProposalRequest)
    ClientId
    Amount
Handler 1
    GetClientInfo
        (Client)
        CPF/CNPJ
        Address
        Phone
        BankAccount
Handler 2
    GetClientRiskAndCalculateRate
        (EnumRisk)
        A/B/C/D
Handler 3
    GetCollateralAndMultiplyRate
        (BankAccount)
        Balance
Handler 4
Calculate Rate
    Risk and collateral
Generate Proposal    


## Use cases

Use a Chain of Responsibilities when:

- More than one object must handle a request.
- The application does not know a priori which object will handle the request.
- The order of handlers execution is relevant.
- The request does not have to know which objects will handle.

## Advantages

- It's easy to add a know handler to the chain and can be done at runtime.
- It allows specifying the handlers execution order and it can be done at runtime.
- If well designed it satisfies Single Responsibility Principle.

## Disadvantages
- This pattern does not ensure that a request will be handled. It can arrive at the end of the chain without being handled (sometimes it's a desired behavior).

## Tips

## References

## TODOs