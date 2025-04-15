using System.ComponentModel;

using Exiled.API.Interfaces;

namespace BetterRadioBattery
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Lower values mean lower drain!")]
        public float DrainMultiplier { get; set; } = 1f;
        [Description("Additional Multipliers")]
        public float ShortRangeMultiplier { get; set; } = 1f;
        public float MiddleRangeMultiplier { get; set; } = 1f;
        public float LongRangeMultiplier { get; set; } = 1f;
        public float UltraRangeMultiplier { get; set; } = 1f;
    }
}
