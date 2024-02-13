using static TraceMethod;

var doSomething = () => Console.WriteLine("Doing some important work!");
StartTrace();
if (IsTrue(doSomething is not null))
{
  doSomething();
}
EndTrace();






using System.Diagnostics;
using System.Runtime.CompilerServices;

public sealed class TraceMethod
{
  [Conditional("DEBUG")]
  public static void StartTrace([CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD START: {memberName} {filePath} {lineNumber}");
  }

  [Conditional("DEBUG")]
  public static void EndTrace([CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"{DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD END: {memberName} {filePath} {lineNumber}");
  }

  public static bool IsTrue(bool condition, [CallerArgumentExpression(nameof(condition))] string? message = null, [CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"TRACE - <{message}> == {condition} | {memberName} {filePath} {lineNumber}");
    return condition;
  }
}