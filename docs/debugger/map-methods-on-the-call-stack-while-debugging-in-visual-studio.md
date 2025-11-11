---
title: Create a visual map of the call stack
description: Create a code map to visually trace the call stack as you debug. Make notes on the map to track what the code is doing, so you can focus on finding bugs.
ms.date: 11/04/2025
ms.topic: how-to
f1_keywords: 
  - vs.progression.debugwithcodemaps
dev_langs: 
  - CSharp
  - VB
  - FSharp
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
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# Create a visual map of the call stack while debugging (C#, Visual Basic, C++, JavaScript)

Create a code map to visually trace the call stack while you're debugging. You can make notes on the map to track what the code is doing, so you can focus on finding bugs.

For details of commands and actions you can use with code maps, see [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md).

>[!IMPORTANT]
>You can create code maps only in [Visual Studio Enterprise edition](https://aka.ms/vs/download/?cid=learn-onpage-download-cta).

Here's a quick look at a code map:

 ![Debugging with call stacks on code maps](../debugger/media/debuggermap_overview.png "DebuggerMap_Overview")

## <a name="MapStack"></a> Map the call stack

1. In a Visual Studio Enterprise C#, Visual Basic, C++, or JavaScript project, start debugging by selecting **Debug** > **Start Debugging** or pressing **F5**.

1. After your app enters break mode or you step into a function, select **Debug** > **Code Map**, or press **Ctrl**+**Shift**+**`**.

   The current call stack appears in orange on a new code map:

   ![See call stack on code map](../debugger/media/debuggermap_seeundocallstack.png "DebuggerMap_SeeUndoCallStack")

The code map updates automatically as you continue debugging. Changing map items or layout doesn't affect the code in any way. Feel free to rename, move, or remove anything on the map.

To get more information about an item, hover over it and look at the item's tooltip. You can also select **Legend** in the toolbar to learn what each icon means.

![Code Map Legend](../debugger/media/debuggermap_showlegend.png "Code Map Legend")

>[!NOTE]
>The message **The diagram may be based on an older version of the code** at the top of the code map means that the code might have changed after you last updated the map. For example, a call on the map might not exist in code anymore. Close the message, then try rebuilding the solution before updating the map again.

## Map external code

By default, only your own code appears on the map. To see external code on the map:

- Right-click in the **Call Stack** window and select **Show External Code**:

   ![Display external code using the Call Stack window](../debugger/media/debuggermap_callstackmenu.png "DebuggerMap_CallStackMenu")

- Or, clear the **Enable Just My Code** checkbox in Visual Studio:

   ::: moniker range="visualstudio"

   This option is available in the **Tools** (or **Debug**) > **Options** pane under the **All Settings** > **Debugging** > **General** section:

   :::image type="content" source="../debugger/media/visualstudio/dbg-just-my-code-options.png" border="false" alt-text="Screenshot that shows how to select the Enable Just My Code option in Visual Studio.":::

   ::: moniker-end
   ::: moniker range="<=vs-2022"

   This option is available in the **Tools** (or **Debug**) > **Options** dialog under the **Debugging** > **General** section:

   ![Show external code using Options dialog](../debugger/media/debuggermap_debugoptions.png "DebuggerMap_DebugOptions")
   
   ::: moniker-end

## Control the map's layout

Changing the map's layout doesn't affect the code in any way.

To control the map's layout, select the **Layout** menu on the map toolbar.

In the **Layout** menu, you can:

- Change the default layout.
- Stop rearranging the map automatically, by deselecting **Automatically Layout when Debugging**.
- Rearrange the map as little as possible when you add items, by deselecting **Incremental Layout**.

## <a name="MakeNotes"></a> Make notes about the code

You can add comments to track what's happening in the code.

To add a comment, right-click in the code map and select **Edit** > **New Comment**, then type the comment.

To add a new line in a comment, press **Shift**+**Enter**.

 ![Add comment to call stack on code map](../debugger/media/debuggermap_addcomment.png "DebuggerMap_AddComment")

## <a name="UpdateMap"></a> Update the map with the next call stack

As you run your app to the next breakpoint or step into a function, the map adds new call stacks automatically.

![Update code map with next call stack](../debugger/media/debuggermap_addclearcallstack.png "DebuggerMap_AddClearCallStack")

To stop the map from adding new call stacks automatically, select ![Show call stack on code map automatically](../debugger/media/debuggermap_automaticupdateicon.gif "Show call stack on code map automatically") on the code map toolbar. The map continues to highlight existing call stacks. To manually add the current call stack to the map, press **Ctrl**+**Shift**+**`**.

## <a name="AddRelatedCode"></a> Add related code to the map

Now that you've got a map, in C# or Visual Basic, you can add items like fields, properties, and other methods, to track what's happening in the code.

To go to the definition of a method in the code, double-click the method in the map, or select it and press **F12**, or right-click it and select **Go To Definition**.

![Go to code definition for a method on code map](../debugger/media/debuggermap_gotocodedefinition.png "DebuggerMap_GoToCodeDefinition")

To add items that you want to track to the map, right-click a method and select the items you want to track. The most recently added items appear in green.

![Fields related to a method on call stack code map](../debugger/media/debuggermap_showedfields.png "DebuggerMap_ShowedFields")

>[!NOTE]
>By default, adding items to the map also adds the parent group nodes such as the class, namespace, and assembly. You can turn this feature off and on by selecting the **Include Parents** button on the code map toolbar, or by pressing **Ctrl** while you add items.

![Show fields in a method on call stack code map](../debugger/media/debuggermap_showfields.png "DebuggerMap_ShowFields")

Continue building the map to see more code.

 ![See methods that use a field: call stack code map](../debugger/media/debuggermap_findallreferences.png "DebuggerMap_FindAllReferences")

 ![Methods that use a field on call stack code map](../debugger/media/debuggermap_foundallreferences.png "DebuggerMap_FoundAllReferences")

## <a name="FindBugs"></a> Find bugs using the map
 Visualizing your code can help you find bugs faster. For example, suppose you're investigating a bug in a drawing app. When you draw a line and try to undo it, nothing happens until you draw another line.

 So you set breakpoints in the `clear`, `undo`, and `Repaint` methods, start debugging, and build a map like this one:

 ![Add another call stack to code map](../debugger/media/debuggermap_addpaintobjectcallstack.png "DebuggerMap_AddPaintObjectCallStack")

 You notice that all the user gestures on the map call `Repaint`, except for `undo`. This might explain why `undo` doesn't work immediately.

 After you fix the bug and continue running the app, the map adds the new call from `undo` to `Repaint`:

 ![Add new method call to call stack on code map](../debugger/media/debuggermap_addnewcallforrepaint.png "DebuggerMap_AddNewCallForRepaint")

## Share the map with others

You can export a map, send it to others with Microsoft Outlook, save it to your solution, and check it into version control.

To share or save the map, use **Share** in the code map toolbar.

![Share call stack code map with others](../debugger/media/debuggermap_sharewithothers.png "Share call stack code map with others")

## Related content
- [Map dependencies across your solutions](../modeling/map-dependencies-across-your-solutions.md)
- [Use code maps to debug your applications](../modeling/use-code-maps-to-debug-your-applications.md)
- [Find potential problems using code map analyzers](../modeling/find-potential-problems-using-code-map-analyzers.md)
- [Browse and rearrange code maps](../modeling/browse-and-rearrange-code-maps.md)
