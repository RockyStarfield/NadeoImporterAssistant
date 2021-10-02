Nadeo Importer Assistant

by Rocky ★


	=== REQUIREMENTS ===

	-	x64 .NET 3.1 or higher

	-	NadeoImporter.exe with its DLL and MaterialLib
		You should have it if you used Importer before, if not:   
		https://doc.trackmania.com/nadeo-importer/01-download-and-install/


	=== INSTALLATION ===

	-	Copy "ImporterAssist.exe" into Trackmania installation folder
		(same directory as NadeoImporter)

		For convenience, create a shortcut and use it from anywhere



	=== USING ASSISTANT ===


	--- BASICS ---


	-	"Trackmania folder"

		Select your local Trackmania folder in "Documents" 

		Saved between sessions, You can forget about it after the initial set up


	-	"Sub-folder"

		Sub-folder in which your Item/Mesh will be created

		You can select an already existing folder or create a completely new one 
		(or a whole tree of folders, i.e. Folder1/Foilder2/MyFolder...)  

		Leaving it empty will put your Item/Mesh in the root of "Items" directory


	-	"FBX file to import" 

		Select FBX file from anywhere in the system — 
		a copy will be created in your TM/Work/Items folder

		Supports Drag&Drop


	-	"Clean Import"

		With this option checked no accompanying files and folders will be left in the Work folder 


	-	"Materials"

		Using buttons on the right (Add, Remove, Edit) set up your list of materials
		Each "Name" should be the same as Material name in your FBX model

		If you have any custom materials set up in MaterialLib they will appear
		in Material selector as well


	-	"Import as" box

		*	Item

			Imports FBX as an Item
			Won’t be editable in mesh modeler


		*	Mesh

			Imports FBX as a combo of .Mesh and .Shape files
			.Mesh can be imported into Mesh modeler as Crystal


	--- PROPERTIES ---


	-	"Author Name" 

		Displayed Author name, only applies to Items


	-	"Scale"

		Scale mesh up or down on Import
		Default is 1


	--- ITEM PROPERTIES ---


	*	The same properties that you set up in "Placement Parameters" in the game
		Can be completely ignored and set up later inside Item editor in TM

		Leave fields empty for default values 



	-	"Clear" button

		Clears all values inside "Item properties" box



	--- AUTOSAVING ---

	*	"Trackmania folder", "Sub-folder", "Clean Import" choice, "Author Name" and 
		all of the "Item Properties" are saved between sessions

		To save Materials use "Save Preset" button



	=== MAIN BUTTONS ====



	--- Quick Import ---

		Using all of the parameters you have set up 
		creates all of the necessary files in your TM\Work folder 
		and then runs NadeoImporter process



	--- Prepare Only ---

		Creates XML files as well as a copy of FBX inside your TM\Work folder
		Doesn't run NadeoImporter process

		Can be useful if you want to manually edit XMLs and add special properties 
		(like Lights or Pivot Positions) that are outside of Importer Assistant's scope



	--- Importer Only ---

		Launches a window that acts purely like an interface for Importer, replacing command line 

		Select a file that is already in place with all its XMLs inside TM\Work folder

		Clicking "Run" will simply launch NadeoImporter process with selected parameters
		(NadeoImporter [Mode] [File] [LogMeshStats])



	--- Open Items Folder ---

		Launches new explorer window with your local Items folder



	--- Save Preset ---

		Saves current configuration of both Materials and Item Properties into a file 



	--- Load Preset ---

		Loads configuration from previously created .preset file



If you have any questions about NadeoImporter, Mesh Modeler or 
other Trackmania related stuff, join Trackmania Scenery Hub:

https://discord.gg/yMSnpjUPEG


Message me directly if you got any suggestions or feedback 
regarding this program

—  Rocky ★
