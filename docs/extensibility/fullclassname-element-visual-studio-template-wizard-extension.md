---
title: "FullClassName element (VS template wizard extension)"
ms.date: "11/04/2016"
ms.technology: "vs-ide-general"
ms.topic: "conceptual"
f1_keywords:
  - "http://schemas.microsoft.com/developer/vstemplate/2005#FullClassName"
helpviewer_keywords:
  - "FullClassName element [Visual Studio project template]"
ms.assetid: 651e1010-d529-4856-85ff-c77ceca5d2ed
author: madskristensen
ms.author: madsk
manager: jillfra
ms.workload:
  - "vssdk"
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
 The following example illustrates the metadata for the standard project template for a [!INCLUDE[csprcs](../data-tools/includes/csprcs_md.md)] Windows application.

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