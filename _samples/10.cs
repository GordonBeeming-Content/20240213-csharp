
var doSomething = () => { Console.WriteLine("Doing some important work!"); return 42; };
if (TraceMethod.DoIfTrue(doSomething, doSomething is not null) == 42)
{
  Console.WriteLine("Here!");
}



using System.Diagnostics;
using System.Runtime.CompilerServices;

public sealed class TraceMethod
{
  public static bool TraceCondition(bool condition, [CallerArgumentExpression(nameof(condition))] string? message = null, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"TRACE - <{message}> == {condition} | {memberName} {filePath} {lineNumber}");
    return condition;
  }

  public static void DoIfTrue(Action action, bool condition, [CallerArgumentExpression(nameof(condition))] string? message = null, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"TRACE - <{message}> == {condition} | {memberName} {filePath} {lineNumber}");
    if (condition)
    {
      action();
    }
  }

  public static T? DoIfTrue<T>(Func<T> func, bool condition, [CallerArgumentExpression(nameof(condition))] string? message = null, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"TRACE - <{message}> == {condition} | {memberName} {filePath} {lineNumber}");
    if (condition)
    {
      return func();
    }
    else
    {
      return default;
    }
  }
}