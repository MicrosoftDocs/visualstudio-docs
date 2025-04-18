---
title: International Settings in the Options dialog box
description: Learn how to use the International Settings page in the Environment section to change the default language when you have more than one language version of the IDE installed.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.ToolsOptionsPages.Environment.InternationalSettings
- VS.ToolsOptionsPages.Environment.International_Settings
- VS.Environment.International Settings
helpviewer_keywords:
- International Settings dialog box
- languages, environment settings
- Options dialog box, international settings
- languages, specifying default
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box: Environment \> International Settings

The International Settings page lets you change the default language when you have more than one language version of the integrated development environment (IDE) installed on your machine. You can access this dialog box by selecting **Options** from the **Tools** menu and then choosing **International Settings** from the **Environment** folder.

**Language**

Lists the available languages for the installed product language versions. If multiple languages of products or a mixed language installation of products share the environment, the language selection is changed to **Same as Microsoft Windows**.

> [!CAUTION]
> In a system with multiple languages installed, the Visual C++ build tools (cl.exe, link.exe, nmake.exe, bscmake.exe and related files) are not affected by this setting. These tools use the version for the last language installed. The build tools for the previously installed language are overwritten because the Visual C++ build tools do not use the satellite DLL model.

### See also

- [Install language packs](../../install/install-visual-studio.md#step-6---install-language-packs-optional)
