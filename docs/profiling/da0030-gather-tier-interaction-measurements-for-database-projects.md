---
title: "DA0030: Gather Tier Interaction measurements for database projects | Microsoft Docs"
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
  - "vs.performance.DA0030"
  - "vs.performance.rules.DA0030"
  - "vs.performance.30"
ms.assetid: 42b2f69d-0cfa-4854-82c4-589c3d8b4557
caps.latest.revision: 7
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
# DA0030: Gather Tier Interaction measurements for database projects
|||  
|-|-|  
|Rule Id|DA0030|  
|Category|Profiling Tools Usage|  
|Profiling method|Sampling|  
|Message|Gathering interaction measurements for multi-tiered applications will help you understand database usage patterns and key data access delays. Try profiling the application again with the Tier Interaction Profiling option enabled.|  
|Rule type|Information|  
  
## Cause  
 Calls to <xref:System.Data> methods are a significant proportion of the profiling data and you have not collected tier interaction data in the profiling run. Consider profiling again and adding tier interaction data.  
  
## Rule Description  
 This rule fires whenever there is significant activity in functions that reside in the System.Data namespaces, including <xref:System.Data.Linq><xref:System.Data.Linq>.  
  
 Multi-tiered applications use layered services for their presentation and data layers. Often the data layer is a separate process running a database management system such as Microsoft Sql Server. The data layer might even be running on a separate machine from the rest of the application. Sampling profiles provide little insight into functions and services running out-of-process or remotely.  
  
 The profiling tools can gather timing information for multi-tiered applications that are interacting with a Microsoft Sql Server data layer using asynchronous calls to ADO.NET services. You must explicitly enable Tier Interaction Profiling. It is not turned on by default.  
  
## How to Fix Violations  
 This rule is for information only, and might not require corrective action.  
  
 For information about how to add tier interaction data to profiling data from the Visual Studio IDE, see [Collecting tier interaction data](../profiling/collecting-tier-interaction-data.md). For information about how to add tier interaction data from the command line, see [Collecting tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md).