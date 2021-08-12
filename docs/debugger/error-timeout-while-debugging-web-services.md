---
description: "When you are stepping into an XML Web service from calling code, the call may sometimes time out, with the result being that you cannot continue debugging."
title: "Timeout While Debugging Web Services | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "error-reference"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
  - "C++"
helpviewer_keywords:
  - "debugger, Web application errors"
  - "XML Web services, timeout while debugging"
author: "mikejo5000"
ms.author: "mikejo"
manager: jmartens
ms.technology: vs-ide-debug
ms.workload:
  - "multiple"
---
# Error: Timeout While Debugging Web Services
When you are stepping into an XML Web service from calling code, the call may sometimes time out, with the result being that you cannot continue debugging. You may see an error message such as this.

```cmd
An unhandled exception of type 'System.Net.WebException' occurred in
system.Web.services.dll
Additional information: The operation has timed-out.
```

## Solution
 To avoid this problem, set the timeout value for the call to the XML Web service to infinite, as shown in this example:

```csharp
Service1 obj = new Service1();
obj.TimeOut = -1; // infinite time out.
```

## See also
- [Debugging Web Applications: Errors and Troubleshooting](../debugger/debugging-web-applications-errors-and-troubleshooting.md)
