---
title: "CA3075: Insecure DTD Processing | Microsoft Docs"
ms.custom: ""
ms.date: "11/04/2016"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-devops-test"
ms.tgt_pltfrm: ""
ms.topic: "article"
ms.assetid: 65798d66-7a30-4359-b064-61a8660c1eed
caps.latest.revision: 17
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
# CA3075: Insecure DTD Processing
|||  
|-|-|  
|TypeName|InsecureDTDProcessing|  
|CheckId|CA3075|  
|Category|Microsoft.Security|  
|Breaking Change|Non Breaking|  
  
## Cause  
 If you use insecure <xref:System.Xml.XmlReaderSettings.DtdProcessing%2A> instances or reference external entity sources, the parser may accept untrusted input and disclose sensitive information to attackers.  
  
## Rule Description  
 A [Document Type Definition (DTD)](https://msdn.microsoft.com/en-us/library/aa468547.aspx) is one of two ways an XML parser can determine the validity of a document, as defined by the  [World Wide Web Consortium (W3C) Extensible Markup Language (XML) 1.0](http://www.w3.org/TR/2008/REC-xml-20081126/). This rule seeks properties and instances where untrusted data is accepted to warn developers about potential [Information Disclosure](../Topic/Information%20Disclosure.md) threats, which may lead to [Denial of Service (DoS)](../Topic/Denial%20of%20Service.md) attacks. This rule triggers when:  
  
-   DtdProcessing is enabled on the <xref:System.Xml.XmlReader> instance, which resolves external XML entities using <xref:System.Xml.XmlUrlResolver>.  
  
-   The <xref:System.Xml.XmlNode.InnerXml%2A> property in the XML is set.  
  
-   <xref:System.Xml.XmlReaderSettings.DtdProcessing%2A> property is set  to Parse    .  
  
-   Untrusted input is processed using <xref:System.Xml.XmlResolver> instead of <xref:System.Xml.XmlSecureResolver> .  
  
-   The XmlReader.<xref:System.Xml.XmlReader.Create%2A> method is invoked with an insecure <xref:System.Xml.XmlReaderSettings> instance or no instance at all.  
  
-   <xref:System.Xml.XmlReader> is created with insecure default settings or values    .  
  
 In each of these cases, the outcome is the same: the contents from either the file system or network shares from the machine where the XML is processed will be exposed to the attacker, which may then be used as a DoS vector.  
  
## How to Fix Violations  
  
-   Catch and process all XmlTextReader exceptions properly to avoid path information disclosure    .  
  
-   Use the <xref:System.Xml.XmlSecureResolver> to restrict the resources      that the XmlTextReader can access.  
  
-   Do not allow the <xref:System.Xml.XmlReader> to open any external resources by setting the <xref:System.Xml.XmlResolver> property to **null**.  
  
-   Ensure that the <xref:System.Data.DataViewManager.DataViewSettingCollectionString%2A> property of <xref:System.Data.DataViewManager> is assigned from a trusted source.  
  
 .NET 3.5 and earlier  
  
-   Disable DTD processing if you are dealing with untrusted sources by setting the <xref:System.Xml.XmlReaderSettings.ProhibitDtd%2A> property to **true** .  
  
-   XmlTextReader class has a full trust inheritance demand. See [Inheritance Demands](http://msdn.microsoft.com/en-us/28b9adbb-8f08-4f10-b856-dbf59eb932d9) for more information    .  
  
 .NET 4 and later  
  
-   Avoid enabling DtdProcessing if you're dealing with untrusted sources by setting the DtdProcessing  property to [Prohibit or Ignore](https://msdn.microsoft.com/en-us/library/system.xml.dtdprocessing.aspx)  
  
-   Ensure that the Load() method takes an XmlReader instance in all InnerXml cases.  
  
> [!NOTE]
>  This rule might report false positives on some valid XmlSecureResolver instances. We're working on solving this issue by mid 2016.  
  
## When to Suppress Warnings  
 Unless you're sure that the input is known to be from a trusted source, do not suppress a rule from this warning.  
  
## Pseudo-code Examples  
  
### Violation  
  
```c#  
using System.IO;   
using System.Xml.Schema;   
  
class TestClass   
{   
    public XmlSchema Test   
    {   
        get   
        {   
            var src = "";   
            TextReader tr = new StreamReader(src);   
            XmlSchema schema = XmlSchema.Read(tr, null); // warn   
            return schema;   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.IO;   
using System.Xml;   
using System.Xml.Schema;   
  
class TestClass   
{   
    public XmlSchema Test   
    {   
        get   
        {   
            var src = "";   
            TextReader tr = new StreamReader(src);   
            XmlTextReader reader = new XmlTextReader(tr) { DtdProcessing = DtdProcessing.Prohibit };   
            XmlSchema schema = XmlSchema.Read(reader , null);   
            return schema;   
        }   
    }   
}  
```  
  
### Violation  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    public class TestClass   
    {   
        public XmlReaderSettings settings = new XmlReaderSettings();   
        public void TestMethod(string path)   
        {   
            var reader = XmlReader.Create(path, settings);  // warn   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    public class TestClass   
    {   
        public XmlReaderSettings settings = new XmlReaderSettings()    
        {   
            DtdProcessing = DtdProcessing.Prohibit    
        };   
  
        public void TestMethod(string path)   
        {   
            var reader = XmlReader.Create(path, settings);    
        }   
    }   
}  
```  
  
### Violations  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    public class DoNotUseSetInnerXml   
    {   
        public void TestMethod(string xml)   
        {   
            XmlDocument doc = new XmlDocument() { XmlResolver = null };   
            doc.InnerXml = xml; // warn   
        }   
    }   
}  
```  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    public class DoNotUseLoadXml   
    {  
        public void TestMethod(string xml)   
        {   
            XmlDocument doc = new XmlDocument(){ XmlResolver = null };   
            doc.LoadXml(xml); // warn   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.Xml;   
  
public static void TestMethod(string xml)   
{   
    XmlDocument doc = new XmlDocument() { XmlResolver = null };   
    System.IO.StringReader sreader = new System.IO.StringReader(xml);   
    XmlTextReader reader = new XmlTextReader(sreader) { DtdProcessing = DtdProcessing.Prohibit };   
    doc.Load(reader);   
}  
```  
  
### Violation  
  
```c#  
using System.IO;   
using System.Xml;   
using System.Xml.Serialization;   
  
namespace TestNamespace   
{   
    public class UseXmlReaderForDeserialize   
    {   
        public void TestMethod(Stream stream)   
        {   
            XmlSerializer serializer = new XmlSerializer(typeof(UseXmlReaderForDeserialize));   
            serializer.Deserialize(stream); // warn   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.IO;   
using System.Xml;   
using System.Xml.Serialization;   
  
namespace TestNamespace   
{   
    public class UseXmlReaderForDeserialize   
    {   
        public void TestMethod(Stream stream)   
        {   
            XmlSerializer serializer = new XmlSerializer(typeof(UseXmlReaderForDeserialize));   
            XmlTextReader reader = new XmlTextReader(stream) { DtdProcessing = DtdProcessing.Prohibit } ;   
            serializer.Deserialize(reader );   
        }   
    }   
}  
```  
  
### Violation  
  
```c#  
using System.Xml;   
using System.Xml.XPath;   
  
namespace TestNamespace   
{   
    public class UseXmlReaderForXPathDocument   
    {   
        public void TestMethod(string path)   
        {   
            XPathDocument doc = new XPathDocument(path); // warn   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.Xml;   
using System.Xml.XPath;   
  
namespace TestNamespace   
{   
    public class UseXmlReaderForXPathDocument   
    {   
        public void TestMethod(string path)   
        {   
            XmlTextReader reader = new XmlTextReader(path) { DtdProcessing = DtdProcessing.Prohibit };   
            XPathDocument doc = new XPathDocument(reader);   
        }   
    }   
}  
```  
  
### Violation  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    class TestClass   
    {   
        public XmlDocument doc = new XmlDocument() { XmlResolver = new XmlUrlResolver() };   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    class TestClass   
    {   
        public XmlDocument doc = new XmlDocument() { XmlResolver = null }; // or set to a XmlSecureResolver instance   
    }   
}  
```  
  
### Violations  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    public class TestClass   
    {   
        public void TestMethod(string path)   
        {   
            XmlReaderSettings settings = new XmlReaderSettings(){ DtdProcessing = DtdProcessing.Parse };   
            XmlReader reader = XmlReader.Create(path, settings); // warn   
        }   
    }   
}  
```  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    class TestClass   
    {   
        private static void TestMethod()   
        {   
            var reader = XmlTextReader.Create(""doc.xml""); //warn   
        }   
    }   
}  
```  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    public class TestClass   
    {   
        public void TestMethod(string path)   
        {   
            try {   
                XmlTextReader reader = new XmlTextReader(path); // warn   
            }   
            catch { throw ; }   
            finally {}   
        }   
    }   
}  
```  
  
### Solution  
  
```c#  
using System.Xml;   
  
namespace TestNamespace   
{   
    public class TestClass   
    {   
        public void TestMethod(string path)   
        {   
            XmlReaderSettings settings = new XmlReaderSettings(){ DtdProcessing = DtdProcessing.Prohibit };   
            XmlReader reader = XmlReader.Create(path, settings);   
        }   
    }   
}  
```