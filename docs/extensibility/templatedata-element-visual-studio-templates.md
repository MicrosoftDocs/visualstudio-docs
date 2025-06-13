---
title: TemplateData Element (Visual Studio Templates)
description: Learn about the TemplateData element and how it categorizes the template and defines how it displays in either the New Project or the Add New Item dialog box.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#TemplateData
helpviewer_keywords:
- TemplateData element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# TemplateData Element (Visual Studio Templates)

Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.

 \<VSTemplate>
 \<TemplateData>

## Syntax

```
<TemplateData>
    <Name> ... </Name>
    <Description> ... </Description>
    <Icon> ... </Icon>
    <ProjectType> ... </ProjectType>
    ...
</TemplateData>
```

## Attributes and Elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes
 None.

### Child Elements

| Element | Description |
| - | - |
| [Name](../extensibility/name-element-visual-studio-templates.md) | Required element.<br /><br /> Specifies the name of the template as it appears in either the **New Project** or the **Add New Item** dialog box. |
| [Description](../extensibility/description-element-visual-studio-templates.md) | Required element.<br /><br /> Specifies the description of the template as it appears in either the **New Project** or the **Add New Item** dialog box. |
| [Icon](../extensibility/icon-element-visual-studio-templates.md) | Required element.<br /><br /> Specifies the path and the filename of the image file that serves as the icon, which appears in either the **New Project** or the **Add New Item** dialog box, for the template. |
| [ProjectType](../extensibility/projecttype-element-visual-studio-templates.md) | Required element.<br /><br /> Categorizes the project template so that it appears under the specified group in the **New Project** dialog box. |
| [ProjectSubType](../extensibility/projectsubtype-element-visual-studio-templates.md) | Optional element.<br /><br /> Classifies the project template so that it appears under the specified subcategory in the **New Project** dialog box. |
| [TemplateID](../extensibility/templateid-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies the template ID. |
| [TemplateGroupID](../extensibility/templategroupid-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies the template group ID. |
| [SortOrder](../extensibility/sortorder-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies a value that is used to arrange the template, among other templates in the same category, as it appears in either the **New Project** or **Add New Item** dialog box. |
| [CreateNewFolder](../extensibility/createnewfolder-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether a containing folder is created on instantiation of the project. |
| [DefaultName](../extensibility/defaultname-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies the name that the Visual Studio project system will generate for the project or item when it is created. |
| [ProvideDefaultName](../extensibility/providedefaultname-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether the Visual Studio project system will generate the default name for a project or item when it is created. |
| [PromptForSaveOnCreation](../extensibility/promptforsaveoncreation-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether the project can be created as a temporary project (Visual Studio 2017 only). |
| [EnableLocationBrowseButton](../extensibility/enablelocationbrowsebutton-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether the **Browse** button is available in the **New Project** dialog box, so that users can easily modify the default directory where a new project is saved. |
| [Hidden](../extensibility/hidden-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether the template appears in either the **New Project** or **Add New Item** dialog box. |
| [NumberOfParentCategoriesToRollUp](../extensibility/numberofparentcategoriestorollup-visual-studio-templates.md) | Optional element.<br /><br /> Specifies the number of parent categories that will display the template in the **New Project** dialog box. |
| [LocationFieldMRUPrefix](../extensibility/locationfieldmruprefix-element-visual-studio-templates.md) | Optional element. |
| [LocationField](../extensibility/locationfield-element-visual-studio-project-templates.md) | Optional element.<br /><br /> Specifies whether or not the **Location** text box in the **New Project** dialog box is either enabled, disabled, or hidden for the project template. |
| [RequiredFrameworkVersion](../extensibility/requiredframeworkversion-element-visual-studio-templates.md) | Optional element.<br /><br /> Use this element if the template only supports a specific minimum version, and later versions if any, of the .NET Framework. |
| [SupportsMasterPage](../extensibility/supportsmasterpage-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether the template supports a master page for web projects. |
| [SupportsCodeSeparation](../extensibility/supportscodeseparation-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether the template supports code separation, or the code-behind page model, for web projects. |
| [SupportsLanguageDropDown](../extensibility/supportslanguagedropdown-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies whether the template is identical for multiple languages, and whether the **Language** option is available from the **New Project** dialog box. |
| [TargetPlatformName](../extensibility/targetplatformname-element-visual-studio-templates.md) | Optional element.<br /><br /> Specifies the platform that the project template targets. This element specifies that a project template is used to create Windows 8.x Store apps. |

### Parent Elements

|Element|Description|
|-------------|-----------------|
|[VSTemplate](../extensibility/vstemplate-element-visual-studio-templates.md)|Required element.<br /><br /> Contains all the metadata for the project template, item template, or starter kit.|

## Remarks
 `TemplateData` is a required element.

 If you do not include an optional element, the default value for that element is used.

## Example
 The following example shows the metadata for a project template for a Visual C# application.

```
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic starter kit</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
    </TemplateData>
    <TemplateContent>
        <Project File="MyStarterKit.csproj">
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
</VSTemplate>
```

## See also
- [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
- [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
