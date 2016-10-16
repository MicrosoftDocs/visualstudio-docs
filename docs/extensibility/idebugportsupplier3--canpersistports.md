---
title: "IDebugPortSupplier3::CanPersistPorts"
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
  - "IDebugPortSupplier3::CanPersistPorts"
helpviewer_keywords: 
  - "IDebugPortSupplier3::CanPersistPorts"
ms.assetid: 4127760c-e602-4e86-9232-457e382a52c7
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
# IDebugPortSupplier3::CanPersistPorts
This method determines whether the port supplier can persist ports (by writing them to disk) between invocations of the debugger.  
  
## Syntax  
  
```cpp  
HRESULT CanPersistPorts();  
```  
  
```c#  
int CanPersistPorts();  
```  
  
#### Parameters  
 None.  
  
## Return Value  
 `S_OK` if ports can be persisted, or `S_FALSE` to indicate that ports cannot be persisted.  
  
## Remarks  
 If the port supplier can persist ports, it should do so when it is destroyed and then reload them when it is instantiated once again.  
  
## See Also  
 [IDebugPortSupplier3](../extensibility/idebugportsupplier3.md)