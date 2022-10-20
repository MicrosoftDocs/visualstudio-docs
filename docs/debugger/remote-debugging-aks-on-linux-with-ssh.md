---
title: "Remote debug AKS on Linux using SSH"
description: Remote debug ASP.NET Core running in AKS on Linux using Secure Shell (SSH) by attaching to a process. Prepare your app for debugging. Build and deploy the app. Attach the debugger.
ms.date: "10/19/2022"
ms.topic: "conceptual"
helpviewer_keywords:
  - "remote debugging, linux"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Remote debug .NET Core running in AKS on Linux using SSH by attaching to a process

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Starting in Visual Studio 2022, you can attach to an ASP.NET Core process running in Azure Kubernetes Service (AKS) on a remote Linux deployment over SSH.

## Prerequisites

[!INCLUDE [prerequisites-dotnet-linux-ssh](../debugger/includes/prerequisites-dotnet-linux-ssh.md)]

## Prepare to debug

1. For AKS, expose the SSH port on the AKS pod, typically using a key pair.

   >[!NOTE]
   > Depending on your security configuration, health probes may detect an unhealthy service and tear down the pod.

2. To debug, follow instructions described in [Debug .NET Core on Linux using SSH by attaching to a process](../debugger/remote-debugging-dotnet-core-linux-with-ssh.md).

