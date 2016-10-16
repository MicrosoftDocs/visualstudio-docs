---
title: "IDebugProgramPublisher2::UnpublishProgramNode"
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
  - "IDebugProgramPublisher2::UnpublishProgramNode"
helpviewer_keywords: 
  - "IDebugProgramPublisher2::UnpublishProgramNode"
ms.assetid: 57c7e6e1-b84e-4e14-ad83-cbbb64e2f526
caps.latest.revision: 8
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
# IDebugProgramPublisher2::UnpublishProgramNode
Removes a specified program node from availability to debug engines (DEs) and the session debug manager (SDM).  
  
## Syntax  
  
```cpp  
HRESULT UnpublishProgramNode(  
   IDebugProgramNode2* pProgramNode  
);  
```  
  
```c#  
int UnpublishProgramNode(  
   IDebugProgramNode2 pProgramNode  
);  
```  
  
#### Parameters  
 `pProgramNode`  
 [in] An [IDebugProgramNode2](../extensibility/idebugprogramnode2.md) object representing the program node being removed.  
  
## Return Value  
 If successful, returns `S_OK`; otherwise, returns an error code.  
  
## Remarks  
 Once removed, the program node is no longer available to be queried for program information.  
  
 To make a program node available, call the [PublishProgramNode](../extensibility/idebugprogrampublisher2--publishprogramnode.md) method.  
  
## See Also  
 [IDebugProgramPublisher2](../extensibility/idebugprogrampublisher2.md)   
 [IDebugProgramNode2](../extensibility/idebugprogramnode2.md)   
 [PublishProgramNode](../extensibility/idebugprogrampublisher2--publishprogramnode.md)