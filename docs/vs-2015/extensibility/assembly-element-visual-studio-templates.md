---
title: "Assembly Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Assembly"
helpviewer_keywords: 
  - "Assembly element [Visual Studio templates]"
  - "<Assembly> element [Visual Studio templates]"
ms.assetid: 9242f76a-1273-4b8a-8f26-6606f91829ef
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# Assembly Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies information about an assembly, which the template uses to add a reference of that assembly to projects.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<References>  
 \<Reference>  
 \<Assembly>  
  
## Syntax  
  
```  
<Assembly> AssemblyName </Assembly>  
```  
  
## Attributes and Elements  
 The following sections describe attributes, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Reference](../extensibility/reference-element-visual-studio-templates.md)|Specifies the assembly reference to add when the item is added to a project.|  
  
## Text Value  
 A text value is required.  
  
 This text specifies the assembly to add to a project when the item template is instantiated. This assembly name must be specified in one of the following ways:  
  
- As a full assembly name. For example:  
  
    ```  
    <Assembly>  
        MyAssembly, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, Custom = null.  
    </Assembly>  
    ```  
  
- As simple text reference. For example:  
  
    ```  
    <Assembly> System </Assembly>  
    ```  
  
## Remarks  
 `Assembly` is a required child element of `Reference`.  
  
 The `Reference`, `References,` and `Assembly` elements can only be used in .vstemplate files that have a `Type` attribute value of `Item`.  
  
## Example  
 The following example illustrates the `TemplateContent` element of an item template. This XML adds references to the System.dll and System.Data.dll assemblies.  
  
```  
<TemplateContent>  
    <References>  
        <Reference>  
            <Assembly>  
                System, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  
            </Assembly>  
        </Reference>  
        <Reference>  
            <Assembly>  
                System.Data, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  
            </Assembly>  
        </Reference>  
    </References>  
    ...  
</TemplateContent>  
```  
  
## See also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
