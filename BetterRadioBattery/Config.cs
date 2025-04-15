using Exiled.API.Interfaces;
using System.ComponentModel;

namespace BetterRadioBattery
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Lower values mean lower drain!")]
        public float DrainMultiplier { get; set; } = 1f;
    }
}
