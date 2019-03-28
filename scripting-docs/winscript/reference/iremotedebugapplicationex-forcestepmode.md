---
title: "IRemoteDebugApplicationEx:ForceStepMode | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname:
  - "IRemoteDebugApplicationEx:ForceStepMode"
apilocation:
  - "scrobj.dll"
helpviewer_keywords:
  - "IRemoteDebugApplicationEx:ForceStepMode"
ms.assetid: 83e69a3e-e4c9-4ddd-b01b-1820e4177a03
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEx:ForceStepMode

Forces the debugger into single-step mode.

## Syntax

```cpp
HRESULT ForceStepMode(
   IRemoteDebugApplicationThread*  pStepThread
);
```

### Parameters

`pStepThread`

[in] Thread for the Process Debug Monitor to step. If null, the PDM clears its stepping thread.

## Return Value

The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.

|Value|Description|
|-----------|-----------------|
|`S_OK`|The method succeeded.|

## See also

- [IRemoteDebugApplicationEx Interface](iremotedebugapplicationex-interface.md)