---
title: "&lt;signature&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "<signature> JavaScript XML tag"
  - "signature JavaScript XML tag"
ms.assetid: 319138e7-cfbe-4b37-9643-2ddb7f9c63d4
caps.latest.revision: 16
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;signature&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Groups a set of related elements for a function or method to provide documentation for overloaded functions.

## Syntax

```
<signature externalid="id" externalFile="filename"
    helpKeyword="keyword" locid="descriptionID">
</signature>
```

#### Parameters
 `externalid`
 Optional. If the `format` attribute for the [\<loc>](../ide/loc-javascript.md) element is `vsdoc`, this attribute specifies the member ID used to locate the XML code that's associated with the signature. Unlike the `locid` attribute, this attribute specifies that all elements in the member that has this ID should be loaded. Any associated description information present in the XML code will also be merged with the elements specified in the signature. This enables you to specify additional elements, such as `<capability>`, in the sidecar file without specifying them in the source file. `externalid` is an optional attribute.

 `externalFile`
 Optional. Specifies the name of the file in which to find the `externalid`. This attribute is ignored if no `externalid` is present. This is an optional attribute. The default value is the name of the current file but with a file extension of .xml instead of .js. By default, managed resource lookup rules for localization are used to locate the file.

 `helpKeyword`
 Optional. The keyword for F1 help.

 `locid`
 Optional. The identifier for localization information about the field. The identifier is either a member ID or it corresponds to the `name` attribute value in a message bundle defined by OpenAjax metadata. The identifier type depends on the format specified in the [\<loc>](../ide/loc-javascript.md) tag.

## Remarks
 Use one `<signature>` element for each overloaded function description in the .js file, or use one `<signature>` element for each external member ID specified.

 The `<signature>` element must be placed in the function body before any statements. When using [\<summary>](../ide/summary-javascript.md), [\<param>](../ide/param-javascript.md), or [\<returns>](../ide/returns-javascript.md) elements with the `<signature>` element, place the other elements inside the `<signature>` block.

## Example
 The following code example shows how to use the `<signature>` element.

```javascript
// Use of <signature> with externalid.
// Requires use of the <loc> tag to identify the external functions.
function illuminate(light) {
    /// <signature externalid='M:Windows.Devices.Light.Illuminate()' />
    /// <signature externalid='M:Windows.Devices.Light.Illuminate(System.Int32)'>
    ///   <param name='light' type='Number' />
    /// </signature>
}

// Use of <signature> for overloads implemented in JavaScript.
function add(a, b) {
    /// <signature>
    /// <summary>function summary 1</summary>
    /// <param name="a" type="Number">The first number</param>
    /// <param name="b" type="Number">The second number</param>
    /// <returns type="Number" />
    /// </signature>
    /// <signature>
    /// <summary>function summary 2 – differ by number of params</summary>
    /// <param name="a" type="Number">Only 1 parameter</param>
    /// <returns type="Number" />
    /// </signature>
    /// <signature>
    /// <summary>function summary 3 – differ by parameter type</summary>
    /// <param name="a" type="Number">Number parameter</param>
    /// <param name="b" type="String">String parameter</param>
    /// <returns type="Number" />
    /// </signature>
    /// <signature>
    /// <summary>function summary 4 – differ by return type</summary>
    /// <param name="a" type="Number">The first number</param>
    /// <param name="b" type="Number">The second number</param>
    /// <returns type="String" />
    /// </signature>

    return a + b;
}
```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
