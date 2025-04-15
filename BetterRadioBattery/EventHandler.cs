using Exiled.API.Features;
using Exiled.API.Enums;
using Exiled.Events.EventArgs.Item;
using Exiled.Events.EventArgs.Player;

namespace BetterRadioBattery
{
    public class EventHandler
    {
        private Config Config { get; set; }
        public EventHandler(Config config)
        {
            Config = config;
        }
        public void OnUsingRadioBattery(UsingRadioBatteryEventArgs ev)
        {
            switch (ev.Radio.Range)
            {
                case RadioRange.Short:
                    ev.Drain *= Config.ShortRangeMultiplier;
                    break;
                case RadioRange.Medium:
                    ev.Drain *= Config.MiddleRangeMultiplier;
                    break;
                case RadioRange.Long:
                    ev.Drain *= Config.LongRangeMultiplier;
                    break;
                case RadioRange.Ultra:
                    ev.Drain *= Config.UltraRangeMultiplier;
                    break;
            }
            ev.Drain *= Plugin.Instance.Config.DrainMultiplier;
            Log.Debug($"{ev.Player} Drain: {ev.Drain}");
        }
        public void OnUsingRadioPickupBattery(UsingRadioPickupBatteryEventArgs ev)
        {
            ev.IsAllowed = false;
        }
    }
}