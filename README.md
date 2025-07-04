## Universal Steam Server Browser WebApp
Primarily used for Source & GoldSrc games/mods! Based off https://github.com/BerntA/GameServerBrowser

### How to run
Edit SteamAPIKey in 'GameServerList.App/appsettings.json', then launch app.sln, compile and launch from there.

```
powershell ./run.ps1
```

Open http://localhost:5176/ in the browser.

### Adding new game entries
Edit the 'GameServerList.App/Data/games.json' file.

### Features
- Queries Steam WEB API to retrieve server info for games & mods
- Utilizes A2S queries to retrieve player info, and server info for legacy mods (e.g appId 215 related games)
- Supports querying master server list, player info and server info via A2S
- Handles split packets & compression
