---
title: "WinRTError Object (JavaScript) | Microsoft Docs"
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
helpviewer_keywords: 
  - "WinRTError object [JavaScript]"
  - "JavaScript, WinRTError object"
ms.assetid: d75ab8e5-e729-4d86-90fd-ea228c30dd66
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# WinRTError Object (JavaScript)
When a Windows Runtime call returns an HRESULT that indicates a failure, JavaScript converts it to a special Windows Runtime error. It is available only in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps, when the Windows Runtime is available, as part of the global JavaScript namespace.  
  
## Syntax  
  
```  
  
errorObj = new WinRTError();  
  
```  
  
## Remarks  
 The WinRTError error type is used only for errors that originate in Windows Runtime APIs.  
  
## Example  
 The following example shows how a WinRTError is thrown and caught.  
  
```JavaScript  
try {  
            Windows.Storage.ApplicationData.localFolder.createFileAsync("sample.txt");  
        } catch (err) {  
            var n = err;  
        }  
  
```  
  
## Methods  
 The WinRTError object has no methods.  
  
## Properties  
 The WinRTError object has the same properties as the [Error Object](../../javascript/reference/error-object-javascript.md) object.  
  
## Requirements  
 The WinRTError object is supported only in [!INCLUDE[win8_appname_long](../../javascript/includes/win8-appname-long-md.md)] apps, not in Internet Explorer.  
  
## See Also  
 [Error Object](../../javascript/reference/error-object-javascript.md)