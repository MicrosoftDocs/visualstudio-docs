---
description: "This function returns additional capabilities supported by the source control plug-in."
title: SccGetExtendedCapabilities Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccGetExtendedCapabilities
helpviewer_keywords:
- SccGetExtendedCapabilities function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccGetExtendedCapabilities function

This function returns additional capabilities supported by the source control plug-in.

## Syntax

```cpp
SCCRTN SccGetExtendedCapabilities(
   LPVOID pContext,
   LONG lSccExCaps,
   LPBOOL pbSupported
);
```

### Parameters
 pContext

[in] The source control plug-in context pointer.

 lSccExCaps

[in] A flag specifying an extended capability for which to test (see the Extended Capability Code table in [Capability flags](../extensibility/capability-flags.md) for the possible flags).

 pbSupported

[out] Returns non-zero (`TRUE`) if the specified capability is supported; otherwise, returns zero (`FALSE`).

## Return value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The get capability operation completed successfully.|
|SCC_E_UNKNOWNERROR<br /><br /> SCC_E_NONSPECIFICERROR|Unknown or unspecified error occurred.|

## Remarks
 This method is called on demand; that is, when a capability needs to be tested, this method is called to determine if that capability is supported. Only one flag at a time is specified.

## See also
- [Source control plug-in API functions](../extensibility/source-control-plug-in-api-functions.md)
- [Error codes](../extensibility/error-codes.md)
- [Capability flags](../extensibility/capability-flags.md)
