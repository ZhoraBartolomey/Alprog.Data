# Simplification of `If/Else constructions`
## [Example in README](README.md)
## Documentation
There is a static class `ConditionExtension`. All related with conditions methods are in the class `ConditionExtension`.
For begin must be called a method `If`. It returns a `ConditionResult<T>`. It's a result of any condition.
In `ConditionResult<T>` can be called methods `Then`, `ElseIf` and `Else`. After every above method, must be called a method `Then`.
It turns out a stack of `ConditionResults`.
## Example
```cs
//Reading the number
int a = int.Parse(Console.ReadLine());

a.If(x => x > 10).Then(x => Console.WriteLine("a > 10")
.ElseIf(x => x > 5).Then(x => Console.WriteLine("a > 5")
.Else(x => Console.WriteLine("a <= 5"));

// If a > 10 then write "a > 10",
// Else if a > 5 then write "a > 5",
// Else write "a <= 5"
```
