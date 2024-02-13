
#if DEBUG
  Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD START");
#endif
Console.WriteLine("Doing some important work!");
#if DEBUG
  Console.WriteLine($"TRACE - {DateTime.UtcNow:yyyyMMdd-HHmmss} METHOD END");
#endif
