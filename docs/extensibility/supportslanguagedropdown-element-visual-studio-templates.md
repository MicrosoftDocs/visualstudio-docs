---
title: SupportsLanguageDropDown Element (Visual Studio Templates)
titleSuffix: ""
description: Learn about the SupportsLanguageDropDown element and how it specifies whether the Web item template is identical for multiple languages, and if the Language option is enabled.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#SupportsLanguageDropDown
helpviewer_keywords:
- SupportsLanguageDropDown element [Visual Studio Templates]
- <SupportsLanguageDropDown> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# SupportsLanguageDropDown Element (Visual Studio Templates)

Specifies whether the Web item template is identical for multiple languages, and whether the **Language** option is enabled on the **Add New Item** dialog box.

 \<VSTemplate>
 \<TemplateData>
 \<SupportsLanguageDropDown>

## Syntax

```xml
<SupportsLanguageDropDown> true/false </SupportsLanguageDropDown>
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
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text Value

 A text value is required.

 The text must be either `true` or `false`, indicating whether or not the **Language** option is available from the **Add New Item** dialog box.

## Remarks

 `SupportsLanguageDropDown` is an optional element. The default value is `false`.

 The `SupportsLanguageDropDown` element is only available for Web item templates.

 If the value for this element is set to `true`, then the item template is identical for all programming languages and the **Language** option is enabled in the **Add New Item** dialog box. This option enables you to choose the programming language of the new item that you want to create from the template.

## Example

 The following example specifies to display the **Language** drop down option.

```xml
<VSTemplate Version="3.0.0" Type="Project"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">>
    <TemplateData>
        <Name>MyWebProjecStarterKit</Name>
        <Description>A simple Web template</Description>
        <Icon>icon.ico</Icon>
        <ProjectType>Web</ProjectType>
        <ProjectSubType>CSharp</ProjectSubType>
        <DefaultName>WebSite</DefaultName>
        <SupportsLanguageDropDown>true</SupportsLanguageDropDown>
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
