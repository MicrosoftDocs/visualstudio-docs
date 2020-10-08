---
title: "&lt;returns&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "returns JavaScript XML tag"
  - "<returns> JavaScript XML tag"
ms.assetid: 10d97829-c0ae-40a5-b04c-d8b538cdefbc
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;returns&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies documentation information for the result of a function or method call.

## Syntax

```
<returns type="ValueType" integer="true|false"
    domElement="true|false" mayBeNull="true|false"
    elementType="ArrayElementType" elementInteger="true|false"
    elementDomElement="true|false" elementMayBeNull="true|false"
    locid="descriptionID" value="code">description
</returns>
```

#### Parameters
 `type`
 Optional. The data type of the return value. The type can be one of the following:

- An ECMAScript language type in the ECMAScript 5 specification, such as `Number` and `Object`.

- A DOM object, such as `HTMLElement`, `Window`, and `Document`.

- A JavaScript constructor function.

  `integer`
  Optional. If `type` is `Number`, specifies whether the return value is an integer. Set to `true` to indicate that the return value is an integer; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `domElement`
  Optional. This attribute is deprecated; the `type` attribute takes precedence over this attribute. This attribute specifies whether the documented return value is a DOM element. Set to `true` to specify that the return value is a DOM element; otherwise, set to `false`. If the `type` attribute is not set and `domElement` is set to `true`, IntelliSense treats the documented return value as an `HTMLElement` when performing statement completion.

  `mayBeNull`
  Optional. Specifies whether the documented return value can be set to null. Set to `true` to indicate that the return value can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementType`
  Optional. If `type` is `Array`, this attribute specifies the type of the elements in the array.

  `elementInteger`
  Optional. If `type` is `Array` and `elementType` is `Number`, this attribute specifies whether the elements in the array are integers. Set to `true` to indicate that the elements in the array are integers; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementDomElement`
  Optional. This attribute is deprecated; the `elementType` attribute takes precedence over this attribute. If `type` is `Array`, this attribute specifies whether the elements in the array are DOM elements. Set to `true` to specify that the elements are DOM elements; otherwise, set to `false`. If the `elementType` attribute is not set and `elementDomElement` is set to `true`, IntelliSense treats each element in the array as an `HTMLElement` when performing statement completion.

  `elementMayBeNull`
  Optional. If `type` is `Array`, specifies whether the elements in the array can be set to null. Set to `true` to indicate that the elements in the array can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `locid`
  Optional. The identifier for localization information about the return value. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../ide/loc-javascript.md) tag.

  `value`
  Optional. Specifies code that should be evaluated for use by IntelliSense instead of the function code itself. For example, you can use this attribute to provide IntelliSense for asynchronous callbacks, such as a `Promise`. Using the `value` attribute with the `<returns>` element can improve IntelliSense performance by bypassing lengthy code execution.

  `description`
  Optional. A description of the return value.

## Remarks
 The `<returns>` element must be placed in the function body before any statements.

## Example
 The following code example shows how to use the `<returns>` element.

```javascript
function areaFunction(radiusParam)
{
    /// <summary>Determines the area of a circle when provided a radius parameter.</summary>
    /// <param name="radiusParam" type="Number">The radius of the circle.</param>
    /// <returns type="Number">The area.</returns>
    var areaVal;
    areaVal = Math.PI * radiusParam * radiusParam;
    return areaVal;
}

// The following examples use the <remarks> element with a value attribute.

function getJson(complete) {
    /// <returns value='complete("")' ></returns>
    var r = new XMLHttpRequest();
    // . . .
}

getJson(function (json) {
    json.  // IntelliSense for a String object is
           // available here.
});

function calculate(x) {
    /// <returns value='1'/>
}
calculate().  // Completion list for a Number.

```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
