# 📻 BetterRadioBattery

A plugin for [EXILED](https://github.com/Exiled-Team/EXILED) that enhances the behavior of radio batteries in SCP: Secret Laboratory. It allows you to control how quickly radios drain and disables recharging them with battery items.

---

## 🔧 Features

- 🔋 **Customizable battery drain**: Adjust how quickly radios lose battery power.
- 🚫 **Disabled Drain while dropped**: Prevent battery drain while not in use.
- ⚙️ **Fully configurable**

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
drain_multiplier: 1.0 #Lower values mean lower drain!
