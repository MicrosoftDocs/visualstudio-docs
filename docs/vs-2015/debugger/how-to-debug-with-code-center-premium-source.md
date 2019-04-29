---
title: "How to: Debug with Code Center Premium Source | Microsoft Docs"
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
  - "Code Center Premium"
  - "debugging [Visual Studio], Code Center Premium"
ms.assetid: 18b4769d-b007-4428-9dae-9e72c283ff0d
caps.latest.revision: 26
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Debug with Code Center Premium Source
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

With the [!INCLUDE[vs_dev11_long](../includes/vs-dev11-long-md.md)] debugger, you can debug secure shared source from Microsoft MSDN Code Center Premium.  
  
 This topic explains how to set up and debug Code Center Premium source code in Visual Studio.  
  
### To prepare for debugging with Code Center Premium  
  
1. Connect your SmartCard reader and insert the card you obtained from the Shared Source Initiative.  
  
2. Launch Visual Studio.  
  
3. On the **Tools** menu, click **Options**.  
  
4. In the **Options** dialog box, open the **Debugging** node and click **General**.  
  
5. Clear the **Enable Just My Code (Managed Only)** check box.  
  
6. Select **Enable Source Server Support**.  
  
7. Clear **Require source files to exactly match the original version**.  
  
8. Under the **Debugging** node, click **Symbols**.  
  
9. In the **Symbol File (.pdb) Locations** box, clear the **Microsoft Server Symbols** check box and add the following locations:  
  
     `https://codepremium.msdn.microsoft.com/symbols`  
  
     `src=https://codepremium.msdn.microsoft.com/source/Visual%20Studio%202010/SP1/`  
  
   > [!NOTE]
   > Be sure to include the trailing slash<strong>/</strong> at the end of the path.  
  
     Move these locations to the top of the list to ensure that these symbols are loaded first.  
  
   > [!NOTE]
   > These Code Center Premium locations must be listed first so that they are the first locations that are loaded. In Visual Studio 2010, you cannot move any servers above the **Microsoft Symbol Servers** entry, which is why you must clear the check box.  
   > 
   >  To load symbols from the Microsoft symbols during a debug session, do this:  
   > 
   > 1. On the **Debug** menu, choose **Windows** and then choose **Modules**.  
   >    2.  Select the module that you want symbols for, and then open the shortcut menu. Choose **Load Symbols From** and then choose **Microsoft Symbol Servers**.  
  
10. In the **Cache symbols from symbol servers in this directory** box, enter a location such as `C:\symbols` where Code Center Premium can cache the symbols. Caching symbols can significantly improve performance during debugging.  
  
     If you experience difficulty debugging source code with [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] after you complete this procedure, check your cache location for previously cached and outdated symbol files. Remove the outdated symbol files.  
  
11. Click **OK**.  
  
12. Restart [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] to ensure that settings are persisted.  
  
### To debug your source code using Attach to Process  
  
1. Connect your SmartCard reader and insert the card you obtained from the Shared Source Initiative.  
  
2. Launch Visual Studio.  
  
3. Open your Visual Studio project.  
  
4. On the **Tools** menu, click **Attach to Process**.  
  
5. In the **Attach to Process** dialog box, click **Select**.  
  
6. In the **Select Code Type** dialog box, under **Detect these code types**, select **Native**, **Managed**, and **Managed(v4.0)**.  
  
7. Click **OK** to dismiss the **Select Code Type** dialog box.  
  
8. In the **Available Processes** box, select the process you want to debug.  
  
9. Click **Attach**.  
  
10. When you are prompted to confirm your certificate, click **OK**. Then enter your PIN. Accept the terms of use for Code Center Premium, if you are prompted,.  
  
     Downloading symbols can take lots of time, depending on the network speed. The status bar will indicate when all symbols have been downloaded successfully.  
  
11. Repeat the attach steps for all managed projects in your Solution.  
  
### To debug source code from an existing solution  
  
1. In **Solution Explorer**, open the shortcut menu for the solution and then choose **Properties**.  
  
2. In the Solution Property Pages dialog box, choose **Debug Source Files** in the **Common Properties** node.  
  
3. Add the following location to the **Directories containing source files** list:  
  
    `https://codepremium.msdn.microsoft.com/source/Visual%20Studio%202010/SP1/`  
  
   > [!NOTE]
   > Be sure to include the trailing slash<strong>/</strong> at the end of the path.  
  
4. For each managed project in your solution, do the following  
  
   1. In Solution Explorer, open the shortcut menu for the project and then choose **Properties**.  
  
   2. Select **Debug** and then choose **Enable unmanged code debugging**.  
  
### To debug your solution with Code Center Premium source  
  
1. In your `Package` class, set a breakpoint on the package constructor.  
  
2. In the `Debug` menu, click **Start Debugging**.  
  
3. When you hit the breakpoint in the package constructor, go to the **Call Stack** window and right-click the stack frame of the assembly you want to load symbols from, then click **Load Symbols**.  
  
     Double-click the call frame to load the source.  
  
### To browse source code on Code Center Premium  
  
1. Connect your SmartCard reader and insert the card you obtained from the Shared Source Initiative.  
  
2. Launch Internet Explorer enter the following URL: `https://codepremium.msdn.microsoft.com`  
  
3. Browse to find the source you want.  
  
## See Also  
 [Debugger Settings and Preparation](../debugger/debugger-settings-and-preparation.md)   
 [Debugger Security](../debugger/debugger-security.md)   
 [Code Center Premium](https://www.microsoft.com/en-us/sharedsource/code-center-premium.aspx)
