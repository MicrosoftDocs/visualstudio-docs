---
title: "How to: Create Project Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
f1_keywords:
  - "VS.ExportTemplateWizard"
helpviewer_keywords:
  - "Visual Studio templates, creating project templates"
  - "project templates, metadata files"
  - "Visual Studio templates, project templates"
  - "project templates, custom template locations"
  - "project templates, creating"
ms.assetid: a1a6999d-a34c-48a8-b1cf-027eb5c76398
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Project Templates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This procedure enables you to create a template using the **Export Template** wizard, which packages your template in a .zip file. You can also create templates in the VSIX file format for improved deployment by using the Export Template Wizard extension, or with templates included in the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)], or you can create templates manually.

### To create a custom project template with the standard Export Template wizard

1. Create a project.

    > [!NOTE]
    > Use only valid identifier characters when naming a project that will be the source for a template. A template exported from a project named with invalid characters can cause compilation errors in future projects based on the template. For more information on valid identifier characters, see [Declared Element Names](https://msdn.microsoft.com/library/09d8843b-c0dc-4afe-9dab-87c439a69e66).

2. Edit the project until it is ready to be exported as a template.

3. As appropriate, edit the code files to indicate where parameter replacement should take place. For more information on parameter replacement, see [How to: Substitute Parameters in a Template](../ide/how-to-substitute-parameters-in-a-template.md).

4. On the **File** menu, click **Export Template**. The **Export Template** wizard opens.

5. Click **Project Template**.

6. If you have more than one project in your current solution, select the projects you want to export to a template.

7. Click **Next**.

8. Select an icon and a preview image for your template. These will appear in the **New Project** dialog box.

9. Enter a template name and description.

10. Click **Finish**. Your project is exported into a .zip file and placed in the specified output location, and, if selected, imported into [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

     If you have the [!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] installed, you can wrap the finished template in a .vsix file for deployment by using the **VSIX Project** template. For more information, see [Getting Started with the VSIX Project Template](../extensibility/getting-started-with-the-vsix-project-template.md).

## See Also
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
 [How to: Create Item Templates](../ide/how-to-create-item-templates.md)
