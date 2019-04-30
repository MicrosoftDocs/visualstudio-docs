---
title: Add or edit tags to project templates
ms.date: 04/30/2019
author: minsa110
ms.author: somin
manager: jillfra
ms.topic: conceptual
helpviewer_keywords:
  - "item templates, updating"
  - "Visual Studio templates, updating"
  - "project templates, updating"
  - "updating templates [Visual Studio]"
  - "template tagging, updating"
  - "template tags, updating"
---
# Add or edit tags to project templates

In [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/) (starting v16.1 Preview 2), you can add language, platform, and project type tags to your project templates, which will

1. Populate them under the template's description in the **New Project Dialog** </br>
    ![Project template with tags in the NPD](media/npd-item-with-template-tags.png "Project template with tags in the NPD")</br>
2. Enable the template to be searched and filtered by the added tags </br>
    ![Search and filter in the NPD](media/npd-search-and-filter.png "Search and filter in the NPD")

You can add tags by updating the *.vstemplate* XML file using template tags built into Visual Studio, or by creating custom template tags. Template tags will only appear in [Visual Studio 2019](https://visualstudio.microsoft.com/downloads/)'s New Project Dialog, and won't affect the template item rendering in previous versions of Visual Studio.

## Add or edit tags to your project templates

Access your project template's *.vstemplate* XML to add/edit tags when:

* Using the [Export Template Wizard](/visualstudio/ide/how-to-create-project-templates) to create a new project template
* Using the [VSIX Project template](/visualstudio/extensibility/getting-started-with-the-vsix-project-template) to create a new VSIX project template
* Updating your [existing project template](/visualstudio/ide/how-to-update-existing-templates)

## Syntax
```XML
<LanguageTag> Language Name </LanguageTag>
<PlatformTag> Platform Name </PlatformTag>
<ProjectTypeTag> Project Type </ProjectTypeTag>
```

```XML
<LanguageTag Package="{PackageID}" ID="ResourceID" />
<PlatformTag Package="{PackageID}" ID="ResourceID" />
<ProjectTypeTag Package="{PackageID}" ID="ResourceID" />
```

## Attributes and elements
The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|`Package`|Optional attribute, for advanced user scenarios.<br /><br /> A GUID that specifies the Visual Studio package ID.|
|`ID`|Optional attribute, for advanced user scenarios.<br /><br /> Specifies the Visual Studio resource ID.|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[TemplateData](../extensibility/templatedata-element-visual-studio-templates.md)|Required element.<br /><br /> Categorizes the template and defines how it displays in either the **New Project** or the **Add New Item** dialog box.|

## Text value
 A text value is required unless the `Package` and `ID` attributes are used.

 The text provides the name of the template.

## Built-in tags
Visual Studio offers a list of built-in tags that, when added, will render a localized resource. Here is a list of our built-in tags and corresponding values in parentheses.

| Language | Platform | Project Type |
| -- | -- | -- |
| C++ (`cpp`) | Android (`android`) | Cloud (`cloud`) |
| C# (`csharp`) | Azure (`azure`) | Console (`console`) |
| F# (`fsharp`) | iOS (`ios`) | Desktop (`desktop`) |
| Java (`java`) | Linux (`linux`) | Extensions (`extension`) |
| JavaScript (`javascript`) | macOS (`macos`) | Games (`games`) |
| Python (`python`) | tvOS (`tvos`) | IoT (`iot`) |
| Query Languate (`querylanguage`) | Windows (`windows`) | Library (`library`) |
| TypeScript (`typescript`) | Xbox (`xbox`) | Machine Learning (`machinelearning`) |
| Visual Basic (`visualbasic`) | | Mobile (`mobile`) |
| | | Office (`office`) |
| | | Other (`other`) |
| | | Service (`service`) |
| | | Test (`test`) |
| | | UWP (`uwp`) |
| | | Web (`web`) |

## Example

The following example shows the metadata for a project template for a Visual C# application.

```xml
<VSTemplate Type="Project" Version="3.0.0"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>My template</Name>
        <Description>A basic template</Description>
        <Icon>TemplateIcon.ico</Icon>
        <ProjectType>CSharp</ProjectType>
        <LanguageTag>C#</LanguageTag>
        <PlatformTag>windows</PlatformTag> 
        <PlatformTag>linux</PlatformTag> 
        <PlatformTag>My Platform</PlatformTag> 
        <ProjectTypeTag>console</ProjectTypeTag>
        <ProjectTypeTag>desktop</ProjectTypeTag>
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
</VSTemplate>
```

## See also
- [Visual Studio template schema reference](/visualstudio/extensibility/visual-studio-template-schema-reference)
- [Creating project and item templates](/visualstudio/ide/creating-project-and-item-templates)
- [Customize project and item templates](/visualstudio/ide/customizing-project-and-item-templates)
- [Getting Started with the VSIX Project Template](/visualstudio/extensibility/getting-started-with-the-vsix-project-template)