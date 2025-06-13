---
description: "Represents a symbol provider that has direct access to metadata and core symbol interfaces."
title: IDebugSymbolProviderDirect
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDebugSymbolProviderDirect interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
---
# IDebugSymbolProviderDirect

Represents a symbol provider that has direct access to metadata and core symbol interfaces.

## Syntax

```
IDebugSymbolProviderDirect: IUnknown
```

## Methods
 This interface implements the following methods:

|Method|Description|
|------------|-----------------|
|[GetAppIDFromAddress](../../../extensibility/debugger/reference/idebugsymbolproviderdirect-getappidfromaddress.md)|Retrieves the application domain identifier given the debug address.|
|[GetCurrentModulesInfo](../../../extensibility/debugger/reference/idebugsymbolproviderdirect-getcurrentmodulesinfo.md)|Retrieves information about the modules in the symbol group.|
|[GetCurrentModulesState](../../../extensibility/debugger/reference/idebugsymbolproviderdirect-getcurrentmodulesstate.md)|Retrieves information about the symbol group of which the symbol provider is a member.|
|[GetMetaDataImport](../../../extensibility/debugger/reference/idebugsymbolproviderdirect-getmetadataimport.md)|Retrieves the metadata import information.|
|[GetMethodFromAddress](../../../extensibility/debugger/reference/idebugsymbolproviderdirect-getmethodfromaddress.md)|Retrieves information about the method at the specified debug address.|
|[GetSymUnmanagedReader](../../../extensibility/debugger/reference/idebugsymbolproviderdirect-getsymunmanagedreader.md)|Retrieves a symbol reader for unmanaged code.|

## Remarks
 This interface can be used instead of most of the other symbol provider interfaces. It provides direct access to the metadata and `CorSym` interfaces.

## Requirements
 Header: Sh.h

 Namespace: Microsoft.VisualStudio.Debugger.Interop

 Assembly: Microsoft.VisualStudio.Debugger.Interop.dll
