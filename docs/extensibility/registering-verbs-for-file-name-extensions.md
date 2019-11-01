---
title: "Registering Verbs for File Name Extensions | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
helpviewer_keywords:
  - "verbs, registering"
ms.assetid: 81a58e40-7cd0-4ef4-a475-c4e1e84d6e06
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Register verbs for file name extensions
The association of a file name extension with an application generally has a preferred action that occurs when a user double-clicks a file. This preferred action is linked to a verb, for example open, that corresponds to the action.

 You can register verbs that are associated with a programmatic identifier (ProgID) for an extension by using the Shell key located at **HKEY_CLASSES_ROOT\{progid}\shell**. For more information, see [File types](/windows/desktop/shell/fa-file-types).

## Register standard verbs
 The operating system recognizes the following standard verbs:

- Open

- Edit

- Play

- Print

- Preview

  Whenever possible, register a standard verb. The most common choice is the Open verb. Use the Edit verb only if there is a clear difference between opening the file and editing the file. For example, opening an *.htm* file displays it in the browser, whereas editing an *.htm* file starts an HTML editor. Standard verbs are localized with the operating system locale.

> [!NOTE]
> When registering standard verbs, do not set the default value for the Open key. The default value contains the display string on the menu. The operating system supplies this string for standard verbs.

 Project files should be registered to start a new instance of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)] when a user opens the file. The following example illustrates a standard verb registration for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] project.

```
[HKEY_CLASSES_ROOT\.csproj]
@="VisualStudio.csproj.8.0"

[HKEY_CLASSES_ROOT\.csproj\OpenWithList]
[HKEY_CLASSES_ROOT\.csproj\OpenWithList\VSLauncher.exe]
@=""

[HKEY_CLASSES_ROOT\.csproj\OpenWithProgids]
"VisualStudio.csproj.8.0"=""

[HKEY_CLASSES_ROOT\Applications\VSLauncher.exe]
[HKEY_CLASSES_ROOT\Applications\VSLauncher.exe\Shell]
[HKEY_CLASSES_ROOT\Applications\VSLauncher.exe\Shell\Open]
[HKEY_CLASSES_ROOT\Applications\VSLauncher.exe\Shell\Open\Command]
@="C:\\Program Files\\Common Files\\Microsoft Shared\\MSEnv\\VSLauncher.exe \"%1\""

[HKEY_CLASSES_ROOT\VisualStudio.csproj.8.0]
@="C# Project file"

[HKEY_CLASSES_ROOT\VisualStudio.csproj.8.0\DefaultIcon]
@="C:\\VisualStudioPath\\VC#\\VCSPackages\\csproj.dll,0"

[HKEY_CLASSES_ROOT\VisualStudio.csproj.8.0\shell]
[HKEY_CLASSES_ROOT\VisualStudio.csproj.8.0\shell\Open]
[HKEY_CLASSES_ROOT\VisualStudio.csproj.8.0\shell\Open\Command]
@="\"C:\\Program Files\\Common Files\\Microsoft Shared\\MSEnv\\VSLauncher.exe\" \"%1\""
```

 To open a file in an existing instance of [!INCLUDE[vsprvs](../code-quality/includes/vsprvs_md.md)], register a DDEEXEC key. The following example illustrates a standard verb registration for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] *.cs* file.

```
[HKEY_CLASSES_ROOT\.cs]
@="VisualStudio.cs.8.0"

[HKEY_CLASSES_ROOT\.cs\OpenWithList]
[HKEY_CLASSES_ROOT\.cs\OpenWithList\devenv.exe]
@=""

[HKEY_CLASSES_ROOT\.cs\OpenWithProgids]
"VisualStudio.cs.8.0"=""

[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0]
@="C# Source file"

[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0\DefaultIcon]
@="C:\\VisualStudioPath\\VC#\\VCSPackages\\csproj.dll,1"

[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0\shell]
[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0\shell\Open]
[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0\shell\Open\Command]
@="\"C:\\VisualStudioPath\\Common7\\IDE\\devenv.exe\" /dde \"%1\""

[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0\shell\Open\ddeexec]
@="Open(\"%1\")"

[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0\shell\Open\ddeexec\Application]
@="VisualStudio.8.0"

[HKEY_CLASSES_ROOT\VisualStudio.cs.8.0\shell\Open\ddeexec\Topic]
@="system"
```

## Set the default verb
 The default verb is the action that is executed when a user double-clicks a file in Windows Explorer. The default verb is the verb specified as the default value for the **HKEY_CLASSES_ROOT\\*progid*\Shell** key. If no value is specified, the default verb is the first verb specified in the **HKEY_CLASSES_ROOT\\*progid*\Shell** key list.

> [!NOTE]
> If you plan to change the default verb for an extension in a side-by-side deployment, consider the impact on installation and removal. During installation the original default value is overwritten.

## See also
- [Manage side-by-side file associations](../extensibility/managing-side-by-side-file-associations.md)
