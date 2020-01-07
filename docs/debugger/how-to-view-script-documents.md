---
title: "How to: View Script Documents | Microsoft Docs"
ms.date: "11/05/2019"
ms.topic: "conceptual"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "Script Explorer"
ms.assetid: 8b621e53-4508-4b4a-9995-70995b0b9ac8
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How to: View Script Documents (JavaScript)

Server-side script files are visible in Solution Explorer. Client-side script files are visible only when you are in debug mode or break mode. Client-side script files appear in the **Script Documents** node.

For some application types that dynamically generate pages, it is easier to enter break mode and debug when you set a breakpoint from a script document that is loaded in the browser. Similarly, you can add the `debugger` statement from a loaded script document to enter break mode. This article shows how to view these documents.

> [!NOTE]
> Previous to [!INCLUDE[vs_dev11_long](../data-tools/includes/vs_dev11_long_md.md)], client-side script files generated from server-side script appeared in the Script Explorer window.

### To view a server-side script document

1. In **Solution Explorer**, open the **\<Website Pathname>** node.

2. Double-click the script file that you want to view.

     The server-side script file opens in a source window.

### To view a client-side script document

1. In **Solution Explorer**, open the **Script Documents** node.

2. Double-click the script file that you want to view.

     The client-side script file opens in a source window.

## See also
- [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)