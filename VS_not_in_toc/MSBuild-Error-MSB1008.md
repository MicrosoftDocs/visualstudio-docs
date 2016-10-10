---
title: "MSBuild Error MSB1008"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 16012f0d-b2d7-424c-9fa0-067e4df1b3e7
caps.latest.revision: 11
manager: douge
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# MSBuild Error MSB1008
<?xml version="1.0" encoding="utf-8"?>
<developerErrorMessageDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <ui>Only one project can be specified.</ui>
    </para>
    <para>
      <token>vstecmsbuild</token> can build only one project.</para>
  </introduction>
  <procedure>
    <title>To correct this error</title>
    <steps class="ordered">
      <step>
        <content>
          <para>Specify only one project to build. If you want to build two projects, build one project then build the other project. For example, instead of typing <codeInline>msbuild myapp1.proj myapp2.proj</codeInline>, build the first project by typing <codeInline>msbuild myapp1.proj</codeInline>, and then, when that build is complete, build the second project by typing <codeInline>msbuild myapp2.proj</codeInline>.</para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>
<link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>

<link xlink:href="76577f6c-7669-44ad-a840-363e37a04d34">MSBuild Task</link>
</relatedTopics>
</developerErrorMessageDocument>