# Discord.Net V3 Bot

This is intended to be a feature rich, all inclusive tutorial series for learning the capabilities and usage of the features present in Discord.Net V3+.

All code and features used here will be available through the Discord.Net Nuget packages
- [Discord.Net](https://www.nuget.org/packages/Discord.Net/)

## Requirements:
I will be using Visual Studio Community 2022 almost exclusively through the series.
The Nuget packages used are:
- [Discord.Net](https://www.nuget.org/packages/Discord.Net/) 3.4.0
- [Microsoft.Extensions.Configuration.Yaml](https://www.nuget.org/packages/Microsoft.Extensions.Configuration.Yaml/) 2.0.0-preview2
- [Microsoft.Extensions.DependencyInjection](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection/) 6.0.0
- [Microsoft.Extensions.DependencyInjection.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.DependencyInjection.Abstractions/) 6.0.0
- [Microsoft.Extensions.Hosting](https://www.nuget.org/packages/Microsoft.Extensions.Hosting/) 6.0.0
- [YamlDotNet](https://www.nuget.org/packages/YamlDotNet/) 8.1.2

These packages and versions used may be changed over time as new features are added or bugs are fixed.
### NOTE
The YamlDotNet version used (8.1.2) is important. The latest is bugged and will not work.

## Layout
The /main branch is the boilerplate bot code. Only basic functionality.
The other branches are feature additions on top of the boilerplate code. They can be mixed and matched as desired. I will do my best to maintain compatibility across them.

## Features
- Slash commands
- User Context Commands
- Message Context Commands
- Prefix Commands
- Buttons
- Select Menus
- Modals (text box inputs)

## Additional Files Required
config.yml (Must end up in same directory as bot executable)
Sample config.yml contents below:
```
testguild: test_guild_id_here
tokens:
    discord: discord_bot_token_here
```

Credit to https://github.com/drobbins329/ for making this possible!
