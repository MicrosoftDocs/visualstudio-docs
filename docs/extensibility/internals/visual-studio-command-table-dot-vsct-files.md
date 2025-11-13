---
title: Visual Studio Command Table (.Vsct) Files
description: Learn about command table configuration files, which are text files that describe the set of commands that a VSPackage contains.
ms.date: 11/04/2016
ms.topic: article
helpviewer_keywords:
- VSCT files, overview
- Visual Studio command table configuration files (VSCT), overview
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Visual Studio Command Table (.Vsct) Files

A command table configuration file is a text file that describes the set of commands that a VSPackage contains. The Visual Studio command table (VSCT) compiler compiles XML-based configuration files (.vsct files) into binary command table output (.cto) files. The resultant .cto files are the same as those that are created by using the command table (CTC) compiler to compile .ctc configuration files. However, XML-based .vsct files has some advantages, such as an XML editor and XML IntelliSense.

 To learn more about the syntax and semantics of .vsct files, see [Designing XML Command Table (.Vsct) Files](../../extensibility/internals/designing-xml-command-table-dot-vsct-files.md)

## In this section

[Designing XML Command Table (.Vsct) Files](../../extensibility/internals/designing-xml-command-table-dot-vsct-files.md) describes how to design .vsct files.

 [How to: Create a .Vsct File](../../extensibility/internals/how-to-create-a-dot-vsct-file.md) compares the methods for creating a .vsct file. Describes the process for manually creating a new .vsct file.

## Related sections

[VSCT XML Schema Reference](../../extensibility/vsct-xml-schema-reference.md) provides details about each section of the command table XML configuration file.

 [Command Table Configuration (.Ctc) Files](/previous-versions/bb165153(v=vs.100)) Presents an overview of the deprecated .ctc file format.

 [How VSPackages Add User Interface Elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md) describes the command table format specification.

 [Resources in VSPackages](../../extensibility/internals/resources-in-vspackages.md) describes how to use managed and unmanaged resources in managed VSPackages.

 [Commands, Menus, and Toolbars](../../extensibility/internals/commands-menus-and-toolbars.md) explains how to create a UI that includes menus, toolbars, and command combo boxes.
