---
title: "IDebugDocumentPosition2::GetFileName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocumentPosition2::GetFileName"
helpviewer_keywords: 
  - "IDebugDocumentPosition2::GetFileName"
ms.assetid: d713635e-088f-465b-b26d-00ac971c9e86
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDocumentPosition2::GetFileName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the file name of the source file that contains the document position.  
  
## Syntax  
  
```cpp#  
HRESULT GetFileName(   
   BSTR* pbstrFileName  
);  
```  
  
```csharp  
int GetFileName(   
   out string pbstrFileName  
);  
```  
  
#### Parameters  
 `pbstrFileName`  
 [out] Returns the file name of the source file.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 A source file may not always have a file name (the source file may not exist on disk, for example).  
  
## See Also  
 [IDebugDocumentPosition2](../../../extensibility/debugger/reference/idebugdocumentposition2.md)
