---
title: "Understanding Resource Contention Data Values"
ms.custom: na
ms.date: 10/04/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 071c0f0f-1eba-4dc8-ae87-0810e4086dd0
caps.latest.revision: 9
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Understanding Resource Contention Data Values
Resource contention profiling collects detailed call stack information each time competing threads in an application are forced to wait for access to a shared resource.  
  
 **Requirements**  
  
-   Visual Studio Ultimate, Visual Studio Premium, Visual Studio Professional  
  
 Resource contention reports display the total number of contentions and the total time that was spent waiting for a resource for the modules, functions, source code lines, and instructions in which the waiting occured.  
  
-   Inclusive values display the total number of contentions that forced a function to wait by resource contentions and the total time that the function waited.  Contentions that were caused by child functions that were called by the function are included in inclusive values.  
  
-   Exclusive values display only the number of contentions that forced a function to wait and that were caused by code in the body of the function. Contentions caused by child functions are not included. The exclusive time for the function also includes only the wait times that were caused by statements in the function body.  
  
 Resource contention report views also include timeline graphs that show the individual contention events over time and show the call stacks that created the particular event. For more information, see one of the following topics:  
  
-   [Thread Details View](../VS_IDE/Thread-Details-View---Contention-Data.md)  
  
-   [Resource Details View](../VS_IDE/Resource-Details-View---Contention-Data.md)  
  
 For more information about the second mode of concurrency profiling, see [Concurrency Visualizer](../VS_IDE/Concurrency-Visualizer.md).