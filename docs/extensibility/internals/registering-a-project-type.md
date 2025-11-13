---
title: Registering a Project Type
description: Learn about creating registry entries that enable Visual Studio to recognize and work with your new project type.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- projects [Visual Studio SDK], new project registry entries
- registry, new project types
- registration, new project types
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Registering a Project Type

When you create a new project type, you must create registry entries that enable Visual Studio to recognize and work with your project type. You typically create these registry entries by using a registry script (.rgs) file.

 In the example below, the statements from the registry provide default paths and data where applicable, followed by a table that contains entries from the registry script for each statement. The tables provide the script entries and additional information about the statements.

> [!NOTE]
> The following registry information is intended to be an example of the type and purposes of the entries in the registry scripts you will be writing to register your project type. Your actual entries and their uses might vary based on the specific requirements of your project type. You should review the samples available to find one that closely resembles the type of project you are developing, and then review the registry script for that sample.

 The following examples are from HKEY_CLASSES_ROOT.

## Example 1

```
\.figp
   @="FigPrjFile"
   "Content Type"="text/plain"
\.figp\ShellNew
   "NullFile"=""
\FigPrjFile
   @="Figure Project File"
\DefaultIcon
   @="<Visual Studio SDK installation path>\\9.0VSIntegration\\SomeFolder\\FigPkgs\\FigPrj\\Debug\\FigPrj.dll,-206"
\shell\open
   @="&Open in Visual Studio"
\shell\open\command
   @="devenv.exe \"%1\""
```

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|`@`|REG_SZ|`FigPrjFile`|Name and description of the project type files that have the extension .figp.|
|`Content Type`|REG_SZ|`Text/plain`|Content type for the project files.|
|`NullFile`|REG_SZ|`Null`||
|`@`|REG_SZ|`%MODULE%,-206`|Default icon used for project of this type. The %MODULE% statement is completed in the registry to the default location of the project type DLL.|
|`@`|REG_SZ|`&Open in Visual Studio`|Default application in which this project type will be opened.|
|`@`|REG_SZ|`devenv.exe "%1"`|Default command that will be run when a project of this type is opened.|

 The following examples are from HKEY_LOCAL_MACHINE and are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\99.0Exp\Packages].

## Example 2

```
\{ACEF4EB2-57CF-11D2-96F4-000000000000} (The CLSID for the VSPackage)
   @="FigPrj Project Package"
   "InprocServer32"="9.0<Visual Studio SDK installation path>\\VSIntegration\\Archive\\FigPkgs\\FigPrj\\                      Debug\\FigPrj.dll"
   "CompanyName"="Microsoft"
   "ProductName"="Figure Project Sample"
   "ProductVersion"="9.0"
   "MinEdition"="professional"
   "ID"=dword:00000001
\{ACEF4EB2-57CF-11D2-96F4-000000000000}\SatelliteDLL
   "DllName"="FigPrjUI.dll"
   "Path"="9.0<Visual Studio SDK installation path>\\VSIntegration\\Archive\\FigPkgs\\FigPrj\\Debug\\"
\{ACEF4EB2-57CF-11D2-96F4-000000000000}\Automation
   "FigProjects"=""
\{ACEF4EB2-57CF-11D2-96F4-000000000000}\AutomationEvents
   "FigProjectsEvents"="Returns the FigProjectsEvents Object"
   "FigProjectItemsEvents"="Returns the FigProjectItemsEvents Object"
```

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|`@` (Default)|REG_SZ|`FigPrj Project VSPackage`|Localizable name of this registered VSPackage (project type).|
|`InprocServer32`|REG_SZ|`%MODULE%`|Path of the project type DLL. The IDE loads this DLL and passes the VSPackage CLSID to `DllGetClassObject` to get <xref:Microsoft.VisualStudio.OLE.Interop.IClassFactory> to construct the <xref:Microsoft.VisualStudio.Shell.Interop.IVsPackage> object.|
|`CompanyName`|REG_SZ|`Microsoft`|Name of the company that developed the project type.|
|`ProductName`|REG_SZ|`Figure Project Sample`|Name for the project type.|
|`ProductVersion`|REG_SZ|`9.0`|Version number of the project type release.|
|`MinEdition`|REG_SZ|`professional`|Edition of the VSPackage being registered.|
|`ID`|REG_DWORD|`%IDS_PACKAGE_LOAD_KEY%`|The package load key for the project VSPackage. The key is validated when a project is loaded after the environment has started.|
|`DllName`|REG_SZ|`%RESOURCE_DLL%`|File name of the satellite DLL that contains localized resources for the project type.|
|`Path`|REG_SZ|`%RESOURCE_PATH%`|Path of the satellite DLL.|
|`FigProjectsEvents`|REG_SZ|See statement for value.|Determines the text string returned for this automation event.|
|`FigProjectItemsEvents`|REG_SZ|See statement for value.|Determines the text string returned for this automation event.|

 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Projects].

## Example 3

```
\{C061DB26-5833-11D2-96F5-000000000000} (The CLSID for projects of this type)
   @="FigPrj Project"
   "DisplayName"="#2"
   "Package"="{ACEF4EB2-57CF-11D2-96F4-000000000000}"
   "ProjectTemplatesDir"="C:\\Program Files\\VSIP 9.0\\EnvSDK\\FigPkgs\\                           FigPrj\\FigPrjProjects"
   "ItemTemplatesDir"="<Visual Studio SDK installation path>\\VSIntegration\\Archive9.0\\FigPkgs\\FigPrj\\                           FigPrjProjectItems"
   "DisplayProjectFileExtensions"="#3"
   "PossibleProjectExtensions"="figp"
   "DefaultProjectExtension"=".figp"
\{C061DB26-5833-11D2-96F5-000000000000}\Filters\1       (Folder 1 contains settings for Open Files filters.)
   @="#4"
   "CommonOpenFilesFilter"=dword:00000000
   "CommonFindFilesFilter"=dword:00000000
   "NotAddExistingItemFilter"=dword:00000000
   "FindInFilesFilter"=dword:00000000
   "NotOpenFileFilter"=dword:00000000
   "SortPriority"=dword:000003e8
\{C061DB26-5833-11D2-96F5-000000000000}\Filters\2
      (Folder 2 contains settings for Find in Files filters.)
   @="#5"
   "CommonOpenFilesFilter"=dword:00000000
   "CommonFindFilesFilter"=dword:00000000
   "NotAddExistingItemFilter"=dword:00000001
   "FindInFilesFilter"=dword:00000001
   "NotOpenFileFilter"=dword:00000000
   "SortPriority"=dword:000003e8
\{C061DB26-5833-11D2-96F5-000000000000}\AddItemTemplates\TemplateDirs\ {ACEF4EB2-57CF-11D2-96F4-000000000000}\1 (Second GUID indicates the registered project type for the Add Items templates.)
   @="#6"
   "TemplatesDir"="<Visual Studio SDK installation path>\\VSIntegration\\Archive9.0\\FigPkgs\\FigPrj\\                    FigPrjProjectItems"
   "SortPriority"=dword:00000064
```

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|`@`|REG_SZ|`FigPrj Project`|Default name of projects of this type.|
|`DisplayName`|REG_SZ|`#%IDS_PROJECT_TYPE%`|Resource ID of the name to be retrieved from the satellite DLL registered under Packages.|
|`Package`|REG_SZ|`%CLSID_Package%`|Class ID of the VSPackage registered under Packages.|
|`ProjectTemplatesDir`|REG_SZ|`%TEMPLATE_PATH%\FigPrjProjects`|Default path of Project Template files. These are the files displayed by the New Project template.|
|`ItemTemplatesDir`|REG_SZ|`%TEMPLATE_PATH% \FigPrjProjectItems`|Default path of Project Item Template files. These are the files displayed by the Add New Item template.|
|`DisplayProjectFileExtensions`|REG_SZ|`#%IDS_DISPLAY_PROJ_FILE_EXT%`|Enables the IDE to implement the **Open** dialog box.|
|`PossibleProjectExtensions`|REG_SZ|`figp`|Used by the IDE to determine whether the project being opened is handled by this project type (project factory). The format for more than one entry is a semicolon delimited list. For example "vdproj;vdp".|
|`DefaultProjectExtension`|REG_SZ|`.figp`|Used by the IDE as the default file name extension for the Save As operation.|
|`Filter Settings`|REG_DWORD|Various, see statements and comments following table.|These settings are used to set the various filters for displaying files in UI dialog boxes.|
|`@`|REG_SZ|`#%IDS_ADDITEM_TEMPLATES_ENTRY%`|Resource ID for Add Item templates.|
|`TemplatesDir`|REG_SZ|`%TEMPLATE_PATH%\FigPrjProjectItems`|Path of the project items displayed in the dialog box for the **Add New Item** template.|
|`SortPriority`|REG_DWORD|`100 (vcprx64)`|Determines the sort order in the tree node of files displayed in the **Add New Item** dialog box.|

 The following table shows the Filters options available in the previous code segment.

|Filter option|Description|
|-------------------|-----------------|
|`CommonFindFilesFilter`|Indicates that the filter is one of the common filters in the **Find in Files** dialog box. The common filters are listed in the filter list before the filters not marked as common.|
|`CommonOpenFilesFilter`|Indicates that the filter is one of the common filters in the **Open File** dialog box. The common filters are listed in the filter list before the filters not marked as common.|
|`FindInFilesFilter`|Indicates that the filter will be one of the filters in the **Find in Files** dialog box and will be listed after the common filters.|
|`NotOpenFileFilter`|Indicates that the filter will not be used in the **Open File** dialog box.|
|`NotAddExistingItemFilter`|Indicates that the filter will not be used in the Add **Existing Item** dialog box.|

 By default, if a filter does not have one or more of these flags set, the filter is used in the **Add Existing Item** dialog box and the **Open File** dialog box after the common filters are listed. The filter is not used in the **Find in Files** dialog box.

 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Projects].

## Example 4

```
{FE3BBBB6-72D5-11d2-9ACE-00C04F79A2A4} (The CLSID for Enterprise Projects)
\{FE3BBBB6-72D5-11d2-9ACE-00C04F79A2A4}\AddItemTemplates\TemplateDirs\ {ACEF4EB2-57CF-11D2-96F4-000000000000}\1 (CLSID for projects of this type)
   @="#7"
   "TemplatesDir"="<Visual Studio SDK installation path>\\VSIntegration\\Archive9.0\\FigPrj\\FigPrjProjects"
   "SortPriority"=dword:00000029
   "NewProjectDialogOnly"=dword:00000000
```

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|`@`|REG_SZ|`#%IDS_NEWPROJ_ TEMPLATES_ENTRY%`|Resource ID for New Project templates.|
|`TemplatesDir`|REG_SZ|`%TEMPLATE_PATH%\FigPrjProjects`|Default path for projects of the registered project type.|
|`SortPriority`|REG_DWORD|`41 (x29)`|Sets sort order of projects displayed in the New Projects wizard dialog box.|
|`NewProjectDialogOnly`|REG_DWORD|`0`|0 indicates that projects of this type are displayed only in the New Project dialog box.|

 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Projects].

## Example 5

```
\{A2FE74E1-B743-11d0-AE1A-00A0C90FFFC3} (CLSID for Miscellaneous Files projects)
   @="Miscellaneous Files Project"
\AddItemTemplates\TemplateDirs\{ACEF4EB2-57CF-11D2-96F4-000000000000}\1
                                 (CLSID for Figures Project projects)
   @="#6"
   "TemplatesDir"="<Visual Studio SDK installation path>\\VSIntegration\\Archive9.0\\FigPkgs\\FigPrj\\                    FigPrjProjectItems"
   "SortPriority"=dword:00000064
```

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|`@`|REG_SZ|None|Default value that indicates that the following entries are for the Miscellaneous Files projects entries.|
|`@`|REG_SZ|`#%IDS_ADDITEM_TEMPLATES_ENTRY%`|Resource ID value for the Add New Items template files.|
|`TemplatesDir`|REG_SZ|`%TEMPLATE_PATH%\FigPrjProjectItems`|Default path of the items that will be displayed in the **Add New Item** dialog box.|
|`SortPriority`|REG_DWORD|`100 (vcprx64)`|Establishes sort order for display in the tree node of the **Add New Item** dialog box.|

 The following example is located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\Menus].

## Example 6

```
"{ACEF4EB2-57CF-11D2-96F4-000000000000}"=",1000,1"
```

 The menu entry points the IDE to the resource used to retrieve the menu information. When this data has been merged into the menu database, the same key will be added in the MenusMerged section of the registry. The VSPackage should not modify anything under the MenusMerged section directly. In the Data field in the following table, there are three comma-separated-fields. The first field identifies a full path of a menu resource file:

- If the first field is omitted, the menu resource is loaded from the satellite DLL identified by the VSPackage GUID.

  The second field identifies a menu resource ID of the type CTMENU:

- If the resource ID is specified, and the file path is supplied by the first parameter, a menu resource is loaded from the full file path.

- If the resource ID is provided, but the file path is not, the menu resource is loaded from the satellite DLL.

- If the full file path is provided and the resource ID omitted, the file to be loaded is expected to be a CTO file.

  The last field identifies the version number for the CTMENU resource. You can merge the menu again by changing the version number.

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|%CLSID_Package%|REG_SZ|`,1000,1`|The resource to retrieve the menu information.|

 All the following examples are located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\NewProjectTemplates].

```
\TemplateDirs\{ACEF4EB2-57CF-11D2-96F4-000000000000}\1                (CLSID for Figures Project projects)
   @="#7"
   "TemplatesDir"="<Visual Studio SDK installation path>\\VSIntegration\\Archive9.0\\FigPkgs\\FigPrj\\FigPrjProjects"
   "SortPriority"=dword:00000029
   "NewProjectDialogOnly"=dword:00000000
```

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|`@`|REG_SZ|`#%IDS_NEWPROJ_TEMPLATES_ENTRY%`|Resource ID value for the Figures Project New Project templates.|
|`TemplatesDir`|REG_SZ|`%TEMPLATE_PATH%\FigPrjProjects`|Default path of the New Projects directory. Items in this directory will be displayed in the **New Project wizard** dialog box.|
|`SortPriority`|REG_DWORD|`41 (x29)`|Establishes the order in which projects will be displayed in the tree node of the **New Project** dialog box.|
|`NewProjectDialogOnly`|REG_DWORD|`0`|0 indicates that projects of this type are displayed only in the **New Project** dialog box.|

 The following example is located in the registry under the key [HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\9.0Exp\InstalledProducts].

```
\FiguresProductSample
   "Package"="{ACEF4EB2-57CF-11D2-96F4-000000000000}"
   "UseInterface"=dword:00000001
```

|Name|Type|Data|Description|
|----------|----------|----------|-----------------|
|`Package`|REG_SZ|`%CLSID_Package%`|Class ID of the registered VSPackage.|
|`UseInterface`|REG_DWORD|`1`|1 indicates that the UI will be used to interact with this project. 0 indicates that there is no UI interface.|

 The.vsz files that control new project types frequently contain a RELATIVE_PATH entry. This path is relative to path specified under \ProductDir entry of the project type in the following Setup key:

 HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\7.0Exp\Setup

 For example, the Enterprise Frameworks project templates add the following registry entries:

 HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\VisualStudio\7.0Exp\Setup\EF\ProductDir = C:\Program Files\Microsoft Visual Studio\EnterpriseFrameworks\

 That means if you include a PROJECT_TYPE=EF entry in the .vsz file, the environment finds your .vsz files in the ProductDir directory specified previously.

## Related content
- [Checklist: Creating New Project Types](../../extensibility/internals/checklist-creating-new-project-types.md)
- [Elements of a Project Model](../../extensibility/internals/elements-of-a-project-model.md)
- [Creating Project Instances By Using Project Factories](../../extensibility/internals/creating-project-instances-by-using-project-factories.md)
