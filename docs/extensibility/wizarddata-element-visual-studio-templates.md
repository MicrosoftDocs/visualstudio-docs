---
title: WizardData Element (Visual Studio Templates)
description: Learn about the WizardData element and how it specifies a custom XML.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#WizardData
helpviewer_keywords:
- WizardData element [Visual Studio Templates]
- <WizardData> element [Visual Studio Templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# WizardData Element (Visual Studio Templates)

Specifies custom XML

```xml
\<VSTemplate>
\<WizardData>
```

## Syntax

```xml
<WizardData>
    <!-- XML to pass to the custom wizard extension -->
    ...
</WizardData>
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
|[VSTemplate](../extensibility/vstemplate-element-visual-studio-templates.md)|Required element.<br /><br /> Contains all the metadata for the project template, item template, or starter kit.|

## Text Value

A text value is optional.

This text specifies the custom XML to pass to the custom wizard extension specified in the [WizardExtension](../extensibility/wizardextension-element-visual-studio-templates.md) element.

## Remarks

Any XML can be specified in this element. The XML will be passed as a parameter to the custom wizard extension, allowing the extension to use the contents of this element. No validation is done on this data.

The contents of the **WizardData** element is passed, unchanged, as a parameter inside the string dictionary of parameters in the `IWizard.RunStarted` method. The dictionary key is named `$wizarddata$`.

## Example

The following example illustrates the metadata for the standard project template for a C# Windows application.

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
    <WizardData>
        <!-- XML to pass to the custom wizard extension -->
    </WizardData>
</VSTemplate>
```

## See also

- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
- [WizardExtension Element (Visual Studio Templates)](../extensibility/wizardextension-element-visual-studio-templates.md)
- [How to: Use Wizards with Project Templates](../extensibility/how-to-use-wizards-with-project-templates.md)
