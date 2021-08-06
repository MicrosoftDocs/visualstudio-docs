---
title: Stop Code Changes | Microsoft Docs
description: Understand how to stop applying code changes while using the Edit and Continue feature during a Visual Studio debugging session.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - Stop Applying Code Changes command
  - code changes, stopping application of
  - Edit and Continue, stopping code changes
ms.assetid: 9e72a50c-bb0a-4eaa-9ac1-d00930b68d38
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
ms.workload: 
  - multiple
---
# How to: Stop Code Changes
While Edit and Continue is in the process of applying code changes, you can stop the operation.

> [!CAUTION]
> Stopping code changes in managed code can produce unexpected results. Applying changes to managed code is normally a quick process, so there is seldom a need to stop code changes in managed code.

### To stop applying code changes

- Choose **Stop Applying Code Changes** from the **Debug** menu.

  This menu item is visible only when code changes are being applied.

  If you choose this option, none of the code changes are committed.

## See also
- [Edit and Continue](../debugger/edit-and-continue.md)
- [Edit and Continue, Debugging, Options Dialog Box](./edit-and-continue.md)