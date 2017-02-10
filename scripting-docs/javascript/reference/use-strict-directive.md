---
title: "use strict Directive | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "devlang-javascript"
ms.tgt_pltfrm: ""
ms.topic: "language-reference"
f1_keywords: 
  - "strict_JavaScriptKeyword"
  - "use strict"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "strict mode"
  - "use strict directive"
  - "use strict"
ms.assetid: b532e8c9-548c-4bbe-b2fc-5459ebd62e56
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# use strict Directive
Restricts the use of some features in JavaScript. Supported in Internet Explorer 10 and [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps only.  
  
## Syntax  
  
```javascript  
use strict  
```  
  
## Remarks  
  
## Example  
 The following code causes a syntax error because in strict mode all variables must be declared with `var`.  
  
```javascript  
"use strict";  
function testFunction(){  
   var testvar = 4;  
    return testvar;  
}  
intvar = 5;  
  
```  
  
## See Also  
 [Strict Mode](../../javascript/advanced/strict-mode-javascript.md)