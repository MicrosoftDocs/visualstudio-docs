---
title: "IManagedAddin::Unload"
description: "Called just before a managed VSTO Add-in is unloaded."
ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
  - C++
f1_keywords:
  - "IMANAGEDADDIN/IManagedAddIn::Unload"
  - "IManagedAddin::Unload"
  - "IManagedAddin.Unload"
helpviewer_keywords:
  - "Unload method"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: office-development
---
# IManagedAddin::Unload

  Called just before a managed VSTO Add-in is unloaded.

## Syntax

```csharp
HRESULT Unload();
```

## Return value
 An HRESULT value that indicates whether the method completed successfully.

## Remarks
 This method is not called by current versions of Microsoft Office. This method is reserved for future use.

## See also
- [IManagedAddin interface](../vsto/imanagedaddin-interface.md)
- [IManagedAddin::Load](../vsto/imanagedaddin-load.md)
