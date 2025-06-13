---
title: Template Directory Description (.Vsdir) Files
description: Learn how a template directory description file enables Visual Studio IDE to display folders, .vsz files, and templates that are associated with your project.
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- .vsdir files
- VSDIR files
- template directory description files
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Template Directory Description (.Vsdir) Files

A template directory description file (.vsdir) is a text file that enables the integrated development environment (IDE) to display folders, wizard .vsz files, and template files that are associated with your project in dialog boxes. The contents include one record per file or folder. All .vsdir files in a referenced location are merged, although only one .vsdir file is generally provided to describe multiple folders, wizards, or template files.

 Folders (subdirectories), files that are referenced in the .vsdir file, and the .vsdir file itself are all located in the same directory. When the IDE runs a wizard or displays a folder or file in the **New Project** or **Add New Item** dialog boxes, the IDE examines the directory that contains the executed files to determine whether a .vsdir file is present. If a .vsdir file is found, the IDE reads it to determine whether it contains an entry for the executed or displayed folder or file. If an entry is found, the IDE uses the information in the execution of the wizard or display of the content.

 The following code example is from the file SourceFiles.vsdir in the \<EnvSDK>\BscPrj\BscPrj\BscPrjProjectItems\Source_Files registry key:

```
HeaderFile.h|{E59935A1-6156-11d1-87A6-00A0C91E2A46}|#125|130|#126|0|0|0|#127
SourceFile.cpp|{E59935A1-6156-11d1-87A6-00A0C91E2A46}|#122|110|#123|0|0|0|#124
```

 In this case, two records are in one file. A new line (carriage return character) separates each record. Each line represents a different file type. A pipe (&#124;) character separates fields in each record. A single directory can contain multiple .vsdir files that have different file names, or you can have one .vsdir file for each file type.

## Fields
 The following table lists the fields specified for each record.

| Field | Description |
| - | - |
| Relative Path Name (RelPathName) | The name of the folder, template, or .vsz file, such as HeaderFile.h or MyWizard.vsz. This field can also be a name used to represent a folder. |
| {clsidPackage} | The GUID of the VSPackage that enables access to localized strings, such as LocalizedName, Description, IconResourceId, and SuggestedBaseName, in the VSPackage's satellite dynamic link library (DLL) resources. IconResourceId applies if DLLPath is not supplied. **Note:**  This field is optional unless one or more of the previous fields is a resource identifier. This field is typically blank for .vsdir files that correspond with third-party wizards that do not localize their text. |
| LocalizedName | The localized name of the template file or wizard. This field can be a string or a resource identifier of the form "#ResID". This name is displayed in the **Add New Item** dialog box. **Note:**  If LocalizedName is a resource identifier, then {clsidPackage} is required. |
| SortPriority | An integer representing the relative priority of this template file or wizard. For example, if this item has a value of 1, then this item is displayed next to other items with a value of 1 and ahead of all items with a sort value of 2 or larger.<br /><br /> Sort priority is relative to the items in the same directory. There may be more than one .vsdir file in the same directory. In that case, the items from all <em>.</em>vsdir files in that directory are merged. Items with same priority are listed in case-insensitive lexicographic order of the displayed name. The `_wcsicmp` function is used to order the items.<br /><br /> Items not described in .vsdir files include a priority number larger than the highest priority number listed in the .vsdir files. The result is that these items are at the end of the displayed list regardless of their name. |
| Description | The localized description of the template file or wizard. This field can be a string or a resource identifier of the form "#ResID". This string appears in the **New Project** or **Add New Item** dialog box when the item is selected. |
| DLLPath or {clsidPackage} | Used to load an icon for the template file or wizard. The icon is loaded as a resource out of a .dll or .exe file by using the IconResourceId. This .dll or .exe file can be identified either by using a full path or by using a GUID of a VSPackage. The implementation DLL of the VSPackage is used to load the icon (not the satellite DLL). |
| IconResourceId | The resource identifier in the DLL or VSPackage implementation DLL that determines the icon to display. |
| Flags (<xref:Microsoft.VisualStudio.Shell.Interop.__VSDIRFLAGS>) | Used to disable or enable the **Name** and **Location** fields on the **Add New Item** dialog box. The value of the **Flags** field is the decimal equivalent of the combination of required bit flags.<br /><br /> When a user selects an item on the **New** tab, the project determines whether the Name field and the Location field are shown when the **Add New Item** dialog box is first displayed. An item, through a .vsdir file, can control only whether the fields are enabled versus disabled when the item is selected. |
| SuggestedBaseName | Represents the default name for the file, wizard, or template. This field is either a string or a resource identifier of the form "#ResID". The IDE uses this value to provide a default name for the item. This base value is appended with an integer value to make the name unique, such as MyFile21.asp.<br /><br /> In the previous list, Description, DLLPath, IconResourceId, Flags, and SuggestedBaseNumber apply only to template and wizard files. These fields do not apply to folders. This fact is illustrated in the code in the BscPrjProjectItems file in the \<EnvSDK>\BscPrj\BscPrj\BscPrjProjectItems registry key. This file contains three records (one for each folder) with four fields for each record: RelPathName, {clsidPackage}, LocalizedName, and SortPriority.<br /><br /> `General&#124;{E59935A1-6156-11d1-87A6-00A0C91E2A46}&#124;#110&#124;100`<br /><br /> `Source_Files&#124;{E59935A1-6156-11d1-87A6-00A0C91E2A46}&#124;#111&#124;110`<br /><br /> `Env&#124;{E59935A1-6156-11d1-87A6-00A0C91E2A46}&#124;#112&#124;120` |

 When you create a wizard file, you should also consider the following issues.

- Any non-required field for which there is no meaningful data should contain a 0 (zero) as a placeholder.

- If no localized name is provided, the relative path name is used in the wizard file.

- DLLPath overrides clsidPackage for icon location.

- If no icon is defined, the IDE substitutes the default icon for a file that has that extension.

- If no suggested base name is provided, 'Project' is used.

- If you delete the .vsz files, folders, or template files, you must also remove their associated records from the .vsdir file.

## Related content
- [Wizards](../../extensibility/internals/wizards.md)
- [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md)
