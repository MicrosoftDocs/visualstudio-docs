---
title: "Unexpected quantifier (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5018"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: ba6d34f9-2d6f-486c-a929-6cd9818be322
caps.latest.revision: 7
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Unexpected quantifier (JavaScript)
When composing your regular expression search pattern, you created a pattern element with an illegal repetition factor. For example, the pattern  
  
```  
/^+/  
```  
  
 is illegal because the element ^ (beginning of input) cannot have a repetition factor. The following table lists the elements that cannot have repetition factors.  
  
|Element|Description|  
|-------------|-----------------|  
|^|Beginning of input|  
|$|End of input|  
|\b|Word boundary|  
|\B|Non-word boundary|  
|*|Zero or more repetitions|  
|+|One or more repetitions|  
|?|Zero or one repetitions|  
|{n}|n repetitions|  
|{n,}|n or more repetitions|  
|{n,m}|From n to m repetitions, inclusive|  
  
### To correct this error  
  
-   Ensure your search pattern element contains legal repetition factors only.  
  
## See Also  
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](http://msdn.microsoft.com/en-us/ab0766e1-7037-45ed-aa23-706f58358c0e)