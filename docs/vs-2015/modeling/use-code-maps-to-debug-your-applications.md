---
title: "Use code maps to debug your applications | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio Ultimate, visualizing code"
  - "Visual Studio Ultimate, navigating code visually"
  - "Visual Studio Ultimate, understanding code"
  - "Visual Studio Ultimate, mapping code relationships"
  - "Visual Studio Ultimate, code maps"
  - "mapping code relationships"
  - "code maps"
  - "mapping relationships in code"
ms.assetid: 9fd0c9a2-d351-40c8-be88-0749788264bf
caps.latest.revision: 51
author: gewarren
ms.author: gewarren
manager: jillfra
---
# Use code maps to debug your applications
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Code maps can help you avoid getting lost in large code bases, unfamiliar code, or legacy code. For example, when you’re debugging, you might have to look at code across many files and projects. Use code maps to navigate around pieces of code and understand the relationships between them. That way, you don't have to keep track of this code in your head, or draw a separate diagram. So, when your work is interrupted, code maps help refresh your memory about the code you're working on.  
  
 ![Code map &#45; Map relationships in code](../modeling/media/codemapstoryboardpaint.png "CodeMapStoryboardPaint")  
  
 **A green arrow shows where your cursor appears in the editor**  
  
 For details of the commands and actions you can use when working with code maps, see [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md).  
  
## Understand the problem  
 Suppose there's a bug in a drawing program that you're working on. To reproduce the bug, you open the solution in Visual Studio and press **F5** to start debugging.  
  
 When you draw a line and choose **Undo my last stroke**, nothing happens until you draw the next line.  
  
 ![Code map &#45; Repro bug](../modeling/media/codemapstoryboardpaint0.png "CodeMapStoryboardPaint0")  
  
 So you start investigating by searching for the `Undo` method. You find it in the `PaintCanvas` class.  
  
 ![Code map &#45; Find code](../modeling/media/codemapstoryboardpaint1.png "CodeMapStoryboardPaint1")  
  
## Start mapping the code  
 Now start mapping the `undo` method and its relationships. From the code editor, you add the `undo` method and the fields that it references to a new code map. When you create a new map, it might take some time to index the code. This helps later operations run faster.  
  
 ![Code map &#45; Show method and related fields](../modeling/media/codemapstoryboardpaint3.png "CodeMapStoryboardPaint3")  
  
> [!TIP]
> The green highlighting shows the last items that were added to the map. The green arrow shows your cursor’s position in the code. Arrows between items represent different relationships. You can get more info about items on the map by moving the mouse over them and examining their tooltips.  
  
 ![Code map &#45; Show tooltips](../modeling/media/codemapstoryboardpaint4.png "CodeMapStoryboardPaint4")  
  
## Navigate and examine code from the map  
 To see the code definition for each field, double-click the field on the map or select the field and press **F12**. The green arrow moves between items on the map. Your cursor in the code editor also moves automatically.  
  
 ![Code map &#45; Examine field definition](../modeling/media/codemapstoryboardpaint5.png "CodeMapStoryboardPaint5")  
  
 ![Code map &#45; Examine field definition](../modeling/media/codemapstoryboardpaint5a.png "CodeMapStoryboardPaint5A")  
  
> [!TIP]
> You can also move the green arrow on the map by moving your cursor in the code editor.  
  
## Understand relationships between pieces of code  
 Now you want to know which other code interacts with the `history` and `paintObjects` fields. You can add all the methods that reference these fields to the map. You can do this from the map or from the code editor.  
  
 ![Code map &#45; Find all references](../modeling/media/codemapstoryboardpaint6.png "CodeMapStoryboardPaint6")  
  
 ![Open a code map from the code editor](../modeling/media/codemapstoryboardpaint6a.PNG "CodeMapStoryboardPaint6A")  
  
> [!NOTE]
> If you add items from a project that's shared across multiple apps, like Windows Phone or Windows Store, then those items always appear with the currently active app project on the map. So, if you change the context to another app project, then the context on the map also changes for any newly added items from the shared project. Operations that you perform with an item on the map apply only to those items that share the same context.  
  
 Change the layout to rearrange the flow of relationships and make the map easier to read. You can also move items around the map by dragging them.  
  
 ![Code map &#45; Change layout](../modeling/media/codemapstoryboardpaint7a.png "CodeMapStoryboardPaint7A")  
  
> [!TIP]
> By default, **Incremental Layout** is turned on. This rearranges the map as little as possible when you add new items. To rearrange the entire map every time you add new items, turn off **Incremental Layout**.  
  
 ![Code map &#45; Change layout](../modeling/media/codemapstoryboardpaint7.png "CodeMapStoryboardPaint7")  
  
 Let's examine these methods. On the map, double-click the **PaintCanvas** method, or select this method and press **F12**. You learn that this method creates `history` and `paintObjects` as empty lists.  
  
 ![Code map &#45; Examine method definition](../modeling/media/codemapstoryboardpaint8.png "CodeMapStoryboardPaint8")  
  
 Now repeat the same steps to examine the `clear` method definition. You learn that `clear` performs some tasks with `paintObjects` and `history`. It then calls the `Repaint` method.  
  
 ![Code map &#45; Examine method definition](../modeling/media/codemapstoryboardpaint9.png "CodeMapStoryboardPaint9")  
  
 Now examine the `addPaintObject` method definition. It also performs some tasks with `history` and `paintObjects`. It also calls `Repaint`.  
  
 ![Code map &#45; Examine method definition](../modeling/media/codemapstoryboardpaint10.png "CodeMapStoryboardPaint10")  
  
## Find the problem by examining the map  
 It seems that all the methods that modify `history` and `paintObjects` call `Repaint`. Yet the `undo` method doesn't call `Repaint`, even though `undo` modifies the same fields. So you think you can fix this problem by calling `Repaint` from `undo`.  
  
 ![Code map &#45; Find missing method call](../modeling/media/codemapstoryboardpaint11.png "CodeMapStoryboardPaint11")  
  
 If you didn't have a map to show you this missing call, it might have been harder to find this problem, especially with more complex code.  
  
## Share your discovery and next steps  
 Before you or someone else fixes this bug, you can make notes on the map about the problem and how to fix it.  
  
 ![Code map &#45; Comment and flag items for followup](../modeling/media/codemapstoryboardpaint12.png "CodeMapStoryboardPaint12")  
  
 For example, you can add comments to the map and flag items using colors.  
  
 ![Code map &#45; Commented and flagged items](../modeling/media/codemapstoryboardpaint12a.png "CodeMapStoryboardPaint12A")  
  
 If you have Microsoft Outlook installed, you can email the map to others. You can also export the map as an image or another format.  
  
 ![Code map &#45; Share, export, mail](../modeling/media/codemapstoryboardpaint13.png "CodeMapStoryboardPaint13")  
  
## Fix the problem and show what you did  
 To fix this bug, you add the call for `Repaint` to `undo`.  
  
 ![Code map &#45; Add missing method call](../modeling/media/codemapstoryboardpaint14.png "CodeMapStoryboardPaint14")  
  
 To confirm your fix, you restart your debugging session and try to reproduce the bug. Now choosing **Undo my last stroke** works as you expect and confirms you made the correct fix.  
  
 ![Code map &#45; Confirm code fix](../modeling/media/codemapstoryboardpaint15.png "CodeMapStoryboardPaint15")  
  
 You can update the map to show the fix you made.  
  
 ![Code map &#45; Update map with missing method call](../modeling/media/codemapstoryboardpaint16.png "CodeMapStoryboardPaint16")  
  
 Your map now shows a link between **undo** and **Repaint**.  
  
 ![Code map &#45; Updated map with method call](../modeling/media/codemapstoryboardpaint17.png "CodeMapStoryboardPaint17")  
  
> [!NOTE]
> When you update the map, you might see a message that says the code index used to create your map was updated. This means someone changed the code, which causes your map to not match the current code. This doesn't stop you from updating the map, but you might have to recreate the map to confirm that it matches the code.  
  
 Now you’re done with your investigation. You successfully found and fixed the problem by mapping the code. You also have a map that helps you navigate around the code, remember what you learned, and shows the steps you took to fix the problem.  
  
## See also  
 [Map methods on the call stack while debugging](../debugger/map-methods-on-the-call-stack-while-debugging-in-visual-studio.md)   
 [Visualize code](../modeling/visualize-code.md)
