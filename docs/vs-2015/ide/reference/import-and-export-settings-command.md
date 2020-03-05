---
title: "Import and Export Settings Command | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords:
  - "Tools.ImportandExportSettings"
helpviewer_keywords:
  - "Tools.ImportandExportSettings"
  - "Import and Export Settings command"
ms.assetid: 94a06468-a44d-403d-a931-77bbc9d06e56
caps.latest.revision: 12
author: jillre
ms.author: jillfra
manager: jillfra
---
# Import and Export Settings Command
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

Imports, exports, or resets [!INCLUDE[vsprvs](../../includes/vsprvs-md.md)] settings.

## Syntax

```
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
 Running this command with no switches opens the **Import and Export Settings** wizard. For more information, see [How to: Share Settings Between Computers or Visual Studio Versions](https://msdn.microsoft.com/1131fb10-35c1-42da-9cd8-91aa3235b882).

## Example
 The following command exports the curent settings to the file `MyFile.vssettings`.

```
Tools.ImportandExportSettings /export:"c:\Files\MyFile.vssettings"
```

## See Also
 [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3)
 [Visual Studio Commands](../../ide/reference/visual-studio-commands.md)
