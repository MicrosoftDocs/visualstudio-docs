---
title: "Create XML Documentation Comments for JavaScript IntelliSense | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "code comments, JavaScript IntelliSense"
  - "XML documentation comments, JavaScript IntelliSense"
  - "documentation comments [JavaScript]"
  - "IntelliSense [JavaScript], XML documentation comments"
ms.assetid: a27f5b50-9807-436f-a0cf-6f3137ecbaf0
caps.latest.revision: 19
author: jillre
ms.author: jillfra
manager: jillfra
---
# Create XML Documentation Comments for JavaScript IntelliSense
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

*XML documentation comments* are JavaScript comments that you add to a script to provide information about code elements such as functions, fields, and variables. In Visual Studio, these text descriptions are displayed with IntelliSense when you reference the script function.

 This topic provides a basic tutorial on using XML documentation comments. For information about using other elements, such as [\<var>](../ide/var-javascript.md) and [\<value>](../ide/value-javascript.md), and for additional code examples, see [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md). For information about providing IntelliSense information for an asynchronous callback such as a `Promise`, see [\<returns>](../ide/returns-javascript.md).

> [!NOTE]
> XML documentation comments are available only from referenced files, assemblies, and services.

### To create XML documentation comments for a JavaScript function

- In the function, add [\<summary>](../ide/summary-javascript.md), [\<param>](../ide/param-javascript.md), and [\<returns>](../ide/returns-javascript.md) elements, and precede each element with three slash marks (///).

    > [!NOTE]
    > Each element must be on a single line.

     The following example shows a JavaScript function.

    ```javascript
    function getArea(radius)
    {
        /// <summary>Determines the area of a circle that has the specified radius parameter.</summary>
        /// <param name="radius" type="Number">The radius of the circle.</param>
        /// <returns type="Number">The area.</returns>
        var areaVal;
        areaVal = Math.PI * radius * radius;
        return areaVal;
    }
    ```

- To view the XML documentation comments, type the name and the opening parenthesis of a function that is marked with XML documentation comments, as in the following example:

    ```javascript
    var areaVal = getArea(
    ```

     When you type the opening parenthesis of the function that contains the XML documentation comments, the Code Editor uses IntelliSense to display the information that is defined in XML documentation comments.

### To create XML Documentation comments for a JavaScript field

- In a constructor function or object definition, add a [\<field>](../ide/field-javascript.md) element preceded by three slash marks (///).

     The following example shows the use of the `<field>` element in a constructor function. For additional examples, see [\<field>](../ide/field-javascript.md).

    ```javascript
    function Engine() {
        /// <field name='HorsePower' type='Number'>The engine's horsepower.</field>
        this.HorsePower = 150;
    }
    ```

- To view the XML documentation comments, create an object by using the function constructor that is marked with XML documentation comments, as in the following example.

    ```javascript
    var eng = new Engine();
    ```

- On the next line, type the name of the object and a period to show IntelliSense information for the field.

    ```javascript
    eng.
    ```

### To create XML documentation comments for an overloaded function

1. In the function, add a [\<signature>](../ide/signature-javascript.md) element for each overload. In these elements, add other elements, such as `<summary>`, `<param>`, and `<returns>`, preceding each element with three slash marks (///).

     The following example shows an overloaded JavaScript function. In this example, the overloads differ by parameter type.

    ```javascript
    function calc(a) {
        /// <signature>
        /// <summary>Function summary 1.</summary>
        /// <param name="a" type="Number">A number.</param>
        /// <returns type="Number" />
        /// </signature>
        /// <signature>
        /// <summary>Function summary 2.</summary>
        /// <param name="a" type="String">A string.</param>
        /// <returns type="Number" />
        /// </signature>
        return a;
    }
    ```

2. To view the XML documentation comments, type the name and the opening parenthesis of the function that is marked with XML documentation comments, as in the following example:

    ```javascript
    calc(
    ```

### To create localized IntelliSense

1. Create an XML file that has documentation comments in the OpenAjax MessageBundle format.

    > [!IMPORTANT]
    > MessageBundle is the recommended format. This format is not supported in Microsoft Ajax or in .winmd files. For information about using the alternative `VSDoc` format, see [\<loc>](../ide/loc-javascript.md).

     The following example shows content in a sidecar file that contains the localized IntelliSense information. This is an XML file that's located in a culture-specific folder, like JA. The folder must be in the same location as the .js file that contains the `<loc>` element. The file name of the XML file must match the `filename` parameter specified in the `<loc>` element.

    ```
    <messagebundle>
      <msg name="1">A class that represents a rectangle</msg>
      <msg name="2">The length of the rectangle</msg>
      <msg name="3">The height of the rectangle</msg>
    </messagebundle>

    ```

2. In your .js file, add the following code. The `<loc>` element must be declared before any script, and follows the same usage rules as the `<reference>` element. For more information, see [JavaScript IntelliSense](../ide/javascript-intellisense.md) and [\<loc>](../ide/loc-javascript.md).

    ```javascript
    /// <loc filename="messageFilename.xml" format="messagebundle"/>

    ```

3. In your .js file, add the XML documentation elements and default descriptions. Set the `locid` attribute values to match the corresponding `name` attribute values from the sidecar file. The default descriptions will be replaced by localized IntelliSense information, if it's available.

    ```javascript
    function add(a,b)
    {
        /// <summary locid='1'>description</summary>
        /// <param name='a' locid='2'>parameter a description</param>
        /// <param name='b' locid='3'>parameter b description</param>
    }

    ```

4. To view the XML documentation comments, type the name and the opening parenthesis of the function, as in the following example:

    ```javascript
    add(
    ```

## See Also
 [JavaScript IntelliSense](../ide/javascript-intellisense.md)
 [XML Documentation Comments](../ide/xml-documentation-comments-javascript.md)
 [NIB: Walkthrough: JavaScript IntelliSense in ASP.NET](https://msdn.microsoft.com/4f6e0cc2-7f48-4dbf-abb0-7fb743a2d05b)
