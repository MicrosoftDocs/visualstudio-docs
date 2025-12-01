---
title: Map methods on the call stack while debugging
description: Learn how to create a code map to visually trace the call stack while you're debugging. Also, learn that you can make notes on the map to track what the code is doing.
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords:
- vs.progression.debugwithcodemaps
dev_langs:
- FSharp
- VB
- CSharp
- C++
helpviewer_keywords:
- call stacks, code maps
- Call Stack window, mapping calls
- debugging [Visual Studio], diagramming the call stack
- call stacks, mapping
- Call Stack window, visualizing
- debugging code visually
- debugging [Visual Studio], mapping the call stack
- call stacks, visualizing
- debugging, code maps
- Call Stack window, tracing calls visually
- Call Stack window, show on code map
- debugging [Visual Studio], tracing the call stack visually
- debugging [Visual Studio], visualizing the call stack
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Map methods on the call stack while debugging in Visual Studio

Create a code map to visually trace the call stack while you're debugging. You can make notes on the map to track what the code is doing so you can focus on finding bugs.

 ![Debugging with call stacks on code maps](../debugger/media/debuggermap_overview.png)

 You'll need:

- [Visual Studio Enterprise](https://aka.ms/vs/download/?cid=learn-onpage-download-cta)

- Code that you can debug, such as Visual C#, Visual Basic, C++, JavaScript, or X++

  See:

- [Map the call stack](#MapStack)

- [Make notes about the code](#MakeNotes)

- [Update the map with the next call stack](#UpdateMap)

- [Add related code to the map](#AddRelatedCode)

- [Find bugs using the map](#FindBugs)

- [Q & A](#QA)

  For details of the commands and actions you can use when working with code maps, see [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md).

## <a name="MapStack"></a> Map the call stack

1. Start debugging. (Keyboard: **F5**)

2. After your app enters break mode or you step into a function, choose **Code Map**. (Keyboard: **Ctrl** + **Shift** + **`**)

     ![Choose Code Map to start mapping call stack](../debugger/media/debuggermap_choosecodemap.png)

     The current call stack appears in orange on a new code map:

     ![See call stack on code map](../debugger/media/debuggermap_seeundocallstack.png)

     The map will update automatically while you continue debugging. See [Update the map with the next call stack](#UpdateMap).

## <a name="MakeNotes"></a> Make notes about the code

 Add comments to track what's happening in the code. To add a new line in a comment, press **Shift + Return**.

 ![Add comment to call stack on code map](../debugger/media/debuggermap_addcomment.png)

## <a name="UpdateMap"></a> Update the map with the next call stack

 Run your app to the next breakpoint or step into a function. The map adds a new call stack.

 ![Update code map with next call stack](../debugger/media/debuggermap_addclearcallstack.png)

## <a name="AddRelatedCode"></a> Add related code to the map

 Now you've got a map - what next? If you're working with C# or Visual Basic, add items, such as fields, properties, and other methods, to track what's happening in the code.

 Double-click a method to see its code definition, or use the shortcut menu for the method. (Keyboard: Select the method on the map and press **F12**)

 ![Go to code definition for a method on code map](../debugger/media/debuggermap_gotocodedefinition.png)

 Add the items that you want to track on the map.

 ![Show fields in a method on call stack code map](../debugger/media/debuggermap_showfields.png)

> [!NOTE]
> By default, adding items to the map also adds the parent group nodes such as the class, namespace, and assembly. While this is useful, you can keep the map simple by turning off this feature using the **Include Parents** button on the map toolbar, or by pressing **CTRL** when you add items.

 ![Fields related to a method on call stack code map](../debugger/media/debuggermap_showedfields.png)

 Here you can easily see which methods use the same fields. The most recently added items appear in green.

 Continue building the map to see more code.

 ![See methods that use a field: call stack code map](../debugger/media/debuggermap_findallreferences.png)

 ![Methods that use a field on call stack code map](../debugger/media/debuggermap_foundallreferences.png)

## <a name="FindBugs"></a> Find bugs using the map

 Visualizing your code can help you find bugs faster. For example, suppose you're investigating a bug in a drawing program. When you draw a line and try to undo it, nothing happens until you draw another line.

 So you set breakpoints in the `clear`, `undo`, and `Repaint` methods, start debugging, and build a map like this one:

 ![Add another call stack to code map](../debugger/media/debuggermap_addpaintobjectcallstack.png)

 You notice that all the user gestures on the map call `Repaint`, except for `undo`. This might explain why `undo` doesn't work immediately.

 After you fix the bug and continue running the program, the map adds the new call from `undo` to `Repaint`:

 ![Add new method call to call stack on code map](../debugger/media/debuggermap_addnewcallforrepaint.png)

## <a name="QA"></a> Q & A

- **Not all calls appear on the map. Why?**

   By default, only your own code appears on the map. To see external code, turn it on in the **Call Stack** window:

   ![Display external code using the Call Stack window](../debugger/media/debuggermap_callstackmenu.png)

   or turn off **Enable Just My Code** in the Visual Studio debugging options:

   ![Show external code using Options dialog](../debugger/media/debuggermap_debugoptions.png)

- **Does changing the map affect the code?**

   Changing the map doesn't affect the code in any way. Feel free to rename, move, or remove anything on the map.

- **What does this message mean: "The diagram may be based on an older version of the code"?**

   The code might have changed after you last updated the map. For example, a call on the map might not exist in code anymore. Close the message, then try rebuilding the solution before updating the map again.

- **How do I control the map's layout?**

   Open the **Layout** menu on the map toolbar:

  - Change the default layout.

  - To stop rearranging the map automatically, turn off **Automatically Layout when Debugging**.

  - To rearrange the map as little as possible when you add items, turn off **Incremental Layout**.

- **Can I share the map with others?**

   You can export the map, send it to others if you have Microsoft Outlook, or save it to your solution so you can check it into source control.

   ![Share call stack code map with others](../debugger/media/debuggermap_sharewithothers.png)

- **How do I stop the map from adding new call stacks automatically?**

   Choose ![Button &#45; Show call stack on code map automatically](../debugger/media/debuggermap_automaticupdateicon.gif) on the map toolbar. To manually add the current call stack to the map, press **Ctrl** + **Shift** + **`**.

   The map will continue highlighting existing call stacks on the map while you're debugging.

- **What do the item icons and arrows mean?**

   To get more info about an item, move the mouse pointer over it and look at the item's tooltip. You can also look at the **Legend** to learn what each icon means.

   ![What do icons on the call stack code map mean?](../debugger/media/debuggermap_showlegend.png)

  See:

- [Map the call stack](#MapStack)

- [Make notes about the code](#MakeNotes)

- [Update the map with the next call stack](#UpdateMap)

- [Add related code to the map](#AddRelatedCode)

- [Find bugs using the map](#FindBugs)

## Related content

- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)
- [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)
- [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)
- [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md)
