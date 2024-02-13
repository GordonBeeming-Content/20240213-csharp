
if (HelperClass.IsDebugBuild)
{
  Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD START");
}
Console.WriteLine("Doing some important work!");
if (HelperClass.IsDebugBuild)
{
  Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD END");
}

public sealed class HelperClass
{
  #if DEBUG
  public const bool IsDebugBuild = true;
#else
  public const bool IsDebugBuild = false;
#endif  
}