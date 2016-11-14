---
title: "Editing XSLT Style Sheets | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 080bed0f-0ca9-4be7-aecd-6bdaebc04007
caps.latest.revision: 2
author: "kempb"
ms.author: "kempb"
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
# Editing XSLT Style Sheets
The XML Editor can also be used to edit XSLT style sheets. You can take advantage of the default Editor features such as IntelliSense, outlining, XML snippets, and so on. In addition, there are also new features that make it easier to develop in XSLT.  
  
## XSLT Features  
 The following table describes features specific to working with XSLT style sheets.  
  
 **Syntax coloring**  
 XSLT keywords, such as `template`, `match`, and so on, are displayed in the XSLT keyword color specified by the **Fonts and Colors** settings.  
  
 **Wavy underlines**  
 The XML Editor uses the installed xslt.xsd file to validate XSLT style sheets. Validation errors are shown as blue wavy underlines. The XML Editor also compiles the style sheet in the background and reports compiler errors or warnings with appropriate wavy underlines.  
  
 **Support for script blocks**  
 Code in script blocks is supported by the XSLT debugger so you can set breakpoints and step through the script block code.  
  
 **View XSLT output**  
 You can execute an XSL transformation and view the output from the XML Editor. For more information, see [How to: Execute an XSLT Transformation from the XML Editor](../xml-tools/how-to-execute-an-xslt-transformation-from-the-xml-editor.md).  
  
 **Debug XSLT**  
 You can launch the XSLT debugger from an XSLT file in the XML Editor. The debugger supports setting breakpoints in the XSLT file, viewing XSLT execution state, and so on. Hovering over an XSLT variable brings up a ToolTip with the value of the variable. The debugger can be used to debug a style sheet, or to debug a compiled XSL transformation invoked from another application. For more information, see [Debugging XSLT](../xml-tools/debugging-xslt.md).  
  
## See Also  
 [XML Editor](../xml-tools/xml-editor.md)