---
title: "MSBuild Project File Schema Reference"
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
ms.assetid: d9a68146-1f43-4621-ac78-2c8c3f400936
caps.latest.revision: 16
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
# MSBuild Project File Schema Reference
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <summary>
    <para>Provides a table of all the <token>vstecmsbuild</token> XML Schema elements with their available attributes and child elements.</para>
  </summary>
  <introduction>
    <para>
      <token>vstecmsbuild</token> uses project files to instruct the build engine what to build and how to build it. <token>vstecmsbuild</token> project files are XML files that adhere to the <token>vstecmsbuild</token> XML schema. This section documents the XML schema definition (.xsd) file for <token>vstecmsbuild</token>.</para>
  </introduction>
  <section>
    <title>MSBuild XML Schema Elements</title>
    <content>
      <para>The following table lists all of the <token>vstecmsbuild</token> XML schema elements along with their child elements and attributes.</para>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>Element</para>
            </TD>
            <TD>
              <para>Child Elements</para>
            </TD>
            <TD>
              <para>Attributes</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>
                <link xlink:href="7b8b025a-d944-4f5c-9018-c89fc2ef146d">Choose Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>Otherwise</para>
              <para>When</para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="3bfecaf1-69fd-4008-b651-c9dafd4389d9">Import Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
            <TD>
              <para>Condition</para>
              <para>Project</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="dac3fa2d-6678-4017-af35-93686f53f302">ImportGroup Element [MSBuild]</link>
              </para>
            </TD>
            <TD>
              <para>Import</para>
            </TD>
            <TD>
              <para>Condition</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="dcef5f91-0613-4bfc-8ee9-d7004bb6d3a9">Item Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>
                <placeholder>ItemMetaData</placeholder>
              </para>
            </TD>
            <TD>
              <para>Condition</para>
              <para>Exclude</para>
              <para>Include</para>
              <para>Remove</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="4e9fb04b-5148-4ae5-a394-42861dd62371">ItemDefinitionGroup Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>
                <placeholder>Item</placeholder>
              </para>
            </TD>
            <TD>
              <para>Condition</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="aac894e3-a9f1-4bbc-a796-6ef07001f35b">ItemGroup Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>
                <placeholder>Item</placeholder>
              </para>
            </TD>
            <TD>
              <para>Condition</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="e3db5122-202d-43a9-b2f4-3e0ec4ed3d08">ItemMetaData Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>
                <placeholder>Item</placeholder>
              </para>
            </TD>
            <TD>
              <para>Condition </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="765767d3-ecb7-4cd9-ba1e-d9468964dddc">OnError Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
            <TD>
              <para>Condition</para>
              <para>ExecuteTargets</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="de3997e9-1595-4263-a886-95530b56a319">Otherwise Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>Choose</para>
              <para>ItemGroup</para>
              <para>PropertyGroup</para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="34bc7cd1-efd3-4b57-b691-4584eeb6a0e9">Output Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
            <TD>
              <para>Condition</para>
              <para>ItemName</para>
              <para>PropertyName</para>
              <para>TaskParameter</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="b273afff-b500-4e97-8cfd-31f39fa64a51">Parameter Element [MSBuild]</link>
              </para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
            <TD>
              <para>Output</para>
              <para>ParameterType</para>
              <para>Required</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="c3275e69-a427-4889-bc1d-51bff2c285fa">ParameterGroup Element [MSBuild]</link>
              </para>
            </TD>
            <TD>
              <para>
                <placeholder>Parameter</placeholder>
              </para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="d1cda56a-dbef-4109-9201-39e962e3f653">Project Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>Choose</para>
              <para>Import</para>
              <para>ItemGroup</para>
              <para>ProjectExtensions</para>
              <para>PropertyGroup</para>
              <para>Target</para>
              <para>UsingTask</para>
            </TD>
            <TD>
              <para>DefaultTargets</para>
              <para>InitialTargets</para>
              <para>ToolsVersion</para>
              <para>TreatAsLocalProperty</para>
              <para>xmlns</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="f95f312f-ff92-41eb-9469-ad99e236a307">ProjectExtensions Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="69ab08ab-3e76-41dd-a01b-49aa1d2e0cac">Property Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>--</para>
            </TD>
            <TD>
              <para>Condition</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="ff1e6c68-b9a1-4263-a1ce-dc3b829a64d4">PropertyGroup Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>
                <placeholder>Property</placeholder>
              </para>
            </TD>
            <TD>
              <para>Condition</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="350f6fc2-86b3-45f2-a31e-ece0e6bd4dca">Target Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>OnError</para>
              <para>
                <placeholder>Task</placeholder>
              </para>
            </TD>
            <TD>
              <para>AfterTargets</para>
              <para>BeforeTargets</para>
              <para>Condition</para>
              <para>DependsOnTargets</para>
              <para>Inputs</para>
              <para>KeepDuplicateOutputs</para>
              <para>Name</para>
              <para>Outputs</para>
              <para>Returns</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="d82e2485-e5f0-4936-a357-745bacccc299">Task Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>Output</para>
            </TD>
            <TD>
              <para>Condition</para>
              <para>ContinueOnError</para>
              <para>
                <placeholder>Parameter</placeholder>
              </para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="49d8741b-f1ea-4470-94fd-a1ac27341a6a">TaskBody Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>
                <placeholder>Data</placeholder>
              </para>
            </TD>
            <TD>
              <para>Evaluate</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="20247902-9446-4a1f-8253-5c7a17e4fe43">UsingTask Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>ParameterGroup</para>
              <para>TaskBody</para>
              <para />
            </TD>
            <TD>
              <para>AssemblyFile</para>
              <para>AssemblyName</para>
              <para>Condition</para>
              <para>TaskFactory</para>
              <para>TaskName</para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>
                <link xlink:href="eb27de6f-4e71-4e87-87e2-d93f7bf5899c">When Element (MSBuild)</link>
              </para>
            </TD>
            <TD>
              <para>Choose</para>
              <para>ItemGroup</para>
              <para>PropertyGroup</para>
            </TD>
            <TD>
              <para>Condition</para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <relatedTopics>
    <link xlink:href="b3144b27-a426-4259-b8ae-5f7991b202b6">MSBuild Task Reference</link>
<link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link></relatedTopics>
</developerConceptualDocument>