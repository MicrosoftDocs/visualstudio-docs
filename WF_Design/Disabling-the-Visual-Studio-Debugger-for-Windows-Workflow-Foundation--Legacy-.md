---
title: "Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)"
ms.custom: na
ms.date: 10/02/2016
ms.prod: .net-framework-4.6
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: reference
ms.assetid: 9da96d0e-f941-4fa9-a1a5-6bab50adfec9
caps.latest.revision: 6
manager: erikre
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Disabling the Visual Studio Debugger for Windows Workflow Foundation (Legacy)
This topic describes how to disable the Visual Studio Debugger using the configuration file when building Windows Workflow Foundation (WF) applications in the legacy Windows Workflow Designer. Use the legacy Workflow Designer when you need to target either the .NET Framework version 3.5 or the WinFX.  
  
 By default, the Visual Studio 2012 Debugger for Windows Workflow Foundation (WF) is enabled for a host process. To disable workflow debugging, you must explicitly turn it off by adding a "DisableWorkflowDebugging" entry **<switches\>** element in the **<system.diagnostics>** section of the host configuration file.  
  
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
 [Invoking the Visual Studio Debugger for Windows Workflow Foundation (Legacy)](../WF_Design/Invoking-the-Visual-Studio-Debugger-for-Windows-Workflow-Foundation--Legacy-.md)   
 [Debugging Legacy Workflows](../WF_Design/Debugging-Legacy-Workflows.md)