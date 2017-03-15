---
title: "ScriptEngineMinorVersion Function (JavaScript) | Microsoft Docs"
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
  - "ScriptEngineMinorVersion"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "ScriptEngineMinorVersion function"
ms.assetid: caa506a5-e61d-4b2a-8b83-83d56a2f26cd
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ScriptEngineMinorVersion Function (JavaScript)
Gets the minor version number of the scripting engine in use.  
  
## Syntax  
  
```  
ScriptEngineMinorVersion()  
```  
  
## Remarks  
 The return value corresponds directly to the version information contained in the dynamic-link library (DLL) for the scripting language in use.  
  
## Example  
 The following example illustrates the use of the `ScriptEngineMinorVersion` function.  
  
```JavaScript  
if (window.ScriptEngineMinorVersion) {  
    console.log(window.ScriptEngineMinorVersion());  
}  
  
//Output: <current minor version>  
  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
## See Also  
 [ScriptEngine Function](../../javascript/reference/scriptengine-function-javascript.md)   
 [ScriptEngineBuildVersion Function](../../javascript/reference/scriptenginebuildversion-function-javascript.md)   
 [ScriptEngineMajorVersion Function](../../javascript/reference/scriptenginemajorversion-function-javascript.md)