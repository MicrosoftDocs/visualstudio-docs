---
title: Update existing project item templates
ms.date: 01/02/2018
ms.topic: conceptual
helpviewer_keywords:
  - "item templates, updating"
  - "Visual Studio templates, updating"
  - "project templates, updating"
  - "updating templates [Visual Studio]"
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Update existing templates

After you create a template and compress the files into a *.zip* file, you may want to modify the template. You can do this by manually changing the files in the template or by exporting a new template from a project that's based on the template.

## Use the Export Template Wizard

Visual Studio provides an **Export Template Wizard** that can be used to update an existing template:

1. Choose **File** > **New** > **Project** from the menu bar.

1. Select the template that you want to update and continue through the steps to create the new project.

1. Modify the project in Visual Studio. For example, change the output type or add a new file to the project.

1. On the **Project** menu, choose **Export Template**.

    The **Export Template Wizard** opens.

1. Follow the prompts in the wizard to export the template as a *.zip* file.

1. (Optional) Place the *.zip* file in the following directory: *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates* to make it available for selection. You'll need to perform this step if you did not select the option **Automatically import the template into Visual Studio** in the **Export Template Wizard**.

1. Delete the old template *.zip* file.

## Manually update an existing template

You can update an existing template without using the **Export Template Wizard**, by modifying the files in the compressed *.zip* file.

### To manually update an existing template

1. Locate the *.zip* file that contains the template. User project templates are located at *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates*.

1. Extract the *.zip* file.

1. Modify or delete the current template files, or add new files to the template.

1. Open, modify, and save the *.vstemplate* XML file to handle updated behavior or new files.

    For more information about the *.vstemplate* schema, see [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md). For more information about what you can parameterize in the source files, see [Template parameters](../ide/template-parameters.md).

1. Select the files in your template, and from the right-click or context menu, and choose **Send to** > **Compressed (zipped) folder**.

    The files that you selected are compressed into a *.zip* file.

1. Put the new *.zip* file in the same directory as the old *.zip* file.

1. Delete the extracted template files and the old template *.zip* file.

## See also

- [Customize templates](../ide/customizing-project-and-item-templates.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [Visual Studio template schema reference](../extensibility/visual-studio-template-schema-reference.md)
- [Template parameters](../ide/template-parameters.md)