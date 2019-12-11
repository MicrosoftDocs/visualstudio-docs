---
title: "Unexpected quantifier (JavaScript) | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: reference
f1_keywords: 
  - "VS.WebClient.Help.SCRIPT5018"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: ba6d34f9-2d6f-486c-a929-6cd9818be322
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Unexpected quantifier (JavaScript)
When composing your regular expression search pattern, you created a pattern element with an illegal repetition factor. For example, the pattern  
  
```js
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
  
- Ensure your search pattern element contains legal repetition factors only.  
  
## See also  
 [Regular Expression Object](../../javascript/reference/regular-expression-object-javascript.md)   
 [Regular Expression Syntax (JavaScript)](https://msdn.microsoft.com/library/1400241x)