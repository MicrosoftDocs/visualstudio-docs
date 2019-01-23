---
title: "Boolean expected | Microsoft Docs"
ms.custom: ""
ms.date: "01/18/2017"
ms.prod: "windows-client-threshold"
ms.reviewer: ""
ms.suite: ""
ms.technology:
  - "javascript"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords:
  - "VS.WebClient.Help.SCRIPT5010"
dev_langs:
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 35d71b7f-53fd-44c4-a7c7-b1550c65cfd4
caps.latest.revision: 9
author: "mikejo5000"
ms.author: "mikejo"
manager: "ghogen"
---
# Boolean expected
You attempted to invoke the **Boolean.prototype.toString** or **Boolean.prototype.valueOf** method on an object of a type other than `Boolean`. The object of this type of invocation must be of type `Boolean`. For example:

```JavaScript
var o = new Object;
o.f = Boolean.prototype.toString;
o.f();
```

## To correct this error

- Only invoke the **Boolean.prototype.toString** or **Boolean.prototype.valueOf** methods on objects of type **Boolean.**

## See Also

- [Boolean Object](../../javascript/reference/boolean-object-javascript.md)
- [Data Types](../../javascript/data-types-javascript.md)
- [Controlling Program Flow](../../javascript/controlling-program-flow-javascript.md)
- [Copying, Passing, and Comparing Data](../../javascript/advanced/copying-passing-and-comparing-data-javascript.md)