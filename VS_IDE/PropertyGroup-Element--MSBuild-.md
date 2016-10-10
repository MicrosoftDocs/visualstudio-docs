---
title: "PropertyGroup Element (MSBuild)"
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
ms.assetid: ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4
caps.latest.revision: 18
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
# PropertyGroup Element (MSBuild)
<?xml version="1.0" encoding="utf-8"?>
<developerXmlReference xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Contains a set of user-defined <legacyLink xlink:href="69ab08ab-3e76-41dd-a01b-49aa1d2e0cac">Property</legacyLink> elements. Every <unmanagedCodeEntityReference>Property</unmanagedCodeEntityReference> element used in an <token>vstecmsbuild</token> project must be a child of a <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> element.</para>
  </introduction>
  <schemaHierarchy>
    <link xlink:href="">&lt;Project&gt;</link>
    <link xlink:href="">    &lt;PropertyGroup&gt;</link>
  </schemaHierarchy>
  <syntaxSection>
    <legacySyntax>&lt;PropertyGroup Condition="'String A' == 'String B'"&gt;
    &lt;<parameterReference>Property1</parameterReference>&gt;...&lt;/<parameterReference>Property1</parameterReference>&gt;
    &lt;<parameterReference>Property2</parameterReference>&gt;...&lt;/<parameterReference>Property2</parameterReference>&gt;
&lt;/PropertyGroup&gt;</legacySyntax>
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
              <para>Condition</para>
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
                <legacyLink xlink:href="69ab08ab-3e76-41dd-a01b-49aa1d2e0cac">Property</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>A user defined property name, which contains the property value. There may be zero or more <placeholder>Property</placeholder> elements in a <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> element.</para>
            </TD>
          </tr>
        </tbody>
      </table>
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
                <legacyLink xlink:href="d1cda56a-dbef-4109-9201-39e962e3f653">Project</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Required root element of an <token>vstecmsbuild</token> project file.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </parentElement>
  </attributesandElements>
  <codeExample>
    <description>
      <content>
        <para>The following code example shows how to set properties based on a condition. In this example, if the value of the <codeInline>CompileConfig</codeInline> property is <codeInline>DEBUG</codeInline>, the <codeInline>Optimization</codeInline>, <codeInline>Obfuscate</codeInline>, and <codeInline>OutputPath</codeInline> properties inside of the <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> element are set.</para>
      </content>
    </description>
    <code>&lt;PropertyGroup Condition="'$(CompileConfig)' == 'DEBUG'" &gt;
    &lt;Optimization&gt;false&lt;/Optimization&gt;
    &lt;Obfuscate&gt;false&lt;/Obfuscate&gt;
    &lt;OutputPath&gt;$(OutputPath)\debug&lt;/OutputPath&gt;
&lt;/PropertyGroup&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
<link xlink:href="d9a68146-1f43-4621-ac78-2c8c3f400936">MSBuild Project File Schema Reference</link>
<link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>
</relatedTopics>
</developerXmlReference>