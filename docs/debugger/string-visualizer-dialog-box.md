---
title: "View strings in a string visualizer | Microsoft Docs"
ms.custom: ""
ms.date: "07/11/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
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
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# View strings in a string visualizer in Visual Studio
While you are paused in the debugger, you can open a string visualizer to view strings that are too long to view in a data tip or debugger window. In many scenarios, the visualizer can help you to identify malformed strings.

The standard built-in string visualizers include plain text, XML, HTML, and JSON. For a few other types such as WPF objects that appear in the debugger windows like the **Autos** window, you can also open visualizers.

## Open a string visualizer

To view a plain text, XML, HTML, or JSON string, click the magnifying glass icon ![VisualizerIcon](../debugger/media/dbg-tips-visualizer-icon.png "Visualizer icon") while hovering over a variable containing a string value.

![Open a String Visualizer](../debugger/media/dbg-tips-string-visualizers.png "OpenStringVisualizer")

## Inspect string data

The **Expression** field in the string visualizer shows the current variable or expression you hovered over in the debugger.

The **Value** field shows the string value.
- Text visualizer shows the plain text.
- XML visualizer shows the nested XML tags, if the string is a valid XML string. Malformed XML may display without the XML tags.
- HTML visualizer shows the string without element tags, if the string is a valid HTML string. Malformed HTML may display as plain text.
- JSON visualizer shows the nested JSON elements, if the string is a valid JSON string. Malformed JSON may display an error icon.

A blank **Value** indicates that the specific visualizer cannot recognize the string type. For example, the XML visualizer shows a blank **Value** for a simple text string (with no XML tags) or a JSON formatted string. If you need to view an unrecognizable string in a visualizer, use the text visualizer.

A well-formed JSON string will appear similar to this in the JSON visualizer.

![JSON String Visualizer](../debugger/media/dbg-tips-string-visualizer-json.png "JSON String Visualizer")

A well-formed XML string will appear similar to this in the XML visualizer.

![XML String Visualizer](../debugger/media/dbg-string-visualizers-xml.png "XML String Visualizer")

A well-formed HTML string will appear similar to this in the HTML visualizer.

![HTML String Visualizer](../debugger/media/dbg-string-visualizers-html.png "HTML String Visualizer")

## See Also  
 [Create Custom Visualizers (C#, Visual Basic)](../debugger/create-custom-visualizers-of-data.md)