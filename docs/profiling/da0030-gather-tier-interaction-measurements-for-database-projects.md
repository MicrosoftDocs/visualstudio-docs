---
title: "DA0030: Gather Tier Interaction measurements for database projects | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
f1_keywords:
  - "vs.performance.DA0030"
  - "vs.performance.rules.DA0030"
  - "vs.performance.30"
ms.assetid: 42b2f69d-0cfa-4854-82c4-589c3d8b4557
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
monikerRange: 'vs-2017'
ms.workload:
  - "multiple"
---
# DA0030: Gather tier interaction measurements for database projects

|||
|-|-|
|Rule Id|DA0030|
|Category|Profiling Tools Usage|
|Profiling method|Sampling|
|Message|Gathering interaction measurements for multi-tiered applications will help you understand database usage patterns and key data access delays. Try profiling the application again with the Tier Interaction Profiling option enabled.|
|Rule type|Information|

## Cause
 Calls to <xref:System.Data> methods are a significant proportion of the profiling data and you have not collected tier interaction data in the profiling run. Consider profiling again and adding tier interaction data.

## Rule description
 This rule fires whenever there is significant activity in functions that reside in the System.Data namespaces, including <xref:System.Data.Linq><xref:System.Data.Linq>.

 Multi-tiered applications use layered services for their presentation and data layers. Often the data layer is a separate process running a database management system such as Microsoft SQL Server. The data layer might even be running on a separate machine from the rest of the application. Sampling profiles provide little insight into functions and services running out-of-process or remotely.

 The profiling tools can gather timing information for multi-tiered applications that are interacting with a Microsoft SQL Server data layer using asynchronous calls to ADO.NET services. You must explicitly enable Tier Interaction Profiling. It is not turned on by default.

## How to fix violations
 This rule is for information only, and might not require corrective action.

 For information about how to add tier interaction data to profiling data from the Visual Studio IDE, see [Collect tier interaction data](../profiling/collecting-tier-interaction-data.md). For information about how to add tier interaction data from the command line, see [Collect tier interaction data](../profiling/adding-tier-interaction-data-from-the-command-line.md).
