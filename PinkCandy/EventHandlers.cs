using Exiled.Events.EventArgs.Scp330;
using System;

namespace PinkCandy
{
    public class EventHandlers
    {
        public static void OnInteractingScp330(InteractingScp330EventArgs ev) 
        {
            if (new Random().Next(1, Plugin.PinkCandyPlugin.Config.SpawnPinkCandy + 1) == 1)
                ev.Candy = InventorySystem.Items.Usables.Scp330.CandyKindID.Pink;
        }
    }
}
