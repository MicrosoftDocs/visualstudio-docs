---
title: "How to: Evaluate an XPath Expression"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 159ba4ef-75e4-4ac8-80dc-e064e0bec345
caps.latest.revision: 2
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
# How to: Evaluate an XPath Expression
You can evaluate XPath expressions with the **QuickWatch** dialog box. The XPath expression must be valid according to the W3C XPath 1.0 recommendation. The current XSLT context—that is, the `self::node()` node in the **Locals** window—provides the evaluation context for the XPath expression.  
  
 The following list describes which functions are supported when evaluating an XPath expression:  
  
-   Built-in XPath functions are supported.  
  
-   Built-in XSLT functions are not supported.  
  
-   User-defined functions are not supported.  
  
> [!NOTE]
>  The following procedure uses the belowAvg.xsl and books.xml files from the [Walkthrough: Debug an XSLT Style Sheet](../reference/walkthrough--debug-an-xslt-style-sheet.md) topic.  
  
### To evaluate an XPath expression  
  
1.  Insert a breakpoint at the `xsl:if` start tag.  
  
2.  Click the **Debug XSL** button on the XML Editor toolbar.  
  
     The debugger starts and breaks on the `xsl:if` tag.  
  
3.  Right-click and select **QuickWatch**.  
  
     The **QuickWatch** dialog box is displayed.  
  
4.  Enter `./price/text()` in the **Expression** field of the **QuickWatch** dialog box and click **Reevaluate**.  
  
     The price of the current book node appears in the **Value** box.  
  
5.  Change the XPath expression to `./price/text() < $bookAverage` and click **Reevaluate**.  
  
     The **Value** box shows that the XPath expression evaluates to `true`.  
  
## See Also  
 [Debugging XSLT](../reference/debugging-xslt.md)