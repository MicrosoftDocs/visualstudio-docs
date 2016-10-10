---
title: "CA3076: Insecure XSLT Script Execution"
ms.custom: na
ms.date: 10/06/2016
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-devops-test
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 53cb7a46-c564-488f-bc51-0e210a7853c9
caps.latest.revision: 5
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
# CA3076: Insecure XSLT Script Execution
|||  
|-|-|  
|TypeName|InsecureXSLTScriptExecution|  
|CheckId|CA3076|  
|Category|Microsoft.Security|  
|Breaking Change|Non Breaking|  
  
## Cause  
 If you execute [Extensible Stylesheets Language Transformations (XSLT)](https://support.microsoft.com/en-us/kb/313997) in .NET applications insecurely, the processor may [resolve untrusted URI references](assetId:///ba3e4d4f-1ee7-4226-a51a-78a1f1b5bd8a) that could disclose sensitive information to attackers, leading to Denial of Service and Cross-Site attacks.  
  
## Rule Description  
 [XSLT](assetId:///6377ce5f-3c45-42a6-b7a9-ec8da588b60c) is a World Wide Web Consortium (W3C) standard for transforming XML data. XSLT is typically used to write style sheets to transform XML data to other formats such as HTML, fixed length text, comma-separated text, or a different XML format. Although prohibited by default, you may choose to enable it for your project.  
  
 To ensure you're not exposing an attack surface, this rule triggers whenever the XslCompiledTransform.<xref:System.Xml.Xsl.XslCompiledTransform.Load?qualifyHint=False> receives insecure combination instances of <xref:System.Xml.Xsl.XsltSettings?qualifyHint=False> and <xref:System.Xml.XmlResolver?qualifyHint=False>, which allows malicious script processing.  
  
## How to Fix Violations  
  
-   Replace the insecure XsltSettings argument with XsltSettings.<xref:System.Xml.Xsl.XsltSettings.Default?qualifyHint=False> or with an instance that has disabled document function and script execution.  
  
-   Replace the <xref:System.Xml.XmlResolver?qualifyHint=False> argument with null or an <xref:System.Xml.XmlSecureResolver?qualifyHint=False> instance.  
  
## When to Suppress Warnings  
 Unless you're sure that the input is known to be from a trusted source, do not suppress a rule from this warning.  
  
## Pseudo-code Examples  
  
### Violation  
  
```c#  
using System.Xml;  
using System.Xml.Xsl;  
  
namespace TestNamespace   
{   
    class TestClass   
    {  
         void TestMethod()   
        {    
             XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();   
             var settings = XsltSettings.TrustedXslt;   
             var resolver = new XmlUrlResolver();   
             xslCompiledTransform.Load("testStylesheet", settings, resolver); // warn   
        }  
    }   
}   
```  
  
### Solution  
  
```c#  
using System.Xml;   
using System.Xml.Xsl;   
  
namespace TestNamespace   
{   
    class TestClass   
    {   
        void TestMethod()   
        {   
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();   
            var settings = XsltSettings.Default;   
            var resolver = new XmlUrlResolver();   
            xslCompiledTransform.Load("testStylesheet", settings, resolver);   
        }   
    }   
}  
```  
  
### Violation  
  
```c#  
using System.Xml;   
using System.Xml.Xsl;   
  
namespace TestNamespace   
{   
    class TestClass   
    {   
        private static void TestMethod(XsltSettings settings)   
        {   
            try   
            {   
                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();   
                var resolver = new XmlUrlResolver();   
                xslCompiledTransform.Load("testStylesheet", settings, resolver); // warn   
            }   
            catch { throw; }   
            finally { }   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.Xml;   
using System.Xml.Xsl;   
  
namespace TestNamespace   
{   
    class TestClass   
    {   
        private static void TestMethod(XsltSettings settings)   
        {   
            try   
            {   
                XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();   
                settings.EnableDocumentFunction = false;   
                settings.EnableScript = false;   
                var resolver = new XmlUrlResolver();   
                xslCompiledTransform.Load("testStylesheet", settings, resolver);   
            }   
            catch { throw; }   
            finally { }   
        }   
    }   
}  
```