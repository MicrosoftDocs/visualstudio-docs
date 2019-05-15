---
title: "How to: Serialize Symbol Information | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "VS.ToolsOptionsPages.Performance.General"
helpviewer_keywords: 
  - "profiling tools, serializing symbol information"
  - "performance tools, serializing symbol information"
ms.assetid: 9e0da706-6325-4073-83d1-aeab3b7c137a
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Serialize Symbol Information
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can serialize symbols that you must have to analyze your application. Symbol serialization adds symbols to the .vsp file. By adding symbol information to the .vsp file, others can analyze a performance report without having access to the original symbols. If symbols are not serialized, you must have original instrumented .exe and .pdb files to analyze the .vsp file.  
  
### To automatically serialize symbol information  
  
1. On the **Tools** menu, click **Options**.  
  
     The **Options** dialog box is displayed.  
  
2. Click **Performance Tools**.  
  
3. Under **General Setting**, select **Automatically serialize symbol information**.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [How to: Reference Windows Symbol Information](../profiling/how-to-reference-windows-symbol-information.md)   
 [How to: Save Analyzed Report Files](https://msdn.microsoft.com/0340ddde-caf4-48ac-8af3-d15dcdade556)
