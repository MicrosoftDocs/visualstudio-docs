---
title: "Init | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: c55ddec8-9101-4673-979b-4109caca9146
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Init
Prepares the in-app component of graphics diagnostics to actively capture and record graphics information to a graphics log file.

## Syntax

```C++
void Init(
  std::function<void (int len, wchar_t * pszBuffer)> vsgLogGetter
);
```

#### Parameters
 `vsgLogGetter`
 A callable entity—such as a function, function pointer, lambda, or function object—that takes as parameters the length of a buffer composed of `wchar_t` and a pointer to that buffer, and returns `void`. When invoked, the callable entity determines the file name that will be used to record graphics information, and writes it to the specified buffer before returning.

## Remarks
 The `Init` function is called automatically when an instance of the `VsgDbg` class is constructed by specifying the `bDefaultInit` parameter of its constructor as `true`; otherwise, `Init` must be called explicitly before you can actively capture and record graphics information.

 You can finalize and close the active graphics log file by calling `UnInit`, and then capture and record more graphics information to a new graphics log file by calling `Init` again. You can repeat this as many times as you want to create several independent graphics log files by using the same `VsgDbg` instance.

## See also
- [UnInit](init.md)