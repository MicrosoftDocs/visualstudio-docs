---
title: "XSLT Default Templates"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 773dd34e-67d3-4997-8df9-b71e7f880d88
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
# XSLT Default Templates
A default template is used during XSLT processing when there is no matching explicit template rule in the style sheet. The default template, also referred to as built-in template rule, is defined in section 5.8 of the W3C XSLT 1.0 Recommendation. The default template allows the XSLT processor to process a node, even though there is no explicit template rule that matches it. However, because the built-in template rule is not explicitly defined in the style sheet, this may lead to unexpected or confusing XSLT transformation results.  
  
 The XSLT debugger now displays the code of XSLT default templates. When you step through an XSLT transformation, if a default template is used, the debugger displays the default template in a window. This enables you to step through the code of the default template and set breakpoints on its instructions.  
  
## See Also  
 [Debugging XSLT](../reference/debugging-xslt.md)