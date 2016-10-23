---
title: "&#39;AddHandler&#39; and &#39;RemoveHandler&#39; methods must have exactly one parameter"
ms.custom: na
ms.date: 10/01/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: f6295626-dd63-408c-ab5f-76367f94d6ca
caps.latest.revision: 9
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# &#39;AddHandler&#39; and &#39;RemoveHandler&#39; methods must have exactly one parameter
A custom event declaration must have `AddHandler` or `RemoveHandler` declarations, each of which takes a single parameter of the delegate type specified by the custom event's `As` clause.  
  
 **Error ID:** BC31133  
  
### To correct this error  
  
-   Remove the extra parameters from the parameter list, and change the parameter type to be the same as the delegate type specified by the custom event's `As` clause.  
  
## Example  
 This example shows a custom event with the correct parameter types for the `AddHandler` and `RemoveHandler` declarations.  
  
 [!CODE [VbVbalrEventError#1](../CodeSnippet/VS_Snippets_VBCSharp/VbVbalrEventError#1)]  
  
## See Also  
 [Event Statement](../Topic/Event%20Statement.md)   
 [AddHandler - delete](assetId:///fc464cf8-582c-48a6-a9c2-185c4c3d5ff8)   
 [RemoveHandler - delete](assetId:///35c17f61-6e22-4b87-b6e1-3ed0c27a88a0)   
 [Events](../Topic/Events%20\(Visual%20Basic\).md)