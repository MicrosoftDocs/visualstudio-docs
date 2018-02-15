---
title: "startsWith Method (String) (JavaScript) | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 871def4a-0f96-4675-b6ff-2349f4996511
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# startsWith Method (String) (JavaScript)
Returns a value that indicates whether a string or substring starts with another specified string.  
  
## Syntax  
  
```vb  
  
stringObj.startsWith(str, [, position]);  
```  
  
#### Parameters  
 `stringObj`  
 Required. The string object to search against.  
  
 `str`  
 Required. The search string.  
  
 `position`  
 Optional. The position of the first character to search against in the string object, starting at 0.  
  
## Return Value  
 If the string beginning at `position` starts with the search string, the `startsWith` method returns `true`; otherwise, it returns `false`.  
  
## Exceptions  
 If `str` is a `RegExp`, a `TypeError` is thrown.  
  
## Remarks  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]