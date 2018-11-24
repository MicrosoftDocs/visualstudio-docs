---
title: "View data values in DataTips in the code editor | Microsoft Docs"
ms.custom: ""
ms.date: "11/21/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
helpviewer_keywords: 
  - "debugging [Visual Studio], DataTips"
  - "DataTips tool"
ms.assetid: ffa7bd18-439b-4685-a9b3-c7884b5de41f
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# View data values in DataTips in the code editor

DataTips are a convenient way to view information about variables in your app during debugging. DataTips appear only in break mode, and only on variables that are in the current scope of execution. 

If this is your first time debugging, you may want to read [Write better C# code using Visual Studio](../debugger/write-better-code-with-visual-studio.md) and [Debugging for absolute beginners](../debugger/debugging-absolute-beginners.md) before you read this article.
  
### To display a DataTip  
  
1. Set a breakpoint in your code, and start debugging by pressing **F5** or selecting **Debug** > **Start Debugging**.
  
1. When paused at the breakpoint, hover over any variable in the current scope. A DataTip appears.
   

### Pin a DataTip

To pin a DataTip so that it stays open, select the pushpin **Pin to source** icon. 

![Pin a DataTip](../debugger/media/dbg-tips-data-tips-pinned.png "Pin a DataTip")

You can move a pinned DataTip by dragging it around the code window. 

>[!NOTE]
>DataTips are always evaluated in the context where execution is suspended, not the cursor or DataTip location. If you hover over a variable in another function that has the same name as a variable in the current context, the value of the variable in the current context is displayed.
  
### Float a DataTip

To float a pinned DataTip, hover over the DataTip and select the pushpin icon from the context menu. 

The pushpin icon changes to the unpinned position, and the DataTip now floats or can be dragged above all open windows. Floating DataTips close when the debugging session ends.  
  
### Repin a DataTip  
  
To repin a floating DataTip, hover over it in the code editor and select the pushpin icon. The pushpin icon changes to the pinned position, and the DataTip is pinned only to the code window. 

If a DataTip is floating over a non-source code window, the pushpin icon is unavailable, and the DataTip cannot be repinned. To access the pushpin icon, return the DataTip to the code editor window by dragging it or giving the code window focus. 
  
### Close a DataTip  
  
To close a DataTip, hover over the DataTip and select the close (**x**) icon from the context menu.  
  
### Close all DataTips  
  
To close all DataTips, on the **Debug** menu, select **Clear All DataTips**.  
  
### Close all DataTips for a specific file  
  
To close all DataTips for a specific file, on the **Debug** menu, select **Clear All DataTips Pinned to \<Filename>**.  
  
## Expand and edit information  
You can use DataTips to expand an array, a structure, or an object to view its members. You can also edit the value of a variable from a DataTip.  
  
### Expand a variable

To expand a variable in a DataTip to see its elements, select the **+** before the variable name, then hover over the expand arrows to display the elements in tree form.

![Expand a DataTip](../debugger/media/dbg-tour-data-tips.png "Expand a DataTip")

You can use the mouse or the arrow keys on the keyboard to move up and down in the expanded view. 

You can also pin any element to the DataTip by hovering over it and selecting its pushpin icon. The element then appears in the DataTip after the tree is collapsed. 

### Edit the value of a variable

To edit the value of a variable or element in a DataTip, select the value, type a new value, and press **Enter**. Selection is disabled for read-only values.  

### Make a DataTip transparent  

To make a DataTip transparent to see code that is underneath it, while in the DataTip, press **Ctrl**. The DataTip stays transparent as long as you hold down the **Ctrl** key. This doesn't work for pinned or floating DataTips.  
## Visualize complex data types  

A magnifying glass icon next to a variable or element in a DataTip means that one or more [visualizers](../debugger/create-custom-visualizers-of-data.md), such as the [Text Visualizer](../debugger/string-visualizer-dialog-box.md), are available for the variable. Visualizers display information in a more meaningful, sometimes graphical, manner.
  
To view the element using the default visualizer for the data type, select the magnifying glass icon ![Visualizer icon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon"). Select the arrow next to the magnifying glass icon to select from a list of visualizers for the data type.  

## Add a variable to a Watch window  

If you want to continue to watch a variable, you can add it to a **Watch** window from a DataTip. Right-click the variable in the DataTip, and select **Add Watch**. 

The variable appears in the **Watch** window. If your Visual Studio edition supports more than one **Watch** window, the variable appears in **Watch 1**. 
  
## Import and export DataTips  

You can export DataTips to an XML file, which you can share or edit using a text editor. You can also import a DataTip XML file you have received or edited. 
  
**To export DataTips:** 
  
1. Select **Debug** > **Export DataTips**.  
   
1. In the **Export DataTips** dialog box, navigate to the location to save the XML file, type a name for the file, and then select **Save**.  
  
**To import DataTips:** 
  
1. Select **Debug** > **Import DataTips**.  
   
1. In the **Import DataTips** dialog box, select the DataTips XML file you want to open, and then select **Open**.  

## See also  
 [What is debugging?](../debugger/what-is-debugging.md)  
 [Write better C# code using Visual Studio](../debugger/write-better-code-with-visual-studio.md)  
 [First look at debugging](../debugger/debugger-feature-tour.md)   
 [View data in the debugger](../debugger/viewing-data-in-the-debugger.md)   
 [Watch and QuickWatch windows](../debugger/watch-and-quickwatch-windows.md)   
 [Create custom visualizers](../debugger/create-custom-visualizers-of-data.md)   
