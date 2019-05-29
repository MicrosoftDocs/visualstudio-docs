---
title: "Assembly Element (Visual Studio Template Wizard Extension) | Microsoft Docs"
ms.date: "11/04/2016"
ms.technology: vs-ide-general
ms.topic: reference
f1_keywords:
  - "http://schemas.microsoft.com/developer/vstemplate/2005#Assembly"
helpviewer_keywords:
  - "Assembly element [Visual Studio Template Wizard Extension]"
  - "<Assembly> element [Visual Studio Template Wizard Extension]"
ms.assetid: 0c3dc280-1753-4ea2-a13c-d31d13b935b2
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
---
# Assembly element (Visual Studio template wizard extension)
Specifies the name or strong name of the assembly that implements the `IWizard` interface.

 \<VSTemplate>
\<WizardExtension>
\<Assembly>

## Syntax

```
<Assembly>AssemblyName</Assembly>
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

 This text specifies the assembly that implements the `IWizard` interface. This assembly name must be specified as a full assembly name. For example, `MyAssembly, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11dd0a3a, Custom = null`.

## Remarks
 `Assembly` is a required child element of `WizardExtension`.

## Example
 The following example illustrates the metadata for the standard project template for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] Windows application.

```xml
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
            <ProjectItem>Form1.cs</ProjectItem>
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
        <Assembly>MyWizard, Version=1.0.3300.0, Culture=neutral, PublicKeyToken=b03f5f7f11dd0a3a, Custom=null</Assembly>
        <FullClassName>MyWizard.CustomWizard</FullClassName>
    </WizardExtension>
</VSTemplate>
```

## See also

- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating project and item templates](../ide/creating-project-and-item-templates.md)
- [How to: Use wizards with project templates](../extensibility/how-to-use-wizards-with-project-templates.md)