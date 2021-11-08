---
description: "The Visual Studio debugger cannot connect to the remote computer."
title: "RPC Requires Authentication | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "error-reference"
f1_keywords:
  - "vs.debug.error.rpc_requires_authentication"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Error: RPC Requires Authentication
The Visual Studio debugger cannot connect to the remote computer. An RPC policy is enabled on the local computer which prevents remote debugging.

### To correct this error

1. Run `\`*windir*`\system32\regedt32.exe`

2. Locate and delete `HKEY_LOCAL_MACHINE\Software\Policies\Microsoft\Windows NT\RPC\RestrictRemoteClients`.

3. Restart your computer so the registry change will take effect.

4. If the problem persists, contact your domain administrator about the **Computer Configuration > Administrative Templates > System > Remote Procedure Call > Restrictions for Unauthenticated RPC clients** group policy setting.
