---
title: "How to: Serialize Symbol Information | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ToolsOptionsPages.Performance.General"
helpviewer_keywords: 
  - "profiling tools, serializing symbol information"
  - "performance tools, serializing symbol information"
ms.assetid: 9e0da706-6325-4073-83d1-aeab3b7c137a
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# How to: Serialize Symbol Information
You can serialize symbols that you must have to analyze your application. Symbol serialization adds symbols to the .vsp file. By adding symbol information to the .vsp file, others can analyze a performance report without having access to the original symbols. If symbols are not serialized, you must have original instrumented .exe and .pdb files to analyze the .vsp file.  
  
### To automatically serialize symbol information  
  
1.  On the **Tools** menu, click **Options**.  
  
     The **Options** dialog box is displayed.  
  
2.  Click **Performance Tools**.  
  
3.  Under **General Setting**, select **Automatically serialize symbol information**.  
  
## See Also  
 [Configuring Performance Sessions](../profiling/configuring-performance-sessions.md)   
 [How to: Reference Windows Symbol Information](../profiling/how-to-reference-windows-symbol-information.md)   
 [How to: Save Analyzed Report Files](http://msdn.microsoft.com/en-us/0340ddde-caf4-48ac-8af3-d15dcdade556)