---
description: "You attempted to invoke the Boolean.prototype.toString or Boolean.prototype.valueOf method on an object of a type other than Boolean."
title: "Boolean expected | Microsoft Docs"
ms.date: "01/18/2017"
ms.prod: visual-studio-windows
ms.technology: vs-javascript
ms.topic: error-reference
f1_keywords:
  - "VS.WebClient.Help.SCRIPT5010"
dev_langs:
  - "JavaScript"
  - "TypeScript"
  - "DHTML"
ms.assetid: 35d71b7f-53fd-44c4-a7c7-b1550c65cfd4
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

## See also

- [Boolean Object](https://developer.mozilla.org/docs/Web/JavaScript/Reference/Global_Objects/Boolean)
- [Data Types](https://developer.mozilla.org/docs/Web/JavaScript/Data_structures)
- [Controlling Program Flow](https://developer.mozilla.org/docs/Web/JavaScript/Guide/Control_flow_and_error_handling)
- [Copying, Passing, and Comparing Data](https://developer.mozilla.org/docs/Web/JavaScript/Guide/Functions)
