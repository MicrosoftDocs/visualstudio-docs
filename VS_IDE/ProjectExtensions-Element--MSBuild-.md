---
title: "ProjectExtensions Element (MSBuild)"
ms.custom: na
ms.date: 10/03/2016
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
ms.assetid: f95f312f-ff92-41eb-9469-ad99e236a307
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
# ProjectExtensions Element (MSBuild)
<?xml version="1.0" encoding="utf-8"?>
<developerXmlReference xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Allows <token>vstecmsbuild</token> project files to contain non-<token>vstecmsbuild</token> information. Anything inside of a <unmanagedCodeEntityReference>ProjectExtensions</unmanagedCodeEntityReference> element will be ignored by <token>vstecmsbuild</token>.</para>
  </introduction>
  <schemaHierarchy>
    <link xlink:href="">&lt;Project&gt;</link>
    <link xlink:href="">    &lt;ProjectExtensions&gt;</link>
  </schemaHierarchy>
  <syntaxSection>
    <legacySyntax>&lt;ProjectExtensions&gt;
    Non-MSBuild information to include in file.
&lt;/ProjectExtensions&gt;</legacySyntax>
  </syntaxSection>
  <attributesandElements>
    <para>The following sections describe attributes, child elements, and parent elements.</para>
    <attributes>
      <para>None</para>
    </attributes>
    <childElement>
      <para>None</para>
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
  <remarks>
    <content>
      <para>Only one <unmanagedCodeEntityReference>ProjectExtensions</unmanagedCodeEntityReference> element may be used in an <token>vstecmsbuild</token> project.</para>
    </content>
  </remarks>
  <codeExample>
    <description>
      <content>
        <para>The following code example shows information from the integrated development environment being stored in a <unmanagedCodeEntityReference>ProjectExtensions</unmanagedCodeEntityReference> element.</para>
      </content>
    </description>
    <code>&lt;ProjectExtensions&gt;
    &lt;VSIDE&gt;
        &lt;External&gt;
            &lt;!--
            Raw XML passed to the IDE by an external source
            --&gt;
        &lt;/External&gt;
    &lt;/VSIDE&gt;
&lt;/ProjectExtensions&gt;</code>
    <comments>
      <content />
    </comments>
  </codeExample>
  <relatedTopics>
<link xlink:href="d9a68146-1f43-4621-ac78-2c8c3f400936">MSBuild Project File Schema Reference</link>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
</relatedTopics>
</developerXmlReference>