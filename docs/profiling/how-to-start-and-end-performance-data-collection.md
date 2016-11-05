---
title: "How to: Start and End Performance Data Collection | Microsoft Docs"
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
  - "vs.performance.wizard.summarypage"
helpviewer_keywords: 
  - "profiling tools, launching sessions"
  - "performance sessions, launching"
  - "performance sessions, ending"
  - "profiling tools, ending sessions"
ms.assetid: 9f6eb0d5-d9e9-4bec-b627-445065610bce
caps.latest.revision: 12
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
# How to: Start and End Performance Data Collection
You must add the target binary that you want to profile to the performance session before you start profiling. To add a target, right-click **Targets** in **Performance Explorer**, and then click **Add Target Binary**. In the **Add Target Binary** dialog box, select the file name, and then click **Open**. A new binary is added.  
  
### To start profiling  
  
1.  Right-click the name of the performance session on the **Performance Explorer** window and choose one of the following options:  
  
    -   **Launch with Profiling** - starts the application and immediately begins profiling.  
  
    -   **Launch with Profiling Paused** - starts the application but does not begin profiling. You can start profiling by selecting **Resume Collection** in the **Data Collection Control** window. For more information, see [How to: Pause and Resume Performance Data Collection](../profiling/how-to-pause-and-resume-performance-data-collection.md).  
  
### To end profiling  
  
-   The preferred method of ending a profiling session is to exit the application. To immediately stop profiling, on the **Performance Explorer** toolbar, click **Stop**.  
  
## See Also  
 [Controlling Data Collection](../profiling/controlling-data-collection.md)   
 [How to: Pause and Resume Performance Data Collection](../profiling/how-to-pause-and-resume-performance-data-collection.md)