---
title: "ScriptEngineMajorVersion Function (JavaScript) | Microsoft Docs"
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
  - "ScriptEngineMajorVersion"
dev_langs: 
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
helpviewer_keywords: 
  - "ScriptEngineMajorVersion function"
ms.assetid: 3e251bce-1e14-4cb5-b79f-53845d1920fd
caps.latest.revision: 10
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ScriptEngineMajorVersion Function (JavaScript)
Gets the major version number of the scripting engine in use.  
  
## Syntax  
  
```  
ScriptEngineMajorVersion()  
```  
  
## Remarks  
 The return value corresponds directly to the version information contained in the dynamic-link library (DLL) for the scripting language in use.  
  
## Example  
 The following example illustrates the use of the `ScriptEngineMajorVersion` function:  
  
```JavaScript  
if (window.ScriptEngineMajorVersion) {  
    console.log(window.ScriptEngine());   
}  
  
Output: <current major version>  
  
```  
  
## Requirements  
 [!INCLUDE[jsv5](../../javascript/reference/includes/jsv5-md.md)]  
  
## See Also  
 [ScriptEngine Function](../../javascript/reference/scriptengine-function-javascript.md)   
 [ScriptEngineBuildVersion Function](../../javascript/reference/scriptenginebuildversion-function-javascript.md)   
 [ScriptEngineMinorVersion Function](../../javascript/reference/scriptengineminorversion-function-javascript.md)