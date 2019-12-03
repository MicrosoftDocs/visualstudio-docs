---
title: "Hardware Supported Data Breakpoints | Microsoft Docs"
ms.date: "12/3/2019"
ms.topic: "conceptual"
helpviewer_keywords:
  - "hardware supported data breakpoints"
ms.assetid: a842caf3-d635-4620-bc81-1d4a6ea06ed6
author: "waan"
ms.author: "waan"
manager: caslan
ms.workload:
  - "multiple"
---
# Debug Registers

The architecture (platform configuration) that your program runs on has a limited number of hardware data breakpoints it can use. The table below indicates how many registers are available to use per architecture.

| Architecture | Number of Hardware Supported Data Breakpoints | Max Byte Size|
| :-------------: |:-------------:| :-------------:|
| x86 | 4 | 4 |
| x64 | 4 | 8 |
| ARM | 1 | 4 |
| ARM64 | 2 | 8 |