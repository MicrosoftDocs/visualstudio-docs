---
title: "How to: Locate and Organize Project and Item Templates | Microsoft Docs"
ms.custom: ""
ms.date: "12/29/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "project templates [Visual Studio], locations"
  - "custom template locations [Visual Studio]"
  - "item templates, locations"
  - "Visual Studio templates, locations"
  - "project templates [Visual Studio], displaying"
  - "templates [Visual Studio], locations"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: locate and organize project and item templates

Template files must be placed in a location that Visual Studio recognizes for the templates appear in the **New Project** and **Add New Item** dialog boxes. You can create custom subcategories for templates that will also appear in the dialog boxes.

## Locating templates

By default, Visual Studio searches two locations for project and item templates. If a compressed file that includes a .vstemplate file exists in these locations, the template will appear in the **New Project** or **Add New Item** dialog boxes.

### Installed templates

By default, templates installed with Visual Studio are located in:

- \\*VisualStudioInstallationDirectory*\Common7\IDE\ItemTemplates\\*Language*\\*Locale*\

- \\*VisualStudioInstallationDirectory*\Common7\IDE\ProjectTemplates\\*Language*\\*Locale\\*

For example, the following directory contains the Visual Basic item templates for English (1033):

C:\\*VisualStudioInstallationDirectory*\Common7\IDE\ItemTemplates\VisualBasic\1033\

### Custom templates

By default, custom templates are located in:

- \%USERPROFILE%\Documents\Visual Studio *Version*\Templates\ProjectTemplates\\*Language*\

- \%USERPROFILE%\Documents\Visual Studio *Version*\Templates\ItemTemplates\\*Language*\

For example, the following directory contains custom c# project templates:

C:\Users\UserName\Documents\Visual Studio *Version*\Templates\ProjectTemplates\Visual C#\

Custom templates do not include a subdirectory for localized templates.

You can change the default directory for custom templates in the **Options** dialog box, under **Projects and Solutions** > **Locations**.

## Organizing templates

The categories in the **New Project** and **Add New Item** dialog boxes reflect the directory structures that exist in the installed and custom template locations. You can modify these directory structures to organize your templates in a way that makes sense to you.

> [!NOTE]
> You cannot create a new category at the programming language level. New categories can only be created within each language.

If the directory structures for installed and custom templates for a particular language are not the same (that is, there are directories under one folder but not the other), all the categories are shown in the **New Project** dialog box.

### Organizing installed templates

You can organize installed templates by creating subdirectories in the programming language folder. These subdirectories appear in the **New Project** and **Add New Item** dialog boxes as virtual folders within each language.

#### To create new installed project template categories

1. Create a folder in the language folder of the installed template directory. For example, to create an Office category for Visual Basic project templates, create the following directory:

     \\*VisualStudioInstallationDirectory*\Common7\IDE\ProjectTemplates\VisualBasic\1033\Office\

1. Place all the templates for this category in the new folder.

1. Close all instances of Visual Studio.

1. Open a command prompt: on the **Start** menu, choose **Windows System** > **Command Prompt**.

1. At the command prompt, locate the directory that contains devenv.exe, and type `devenv /installvstemplates`.

1. Open Visual Studio, and on the **File** menu, choose **New** > **Project**.

   The Office category appears in the **New Project** dialog box, in the **Project types** pane, under Visual Basic.

You can also group a subset of the project item templates into a custom folder.

#### To create new installed item template categories

1. Create a folder in the language folder of the installed template directory. For example, to create a Web category for C# item templates, create the following directory:

    \\*VisualStudioInstallationDirectory*\Common7\IDE\ItemTemplates\CSharp\1033\Web\

1. Place all templates for this category in the new folder.

1. Close all instances of Visual Studio.

1. Open a command prompt: on the **Start** menu, choose **Windows System** > **Command Prompt**.

1. At the command prompt, locate the directory that contains devenv.exe, and type **devenv /setup**.

1. Open Visual Studio and create a new project or open an existing project.

1. On the **Project** menu, choose **Add New Item**.

   The Web category appears in the **Add New Item** dialog box, in the **Project types** pane.

### Organizing custom templates

Custom templates can be organized into their own categories by adding new folders in the custom template location. The **New Project** dialog box reflects any changes you make to your template categories.

#### To create new custom project template categories

1. Create a folder in the language folder in the custom project template directory. For example, to create a HelloWorld category for C# templates, create the following directory:

    \%USERPROFILE%\Documents\Visual Studio *Version*\Templates\ProjectTemplates\CSharp\HelloWorld\

1. Place all the templates for this category in the new folder.

1. On the **File** menu, choose **New** > **Project**.

   The HelloWorld category appears in the **New Project** dialog box, in the **Project types** pane under Visual C#.

You can also group a subset of the custom item templates into a custom folder.

#### To create new custom item template categories

1. Create a folder in the language folder in the custom item template directory. For example, to create a HelloWorld category for C# templates, create the following directory:

    \%USERPROFILE%\Documents\Visual Studio *Version*\Templates\ItemTemplates\CSharp\HelloWorld\

1. Place all the templates for this category in the new folder.

1. Create a project or open an existing project. Then, on the **Project** menu, choose **Add New Item**.

   The HelloWorld category appears in the **Add New Item** dialog box, in the **Project types** pane.

### Displaying templates in parent categories

You can enable templates in subcategories to be displayed in their parent categories by using the `NumberOfParentCategoriesToRollUp` element in the .vstemplate file. These steps are identical for project templates and item templates.

#### To display templates in parent categories

1. Locate the .zip file that contains the template.

1. Extract the .zip file.

1. Open the .vstemplate file in Visual Studio.

1. In the `TemplateData` element, add a `NumberOfParentCategoriesToRollUp` element. For example, the following code makes the template visible in the parent category, but no higher.

    ```xml
    <TemplateData>
        ...
        <NumberOfParentCategoriesToRollUp>
            1
        </NumberOfParentCategoriesToRollUp>
        ...
    </TemplateData>
    ```

1. Save and close the .vstemplate file.

1. Select the files in your template, right-click the selection, and choose **Send to** > **Compressed (zipped) folder**.

   The files are compressed into a .zip file.

1. Delete the extracted template files and the old template .zip file.

1. Put the new .zip file in the directory that had the deleted .zip file.

## See also

[Customizing Templates](../ide/customizing-project-and-item-templates.md)  
[Visual Studio Template Schema Reference (Extensibility)](../extensibility/visual-studio-template-schema-reference.md)  
[NumberOfParentCategoriesToRollUp (Visual Studio Templates)](../extensibility/numberofparentcategoriestorollup-visual-studio-templates.md)  
[How to: Create Project Templates](../ide/how-to-create-project-templates.md)  
[How to: Create Item Templates](../ide/how-to-create-item-templates.md)
