---
title: Registering Project and Item Templates
description: Learn how Visual Studio uses registration information for your project types to determine what to show in the Add New Project and Add New Item dialog boxes.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- projects [Visual Studio SDK], adding items
- registry, Add New Item dialog box
- Add New Item dialog box
- Add New Project dialog box
- registry, Add New Project dialog box
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Registering Project and Item Templates

Project types must register the directories where their project and project-item templates are located. Visual Studio uses the registration information associated with your project types to determine what to show in the **Add New Project** and **Add New Item** dialog boxes.

 For more information about templates, see [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md).

## Registry Entries for Projects
 The following examples show registry entries under HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\\<*Version*>. The accompanying tables explain the elements used in the examples.

```
[Projects\{ProjectGUID}]
@="MyProjectType"
"DisplayName"="#2"
"Package"="{VSPackageGUID}"
"ProjectTemplatesDir"="C:\\MyProduct\\MyProjectTemplates"
```

|Name|Type|Description|
|----------|----------|-----------------|
|@|REG_SZ|Default name of projects of this kind.|
|DisplayName|REG_SZ|Resource ID of the name to be retrieved from the satellite DLL registered under Packages.|
|Package|REG_SZ|Class ID of the package registered under Packages.|
|ProjectTemplatesDir|REG_SZ|Default path of the Project Template files. The Project Template files are displayed by the **New Project** template.|

### Registering Item Templates
 You must register the directory where you store item templates.

```
[Projects\{ProjectGUID}\AddItemTemplates\TemplateDirs\{VSPackageGUID}\1]
@="#7"
"TemplatesDir"="C:\\MyProduct\\MyProjectItemTemplates "
"TemplatesLocalizedSubDir"="#10"
"SortPriority"=dword:00000064
```

| Name | Type | Description |
|--------------------------|-----------| - |
| @ | REG_SZ | Resource ID for Add Item templates. |
| TemplatesDir | REG_SZ | Path of the project items displayed in the dialog box for the **Add New Item** wizard. |
| TemplatesLocalizedSubDir | REG_SZ | Resource ID of a string that names the subdirectory of TemplatesDir that holds localized templates. Because Visual Studio loads the string resource from satellite DLLs if you have them, each satellite DLL can contain a different localized subdirectory name. |
| SortPriority | REG_DWORD | Set SortPriority to govern the order in which templates are displayed in the **Add New Item** dialog box. Larger SortPriority values appear earlier in the template list. |

### Registering file filters
 Optionally, you can register filters that Visual Studio uses when it prompts for file names. For example, the Visual C# filter for the **Open File** dialog box is:

 **Visual C# Files (\*.cs,\*.resx,\*.settings,\*.xsd,\*.wsdl);\*.cs,\*.resx,\*.settings,\*.xsd,\*.wsdl)**

 To support registration of multiple filters, each filter is registered in its own subkey under HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\\<*Version*>\Projects\\{\<*ProjectGUID*>}\Filters\\<*Subkey*>. The subkey name is arbitrary; Visual Studio ignores the subkey's name and uses just its values.

 You can control the contexts in which a filter is used by setting flags, shown in the following table. If a filter does not have any flags set, it will be listed after the common filters in the **Add Existing Item** dialog box and the **Open File** dialog box, but it will not be used in the **Find in Files** dialog box.

```
[Projects\{ProjectGUID}\Filters\MyLanguageFilter]
@="#3"
"CommonOpenFilesFilter"=dword:00000000
"CommonFindFilesFilter"=dword:00000000
"FindInFilesFilter"=dword:00000000
"NotOpenFileFilter"=dword:00000000
"NotAddExistingItemFilter"=dword:00000000
"SortPriority"=dword:00000064
```

|Name|Type|Description|
|----------|----------|-----------------|
|CommonFindFilesFilter|REG_DWORD|Makes the filter one of the common filters in the **Find in Files** dialog box. Common filters are listed in the filter list before filters not marked as common.|
|CommonOpenFilesFilter|REG_DWORD|Makes the filter one of the common filters in the **Open File** dialog box. Common filters are listed in the filter list before filters not marked as common.|
|FindInFilesFilter|REG_DWORD|Lists the filter after the common filters in the **Find in Files** dialog box.|
|NotOpenFileFilter|REG_DWORD|Indicates that the filter is not used in the **Open File** dialog box.|
|NotAddExistingItemFilter|REG_DWORD|Indicates that the filter is not used in the **Add Existing Item** dialog box.|
|SortPriority|REG_DWORD|Set SortPriority to govern the order in which filters are displayed. Larger SortPriority values appear earlier in the filter list.|

## Directory Structure
 VSPackages can put template files and folders anywhere on a local or remote disk, as long as the location is registered through the integrated development environment (IDE). However, for ease of organization, we recommend the following directory structure under your product's installation path.

 \Templates

 \Projects (contains the project templates)

 \Applications

 \Components

 \ ...

 \ProjectItems (contains the project items)

 \Class

 \Form

 \Web Page

 \HelperFiles (contains the files used in multi-file project items)

 \WizardFiles

## See also

- [Adding Project and Project Item Templates](../../extensibility/internals/adding-project-and-project-item-templates.md)
- [Wizards](../../extensibility/internals/wizards.md)
- [Localizing Applications](../../ide/globalizing-and-localizing-applications.md)
- [CATIDs for Objects That Are Typically Used to Extend Projects](../../extensibility/internals/catids-for-objects-that-are-typically-used-to-extend-projects.md)
