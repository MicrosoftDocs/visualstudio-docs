---
description: "Gets extended information for the property."
title: IDebugProperty2::GetExtendedInfo
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugProperty2::GetExtendedInfo
helpviewer_keywords:
- IDebugProperty2::GetExtendedInfo
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugProperty2::GetExtendedInfo

Gets extended information for the property.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetExtendedInfo ( 
   ref Guid guidExtendedInfo,
   out object pExtendedInfo
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetExtendedInfo ( 
   REFGUID* guidExtendedInfo,
   VARIANT* pExtendedInfo
);
```
---

## Parameters
`guidExtendedInfo`\
[in] GUID that determines the type of extended information to be retrieved. See Remarks for details.

`pExtendedInfo`\
[out] Returns a `VARIANT` (C++) or object (C#) that can be used to retrieve the extended property information. For example, this parameter might return an `IUnknown` interface that can be queried for an [IDebugDocumentText2](../../../extensibility/debugger/reference/idebugdocumenttext2.md) interface. See Remarks for details.

## Return Value
 If successful, returns `S_OK`; otherwise returns error code. Returns `S_GETEXTENDEDINFO_NO_EXTENDEDINFO` if there is no extended information to retrieve.

## Remarks
 This method exists for the purpose of retrieving information that does not lend itself to being retrieved by calling the [GetPropertyInfo](../../../extensibility/debugger/reference/idebugproperty2-getpropertyinfo.md) method.

 The following GUIDs are typically recognized by this method (the GUID values are specified for C# since the name is not available in any assembly). Additional GUIDs can be created for internal use.

|Name|GUID|Description|
|----------|----------|-----------------|
|guidDocument|{3f98de84-fee9-11d0-b47f-00a0244a1dd2}|Returns an `IUnknown` interface to the document. Typically, the [IDebugDocumentText2](../../../extensibility/debugger/reference/idebugdocumenttext2.md) interface can be obtained from this `IUnknown` interface.|
|guidCodeContext|{e2fc65e-56ce-11d1-b528-00aax004a8797}|Returns an `IUnknown` interface to the document context. Typically, the [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md) interface can be obtained from this `IUnknown` interface.|
|guidCustomViewerSupported|{d9c9da31-ffbe-4eeb-9186-23121e3c088c}|Returns a string containing the CLSID of a custom viewer, typically implemented by an expression evaluator.|
|guidExtendedInfoSlot|{6df235ad-82c6-4292-9c97-7389770bc42f}|Returns a 32-bit number representing the desired slot number if this property represents a managed code local address.|
|guidExtendedInfoSignature|{b5fb6d46-f805-417f-96a3-8ba737073ffd}|Returns a string containing the signature of the variable associated with the property object.|

## See also
- [IDebugProperty2](../../../extensibility/debugger/reference/idebugproperty2.md)
- [IDebugDocumentText2](../../../extensibility/debugger/reference/idebugdocumenttext2.md)
- [IDebugDocumentContext2](../../../extensibility/debugger/reference/idebugdocumentcontext2.md)
