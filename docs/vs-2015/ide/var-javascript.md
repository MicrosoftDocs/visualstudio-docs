---
title: "&lt;var&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "<var> JavaScript XML tag"
  - "var JavaScript XML tag"
ms.assetid: 34ff9023-c81c-46d1-85b6-0022f0962e66
caps.latest.revision: 14
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;var&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies documentation information for a variable.

## Syntax

```
<var type="ValueType" integer="true|false"
    domElement="true|false" mayBeNull="true|false"
    elementType="ArrayElementType" elementInteger="true|false"
    elementDomElement="true|false" elementMayBeNull="true|false"
    helpKeyword="keyword" locid="descriptionID">description
</var>
```

#### Parameters
 `type`
 Optional. The data type of the variable. The type can be one of the following:

- An ECMAScript language type that's in the ECMAScript 5 specification, such as `Number` and `Object`.

- A DOM object, such as `HTMLElement`, `Window`, and `Document`.

- A JavaScript constructor function.

  `integer`
  Optional. If `type` is `Number`, specifies whether the variable is an integer. Set to `true` to indicate that the variable is an integer; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `domElement`
  Optional. This attribute is deprecated; the `type` attribute takes precedence over this attribute. This attribute specifies whether the documented variable is a DOM element. Set to `true` to specify that the variable is a DOM element; otherwise, set to `false`. If the `type` attribute is not set and `domElement` is set to `true`, IntelliSense treats the documented variable as an `HTMLElement` when performing statement completion.

  `mayBeNull`
  Optional. Specifies whether the documented variable can be set to null. Set to `true` to indicate that the variable can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementType`
  Optional. If `type` is `Array`, this attribute specifies the type of the elements in the array.

  `elementInteger`
  Optional. If `type` is `Array` and `elementType` is `Number`, this attribute specifies whether the elements in the array are integers. Set to `true` to indicate that the elements in the array are integers; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementDomElement`
  Optional. This attribute is deprecated; the `elementType` attribute takes precedence over this attribute. If `type` is `Array`, this attribute specifies whether the elements in the array are DOM elements. Set to `true` to specify that the elements are DOM elements; otherwise, set to `false`. If the `elementType` attribute is not set and `elementDomElement` is set to `true`, IntelliSense treats each element in the array as an `HTMLElement` when performing statement completion.

  `elementMayBeNull`
  Optional. If `type` is `Array`, specifies whether the elements in the array can be set to null. Set to `true` to indicate that the elements in the array can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `helpKeyword`
  Optional. The keyword for F1 Help.

  `locid`
  Optional. The identifier for localization information about the variable. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../ide/loc-javascript.md) tag.

  `description`
  Optional. A description of the variable.

## Example
 The following code example shows how to use the `<var>` element.

```javascript
/// <var>A rectangle that has a width of 5.</var>
var Rectangle = {
    /// <field type = 'Number'>The width of the rectangle.</field>
    wid: 5,
    /// <field type = 'Number'>The length of the rectangle.</field>
    len: 0,
    /// <field type='Number'>Returns the area of the rectangle.</field>
    getArea: function (wid, len) {
        return len * wid;
    }
}
```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
