---
title: Source Control Plug-ins
description: The articles in this section describe the complete interface specification that enables source control systems to be integrated with Visual Studio.
ms.date: 10/23/2025
ms.topic: article
helpviewer_keywords:
- source control plug-ins, reference
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Source Control Plug-ins

The Source Control Plug-in SDK reference section contains the complete interface specification that enables source control systems to be integrated with Visual Studio. It specifies the syntax and semantics of the various functions and data types that the source control plug-in must implement to interface with the Visual Studio integrated development environment (IDE).

## In this section

- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md) lists functions that must be implemented by the source control plug-in in order to comply with the Source Control Plug-in API.

- [Callback Functions Implemented by the IDE](../extensibility/callback-functions-implemented-by-the-ide.md) describes functions that the source control plug-in uses to pass information back to the IDE while certain commands are executed.

- [Enumerators](../extensibility/enumerators.md) lists the enumerator data types in the Source Control Plug-in API that the source control plug-in must know about.

- [Capability Flags](../extensibility/capability-flags.md) describes the `SCC_CAP_xxx` flags, which indicate a provider's capabilities.

- [Bitflags Used by Specific Commands](../extensibility/bitflags-used-by-specific-commands.md) lists flags that are useful in the context of particular commands.

- [Error Codes](../extensibility/error-codes.md) lists common error values returned by functions as `SCCTRN`.

- [Strings Used as Keys for Finding a Source Control Plug-in](../extensibility/strings-used-as-keys-for-finding-a-source-control-plug-in.md) describes keys for accessing the registry to find the source control plug-in.

- [MSSCCPRJ.SCC File](../extensibility/mssccprj-scc-file.md) describes a client-side file that contains information opaque to the IDE, but that is used by the source control plug-in to locate the solution or project in version control.

- [Best Practices for Implementing a Source Control Plug-in](../extensibility/best-practices-for-implementing-a-source-control-plug-in.md) provides a collection of important technical reminders to remember while you are implementing the Source Control Plug-in API.

- [Restrictions on String Lengths](../extensibility/restrictions-on-string-lengths.md) describes limitations in the Source Control Plug-in API on the lengths of strings used in various functions.

- [Glossary](../extensibility/source-control-plug-in-glossary.md) provides helpful terms and their definitions for reading the Source Control Plug-in SDK documentation.

- [How to: Turn Off Compatibility Warnings for Source Control Plug-ins](../extensibility/how-to-turn-off-compatibility-warnings-for-source-control-plug-ins.md) describes how to disable warnings.

## Related sections

- [Test Guide for Source Control Plug-ins](../extensibility/internals/test-guide-for-source-control-plug-ins.md) describes testing procedures related to a source control plug-in.

- [Creating a Source Control Plug-in](../extensibility/internals/creating-a-source-control-plug-in.md) discusses how to create a source control plug-in that supplies source control functionality while you are using the Visual Studio source control user interface (UI).

- [Visual Studio SDK Reference](../extensibility/visual-studio-sdk-reference.md) presents a list of reference topics.
