---
title: "Utilization Navigator | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
f1_keywords: 
  - "vs.cv.performance.utilizationnavigator"
ms.assetid: 522a981a-37ef-4cdd-a04c-f1e7525a2aab
caps.latest.revision: 14
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Utilization Navigator
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the Utilization Navigator in the Concurrency Visualizer to select an interval of time in a trace. The Concurrency Visualizer shows the utilization of CPU cores by the target process over time. This makes it easier to examine CPU utilization patterns and also enables comparison between the utilization data and the data in other views. The Utilization Navigator appears at the top of every view in the Concurrency Visualizer. The following illustration shows the Utilization Navigator.  
  
 ![Utilization Navigator showing selected timeframe](../profiling/media/cvutilizationnavigator.png "CVUtilizationNavigator")  
Utilization Navigator and a selected time frame  
  
 In the illustration, the selected interval is defined by a red rectangle, known as the *thumb*.  
  
 Here's how you can use the Utilization Navigator to manipulate the displayed time range:  
  
- You can pan by dragging the thumb left or right. (Keyboard: Move the focus to the thumb and then press the left or right arrow key.)  
  
- You can change the extent of the interval by dragging one of the handles. (Keyboard: Move the focus to a handle and then press the right or left arrow key.)  
  
  If you change the interval by using a different Concurrency Visualizer zoom control, the Utilization Navigator updates to reflect the change.
