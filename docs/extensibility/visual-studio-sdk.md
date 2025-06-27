---
title: What is the Visual Studio SDK?
description: Explore the Visual Studio SDK to add features and extend options in the Visual Studio IDE, including menus, commands, and IntelliSense.
ms.date: 11/04/2016
ms.topic: conceptual
f1_keywords:
- VSSDK.v90.StartPage
helpviewer_keywords:
- Visual Studio SDK
- VSSDK (see Visual Studio SDK)
- Visual Studio, SDK
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Visual Studio SDK

The Visual Studio SDK helps you extend Visual Studio features or integrate new features into Visual Studio. You can distribute your extensions to other users, as well as to the Visual Studio Marketplace. The following are some of the ways in which you can extend Visual Studio:

- Add commands, buttons, menus, and other UI elements to the IDE

- Add tool windows for new functionality

- Extend IntelliSense for a given language, or provide IntelliSense for new programming languages

- Use light bulbs to provide hints and suggestions that help developers write better code

- Enable support for a new language

- Add a custom project type

- Reach millions of developers via the Visual Studio Marketplace

  If you've never written a Visual Studio extension before, you should find more information about these features and at [Starting to develop Visual Studio extensions](../extensibility/starting-to-develop-visual-studio-extensions.md).

## Install the Visual Studio SDK
 The Visual Studio SDK is an optional feature in Visual Studio setup. You can also install the VSSDK later on. For more information, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## What's new in the Visual Studio SDK
 The Visual Studio SDK has some new features such as the synchronously autoloaded extensions warning and VSIX v3 format as well as breaking changes, which may require you to update your extension. For more information, see [What's new in the Visual Studio 2019 SDK](../extensibility/whats-new-visual-studio-2019-sdk.md) and [What's new in the Visual Studio 2017 SDK](/previous-versions/visualstudio/visual-studio-2017/extensibility/what-s-new-in-the-visual-studio-2017-sdk).

## Visual Studio user experience guidelines
 Get great tips for designing the UI for your extension in [Visual Studio user experience guidelines](../extensibility/ux-guidelines/visual-studio-user-experience-guidelines.md).

 You can also learn how to make your extension look great on high DPI devices with the [Address DPI issues](../extensibility/addressing-dpi-issues2.md) article.

 Take advantage of the [Image service and catalog](../extensibility/image-service-and-catalog.md) for great image management and support for high DPI and theming.

## Find and install existing Visual Studio extensions
 You can find Visual Studio extensions in the **Extensions and Updates** dialog on the **Tools** menu. For more information, see [Find and Use Visual Studio Extensions](../ide/finding-and-using-visual-studio-extensions.md). You can also find extensions in the [Visual Studio Marketplace](https://marketplace.visualstudio.com/)

## Visual Studio SDK reference
 You can find the Visual Studio SDK API reference at [Visual Studio SDK Reference](../extensibility/visual-studio-sdk-reference.md).

## Visual Studio SDK samples
 You can find open source examples of VSSDK extensions on GitHub at [Visual Studio Samples](https://github.com/Microsoft/VSSDK-Extensibility-Samples). This GitHub repo contains samples that illustrate various extensible features in Visual Studio.

## Other Visual Studio SDK resources
 If you have questions about the VSSDK or want to share your experiences developing extensions, you can use the [Visual Studio Extensibility Forum](https://social.msdn.microsoft.com/Forums/vstudio/home?forum=vsx) or the [ExtendVS Gitter Chatroom](https://gitter.im/Microsoft/extendvs).

 You can find more information in the [VSX Arcana blog](/archive/blogs/vsx/) and a number of blogs written by Microsoft MVPs:

- [Favorite Visual Studio extensions](https://scottdorman.blog/2014/10/05/favorite-visual-studio-extensions/)

- [Visual Studio extensibility](http://www.visualstudioextensibility.com/overview/vs/)

- [Extending Visual Studio](https://blog.slaks.net/2013-10-18/extending-visual-studio-part-1-getting-started/)

## Related content

- [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md)
- [FAQ: Converting add-ins to VSPackage extensions](/previous-versions/visualstudio/visual-studio-2015/extensibility/faq-converting-add-ins-to-vspackage-extensions?preserve-view=true&view=vs-2015)
- [Manage multiple threads in managed code](../extensibility/managing-multiple-threads-in-managed-code.md)
- [Extend menus and commands](../extensibility/extending-menus-and-commands.md)
- [Add commands to toolbars](../extensibility/adding-commands-to-toolbars.md)
- [Extend and customizing tool windows](../extensibility/extending-and-customizing-tool-windows.md)
- [Editor and language service extensions](../extensibility/editor-and-language-service-extensions.md)
- [Extending projects](extending-projects.md)
- [Extend user settings and options](../extensibility/extending-user-settings-and-options.md)
- [Create custom project and item templates](../extensibility/creating-custom-project-and-item-templates.md)
- [Expose properties to the properties window](exposing-properties-to-the-properties-window.md)
- [Use and providing services](../extensibility/using-and-providing-services.md)
- [Manage VSPackages](../extensibility/managing-vspackages.md)
- [Ship Visual Studio extensions](../extensibility/shipping-visual-studio-extensions.md)
- [Inside the Visual Studio SDK](../extensibility/internals/inside-the-visual-studio-sdk.md)
- [Support for the Visual Studio SDK](../extensibility/support-for-the-visual-studio-sdk.md)
- [Visual Studio SDK reference](../extensibility/visual-studio-sdk-reference.md)