---
title: "IDebugCustomAttributeQuery2::EnumCustomAttributes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugCustomAttributeQuery2::EnumCustomAttributes"
helpviewer_keywords: 
  - "IDebugCustomAttributeQuery2::EnumCustomAttributes"
ms.assetid: 94bfce74-aa3d-45f0-8e04-5715faf85217
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugCustomAttributeQuery2::EnumCustomAttributes
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Gets an enumerator for all custom attributes attached to this field.  
  
## Syntax  
  
```cpp#  
HRESULT EnumCustomAttributes(   
   IEnumDebugCustomAttributes** ppEnum  
);  
```  
  
```csharp  
int EnumCustomAttributes(  
   out IEnumDebugCustomAttributes ppEnum  
);  
```  
  
#### Parameters  
 `ppEnum`  
 [out] Returns an [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md) object representing the list of custom attributes; otherwise, returns a null value if there are no custom attributes.  
  
## Return Value  
 If successful, returns S_OK or S_FALSE if there are no custom attributes on this field. Otherwise, returns an error code;  
  
## Remarks  
 A field can have multiple custom attributes.  
  
## See Also  
 [IDebugCustomAttributeQuery2](../../../extensibility/debugger/reference/idebugcustomattributequery2.md)   
 [IEnumDebugCustomAttributes](../../../extensibility/debugger/reference/ienumdebugcustomattributes.md)
