---
title: "Class &#39;&lt;classname&gt;&#39; should declare a &#39;Sub New&#39; because the &#39;&lt;constructorname&gt;&#39; in its base class &#39;&lt;baseclassname&gt;&#39; is marked obsolete: &#39;&lt;errormessage&gt;&#39;"
ms.custom: na
ms.date: 10/10/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - devlang-csharp
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 6d034bbe-ab6a-433a-ae31-8c4a42faf7f8
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
# Class &#39;&lt;classname&gt;&#39; should declare a &#39;Sub New&#39; because the &#39;&lt;constructorname&gt;&#39; in its base class &#39;&lt;baseclassname&gt;&#39; is marked obsolete: &#39;&lt;errormessage&gt;&#39;
A class declaration does not include a constructor, and the base class constructor is marked with the <xref:System.ObsoleteAttribute?qualifyHint=False> attribute and the directive to treat it as a warning.  
  
 When a derived class does not declare a constructor, Visual Basic attempts to generate an implicit parameterless constructor that calls `MyBase.New()`. If there is no accessible constructor in the base class that can be called without arguments, Visual Basic cannot generate an implicit constructor. In this case, the required constructor is marked with the <xref:System.ObsoleteAttribute?qualifyHint=False> attribute, so Visual Basic cannot call it.  
  
 You can mark any programming element as being no longer in use by applying <xref:System.ObsoleteAttribute?qualifyHint=False> to it. If you do this, you can set the attribute's <xref:System.ObsoleteAttribute.IsError?qualifyHint=False> property to either `True` or `False`. If you set it to `True`, the compiler treats an attempt to use the element as an error. If you set it to `False`, or let it default to `False`, the compiler issues a warning if there is an attempt to use the element.  
  
 By default, this message is a warning, because the <xref:System.ObsoleteAttribute.IsError?qualifyHint=False> property of <xref:System.ObsoleteAttribute?qualifyHint=False> is `False`. For information on hiding warnings or treating warnings as errors, see [Configuring Warnings in Visual Basic](../VS_IDE/Configuring-Warnings-in-Visual-Basic.md).  
  
 **Error ID:** BC41002  
  
### To correct this error  
  
1.  Examine the quoted error message and take appropriate action.  
  
2.  Use `Sub New` to declare a constructor in the derived class.  
  
## See Also  
 [NOT IN BUILD: Attributes Used in Visual Basic](assetId:///22231318-8a40-49af-9245-e0aab723563b)   
 [NOT IN BUILD: Application of Attributes](assetId:///2b1703ed-4437-49b3-bc0b-568094324f47)