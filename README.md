# Alprog.Data
`Alprog.Data` is a extendable system for processing data. 
## Conception
There are `pipelines`, `processors` and `data sources`. So, here is a visualisation:
```
Pipeline
|-----------|     |--------------|    |-----------|
|IDataSource| ==> |IDataProcessor| => |IDataSource| => ........ etc.
|-----------|     |--------------|    |-----------|
```
What's going on here? 
It's a `Data Pipeline`

A data is going to a `Data Processor`. It's processing data and return us a processed data. 
This processed data is going to an other `Data Processor`. It's doing same.
This action is going while Another Data Processors are available.

Here is a UML visualisation of a `Pipeline`:
```
|=====================|     |==============|     |=============|
|IDataPipeline        |     |IDataProcessor|     |IDataSource  |
|=====================|     |==============|     |=============|
|Processors           |     |Process       |     |Add          |
|CurrentDataSource    |     |--------------|     |AddRange     |
|CurrentProcessor     |                          |Remove       |
|CurrentProcessorIndex|                          |RemoveRange  |
|AddProcessor         |                          |Get          |
|NextProcessor        |                          |GetRange     |
|StartAndContinueToEnd|                          |Clear        |
|---------------------|                          |GetEnumerator|
                                                 |-------------|
```
