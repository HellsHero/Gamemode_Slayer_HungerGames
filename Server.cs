//      __ __    __  __      ____      __  __                
//     / // /   / / / /___  / / /_____/ / / /___  _________ 
//    / // /   / /_/ // _ \/ / // ___/ /_/ // _ \/ ___/ __ \ 
//   / // /   / __  //  __/ / /(__  ) __  //  __/ /  / /_/ / 
//  /_//_/   /_/ /_/ \___/_/_//____/_/ /_/ \___/_/   \____/

%error = forceRequiredAddon("Gamemode_Slayer");
if(%error == $Error::Addon_NotFound)
	error("ERROR: Gamemode_Slayer_HungerGames - Required add-on Gamemode_Slayer not found!");
else
	exec("./Gamemode_HungerGames.cs");