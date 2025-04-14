---
title: Update existing project or item templates
description: Use the Visual Studio Export Template Wizard or a manual process to update existing project or item templates.
ms.date: 04/14/2025
ms.topic: how-to
helpviewer_keywords:
- item templates, updating
- Visual Studio templates, updating
- project templates, updating
- updating templates [Visual Studio]
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Update existing project or item templates

After you create a Visual Studio project or item template by compressing the template files into a *.zip* file, you might want to modify the template. This article explains how to modify an existing template by exporting a new template from a project that's based on the template, or by manually changing the files in the template.

## Use the Export Template Wizard

You can use the Visual Studio **Export Template Wizard** to update an existing template.

1. Choose **File** > **New** > **Project** from the menu bar.
1. Select an existing project template that you want to update, and create the new project.
1. Modify the project in Visual Studio. For example, change the output type or add a new file to the project.
1. To change an item template, select **Project** > **Add New Item**, and add the item template from the **Add New Item** dialog box. Make any changes you want in the item.
1. On the **Project** menu, choose **Export Template**. The **Export Template Wizard** opens.
1. Select either **Project Template** or **Item Template** on the **Template Type** page, and follow the prompts in the wizard to export the template as a *.zip* file.
1. If you select the option to **Automatically import the template into Visual Studio** in the **Export Template Wizard**, the wizard places the *.zip* file in the *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates* or *\\ItemTemplates* folder to make it available for selection in future projects. If you didn't select the option, paste the *.zip* file in the user template location manually.
1. Delete the old template *.zip* file if necessary.

## Manually update an existing template

You can update an existing template without using the **Export Template Wizard** by manually modifying the files in the template *.zip* file.

1. Locate the *.zip* file that contains the template. User templates are located at *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates* or *\\ItemTemplates*.
1. Extract the *.zip* file.
1. Modify or delete the current template files, or add new files to the template.
1. Open, modify, and save the *.vstemplate* XML file to handle updated behavior or new files.

    For more information about the *.vstemplate* schema, see [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md). For more information about what you can parameterize in the source files, see [Template parameters](template-parameters.md).

1. In Windows Explorer, select the files for your template, including the *.vstemplate* file. Right-click the selection and select **Compress to** > **ZIP File**.
1. Copy the resulting *.zip* file and paste it in the same directory as the old *.zip* file.
1. Delete the extracted template files and delete the old template *.zip* file if necessary.

## Related content

- [Customize templates](customizing-project-and-item-templates.md)
- [Create project and item templates](creating-project-and-item-templates.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Template parameters](template-parameters.md)
