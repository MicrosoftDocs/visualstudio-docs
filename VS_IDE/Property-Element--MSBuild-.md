---
title: "Property Element (MSBuild)"
ms.custom: na
ms.date: 10/10/2016
ms.devlang: 
  - VB
  - CSharp
  - C++
  - jsharp
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 69ab08ab-3e76-41dd-a01b-49aa1d2e0cac
caps.latest.revision: 15
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Property Element (MSBuild)
<?xml version="1.0" encoding="utf-8"?>
<developerXmlReference xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Contains a user defined property name and value. Every property used in an <token>vstecmsbuild</token> project must be specified as a child of a <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> element.</para>
  </introduction>
  <schemaHierarchy>
    <link xlink:href="">&lt;Project&gt;</link>
    <link xlink:href="">    &lt;PropertyGroup&gt;</link>
  </schemaHierarchy>
  <syntaxSection>
    <legacySyntax>&lt;<parameterReference>Property </parameterReference>Condition="'String A' == 'String B'"&gt;
    Property Value
&lt;/<parameterReference>Property</parameterReference>&gt;</legacySyntax>
  </syntaxSection>
  <attributesandElements>
    <para>The following sections describe attributes, child elements, and parent elements.</para>
    <attributes>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Attribute</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>Condition</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>Condition to be evaluated. For more information, see <link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </attributes>
    <childElement>
      <para>None.</para>
    </childElement>
    <parentElement>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Element</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4">PropertyGroup</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Grouping element for properties.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </parentElement>
  </attributesandElements>
  <textValue>
    <content>
      <para>A text value is optional.</para>
      <para>This text specifies the property value and may contain XML.</para>
    </content>
  </textValue>
  <remarks>
    <content>
      <para>Property names are limited to ASCII chars only. Property values are referenced in the project by placing the property name between "<codeInline>$(</codeInline>" and "<codeInline>)</codeInline>". For example, <codeInline>$(builddir)\classes</codeInline> would resolve to "build\classes", if the <codeInline>builddir</codeInline> property had the value <codeInline>build</codeInline>. For more information on properties, see MSBuild Properties.</para>
    </content>
  </remarks>
  <codeExample>
    <description>
      <content>
        <para>The following code sets the <codeInline>Optimization</codeInline> property to <codeInline>false</codeInline> and the <codeInline>DefaultVersion</codeInline> property to <codeInline>1.0</codeInline> if the <codeInline>Version</codeInline> property is empty.</para>
      </content>
    </description>
    <code>&lt;PropertyGroup&gt;
    &lt;Optimization&gt;false&lt;/Optimization&gt;
    &lt;DefaultVersion Condition="'$(Version)' == ''" &gt;1.0&lt;/DefaultVersion&gt;
&lt;/PropertyGroup&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>

<link xlink:href="d9a68146-1f43-4621-ac78-2c8c3f400936">MSBuild File Format</link>
</relatedTopics>
</developerXmlReference>