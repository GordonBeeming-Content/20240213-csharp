
public sealed class HelperClass
{
  #if DEBUG
  public const bool IsDebugBuild = true;
#else
  public const bool IsDebugBuild = false;
#endif  
}