---
title: "Walkthrough: Using XSLT Hierarchy"
ms.date: 11/04/2016
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
---
# Walkthrough: Use XSLT hierarchy

The XSLT Hierarchy tool simplifies many XML development tasks. An XSLT style sheet often uses `includes` and `imports` instructions. Compilation starts from the principal style sheet, but when you see an error as a result of compiling an XSLT style sheet, the error may come from a different source than the principal style sheet. Fixing the error or editing the style sheet may require access to included or imported style sheets. Stepping through the style sheet in the debugger may open included and imported style sheets, and you may want to add a breakpoint at some point in one or more of the included style sheets.

Another scenario where the XSLT Hierarchy tool can be useful is putting breakpoints on the built-in template rules. Template rules are special templates generated for each mode of the style sheet and called by `xsl:apply-templates` when no other template matches the node. To implement debugging in built-in templates rules, XSLT debugger generates the file with the rules in the temporary folder and compiles them together with the principal style sheet. Without stepping into the code from some `xsl:apply-template`, it can be difficult to find style sheets that have been included in the principal style sheet or to find and open the style sheet with the built-in template rules.

The example in this topic demonstrates debugging in a referenced style sheet.

## To debug in a referenced style sheet

1. Open an XML document in Visual Studio. This example uses the following  document:

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <?xml-stylesheet type="text/xsl" href="xslinclude.xsl"?>
    <COLLECTION>
      <BOOK>
        <TITLE>Lover Birds</TITLE>
        <AUTHOR>Cynthia Randall</AUTHOR>
        <PUBLISHER>Lucerne Publishing</PUBLISHER>
      </BOOK>
      <BOOK>
        <TITLE>The Sundered Grail</TITLE>
        <AUTHOR>Eva Corets</AUTHOR>
        <PUBLISHER>Lucerne Publishing</PUBLISHER>
      </BOOK>
      <BOOK>
        <TITLE>Splish Splash</TITLE>
        <AUTHOR>Paula Thurman</AUTHOR>
        <PUBLISHER>Scootney</PUBLISHER>
      </BOOK>
    </COLLECTION>
    ```

1. Add the following *xslincludefile.xsl*:

    ```xml
    <?xml version='1.0'?>
    <xsl:stylesheet version="1.0"
          xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
          xml:space="preserve">

    <xsl:template match="TITLE">
       Title - <xsl:value-of select="."/><BR/>
    </xsl:template>

    <xsl:template match="AUTHOR">
       Author - <xsl:value-of select="."/><BR/>
    </xsl:template>

    <xsl:template match="PUBLISHER">
       Publisher - <xsl:value-of select="."/><BR/><!-- removed second <BR/> -->
    </xsl:template>

    </xsl:stylesheet>
    ```

3. Add the following *xslinclude.xsl* file:

    ```xml
    <?xml version='1.0'?>
    <xsl:stylesheet version="1.0"
          xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

      <xsl:output method="xml" omit-xml-declaration="yes"/>

      <xsl:template match="/">
        <xsl:for-each select="COLLECTION/BOOK">
          <xsl:apply-templates select="TITLE"/>
          <xsl:apply-templates select="AUTHOR"/>
          <xsl:apply-templates select="PUBLISHER"/>
          <BR/>
          <!-- add this -->
        </xsl:for-each>
      </xsl:template>

      <!-- The following template rule will not be called,
      because the related template in the including stylesheet
      is called. If we move this template so that
      it follows the xsl:include instruction, this one
      will be called instead.-->
      <xsl:template match="TITLE">
        <DIV STYLE="color:blue">
          Title: <xsl:value-of select="."/>
        </DIV>
      </xsl:template>

      <xsl:include href="xslincludefile.xsl" />
    </xsl:stylesheet>
    ```

4. Add a breakpoint at the instruction `<xsl:include href="xslincludefile.xsl" />`.

5. Start debugging.

6. When the debugger stops at the instruction `<xsl:include href="xslincludefile.xsl" />`, press the **Step Into** button. The debugging can be continued in the referenced style sheet. The hierarchy is visible and the designer displays the right path.

## See also

- [XSLT profiler](../xml-tools/xslt-profiler.md)