---
title: Locate templates
description: Learn how to locate and organize project and item templates.
ms.custom: SEO-VS-2020
ms.date: 01/02/2018
ms.topic: how-to
helpviewer_keywords:
- project templates [Visual Studio], locations
- item templates [Visual Studio], locations
- template locations [Visual Studio]
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
---
# How to: Locate and organize project and item templates

Template files must be placed in a known location in order for them to be shown in the new project and new item dialog boxes..

::: moniker range="vs-2017"

You can also create custom subcategories in the user template location, and the categories are shown in the **New Project** and **Add New Item** dialog boxes.

::: moniker-end

## Locate templates

Installed templates and user templates are stored in two different locations.

### Installed templates

By default, templates installed with Visual Studio are located in:

::: moniker range="vs-2017"

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2017\\\<edition>\\Common7\IDE\ProjectTemplates\\<Language\>\\<Locale ID\>*

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2017\\\<edition>\Common7\IDE\ItemTemplates\\<Language\>\\<Locale ID\>*

For example, the following directory has the Visual Basic item templates for English (LCID 1033):

*C:\\Program Files (x86)\\Microsoft Visual Studio\\2017\\Community\\Common7\\IDE\\ItemTemplates\\VisualBasic\\1033*

::: moniker-end

::: moniker range=">=vs-2019"

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2019\\\<edition>\\Common7\IDE\ProjectTemplates\\<Language\>\\<Locale ID\>*

- *%ProgramFiles(x86)%\\Microsoft Visual Studio\\2019\\\<edition>\Common7\IDE\ItemTemplates\\<Language\>\\<Locale ID\>*

For example, the following directory has the Visual Basic item templates for English (LCID 1033):

*C:\\Program Files (x86)\\Microsoft Visual Studio\\2019\\Community\\Common7\\IDE\\ItemTemplates\\VisualBasic\\1033*

::: moniker-end

### User templates

If you add a compressed (*.zip*) file that includes a *.vstemplate* file to the user template directory, the template appears in the new project and new item dialog boxes. By default, user templates are located in:

::: moniker range="vs-2017"

- *%USERPROFILE%\Documents\Visual Studio 2017\Templates\ProjectTemplates*

- *%USERPROFILE%\Documents\Visual Studio 2017\Templates\ItemTemplates*

For example, the following directory has user project templates for C#:

- *C:\Users\UserName\Documents\Visual Studio 2017\Templates\ProjectTemplates\Visual C#*

::: moniker-end

::: moniker range=">=vs-2019"

- *%USERPROFILE%\Documents\Visual Studio 2019\Templates\ProjectTemplates*

- *%USERPROFILE%\Documents\Visual Studio 2019\Templates\ItemTemplates*

For example, the following directory has user project templates for C#:

- *C:\Users\UserName\Documents\Visual Studio 2019\Templates\ProjectTemplates\Visual C#*

::: moniker-end

> [!TIP]
> You can change the known location for user templates in **Tools** > **Options** > **Projects and Solutions** > **Locations**.

::: moniker range="vs-2017"

## Organize templates

The categories in the **New Project** and **Add New Item** dialog boxes reflect the directory structures that exist in the installed template and user template locations. User templates can be organized into their own categories by adding new folders to the user template directory. The **New Project** and **Add New Item** dialog boxes show any changes you make to your user template categories.

> [!NOTE]
> You cannot create a new category at the programming language level. New categories can only be created within each language.

### Create new user project template categories

1. Create a folder in the programming language folder in the user project template directory. For example, to establish a **HelloWorld** category for C# project templates, create the following directory:

    - *\%USERPROFILE%\Documents\Visual Studio \<Version\>\Templates\ProjectTemplates\Visual C#\HelloWorld*

1. Place all the templates for this category in the new folder.

1. On the **File** menu, choose **New** > **Project**.

   The **HelloWorld** category appears in the **New Project** dialog box, under **Installed** > **Visual C#**.

### Create new user item template categories

1. Create a folder in the programming language folder in the user item template directory. For example, to establish a **HelloWorld** category for C# item templates, create the following directory:

    - *\%USERPROFILE%\Documents\Visual Studio \<Version\>\Templates\ItemTemplates\Visual C#\HelloWorld*

1. Place all the templates for this category in the new folder.

1. Create a project or open an existing project. Then, on the **Project** menu, choose **Add New Item**.

   The **HelloWorld** category appears in the **Add New Item** dialog box, under **Installed** > **Visual C# Items**.

### Display templates in parent categories

You can enable templates in subcategories to be displayed in their parent categories by using the `NumberOfParentCategoriesToRollUp` element in the *.vstemplate* file. These steps are the same for project templates and item templates.

1. Locate the *.zip* file that contains the template.

1. Extract the *.zip* file.

1. Open the *.vstemplate* file in Visual Studio.

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

1. Save and close the *.vstemplate* file.

1. Select the files in your template, right-click the selection, and choose **Send to** > **Compressed (zipped) folder**.

   The files are compressed into a *.zip* file.

1. Delete the extracted template files and the old template *.zip* file.

1. Put the new *.zip* file in the directory that had the deleted *.zip* file.

::: moniker-end

## See also

- [Customize templates](../ide/customizing-project-and-item-templates.md)
- [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)
- [NumberOfParentCategoriesToRollUp (Visual Studio templates)](../extensibility/numberofparentcategoriestorollup-visual-studio-templates.md)
- [How to: Create project templates](../ide/how-to-create-project-templates.md)
- [How to: Create item templates](../ide/how-to-create-item-templates.md)
