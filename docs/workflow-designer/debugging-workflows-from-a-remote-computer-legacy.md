---
title: "Workflow Designer - Debugging Workflows from a Remote Computer (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "workflows, debugging remotely"
  - "debugging workflows, remotely"
  - "remote debugging, workflows"
  - "debugging, remote"
ms.assetid: 44eaec8f-9959-4ae7-a374-670946f933c1
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Debugging Workflows from a Remote Computer (Legacy)

This topic describes how to debug remote legacy Windows Workflow Foundation (WF) applications that are built with the legacy Windows Workflow Designer. Use the legacy Workflow Designer when your application needs to target either the .NET Framework version 3.5 or the WinFX.

 When you install Visual Studio, one of the component installation options is to install the Visual Studio Debugger for Windows Workflow Foundation (WF). This installs the remote debugging components. These remote debugging components must be installed on the computer that you are targeting for remote workflow debugging.

 Additionally, the assembly that contains the workflow definition of the legacy workflow that you are debugging on a remote computer must be installed in the global assembly cache (GAC) of the local computer that you are debugging from. For example, if a legacy workflow is running on a remote computer A, and you are debugging it from local computer B, the workflow definition must be present in the GAC of computer B. This enables the designer to deserialize and display on computer B the workflow markup of the workflow that is running remotely on computer A. For more information about the global assembly cache, see the MSDN Library.

 Windows Workflow Foundation remote debugging functions the same as remote debugging for other Visual Studio components. For more information, see Visual Studio Remote Debugging in the MSDN Library.

## See also

- [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)