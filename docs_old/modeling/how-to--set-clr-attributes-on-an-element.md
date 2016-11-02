---
title: "How to: Set CLR Attributes on an Element"
ms.custom: na
ms.date: "10/14/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
f1_keywords: 
  - "vs.dsltools.EditAttributesDialog"
helpviewer_keywords: 
  - "Domain-Specific Language, custom attrributes"
ms.assetid: b3db3c74-920c-4701-9544-6f75cbe8b7c9
caps.latest.revision: 19
ms.author: "awills"
manager: "kamrani"
---
# How to: Set CLR Attributes on an Element
Custom attributes are special attributes that can be added to domain elements, shapes, connectors, and diagrams. You can add any attribute that inherits from the `System.Attribute` class.  
  
### To add a custom attribute  
  
1.  In the **DSL Explorer**, select the element to which you want to add a custom attribute.  
  
2.  In the **Properties** window, next to the **Custom Attributes** property, click the Browse (**...**) icon.  
  
     The **Edit Attributes** dialog box opens.  
  
3.  In the **Name** column, click **\<add attribute>** and type the name of your attribute. Press ENTER.  
  
4.  The line under the attribute name shows parentheses. On this line type a parameter type for the attribute (for example, `string`), and then press ENTER.  
  
5.  In the **Name Property** column, type an appropriate name, for example, `MyString`.  
  
6.  Click **OK**.  
  
     The **Custom Attributes** property now displays the attribute in the following format:  
  
     `[` *AttributeName* `(` *ParameterName* `=` *Type* `)]`  
  
## See Also  
 [Domain-Specific Language Tools Glossary](assetId:///ca5e84cb-a315-465c-be24-76aa3df276aa)