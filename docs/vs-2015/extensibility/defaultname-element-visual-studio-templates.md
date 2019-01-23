---
title: "DefaultName Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#DefaultName"
helpviewer_keywords: 
  - "DefaultName element [Visual Studio project templates]"
ms.assetid: 0ff056c8-b9d2-4747-9308-92adf1811491
caps.latest.revision: 16
ms.author: gregvanl
manager: jillfra
---
# DefaultName Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies the name that the Visual Studio project system will generate for the project or item when it is created.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<DefaultName>  
  
## Syntax  
  
```  
<DefaultName>  
    Default Project Name  
</DefaultName>  
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 This text specifies the default name of the project or item.  
  
## Remarks  
 `DefaultName` is an optional element.  
  
 For projects, this element specifies the name of the directory that stores the project on disk. For items, it specifies the file name of the source file.  
  
 When you create a project or item, you can modify the default name using the **Name** option, which is available from either the **New Project** dialog box or **Add New Item** dialog box.  
  
 If you do not want the project system to generate the default name for the project or item, then set the [ProvideDefaultName](../extensibility/providedefaultname-element-visual-studio-templates.md) element to `False`.  
  
## Example  
 The following example illustrates the metadata for the standard item template for a [!INCLUDE[csprcs](../includes/csprcs-md.md)] class.  
  
```  
<VSTemplate Type="Item" Version="3.0.0"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <Name>MyClass</Name>  
        <Description>My custom C# class.</Description>  
        <Icon>Icon.ico</Icon>  
        <ProjectType>CSharp</ProjectType>  
        <DefaultName>MyClass.cs</DefaultName>  
    </TemplateData>  
    <TemplateContent>  
        <ProjectItem ReplaceParameters="true">MyClass.cs</ProjectItem>  
    </TemplateContent>  
</VSTemplate>  
```  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
