---
title: "span::span Constructor"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 8b5578aa-5e5c-4ac7-87c7-ce87c4246e2c
caps.latest.revision: 3
manager: ghogen
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
# span::span Constructor
<?xml version="1.0" encoding="utf-8"?>
<developerReferenceWithSyntaxDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>Initializes a new instance of the <unmanagedCodeEntityReference>span</unmanagedCodeEntityReference> class.</para>
  </introduction>
  <syntaxSection>
    <legacySyntax>span(
   const marker_series&amp; <parameterReference>_Series</parameterReference>,
   _In_ LPCTSTR <parameterReference>_Format</parameterReference>,
   ...
);
span(
   const marker_series&amp; <parameterReference>_Series</parameterReference>,
   marker_importance <parameterReference>_Importance</parameterReference>,
   _In_ LPCTSTR <parameterReference>_Format</parameterReference>,
   ...
);
span(
   const marker_series&amp; <parameterReference>_Series</parameterReference>,
   int <parameterReference>_Category</parameterReference>,
   _In_ LPCTSTR <parameterReference>_Format</parameterReference>,
   ...
);
span(
   const marker_series&amp; <parameterReference>_Series</parameterReference>,
   marker_importance <parameterReference>_Importance</parameterReference>,
   int <parameterReference>_Category</parameterReference>,
   _In_ LPCTSTR <parameterReference>_Format</parameterReference>,
   ...
);</legacySyntax>
  </syntaxSection>
  <parameters>
    <content>
      <definitionTable>
        <definedTerm>
          <parameterReference>_Series</parameterReference>
        </definedTerm>
        <definition>
          <para>Valid marker series context.</para>
        </definition>
        <definedTerm>
          <parameterReference>_Format</parameterReference>
        </definedTerm>
        <definition>
          <para>A composite format string that contains text intermixed with zero or more format items, which correspond to objects in the argument list.</para>
        </definition>
        <definedTerm>
          <parameterReference>_Importance</parameterReference>
        </definedTerm>
        <definition>
          <para>Importance level.</para>
        </definition>
        <definedTerm>
          <parameterReference>_Category</parameterReference>
        </definedTerm>
        <definition>
          <para>Category.</para>
        </definition>
      </definitionTable>
    </content>
  </parameters>
  <requirements>
    <content>
      <para>
        <embeddedLabel>Header: </embeddedLabel>cvmarkersobj.h</para>
      <para>
        <embeddedLabel>Namespace: </embeddedLabel>Concurrency::diagnostic</para>
    </content>
  </requirements>
  <relatedTopics>
    
  </relatedTopics>
</developerReferenceWithSyntaxDocument>