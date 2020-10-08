---
title: "References Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#References"
helpviewer_keywords: 
  - "<References> element [Visual Studio Templates]"
  - "References element [Visual Studio Templates]"
ms.assetid: 1969146d-46bf-422d-8d46-0e9493925003
caps.latest.revision: 9
ms.author: gregvanl
manager: jillfra
---
# References Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Groups the assembly references that the template adds to projects.  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<References>  
  
## Syntax  
  
```  
<References>  
    <Reference>... </Reference>  
    <Reference>... </Reference>  
    ...  
</References>  
```  
  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[Reference](../extensibility/reference-element-visual-studio-templates.md)|Required element.<br /><br /> Specifies the assembly reference to add when the item is added to a project. There must be one or more `Reference` elements in a `References` element.|  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md)|Specifies the contents of the template.|  
  
## Remarks  
 `References` is an optional child element of `TemplateContent`.  
  
 The `Reference` and `References` elements can only be used in .vstemplate files that have a `Type` attribute value of `Item`.  
  
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
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
