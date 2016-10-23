---
title: "MSBuild Error MSB1005"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: cf4e8503-46fb-4c1e-a1ca-aa344276ebb0
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
# MSBuild Error MSB1005
<?xml version="1.0" encoding="utf-8"?>
<developerErrorMessageDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <ui>Specify a property and its value.</ui>
    </para>
    <para>A property name and value must be specified for the <system>/property</system> switch.</para>
  </introduction>
  <procedure>
    <title>To correct this error</title>
    <steps class="ordered">
      <step>
        <content>
          <para>Specify a property name and value using the format <codeInline>/property:&lt;name&gt;=&lt;value&gt;</codeInline>. You can use either a comma or a semicolon to separate a list of properties, for example, <codeInline>/property:WarningLevel=2;OutputDir=bin\Debug</codeInline> or <codeInline>/property:WarningLevel=2,OutputDir=bin\Debug</codeInline>. Alternatively, you can repeat the switch, for example, <codeInline>/p:WarningLevel=2 /p:OutputDir=bin\Debug</codeInline></para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>
<link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>
<link xlink:href="962912ac-8931-49bf-a88c-0200b6e37362">MSBuild Properties</link>
</relatedTopics>
</developerErrorMessageDocument>