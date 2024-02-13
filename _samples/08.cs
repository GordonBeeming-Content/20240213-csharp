
TraceMethod.Start();
Console.WriteLine("Doing some important work!");
TraceMethod.End();


using System.Diagnostics;
using System.Runtime.CompilerServices;

public sealed class TraceMethod
{
  [Conditional("DEBUG")]
  public static void Start()
  {
    Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD START");
  }

  [Conditional("DEBUG")]
  public static void End()
  {
    Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD END");
  }

  [Conditional("DEBUG")]
  public static void Start2([CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD START: {memberName} {filePath} {lineNumber}");
  }

  [Conditional("DEBUG")]
  public static void End2([CallerMemberName] string memberName = null, [CallerFilePath] string filePath = null, [CallerLineNumber] int lineNumber = 0)
  {
    Console.WriteLine($"{DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD END: {memberName} {filePath} {lineNumber}");
  }
}