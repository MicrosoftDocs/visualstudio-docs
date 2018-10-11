---
title: "IDebugExtendedField::IsClosedType | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "IsClosedType"
  - "IDebugExtendedField::IsClosedType"
ms.assetid: 9136fc57-74ff-4fe4-a6e2-b137cb9d5b08
caps.latest.revision: 9
ms.author: "gregvanl"
manager: "ghogen"
---
# IDebugExtendedField::IsClosedType
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

  
Determines if the field represents a closed type.  
  
## Syntax  
  
```cpp#  
HRESULT IsClosedType(  
   void  
);  
```  
  
```csharp  
int IsClosedType();  
```  
  
## Return Value  
 If the field is a closed type, returns `S_OK`; otherwise, returns `S_FALSE`.  
  
## See Also  
 [IDebugExtendedField](../../../extensibility/debugger/reference/idebugextendedfield.md)

