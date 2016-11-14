---
title: "CA3077: Insecure Processing in API Design, XML Document and XML Text Reader | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 7f33771b-f3c8-4c02-bef6-f581b623c303
caps.latest.revision: 7
author: "stevehoag"
ms.author: "shoag"
manager: "wpickett"
translation.priority.ht: 
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "ru-ru"
  - "zh-cn"
  - "zh-tw"
translation.priority.mt: 
  - "cs-cz"
  - "pl-pl"
  - "pt-br"
  - "tr-tr"
---
# CA3077: Insecure Processing in API Design, XML Document and XML Text Reader
|||  
|-|-|  
|TypeName|InsecureDTDProcessingInAPIDesign|  
|CheckId|CA3077|  
|Category|Microsoft.Security|  
|Breaking Change|Non Breaking|  
  
## Cause  
 When designing an API derived from XMLDocument and XMLTextReader, be mindful of <xref:System.Xml.XmlReaderSettings.DtdProcessing%2A>.  Using insecure DTDProcessing instances when referencing or resolving external entity sources or setting insecure values in the XML may lead to information disclosure.  
  
## Rule Description  
 A [Document Type Definition (DTD)](https://msdn.microsoft.com/en-us/library/aa468547.aspx) is one of two ways an XML parser can determine the validity of a document, as defined by the  [World Wide Web Consortium (W3C) Extensible Markup Language (XML) 1.0](http://www.w3.org/TR/2008/REC-xml-20081126/). This rule seeks properties and instances where untrusted data is accepted to warn developers about potential [Information Disclosure](../Topic/Information%20Disclosure.md) threats, which may lead to [Denial of Service (DoS)](../Topic/Denial%20of%20Service.md) attacks. This rule triggers when:  
  
-   <xref:System.Xml.XmlDocument> or <xref:System.Xml.XmlTextReader> classes use default resolver values for DTD processing    .  
  
-   No constructor is defined for the XmlDocument or XmlTextReader derived classes or no secure value is used for <xref:System.Xml.XmlResolver>.  
  
## How to Fix Violations  
  
-   Catch and process all XmlTextReader exceptions properly to avoid path information disclosure    .  
  
-   Use <xref:System.Xml.XmlSecureResolver>instead of XmlResolver to restrict the resources the XmlTextReader can  access.  
  
## When to Suppress Warnings  
 Unless you're sure that the input is known to be from a trusted source, do not suppress a rule from this warning.  
  
## Pseudo-code Examples  
  
### Violation  
  
```c#  
using System;   
using System.Xml;   
  
namespace TestNamespace   
{   
    class TestClass : XmlDocument    
    {   
        public TestClass () {} // warn   
    }   
  
    class TestClass2 : XmlTextReader    
    {       
        public TestClass2() // warn   
        {   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System;   
using System.Xml;   
  
namespace TestNamespace   
{   
    class TestClass : XmlDocument    
    {   
        public TestClass ()    
        {   
            XmlResolver = null;   
        }   
    }   
  
    class TestClass2 : XmlTextReader    
    {       
        public TestClass2()    
        {   
               XmlResolver = null;   
        }   
    }   
}  
```