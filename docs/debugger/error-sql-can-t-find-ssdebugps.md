---
title: "Error: SQL Can&#39;t Find SSDEBUGPS | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.prod: "visual-studio-dev14"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-debug"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "vs.debug.error.sqlde_cant_find_ssdebugps"
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
  - "SQL"
ms.assetid: 596425c8-14c7-4c05-8823-e1c52f420f5e
caps.latest.revision: 6
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# Error: SQL Can&#39;t Find SSDEBUGPS
SSDEBUGPS.dll is the SQL Server Debugging Host component.  
  
 This error occurs when you are trying to start debugging, and indicates that the specified file is not present on the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine. Possible causes are that either Remote Debugging setup was never run, or that somehow this file got deleted.  
  
 There are two ways to resolve this error: by rerunning Remote Debugging setup, and by copying the file onto the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine.  
  
 To rerun Remote Debugging setup, follow the instructions at [Remote Debugging](../debugger/remote-debugging.md).  
  
 If you can locate a copy of ssdebugps.dll, you can copy it onto the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine. If present, the file will be in the directory \Program Files\ Common Files\Microsoft Shared\SQL Debugging. You might find it on another [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine, or on a machine that has [!INCLUDE[vsprvslong](../code-quality/includes/vsprvslong_md.md)] installed.  
  
### To copy SSDEBUGPS.dll onto the SQL Server 2005 machine  
  
1.  Copy the file to the directory with the same name and path on the [!INCLUDE[sqprsqlong](../debugger/includes/sqprsqlong_md.md)] machine.  
  
2.  Register it by opening a **Command Prompt**, and running the following command:  
  
    ```  
    regsrv32 ssdebugps.dll  
    ```