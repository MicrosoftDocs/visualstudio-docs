---
title: "How to: Locate and Organize Project and Item Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "project templates [Visual Studio], locations"
  - "custom template locations [Visual Studio]"
  - "item templates, locations"
  - "Visual Studio templates, locations"
  - "project templates [Visual Studio], displaying"
  - "templates [Visual Studio], locations"
ms.assetid: 71f9ed52-c9c9-4818-9bce-c279ffaa0438
caps.latest.revision: 28
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Locate and Organize Project and Item Templates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Template files must be placed in a location that Visual Studio recognizes so that the templates will appear in the **New Project** and **Add New Item** dialog boxes. You can create custom subcategories for templates so that the subcategories will also appear in the user interface.

## Locating Templates
 By default, Visual Studio searches two locations for project and item templates. If a compressed file that includes a .vstemplate file exists in these locations, a template will appear in the **New Project** or **Add New Item** dialog boxes.

### Installed Templates
 By default, templates installed together with the product are located in:

- \\*VisualStudioInstallationDirectory*\Common7\IDE\ItemTemplates\\*Language*\\*Locale*\

- \\*VisualStudioInstallationDirectory*\Common7\IDE\ProjectTemplates\\*Language*\\*Locale\\*

  For example, the following directory contains the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project templates for English:

  C:\\*VisualStudioInstallationDirectory*\Common7\IDE\ItemTemplates\VisualBasic\1033\

### Custom Templates
 By default, custom templates are located in:

- \My Documents\Visual Studio *Version*\Templates\ProjectTemplates\\*Language*\

- \My Documents\Visual Studio *Version*\Templates\ItemTemplates\\*Language*\

  For example, the following directory contains custom [!INCLUDE[csprcs](../includes/csprcs-md.md)] project templates:

  C:\Documents and Settings\UserName\My Documents\\<Visual Studio version\>\Templates\ProjectTemplates\Visual C#\

  Custom templates do not include a subdirectory for localized templates. You can change the default directory for custom templates in the **Options** dialog box, under **Environment\Projects and Solutions**.

## Organizing Templates
 The categories in the **New Project** and **Add New Item** dialog boxes reflect the directory structures that exist in the installed and custom template locations. You can modify these directory structures to organize your templates in a way that makes sense to you.

> [!NOTE]
> You cannot create a new category at the programming language level. New categories can only be created within each language.

 If the directory structures for installed and custom templates for a particular language do not have the same structure (that is, there are directories under one folder that do not exist under the other) the set of categories that appear in the **New Project** dialog will be the merger of all categories.

### Organizing Installed Templates
 You can organize installed templates by creating subdirectories in the programming language folder. These subdirectories appear in the **New Project** and **Add New Item** dialog boxes as virtual folders within each language.

##### To create new installed project template categories

1. Create a folder in the language folder of the installed template directory. For example, to create an Office category for [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project templates you would create the following directory:

    \\*VisualStudioInstallationDirectory*\Common7\IDE\ProjectTemplates\VisualBasic\1033\Office\

2. Place all the templates for this category in the new folder.

3. Close all instances of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

4. On the **Start** menu, click **Run**, type **cmd**, and click **OK**.

5. At the command prompt, locate the directory that contains devenv.exe, and type **devenv /installvstemplates**.

6. Run [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

7. On the **File** menu, click **New**, and then click **Project**.

8. Verify that the Office category appears in the **New Project** dialog box, in the **Project types** pane, under [!INCLUDE[vbprvb](../includes/vbprvb-md.md)].

   You can also group a subset of the project item templates into a custom folder.

##### To create new installed item template categories

1. Create a folder in the language folder of the installed template directory. For example, to create a Web category for [!INCLUDE[csprcs](../includes/csprcs-md.md)] item templates you would create the following directory:

     \\*VisualStudioInstallationDirectory*\Common7\IDE\ItemTemplates\CSharp\1033\Web\

2. Place all templates for this category in the new folder.

3. Close all instances of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

4. On the **Start** menu, click **Run**, type **cmd**, and click **OK**.

5. At the command prompt, locate the directory that contains devenv.exe, and type **devenv /setup**.

6. Run [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

7. Create a project or open an existing project.

8. On the **Project** menu, click **Add New Item**.

9. Verify that the Web category appears in the **Add New Item** dialog box, in the **Project types** pane.

### Organizing Custom Templates
 Custom templates can be organized into their own categories by adding new folders in the custom template location. The **New Project** dialog box reflects any changes you make to your template categories.

##### To create new custom project template categories

1. Create a folder in the language folder in the custom project template directory. For example, to create a HelloWorld category for [!INCLUDE[csprcs](../includes/csprcs-md.md)] templates, you would create the following directory:

    \My Documents\\<Visual Studio version\>\Templates\ProjectTemplates\CSharp\HelloWorld\

2. Place all the templates for this category in the new folder.

3. On the **File** menu, click **New**, and then click **Project**.

4. Verify that the HelloWorld category appears in the **New Project** dialog box, in the **Project types** pane, under [!INCLUDE[csprcs](../includes/csprcs-md.md)].

   You can also group a subset of the custom item templates into a custom folder.

##### To create new custom item template categories

1. Create a folder in the language folder in the custom item template directory. For example, to create a HelloWorld category for [!INCLUDE[csprcs](../includes/csprcs-md.md)] templates you would create the following directory:

     \My Documents\\<Visual Studio version\>\Templates\ItemTemplates\CSharp\HelloWorld\

2. Place all the templates for this category in the new folder.

3. Create a project or open an existing project.

4. On the **Project** menu, click **Add New Item**.

5. Verify that the HelloWorld category appears in the **Add New Item** dialog box, in the **Project types** pane.

### Displaying Templates in Parent Categories
 You can enable templates in subcategories to be displayed in their parent categories by using the `NumberOfParentCategoriesToRollUp` element in the .vstemplate file. These steps are identical for both project templates and item templates.

##### To display templates in parent categories

1. Locate the .zip file that contains the template.

2. Extract the .zip file.

3. Open the .vstemplate file in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

4. In the `TemplateData` element, add a `NumberOfParentCategoriesToRollUp` element. For example, the following code makes the template visible in the parent category, but no higher.

    ```
    <TemplateData>
        ...
        <NumberOfParentCategoriesToRollUp>
            1
        </NumberOfParentCategoriesToRollUp>
        ...
    </TemplateData>
    ```

5. Save and close the .vstemplate file.

6. Select the files in your template, right-click the selection, click **Send To**, and then click **Compressed (zipped) Folder**. The files are compressed into a .zip file.

7. Delete the extracted template files and the old template .zip file.

8. Put the new .zip file in the directory that had the deleted .zip file.

## See Also
 [Customizing Templates](../ide/customizing-project-and-item-templates.md)
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
 [NumberOfParentCategoriesToRollUp (Visual Studio Templates)](../extensibility/numberofparentcategoriestorollup-visual-studio-templates.md)
 [How to: Create Project Templates](../ide/how-to-create-project-templates.md)
 [How to: Create Item Templates](../ide/how-to-create-item-templates.md)
