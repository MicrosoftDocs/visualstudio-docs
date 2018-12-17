---
title: "Debug COM clients and servers using RPC debugging | Microsoft Docs"
ms.custom: "seodec18"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.debug.com"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "RPC (Remote Procedure Call), debugging COM clients and servers"
  - "COM, debugging"
  - "RPC (Remote Procedure Call)"
  - "RPC (Remote Procedure Call), debugging"
  - "COM clients, debugging"
  - "COM servers, debugging"
  - "out-of-process remote procedure call debugging"
  - "remote debugging, RPC (Remote Procedure Call)"
  - "in-process remote procedure call debugging"
ms.assetid: 3e8526c8-43b5-4b87-8e0d-b22c24f0a3ea
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Debug COM Clients and Servers Using RPC Debugging
You can use remote procedure call (RPC) debugging to debug COM client/server applications. You must enable RPC debugging to use it. With RPC debugging enabled, when you step into the server call from the client, the debugger attaches to the server and lets you debug its code. When the debugger is attached, you can use all debugger features with both the client and server processes.

### To enable RPC debugging

1. On the **Tools** menu, click **Options**.

2. In the **Options** dialog box, click the **Debugging** folder.

3. Click the **Native** page.

4. Select the **RPC debugging** check box.

    > [!NOTE]
    > To debug RPC calls, you must have Administrator or Power User privileges.

    > [!NOTE]
    > RPC stepping into a remote server that runs Microsoft Windows Vista will work only if a native debugger is attached to the remote server. Otherwise, the RPC call will fail without an error message. Otherwise the RPC call will complete, but the step-into the RPC call will not work.

## See also
- [COM Server and Container Debugging](../debugger/com-server-and-container-debugging.md)
- [Debugging in Visual Studio](../debugger/index.yml)
- [First look at the debugger](../debugger/debugger-feature-tour.md)