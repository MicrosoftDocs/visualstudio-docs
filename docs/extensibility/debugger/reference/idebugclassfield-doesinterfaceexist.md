---
title: "IDebugClassField::DoesInterfaceExist | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "IDebugClassField::DoesInterfaceExist"
helpviewer_keywords: 
  - "IDebugClassField::DoesInterfaceExist method"
ms.assetid: cc0c8642-1a76-4fda-a309-7018a34883c9
caps.latest.revision: 9
author: "gregvanl"
ms.author: "gregvanl"
manager: ghogen
ms.workload: 
  - "vssdk"
---
# IDebugClassField::DoesInterfaceExist
Determines if a specific interface is defined in the class.  
  
## Syntax  
  
```cpp  
HRESULT DoesInterfaceExist(   
   LPCOLESTR pszInterfaceName  
);  
```  
  
```csharp  
int DoesInterfaceExist(  
   [In] string pszInterfaceName  
);  
```  
  
#### Parameters  
 `pszInterfaceName`  
 [in] A string containing the interface name to look for.  
  
## Return Value  
 If successful, returns S_OK, returns S_FALSE if the interface does not exist; otherwise, returns an error code.  
  
## Remarks  
 This method in effect gets an enumeration of all interfaces and searches the list for a matching interface.  
  
## See Also  
 [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)