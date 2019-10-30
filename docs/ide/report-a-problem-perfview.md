---
title: Collect an ETL trace with PerfView
ms.date: 09/27/2019
ms.topic: conceptual
helpviewer_keywords:
  - "perfview"
  - "ETL Trace"
author: mikeblome
ms.author: mblome
manager: jillfra
dev_langs:
 - CSharp
 - VB
 - CPP
ms.workload:
  - "multiple"
ms.description: "Use perfview.exe to collect ETL traces for troubleshooting issues with Visual Studio"
---
# Collect an ETL trace with PerfView

PerfView is a tool that creates ETL (event trace log) files based on [Event Tracing for Windows](/windows/desktop/ETW/event-tracing-portal) that can be useful in troubleshooting some kinds of issues with Visual Studio. Occasionally when you report a problem, the product team may ask you to run PerfView to collect additional information.

## Install PerfView

Download PerfView from [GitHub](https://github.com/Microsoft/perfview/blob/master/documentation/Downloading.md).

## Run PerfView

1. Right-click on **PerfView.exe** in Windows Explorer and choose **Run as administrator** as admin
1. On the Collect menu, choose **Collect**
1. Check **Zip**, **Merge**, and **ThreadTime**.
1. Increase **Circular MB** to 1000.
1. Change **Current Dir** to save ETL traces to a specified folder and Data File if you are going to collect more than once.
1. To start recording data, choose the **Start Collection** button.
1. To stop recording data, choose the **Stop Collection** button. The PrefView.etl.zip file will be saved in the specified directory.

PerfView can store only the most recent data that fits into its buffer. Therefore, try to stop the collection as soon as possible after Visual Studio starts to freeze or slow down. Don't collect for more than 30 seconds after you hit a problem.

For more information, see [PerfView Tutorial on Channel9](https://channel9.msdn.com/Series/PerfView-Tutorial/PerfView-Tutorial-1-Collecting-data-with-the-Run-command).
