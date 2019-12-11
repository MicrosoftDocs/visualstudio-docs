---
title: "Debugging a Data-Bound ActiveX Control | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "data-bound controls, ActiveX"
  - "ActiveX controls, debugging"
  - "controls [Visual Studio], ActiveX"
ms.assetid: 9f6e1f00-e25b-48a9-8484-7e67a1232461
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Debugging a Data-Bound ActiveX Control
If you are developing an ActiveX control that will be bound to a data source control, you can create your own container application and use that container to debug the ActiveX control.

 For example, you can create a dialog-based MFC application and place your data-bound control and a data source control on the dialog box. You can use this MFC application for run-time testing and as the container executable for debugging your data-bound ActiveX control.

## Using the Test Container
 If you want a container that you can easily modify to support various interfaces on either the control or the container, use the ActiveX Test Container as the executable for the debug session. In the ActiveX Test Container, click **Options** from the **Container** menu to enable various interfaces. For more information, see [Testing Properties and Events with Test Container](/cpp/mfc/testing-properties-and-events-with-test-container).

 If you need to step into the container's code while you are debugging, use the debug version of your container or use the debug version of the ActiveX Test Container. For more information, see [TSTCON Sample: ActiveX Control Test Container](https://msdn.microsoft.com/library/72fa40ef-27d3-400c-813f-10b03236e600).

## See also
- [COM and ActiveX Debugging](../debugger/com-and-activex-debugging.md)
- [ActiveX Controls](/cpp/mfc/activex-controls)