---
title: "MSBuild .Targets Files"
ms.custom: na
ms.date: 10/07/2016
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
ms.assetid: f6d98eb4-d2fa-49b7-8e3c-bae1ca3cf596
caps.latest.revision: 13
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
# MSBuild .Targets Files
<?xml version="1.0" encoding="utf-8"?>
<developerReferenceWithoutSyntaxDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <token>vstecmsbuild</token> includes several .targets files that contain items, properties, targets, and tasks for common scenarios. These files are automatically imported into most <token>vsprvs</token> project files to simplify maintenance and readability.</para>
    <para>Projects typically import one or more .targets files to define their build process. For example a <token>csprcs</token> project created by <token>vsprvs</token> will import Microsoft.CSharp.targets which imports Microsoft.Common.targets. The <token>csprcs</token> project itself will define the items and properties specific to that project, but the standard build rules for a <token>csprcs</token> project are defined in the imported .targets files.</para>
    <para>The <codeInline>$(MSBuildToolsPath)</codeInline> value specifies the path of these common .targets files. If the <languageKeyword>ToolsVersion</languageKeyword> is 4.0, the files are in the following location: <codeInline>WindowsInstallationPath\Microsoft.NET\Framework\v4.0.30319\</codeInline></para>
    <alert class="note">
      <para>For information about how to create your own targets, see <link xlink:href="8060b4d2-e4a9-48cf-a437-852649ceb417">MSBuild Targets</link>. For information about how to use the <unmanagedCodeEntityReference>Import</unmanagedCodeEntityReference> element to insert a project file into another project file, see <link xlink:href="3bfecaf1-69fd-4008-b651-c9dafd4389d9">Import Element (MSBuild)</link> and <link xlink:href="163734bd-1bfd-4093-a730-7741fc21742d">How to: Use the Same Target in Multiple Project Files</link>.</para>
    </alert>
  </introduction>
  <section>
    <title>Common .Targets Files</title>
    <content>
      <table xmlns:caps="http://schemas.microsoft.com/build/caps/2013/11">
        <thead>
          <tr>
            <TD>
              <para>.Targets file</para>
            </TD>
            <TD>
              <para>Description</para>
            </TD>
          </tr>
        </thead>
        <tbody>
          <tr>
            <TD>
              <para>Microsoft.Common.targets</para>
            </TD>
            <TD>
              <para>Defines the steps in the standard build process for <token>vbprvb</token> and <token>csprcs</token> projects.</para>
              <para>Imported by the Microsoft.CSharp.targets and Microsoft.VisualBasic.targets files, which include the following statement: <codeInline>&lt;Import Project="Microsoft.Common.targets" /&gt;</codeInline></para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Microsoft.CSharp.targets</para>
            </TD>
            <TD>
              <para>Defines the steps in the standard build process for Visual C# projects.</para>
              <para>Imported by Visual C# project files (.csproj), which include the following statement: <codeInline>&lt;Import Project="$(MSBuildToolsPath)\Microsoft.CSharp.targets" /&gt;</codeInline></para>
            </TD>
          </tr>
          <tr>
            <TD>
              <para>Microsoft.VisualBasic.targets</para>
            </TD>
            <TD>
              <para>Defines the steps in the standard build process for Visual Basic projects.</para>
              <para>Imported by Visual Basic project files (.vbproj), which include the following statement: <codeInline>&lt;Import Project="$(MSBuildToolsPath)\Microsoft.VisualBasic.targets" /&gt;</codeInline></para>
            </TD>
          </tr>
        </tbody>
      </table>
    </content>
  </section>
  <relatedTopics>
    <link xlink:href="3bfecaf1-69fd-4008-b651-c9dafd4389d9">Import Element (MSBuild)</link>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link></relatedTopics>
</developerReferenceWithoutSyntaxDocument>