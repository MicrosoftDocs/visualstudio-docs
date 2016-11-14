---
title: "IDebugCustomAttribute::GetAttributeBytes | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCustomAttribute::GetAttributeBytes"
helpviewer_keywords: 
  - "IDebugCustomAttribute::GetAttributeBytes"
ms.assetid: cf34583b-6530-4dcc-89f8-eb27e4e8d594
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
translation.priority.mt: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# IDebugCustomAttribute::GetAttributeBytes
Gets the attribute information as a blob of bytes.  
  
## Syntax  
  
```cpp#  
HRESULT GetAttributeBytes(   
   BYTE*  ppBlob,  
   DWORD* pdwLen  
);  
```  
  
```c#  
int GetAttributeBytes(  
   ref byte[] ppBlob,   
   ref uint   pdwLen  
);  
```  
  
#### Parameters  
 `ppBlob`  
 [in, out] An array that is filled in with the attribute bytes.  
  
 `pdwLen`  
 [in, out] Specifies the maximum number of bytes to return in the `ppBlob` array and returns the number of bytes actually written to the array.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 Set the `ppBlob` parameter to a null value to return the number of attributes bytes available. Then allocate an array and pass that array in for the `ppBlob` parameter.  
  
 The attribute bytes represent the raw data of the custom attribute.  
  
## See Also  
 [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)