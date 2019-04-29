---
title: "What&#39;s New in the Visual Studio 2015 SDK | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: c64aac80-a411-463f-b7bd-8b7607a52ece
author: "gregvanl"
ms.author: "gregvanl"
manager: jillfra
ms.workload:
  - "vssdk"
---
# What&#39;s new in the Visual Studio 2015 SDK
The Visual Studio SDK has the following new and updated features for Visual Studio 2015, Visual Studio 2015 updated, and Visual Studio 2017.

## VS 2015 SDK Update 1
 Update 1 includes tools to help your extension work well with color themes and the Visual Studio image service.

 These topics are under the [VSSDK Utilities](../extensibility/internals/vssdk-utilities.md) section:

- The [Color theming tools](../extensibility/internals/color-theming-tools.md) help you create and edit custom colors for Visual Studio.

- The [Image service tools](../extensibility/internals/image-service-tools.md) let you work with Visual Studio image manifest files.

## New way to add the Visual Studio SDK to Visual Studio
 Starting in Visual Studio 2015, you don't need to download the Visual Studio SDK separately. Instead, you can install it as part of the normal installation process, or you can choose to install it later on. When you open or create  a VSIX solution, Visual Studio will ask you to install the Visual Studio Extensibility Tools. For more information, see [Installing the Visual Studio SDK](../extensibility/installing-the-visual-studio-sdk.md).

## New ways of creating extensions
 Starting in the Visual Studio 2015 SDK, you have different options for creating extensions, depending on which programming language you're using.

### Visual C# and Visual Basic
 For C# and Visual Basic, there is a full range of project item templates that allow you to create VSPackages, menu commands, tool windows, editor classifiers, editor adornments, and editor margin extensions. You can add any or all of these templates to the standard VSIX project. For more information, see:

- [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md)

- [Create an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md)

- [Create an extension with an editor item template](../extensibility/creating-an-extension-with-an-editor-item-template.md)

- [Create an extension with a VSPackage](../extensibility/creating-an-extension-with-a-vspackage.md)

     The VSPackage Wizard no longer creates extensions in C# or Visual Basic.

### C++
 For C++, the VSPackage Wizard support menu commands, tool windows, and custom editors. Look for it in the **New Project** dialog in **Visual C++ / Extensibility**.

## VS SDK reference assemblies via NuGet
 For increased portability and sharing of extensibility projects, you can use the NuGet versions of the VS SDK reference assemblies. These assemblies are available on [nuget.org](http://www.nuget.org) published by [VisualStudioExtensibility](http://www.nuget.org/profiles/VisualStudioExtensibility) and can be easily added to your project or solution through the Visual Studio **References / Manage NuGet Packages** dialog. You can add individual references to specific extensibility assemblies or add all the VS SDK references assemblies at once using the VS SDK [Meta package](http://www.nuget.org/packages/VSSDK_Reference_Assemblies). To learn more about NuGet, see the [NuGet documentation](/NuGet) and [Package Manager UI](/NuGet/Tools/Package-Manager-UI) topics.

 When you use the NuGet versions of the VS SDK reference assemblies, another user doesn't need to install the VS SDK to open and build your project.  The NuGet reference assemblies and VS SDK build tools will automatically be installed on their computer for that project.

 The VS SDK item templates use NuGet for their references and build tools so you get the benefits of NuGet by default.

> [!NOTE]
> You can continue to use the VS SDK installed reference assemblies with your projects (located under \<Visual Studio Install Location>\ VSSDK\VisualStudioIntegration\Common\Assemblies) and existing extensibility projects do not need to be upgraded to use NuGet packages.  The project **References / Add Reference** dialog continues to use the VS SDK installed reference assemblies.
>
> If you'd like to modify your existing projects to use NuGet, see [How to: Migrate VSPackages to Visual Studio 2015](../extensibility/how-to-migrate-extensibility-projects-to-visual-studio-2015.md) which has a section on updating extensibility projects to NuGet packages.

## Light bulbs
 One of the most exciting new ways of writing extension code is provided by the Roslyn project. For more information, see [Roslyn](https://github.com/dotnet/Roslyn).

 Light bulbs are a new feature that ships with the VSSDK. They are icons used in the Visual Studio editor that expand to display a set of code refactoring actions or fixes for problems identified by the built-in code analyzers. For more information, see [Walkthrough: Displaying Light Bulb Suggestions](../extensibility/walkthrough-displaying-light-bulb-suggestions.md).

## Updated user experience guidelines
 Designing new extensions or features for Visual Studio? Check out the updated and expanded [Visual Studio user experience guidelines](../extensibility/ux-guidelines/visual-studio-user-experience-guidelines.md).  You'll find the [color tokens](../extensibility/ux-guidelines/shared-colors-for-visual-studio.md), [font sizes](../extensibility/ux-guidelines/fonts-and-formatting-for-visual-studio.md), [dialog layout specifications](../extensibility/ux-guidelines/layout-for-visual-studio.md), and other guidance you need to seamlessly integrate your new UI with Visual Studio.