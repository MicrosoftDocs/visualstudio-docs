---
title: View Script Documents
description: Understand how to view JavaScript server-side script documents in Visual Studio using Solution Explorer.
ms.date: 11/05/2019
ms.topic: how-to
dev_langs: 
  - CSharp
  - VB
  - FSharp
  - C++
helpviewer_keywords: 
  - Script Explorer
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: debug-diagnostics
---
# View Script Documents (JavaScript)

Server-side script files are visible in Solution Explorer. Client-side script files are visible only when you are in debug mode or break mode. Client-side script files appear in the **Script Documents** node.

For some application types that dynamically generate pages, it is easier to enter break mode and debug when you set a breakpoint from a script document that is loaded in the browser. Similarly, you can add the `debugger` statement from a loaded script document to enter break mode. This article shows how to view these documents.

### To view a server-side script document

1. In **Solution Explorer**, open the **\<Website Pathname>** node.

2. Double-click the script file that you want to view.

     The server-side script file opens in a source window.

### To view a client-side script document

1. In **Solution Explorer**, open the **Script Documents** node.

2. Double-click the script file that you want to view.

     The client-side script file opens in a source window.

## Related content
- [Viewing Data in the Debugger](../debugger/viewing-data-in-the-debugger.md)