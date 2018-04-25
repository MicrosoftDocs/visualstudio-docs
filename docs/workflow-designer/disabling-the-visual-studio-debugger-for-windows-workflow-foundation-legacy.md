---
title: "Workflow Designer - Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)"
ms.date: 11/04/2016
ms.topic: conceptual
ms.prod: visual-studio-dev15
ms.technology: vs-workflow-designer
helpviewer_keywords:
  - "workflows, disabling debugger"
  - "debugging workflows, disabling debugger"
  - "workflow debugger, disabling"
ms.assetid: 9da96d0e-f941-4fa9-a1a5-6bab50adfec9
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)

This topic describes how to disable the Visual Studio Debugger using the configuration file when building Windows Workflow Foundation (WF) applications in the legacy Windows Workflow Designer. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.

 By default, the Visual Studio Debugger for Windows Workflow Foundation (WF) is enabled for a host process. To disable workflow debugging, you must explicitly turn it off by adding a "DisableWorkflowDebugging" entry **\<switches>** element in the **\<system.diagnostics>** section of the host configuration file.

 The following example shows how to modify the host configuration file to disable workflow debugging.

```xml
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
   <system.diagnostics>
      <switches>
         <add name="DisableWorkflowDebugging" value="true"/>
      </switches>
   </system.diagnostics>
</configuration>
```

## See also

- [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../workflow-designer/invoking-the-visual-studio-debugger-for-windows-workflow-foundation-legacy.md)
- [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)