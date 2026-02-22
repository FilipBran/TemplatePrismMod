using Prism;

namespace TemplatePrismMod;

public sealed class MyMod : Mod
{
    public override string Name => "MyMod";
    public override string Version => "1.0.0";
    public override string Id => "com.example.mymod";

    public override void Init()
    {
        AdvancedLogger.Log($"[{Name}] Loaded mod {Name}!", AdvancedLogger.LogType.Info);
    }
}