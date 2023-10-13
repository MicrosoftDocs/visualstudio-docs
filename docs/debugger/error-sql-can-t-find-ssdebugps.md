---
description: "SSDEBUGPS.dll is the SQL Server Debugging Host component."
title: "SQL Can&apos;t Find SSDEBUGPS"
ms.date: "11/04/2016"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.sqlde_cant_find_ssdebugps"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
  - "SQL"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
---
# Error: SQL Can&#39;t Find SSDEBUGPS

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

SSDEBUGPS.dll is the SQL Server Debugging Host component.

This error occurs when you are trying to start debugging, and indicates that the specified file is not present on the SQL Server 2005 machine. Possible causes are that either Remote Debugging setup was never run, or that somehow this file got deleted.

There are two ways to resolve this error: by rerunning Remote Debugging setup, and by copying the file onto the SQL Server 2005 machine.

To rerun Remote Debugging setup, follow the instructions at [Remote Debugging](../debugger/remote-debugging.md).

If you can locate a copy of ssdebugps.dll, you can copy it onto the SQL Server 2005 machine. If present, the file will be in the directory \Program Files\ Common Files\Microsoft Shared\SQL Debugging. You might find it on another SQL Server 2005 machine, or on a machine that has Visual Studio 2005 installed.

To copy SSDEBUGPS.dll onto the SQL Server 2005 machine:

1. Copy the file to the directory with the same name and path on the SQL Server 2005 machine.

2. Register it by opening a **Command Prompt**, and running the following command:

    ```cmd
    regsvr32 ssdebugps.dll
    ```
