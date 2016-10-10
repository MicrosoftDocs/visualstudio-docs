---
title: "Empty Timeline Segment"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f37b301f-3edc-4e56-8084-feec2dc5a9b1
caps.latest.revision: 11
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
# Empty Timeline Segment
In the Concurrency Visualizer, the reason that a section of the timeline is empty (has a white background) depends on the kind of channel.  
  
-   For a CPU thread channel, it means that the thread did not exist during this part of the timeline. If you're interested in the thread, you can find its executing section by using the zoom control or scrolling horizontally.  
  
-   For an I/O channel, it means that no disk access occurred on behalf of the target process at that point in time.  
  
-   For a DirectX channel, it means that no GPU work was performed on behalf of the target process during this part of the timeline.  
  
-   For a marker channel, it means that no markers were generated.  
  
## See Also  
 [Threads View](../VS_IDE/Threads-View--Parallel-Performance-.md)   
 [Zoom Control (Threads View)](../VS_IDE/Zoom-Control--Threads-View-.md)