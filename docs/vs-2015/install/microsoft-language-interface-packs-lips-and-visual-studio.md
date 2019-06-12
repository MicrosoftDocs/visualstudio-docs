---
title: "Microsoft Language Interface Packs (LIPs) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-install"
ms.topic: conceptual
helpviewer_keywords:
  - "text [Visual Studio], multiple languages"
  - "Multilingual User Interface [Visual Studio]"
  - "language switching [Visual Studio]"
  - "MUI [Visual Studio]"
  - "multiple language support [Visual Studio SDK]"
  - "Windows Multilingual User Interface"
  - "UI text language [Visual Studio]"
  - "languages, multiple language support"
ms.assetid: dc86304b-65b7-47e6-9314-1dfd02ecfa65
caps.latest.revision: 28
author: TerryGLee
ms.author: tglee
manager: jillfra
---
# Microsoft Language Interface Packs (LIPs) and Visual Studio
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

By using a Windows Language Interface Pack (LIP), you can install a language version of Windows and then install various User Interface Language Packs. User Interface Language Packs provide a localized user interface (UI) for the operating system. For example, you can install a Japanese Language Interface Pack on top of an English version of Windows and then switch the Windows UI language between Japanese and English. By using LIPs, you can have multiple language versions of Windows on one computer.

 On computers that have the LIPs and multiple language versions of Visual Studio installed, changing the Windows display language settings sets both Windows and Visual Studio when matching language packs are installed.

## Limitations of Multi-Language Installations
 When you install different language versions of Visual Studio on the same computer, you can only switch languages between matching editions. For example, if you have an English Express Edition installed, a German Express Edition installed, and a Professional Edition installed, you can only switch languages for the Express Editions, not for the Professional Edition.

 Visual Studio uses a unified language pack. To install more than one language version of these products, you must install a full language product first and then install one or more language packs.

> [!NOTE]
> Visual Studio doesn't support installing multiple language versions of the full language product on the same computer. After you install one full language product, you must add language versions by using language packs. You can still install multiple full language products of the Express editions on the same computer.

### Support for Code Pages
 Some Visual Studio tools do not display text correctly when the text contains characters that are not in the current code page. Instead, question marks appear or the text is corrupted. The following tools or areas are affected:

- Sites deployed by using FTP.

- Non-ASCII computer names in some controls.

- Command line tools that run outside of Visual Studio.

- Visual Basic Migration Wizard.

- ActiveX Control Test Container.

- OLE/COM Object Viewer.

- ISAPI Web Debug Tool.

- MFC application projects that have HTML Help content.

- Visual SourceSafe / SCCI UI falls back to English when there is an incompatible code page.

- Visual SourceSafe does not support Unicode file names.

- End User-Defined Characters (private use zone) cannot be used as tokens/identifiers.

- Latin Extended-B characters cannot be displayed in some Visual Studio tool windows when the Windows code page is set to an East Asian language.

- Text runs that consist of characters from multiple language scripts may display the default glyph for some characters.

- Copying and pasting complex script strings into common controls may cause character shaping to be lost. Instead, use the corresponding language keyboard to input text.

##### To correctly display characters that are not included in the current code page

1. Click **Start**, click **Control Panel**, and then open **Regional and Language Options** (or **Region** in [!INCLUDE[win8](../includes/win8-md.md)]).

    > [!NOTE]
    > You must be an administrator on the computer to follow these steps.

2. Click the **Advanced** tab.

3. In the **Select a language to match the language version of the non-Unicode programs you want to use** list, select the language you are currently using.

4. Click **OK**.

## Changing the Language Used for the UI Text in Visual Studio
 When you install multiple language versions of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] on the same computer, the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] UI defaults to **Same as Microsoft Windows**. This setting indicates that [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will display the UI text in the language that is specified as the display language for the operating system.

> [!NOTE]
> If Visual Studio is set to use **Same as Microsoft Windows**, and the matching Visual Studio language pack is not installed, Visual Studio will use the language of the first Visual Studio installation.

#### To set the language that is used for the UI text in Visual Studio

1. On the **Tools** menu, click **Options**.

2. In the **Options** dialog box, expand **Environment** and then click **International Settings**.

3. In the **Language** list, choose the language in which the UI text should appear in the development environment.

    To have the UI text in the IDE match the operating system display language setting, select **Same as Microsoft Windows**.

   You can also use the devenv command to set the language that's used for UI. For more information, see [/LCID (devenv.exe)](../ide/reference/lcid-devenv-exe.md).

## See Also
 [International Settings, Environment, Options Dialog Box](../ide/reference/international-settings-environment-options-dialog-box.md)