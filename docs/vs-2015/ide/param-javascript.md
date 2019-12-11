---
title: "&lt;param&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "<param> JavaScript XML tag"
  - "param JavaScript XML tag"
ms.assetid: 2c4e0167-c1dd-4e54-83f1-c437856bddc1
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;param&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies documentation information for a parameter in a function or method.

## Syntax

```
<param name="parameterName" type="ParameterType"
    integer="true|false" domElement="true|false"
    mayBeNull="true|false" elementType="ArrayElementType"
    elementInteger="true|false" elementDomElement="true|false"
    elementMayBeNull="true|false" locid="descriptionID"
    parameterArray="true|false" optional="true|false"
    value="code">description
</param>
```

#### Parameters
 `name`
 Required. The name of the parameter.

 `type`
 Optional. The data type of the parameter. The type can be one of the following:

- An ECMAScript language type in the ECMAScript 5 specification, such as `Number` and `Object`.

- A DOM object, such as `HTMLElement`, `Window`, and `Document`.

- A JavaScript constructor function.

  `integer`
  Optional. If `type` is `Number`, specifies whether the parameter is an integer. Set to `true` to indicate that the parameter is an integer; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `domElement`
  Optional. This attribute is deprecated; the `type` attribute takes precedence over this attribute. This attribute specifies whether the documented parameter is a DOM element. Set to `true` to specify that the parameter is a DOM element; otherwise, set to `false`. If the `type` attribute is not set and `domElement` is set to `true`, IntelliSense treats the documented parameter as an `HTMLElement` when performing statement completion.

  `mayBeNull`
  Optional. Specifies whether the documented parameter can be set to null. Set to `true` to indicate that the parameter can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementType`
  Optional. If `type` is `Array`, this attribute specifies the type of the elements in the array.

  `elementInteger`
  Optional. If `type` is `Array` and `elementType` is `Number`, this attribute specifies whether the elements in the array are integers. Set to `true` to indicate that the elements in the array are integers; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementDomElement`
  Optional. This attribute is deprecated; the `elementType` attribute takes precedence over this attribute. If `type` is `Array`, this attribute specifies whether the elements in the array are DOM elements. Set to `true` to specify that the elements are DOM elements; otherwise, set to `false`. If the `elementType` attribute is not set and `elementDomElement` is set to `true`, IntelliSense treats each element in the array as an `HTMLElement` when performing statement completion.

  `elementMayBeNull`
  Optional. If `type` is `Array`, specifies whether the elements in the array can be set to null. Set to `true` to indicate that the elements in the array can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `locid`
  Optional. The identifier for localization information about the parameter. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../ide/loc-javascript.md) element.

  `parameterArray`
  Optional. Specifies whether the documented parameter can be repeated in the function call, similar to repeating parameters supported in the `String.format` function. Set to `true` to indicate that the parameter can be repeated; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `optional`
  Optional. Specifies whether the documented parameter is optional in the calling function. Set to `true` to indicate that the parameter is optional; otherwise, set to `false`.

  `value`
  Optional. Specifies code that should be evaluated for use by IntelliSense instead of the function code itself. You can use this attribute is to provide type information when the parameter type is undefined. For example, you can use `value=’1’` to treat the parameter type as a number.

  `description`
  Optional. A description of the parameter.

## Remarks
 The only required attribute is `name`. All other attributes are optional.

 Elements used to annotate functions, such as [\<summary>](../ide/summary-javascript.md), [\<param>](../ide/param-javascript.md), and [\<returns>](../ide/returns-javascript.md), must be placed in the function body before any statements.

 If there are multiple `<param>` elements that have the same name, one of the `<param>` elements is used and the redundant elements are ignored. The behavior that determines which element is used is not defined. If `name` refers to a nonexistent parameter, the element is ignored.

## Example
 The following code example shows how to use the `<param>` element.

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

// Uses of <param> with the value attribute.

function calculate(a) {
    /// <param name='a' value='1'/>
    a.    // Completion list for a Number.
}

function calculate(a) {
    /// <param name='a' value='{x:0,y:0}'/>
    a.    // x and y appear in the completion list.
}

```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
