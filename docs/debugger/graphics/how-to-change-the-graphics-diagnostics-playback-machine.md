---
title: "How to: Change the Graphics Diagnostics Playback Machine | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 1b9aa3ea-29a0-4e21-bc57-936f33537b5c
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: Change the Graphics Diagnostics Playback Machine
You can play back graphics information by using your local machine, or by using a remote machine or device.

## Choosing a Playback Machine
 The playback machine is a machine or device that's used to play back graphics events from a graphics log. Usually, the local machine is the most convenient option, but a rendering problem might not reproduce on a machine that has different hardware or driver versions than the machine where it was captured; when this happens, you can choose a remote playback machine that better reproduces the problem and still use your development machine to diagnose it.

#### To use the local machine to play back graphics information

1. On the Graphics Log document window, choose the **Playback Machine** link. The **Remote Debugger Connections** dialog box appears.

2. Under **Manual Configuration**, in the **Address** property, enter `localhost`.

3. Set the **Authentication Mode** property to **None**.

4. Choose the **Select** button.

#### To use a remote machine to play back graphics information

1. On the Graphics Log document window, choose the **Playback Machine** link. The **Remote Debugger Connections** dialog box appears.

2. Under **Manual Configuration**, in the **Address** property, enter the Windows domain name or IP address of the machine or device that you want to use to play back graphics information.

3. Specify the kind of authorization that you want to use to secure the connection to the playback machine.

    - For Windows Authentication, set the **Authentication Mode** property to **Windows**.

    - For no authentication, set the **Authentication Mode** property to **None**.

4. Choose the **Select** button.

> [!NOTE]
> The **Remote Debugger Connections** dialog box might also display remote debugging targets that are directly connected to your development machine or are on the same subnet. You can use one of these remote debugging targets as the Graphics Diagnostics playback machine without manually configuring it. In the **Remote Debugger Connections** dialog box, select the target you want and then choose the **Select** button.

## See also
- [Graphics Log Document](graphics-log-document.md)