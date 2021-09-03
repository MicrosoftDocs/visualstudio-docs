---
description: "SSDEBUGPS.dll is the SQL Server Debugging Host component."
title: "SQL Can&apos;t Find SSDEBUGPS | Microsoft Docs"
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
ms.workload:
  - "multiple"
---
# Error: SQL Can&#39;t Find SSDEBUGPS

SSDEBUGPS.dll is the SQL Server Debugging Host component.

This error occurs when you are trying to start debugging, and indicates that the specified file is not present on the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine. Possible causes are that either Remote Debugging setup was never run, or that somehow this file got deleted.

There are two ways to resolve this error: by rerunning Remote Debugging setup, and by copying the file onto the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine.

To rerun Remote Debugging setup, follow the instructions at [Remote Debugging](../debugger/remote-debugging.md).

If you can locate a copy of ssdebugps.dll, you can copy it onto the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine. If present, the file will be in the directory \Program Files\ Common Files\Microsoft Shared\SQL Debugging. You might find it on another [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine, or on a machine that has Visual Studio 2005 installed.

To copy SSDEBUGPS.dll onto the SQL Server 2005 machine:

1. Copy the file to the directory with the same name and path on the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine.

2. Register it by opening a **Command Prompt**, and running the following command:

    ```cmd
    regsvr32 ssdebugps.dll
    ```
