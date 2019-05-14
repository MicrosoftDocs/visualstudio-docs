---
title: "View data values in Data Tips  in the code editor | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "JScript"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "debugging [Visual Studio], DataTips"
  - "DataTips tool"
ms.assetid: ffa7bd18-439b-4685-a9b3-c7884b5de41f
caps.latest.revision: 41
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# View data values in Data Tips  in the code editor
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

DataTips provide a convenient way to view information about variables in your program during debugging. DataTips work only in break mode and only with variables that are in the current scope of execution.  
  
 In [!INCLUDE[vs_dev10_long](../includes/vs-dev10-long-md.md)], DataTips can be pinned to a specific location in a source file, or they can float on top of all [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] windows.  
  
### To display a DataTip (in break mode only)  
  
1. In a source window, place the mouse pointer over any variable in the current scope.  
  
    A DataTip appears.  
  
   > [!NOTE]
   > Data tips are always evaluated in the context where execution is suspended, and not where the cursor is hovering. If you hover over a variable in another function with the same name as a variable that is in the current context, the value of the variable in the other function is displayed as the value of the variable in the current context.  
  
2. The DataTip disappears when you remove the mouse pointer. To pin the DataTip so that it remains open, click the **Pin to source** icon, or  
  
   - Right-click on a variable, then click **Pin to source**.  
  
     The pinned DataTip closes when the debugging session ends.  
  
### To unpin a DataTip and make it float  
  
- In a pinned DataTip, click the **Unpin from source** icon.  
  
     The pin icon changes to the unpinned position. The DataTip now floats above any open windows. The floating DataTip closes when the debugging session ends.  
  
### To repin a floating DataTip  
  
- In a DataTip, click the pin icon.  
  
     The pin icon changes to the pinned position. If the DataTip is outside a source window, the pin icon is disabled and the DataTip cannot be pinned.  
  
### To close a DataTip  
  
- Place the mouse pointer over a DataTip, and then click the **Close** icon.  
  
### To close all DataTips  
  
- On the **Debug** menu, click **Clear All DataTips**.  
  
### To close all DataTips for a specific file  
  
- On the **Debug** menu, click **Clear All DataTips Pinned to** *File*.  
  
## Expanding and Editing Information  
 You can use DataTips to expand an array, a structure, or an object to view its members. You can also edit the value of a variable from a DataTip.  
  
#### To expand a variable to see its elements  
  
- In a DataTip, put the mouse pointer over the **+** sign that comes before the variable name.  
  
     The variable expands to show its elements in tree form.  
  
     When the variable is expanded, you can use the arrow keys on your keyboard to move up and down. Alternatively, you can use the mouse.  
  
#### To edit the value of a variable using a DataTip  
  
1. In a DataTip, click the value. This is disabled for read-only values.  
  
2. Type a new value and press ENTER.  
  
## Making a DataTip Transparent  
 If you want to see the code that is behind a DataTip, you can make the DataTip temporarily transparent. This does not apply to DataTips that are pinned or floating.  
  
#### To make a DataTip transparent  
  
- In a DataTip, press CTRL.  
  
     The DataTip will remain transparent as long as you hold down the CTRL key.  
  
## Visualizing Complex Data Types  
 If a magnifying glass icon appears next to a variable name in a DataTip, one or more [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md) are available for variables of that data type. You can use a visualizer to display the information in a more meaningful, usually graphical, manner.  
  
#### To view the contents of a variable using a visualizer  
  
- Click the magnifying glass icon to select the default visualizer for the data type.  
  
     -or-  
  
     Click the pop-up arrow next to the visualizer to select from a list of appropriate visualizers for the data type.  
  
     A visualizer displays the information.  
  
## Adding Information to a Watch Window  
 If you want to continue to watch a variable, you can add the variable to the **Watch** window from a DataTip.  
  
#### To add a variable to the Watch window  
  
- Right-click a DataTip, and then click **Add Watch**.  
  
     The variable is added to the **Watch** window. If you are using an edition that supports multiple **Watch** windows, the variable is added to **Watch 1.**  
  
## Importing and Exporting DataTips  
 You can export DataTips to an XML file, which can be shared with a colleague or edited using a text editor.  
  
#### To Export DataTips  
  
1. On the Debug menu, click **Export DataTips**.  
  
     The **Export DataTips** dialog box appears.  
  
2. Use standard file techniques to navigate to the location where you want to save the XML file, type a name for the file in the **File name** box, and then click **OK**.  
  
#### To Import DataTips  
  
1. On the Debug menu, click **Import DataTips**.  
  
     The **Import DataTips** dialog box appears.  
  
2. Use the dialog box to find the XML file that you want to open and click **OK**.  
  
## See Also  
 [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)   
 [How to: Use the QuickWatch Dialog Box](https://msdn.microsoft.com/library/ffaee1dd-e5ce-4ef2-9401-d28329398867)   
 [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)   
 [How to: Change the Numeric Format of Debugger Windows](https://msdn.microsoft.com/library/cd593847-a625-411d-a430-b798346ef18f)
