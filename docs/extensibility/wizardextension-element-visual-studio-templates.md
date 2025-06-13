---
title: WizardExtension Element (Visual Studio Templates)
description: Learn about the WizardExtension element and how it contains the registration elements for customizing the template wizard.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#WizardExtension
helpviewer_keywords:
- WizardExtension element [Visual Studio Templates]
- <WizardExtension> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# WizardExtension Element (Visual Studio Templates)

Contains the registration elements for customizing the template wizard.

 \<VSTemplate>
 ...
 \<WizardExtension>

## Syntax

```
<WizardExtension>
    <Assembly>... </Assembly>
    <FullClassName>... </FullClassName>
</WizardExtension>
```

## Attributes and Elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes
 None.

### Child Elements

|Element|Description|
|-------------|-----------------|
|[Assembly](../extensibility/assembly-element-visual-studio-template-wizard-extension.md)|Required element.<br /><br /> Specifies the name or strong name of an assembly that appears in the global assembly cache. There must be at least one `Assembly` element in a `WizardExtension` element.|
|[FullClassName](../extensibility/fullclassname-element-visual-studio-template-wizard-extension.md)|Required element.<br /><br /> The fully qualified name of the class that implements the `IWizard` interface. There must be at least one `FullClassName` element in a `WizardExtension` element.|

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[VSTemplate](../extensibility/vstemplate-element-visual-studio-templates.md)|Contains all the metadata for the project template, item template, or starter kit.|

## Remarks
 `WizardExtension` is an optional child element of `VSTemplate`.

## Example
 The following example illustrates the metadata for the standard project template for a Visual C# Windows application.

```
<VSTemplate Version="3.0.0" Type="Item"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>MyTemplate</Name>
        <Description>Template using IWizard extension</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
    </TemplateData>
    <TemplateContent>
        <Project File="MyTemplate.csproj">
            <ProjectItem>Form1.cs<ProjectItem>
            <ProjectItem>Form1.Designer.cs</ProjectItem>
            <ProjectItem>Program.cs</ProjectItem>
            <ProjectItem>Properties\AssemblyInfo.cs</ProjectItem>
            <ProjectItem>Properties\Resources.resx</ProjectItem>
            <ProjectItem>Properties\Resources.Designer.cs</ProjectItem>
            <ProjectItem>Properties\Settings.settings</ProjectItem>
            <ProjectItem>Properties\Settings.Designer.cs</ProjectItem>
        </Project>
    </TemplateContent>
    <WizardExtension>
        <Assembly>MyWizard, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a, Custom=null</Assembly>
        <FullClassName>MyWizard.CustomWizard</FullClassName>
    </WizardExtension>
</VSTemplate>
```

## See also
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
- [How to: Use Wizards with Project Templates](../extensibility/how-to-use-wizards-with-project-templates.md)
