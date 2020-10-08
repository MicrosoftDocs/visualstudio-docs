---
title: "&lt;loc&gt; (JavaScript) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "<loc> JavaScript XML tag"
  - "loc JavaScript XML tag"
ms.assetid: 0d3349b6-4bdd-418f-bc11-73665305baae
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# &lt;loc&gt; (JavaScript)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies the location and type of the sidecar file that provides localized IntelliSense information.

## Syntax

```
<loc filename="filename"
    format="vsdoc|messagebundle" />
```

#### Parameters
 `filename`
 Optional. The root name of the sidecar file that contains localization information for the neutral culture. When Visual Studio searches for localization information, it attempts to find a culture-specific version of this file. For example, if `filename` is jquery.xml, Visual Studio searches for the correct culture-specific folder (like JA) in the same location as the .js file that contains the `<loc>` element. If it locates the culture-specific folder, it checks whether a jquery.xml file exists in it. If it cannot locate the correct file, it instead uses managed resource location rules. The default value for `filename` is the name of the current file, but with an .xml extension instead of .js.

 `format`
 Optional. The type of sidecar file used for localization. Use `messagebundle` to specify the use of message bundles defined by Open Ajax metadata. `messagebundle` is the recommended format. However, this format is not supported in Microsoft Ajax or in .winmd files. Use `vsdoc` to specify the standard .NET Framework localization format that is used by Microsoft Ajax and Windows Runtime. This attribute is optional. `vsdoc` is the default format.

## Remarks
 The `<loc>` element must appear at the top of the file in the same section as the `<reference>` element. Usage rules for the `<loc>` element are the same as the `<reference>` element. For more information, see the “References Directives” section in [JavaScript IntelliSense](../ide/javascript-intellisense.md).

 Visual Studio processes a single `<loc>` element for each .js file. If multiple `<loc>` elements are present, only a single `<loc>` element is used. Behavior for determining which `<loc>` element to use is not defined.

 When using message bundle format, use the `locid` attribute in XML documentation comments to specify the `name` attribute value.

## Example
 The following example shows how to use the `<loc>` element with messagebundle format. Add the following XML to a file named messageFilename.xml and place the file in the correct culture-specific folder, as specified in the description of the `filename` parameter.

```
<?xml version="1.0" encoding="utf-8" ?>
<messagebundle>
  <msg name="1">A class that represents a rectangle</msg>
  <msg name="2">The height of a rectangle</msg>
  <msg name="3">The width of a rectangle</msg>
</messagebundle>

```

 For the messagebundle example, add the following code to a JavaScript file in your project. The `<loc>` element must appear as the first line in the JavaScript file. The descriptions in this code will be replaced by localized descriptions, if available.

```javascript
/// <loc filename="messageFilename.xml" format="messagebundle"/>

function doSomething(a,b)
{
    /// <summary locid='1'>description</summary>
    /// <param name='a' locid='2'>parameter a description</param>
    /// <param name='b' locid='3'>parameter b description</param>
}

```

 The following example uses VSDoc format. Add the following XML to a file named scriptFilename.xml and place the file in the correct culture-specific folder.

```
<?xml version="1.0" encoding="utf-8" ?>
<doc>
  <assembly>
    <name>Lights</name>
  </assembly>
  <members>
    <member name="M:illuminate">
      <summary>Activates a light. </summary>
      <param name='a'>The light to activate. </param>
    </member>
  </members>
</doc>

```

 For the VSDoc example, add the following code to a JavaScript file in your project. The descriptions in this code will be replaced by localized descriptions, if available.

```javascript
/// <loc filename="scriptFilename.xml" format="vsdoc" />

function illuminate(a)
{
    /// <summary locid='M:illuminate'>description</summary>
    /// <param name='a' type='Number'>parameter a description</param>
}

```

## See Also
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
