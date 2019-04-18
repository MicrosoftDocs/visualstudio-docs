---
title: "Starting to Develop Extensions | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords:
  - "getting started, Visual Studio integration"
  - "Visual Studio, integration"
ms.assetid: 8fe5e2ab-a424-4173-9d39-dd082c4d58d0
caps.latest.revision: 30
ms.author: gregvanl
manager: jillfra
---
# Starting to Develop Visual Studio Extensions
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

If you’ve never written a Visual Studio extension before, you probably have some questions. We’ve listed some of the most common ones here. If you don’t see the information you’re looking for, use the feedback buttons (**Was this page helpful?** at the bottom of the screen) to ask for what you want.

## What software do I need to develop Visual Studio extensions?
 You need to install the Visual Studio 2015 SDK in addition to Visual Studio 2015 in order to develop Visual Studio extensions.   You can install the Visual Studio 2015 SDK as part of regular setup, or you can install it later on. For more information about installing the Visual Studio SDK, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## What kinds of things can I do with Visual Studio extensions?
 The sky’s the limit when it comes to imagining different Visual Studio extensions. Of course, most extensions have something to do with writing code, but that doesn’t have to be the case. Here are some examples of the kinds of extensions you can build:

- Support for languages that aren’t included in Visual Studio, with syntax coloring, IntelliSense, and compiler and debug support

- Productivity tools that extend the core IDE experience with additional templates, code refactoring, new dialogs or tool windows

- Domain-specific designers for scenarios like data design or cloud support

  For examples of extensions, check out the [Visual Studio Marketplace](https://marketplace.visualstudio.com/). You can also take a look at [Visual Studio Open Source Extensions](https://github.com/Microsoft/extendvs/blob/master/CommunityExtensions.md).

## Which Visual Studio features can I extend?
 In theory, you can extend just about any part of Visual Studio: menus, toolbars, commands, windows, solutions, projects, editors, and so on.

 In practice, we have found that the features most people want to extend are commands, menus and toolbars, windows, IntelliSense, and projects. Here are links to the relevant sections:

- [Extending Menus and Commands](../extensibility/extending-menus-and-commands.md): add your own items to Visual Studio menus and toolbars. You can use them to launch new Visual Studio functionality or your own external helper applications. You can also provide custom shortcuts for your menu items.

- [Extending and Customizing Tool Windows](../extensibility/extending-and-customizing-tool-windows.md): extend existing tool windows or create your own tool windows. For instance, you could add new properties to the **Properties**, or you could create a new tool window to add additional features.

- [Editor and Language Service Extensions](../extensibility/editor-and-language-service-extensions.md): add your own customizations the IntelliSense provided for Visual Studio languages, or create support for new programming languages. You can create new statement completions, suggestions, and new QuickInfo tooltips. With light bulbs, you can add refactoring suggestions and code fixes to support new programming languages.

- [Extending Projects](../extensibility/extending-projects.md)

- [Extending User Settings and Options](../extensibility/extending-user-settings-and-options.md)

- [Extending Properties and the Property Window](../extensibility/extending-properties-and-the-property-window.md)

- [Extending Other Parts of Visual Studio](../extensibility/extending-other-parts-of-visual-studio.md)

- [Visual Studio Isolated Shell](../extensibility/visual-studio-isolated-shell.md)

## <a name="BKMK_ProjectTemplate"></a> What project templates are provided by the VSSDK?
 The two main types of extensions are VSPackages and MEF extensions. In general, VSPackage extensions are used for extensions that use or extend commands, tool windows, and projects. MEF extensions are used to extend or customize the Visual Studio editor.

 For Visual C# and Visual Basic extensions, the VSSDK provides an empty VSIX project template that you can use together with the new item templates that create menu commands, tool windows, and editor extensions. For more information, see [What's New in the Visual Studio 2015 SDK](../extensibility/what-s-new-in-the-visual-studio-2015-sdk.md). You can also use this template to package project templates, code snippets, and other artifacts for distribution to other users.

 For C++, the VSPackage wizard provides the code to add menu commands, tool windows, and custom editors.

 The Isolated Shell template is used to package an extension in a version of the Visual Studio shell that you can brand and distribute as your own. The following topics show you how to get started with each kind of extension:

- Menu commands: [Creating an Extension with a Menu Command](../extensibility/creating-an-extension-with-a-menu-command.md)

- Tool windows: [Creating an Extension with a Tool Window](../extensibility/creating-an-extension-with-a-tool-window.md)

- Editor extensions: [Creating an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md)

- Basic VSPackages: [Creating an Extension with a VSPackage](../extensibility/creating-an-extension-with-a-vspackage.md)

- VSIX project template: [Getting Started with the VSIX Project Template](../extensibility/getting-started-with-the-vsix-project-template.md)

- Visual Studio isolated shell: [Walkthrough: Creating a Basic Isolated Shell Application](../extensibility/walkthrough-creating-a-basic-isolated-shell-application.md)

## How do I get my extension to look like Visual Studio?
 Get great tips for designing the UI for your extension in [Visual Studio User Experience Guidelines](../extensibility/ux-guidelines/visual-studio-user-experience-guidelines.md).

## Where can I find examples of VSSDK code?
 Each of the links listed in the preceding section have step-by-step walkthroughs that show you how to implement specific features. You can also find open source VSSDK samples on GitHub at [Visual Studio Samples](https://aka.ms/vs2015sdksamples).

## How can I distribute my extension?
 You can install your extension on another computer or send it to your friends as a .vsix file, which you install by double-clicking it. You can find out more about VSIX packages at [Shipping Visual Studio Extensions](../extensibility/shipping-visual-studio-extensions.md).

 You can also publish your extension on the Visual Studio Gallery, which makes it visible to large numbers of Visual Studio customers. For an example of packaging an extension for the Gallery, see [Walkthrough: Publishing a Visual Studio Extension](../extensibility/walkthrough-publishing-a-visual-studio-extension.md). For more information about what you need to do to publish on the Gallery, see [Products and Extensions for Visual Studio](https://visualstudiogallery.msdn.microsoft.com/).
