
#if DEBUG
const bool debugBuild = true;
#else
const bool debugBuild = false;
#endif
if (debugBuild)
{
  Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD START");
}
Console.WriteLine("Doing some important work!");
if (debugBuild)
{
  Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD END");
}