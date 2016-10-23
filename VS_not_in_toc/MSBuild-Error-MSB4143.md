---
title: "MSBuild Error MSB4143"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 25019aa4-f0da-4bcd-862e-9b5a57913bb4
caps.latest.revision: 8
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
# MSBuild Error MSB4143
<?xml version="1.0" encoding="utf-8"?>
<developerErrorMessageDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <ui>MSB4143: The expression "&lt;expression&gt;" cannot be evaluated.</ui>
    </para>
    <para>A property expression that reads its value from the registry cannot be evaluated.</para>
  </introduction>
  <procedure>
    <title>To correct this error</title>
    <steps class="bullet">
      <step>
        <content>
          <para>Make sure that the property follows the correct syntax to read a value from the registry. For example: <codeInline>$(Registry:HKEY_LOCAL_MACHINE\Software\Microsoft\VisualStudio\8.0\MSBuild@MSBuildBinPath)</codeInline>.</para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>

<link xlink:href="d1cda56a-dbef-4109-9201-39e962e3f653">Project Element (MSBuild)</link>
<link xlink:href="29dd85ee-1530-43c1-b085-bb2330ac5a48">Resources for Troubleshooting MSBuild Errors</link>
</relatedTopics>
</developerErrorMessageDocument>