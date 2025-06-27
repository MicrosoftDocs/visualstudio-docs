---
title: Start developing Visual Studio extensions
description: Get answers to common questions about writing Visual Studio extensions, including prerequisites, extending features, and project templates.
ms.date: 02/02/2024
ms.topic: conceptual
helpviewer_keywords:
- getting started, Visual Studio integration
- Visual Studio, integration
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Start developing extensions in Visual Studio

If you've never written a Visual Studio extension before, you probably have some questions. We've listed some of the most common ones here. If you don't see the information you're looking for, use the feedback button at the upper right of this page to ask for what you want.

> [!NOTE]
> This article applies to Visual Studio on Windows. For Visual Studio Code, see [Visual Studio Code Extension API](https://code.visualstudio.com/api).

## What software do I need to develop Visual Studio extensions?

You need to install the Visual Studio SDK in addition to Visual Studio in order to develop Visual Studio extensions. You can install the Visual Studio SDK as part of regular setup, or you can install it later on. For more information about installing the Visual Studio SDK, see [Install the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## What kinds of things can I do with Visual Studio extensions?

The sky's the limit when it comes to imagining different Visual Studio extensions. Of course, most extensions have something to do with writing code, but that doesn't have to be the case. Here are some examples of the kinds of extensions you can build:

- Support for languages that aren't included in Visual Studio, with syntax coloring, IntelliSense, and compiler and debug support.

- Productivity tools that extend the core IDE experience with more templates, code refactoring, new dialogs or tool windows.

- Domain-specific designers for scenarios like data design or cloud support.

For examples of extensions, check out the [Visual Studio Marketplace](https://marketplace.visualstudio.com/vs). Many extensions are open-sourced, and the Marketplace includes links to their GitHub repo.

## Which Visual Studio features can I extend?

In theory, you can extend just about any part of Visual Studio: menus, toolbars, commands, windows, solutions, projects, editors, and so on.

In practice, we have found that the features most people want to extend are commands, menus and toolbars, windows, IntelliSense, and projects. Here are links to the relevant sections:

- [Extending Menus and Commands](../extensibility/extending-menus-and-commands.md): add your own items to Visual Studio menus and toolbars. You can use them to launch new Visual Studio functionality or your own external helper applications. You can also provide custom shortcuts for your menu items.

- [Extending and Customizing Tool Windows](../extensibility/extending-and-customizing-tool-windows.md): extend existing tool windows or create your own tool windows. For instance, you could add new properties to the **Properties**, or you could create a new tool window to add more features.

- [Editor and Language Service Extensions](../extensibility/editor-and-language-service-extensions.md): add your own customizations to the IntelliSense provided for Visual Studio languages, or create support for new programming languages. You can create new statement completions, suggestions, and new QuickInfo tooltips. With light bulbs, you can add refactoring suggestions and code fixes to support new programming languages.

- [Extending Projects](../extensibility/extending-projects.md)

- [Extending User Settings and Options](../extensibility/extending-user-settings-and-options.md)

- [Extending Properties and the Property Window](/previous-versions/visualstudio/visual-studio-2017/extensibility/extending-properties-and-the-property-window)

- [Extending Other Parts of Visual Studio](/previous-versions/visualstudio/visual-studio-2017/extensibility/extending-other-parts-of-visual-studio)

## What project templates are provided by the VSSDK?

 The two main types of extensions are VSPackages and MEF extensions. In general, VSPackage extensions are used for extensions that use or extend commands, tool windows, and projects. MEF extensions are used to extend or customize the Visual Studio editor.

 For Visual C# and Visual Basic extensions, the VSSDK provides an empty VSIX project template that you can use together with the new item templates that create menu commands, tool windows, and editor extensions. You can also use this template to package project templates, code snippets, and other artifacts for distribution to other users.

 For C++, the VSPackage wizard provides the code to add menu commands, tool windows, and custom editors.

The following articles show you how to get started with each kind of extension:

- Menu commands: [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md)

- Tool windows: [Creating an Extension with a Tool Window](../extensibility/creating-an-extension-with-a-tool-window.md)

- Editor extensions: [Creating an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md)

- Basic VSPackages: [Creating an Extension with a VSPackage](../extensibility/creating-an-extension-with-a-vspackage.md)

- VSIX project template: [Getting Started with the VSIX Project Template](../extensibility/getting-started-with-the-vsix-project-template.md)

## How do I get my extension to look like Visual Studio?

 Get great tips for designing the UI for your extension in [Visual Studio User Experience Guidelines](../extensibility/ux-guidelines/visual-studio-user-experience-guidelines.md).

## Where can I find examples of VSSDK code?

 Each of the links listed in the preceding section has step-by-step walkthroughs that show you how to implement specific features. You can also find open-source VSSDK samples on GitHub at [Visual Studio Samples](https://github.com/Microsoft/VSSDK-Extensibility-Samples).

## How can I distribute my extension?

 You can install your extension on another computer or send it to your friends as a *.vsix* file, which you install by double-clicking it. You can find out more about VSIX packages at [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md).

 You can also publish your extension on the Visual Studio Marketplace, which makes it visible to a large number of Visual Studio customers. For an example of packaging an extension to the Marketplace, see [Walkthrough: Publishing a Visual Studio Extension](../extensibility/walkthrough-publishing-a-visual-studio-extension.md). For more information about what you need to do to publish on the Marketplace, see [Products and Extensions for Visual Studio](/azure/devops/extend/overview?view=vsts&preserve-view=true).

## Related content

- [Extending Visual Studio Code](https://code.visualstudio.com/api)
