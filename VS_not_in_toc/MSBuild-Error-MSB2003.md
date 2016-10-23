---
title: "MSBuild Error MSB2003"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 2686117d-acc6-4222-93cd-2354cd3e1134
caps.latest.revision: 12
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
# MSBuild Error MSB2003
<?xml version="1.0" encoding="utf-8"?>
<developerErrorMessageDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>
      <ui>The file name of the old project must be specified.</ui>
    </para>
    <para>This project file does not exist in the expected location.</para>
  </introduction>
  <procedure>
    <title>To correct this error</title>
    <steps class="bullet">
      <step>
        <content>
          <para>Check whether the project file has been moved.</para>
        </content>
      </step>
      <step>
        <content>
          <para>Check whether the project file has been modified or corrupted. If it has been modified or corrupted, open the project in the version of <token>vsprvs</token> in which it was created, save it, and then attempt to convert it again.</para>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>

</relatedTopics>
</developerErrorMessageDocument>