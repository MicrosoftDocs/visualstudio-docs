---
title: FullClassName element (VS template wizard extension)
description: Learn about the FullClassName element and how its the fully qualified name of the class that implements the IWizard interface.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#FullClassName
helpviewer_keywords:
- FullClassName element [Visual Studio project template]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# FullClassName element (Visual Studio template wizard extension)

The fully qualified name of the class that implements the `IWizard` interface.

 \<VSTemplate>
 \<WizardExtension>
 ...
 \<FullClassName>

## Syntax

```xml
<FullClassName>ClassName</FullClassName>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes
 None.

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[WizardExtension](../extensibility/wizardextension-element-visual-studio-templates.md)|Contains the registration elements for customizing the template wizard.|

## Text value
 A text value is required.

 This text specifies the class that implements the `IWizard` interface. The specified class must exist in the assembly specified by the [Assembly](../extensibility/assembly-element-visual-studio-template-wizard-extension.md) element.

## Remarks
 `FullClassName` is a required child element of `WizardExtension`.

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
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [How to: Use wizards with project templates](../extensibility/how-to-use-wizards-with-project-templates.md)
