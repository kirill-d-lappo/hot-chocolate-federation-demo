# Apollo Federation Example using HotChocolate

## Tech Details

* dotnet 9
* HotChocolate packages, version 15.*
* router version 1.60.1
* rover version 0.27.1
* no db required, solution is ready to start up

## Setup

Solution contains two graphql services, A and B.

"A" provides user query with some user data.

"B" extends User type from "A"; also B tries to use external fields of the User type.

Both services generate their own schema on disk (schema-a.graphql and schema-b.graphql)

Also, solution contains scripts for running router instance, which joins subgraphs A and B into a supergraph.

## Related Issues

* [HotChocolate.ApolloFederation ArgumentParser not parsing ListValue kind](https://github.com/ChilliCream/graphql-platform/issues/6232)

## How To

* Run ApiA project (dotnet run), make sure it runs
* Run ApiB project (dotnet run), make sure it runs
* Start Supergaph
  * navigate to rover-compose folder
  * install rover binary into that folder (script or manually)
  * install router binary into that folder (script or manually)
  * all config files are tied to default ApiA and ApiB configuration, no changes here
  * run `compose.sh` to generate supergraph schema and start router instance
  * make sure that supergraph was built and router is running
* Navigate to supergraph dashboard [http://0.0.0.0:4000/graphql](http://0.0.0.0:4000/graphq)
* Execute the next query:
  ```graphql
  query allUsers {
    allUsers {
      id
      name
      age
      personalKey
      numbers
      longs {
        value
      }

      # these field uses fields from above
      simpleTypesOnlyExample

      # but this field can't get "numbers" field value - it is an array
      collectionOfDefaultTypeExample

      # example of array of ref type, also always null
      collectionOfRefType

      # result of workaround
      workaroundForNumbers
    }
  }
  ```

Result is:

```json5
{
  "data": {
    "allUsers": [
      {
        "id": 1,
        "name": "user1",
        "age": 42,
        "personalKey": "e35f3d0a-12d9-4617-9898-5f1d6b295ec1",
        "numbers": [
          1,
          2,
          3,
          4
        ],
        "longs": [
          {
            "value": 42
          }
        ],
        "simpleTypesOnlyExample": "1--user1--42--e35f3d0a-12d9-4617-9898-5f1d6b295ec1",
        "collectionOfDefaultTypeExample": "user MAGIC NUMBERS are null, can't create extended name",
        "collectionOfRefType": "user LONGS  are null, can't create extended name",
        "workaroundForNumbers": "Numbers are: 1, 2, 3, 4"
      }
      // other users here...
    ]
  }
}
```
