# Alprog.Data
`Alprog.Data` is a extendable system for processing data. 
## Conception
In `Alprog.Data` are extension methods for processing data and not only. 
Go to examples!
## Simplification of `If/Else constructions`
Okey. For begin, let's change your mean about `if/else constructions`.
Default:
```cs
if (a > 10)
{
   ...
}
else if (a > 5)
{
   ...
}
else
{
   ...
}
```
With Alprog.Data extension methods:
```cs
a.If(x => x > 10).Then(...)
.ElseIf(x => x > 5).Then(...)
.Else(...);
```
As you noticed, here `if/else construction` looks like English language. It's easy for writing the code.
[How it work and underwater stones](conditionSimplification.md)

## Extension methods for processing lists and arrays

Default:
```cs
foreach (object item in items)
{
     ...
}
```
Or:
```cs
for (int i = 0; i < items.Lenght; i++)
{
    ...
}
```
It can be easy with Alprog.Data!
If just for example output somewhere: 
```cs
items.EveryItem(x => ...);
```
If need to process data:
```cs
items.Process(x => ...);
```
Filtering data:
```cs
items.FilterBy(x => ...); //here lamda-function must return boolean value!
```
And transform data to other type:
```cs
items.Transform(x => ...);
```
These methods can be called in any type, which inherts `IEnumerable`
