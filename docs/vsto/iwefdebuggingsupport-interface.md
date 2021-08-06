---
title: "IWefDebuggingSupport interface"
description: Learn how you can use a debugging environment like Visual Studio to facilitate debugging of Microsoft Office applications.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "interface"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# IWefDebuggingSupport interface
  Implemented by a debugging environment, such as Visual Studio, to facilitate debugging of apps for Office. The Office application, such as Word or Excel, obtains this interface from Visual Studio and then calls methods on the interface at certain points during the debugging session.

## Syntax

```csharp
[
    uuid(ccaf1a90-ce1c-4199-9cd6-b40c5c57a671),
    oleautomation
]
interface IWefDebuggingSupport : IUnknown
{
    HRESULT SetWefProcessId(
        [in] DWORD dwProcessId);
    HRESULT GetAutoInsertExtensions(
        [out, retval] SAFEARRAY(BSTR)* psaExtensionNames);
}
```

## Methods
 The following table lists the methods that the IWefDebuggingSupport interface defines.

|Name|Description|
|----------|-----------------|
|[GetAutoInsertExtensions method](../vsto/getautoinsertextensions-method.md)|Gets information about the apps for Office that are to be automatically inserted during debugging.|
|[SetWefProcessId method](../vsto/setwefprocessid-method.md)|Provides the process identifier that will run Web Extensions Framework (WEF) content.|
