# 📻 BetterRadioBattery

A plugin for [EXILED](https://github.com/ExMod-Team/EXILED) that enhances the behavior of radio batteries in [SCP: Secret Laboratory](https://store.steampowered.com/app/700330/SCP_Secret_Laboratory/). It allows you to control how quickly radios drain and disables recharging them with battery items.

---

## 🔧 Features

- 🔋 **Customizable battery drain**: Adjust how quickly radios lose battery power.
- 🚫 **Disabled Drain while dropped**: Prevent battery drain while not in use.
- ⚙️ **Fully configurable**: To keep the radio balanced however _YOU_ like.

---

## 📁 Installation

1. Download the latest `.dll` release of the plugin.
2. Place it into your server’s `~/EXILED/Plugins` folder.
3. Restart your server.

---

## ⚙️ Configuration (`~/EXILED/Configs/config.yml`)

```yaml
is_enabled: true
debug: false
#Global multiplier for all ranges
drain_multiplier: 1.0
# Multipliers based on radio range
short_range_multiplier: 1.0
middle_range_multiplier: 1.0
long_range_multiplier: 1.0
ultra_range_multiplier: 1.0
