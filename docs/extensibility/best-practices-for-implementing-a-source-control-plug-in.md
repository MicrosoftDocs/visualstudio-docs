---
title: Implementing a source control plug-in - best practices
description: Review these technical details to help you reliably implement a source control plug-in in Visual Studio.
ms.date: 11/04/2016
ms.topic: best-practice
helpviewer_keywords:
- source control plug-ins, best practices
- best practices, source control plug-ins
- source control [Visual Studio SDK], plug-ins
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Best practices for implementing a source control plug-in

The following technical details can help you reliably implement a source control plug-in in Visual Studio.

## Memory management issues
 In most cases, the integrated development environment (IDE), which is the caller, releases and allocates memory. The source control plug-in returns strings and other items in caller-allocated buffers. Exceptions are noted in descriptions of specific functions where they occur.

## Arrays of file names
 When an array of files is passed, it is not passed as a contiguous array of file names. It is passed as an array of pointers to file names. For example, in the [SccGet](../extensibility/sccget-function.md), the file names are passed by the `lpFileNames` parameter, where `lpFileNames` is actually a pointer to a `char **`. `lpFileNames`[0] is a pointer to the first name, `lpFileNames`[1] is a pointer to the second name, and so on.

## Large model
 All pointers are 32 bits, even on 16-bit operating systems.

## Fully qualified paths
 Where file names or directories are specified as arguments, they must be fully qualified paths or UNC paths, without the ending backslashes. It is the responsibility of the source control plug-in to translate these to relative paths if that is a requirement of the underlying source control system.

## Specify a fully qualified path for the registered DLL
 The IDE no longer loads DLLs from relative paths (for example, *.\NewProvider.dll*). A full path of the DLL must be specified (for example, *C:\Providers\NewProvider.dll*). This requirement strengthens the security of the IDE by preventing the loading of unauthorized or impersonated source control DLLs.

## Check for an existing VSSCI plug-in when you install your source control plug-in
 A user who plans to install your source control plug-in may already have an existing source control plug-in installed on the computer. The installation (setup) program for the plug-in that you create should determine whether there are existing values for the relevant registry keys. If these keys are already set, your installation program should ask the user whether to register your plug-in as the default source control plug-in and replace the one that is already installed.

## Error result codes and reporting
 The `SCC_OK` return code for a source control function indicates that the operation has succeeded for all files. If the operation fails, it is expected to return the last error code encountered.

 The rule for reporting is that if an error occurs in the IDE, the IDE is responsible for reporting it. If an error occurs in the source control system, the source control plug-in is responsible for reporting it. For instance, **No files are currently selected** would be reported by the IDE, whereas **This file is already checked out** would be reported by the plug-in.

## The context structure
 During the call to the [SccInitialize](../extensibility/sccinitialize-function.md), the caller passes the `ppvContext` parameter, which is an uninitialized handle to a void. The source control plug-in can ignore this parameter or it can allocate a structure of any kind and put a pointer to that structure into the passed pointer. The IDE does not understand this structure, but it passes a pointer to this structure into every other call in the plug-in. This provides valuable context cache information to the plug-in that it can use to maintain global state information that persists across function calls without using global variables. The plug-in is responsible for freeing the structure on a call to the [SccUninitialize](../extensibility/sccuninitialize-function.md).

 If the plug-in sets the `SCC_CAP_REENTRANT` bit in the [SccInitialize](../extensibility/sccinitialize-function.md) (specifically, in the `lpSccCaps` parameter), multiple context structures are used to track all the projects that are open.

## Bitflags and other command options
 For each command, such as the [SccGet](../extensibility/sccget-function.md), the IDE can specify many options that change the behavior of the command.

 The API supports the setting of certain options by the IDE through the `fOptions` parameter. These options are described in [Bitflags used by specific commands](../extensibility/bitflags-used-by-specific-commands.md) together with the commands that they affect. In general, these are options for which the user would not be prompted.

 Most user-configurable setting options are not defined in this manner, because they vary widely among source control plug-ins. Therefore, the recommended mechanism is an **Advanced** button. For instance, in the **Get** dialog box, the IDE displays only information that it understands, but it also displays an **Advanced** button if the plug-in has options for this command. When the user clicks the **Advanced** button, the IDE calls the [SccGetCommandOptions](../extensibility/sccgetcommandoptions-function.md) to enable the source control plug-in to prompt the user for information, such as bitflags or a date/time. The plug-in returns this information in a structure that is passed back during the `SccGet` command.

## Related content
- [Source control plug-ins](../extensibility/source-control-plug-ins.md)
- [Create a source control plug-in](../extensibility/internals/creating-a-source-control-plug-in.md)
