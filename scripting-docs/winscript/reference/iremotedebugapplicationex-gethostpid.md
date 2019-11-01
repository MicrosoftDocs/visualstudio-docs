---
title: "IRemoteDebugApplicationEx:GetHostPid | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.reviewer: ""
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "reference"
apiname:
  - "IRemoteDebugApplicationEx:GetHostPid"
apilocation:
  - "scrobj.dll"
helpviewer_keywords:
  - "IRemoteDebugApplicationEx:GetHostPid"
ms.assetid: 4cf9f46c-29cf-4201-87f0-5b1ddbed2f2b
caps.latest.revision: 5
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# IRemoteDebugApplicationEx:GetHostPid

Returns the process ID for the host application.

## Syntax

```cpp
HRESULT GetHostPid(
   DWORD*  dwHostPid
);
```

### Parameters

`dwHostPid`

[out] The host process identifier.

## Return Value

The method returns an `HRESULT`. Possible values include, but are not limited to, those in the following table.

|Value|Description|
|-----------|-----------------|
|`S_OK`|The method succeeded.|

## Remarks

Used by the IDE.

## See also

- [IRemoteDebugApplicationEx Interface](iremotedebugapplicationex-interface.md)