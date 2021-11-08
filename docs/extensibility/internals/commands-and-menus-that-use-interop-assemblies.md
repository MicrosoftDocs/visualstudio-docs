---
title: Commands and Menus That Use Interop Assemblies | Microsoft Docs
description: Learn about the tasks that must be completed when implementing menu and toolbar commands in a VSPackage by using Interop assemblies. 
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
- menus, using interop assemblies
- interop assemblies, using in commands and menus
- commands, handling using interop assemblies
- command handling with interop assemblies
ms.assetid: 8f4af525-39e5-4e69-92c8-d3efabe80bb2
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.technology: vs-ide-sdk
ms.workload:
- vssdk
---
# Commands and menus that use Interop assemblies
A VSPackage that implements menu and toolbar commands by using Interop assemblies must:

- Inform the [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] integrated development environment (IDE) about the commands it supports and whether they are currently enabled.

- Adhere to the rules (contract) for handling commands.

- Explicitly implement command handling by using either the <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> or <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIHierarchy> interface.

  The following section describes how to do these tasks.

## In this section
- [Determine command status by using Interop assemblies](../../extensibility/internals/determining-command-status-by-using-interop-assemblies.md)

 Describes how a VSPackage notifies the IDE about which commands it supports and whether they are currently enabled.

- [Command contracts in Interop assemblies](../../extensibility/internals/command-contracts-in-interop-assemblies.md)

 Provides a definition of the basic command contract used by all VSPackages implementing commands using Interop assemblies.

- [Command implementation](../../extensibility/internals/command-implementation.md)

 Provides an overview of how a VSPackage implements a command.

- [Register Interop assembly command handlers](../../extensibility/internals/registering-interop-assembly-command-handlers.md)

 Describes the registry entries required to notify the IDE that a VSPackage provides a command handler.

## Related sections
- [Command availability](../../extensibility/internals/command-availability.md)

 Describes criteria that are used by the IDE to determine which VSPackage commands are available and what object handles them.

- [How VSPackages add user interface elements](../../extensibility/internals/how-vspackages-add-user-interface-elements.md)

 Provides details about how to create a UI that uses [!INCLUDE[vsprvs](../../code-quality/includes/vsprvs_md.md)] command support.

- [Command routing in VSPackages](../../extensibility/internals/command-routing-in-vspackages.md)

 An overview of the process used to relate an object with the correct command request.
