---
title: "IDebugApplicationNode100::QueryIsChildNode | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
helpviewer_keywords: 
  - "IDebugApplicationNode100::QueryIsChildNode"
ms.assetid: 4f36f435-0f34-4f9e-bba3-e75285fd7bbb
caps.latest.revision: 4
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IDebugApplicationNode100::QueryIsChildNode
Determines whether the specified document belongs to one of the child nodes of this node.  
  
> [!IMPORTANT]
> [IDebugApplicationNode100 Interface](../../winscript/reference/idebugapplicationnode100-interface.md) is implemented by PDM v10.0 and greater. Found in activdbg100.h.  
  
## Syntax  
  
```cpp  
HRESULT QueryIsChildNode(        [in] IDebugDocument* pSearchKey        );  
```  
  
#### Parameters  
 `pSearchKey`  
 The search key.  
  
## See also  
 [IDebugApplicationNode100 Interface](../../winscript/reference/idebugapplicationnode100-interface.md)