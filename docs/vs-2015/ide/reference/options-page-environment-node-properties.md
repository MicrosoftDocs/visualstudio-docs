---
title: "Options Page, Environment Node Properties | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
helpviewer_keywords:
  - "automation [Visual Studio], controlling Tools Options"
  - "Tools Options settings, Environment node properties"
ms.assetid: 26dca41f-91fc-4ca7-9103-3da402baa1d5
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# Options Page, Environment Node Properties
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

This document describes the pages (or properties collections) that are associated with the **Environment** category, `DTE.Properties("Environment", <Property Page>)`, of the **Options** dialog box. The title of each subsection is the call that is used to access the Properties collection, and the table in each subsection lists the properties in the collection.

## General
 `DTE.Properties("Environment", "General")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|ShowStatusBar|Get/Set (Boolean)|Determines whether the status bar is visible.|
|WindowMenuContainsNItems|Get/Set (Short)|Determines how document windows are contained at the bottom of the Windows menu.|
|MRUListContainsNItems|Get/Set (Short)|Determines how many files display in the "Most Recently Used" submenu.|
|Animations|Get/Set (Boolean)|Determines whether the integrated development environment (IDE) uses animation in the status bar.|
|AnimationSpeed|Get/Set (Short)||
|AutoAdjustExperience|Get/Set (Boolean)|Automatically adjusts the visual experience depending on the client performance.|
|RichClientExperienceOptions|Get/Set (Enum)|Enables rich client visual experience with values in <xref:EnvDTE100.vsRichClientExperienceOptions>.|
|CloseButtonActiveTabOnly|Get/Set (Boolean)|Determines whether the **Close** button is shown only on the active tab.|
|AutohidePinActiveTabOnly|Get/Set (Boolean)|Determines whether the **Auto Hide** button affects only the active tab.|

## Add-in/Macros Security
 `DTE.Properties("Environment", "AddinMacrosSecurity")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|MacrosEnabled|Get/Set (Boolean)|Allows macros to run.|
|AddinsEnabled|Get/Set (Boolean)|Allows add-ins to load.|
|LoadAddinsFromTheWeb|Get/Set (Boolean)|Allows add-ins to load from a URL on the Web.|

## Documents
 `DTE.Properties("Environment", "Documents")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|ReuseSavedActiveDocWindow|Get/Set (Boolean)|Determines whether opening a new file reuses the current document window if the current document is saved. `false` means always open a new document window for each document opened.|
|DetectFileChangesOutsideIDE|Get/Set (Boolean)|Determines whether the environment automatically reloads files opened in the IDE when the operating system notifies the IDE that the files have been modified on disk.|
|AutoloadExternalChanges|Get/Set (Boolean)|Determines whether detected external modifications to open documents automatically reload the modified file if the open document is not modified. If the open document is modified and this property is `true`, then the IDE prompts as if this property were `false`.|
|InitializeOpenFileFromCurrentDocument|Get/Set (Boolean)|Determines whether the <xref:EnvDTE.DTEClass.OpenFile%2A> command seeds the directory and file name from the last active document, or from the last place you opened a file.|
|MiscFilesProjectSavesLastNItems|Get/Set (Short)|Determines how many files the Miscellaneous Files project records. As a result, you can see what you most recently had open as a miscellaneous file on disk when you next use the IDE.|
|ShowMiscFilesProject|Get/Set (Boolean)|Determines whether the Miscellaneous Files project is shown.|
|CheckForConsisentLineEndings|Get/Set (Boolean)|Checks for consistent line endings on file load.|
|SaveDocsAsUnicodeWhenDataLoss|Get/Set (Boolean)|Saves documents as Unicode when data cannot be saved in codepage.|
|DontShowGlobalUndoChangeLossDialog|Get/Set (Boolean)|Displays a warning when global undo will modify other edited files.|
|AllowEditingReadOnlyFiles|Get/Set (Boolean)|Allows editing of read-only files, but give a warning when there is an attempt to save them.|
|DocumentDockPreference|Get/Set (Enum)|<xref:EnvDTE100.vsDocumentDockPreferenceOptions>. Position in the tab well in which to insert opened document.|

## Extension Manager
 `DTE.Properties("Environment", "ExtensionManager")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|EnableAdminExtensions|Get/Set (Boolean)|Loads per-user extensions when Visual Studio is run under Administrator credentials. Visual Studio must be restarted after this value is changed.|
|EnableOnline|Get/Set (Boolean)|Enables access to extensions on the Visual Studio Gallery.|
|AutomaticallyCheckForUpdates|Get/Set (Boolean)|Automatically checks for updates to installed extensions.|

## Find and Replace
 `DTE.Properties("Environment", "FindAndReplace")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|ShowWarningMessages|Get/Set (Boolean)|Displays warning messages.|
|InitializeFromEditor|Get/Set (Boolean)|Automatically populates the **Find What** box with text from the editor.|
|ShowMessageBoxes|Get/Set (Boolean)|Displays informational messages.|
|HideWindowsAfterMatchFromQuickFindReplace|Get/Set (Boolean)|Hides the **Find and Replace** window after a match is located by using **Quick Find** or **Quick Replace**.|

## Import and Export Settings
 `DTE.Properties("Environment", "Import and Export Settings")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|TrackTeamSettings|Get/Set (Boolean)|Uses the settings in the file specified by TeamSettingsFile.|
|TeamSettingsFile|Get/Set (String)|Name of file that has team settings.|
|AutoSaveFile|Get/Set (String)|Name of file where user settings are automatically saved.|

## International Settings
 `DTE.Properties("Environment", "International")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|Language|Get/Set (String)|LCID value for the current language for Visual Studio.|

## Keyboard
 `DTE.Properties("Environment", "Keyboard")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|Scheme|Get/Set (String)|Returns a string that contains a built-in scheme, a string containing the full path of the .vsk file that is loaded, or "(Default)" if no .vsk file is loaded.|

## Projects and Solution
 `DTE.Properties("Environment", "ProjectsAndSolution")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|OnRunOrPreview|Get/Set (String)|Determines whether the IDE saves everything before previewing or running a built project.|
|ProjectsLocation|Get/Set (String)|Determines the default directory where the **Add Project** dialog box saves new projects.|
|ShowOutputWindowBeforeBuild|Get/Set (Boolean)|Determines whether starting a build displays the **Output** window.|
|ShowTaskListAfterBuild|Get/Set (Boolean)|Determines whether an unsuccessful build operation displays the **Task List** when the build is done.|
|TrackFileSelectionInExplorer|Get/Set (Boolean)|Determines whether the current item is tracked in **Solution Explorer**.|
|AlwaysShowSolutionNode|Get/Set (Boolean)|Determines whether the solution node is displayed.|
|OnlySaveStartupProjectsAndDependencies|Get/Set (Boolean)|Determines whether save operations are limited to startup projects and their dependent files.|
|ShowAdvancedBuildConfigurations|Get/Set (Boolean)|Determines whether advanced build configurations are displayed.|
|ConcurrentBuilds|Get/Set (String)|Determines the maximum number of parallel project builds that can occur.|
|SaveNewProjects|Get/Set (Boolean)|Determines whether new projects are automatically saved after being created.|
|PromptForRenameSymbol|Get/Set (Boolean)|Specifies whether to prompt for symbolic renaming when files are renamed.|
|OnRunWhenErrors|Get/Set (Enum)|Specifies the behavior on Run when a build completed with errors.|
|OnRunWhenOutOfDate|Get/Set (Enum)|Specifies the behavior on Run when a project is out of date.|
|ProjectTemplatesLocation|Get/Set (String)|Directory that contains user project templates.|
|ProjectItemTemplatesLocation|Get/Set (String)|Directory that contains user item templates.|
|DefaultBehaviorForStartupProjects|Get/Set (String)||
|MSBuildOutputVerbosity|Get/Set (String)|Specifies the level of verbosity for Build output.|

## Startup
 `DTE.Properties("Environment", "Startup")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|OnStartUp|Get/Set (Enum)|Action to take at startup, from <xref:EnvDTE.vsStartUp>, with values 0 through 5:<br /><br /> -   0: Open Home Page<br />-   1: Load last loaded solution<br />-   2: Show **Open Project** dialog box<br />-   3: Show **New Project** dialog box<br />-   4: Show empty environment<br />-   5: Show Start Page|
|StartPageRSSUrl|Get/Set (String)|URL for the RSS feed that is used at startup.|
|StartPageRefreshDownloadedContent|Get/Set (Boolean)|Refreshes the Start Page after every passage of the interval specified in StartPageRefreshInterval.|
|StartPageRefreshInterval|Get/Set (Short)|Interval in minutes to refresh the Start Page.|

## TaskList
 `DTE.Properties("Environment", "TaskList")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|ConfirmTaskDeletion|Get/Set (Boolean)|Specifies whether a confirmation box displays when deleting tasks from the **Task List**.|
|WarnOnAddingHiddenItem|Get/Set (Boolean)|Specifies whether you are warned when adding a user task that will not be shown.|
|DontShowFilePaths|Get/Set (Boolean)|Specifies whether to show full file paths in the Task List.|
|CommentTokens|SafeArray|Returns a SafeArray of comment token values. Each has the fields, `Name` (string) and `Priority` (<xref:EnvDTE.vsTaskPriority>, High, Medium, or Low).|

## Web Browser
 `DTE.Properties("Environment", "WebBrowser")`

|Property Item Name|Value|Description|
|------------------------|-----------|-----------------|
|HomePage|Get/Set (String)|Represents the home page URL.|
|SearchPage|Get/Set (String)|Represents the search page URL.|
|ViewSourceIn|Get/Set (Enum)|<xref:EnvDTE.vsBrowserViewSource> (Source, Design, External).|
|ViewSourceExternalProgram|Get/Set (String)|The path of the external source viewer.|

## See Also
 [Controlling Options Settings](https://msdn.microsoft.com/library/a09ed242-7494-4cde-bbd1-7a8ec617965d)
 [Determining the Names of Property Items on Options Pages](https://msdn.microsoft.com/library/d450422d-47c7-4eeb-9f9f-3286264bc5aa)
 [Options Page, Fonts and Colors Node Properties](../../ide/reference/options-page-fonts-and-colors-node-properties.md)
 [Options Page, Text Editor Node Properties](../../ide/reference/options-page-text-editor-node-properties.md)
 [Environment Options Dialog Box](../../ide/reference/environment-options-dialog-box.md)
