---
description: The Debug Interface Access (DIA) SDK supplies you with instructional documentation and a sample that illustrates how to use the DIA API.
title: Getting Started (Debug Interface Access SDK)
ms.date: "05/09/2023"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - ".dbg files"
  - "DBG files"
author: "mikejo5000"
ms.author: "mikejo"
manager: mijacobs
ms.subservice: debug-diagnostics
---

# Getting Started (Debug Interface Access SDK)

The Debug Interface Access (DIA) SDK supplies you with instructional documentation and a sample that illustrates how to use the DIA API. Use the interfaces and methods in the DIA SDK to develop custom applications that open the `.pdb` and `.dbg` files and search their content for symbols, values, attributes, addresses, and other debugging information. This SDK also provides reference tables for the properties associated with symbols found in C++ applications.

To make best use of the DIA SDK, you should be familiar with the following:

- C++ programming language

- COM programming

- Visual Studio integrated development environment (IDE) for compiling the samples

  The DIA SDK is normally installed with Visual Studio and its default location is `%VSINSTALLDIR%\DIA SDK\bin` with associated subdirectories for additional processor architectures. For example,
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\msdia140.dll` (x86)
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\amd64\msdia140.dll` (amd64)
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\arm\msdia140.dll` (arm)
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\arm64\msdia140.dll` (arm64)

  Header: `include\dia2.h`

  Library: `lib\diaguids.lib`

  DLL: `bin\msdia140.dll`

  IDL: `idl\dia2.idl`

## In This Section

[Overview](../../debugger/debug-interface-access/overview-debug-interface-access-sdk.md)

Reviews the basic architecture of DIA.

[Querying the .Pdb File](../../debugger/debug-interface-access/querying-the-dot-pdb-file.md)

Provides step-by-step instructions on how to use the DIA API to query a `.pdb` file.

## See also

- [Debug Interface Access SDK](../../debugger/debug-interface-access/debug-interface-access-sdk.md)
