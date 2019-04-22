---
title: "ProjectItem Element (Visual Studio Item Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#ProjectItem"
helpviewer_keywords: 
  - "<ProjectItem> element [Visual Studio item templates]"
  - "ProjectItem element [Visual Studio item templates]"
ms.assetid: 9ed94112-0c38-49df-b728-0dd2d0d1eb47
caps.latest.revision: 14
ms.author: gregvanl
manager: jillfra
---
# ProjectItem Element (Visual Studio Item Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies a file that is included in the item template.  
  
> [!NOTE]
> The `ProjectItem` element accepts different attributes depending on whether the template is for a project or an item. This topic explains the `ProjectItem` element for item. For an explanation of the `ProjectItem` element for project templates, see [ProjectItem Element (Visual Studio Project Templates)](../extensibility/projectitem-element-visual-studio-project-templates.md).  
  
 \<VSTemplate>  
 \<TemplateContent>  
 \<ProjectItem>  
  
## Syntax  
  
```  
<ProjectItem  
    SubType="Form/Component/CustomControl/UserControl"  
    CustomTool="string"  
    ItemType="string"  
    ReplaceParameters="true/false"  
    TargetFileName="TargetFileName.ext">  
        FileName.ext  
</ProjectItem>  
```  
  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
  
|Attribute|Description|  
|---------------|-----------------|  
|`SubType`|Optional attribute.<br /><br /> Specifies the subtype of an item in a multi-file item template. This value is used to determine the editor that [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will use to open the item.|  
|`CustomTool`|Optional attribute.<br /><br /> Sets the CustomTool for the item in the Project file.|  
|`ItemType`|Optional attribute.<br /><br /> Sets the ItemType for the item in the Project file.|  
|`ReplaceParameters`|Optional attribute.<br /><br /> A Boolean value that specifies whether the item has parameter values that must be replaced when a project is created from the template. Default value is `false`.|  
|`TargetFileName`|Optional attribute.<br /><br /> Specifies the name of the item that is created from the template. This attribute is useful for using parameter replacement to create an item name.|  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateContent](../extensibility/templatecontent-element-visual-studio-templates.md)|Specifies the contents of the template.|  
  
## Text Value  
 A text value is required.  
  
 A `string` that represents the name of a file in the template .zip file.  
  
## Remarks  
 `ProjectItem` is an optional child of `TemplateContent`.  
  
 The `TargetFileName` attribute can be used to rename files with parameters. For example, if the file `MyFile.vb` exists in the root directory of the template .zip file, but you want the file to be named based on the file name provided by the user in the **Add New Item** dialog box, you would use the following XML:  
  
```  
<ProjectItem TargetFileName="$fileinputname$.vb">MyFile.vb</ProjectItem>  
```  
  
 When an item is created from this template, the file name will be based on the name the user entered in the **Add New Item** dialog box. This is useful when creating multi-file item templates. For more information, see [How to: Create Multi-file Item Templates](../ide/how-to-create-multi-file-item-templates.md) and [Template Parameters](../ide/template-parameters.md).  
  
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
 [How to: Create Multi-file Item Templates](../ide/how-to-create-multi-file-item-templates.md)   
 [Template Parameters](../ide/template-parameters.md)
