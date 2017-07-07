---
title: "String Visualizer Dialog Box | Microsoft Docs"
ms.custom: ""
ms.date: "06/01/2017"
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
# String Visualizer Dialog Box
This dialog box is one of the standard visualizers included with the Visual Studio debugger. In addition to normal text, the string visualizer can evaluate HTML, XML, and JSON strings, allowing you to view the results in a meaningful format.

This dialog box allows you to view strings that are too long to view in a data tip or debugger window. In some scenarios, the visualizer can help you to identify bad or invalid strings.

**Expression**
Shows the current variable or expression you hovered over in the debugger.

**Value**
Shows the string value.
- Text visualizer shows the plain text.
- XML visualizer shows the nested XML tags, if the string is a valid XML string. Badly formatted XML may display without the XML tags.
- HTML visualizer shows the string without element tags, if the string is a valid HTML string. Badly formatted HTML may display as plain text.
- JSON visualizer shows the nested JSON elements, if the string is a valid JSON string. Badly formatted JSON may display an error icon.

A blank **Value** indicates that the specific visualizer cannot recognize the string type. For example, the XML visualizer shows a blank **Value** for a simple text string (with no XML tags) or a JSON formatted string.

## See Also  
 [Debugger Security](../debugger/debugger-security.md)   
 [Create Custom Visualizers](../debugger/create-custom-visualizers-of-data.md)