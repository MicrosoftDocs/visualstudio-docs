---
title: Anatomy of an extension
description: Explains the structure of a Visual Studio extension
ms.date: 12/01/2021
ms.topic: conceptual
author: madskristensen
ms.author: madsk
manager: pchapman

ms.subservice: extensibility-integration
---
# Anatomy of a Visual Studio extension

A VSIX package is a .vsix file that contains one or more Visual Studio extensions and the metadata that Visual Studio uses to classify and install the extensions. The VSIX package format follows the Open Packaging Conventions (OPC) standard that means it can be opened by any tool that can open ZIP files.

An extension project is a C# project with a few extras that make it unique. The following video explores an extension project to better understand how extension projects work:

> [!VIDEO https://learn-video.azurefd.net/vod/player?id=cc3dbbb6-c221-469e-8320-208d816eff0a]

## File structure
When creating new extensions using the **VSIX Project w/Command (Community)** template, the file structure looks as follows:

:::image type="content" source="../media/new-project-files.png" alt-text="File structure of a VSIX project.":::

The **.vsixmanifest** file is the main file. It's an XML file containing information about the extension used by Visual Studio. All components of the extension are registered in the **.vsixmanifest** file. It's the only mandatory file in a VSIX project.

The **VSCommandTable.vsct** file is where commands are declared. It's an XML file and contains the definitions of button commands, menus, keyboard shortcut bindings and more. The file compiles its content into a blob in the output .dll that Visual Studio uses to construct its entire command table menu structure. This file only declares the components in the command table; it doesn't handle any command invocations.

The **\*Package.cs** file is the Package class, which is the entry point for most extensions. In here, you often find command handlers, tool windows, options pages, services, and other components registered.

## Compilation
The project compiles into a .vsix file located in the */bin/debug* or */bin/release* folder, which depends on your current solution build configuration. The *Visual Studio extension development* [workload](get-tools.md) provides dedicated MSBuild targets and tasks to handle the VSIX project flavor.

When the VSIX project builds, it automatically deploys itself to the Experimental Instance. This can be controlled in the VSIX project settings: 

:::image type="content" source="../media/deploy-vsix-experimental-instance.png" alt-text="VSIX project properties.":::

## Experimental instance
To safeguard your Visual Studio development environment from untested applications that might change it, the VSSDK provides an experimental space that you can use to experiment. You develop new applications by using Visual Studio as usual, but you run them by using this Experimental Instance.

Every application that has a VSIX package launches the Visual Studio experimental instance in debug mode.

If you want to start the experimental instance of Visual Studio outside a specific solution, run the following command at the command window:

```shell
devenv.exe /RootSuffix Exp
```

For more extensibility concepts, check out the [useful resources](useful-resources.md), which will come in handy for following this toolkit.
