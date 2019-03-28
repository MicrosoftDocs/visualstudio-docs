---
title: "RequiredPlatformVersion Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
ms.assetid: 6f0e4986-3157-4bba-aed3-c28413ebe976
caps.latest.revision: 7
ms.author: gregvanl
manager: jillfra
---
# RequiredPlatformVersion Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies the minimum version of the operating system that the project template requires to work correctly. This element is used to for project templates that create [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] apps.  
  
 The `RequiredPlatformVersion` value is compared directly with the version of the operating system. If the `RequiredPlatformVersion` is higher than the operating system version, the template does not appear in the **New Project** dialog box. To specify a template for [!INCLUDE[win8](../includes/win8-md.md)] or higher, set `RequiredPlatformVersion` to 6.2.0. To specify a template for [!INCLUDE[win81](../includes/win81-md.md)] or higher, set RequiredPlatformVersion to 6.3.0.  
  
 Templates that specify `RequiredPlatformVersion`=8 are compatible with previous customer [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] templates.  
  
 VSTemplate  
TemplateData  
…..TargetPlatformName  
RequiredPlatformVersion  
  
## Syntax  
  
```xml  
<RequiredPlatformVersion> OperatingSystem </RequiredPlatformVersion>  
```  
  
## Attributes and Elements  
 None.  
  
### Attributes  
 None.  
  
### Child Elements  
 None.  
  
### Parent Elements  
  
|Element|Description|  
|-------------|-----------------|  
|[TemplatePlatformName](../extensibility/templatedata-element-visual-studio-templates.md)|Specifies the platform that the project template targets.|  
  
## Text Value  
 A text value is required.  
  
## Remarks  
 This text specifies the minimum operating system version required by the template.  
  
## Example  
 This example specifies that the project template targets [!INCLUDE[win8](../includes/win8-md.md)] or later.  
  
```xml  
<VSTemplate Type="Project" Version="3.0.0"    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <TargetPlatformName>Windows</TargetPlatformName>  
            <RequiredPlatformVersion>6.3.0</RequiredPlatformVersion>  
  
    </TemplateData>  
    <TemplateContent>  
  
    </TemplateContent>  
</VSTemplate>  
```  
  
## See Also  
 [TargetPlatformName Element (Visual Studio Templates)](../extensibility/targetplatformname-element-visual-studio-templates.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)   
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
