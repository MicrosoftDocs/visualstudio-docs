---
title: "How to: Use the WPF Tree Visualizer | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "WPF, debugging"
  - "debugging, WPF"
ms.assetid: 2a1bf1cd-90f9-4d06-9fb4-1bfc925afef3
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Use the WPF Tree Visualizer
You can use the WPF Tree visualizer to explore the visual tree of a WPF object, and to view the WPF dependency properties for the objects that are contained in that tree. For more information about visual trees, see [Trees in WPF](/dotnet/framework/wpf/advanced/trees-in-wpf). For more information about dependency properties, see [Dependency Properties Overview](/dotnet/framework/wpf/advanced/dependency-properties-overview).

 When you open the WPF Tree visualizer, you will see two panes: the **Visual Tree** on the left and the **Properties of** _Name_**:**_Type_ pane on the right. Select any object in the **Visual Tree** pane, and the **Properties of** _Name_**:**_Type_ pane is automatically updated to show the properties for that object.

 > [!NOTE]
 > You can also use the [Live Visual Tree and Live Property Explorer](../xaml-tools/inspect-xaml-properties-while-debugging.md) to examine the visual tree of WPF objects. The WPF Tree Visualizer is a legacy feature and is not in active development.

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

- In the **Properties of** _Name_**:**_Type_ pane, type the string you want to search for in the **Filter** box.

  The WPF Tree visualizer immediately finds the properties that match the string you have typed; now, the list displays only those properties matching the string you have typed. Type more characters to find a more-accurate match.

  - To clear the search criteria, click **Clear**.

### To close the visualizer

- Click the **Close** icon in the upper-right corner of the dialog box.

## See also
- [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)
- [Trees in WPF](/dotnet/framework/wpf/advanced/trees-in-wpf)
- [Dependency Properties Overview](/dotnet/framework/wpf/advanced/dependency-properties-overview)
