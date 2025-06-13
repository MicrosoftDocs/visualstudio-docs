---
description: "This function checks whether the source control plug-in allows multiple checkouts on a file."
title: SccIsMultiCheckoutEnabled Function
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- SccIsMultiCheckoutEnabled
helpviewer_keywords:
- SccIsMultiCheckoutEnabled function
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# SccIsMultiCheckoutEnabled Function

This function checks whether the source control plug-in allows multiple checkouts on a file.

## Syntax

```cpp
SCCRTN SccIsMultiCheckoutEnabled(
   LPVOID pContext,
   LPBOOL pbMultiCheckout
);
```

#### Parameters
 pContext

[in] The source control plug-in context structure.

 pbMultiCheckout

[out] Specifies whether multiple checkouts are enabled for this project (nonzero means that multiple checkouts are supported).

## Return Value
 The source control plug-in implementation of this function is expected to return one of the following values:

|Value|Description|
|-----------|-----------------|
|SCC_OK|The check was successful.|
|SCC_E_NONSPECIFICERROR<br /><br /> SCC_E_UNKNOWNERROR|Nonspecific failure.|

## Remarks
 The IDE makes two checks to determine if files can be checked out simultaneously by more than one user. First, the source control system must support multiple checkouts. The source control plug-in can specify this capability during initialization by specifying the `SCC_CAP_MULTICHECKOUT`. Thereafter, as a second check, the IDE calls this function to determine whether or not the current project supports multiple checkouts. If multiple checkouts are supported for the selected project, the plug-in returns a success code and sets `pbMultiCheckout` to nonzero (`TRUE`) or `FALSE`.

## See also
- [Source Control Plug-in API Functions](../extensibility/source-control-plug-in-api-functions.md)
