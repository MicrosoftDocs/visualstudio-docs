---
title: "Disabling the Debugger for Windows Workflow Foundation (Legacy) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-workflow-designer
ms.topic: "reference"
helpviewer_keywords:
  - "workflows, disabling debugger"
  - "debugging workflows, disabling debugger"
  - "workflow debugger, disabling"
ms.assetid: 9da96d0e-f941-4fa9-a1a5-6bab50adfec9
caps.latest.revision: 6
author: jillre
ms.author: jillfra
manager: jillfra
---
# Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)
This topic describes how to disable the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Debugger using the configuration file when building [!INCLUDE[wf](../includes/wf-md.md)] applications in the legacy [!INCLUDE[wfd1](../includes/wfd1-md.md)]. Use the legacy [!INCLUDE[wfd2](../includes/wfd2-md.md)] when you need to target either the [!INCLUDE[netfx35_long](../includes/netfx35-long-md.md)] or the [!INCLUDE[vstecwinfx](../includes/vstecwinfx-md.md)].

 By default, the [!INCLUDE[vs_current_long](../includes/vs-current-long-md.md)] Debugger for [!INCLUDE[wf](../includes/wf-md.md)] is enabled for a host process. To disable workflow debugging, you must explicitly turn it off by adding a "DisableWorkflowDebugging" entry **\<switches>** element in the **\<system.diagnostics>** section of the host configuration file.

 The following example shows how to modify the host configuration file to disable workflow debugging.

```
<?xml version="1.0" encoding="utf-8" ?>
<configuration>
   <system.diagnostics>
      <switches>
         <add name="DisableWorkflowDebugging" value="true"/>
      </switches>
   </system.diagnostics>
</configuration>
```

## See Also
 [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../workflow-designer/invoking-the-visual-studio-debugger-for-windows-workflow-foundation-legacy.md)
 [Debugging Legacy Workflows](../workflow-designer/debugging-legacy-workflows.md)