---
title: "ScriptEngineBuildVersion Function (JavaScript) | Microsoft Docs"
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
  - "ScriptEngineBuildVersion"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "ScriptEngineBuildVersion function"
ms.assetid: 7e255030-b0a3-420b-9c96-bb3e93c9333f
caps.latest.revision: 11
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ScriptEngineBuildVersion Function (JavaScript)
Gets the build version number of the scripting engine in use.  
  
## Syntax  
  
```  
ScriptEngineBuildVersion()  
```  
  
## Remarks  
 The return value corresponds directly to the version information contained in the dynamic-link library (DLL) for the scripting language in use.  
  
## Example  
 The following example illustrates the use of the `ScriptEngineBuildVersion` function:  
  
```JavaScript  
if(window.ScriptEngineBuildVersion) {  
    console.log(window.ScriptEngineBuildVersion());  
}  
  
// Output: <current build version>  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
## See Also  
 [ScriptEngine Function](../../javascript/reference/scriptengine-function-javascript.md)   
 [ScriptEngineMajorVersion Function](../../javascript/reference/scriptenginemajorversion-function-javascript.md)   
 [ScriptEngineMinorVersion Function](../../javascript/reference/scriptengineminorversion-function-javascript.md)