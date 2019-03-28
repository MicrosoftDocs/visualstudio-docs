---
title: "IDebugClassField::DoesInterfaceExist | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: reference
f1_keywords: 
  - "IDebugClassField::DoesInterfaceExist"
helpviewer_keywords: 
  - "IDebugClassField::DoesInterfaceExist method"
ms.assetid: cc0c8642-1a76-4fda-a309-7018a34883c9
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# IDebugClassField::DoesInterfaceExist
[!INCLUDE[vs2017banner](../../../includes/vs2017banner.md)]

Determines if a specific interface is defined in the class.  
  
## Syntax  
  
```cpp#  
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
