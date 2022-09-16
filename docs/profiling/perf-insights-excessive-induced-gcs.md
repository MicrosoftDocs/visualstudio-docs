---
title: Perf insights for excessive induced GCs
description: Learn how to improve performance for excessive induced garbage collections
ms.date: 9/15/2022
ms.topic: reference
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---

# Excessive induced GCs

This article describes performance insights for excessive induced garbage collections (GCs).

## Cause

It's rarely justified to induce GCs as GC manages its own schedule. The only rare cases are mostly from framework but even that should be very rare. If you are seeing too many induced GCs it's something to investigate especially if you are worried about your GC time or if you are surprised by the fact there are induced GCs.

## Rule description

The [.NET Garbage Collector (GC)](/dotnet/standard/garbage-collection/) can determine the best time to perform a collection in most cases.

When an application frequently forces GC collections, it might impact performance and responsiveness of an application.

## How to investigate a warning

Look for (GC.Collect Method (System) | Microsoft Docs) and check if they are really needed.