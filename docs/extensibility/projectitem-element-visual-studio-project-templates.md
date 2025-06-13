---
title: ProjectItem Element (Visual Studio Project Templates)
description: Learn about the ProjectItem element for project templates and how it accepts different attributes depending on whether the template is for a project or an item.
ms.date: 11/04/2016
ms.subservice: general-ide
ms.topic: reference
f1_keywords:
- http://schemas.microsoft.com/developer/vstemplate/2005#ProjectItem
helpviewer_keywords:
- ProjectItem element [Visual Studio project templates]
- <ProjectItem> element [Visual Studio project templates]
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
---
# ProjectItem element (Visual Studio project templates)

Specifies a file that is included in the project template.

> [!NOTE]
> The `ProjectItem` element accepts different attributes depending on whether the template is for a project or an item. This topic explains the `ProjectItem` element for project templates. For an explanation of the `ProjectItem` element for item templates, see [ProjectItem Element (Visual Studio Item Templates)](../extensibility/projectitem-element-visual-studio-item-templates.md).

 \<VSTemplate>
 \<TemplateContent>
 \<Project>
 \<ProjectItem>

## Syntax

```
<ProjectItem
    TargetFileName="TargetFileName.ext"
    ReplaceParameters="true/false"
    OpenInEditor="true/false"
    OpenInWebBrowser="true/false"
    OpenInHelpBrowser="true/false"
    OpenOrder="Value">
        FileName.ext
</ProjectItem>
```

## Attributes and elements
 The following sections describe attribute, child elements, and parent elements.

### Attributes

| Attribute | Description |
|---------------------| - |
| `TargetFileName` | Optional attribute.<br /><br /> Specifies the name and path of the project item when a project is created from the template. This attribute is useful for creating a directory structure different from the directory structure in the template *.zip* file, or for using parameter replacement to create an item name. |
| `ReplaceParameters` | Optional attribute.<br /><br /> A Boolean value that specifies whether the item has parameter values that must be replaced when a project is created from the template. Default value is `false`. |
| `OpenInEditor` | Optional attribute.<br /><br /> A Boolean value that specifies whether the item should be opened in its respective editor in Visual Studio when a project is created from the template.<br /><br /> The `OpenInWebBrowser` and `OpenInHelpBrowser` attributes are ignored on an item with an `OpenInEditor` value of `true`.<br /><br /> The default value is `false`. |
| `OpenInWebBrowser` | Optional attribute.<br /><br /> A Boolean value that specifies whether the item should be opened the Web browser when a project is created from the template.<br /><br /> Only HTML files and text files that are local to the project can be opened in the Web browser. External URLs cannot be opened with this attribute.<br /><br /> The default value is `false`. |
| `OpenInHelpBrowser` | Optional attribute.<br /><br /> A Boolean value that specifies whether the item should be opened in the Help viewer when a project is created from the template.<br /><br /> Only HTML files and text files that are local to the project can be opened in the Help browser. External URLs cannot be opened with this attribute.<br /><br /> The default value is `false`. |
| `OpenOrder` | Optional attribute.<br /><br /> Specifies a numeric value that represents the order that items will be opened in their respective editors. All values must be multiples of 10. Items with higher `OpenOrder` values are opened first. |

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[Project](../extensibility/project-element-visual-studio-templates.md)|Specifies the files or directories to add to the project.|

## Text value
 A text value is required.

 A `string` that represents the name or path to a file in the template *.zip* file.

## Remarks
 `ProjectItem` is an optional child of `Project`.

 The `TargetFileName` attribute can be used to create a directory structure different from the directory structure in the template *.zip* file. For example, if the file *MyFile.vb* exists in the root of the template *.zip* file, but you want the file to be placed in a directory named *CustomFiles* in all projects created from the template, you would use the following XML:

```xml
<ProjectItem TargetFileName="CustomFiles\MyFile.vb">MyFile.vb</ProjectItem>
```

 The `TargetFileName` attribute can also be used to rename files that contain international characters in their filenames. For example, a template *.zip* file cannot contain file names with Unicode characters, so the file must be renamed before it can be compressed into a *.zip* file. The `TargetFileName` attribute can be used to set the file name back to the original Unicode file name.

 The `TargetFileName` attribute can also be used to rename files with parameters. The following procedure explains how to rename the file *MyFile.vb*, which exists in the root directory of the template *.zip* file, to a file name based on the project name.

### To rename files with parameters

1. Use the following XML in the *.vstemplate* file:

   ```xml
   <ProjectItem TargetFileName="$safeprojectname$.vb">MyFile.vb</ProjectItem>
   ```

2. Open the project file (*.vbproj* for a Visual Basic project) in a text editor or Visual Studio.

3. Locate the line in the project file that looks similar to the following XML:

   ```xml
   <Compile Include="MyFile.vb">
   ```

4. Replace the line of code with the following XML:

   ```xml
   <Compile Include="$safeprojectname$.vb">
   ```

    When a project is created from this template, the file name will be based on the name the user entered in the **New Project** dialog box, with all unsafe characters and spaces removed. For more information, see [Template parameters](../ide/template-parameters.md).

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
            <ProjectItem ReplaceParameters="true">Form1.cs<ProjectItem>
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
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [Template parameters](../ide/template-parameters.md)
- [ProjectItem element (Visual Studio item templates)](../extensibility/projectitem-element-visual-studio-item-templates.md)
