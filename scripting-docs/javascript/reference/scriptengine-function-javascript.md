---
title: "ScriptEngine Function (JavaScript) | Microsoft Docs"
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
  - "ScriptEngine"
dev_langs: 
  - "JavaScript"
  - "DHTML"
helpviewer_keywords: 
  - "ScriptEngine function"
ms.assetid: 65674b2b-d2c2-4493-99b3-f0d20fda8249
caps.latest.revision: 15
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ScriptEngine Function (JavaScript)
Gets the name of the scripting language in use.  
  
## Syntax  
  
```  
ScriptEngine()  
```  
  
## Remarks  
 The `ScriptEngine` function returns "JScript", which indicates that [!INCLUDE[javascript](../../javascript/includes/javascript-md.md)] is the current scripting engine.  
  
## Example  
 The following example illustrates the use of the `ScriptEngine` function:  
  
```javascript  
if (window.ScriptEngine) {  
    console.log(window.ScriptEngine());  
}  
  
// Output: JScript  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
## See Also  
 [ScriptEngineBuildVersion Function](../../javascript/reference/scriptenginebuildversion-function-javascript.md)   
 [ScriptEngineMajorVersion Function](../../javascript/reference/scriptenginemajorversion-function-javascript.md)   
 [ScriptEngineMinorVersion Function](../../javascript/reference/scriptengineminorversion-function-javascript.md)