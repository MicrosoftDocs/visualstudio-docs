---
title: "AppliesTo Element (Visual Studio Templates) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: reference
ms.assetid: 8fb1334b-d78c-405f-98b4-786e9f6b58d7
caps.latest.revision: 11
ms.author: gregvanl
manager: jillfra
---
# AppliesTo Element (Visual Studio Templates)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Specifies an optional expression to match one or more capabilities. (see <xref:Microsoft.VisualStudio.Shell.Interop.VsProjectCapabilityExpressionMatcher>). Capabilities are exposed by project types via the hierarchy as a property <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID5>. In this way, the template can be shared by multiple project types that have common applicable capabilities.  
  
 This element is optional. There can be a maximum of one instance in a template file. This element only enables an item template to opt-in as applicable, based on the capabilities of the currently selected active project. It cannot be used to make an item template not applicable. If `AppliesTo` is absent or the expression does not successfully opt in, then `TemplateID` or `TemplateGroupID` is used to make the template applicable, as with previous versions of the product.  
  
 Introduced in Visual Studio 2013 Update 2. To reference the correct version, see [Referencing Assemblies Delivered in the Visual Studio 2013 SDK Update 2](https://msdn.microsoft.com/42b65c3e-e42b-4c39-98c8-bea285f25ffb).  
  
 \<VSTemplate>  
 \<TemplateData>  
 \<AppliesTo>  
  
## Syntax  
  
```  
<AppliesTo>Capability1</AppliesTo>   
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Categorizes the template.|  
  
## Text Value  
 A text value is required. This text specifies the capabilities of the project.  
  
 Valid expression syntax is defined as:  
  
- The capability expression, such as "(VisualC &#124; CSharp) + (MSTest &#124; NUnit)".  
  
- The "&#124;" is the OR operator.  
  
- The "&" and "+" characters are both AND operators.  
  
- The "!" character is the NOT operator.  
  
- Parentheses force evaluation-precedence order.  
  
- A null or empty expression is evaluated as a match.  
  
- Project capabilities may be any character except these reserved characters: "'`:;,+-*/\\!~&#124;&%$@^()={}[]<>? \t\b\n\r  
  
## Example  
 The following example shows three different templates. `Template1` applies either to all C# project types or any other project type that supports the `WindowsAppContainer` capability. `Template2` applies to all C# projects of any kind. `Template3` applies to C# projects that are not `WindowsAppContainer` projects.  
  
```xml  
<!--  Template 1 -->  
<?xml version="1.0" encoding="utf-8"?>  
<VSTemplate Version="3.0.0" Type="Item" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <AppliesTo>CSharp | WindowsAppContainer</AppliesTo>   
    </TemplateData>  
</VSTemplate>  
  
<!--  Template 2 -->  
<?xml version="1.0" encoding="utf-8"?>  
<VSTemplate Version="3.0.0" Type="Item" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <AppliesTo>CSharp</AppliesTo>   
    </TemplateData>  
</VSTemplate>  
  
<!--  Template 1 -->  
<?xml version="1.0" encoding="utf-8"?>  
<VSTemplate Version="3.0.0" Type="Item" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://schemas.microsoft.com/developer/vstemplate/2005">  
    <TemplateData>  
        <AppliesTo>CSharp_Class + (!WindowsAppContainer)</AppliesTo>   
    </TemplateData>  
</VSTemplate>  
  
```  
  
## See Also  
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
