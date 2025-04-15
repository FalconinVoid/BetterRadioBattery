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
        public override Version Version => new Version(1,0,0);
        public override Version RequiredExiledVersion => new Version(9,5,1);
        public static Plugin Instance { get; private set; }
        private readonly EventHandler handler = new EventHandler();
        public override void OnEnabled()
        {
            Instance = this;
            player.UsingRadioBattery += handler.OnUsingRadioBattery;
            item.UsingRadioPickupBattery += handler.OnUsingRadioPickupBattery;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            player.UsingRadioBattery -= handler.OnUsingRadioBattery;
            item.UsingRadioPickupBattery -= handler.OnUsingRadioPickupBattery;
            base.OnDisabled();
        }
    }
}
