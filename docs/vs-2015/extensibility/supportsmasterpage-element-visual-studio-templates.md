---
title: "SupportsMasterPage Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
f1_keywords: 
  - "http://schemas.microsoft.com/developer/vstemplate/2005#SupportsMasterPage"
helpviewer_keywords: 
  - "<SupportsMasterPage> element [Visual Studio Templates]"
  - "SupportsMasterPage element [Visual Studio Templates]"
ms.assetid: ce877a6a-9bba-4fd9-92fb-0a8dfec9e75b
caps.latest.revision: 10
ms.author: gregvanl
manager: jillfra
---
# SupportsMasterPage Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies whether the or not the **Select Master Page** checkbox is enabled on the **Add New Item** dialog box.  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<SupportsMasterPage>  
  
## Syntax  
  
```  
<SupportsMasterPage> true/false </SupportsMasterPage>  
```  
  
## Attributes and Elements  
 The following sections describe attribute, child elements, and parent elements.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Specifies data that categorizes the template, and defines how it displays in the **New Project** or **New Item** dialog box.|  
  
## Text Value  
 A text value is required.  
  
 The text must be either `true` or `false`, indicating whether or not the **Select Master Page** checkbox is enabled on the **Add New Item** dialog box.  
  
## Remarks  
 `SupportsMasterPage` is an optional element. The default value is `false`.  
  
 The `SupportsMasterPage` element is only available for Web item templates.  
  
## Example  
 The following example illustrates the metadata for a Web project that includes support for a master page.  
  
```  
<VSTemplate Version="3.0.0" Type="Project"  
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">>  
    <TemplateData>  
        <Name>MyWebProjecStarterKit</Name>  
        <Description>A simple Web template</Description>  
        <Icon>icon.ico</Icon>  
        <ProjectType>Web</ProjectType>  
        <ProjectSubType>CSharp</ProjectSubType>  
        <DefaultName>WebSite</DefaultName>  
        <SupportsMasterPage>true</SupportsMasterPage>  
    </TemplateData>  
    <TemplateContent>  
        <Project File="WebApplication.webproj">  
            <ProjectItem>icon.ico</ProjectItem>  
            <ProjectItem OpenInEditor="true">Default.aspx</ProjectItem>  
            <ProjectItem>Default.aspx.cs</ProjectItem>  
        </Project>  
    </TemplateContent>  
</VSTemplate>  
```  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
