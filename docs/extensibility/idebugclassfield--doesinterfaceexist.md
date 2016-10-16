---
title: "IDebugClassField::DoesInterfaceExist"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: na
ms.suite: na
ms.technology: 
  - "vs-ide-sdk"
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "IDebugClassField::DoesInterfaceExist"
helpviewer_keywords: 
  - "IDebugClassField::DoesInterfaceExist method"
ms.assetid: cc0c8642-1a76-4fda-a309-7018a34883c9
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
# IDebugClassField::DoesInterfaceExist
Determines if a specific interface is defined in the class.  
  
## Syntax  
  
```cpp#  
HRESULT DoesInterfaceExist(   
   LPCOLESTR pszInterfaceName  
);  
```  
  
```c#  
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
 [IDebugClassField](../extensibility/idebugclassfield.md)