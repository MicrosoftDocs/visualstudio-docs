---
title: "Project Element (MSBuild)"
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
ms.assetid: d1cda56a-dbef-4109-9201-39e962e3f653
caps.latest.revision: 27
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
# Project Element (MSBuild)
<?xml version="1.0" encoding="utf-8"?>
<developerXmlReference xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Required root element of an <token>vstecmsbuild</token> project file.</para>
  </introduction>
  <syntaxSection>
    <legacySyntax>&lt;Project InitialTargets="TargetA;TargetB"
         DefaultTargets="TargetC;TargetD"
         TreatAsLocalProperty="PropertyA;PropertyB"
         ToolsVersion=&lt;version number&gt;
         xmlns="http://schemas.microsoft.com/developer/msbuild/2003"&gt;
    &lt;Choose&gt;... &lt;/Choose&gt;
    &lt;PropertyGroup&gt;... &lt;/PropertyGroup&gt;
    &lt;ItemGroup&gt;... &lt;/ItemGroup&gt;
    &lt;Target&gt;... &lt;/Target&gt;
    &lt;UsingTask.../&gt;
    &lt;ProjectExtensions&gt;... &lt;/ProjectExtensions&gt;
    &lt;Import... /&gt;
&lt;/Project&gt;</legacySyntax>
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
                <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>The default target or targets to be the entry point of the build if no target has been specified. Multiple targets are semi-colon (;) delimited.</para>
              <para>If no default target is specified in either the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute or the <token>vstecmsbuild</token> command line, the engine executes the first target in the project file after the <legacyLink xlink:href="3bfecaf1-69fd-4008-b651-c9dafd4389d9">Import</legacyLink> elements have been evaluated.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>InitialTargets</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>The initial target or targets to be run before the targets specified in the <unmanagedCodeEntityReference>DefaultTargets</unmanagedCodeEntityReference> attribute or on the command line. Multiple targets are semi-colon (;) delimited.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>ToolsVersion</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>The version of the toolset MSBuild uses to determine the values for $(MSBuildBinPath) and $(MSBuildToolsPath).</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>TreatAsLocalProperty</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Optional attribute.</para>
              <para>Property names that won't be considered to be global. This attribute prevents specific command-line properties from overriding property values that are set in a project or targets file and all subsequent imports. Multiple properties are semi-colon (;) delimited.</para>
              <para>Normally, global properties override property values that are set in the project or targets file. If the property is listed in the <unmanagedCodeEntityReference>TreatAsLocalProperty</unmanagedCodeEntityReference> value, the global property value doesn't override property values that are set in that file and any subsequent imports. For more information, see <link xlink:href="d14f1212-ddd9-434f-b138-f840011b0fb2">How to: Build the Same Source Files with Different Options</link>.</para>
              <alert class="note">
                <para>You set global properties  at a command prompt by using the <system>/property</system> (or <system>/p</system>) switch. You can also set or modify global properties for child projects in a multi-project build by using the <unmanagedCodeEntityReference>Properties</unmanagedCodeEntityReference> attribute of the MSBuild task. For more information, see <link xlink:href="76577f6c-7669-44ad-a840-363e37a04d34">MSBuild Task</link>.</para>
              </alert>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <unmanagedCodeEntityReference>Xmlns</unmanagedCodeEntityReference>
              </para>
            </TD>
            <TD>
              <para>Required attribute.</para>
              <para>The <unmanagedCodeEntityReference>xmlns</unmanagedCodeEntityReference> attribute must have the value of "http://schemas.microsoft.com/developer/msbuild/2003".</para>
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
                <legacyLink xlink:href="7b8b025a-d944-4f5c-9018-c89fc2ef146d">Choose</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>Evaluates child elements to select one set of <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> elements and/or <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> elements to evaluate.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="3bfecaf1-69fd-4008-b651-c9dafd4389d9">Import</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>Enables a project file to import another project file. There may be zero or more <unmanagedCodeEntityReference>Import</unmanagedCodeEntityReference> elements in a project.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="aac894e3-a9f1-4bbc-a796-6ef07001f35b">ItemGroup</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>A grouping element for individual items. Items are specified by using the <legacyLink xlink:href="dcef5f91-0613-4bfc-8ee9-d7004bb6d3a9">Item</legacyLink> element. There may be zero or more <unmanagedCodeEntityReference>ItemGroup</unmanagedCodeEntityReference> elements in a project.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="f95f312f-ff92-41eb-9469-ad99e236a307">ProjectExtensions</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>Provides a way to persist non-<token>vstecmsbuild</token> information in an <token>vstecmsbuild</token> project file. There may be zero or one <unmanagedCodeEntityReference>ProjectExtensions</unmanagedCodeEntityReference> elements in a project.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4">PropertyGroup</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>A grouping element for individual properties. Properties are specified by using the <legacyLink xlink:href="69ab08ab-3e76-41dd-a01b-49aa1d2e0cac">Property</legacyLink> element. There may be zero or more <unmanagedCodeEntityReference>PropertyGroup</unmanagedCodeEntityReference> elements in a project.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="350f6fc2-86b3-45f2-a31e-ece0e6bd4dca">Target</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>Contains a set of tasks for <token>vstecmsbuild</token> to sequentially execute. Tasks are specified by using the <legacyLink xlink:href="d82e2485-e5f0-4936-a357-745bacccc299">Task</legacyLink> element. There may be zero or more <unmanagedCodeEntityReference>Target</unmanagedCodeEntityReference> elements in a project.</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <legacyLink xlink:href="20247902-9446-4a1f-8253-5c7a17e4fe43">UsingTask</legacyLink>
              </para>
            </TD>
            <TD>
              <para>Optional element.</para>
              <para>Provides a way to register tasks in <token>vstecmsbuild</token>. There may be zero or more <unmanagedCodeEntityReference>UsingTask</unmanagedCodeEntityReference> elements in a project.</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </childElement>
    <parentElement>
      <para>None.</para>
    </parentElement>
  </attributesandElements>
  <relatedTopics>
<link xlink:href="a580ba5b-2919-42d2-ae38-1af991e0205a">How To: Specify Which Target to Build First</link>
<link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>
<link xlink:href="d9a68146-1f43-4621-ac78-2c8c3f400936">MSBuild File Format</link>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
</relatedTopics>
</developerXmlReference>