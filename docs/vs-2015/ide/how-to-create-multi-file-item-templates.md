---
title: "How to: Create Multi-file Item Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "Visual Studio templates, creating multi-file item templates"
  - "multi-file item templates"
  - "item templates, creating multi-file item templates"
ms.assetid: fe3c4257-e383-4c80-b8af-c5c521959c33
caps.latest.revision: 15
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Multi-file Item Templates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Item templates may only specify one item, but sometimes the item is made up of multiple files. For example, a Windows Forms item template for Visual Basic requires the following three files:

- A .vb file that contains the code for the form.

- A .designer.vb file that contains the designer information for the form.

- A .resx file that contains the embedded resources for the form.

  Multi-file item templates require parameters to ensure the correct file name extensions are used when the item is created in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)]. If you create an item template by using the **Export Template** wizard, these parameters are automatically generated, and no further editing is required. The following steps explain how to use parameters to ensure that the correct file name extensions are created.

### To manually create a multi-file item template

1. Create the item template as you would create a single-file item template. For more information, see [How to: Create Item Templates](../ide/how-to-create-item-templates.md).

2. Add `TargetFileName` attributes to every `ProjectItem` element. Set the values of the `TargetFileName` attributes to $fileinputname$.*FileExtension*, where *FileExtension* is the file name extension of the file that is being included in the template. For example:

    ```
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

     When an item derived from this template is added to a project, the file names will be based on the name that the user typed in the **Add New Item** dialog box.

3. Select the files to be included in your template, right-click the selection, click **Send To**, and then click **Compressed (zipped) Folder**. The files that you selected are compressed into a .zip file.

4. Put the .zip file in the user item template location. By default, the directory is \My Documents\Visual Studio *Version*\Templates\ItemTemplates\\. For more information, see [How to: Locate and Organize Templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

## Example
 The following example shows a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Windows Forms template. When an item is created based on this template, the names of the three files created will match the name entered in the **Add New Item** dialog box.

```
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

## See Also
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
 [How to: Create Item Templates](../ide/how-to-create-item-templates.md)
 [Template Parameters](../ide/template-parameters.md)
 [How to: Substitute Parameters in a Template](../ide/how-to-substitute-parameters-in-a-template.md)
