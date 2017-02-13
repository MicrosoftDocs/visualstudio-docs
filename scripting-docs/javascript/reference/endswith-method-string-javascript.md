---
title: "endsWith Method (String) (JavaScript) | Microsoft Docs"
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
  - "DHTML"
ms.assetid: c7d836e3-bc43-4d1b-be60-0a93beb8b7a2
caps.latest.revision: 2
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# endsWith Method (String) (JavaScript)
Returns a value that indicates whether a string or substring ends with another specified string.  
  
## Syntax  
  
```vb  
  
stringObj.endsWith(str, [, position]);  
```  
  
#### Parameters  
 `stringObj`  
 Required. The string object to search against.  
  
 `str`  
 Required. The search string.  
  
 `position`  
 Optional. The position of the first character to search against in the string object, starting at 0.  
  
## Return Value  
 If the string beginning at `position` ends with the search string, the `endsWith` method returns `true`; otherwise, it returns `false`.  
  
## Exceptions  
 If `str` is a `RegExp`, a `TypeError` is thrown.  
  
## Remarks  
  
## Requirements  
 [!INCLUDE[jsv12](../../javascript/reference/includes/jsv12-md.md)]