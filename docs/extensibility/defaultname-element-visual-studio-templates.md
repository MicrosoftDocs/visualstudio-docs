---
title: DefaultName Element (Visual Studio Templates) | Microsoft Docs
description: Learn about the DefaultName element and how it specifies the name that the Visual Studio project system will generate for the project or item when it is created.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#DefaultName
helpviewer_keywords:
- DefaultName element [Visual Studio project templates]
ms.assetid: 0ff056c8-b9d2-4747-9308-92adf1811491
author: leslierichardson95
ms.author: lerich
manager: jmartens
ms.workload:
- vssdk
---
# DefaultName element (Visual Studio templates)
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

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value
 A text value is required.

 This text specifies the default name of the project or item.

## Remarks
 `DefaultName` is an optional element.

 For projects, this element specifies the name of the directory that stores the project on disk. For items, it specifies the file name of the source file.

 When you create a project or item, you can modify the default name using the **Name** option, which is available from either the **New Project** dialog box or **Add New Item** dialog box.

 If you do not want the project system to generate the default name for the project or item, then set the [ProvideDefaultName](../extensibility/providedefaultname-element-visual-studio-templates.md) element to `False`.

## Example
 The following example illustrates the metadata for the standard item template for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] class.

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

## See also
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
