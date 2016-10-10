---
title: "How to: Escape Special Characters in MSBuild"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 1aa3669c-1647-4960-b770-752e2532102f
caps.latest.revision: 10
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
# How to: Escape Special Characters in MSBuild
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Certain characters have special meaning in <token>vstecmsbuild</token> project files. Examples of the characters include semicolons (;) and asterisks (*). For a complete list of these special characters, see <link xlink:href="545e6a59-1093-4514-935e-78679a46fb3c">MSBuild Special Characters</link>.</para>
    <para>In order to use these special characters as literals in a project file, they must be specified by using the syntax %<placeholder>xx</placeholder>, where <placeholder>xx</placeholder> represents the ASCII hexadecimal value of the character.</para>
  </introduction>
  <section>
    <title>MSBuild Special Characters</title>
    <content>
      <para>One example of where special characters are used is in the <unmanagedCodeEntityReference>Include</unmanagedCodeEntityReference> attribute of item lists. For example, the following item list declares two items: <codeInline>MyFile.cs</codeInline> and <codeInline>MyClass.cs</codeInline>.</para>
      <code>&lt;Compile Include="MyFile.cs;MyClass.cs"/&gt;</code>
      <para>If you want to declare an item that contains a semicolon in the name, you must use the %<placeholder>xx</placeholder> syntax to escape the semicolon and prevent <token>vstecmsbuild</token> from declaring two separate items. For example, the following item escapes the semicolon and declares one item named <codeInline>MyFile.cs;MyClass.cs</codeInline>.</para>
      <code>&lt;Compile Include="MyFile.cs%3BMyClass.cs"/&gt;</code>
      <procedure>
        <title>To use an MSBuild special character as a literal character</title>
        <steps class="bullet">
          <step>
            <content>
              <para>Use the notation %<placeholder>xx</placeholder> in place of the special character, where <placeholder>xx</placeholder> represents the hexadecimal value of the ASCII character. For example, to use an asterisk (*) as a literal character, use the value <codeInline>%2A</codeInline>.</para>
            </content>
          </step>
        </steps>
      </procedure>
    </content>
  </section>
  <relatedTopics>
<link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>

<link xlink:href="d762eff4-c92a-4b5f-a944-1ca30aa22319">MSBuild Items</link>
</relatedTopics>
</developerHowToDocument>