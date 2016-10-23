---
title: "MSBuild Error MSB1006"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6d97d164-66f1-47bf-9cd9-7422a6c0dbb3
caps.latest.revision: 10
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
# MSBuild Error MSB1006
<?xml version="1.0" encoding="utf-8"?>
<developerErrorMessageDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <ui>Property is not valid.</ui>
    </para>
    <para>The property name or the property value is not specified, for example, <codeInline>/property:=Debug</codeInline> or <codeInline>/property:Configuration</codeInline>.</para>
  </introduction>
  <procedure>
    <title>To correct this error</title>
    <steps class="ordered">
      <step>
        <content>
          <para>Specify both the property name and the property value, for example, <codeInline>/property:Configuration=Debug</codeInline>. </para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>
<link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>
</relatedTopics>
</developerErrorMessageDocument>