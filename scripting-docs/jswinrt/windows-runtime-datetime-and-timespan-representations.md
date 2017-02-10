---
title: "Windows Runtime DateTime and TimeSpan Representations | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "JavaScript, Windows Runtime dates and times"
  - "TimeSpan [JavaScript]"
  - "DateTime [JavaScript]"
ms.assetid: 9743e9ac-9054-463e-8264-427183e4905f
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Windows Runtime DateTime and TimeSpan Representations
The JavaScript representation of dates and times is different from the Windows Runtime version. The Windows Runtime [DateTime](http://msdn.microsoft.com/library/windows/apps/windows.foundation.datetime.aspx) structure is represented in JavaScript as a [Date](../javascript/reference/date-object-javascript.md) that has a backing store that matches the `DateTime` data (and has a different range and precision from the JavaScript `Date`). If you modify this custom `Date` object, it becomes a standard JavaScript `Date` and loses precision. JavaScript `Date` values can be passed to a Windows Runtime `DateTime` and will be range-checked, which might result in marshaling exceptions.  
  
 The Windows Runtime [TimeSpan](http://msdn.microsoft.com/en-us/c5defb66-819c-4796-85b5-07ed249a5d86) structure is converted to milliseconds and returned as a JavaScript number.  
  
## See Also  
 [Using the Windows Runtime in JavaScript](../jswinrt/using-the-windows-runtime-in-javascript.md)