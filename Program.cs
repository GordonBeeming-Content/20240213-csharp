
var doSomething = () => { Console.WriteLine("Doing some important work!"); return 42;};
if (TraceMethod.DoIfTrue(doSomething, doSomething is not null) == 42)
{
  Console.WriteLine("Done!");
}
