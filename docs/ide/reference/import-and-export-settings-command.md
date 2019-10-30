---
title: Import and Export Settings command
ms.date: 11/21/2018
ms.topic: reference
f1_keywords:
  - "Tools.ImportandExportSettings"
helpviewer_keywords:
  - "Tools.ImportandExportSettings"
  - "Import and Export Settings command"
ms.assetid: 94a06468-a44d-403d-a931-77bbc9d06e56
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Import and Export Settings command

Imports, exports, or resets Visual Studio settings.

## Syntax

```cmd
Tools.ImportandExportSettings [/export:filename | /import:filename | /reset]
```

## Switches

/export:`filename`

Optional. Exports the current settings to the specified file.

/import:`filename`

Optional. Imports the settings in the specified file.

/reset

Optional. Resets the current settings.

## Remarks

Running this command with no switches opens the **Import and Export Settings** wizard. For more information, see [Synchronize your settings](../synchronized-settings-in-visual-studio.md) and [Environment settings](../environment-settings.md).

## Example

The following command exports the current settings to the file `MyFile.vssettings`:

```cmd
Tools.ImportandExportSettings /export:"c:\Files\MyFile.vssettings"
```

## See also

- [Environment settings](../../ide/environment-settings.md)
- [Synchronize your settings](../../ide/synchronized-settings-in-visual-studio.md)
- [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)
- [Visual Studio commands](../../ide/reference/visual-studio-commands.md)