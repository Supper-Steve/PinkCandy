using Exiled.API.Features;
using System;

namespace PinkCandy
{
    public class Plugin : Plugin<Config>
    {
        public static Plugin PinkCandyPlugin { get; } = new Plugin();
        public override string Author { get; } = "史蒂夫";
        public override string Name { get; } = "PinkCandy";
        public override Version Version { get; } = new Version(0, 0, 0, 1);
        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 += EventHandlers.OnInteractingScp330;
            Log.Info("加载粉糖插件! By 史蒂夫 [已在GitHub上开源,版权史蒂夫]");
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Scp330.InteractingScp330 -= EventHandlers.OnInteractingScp330;
            Log.Info("关闭粉糖插件!");
            base.OnDisabled();
        }
    }
}
