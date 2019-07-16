---
title: "How to: Test and Debug a Visualizer | Microsoft Docs"
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
  - "visualizers, testing"
  - "visualizers, debugging"
  - "debugging [Visual Studio], visualizers"
ms.assetid: 5cc12ce8-c819-48e4-b487-98d403001b28
caps.latest.revision: 18
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# How to: Test and Debug a Visualizer
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Once you have written a visualizer, you need to debug and test it.  
  
 One way to test a visualizer is by installing it in Visual Studio and calling it from a debugger window. (See [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md).) If you do that, you will need to use a second instance of Visual Studio to attach and debug the visualizer, which is running in the first instance of the debugger.  
  
 An easier way to debug a visualizer is to run the visualizer from a test driver. The visualizer APIs make it easy to create such a driver, which is called the *visualizer development host*.  
  
### To create a visualizer development host  
  
1. In your debugger-side class, include a static method that creates a <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerDevelopmentHost> object and calls its show method:  
  
    ```  
    public static void TestShowVisualizer(object objectToVisualize)  
    {  
       VisualizerDevelopmentHost myHost = new VisualizerDevelopmentHost(objectToVisualize, typeof(DebuggerSide));  
       myHost.ShowVisualizer();  
    }  
    ```  
  
     The parameters used to construct the host are the data object that will be shown in the visualizer (`objectToVisualize`) and the type of the debugger side class.  
  
2. Add the following statement to call `TestShowVisualizer`. If you created your visualizer in a class library, you need to create an executable to call the class library and place this statement in your executable:  
  
    ```  
    DebuggerSide.TestShowVisualizer(myString);  
    ```  
  
     For a more complete example, see [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md).  
  
## See Also  
 [Walkthrough: Writing a Visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)   
 [How to: Install a Visualizer](../debugger/how-to-install-a-visualizer.md)   
 [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)
