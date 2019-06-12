---
title: "IDebugMethodField::GetThis | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugMethodField::GetThis"
helpviewer_keywords: 
  - "IDebugMethodField::GetThis method"
ms.assetid: cc235bea-e909-4d8c-ab54-936736c803fc
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugMethodField::GetThis
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets the `this` (`Me` in [!INCLUDE[vbprvb](../../../includes/vbprvb-md.md)]) pointer of the object containing the method.  
  
## Syntax  
  
```cpp#  
HRESULT GetThis(   
   IDebugClassField** ppClass  
);  
```  
  
```csharp  
int GetThis(  
   out IDebugClassField ppClass  
);  
```  
  
#### Parameters  
 `ppClass`  
 [out] Returns an [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md) object representing the "this" pointer.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 In object-oriented languages, there is typically an implied pointer to the current instantiation of a class. This is known as `this` in C#/C++ and as `Me` in [!INCLUDE[vbprvb](../../../includes/vbprvb-md.md)].  
  
## See Also  
 [IDebugMethodField](../../../extensibility/debugger/reference/idebugmethodfield.md)   
 [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
