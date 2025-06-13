---
description: "Represents a query for custom attributes on a method or type."
title: IDebugCustomAttributeQuery
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugCustomAttributeQuery interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugCustomAttributeQuery

Represents a query for custom attributes on a method or type.

## Syntax

```
IDebugCustomAttributeQuery : IUnknown
```

## Methods
 This interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetCustomAttributeByName](../../../extensibility/debugger/reference/idebugcustomattributequery-getcustomattributebyname.md)|Retrieves a custom attribute given its name.|
|[IsCustomAttributeDefined](../../../extensibility/debugger/reference/idebugcustomattributequery-iscustomattributedefined.md)|Determines in the specified custom attribute is defined.|

## Requirements
 Header: Sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
