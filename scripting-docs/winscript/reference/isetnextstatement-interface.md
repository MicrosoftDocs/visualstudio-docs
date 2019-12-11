---
title: "ISetNextStatement Interface | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
ms.assetid: b570c2e0-a173-4f14-97d8-f39465753115
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# ISetNextStatement Interface
This interface is implemented by an interpreter to allow the Process Debug Manager to update the current statement. It is implemented from a stack frame object, and the PDM obtains this interface through QueryInterface.  
  
 interface provides methods that are useful for setting the execution point, which determines the next statement to be executed.  
  
 In addition to the methods inherited from `IUnknown`, the `ISetNextStatement` interface exposes the following methods.  
  
## Methods in Vtable Order  
  
|Method|Description|  
|------------|-----------------|  
|[ISetNextStatement::CanSetNextStatement](../../winscript/reference/isetnextstatement-cansetnextstatement.md)|Determines whether the execution point can be set to the specified location.|  
|[ISetNextStatement::SetNextStatement](../../winscript/reference/isetnextstatement-setnextstatement.md)|Sets the execution point to the specified location.|