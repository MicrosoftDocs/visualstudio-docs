---
title: "View strings in a string visualizer | Microsoft Docs"
ms.custom: ""
ms.date: "07/11/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "reference"
f1_keywords: 
  - "vs.debug.stringviewer"
dev_langs: 
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "JScript"
  - "SQL"
helpviewer_keywords: 
  - "string visualizer"
  - "visualizers, string"
ms.assetid: 080fd8f1-72b0-461f-8451-3c84d5dc51df
caps.latest.revision: 8
author: "mikejo5000"
ms.author: "mikejo"
manager: ghogen
ms.workload: 
  - "multiple"
---
# View strings in a string visualizer in Visual Studio
While you are debugging, you can open a string visualizer to view strings that are too long to view in a data tip or debugger window. In many scenarios, the visualizer can help you to identify malformed strings.

The standard built-in string visualizers include plain text, XML, HTML, and JSON. For a few other types such as WPF objects that appear in the debugger windows like the **Autos** window, you can also open visualizers.

## Open a string visualizer

To view a plain text, XML, HTML, or JSON string, click the magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon") while hovering over a variable containing a string value. You must be paused in the debugger to see the magnifying glass icon.

![Open a String Visualizer](../debugger/media/dbg-tips-string-visualizers.png "OpenStringVisualizer")

## View string data

The **Expression** field in the string visualizer shows the current variable or expression you hovered over in the debugger.

The **Value** field shows the string value. The Text visualizer shows the plain text.

A blank **Value** indicates that the specific visualizer cannot recognize the string type. For example, the XML visualizer shows a blank **Value** for a simple text string (with no XML tags) or a JSON formatted string. If you need to view an unrecognizable string in a visualizer, use the text visualizer.

### View JSON string data

A well-formed JSON string will appear similar to the following illustration in the JSON visualizer. Malformed JSON may display an error icon (or blank if unrecognized).

![JSON String Visualizer](../debugger/media/dbg-tips-string-visualizer-json.png "JSON String Visualizer")

### View XML string data

A well-formed XML string will appear similar to the following illustration in the XML visualizer. Malformed XML may display without the XML tags (or blank if unrecognized).

![XML String Visualizer](../debugger/media/dbg-string-visualizers-xml.png "XML String Visualizer")

### View HTML string data

A well-formed HTML string appears similar to the view you would see if the string is rendered in a browser, as shown in following illustration. Malformed HTML may display as plain text.

![HTML String Visualizer](../debugger/media/dbg-string-visualizers-html.png "HTML String Visualizer")

## See Also  
 [Create Custom Visualizers (C#, Visual Basic)](../debugger/create-custom-visualizers-of-data.md)