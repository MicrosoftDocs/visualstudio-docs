---
title: "How to: Use the WPF Tree Visualizer | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "WPF, debugging"
  - "debugging, WPF"
ms.assetid: 2a1bf1cd-90f9-4d06-9fb4-1bfc925afef3
caps.latest.revision: 21
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Use the WPF Tree Visualizer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can use the WPF Tree visualizer to explore the visual tree of a WPF object, and to view the WPF dependency properties for the objects that are contained in that tree. For more information about visual trees, see [Trees in WPF](https://msdn.microsoft.com/library/e83f25e5-d66b-4fc7-92d2-50130c9a6649). For more information about dependency properties, see [Dependency Properties Overview](https://msdn.microsoft.com/library/d119d00c-3afb-48d6-87a0-c4da4f83dee5).  
  
 When you open the WPF Tree visualizer, you will see two panes: the **Visual Tree** on the left and the **Properties of** _Name_**:**_Type_ pane on the right. Select any object in the **Visual Tree** pane, and the **Properties of** _Name_**:**_Type_ pane is automatically updated to show the properties for that object.  
  
### To open the WPF Tree visualizer  
  
1. In a DataTip, **Watch** window, **Autos** window, or **Locals** window, next to a WPF object name, click the arrow adjacent to the magnifying glass icon.  
  
     A list of visualizers is displayed.  
  
2. Click **WPF Tree Visualizer**.  
  
### To search the visual tree  
  
- In the **Visual Tree** pane, type the string you want to search for in the **Search** box.  
  
  The WPF Tree visualizer immediately finds the first object in the visual tree that matches the string you have typed. Type more characters to find a more accurate match.  

  - To go to the next match within the visual tree, click **Next**.  

  - To go back to the previous match, click **Prev**.  

  - To clear the search criteria, click **Clear**.  

### To search the properties list  
  
- In the **Properties of** _Name_**:**_Type_ pane, type the string your want to search for in the **Filter** box.  
  
  The WPF Tree visualizer immediately finds the properties that match the string you have typed; now, the list displays only those properties matching the string you have typed. Type more characters to find a more-accurate match.  

  - To clear the search criteria, click **Clear**.  
  
### To close the visualizer  
  
- Click the **Close** icon in the upper-right corner of the dialog box.  
  
## See Also  
 [How to: Use a Visualizer](../misc/how-to-use-a-visualizer.md)   
 [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)   
 [Trees in WPF](https://msdn.microsoft.com/library/e83f25e5-d66b-4fc7-92d2-50130c9a6649)   
 [Dependency Properties Overview](https://msdn.microsoft.com/library/d119d00c-3afb-48d6-87a0-c4da4f83dee5)
