---
title: "IDebugCustomAttribute::GetName | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugCustomAttribute::GetName"
helpviewer_keywords: 
  - "IDebugCustomAttribute::GetName"
ms.assetid: ba509cc5-5816-4925-a094-4c72d88c360c
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugCustomAttribute::GetName
Gets the name of the custom attribute.  
  
## Syntax  
  
```cpp  
HRESULT GetName(   
   BSTR* bstrName  
);  
```  
  
```csharp  
int GetName(  
   out string bstrName  
);  
```  
  
#### Parameters  
 `bstrName`  
 [out] Returns a string containing the name of the custom attribute.  
  
## Return Value  
 If successful, returns S_OK; otherwise, returns an error code.  
  
## Remarks  
 The named returned by this method corresponds to the name of the class used to declare the attribute. This may not exactly correspond to the name of the custom attribute class itself as C# allows the "Attribute" suffix to be dropped from a custom attribute name when it is used in a declaration.  
  
## See Also  
 [IDebugCustomAttribute](../../../extensibility/debugger/reference/idebugcustomattribute.md)