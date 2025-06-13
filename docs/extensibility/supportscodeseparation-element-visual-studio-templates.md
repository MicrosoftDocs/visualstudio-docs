---
title: SupportsCodeSeparation Element (Visual Studio Templates)
titleSuffix: ""
description: Learn about the SupportsCodeSeparation element and how it specifies if the Place code in separate file check box is enabled in the Add New Item dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#SupportsCodeSeparation
helpviewer_keywords:
- SupportsCodeSeparation element [Visual Studio Templates]
- <SupportsCodeSeparation> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# SupportsCodeSeparation Element (Visual Studio Templates)

Specifies whether or not the **Place code in separate file** check box is enabled in the **Add New Item** dialog box.

 \<VSTemplate>
 \<TemplateData>
 \<SupportsCodeSeparation>

## Syntax

```
<SupportsCodeSeparation> true/false </SupportsCodeSeparation>
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **New Item** dialog box.|

## Text Value
 A text value is required.

 The text must be either `true` or `false`, indicating whether or not the **Place code in separate file** check box is enabled in the **Add New Item** dialog box.

## Remarks
 `SupportsCodeSeparation` is an optional element. The default value is `false`.

 The `SupportsCodeSeparation` element is only available for Web item templates.

 Code separation, or the code-behind page model, allows you to keep the markup in one file and the programming code in another file. ASP.NET and other .NET languages use this model.

## Example
 The following example specifies to display the **Place code in separate file** option.

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
        <SupportsCodeSeparation>true</SupportsCodeSeparation>
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

## See also
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
