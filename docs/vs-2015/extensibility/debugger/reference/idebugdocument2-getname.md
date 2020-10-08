---
title: "IDebugDocument2::GetName | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugDocument2::GetName"
helpviewer_keywords: 
  - "IDebugDocument2::GetName"
ms.assetid: 6f09ff09-b0cf-4472-8fc8-143991f0ceb1
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# IDebugDocument2::GetName
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the name of the document in one of several forms.  
  
## Syntax  
  
```cpp#  
HRESULT GetName(   
   GETNAME_TYPE gnType,  
   BSTR*        pbstrFileName  
);  
```  
  
```csharp  
int GetName(   
   enum_GETNAME_TYPE gnType,  
   out string        pbstrFileName  
);  
```  
  
#### Parameters  
 `gnType`  
 [in] A value from the [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md) enumeration that determines the type of name to return.  
  
 `pbstrFileName`  
 [out] Returns a string containing the document name.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 This method can, for example, return the name of the document as a title or as a file name or even part of a file name.  
  
## See Also  
 [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)   
 [GETNAME_TYPE](../../../extensibility/debugger/reference/getname-type.md)
