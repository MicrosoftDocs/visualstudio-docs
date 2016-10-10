---
title: "MSBuild Error MSB1020"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 75fcb139-0c45-4bf1-a176-60bfb9d1baa4
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
# MSBuild Error MSB1020
<?xml version="1.0" encoding="utf-8"?>
<developerErrorMessageDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <ui>The logger was not found. Check the following: 1.) The logger name specified is the same as the name of the logger class. 2.) The logger class is "public" and implements the Microsoft.Build.Framework.ILogger interface. 3.) The path to the logger assembly is correct, or the logger can be loaded using only the assembly name provided.</ui>
    </para>
    <para>The specified logger was not found.</para>
  </introduction>
  <procedure>
    <title>To correct this error</title>
    <steps class="bullet">
      <step>
        <content>
          <para>Check that the logger name specified is the same as the name of the logger class.</para>
        </content>
      </step>
      <step>
        <content>
          <para>Check that the logger class is public and implements the <codeEntityReference autoUpgrade="true">T:Microsoft.Build.Framework.ILogger</codeEntityReference> interface.</para>
        </content>
      </step>
      <step>
        <content>
          <para>Check that the path to the logger assembly is correct, or the logger can be loaded using only the assembly name provided.</para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>
<link xlink:href="edaa65ec-ab8a-42a1-84cb-d76d5b2f4584">MSBuild Command Line Reference</link>
<link xlink:href="fa34810d-185a-4d22-92bd-9852915e5f1d">How To: Write a Logger</link>

</relatedTopics>
</developerErrorMessageDocument>