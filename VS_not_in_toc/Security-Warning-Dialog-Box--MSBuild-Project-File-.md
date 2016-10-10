---
title: "Security Warning Dialog Box (MSBuild Project File)"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: ea705296-ad5b-4e55-a75f-e421f35fe640
caps.latest.revision: 10
manager: douge
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
# Security Warning Dialog Box (MSBuild Project File)
<?xml version="1.0" encoding="utf-8"?>
<developerUIReferenceDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>The <ui>Security Warning</ui> dialog box warns developers about security issues with projects.</para>
  </introduction>
  <section>
    <title>UI Elements</title>
    <content>
      <definitionTable>
        <definedTerm>
          <ui>Ask me for every project in this solution</ui>
        </definedTerm>
        <definition>
          <para>Select this option to be prompted for every project in the solution. This is set by default.</para>
        </definition>
      </definitionTable>
    </content>
  </section>
  <section>
    <content />
    <sections>
      <section>
        <title>Project Items in Potentially Dangerous Locations</title>
        <content>
          <para>Some items in otherwise safe .targets files use user-defined project properties set their paths. To prevent an item from overwriting an important file, project files that contain item paths that evaluate to one of the following locations or any subdirectories of these locations are considered to be potential security risks unless they are also located in or below the solution file or project file directory:</para>
          <list class="bullet">
            <listItem>
              <para>The root directory of any drive.</para>
            </listItem>
            <listItem>
              <para>The Windows directory, for example, C:\Windows\.</para>
            </listItem>
            <listItem>
              <para>The Program Files directory, for example, C:\Program Files\.</para>
            </listItem>
            <listItem>
              <para>Network shares.</para>
            </listItem>
          </list>
        </content>
      </section>
    </sections>
  </section>
  <relatedTopics>
<link xlink:href="e39f13f7-1e1d-4435-95ca-0c222bca071c">MSBuild</link>
<link xlink:href="093395e1-70da-4f74-b34d-046c5e2b32e8">MSBuild Reference</link>
<link xlink:href="083b8ba3-e4ad-45af-bb5d-3bc81d406131">MSBuild Concepts</link>
</relatedTopics>
</developerUIReferenceDocument>