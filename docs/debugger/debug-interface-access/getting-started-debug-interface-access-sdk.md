---
description: "The Debug Interface Access (DIA) SDK supplies you with instructional documentation and a sample that illustrates how to use the DIA API."
title: "Getting Started (Debug Interface Access SDK) | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "reference"
dev_langs:
  - "C++"
helpviewer_keywords:
  - ".dbg files"
  - "DBG files"
ms.assetid: cb3d040a-2846-40d7-bdbc-8a5beb5dd2f6
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Getting Started (Debug Interface Access SDK)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]
The Debug Interface Access (DIA) SDK supplies you with instructional documentation and a sample that illustrates how to use the DIA API. Use the interfaces and methods in the DIA SDK to develop custom applications that open the `.pdb` and `.dbg` files and search their content for symbols, values, attributes, addresses, and other debugging information. This SDK also provides reference tables for the properties associated with symbols found in C++ applications.

 To make best use of the DIA SDK, you should be familiar with the following:

- C++ programming language

- COM programming

- Visual Studio integrated development environment (IDE) for compiling the samples

  The DIA SDK is normally installed with Visual Studio and its default location is `%VSINSTALLDIR%\DIA SDK\bin` with associated subdirectories for additional processor architectures.     For example, 
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\msdia140.dll` (default)
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\amd64\msdia140.dll` (amd64)
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\arm\msdia140.dll` (arm)
  - `C:\Program Files\Microsoft Visual Studio\2022\Enterprise\DIA SDK\bin\arm64\msdia140.dll` (arm64)
 
  As part of the installation, the `msdia140.dll`, which implements the DIA SDK, is automatically registered so all that you need to do to use it is to include `dia2.h` in your program and link to `diaguids.lib`.

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
