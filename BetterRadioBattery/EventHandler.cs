using Exiled.API.Features;
using Exiled.Events.EventArgs.Item;
using Exiled.Events.EventArgs.Player;

namespace BetterRadioBattery
{
    class EventHandler
    {
        public void OnUsingRadioBattery(UsingRadioBatteryEventArgs ev)
        {
            ev.Drain *= Plugin.Instance.Config.DrainMultiplier;
            Log.Debug($"{ev.Player} Drain: {ev.Drain}");
        }
        public void OnUsingRadioPickupBattery(UsingRadioPickupBatteryEventArgs ev)
        {
            ev.IsAllowed = false;
        }
    }
}
