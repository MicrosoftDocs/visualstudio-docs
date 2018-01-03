---
title: "Update existing project and item templates in Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "item templates, updating"
  - "Visual Studio templates, updating"
  - "project templates, updating"
  - "updating templates [Visual Studio]"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: Update existing templates

After you create a template and compress the files into a .zip file, you may want to modify the template. You can do this by manually changing the files in the template, or by exporting a new template from a project that is based on the template.

## Using the Export Template Wizard to update an existing project template

Visual Studio provides an **Export Template Wizard** that can be used to update an existing template:

1. Open the **New Project** dialog box by choosing **File** > **New** > **Project**.

1. Select the template that you want to update, enter a name and location for your project, and choose **OK**.

1. Modify the project in Visual Studio.

1. On the **Project** menu, choose **Export Template...**.

    The **Export Template Wizard** opens.

1. Follow the prompts in the wizard to export the template as a .zip file.

1. (Optional) To add the template to the **New Project** dialog box, place the .zip file in the following directory: %USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates. You'll need to perform this step if you did not select the option **Automatically import the template into Visual Studio** in the **Export Template Wizard**.

1. Delete the old template .zip file.

## Manually updating an existing template

You can update an existing template without using the **Export Template Wizard**, by modifying the files in the compressed .zip file.

### To manually update an existing template

1. Locate the .zip file that contains the template. User project templates are usually located at %USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ProjectTemplates.

1. Extract the .zip file.

1. Modify or delete the current template files, or add new files to the template.

1. Open, modify, and save the .vstemplate XML file to handle updated behavior or new files.

    For more information about the .vstemplate schema, see [Visual Studio template schema reference (Extensibility)](../extensibility/visual-studio-template-schema-reference.md). For more information about what you can parameterize in the source files, see [Template parameters](../ide/template-parameters.md).

1. Select the files in your template, and from the right-click or context menu, and choose **Send to** > **Compressed (zipped) folder**.

    The files that you selected are compressed into a .zip file.

1. Put the new .zip file in the same directory as the old .zip file.

1. Delete the extracted template files and the old template .zip file.

## See also

[Customizing Templates](../ide/customizing-project-and-item-templates.md)  
[Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)  
[Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)  
[Template Parameters](../ide/template-parameters.md)  
[How to: Create Starter Kits](../ide/how-to-create-starter-kits.md)