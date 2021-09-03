---
title: Creating multi-file item templates
description: Learn how to create an item template in Visual Studio that is made up of multiple files.
ms.custom: SEO-VS-2020
ms.date: 01/02/2018
ms.topic: how-to
helpviewer_keywords:
- Visual Studio templates, creating multi-file item templates
- multi-file item templates
- item templates, creating multi-file item templates
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
---
# How to: Create multi-file item templates

Item templates may only specify one item, but sometimes the item is made up of multiple files. For example, a Windows Forms item template requires the following three files:

- A file that contains the code for the form

- A file that contains the designer information for the form

- A file that contains the embedded resources for the form

Multi-file item templates require parameters to ensure that the correct file extensions are used when the item is created. If you create a multi-file item template by using the **Export Template Wizard**, these parameters are automatically generated, and no further editing is required.

## Use the Export Template Wizard

You can create a multi-file item template in the same manner as you would a single-file item template. See [How to: Create item templates](../ide/how-to-create-item-templates.md). On the **Select Item To Export** page of the wizard, select the file that has dependent files (for example, a Windows Forms form file). The wizard automatically includes any dependent files, such as designer and resource files, in the template.

## Manually create a multi-file item template

1. Create the item template as you would manually create a single-file item template, but include each file that constitutes the multi-file item.

1. In the *.vstemplate* XML file, add a `ProjectItem` element for each individual file, and add a `TargetFileName` attribute to this element. Set the value of the `TargetFileName` attribute to *$fileinputname$.FileExtension*, where *FileExtension* is the file extension of the file that is being included in the template. For example:

    ```xml
    <ProjectItem TargetFileName="$fileinputname$.vb">
        Form1.vb
    </ProjectItem>
    <ProjectItem TargetFileName="$fileinputname$.Designer.vb">
        Form1.Designer.vb
    </ProjectItem>
    <ProjectItem TargetFileName="$fileinputname$.resx">
        Form1.resx
    </ProjectItem>
    ```

     > [!NOTE]
     > When an item derived from this template is added to a project, the file names will derive from the name that the user enters in the **Add New Item** dialog box.

1. Select the files to be included in your template, right-click the selection, and choose **Send to** > **Compressed (zipped) folder**.

   The files that you selected are compressed into a *.zip* file.

1. Copy the *.zip* file to the user item template location. By default, the directory is *%USERPROFILE%\Documents\Visual Studio \<Version\>\Templates\ItemTemplates*. For more information, see [How to: Locate and organize templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

1. Close Visual Studio and then reopen it.

1. Create a new project, or open an existing project, and then choose **Project** > **Add New Item** or press **Ctrl**+**Shift**+**A**.

   The multi-file item template appears in the **Add New Item** dialog box.

## Example

The following example shows a Windows Forms template. When an item is created based on this template, the names of the three files created will match the name entered in the **Add New Item** dialog box.

```xml
<VSTemplate Version="2.0.0" Type="Item"
    xmlns="http://schemas.microsoft.com/developer/vstemplate/2005">
    <TemplateData>
        <Name>Multi-file Item Template</Name>
        <Icon>Icon.ico</Icon>
        <Description>An example of a multi-file item template</Description>
        <ProjectType>VisualBasic</ProjectType>
    </TemplateData>
    <TemplateContent>
        <ProjectItem TargetFileName="$fileinputname$.vb" SubType="Form">
            Form1.vb
        </ProjectItem>
        <ProjectItem TargetFileName="$fileinputname$.Designer.vb">
            Form1.Designer.vb
        </ProjectItem>
        <ProjectItem TargetFileName="$fileinputname$.resx">
            Form1.resx
        </ProjectItem>
    </TemplateContent>
</VSTemplate>
```

## See also

- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [How to: Create item templates](../ide/how-to-create-item-templates.md)
- [Template parameters](../ide/template-parameters.md)
- [How to: Substitute parameters in a template](../ide/how-to-substitute-parameters-in-a-template.md)
