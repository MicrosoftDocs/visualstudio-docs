---
title: SupportsMasterPage Element (Visual Studio Templates)
description: Learn about the SupportsMasterPage element and how it specifies whether the or not the Select Master Page checkbox is enabled on the Add New Item dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#SupportsMasterPage
helpviewer_keywords:
- <SupportsMasterPage> element [Visual Studio Templates]
- SupportsMasterPage element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# SupportsMasterPage Element (Visual Studio Templates)

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

## See also
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
