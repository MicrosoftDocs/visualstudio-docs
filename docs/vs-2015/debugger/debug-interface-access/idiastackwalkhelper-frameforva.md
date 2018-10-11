---
title: "IDiaStackWalkHelper::frameForVA | Microsoft Docs"
ms.custom: ""
ms.date: "2018-06-30"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "C++"
helpviewer_keywords: 
  - "IDiaStackWalkHelper2::frameForVA method"
ms.assetid: f35fc61b-f8dd-473a-b583-82c304059422
caps.latest.revision: 12
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDiaStackWalkHelper::frameForVA
[!INCLUDE[vs2017banner](../../includes/vs2017banner.md)]

  
Retrieves the stack frame that contains the specified virtual address.  
  
## Syntax  
  
```cpp#  
HRESULT frameForVA(   
   ULONGLONG        va,  
   IDiaFrameData**  ppFrame  
);  
```  
  
#### Parameters  
 `va`  
 [in] The virtual address for the frame data.  
  
 `ppFrame`  
 [out] An [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md) object that represents the stack frame at the specified address.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## See Also  
 [IDiaStackWalkHelper](../../debugger/debug-interface-access/idiastackwalkhelper.md)   
 [IDiaFrameData](../../debugger/debug-interface-access/idiaframedata.md)



