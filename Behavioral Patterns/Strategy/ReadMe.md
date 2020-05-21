# Strategy

Define a family of algorithms, encapsulate each one, and make them interchangeable. Strategy lets the algorithm vary independently from clients that use it.

## Problem


## Use cases

Use State Pattern when:


- Must configure behaviors of an object that changes with it states.
- 
- 
- 

## Advantages

- Decouple the context and the strategy implementation.
- Cleaner implementation of the context.
- Easily to extend new strategies, without changing previous ones.
- Makes tests easier as we can mock the strategies behaviours.

## Disadvantages

- Strategiesmust be chosen by the client, different from state.
-
-

## Comparisons

- Strategy is about different algorithms which can be interchanged, different from states that is about transitioning between different states.
- A strategy has no knowledge about other strategies, they're independent, while state should know the previous and next states.
- Client should know all the available strategies, but it can be unaware about the states.

## References

## TODOs

{
  "assetType": "Cash",
  "buyer": "83fdb920-5316-4b74-b3d3-927def5e0be2",
  "seller": "63be2bdb-a101-4ca4-9fd1-ca46de6f8f29",
  "tradeDate": "2020-05-30T15:54:55.894Z",
  "movements": [
    {
      "withdrawDate": "2020-12-21T15:54:55.894Z",
      "price": 1500,
      "volume": 1,
      "direction": "Inflow",
    }
  ]
}

{
  "assetType": "Bond",
  "buyer": "83fdb920-5316-4b74-b3d3-927def5e0be2",
  "seller": "63be2bdb-a101-4ca4-9fd1-ca46de6f8f29",
  "tradeDate": "2020-05-30T15:54:55.894Z",
  "movements": [
    {
      "withdrawDate": "2020-09-17",
      "price": 100,
      "volume": 1,
      "direction": "Inflow",
    },
    {
      "withdrawDate": "2020-09-17",
      "price": 100,
      "volume": 1,
      "direction": "Outflow",
      "index": "PRE",
      "rate": 0.3
    }
  ]
}

{
  "assetType": "Forex",
  "buyer": "83fdb920-5316-4b74-b3d3-927def5e0be2",
  "seller": "63be2bdb-a101-4ca4-9fd1-ca46de6f8f29",
  "tradeDate": "2020-05-30T15:54:55.894Z",
  "movements": [
    {
      "withdrawDate": "2020-09-17",
      "price": 6.50,
      "volume": 1,
      "direction": "Inflow",
      "referenceCurrency": "USD",
      "currency": "BRL",
    }
  ]
}

{
  "assetType": "Stock",
  "buyer": "83fdb920-5316-4b74-b3d3-927def5e0be2",
  "seller": "63be2bdb-a101-4ca4-9fd1-ca46de6f8f29",
  "tradeDate": "2020-05-30T15:54:55.894Z",
  "movements": [
    {
      "withdrawDate": "2020-09-17",
      "price": 6.50,
      "volume": 1,
      "stockCode": "FB",
    }
  ]
}

{
  "assetType": "Commodity",
  "buyer": "83fdb920-5316-4b74-b3d3-927def5e0be2",
  "seller": "63be2bdb-a101-4ca4-9fd1-ca46de6f8f29",
  "tradeDate": "2020-05-30T15:54:55.894Z",
  "movements": [
    {
      "withdrawDate": "2020-09-17",
      "price": 1750,
      "volume": 1,
      "commodityIdentifier": "GOLD",
    }
  ]
}