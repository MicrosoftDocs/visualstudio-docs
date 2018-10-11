---
title: "DA0029: Unsupported CLR Version | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.performance.29"
  - "vs.performance.rules.DA0029"
helpviewer_keywords: 
  - "vs.performance.29"
  - "vs.performance.DA0029"
  - "vs.performance.rules.DA0029"
ms.assetid: 76247259-c6f3-44c4-b3f9-d8dac16b5e0d
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# DA0029: Unsupported CLR Version
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Rule Id|DA0029|  
|Category|Profiling Tools Usage|  
|Profiling method|Profiling from the command line|  
|Message|An unsupported CLR version was detected during collection. Managed symbols may not resolve correctly.|  
|Rule type|Information.|  
  
## Cause  
 You are trying to profile an application that uses the [!INCLUDE[net_v11_long](../includes/net-v11-long-md.md)] that is not supported by the Profiling Tools.  
  
## Rule Description  
 This warning occurs because the profiling tools will be unable to resolve symbols for the managed code running in the application. The profiling tools cannot resolve managed code symbols for applications that are running the [!INCLUDE[net_v11_long](../includes/net-v11-long-md.md)].  
  
## How to Fix Violations  
 None.



