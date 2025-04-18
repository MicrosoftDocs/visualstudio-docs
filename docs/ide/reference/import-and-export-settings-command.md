---
description: "Imports, exports, or resets Visual Studio settings. vssettings file extension"
title: Import and Export Settings command
ms.date: 05/28/2021
ms.topic: reference
f1_keywords:
- Tools.ImportandExportSettings
helpviewer_keywords:
- Tools.ImportandExportSettings
- Import and Export Settings command
ms.custom: "ide-ref"
author:Mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: general-ide
---
# Import and Export Settings command (.vssettings file)

Imports, exports, or resets Visual Studio settings file, `.vssettings`.

The file’s schema is open. Most commonly, the schema follows an XML structure where each category is a tag, which can itself contain subcategory tags. These subcategory tags can contain property value tags. While most packages use the common structure, any package in Visual Studio can contribute arbitrary XML to the file with the schema it chooses.

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

Running this command with no switches opens the **Import and Export Settings** wizard. For more information, see [Synchronize your settings](../synchronized-settings-in-visual-studio.md) and [Environment settings](../personalizing-the-visual-studio-ide.md).

## Example

The following command exports the current settings to the file `MyFile.vssettings`:

```cmd
Tools.ImportandExportSettings /export:"c:\Files\MyFile.vssettings"
```

## See also

- [Environment settings](../../ide/personalizing-the-visual-studio-ide.md)
- [Synchronize your settings](../../ide/synchronized-settings-in-visual-studio.md)
- [Personalize the Visual Studio IDE](../../ide/personalizing-the-visual-studio-ide.md)
- [Visual Studio commands](../../ide/reference/visual-studio-commands.md)
