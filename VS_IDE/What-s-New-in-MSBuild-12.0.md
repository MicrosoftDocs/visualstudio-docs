---
title: "What&#39;s New in MSBuild 12.0"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-sdk
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 9976a6ad-c052-4017-b848-35b5ae4a2f66
caps.latest.revision: 21
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
# What&#39;s New in MSBuild 12.0
<?xml version="1.0" encoding="utf-8"?>
<developerConceptualDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>MSBuild is now installed as part of Visual Studio rather than as part of the .NET Framework. The current MSBuild version number is 12.0. If you want to install MSBuild separately, download the installation package from <externalLink><linkText>MSBuild Download</linkText><linkUri>http://go.microsoft.com/fwlink/?LinkId=309745</linkUri></externalLink>.</para>
  </introduction>
  <section>
    <title>Changed Path </title>
    <content>
      <para>MSBuild is now installed directly under <placeholder>%ProgramFiles%</placeholder>—for example, in C:\Program Files\MSBuild\.</para>
    </content>
  </section>
  <section>
    <title>Changed Properties </title>
    <content>
      <para>The following MSBuild properties are changed as a result of the new version number:</para>
      <list class="bullet">
        <listItem>
          <para>
            <languageKeyword>MSBuildToolsVersion</languageKeyword> for this version of tools is 12.0.</para>
        </listItem>
        <listItem>
          <para>
            <languageKeyword>MSBuildToolsPath</languageKeyword> is now %ProgramFiles%\MSBuild\12.0\bin on 32-bit operating systems, or %ProgramFiles%\MSBuild\12.0\bin\amd64 on 64-bit operating systems.</para>
        </listItem>
        <listItem>
          <para>
            <languageKeyword>ToolsVersion</languageKeyword> values can be found in HKLM\SOFTWARE\Microsoft\MSBuild\ToolsVersions\12.0 for 32-bit operating systems or HKLM\SOFTWARE\Wow6432Node\Microsoft\MSBuild\ToolsVersions\12.0 <?Comment MO: Correct? 2013-06-18T15:39:00Z  Id='15?>for 64-bit operating systems<?CommentEnd Id='15'
    ?>.</para>
        </listItem>
        <listItem>
          <para>The <languageKeyword>SDK35ToolsPath</languageKeyword> and <languageKeyword>SDK40ToolsPath</languageKeyword> properties point to the .NET Framework SDK that's packaged with this version of Visual Studio (for example, 8.1A for the 4.X tools).</para>
        </listItem>
      </list>
    </content>
  </section>
  <section>
    <title>New Properties</title>
    <content>
      <list class="bullet">
        <listItem>
          <para>
            <languageKeyword>MSBuildFrameworkToolsPath</languageKeyword> is a new property that has a value of %windir%\Microsoft.NET\Framework\v4.0.30319 on 32-bit operating systems or %windir%\Microsoft.NET\Framework64\v4.0.30319 on 64-bit operating systems. This is a replacement for <languageKeyword>MSBuildToolsPath</languageKeyword> that can be used to point to the .NET Framework tools and utilities.</para>
        </listItem>
        <listItem>
          <para>
            <languageKeyword>MSBuildToolsPath</languageKeyword> and <languageKeyword>MSBuildFrameworkToolsPath</languageKeyword> have 32-bit equivalents—<languageKeyword>MSBuildToolsPath32</languageKeyword> and <languageKeyword>MSBuildFrameworkToolsPath32</languageKeyword>—that always point to the 32-bit location, regardless of whether 32-bit or 64-bit MSBuild is being used.</para>
        </listItem>
      </list>
    </content>
  </section>
  <relatedTopics>
    
  </relatedTopics>
</developerConceptualDocument>