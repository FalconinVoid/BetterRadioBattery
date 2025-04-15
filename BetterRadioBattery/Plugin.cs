using System;

using Exiled.API.Features;
using player = Exiled.Events.Handlers.Player;
using item = Exiled.Events.Handlers.Item;

namespace BetterRadioBattery
{
    public class Plugin : Plugin<Config>
    {
        public override string Author => "FalconinVoid";
        public override string Name => "BetterRadioBattery";
        public override string Prefix => "BRadioBat";
        public override Version Version => new Version(1,1,0);
        public override Version RequiredExiledVersion => new Version(9,5,1);
        public static Plugin Instance { get; private set; }
        private EventHandler handler;
        public override void OnEnabled()
        {
            Instance = this;
            handler = new EventHandler(Instance.Config);
            player.UsingRadioBattery += handler.OnUsingRadioBattery;
            item.UsingRadioPickupBattery += handler.OnUsingRadioPickupBattery;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            if (handler != null)
            {
                player.UsingRadioBattery -= handler.OnUsingRadioBattery;
                item.UsingRadioPickupBattery -= handler.OnUsingRadioPickupBattery;
            }
            handler = null;
            base.OnDisabled();
        }
    }
}
