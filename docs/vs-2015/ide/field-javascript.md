---
title: "&lt;field&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "<field> JavaScript XML tag"
  - "field JavaScript XML tag"
ms.assetid: c494bae0-3095-42a3-aa0a-4c415188c65c
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;field&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies documentation information, including a description, for either a field or member that's defined on an object.

## Syntax

```
<field name="fieldName" static="true|false"
    type="FieldType" integer="true|false"
    domElement="true|false" mayBeNull="true|false"
    elementType="ArrayElementType" elementInteger="true|false"
    elementDomElement="true|false" elementMayBeNull="true|false"
    helpKeyword="keyword" locid="descriptionID"
    value="code">description
</field>
```

#### Parameters
 `name`
 The name of the field or member. When the `<field>` element is used in a constructor function, `name` is required and defines the member to which the tag applies. When the `<field>` element is directly annotating a field, this attribute is ignored, and the name used by Visual Studio is the name of the actual field in the source code.

 `static`
 Optional. Specifies whether the field is a member of the constructor function or a member of the object returned by the constructor function. Set to `true` to treat the field as a member of the constructor function. Set to `false` to treat the field as a member of the object returned by the constructor function.

 `type`
 Optional. The data type of the field. The type can be one of the following:

- An ECMAScript language type in the ECMAScript 5 specification, such as `Number` and `Object`.

- A DOM object, such as `HTMLElement`, `Window`, and `Document`.

- A JavaScript constructor function.

  `integer`
  Optional. If `type` is `Number`, specifies whether the field is an integer. Set to `true` to indicate that the field is an integer; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `domElement`
  Optional. This attribute is deprecated; the `type` attribute takes precedence over this attribute. This attribute specifies whether the documented field is a DOM element. Set to `true` to specify that the field is a DOM element; otherwise, set to `false`. If the `type` attribute is not set and `domElement` is set to `true`, IntelliSense treats the documented field as an `HTMLElement` when performing statement completion.

  `mayBeNull`
  Optional. Specifies whether the documented field can be set to null. Set to `true` to indicate that the field can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementType`
  Optional. If `type` is `Array`, this attribute specifies the type of the elements in the array.

  `elementInteger`
  Optional. If `type` is `Array` and `elementType` is `Number`, this attribute specifies whether the elements in the array are integers. Set to `true` to indicate that the elements in the array are integers; otherwise, set to `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `elementDomElement`
  Optional. This attribute is deprecated; the `elementType` attribute takes precedence over this attribute. If `type` is `Array`, this attribute specifies whether the elements in the array are DOM elements. Set to `true` to specify that the elements are DOM elements; otherwise, set to `false`. If the `elementType` attribute is not set and `elementDomElement` is set to `true`, IntelliSense treats each element in the array as an `HTMLElement` when performing statement completion.

  `elementMayBeNull`
  Optional. If `type` is `Array`, specifies whether the elements in the array can be set to null. Set to `true` to indicate that the elements in the array can be set to null; otherwise, set to `false`. The default value is `false`. This attribute is not used by Visual Studio to provide IntelliSense information.

  `helpKeyword`
  Optional. The keyword for F1 help.

  `locid`
  Optional. The identifier for localization information about the field. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../ide/loc-javascript.md) tag.

  `value`
  Optional. Specifies code that should be evaluated for use by IntelliSense instead of the function code itself. For `<field>`, this attribute is supported for constructor functions, but is not supported for object literals. You can use this attribute is to provide type information when the field type is undefined. For example, you can use `value=’1’` to treat the field type as a number.

  `description`
  Optional. A description for the field.

## Remarks
 The `name` attribute is required when you're documenting a field in a constructor function. For all other scenarios, all attributes for the `<field>` element are optional.

 When you're documenting a constructor function, the `<field>` element must appear immediately before the field declaration. The `name` attribute must match the field name that's used in the source code. For object members, the `name` attribute can be omitted if the `<field>` element appears immediately before the object member declaration.

## Example
 The following code example shows how to use the `<field>` element.

```javascript
// Use of <field> in an object definition.
var Rectangle = {
    /// <field type='Number'>The width of the rectangle.</field>
    wid: 5,
    /// <field type='Number'>The length of the rectangle.</field>
    len: 0,
    /// <field type='Number'>Returns the area of the rectangle.</field>
    getArea: function (wid, len) {
        return len * wid;
    }
}

// Use of <field> in a constructor function.
// The name attribute is required.
function Engine() {
    /// <field name='HorsePower' type='Number'>The engine's horsepower.</field>
    this.HorsePower = 150;
}
```

## Example
 The following example shows how to use the `<field>` element with the `static` attribute set to `true`.

```javascript
function Engine() {
    /// <field name='HorsePower' static='true' type='Number'>static field desc.</field>
}

Engine.HorsePower = 140;
// IntelliSense on the field is available here.
Engine.

```

## Example
 The following example shows how to use the `<field>` element with the `static` attribute set to `false`.

```javascript
function Engine() {
    /// <field name='HorsePower' static='false' type='Number'>Non-static field desc.</field>
}

Engine.HorsePower = 140;
var eng = new Engine();
// IntelliSense on the field is available here.
eng.

```

## Example
 The following example shows how to use the `<field>` element with the `value` attribute.

```javascript
function calculator(a) {
    /// <field name='f' value='1'/>
}
new calculator().f.   // Completion list for a Number.

```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
