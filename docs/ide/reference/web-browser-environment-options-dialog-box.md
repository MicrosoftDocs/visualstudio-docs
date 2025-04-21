---
title: Web Browser, Environment, Options Dialog Box
description: Learn how to use the Web Browser page in the Environment section to set options for both the internal Web browser and Internet Explorer.
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- VS.Environment.Web Browser
- VS.ToolsOptionsPages.Environment.WebBrowser
- VS.ToolsOptionsPages.Environment.Web_Browser
helpviewer_keywords:
- browsers, customizing
- searching, search page for Web browser
- Web browsers, customizing
- searches, default Web browser search page
- URLs, specifying VS home page
- home page
- Options dialog box, Web settings
- Internet Explorer, setting options
ms.custom: "ide-ref"
author: anandmeg
ms.author: meghaanand
manager: mijacobs
ms.subservice: general-ide
---
# Options dialog box: Environment \> Web Browser

Sets options for both the internal Web browser and Internet Explorer. To access this dialog box, click **Options** on the **Tools** menu, expand the **Environment** folder, and select **Web Browser**.

> [!Important]
> This feature is deprecated in Visual Studio 2022 and won’t be supported going forward.
>
> For more information about Visual Studio 2022, check out our [release notes](/visualstudio/releases/2022/release-notes) and the Visual Studio [roadmap](/visualstudio/productinfo/vs-roadmap/).

> [!IMPORTANT]
> Opening certain files or components from the Web can execute code on your computer.

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Reset settings](../personalizing-the-visual-studio-ide.md#reset-all-settings).

## Home page

Sets the page displayed when you open the IDE Web Browser.

## Search page

Lets you designate a Search page for the internal Web browser. This location can differ from the search page used by instances of Internet Explorer initiated outside of the integrated development environment (IDE).

## View source in

Sets the editor used to open a Web page when you choose **View Source** on the page from the internal Web browser.

- **Source editor** Select to view source in the [editor](../../ide/writing-code-in-the-code-and-text-editor.md).

- **HTML editor** Select to view source in the [HTML designer](/previous-versions/ex0hkwbx(v=vs.140)). Use this selection to edit the Web page in one of two views: Design view or the standard text-based Source view.

- **External editor** Select to view source in another editor. Specify the path of any editor you choose, for example, Notepad.exe.

## Internet Explorer Options

Click to change options for Internet Explorer in the **Internet Properties** dialog box. Changes made in this dialog box affect both the internal Web browser and instances of Internet Explorer initiated outside of the Visual Studio IDE (for example, from the Start menu).

> [!NOTE]
> Use the **Browse With** dialog box to replace the Visual Studio internal Web browser with a browser of your choice. You can access the Browse With dialog box from the right-click or context menu of, for example, an HTML file in your project.

## See also

- [General, Environment, Options Dialog Box](../../ide/reference/general-environment-options-dialog-box.md)
- [HTML Designer](/previous-versions/ex0hkwbx(v=vs.140))
