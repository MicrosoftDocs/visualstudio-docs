---
title: "Markers Report"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.cv.threads.report.markers"
ms.assetid: 829ce099-172e-4c7e-bbd0-578b110c59bd
caps.latest.revision: 6
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
# Markers Report
The Markers Report lists the markers in the displayed time frame.  Panning or zooming, or hiding lanes, might cause markers to appear or disappear. The report contains this information about each marker:  
  
-   The time when it began, relative to the start of the trace.  
  
-   Its duration. The duration is zero for flags and messages because they represent an instant.  
  
-   The ID of the thread that generated it.  
  
-   The Event Tracking for Windows (ETW) provider that generated it.  
  
-   The marker series from which it was written.  
  
-   The category of events it belongs to.  
  
-   Its importance level.  
  
-   Its type (span, flag, or message).  
  
-   A high-level description of what it represents  
  
 Choose the **Export** button to save the Markers Report as a CSV file. You can use the data in the CSV file with other apps or tools.  
  
> [!NOTE]
>  The Markers Report can display 1,000 markers. To see all markers, export the full report to a CSV file.