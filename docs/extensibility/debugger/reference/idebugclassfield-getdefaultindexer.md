---
description: "Gets the name of the default indexer."
title: IDebugClassField::GetDefaultIndexer
ms.date: 11/04/2016
ms.topic: reference
f1_keywords:
- IDebugClassField::GetDefaultIndexer
helpviewer_keywords:
- IDebugClassField::GetDefaultIndexer method
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: debug-diagnostics
dev_langs:
- CPP
- CSharp
---
# IDebugClassField::GetDefaultIndexer

Gets the name of the default indexer.

## Syntax

### [C#](#tab/csharp)
```csharp
int GetDefaultIndexer(
   out string pbstrIndexer
);
```
### [C++](#tab/cpp)
```cpp
HRESULT GetDefaultIndexer( 
   BSTR* pbstrIndexer
);
```
---

## Parameters
`pbstrIndexer`
[out] Returns a string containing the name of the default indexer.

## Return Value
 If successful, returns S_OK or returns S_FALSE if there is no default indexer. Otherwise, returns an error code.

## Remarks
 The default indexer of a class is the property that is marked as the `Default` property for array accesses. This is specific to Visual Basic. Here is an example of a default indexer declared in Visual Basic and how it is used.

```vb
Imports System.Collections;

Public Class Class1
    Private myList as Hashtable

    Default Public Property Item(ByVal Index As Integer) As Integer
        Get
            Return CType(List(Index), Integer)
        End Get
        Set(ByVal Value As Integer)
            List(Index) = Value
        End Set
    End Property
End Class

Function GetItem(Index as Integer) as Integer
    Dim classList as Class1 = new Class1
    Dim value as Integer

    ' Access array through default indexer
    value = classList(2)

    ' Access array through explicit property
    value = classList.Item(2)

    Return value
End Function
```

## See also
- [IDebugClassField](../../../extensibility/debugger/reference/idebugclassfield.md)
