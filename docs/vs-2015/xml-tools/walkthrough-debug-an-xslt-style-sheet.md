---
title: "Walkthrough: Debug an XSLT Style Sheet | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-xml-tools
ms.topic: conceptual
ms.assetid: 3db9fa5a-f619-4cb6-86e7-64b364e58e5d
caps.latest.revision: 5
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: Debug an XSLT Style Sheet
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The steps in this walkthrough demonstrate how to use the XSLT debugger. Steps include viewing variables, setting breakpoints, and stepping through the code. The style sheet finds all books that cost below the average book price.

### To prepare for this walkthrough

1. Close any open solutions.

2. Copy the two sample files to your local computer.

## Start Debugging

#### To start debugging

1. From the **File** menu, point to **Open**, and click **File**.

2. Locate the belowAvg.xsl file and click **Open**.

    The style sheet is opened in the XML Editor.

3. Click the browse button (**...**) on the **Input** field of the document properties window.

4. Locate the books.xml file and click **Open**.

    This sets the source document file that is used for the XSLT transformation.

5. Right-click the `xsl:if` start tag, point to **Breakpoint**, and click **Insert Breakpoint**.

6. Click the **Debug XSL** button on the XML Editor toolbar.

   This starts the debugging process and opens several new windows that are used by the debugger.

   There are two windows that display the input document and styles sheet. The debugger uses these windows to show the current execution state. The debugger is positioned on the `xsl:if` element of the style sheet and on the first book node in the books.xml file.

   The Locals window displays all the local variables and their current values. This includes variables defined in the style sheet and also variables that the debugger uses to track the nodes that are currently in context.

   The **XSL Output** window displays the output of the XSL transformation. This window is separate from the **Visual Studio Output** window.

## Watch Window

#### To use the Watch window

1. From the **Debug** menu, point to **Windows**, point to **Watch**, and click **Watch 1**.

     This makes the Watch 1 window visible.

2. Type `$bookAverage` in the **Name** field and press ENTER.

     The value of the `$bookAverage` variable is displayed in the window.

3. Type `self::node()` in the **Name** field and press ENTER.

     `self::node()` is an XPath expression that evaluates to the current context node. The value of the `self::node()` XPath expression is the first book node. This changes as we progress through the transformation.

4. Expand the `self::node()` node, and then expand the `price` node.

     This allows you to see the value of the book price and you can easily compare it to the `$bookAverage` value. Because the book price is below the average, the `xsl:if` condition should succeed.

## Step Through the Code
 The debugger enables you to execute code one line at a time.

#### To step through the code

1. Press **F5** to continue.

     Because the first book node satisfied the `xsl:if` condition, the book node is added to the XSL output window. The debugger continues to execute until it is positioned again on the `xsl:if` element in the style sheet. The debugger is now positioned on the second book node in the books.xml file.

     In the Watch1 window the `self::node()` value changes to the second book node. By examining the value of the price element, you can determine that the price is above the average, thus the `xsl:if` condition should fail.

2. Press **F5** to continue.

     Because the second book node does not meet the `xsl:if` condition, the book node is not added to the XSL output window. The debugger continues to execute until it is positioned again on the `xsl:if` element in the style sheet. The debugger is now positioned on the third `book` node in the books.xml file.

     In the Watch1 window the `self::node()` value changes to the third book node. By examining the value of the `price` element, you can determine that the price is below the average, thus the `xsl:if` condition should succeed.

3. Press **F5** to continue.

     Because the `xsl:if` condition was satisfied, the third book is added to the XSL Output window. All books in the XML document have been processed and the debugger stops.

## Sample Files
 The following two files are used by the walkthrough.

### belowAvg.xsl

```
<?xml version='1.0'?>
<xsl:stylesheet version="1.0"
      xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
  <xsl:output method="xml" encoding="utf-8"/>
  <xsl:template match="/">
    <xsl:variable name="bookCount" select="count(/bookstore/book)"/>
    <xsl:variable name="bookTotal" select="sum(/bookstore/book/price)"/>
    <xsl:variable name="bookAverage" select="$bookTotal div $bookCount"/>
    <books>
      <!--Books That Cost Below Average-->
      <xsl:for-each select="/bookstore/book">
        <xsl:if test="price < $bookAverage">
          <xsl:copy-of select="."/>
        </xsl:if>
      </xsl:for-each>
    </books>
  </xsl:template>
</xsl:stylesheet>
```

### books.xml

```
<?xml version='1.0'?>
<!-- This file represents a fragment of a book store inventory database -->
<bookstore>
  <book genre="autobiography" publicationdate="1981" ISBN="1-861003-11-0">
    <title>The Autobiography of Benjamin Franklin</title>
    <author>
      <first-name>Benjamin</first-name>
      <last-name>Franklin</last-name>
    </author>
    <price>8.99</price>
  </book>
  <book genre="novel" publicationdate="1967" ISBN="0-201-63361-2">
    <title>The Confidence Man</title>
    <author>
      <first-name>Herman</first-name>
      <last-name>Melville</last-name>
    </author>
    <price>11.99</price>
  </book>
  <book genre="philosophy" publicationdate="1991" ISBN="1-861001-57-6">
    <title>The Gorgias</title>
    <author>
      <name>Plato</name>
    </author>
    <price>9.99</price>
  </book>
</bookstore>
```

## See Also
 [Debugging XSLT](../xml-tools/debugging-xslt.md)
