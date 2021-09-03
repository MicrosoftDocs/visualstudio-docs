---
title: 'Walkthrough: Using XSLT IntelliSense'
description: Learn how to use XSLT IntelliSense to auto-complete the values of some attributes by following the steps in this walkthrough.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.assetid: 079d95ac-2eaf-4ae1-9cd3-2c81a961a942
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-xml-tools
ms.workload:
- multiple
---
# Walkthrough: Using XSLT IntelliSense

This walkthrough demonstrates how to use XSLT IntelliSense to auto-complete value of some attributes.

## To use IntelliSense in the name attribute of xsl:with-param and xsl:call-template elements

1. Create a new XSLT file and copy in the following code:

    ```xml
    <xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
    <!-- These 2 elements effectively assign
         $messages = resources/en.xml/<messages>,
         then $messages is used in the "localized-message" template.  -->
    <xsl:param name="lang">en</xsl:param>
    <xsl:variable name="messages"
          select="document(concat('resources/', $lang, '.xml'))/messages"/>

    <xsl:template name="msg23" match="msg23">
    </xsl:template>

    <xsl:template name="localized-message">
      <xsl:param name="msgcode"/>
      <!-- Show message string. -->
      <xsl:message terminate="yes">
        <xsl:value-of select="$messages/message[@name=$msgcode]"/>
      </xsl:message>
    </xsl:template>
    </xsl:stylesheet>
    ```

2. Insert your cursor after `<xsl:template name="msg23" match="msg23">` and press **Enter**. Then start typing the following `xsl:call-template` element:

    ```xml
    <xsl:call-template name="localized-message">
    </xsl:call-template>
    ```

     The list of template names appears in the `name=""` attribute of the `xsl:call-template` element as you type.

3. Insert your cursor after `<xsl:call-template name="localized-message">` and press **Enter**. Then start typing the following `xsl:with-param` element:

    ```xml
    <xsl:with-param name="msgcode">msg23</xsl:with-param>
    ```

     The list of parameter names appears in the `name=""` attribute of the `xsl:with-param` element.

## To use IntelliSense in the mode attribute of an xsl:apply-templates element

1. Create a new XSLT file and copy in the following code:

    ```xml
    <xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" version="1.0">
      <xsl:template match="/">
        <HTML>
          <BODY>
            <TABLE>
              <xsl:apply-templates select="customers/customer">
                <xsl:sort select="state"/>
                <xsl:sort select="name"/>
              </xsl:apply-templates>
            </TABLE>
          </BODY>
        </HTML>
      </xsl:template>
      <xsl:template match="customer">
        <TR>
          <xsl:apply-templates select="name" />
          <xsl:apply-templates select="address" />
          <xsl:apply-templates select="phone" />
        </TR>
      </xsl:template>
      <xsl:template match="name">
        <TD STYLE="font-size:14pt font-family:serif">
          <xsl:apply-templates />
        </TD>
      </xsl:template>
      <xsl:template match="address">
        <TD>
          <xsl:apply-templates />
        </TD>
      </xsl:template>
      <xsl:template match="phone">
        <TD>
          <xsl:apply-templates />
        </TD>
      </xsl:template>
      <xsl:template match="phone" mode="accountNumber">
        <xsl:param name="Area_Code"/>
        <TD STYLE="font-style:italic">
          1-<xsl:value-of select="."/>-001
        </TD>
      </xsl:template>
    </xsl:stylesheet>
    ```

2. Insert your cursor  after `<xsl:apply-templates select="phone" />` and press **Enter**. Then start typing the following `xsl: apply-templates` element:

    ```xml
    <xsl:apply-templates select="phone"  mode="accountNumber">
    ```

     The list of template modes appears in the `mode=""` attribute of the `xsl:apply-templates` element.

## To use IntelliSense in the stylesheet-prefix and result-prefix attributes of an xsl:namespace-alias element

1. Create a new XSLT file and copy in the following code:

    ```xml
    <xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:alt="http://www.w3.org/1999/XSL/Transform-alternate"
    version="1.0">
      <xsl:param name="browser" select="'InternetExplorer'"/>
      <xsl:template match="/">
        <alt:stylesheet>
          <xsl:choose>
            <xsl:when test="$browser='InternetExplorer'">
              <alt:import href="IERoutines.xsl"/>
              <alt:template match="/">
                <div>
                  <alt:call-template name="showTable"/>
                </div>
              </alt:template>
            </xsl:when>
            <xsl:otherwise>
              <alt:import href="OtherBrowserRoutines.xsl"/>
              <alt:template match="/">
                <div>
                  <alt:call-template name="showTable"/>
                </div>
              </alt:template>
            </xsl:otherwise>
          </xsl:choose>
        </alt:stylesheet>
      </xsl:template>
    </xsl:stylesheet>
    ```

2. Insert your cursor after `<xsl:stylesheet xmlns:xsl="http://www.w3.org/1999/XSL/Transform" xmlns:alt="http://www.w3.org/1999/XSL/Transform-alternate" version="1.0">` and press **Enter**. Then start typing the following `xsl:namespace-alias` element:

    ```xml
    <xsl:namespace-alias stylesheet-prefix="alt" result-prefix="xsl"/>
    ```

     Notice how the list of prefixes appeared in the `stylesheet-prefix` and `result-prefix` attributes of the `xsl:namespace-alias` element.

## See also

- [XML editor IntelliSense features](../xml-tools/xml-editor-intellisense-features.md)
