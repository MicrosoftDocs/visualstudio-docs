---
title: "MSBuild Reference"
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
ms.assetid: 093395e1-70da-4f74-b34d-046c5e2b32e8
caps.latest.revision: 20
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
# MSBuild Reference
<?xml version="1.0" encoding="utf-8"?>
<developerOrientationDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <token>vstecmsbuild</token> is the build system for <token>vsprvs</token>. The following links lead to topics that contain <token>vstecmsbuild</token> reference information.</para>
  </introduction>
  <inThisSection>
    <content>
      <definitionTable>
        <definedTerm>
          <link xlink:href="d9a68146-1f43-4621-ac78-2c8c3f400936">MSBuild Project File Schema Reference</link>
        </definedTerm>
        <definition>
          <para>Describes the XML elements that make up the <token>vstecmsbuild</token> file format.</para>
        </definition>
        <definedTerm>
          <link xlink:href="b3144b27-a426-4259-b8ae-5f7991b202b6">MSBuild Task Reference</link>
        </definedTerm>
        <definition>
          <para>Describes some of the typical tasks that are included with <token>vstecmsbuild</token>.</para>
        </definition>
        <definedTerm>
          <link xlink:href="9d7aa308-b667-48ed-b4c9-a61e49eb0a85">MSBuild Conditions</link>
        </definedTerm>
        <definition>
          <para>Describes the conditions that are available in <token>vstecmsbuild</token> files.</para>
        </definition>
        <definedTerm>
          <link xlink:href="dd54258e-f4fb-448f-9da4-d1817e0cbaf2">MSBuild Conditional Constructs</link>
        </definedTerm>
        <definition>
          <para>Describes how to use the <unmanagedCodeEntityReference>Choose</unmanagedCodeEntityReference>, <unmanagedCodeEntityReference>When</unmanagedCodeEntityReference>, and <unmanagedCodeEntityReference>Otherwise</unmanagedCodeEntityReference> elements.</para>
        </definition>
        <definedTerm>
          <link xlink:href="99333e61-83c9-4804-84e3-eda297c2478d">MSBuild Reserved Properties</link>
        </definedTerm>
        <definition>
          <para>Describes the <token>vstecmsbuild</token> reserved properties.</para>
        </definition>
        <definedTerm>
          <link xlink:href="9857505d-ae15-42f1-936d-6cd7fb9dd276">Common MSBuild Project Properties</link>
        </definedTerm>
        <definition>
          <para>Describes project properties that are common to all project types, and also properties that are often used by particular project types.</para>
        </definition>
        <definedTerm>
          <link xlink:href="1eba3721-cc12-4b80-9987-84923ede5e2e">Common MSBuild Project Items</link>
        </definedTerm>
        <definition>
          <para>Describes project items that are common to all project types, and also items that are often used by particular project types.</para>
        </definition>
        <definedTerm>
          <link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>
        </definedTerm>
        <definition>
          <para>Describes the arguments and switches that can be used with <token>vstecmsbuild</token>.exe.</para>
        </definition>
        <definedTerm>
          <link xlink:href="f6d98eb4-d2fa-49b7-8e3c-bae1ca3cf596">MSBuild .Targets Files</link>
        </definedTerm>
        <definition>
          <para>Describes the .Targets file that is included in <token>vstecmsbuild</token>.</para>
        </definition>
        <definedTerm>
          <link xlink:href="b5e791b5-c68f-4978-ad8a-9247d03bb6c0">MSBuild Well-known Item Metadata</link>
        </definedTerm>
        <definition>
          <para>Lists the metadata that is created together with every item.</para>
        </definition>
        <definedTerm>
          <link xlink:href="9f53987b-20ee-470a-ab62-fce997bb5e15">MSBuild Response Files</link>
        </definedTerm>
        <definition>
          <para>Explains the .rsp files that contain command-line switches.</para>
        </definition>
        <definedTerm>
          <link xlink:href="3206dc09-daa4-43c4-8073-731a82e36a89">Additional Resources for MSBuild</link>
        </definedTerm>
        <definition>
          <para>Provides links to <token>vstecmsbuild</token> Web sites and newsgroups.</para>
        </definition>
        <definedTerm>
          <link xlink:href="94b12890-365d-479a-b239-71109fbcb462">Windows Presentation Foundation (WPF) MSBuild Reference</link>
        </definedTerm>
        <definition>
          <para>Contains an <token>vstecmsbuild</token> targets and task reference for Windows Presentation Foundation (WPF).</para>
        </definition>
        <definedTerm>
          <link xlink:href="5b5172c3-41e4-4f38-a16f-2aeac831a5fc">Special Characters to Escape</link>
        </definedTerm>
        <definition>
          <para>Lists the characters that may have to be "escaped" to be interpreted correctly. An escape sequence is a series of characters that signifies that what follows is an alternative interpretation.</para>
        </definition>
      </definitionTable>
    </content>
  </inThisSection>
  <relatedSections>
    <content>
      <definitionTable>
        <definedTerm>
         "MSBuild Overview""
        </definedTerm>
        <definition>
          <para>Introduces <token>vstecmsbuild</token> and provides links to topics that explain how to use it to build projects.</para>
        </definition>
        <definedTerm>
          <codeEntityReference autoUpgrade="true" qualifyHint="false">N:Microsoft.Build.Conversion</codeEntityReference>
        </definedTerm>
        <definition>
          <para>Contains the Conversion namespace reference</para>
        </definition>
        <definedTerm>
          <codeEntityReference autoUpgrade="true" qualifyHint="false">N:Microsoft.Build.Evaluation</codeEntityReference>
        </definedTerm>
        <definition>
          <para>Contains the Evaluation namespace reference</para>
        </definition>
        <definedTerm>
          <codeEntityReference autoUpgrade="true" qualifyHint="false">N:Microsoft.Build.Execution</codeEntityReference>
        </definedTerm>
        <definition>
          <para>Contains the Execution namespace reference</para>
        </definition>
        <definedTerm>
          <codeEntityReference autoUpgrade="true" qualifyHint="false">N:Microsoft.Build.Framework</codeEntityReference>
        </definedTerm>
        <definition>
          <para>Contains the Framework namespace reference</para>
        </definition>
        <definedTerm>
          <codeEntityReference autoUpgrade="true" qualifyHint="false">N:Microsoft.Build.Logging</codeEntityReference>
        </definedTerm>
        <definition>
          <para>Contains the Logging namespace reference</para>
        </definition>
        <definedTerm>
          <codeEntityReference autoUpgrade="true" qualifyHint="false">N:Microsoft.Build.Tasks</codeEntityReference>
        </definedTerm>
        <definition>
          <para>Contains the Tasks namespace reference</para>
        </definition>
        <definedTerm>
          <codeEntityReference autoUpgrade="true" qualifyHint="false">N:Microsoft.Build.Utilities</codeEntityReference>
        </definedTerm>
        <definition>
          <para>Contains the Utilities namespace reference</para>
        </definition>
      </definitionTable>
    </content>
  </relatedSections>
</developerOrientationDocument>