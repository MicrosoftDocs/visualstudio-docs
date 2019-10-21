---
title: "&lt;value&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "<value> JavaScript XML tag"
  - "value JavaScript XML tag"
ms.assetid: 983e31de-cb1d-411e-b60d-eea6698a26f6
caps.latest.revision: 11
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;value&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies documentation information for `get` and `set` functions for ECMAScript 3 properties.

## Syntax

```
<value type="ValueType" integer="true|false"
    domElement="true|false" mayBeNull="true|false"
    elementType="ArrayElementType" elementInteger="true|false"
    elementDomElement="true|false" elementMayBeNull="true|false"
    locid="descriptionID">description
</value>
```

#### Parameters
 `type`
 Optional. The data type of the property. The type can be one of the following:

- An ECMAScript language type that's in the ECMAScript 5 specification, such as `Number` and `Object`.

- A DOM object, such as `HTMLElement`, `Window`, and `Document`.

- A JavaScript constructor function.

  `integer`
  Optional. If `type` is `Number`, specifies whether the property is an integer. Set to `true` to indicate that the property is an integer; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `domElement`
  Optional. This attribute is deprecated; the `type` attribute takes precedence over this attribute. This attribute specifies whether the documented property is a DOM element. Set to `true` to specify that the property is a DOM element; otherwise, set to `false`. If the `type` attribute is not set and `domElement` is set to `true`, IntelliSense treats the documented property as an `HTMLElement` when performing statement completion.

  `mayBeNull`
  Optional. Specifies whether the documented property can be set to null. Set to `true` to indicate that the property can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementType`
  Optional. If `type` is `Array`, this attribute specifies the type of the elements in the array.

  `elementInteger`
  Optional. If `type` is `Array` and `elementType` is `Number`, this attribute specifies whether the elements in the array are integers. Set to `true` to indicate that the elements in the array are integers; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementDomElement`
  Optional. This attribute is deprecated; the `elementType` attribute takes precedence over this attribute. If `type` is `Array`, this attribute specifies whether the elements in the array are DOM elements. Set to `true` to specify that the elements are DOM elements; otherwise, set to `false`. If the `elementType` attribute is not set and `elementDomElement` is set to `true`, IntelliSense treats each element in the array as an `HTMLElement` when performing statement completion.

  `elementMayBeNull`
  Optional. If `type` is `Array`, specifies whether the elements in the array can be set to null. Set to `true` to indicate that the elements in the array can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `locid`
  Optional. The identifier for localization information about the property. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../ide/loc-javascript.md) element.

  `description`
  Optional. A description of the property.

## Remarks
 ECMAScript 5 properties use the [\<summary>](../ide/summary-javascript.md) element.

 Use the `<value>` element immediately before the `get` or `set` function.

## Example
 The following code example shows how to use the `<value>` element on a `get` function.

```javascript
function Sys$CancelEventArgs$get_cancel() {
    /// <value type="Boolean" locid="P:J#Sys.CancelEventArgs.cancel"></value>
    if (arguments.length !== 0) throw Error.parameterCount();
    return this._cancel();
}
```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
