---
title: "Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)"
ms.custom: na
ms.date: "10/13/2016"
ms.prod: ".net-framework-4.6"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "reference"
helpviewer_keywords: 
  - "workflows, disabling debugger"
  - "debugging workflows, disabling debugger"
  - "workflow debugger, disabling"
ms.assetid: 9da96d0e-f941-4fa9-a1a5-6bab50adfec9
caps.latest.revision: 6
ms.author: "erikre"
manager: "erikre"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)
This topic describes how to disable the [!INCLUDE[vsprvs](../codequality/includes/vsprvs_md.md)] Debugger using the configuration file when building [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] applications in the legacy [!INCLUDE[wfd1](../workflowdesigner/includes/wfd1_md.md)]. Use the legacy [!INCLUDE[wfd2](../workflowdesigner/includes/wfd2_md.md)] when you need to target either the [!INCLUDE[netfx35_long](../workflowdesigner/includes/netfx35_long_md.md)] or the [!INCLUDE[vstecwinfx](../workflowdesigner/includes/vstecwinfx_md.md)].  
  
 By default, the [!INCLUDE[vs_current_long](../misc/includes/vs_current_long_md.md)] Debugger for [!INCLUDE[wf](../workflowdesigner/includes/wf_md.md)] is enabled for a host process. To disable workflow debugging, you must explicitly turn it off by adding a "DisableWorkflowDebugging" entry **\<switches>** element in the **\<system.diagnostics>** section of the host configuration file.  
  
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
 [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../workflowdesigner/invoking-the-visual-studio-debugger-for-windows-workflow-foundation--legacy-.md)   
 [Debugging Legacy Workflows](../workflowdesigner/debugging-legacy-workflows.md)