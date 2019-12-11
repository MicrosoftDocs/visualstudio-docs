---
title: "&lt;deprecated&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
ms.assetid: cf33d371-59da-4310-95ee-d7524fd9d58c
caps.latest.revision: 10
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;deprecated&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies a deprecated function or method.

## Syntax

```
<deprecated
    type="deprecate|remove"
    locid="descriptionID">description
</deprecated>
```

#### Parameters
 `type`
 Optional. Specifies whether the function or method will be removed in a future release, or whether the function or method has already been removed and that its use may result in an error. Set to `deprecate` to specify that the function or method will be removed in a future release. Set to `remove` to specify that the function or method has already been removed.

 `locid`
 Optional. The identifier for localization information about the function or method. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../ide/loc-javascript.md) element.

 `description`
 Optional. A description of the function or method that is being deprecated.

## Remarks
 The elements used to annotate functions, which include `<deprecated>`, must be placed in the function body before any statements. When you mark a function as deprecated, we recommend that you replace its [\<summary>](../ide/summary-javascript.md) element with the `<deprecated>` element.

## Example
 The following code shows how to use the `<deprecated>` element.

```javascript
function areaFunction(radiusParam) {
    /// <deprecated type="deprecate" >Determines the area of a circle when supplied a radius parameter.</deprecated>
    /// <param name="radiusParam" type="Number">The radius of the circle.</param>
    /// <returns type="Number">The area.</returns>
    var areaVal;
    areaVal = Math.PI * radiusParam * radiusParam;
    return areaVal;
}

```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
