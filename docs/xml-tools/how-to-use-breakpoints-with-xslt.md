---
title: "How to: Use Breakpoints with XSLT | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: bf7bbc2c-71dc-4cac-a6fc-add6b27d92ed
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
# How to: Use Breakpoints with XSLT
You can set breakpoints in an XSLT style sheet or in the XML source document. If you set a breakpoint on a tag, when execution starts the breakpoint will move to the next statement that has source line information.  
  
 For more information, see [Debugging Basics: Breakpoints](http://msdn.microsoft.com/en-us/752a02c2-0ac7-4c8b-aa1b-4b2b3b21152e).  
  
## Set a Breakpoint in a Style Sheet  
 Breakpoints can be set on start tags, end tags, and text nodes of an XSLT style sheet. Breakpoints can also be set on code in a script block.  
  
#### To set a breakpoint in a style sheet  
  
1.  Open a style sheet in the XML Editor.  
  
2.  Position the cursor at the breakpoint location, right-click, point to **Breakpoint**, and click **Insert Breakpoint**.  
  
3.  Click the browse the browse button (**...**) on the **Input** field of the document properties window.  
  
4.  Locate the XML source document and click **Open**.  
  
     This sets the source document file that is used for the XSLT transformation.  
  
5.  Click the **Debug XSL** button on the XML Editor toolbar.  
  
## Set a Breakpoint in an XML Source Document  
 Breakpoints can be set on elements, attributes, namespace node, comments, processing instruction, and text nodes of an XML source document. You cannot set a breakpoint on the document node, or on a namespace node that is inherited from the parent element.  
  
#### To set a breakpoint in an XML source document  
  
1.  Open the XML document in the XML Editor.  
  
2.  Position the cursor at the breakpoint location, right-click, point to **Breakpoint**, and click **Insert Breakpoint**.  
  
3.  Click the browse the browse button (**...**) on the **Stylesheet** field of the document properties window.  
  
4.  Locate the XML source document and click **Open**.  
  
     This sets the source document file that is used for the XSLT transformation.  
  
5.  Click the **Debug XSL** button on the XML Editor toolbar.  
  
## See Also  
 [Walkthrough: Debug an XSLT Style Sheet](../xml-tools/walkthrough-debug-an-xslt-style-sheet.md)