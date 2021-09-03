---
title: Debug an ActiveX Control | Microsoft Docs
description: Learn how to debug an ActiveX control. You must specify a containing executable, which you can do in Project Property Pages or when you begin debugging.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
f1_keywords: 
  - vc.controls.debug
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - testing [Visual Studio], test containers
  - ActiveX control container debugging [Visual Studio]
  - debugging ActiveX controls
  - data-bound controls, ActiveX
  - test container
  - containers, specifying for debug sessions
  - ActiveX controls, debugging
  - testing [Visual Studio], ActiveX controls
ms.assetid: bbc02cf7-a7e6-44fe-99af-87a43e1d7251
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Debug an ActiveX Control

> [!NOTE]
> The dialog boxes and menu commands you see might differ from those described in Help depending on your active settings or edition. To change your settings, choose Import and Export Settings on the Tools menu. For more information, see [Reset settings](../ide/environment-settings.md#reset-settings).

To debug your ActiveX control, you must specify a container (executable) for the control to run in.

## To specify a container for the debug session

1. In Solution Explorer, select the project.

2. From the **View** menu, choose **Property Pages**.

3. In the **Project Property Pages** dialog box, open the **Configuration Properties** folder, and select **Debugging**.

4. Under the **Debugging** category, locate the **Command** property.

5. Specify the path name for the container. For example, C:\Program Files\Internet Explorer\IEXPLORE.EXE.

6. If you specify Internet Explorer as the container and you are using Active Desktop, type `/new` in the **Command Arguments** box.

7. Click **OK**.

     If you do not specify a container in the **Project Property Pages** dialog box, you can specify the container when you begin debugging. When you select an execution command to start debugging, the [Executable for Debugging Session Dialog Box](../debugger/executable-for-debugging-session-dialog-box.md) appears. Specify the path name of the container in the dialog box.

## See also

- [ActiveX Controls](/cpp/mfc/activex-controls)
- [Testing Properties and Events with Test Container](/cpp/mfc/testing-properties-and-events-with-test-container)
- [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)
- [Debugging in Visual Studio](../debugger/index.yml)
- [First look at the debugger](../debugger/debugger-feature-tour.md)
