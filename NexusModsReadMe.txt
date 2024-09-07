[b][size=5]Shortest Trip To Earth - Load Crew Only[/size][/b] 
 
A mod to load only the crew positions from a preset.  Press Right Click on the Load button to only move the crew.
 
Left Click and the preset hotkeys are not affected.
 
[b][size=4]Combat Example:[/size][/b] 
 
Player is in combat.  During combat, modules (such as weapons) were changed since a preset was loaded.  Enemies board the ship, which causes the player to move crew to attack.  Afterwards, the player wants to return the crew to their weapons as well as return the crew to their spread out locations so a single hit doesn't kill them.
 
The user can reload the preset, but the module changes and power settings will be reverted.  With this mod, Right Clicking the preset will move the crew back to the preset's locations without affecting power or modules.
 
[b][size=5]Compatibility[/size][/b] 
[list]
[*]Some mods instruct the user to overwrite the game's original files.  This mod may not be compatible with those mods.
[list]
[*]This mod does not affect the original game files.
[/list][*]Safe to add and remove from existing saves.
[/list] 
[b][size=5]Support[/size][/b] 
 
If you enjoy my mods and want to buy me a coffee, check out my [url=https://ko-fi.com/nbkredspy71915]Ko-Fi[/url] page.
Thanks!
 
[b][size=5]Installation[/size][/b] 
 
This section covers how to install the BepInEx mod loader and the mod itself.
 
[b][size=4]BepInEx Setup[/size][/b] 
 
If BepInEx has already been installed, skip to the [font=Courier New]Mod Install[/font] section.
[list]
[*] Download BepInEx from [url=https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip]https://github.com/BepInEx/BepInEx/releases/download/v5.4.23.2/BepInEx_win_x64_5.4.23.2.zip[/url]
[*] Extract the contents of the BepInEx zip file into the game's directory:
[font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth[/font] [b]Important[/b]:  The .zip file [i]must[/i] be extracted to the root folder of the game.  If BepInEx was extracted correctly, the following directory will exist: [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx[/font]. A common issue is extracting the .zip with the .zip name.  Ex: [font=Courier New]BepInEx_win_x64_5.4.23.1/BepInEx[/font].  If this occurs, move the [font=Courier New]BepInEx[/font] sub directory to the game's root directory.[*]Run the game.  Once the main menu is shown, exit the game.
[*]If the install was successful, there will now be a [font=Courier New]<Game Dir>/BepInEx/plugins[/font] directory.
[/list]
 
[b][size=4]Mod Install[/size][/b] 
[list]
[*]Download the LoadCrewOnly.zip.
[list]
[*]If on Nexumods.com, download from the Files tab.
[*]Otherwise, download from [url=https://github.com/NBKRedSpy/STTE-LoadCrewOnly/releases/]https://github.com/NBKRedSpy/STTE-LoadCrewOnly/releases/[/url]
[/list][*]Extract the contents of the zip file into the [font=Courier New]<Game Dir>/BepInEx/plugins[/font] folder.
[*]Run the Game.  The mod will now be enabled.
[/list]
 
[b][size=5]Uninstalling[/size][/b] 
 
[b][size=4]Uninstalling This Mod Only[/size][/b] 
 
This method removes this mod, but keeps the BepInEx mod loader and any other mods.
 
Delete the directory [font=Courier New]<Steam Directory>\steamapps\common\Shortest Trip to Earth\BepInEx\plugins\LoadCrewOnly[/font].
 
[b][size=4]Uninstall the Mod and BepInEx[/size][/b] 
 
This resets the game to an unmodded state by deleting BepInEx and any BepInEx mods.
 
Delete the following files and folders in the game's directory:
[code]
BepInEx  (<-- Folder)
.doorstop_version
changelog.txt
doorstop_config.ini
winhttp.dll
[/code]
 
[b][size=5]Change Log[/size][/b] 
 
[b][size=4]1.0.0[/size][/b] 
[list]
[*]Release
[/list]
 
[b][size=5]Source Code[/size][/b] 
 
Source code is available on GitHub at [url=https://github.com/NBKRedSpy/STTE-LoadCrewOnly]https://github.com/NBKRedSpy/STTE-LoadCrewOnly[/url]
