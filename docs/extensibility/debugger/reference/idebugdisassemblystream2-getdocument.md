---
title: "IDebugDisassemblyStream2::GetDocument | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: reference
f1_keywords:
  - "IDebugDisassemblyStream2::GetDocument"
helpviewer_keywords:
  - "IDebugDisassemblyStream2::GetDocument"
ms.assetid: 3d039a44-ebaa-4413-ac18-7cfd92c408bd
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
dev_langs:
  - CPP
  - CSharp
---
# IDebugDisassemblyStream2::GetDocument
Gets the source document associated with this input stream.

## Syntax

```cpp
HRESULT GetDocument( 
   BSTR              bstrDocumentUrl,
   IDebugDocument2** ppDocument
);
```

```csharp
int GetDocument( 
   string              bstrDocumentUrl,
   out IDebugDocument2 ppDocument
);
```

## Parameters
`bstrDocumentUrl`\
[in] The document URL.

`ppDocument`\
[out] Returns an [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md) object representing the document.

## Return Value
 If successful, returns `S_OK`; otherwise, returns an error code.

## Remarks
 This method is implemented by debug engines that have text documents that are not stored in an actual file.

## See also
- [IDebugDisassemblyStream2](../../../extensibility/debugger/reference/idebugdisassemblystream2.md)
- [IDebugDocument2](../../../extensibility/debugger/reference/idebugdocument2.md)