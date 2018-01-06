---
title: "Create project templates for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: vs-ide-general
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ExportTemplateWizard"
helpviewer_keywords:
  - "project templates [Visual Studio], creating"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: Create project templates

This topic shows you how to create a template using the **Export Template Wizard**, which packages your template in a .zip file.

## To create a user project template by using the Export Template Wizard

1. Create a project.

    > [!NOTE]
    > Use only valid identifier characters when naming a project that will be the source for a template. Otherwise, compilation errors can occur in projects that are created from the template. For more information about valid identifier characters, see [Declared element names (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/declared-elements/declared-element-names) or [Identifiers (C++)](/cpp/cpp/identifiers-cpp). Alternatively, you can use [template parameters](../ide/template-parameters.md) to use "safe" names for classes and namespaces.

1. Edit the project until it is ready to be exported as a template. For example, you might want to edit code files to indicate where parameter replacement should take place. See [How to: Substitute parameters in a template](../ide/how-to-substitute-parameters-in-a-template.md).

1. On the **Project** menu, choose **Export Template...**.

   The **Export Template Wizard** opens.

1. On the **Choose Template Type** page, select **Project Template**. Select the project you want to export to a template, and then choose **Next**.

1. On the **Select Template Options** page, enter a name, and optional description, icon, and preview image for your template. These items will appear in the **New Project** dialog box. Choose **Finish**.

  The project is exported into a .zip file and placed in the specified output location, and, if selected, imported into Visual Studio.

>[!NOTE]
> To find your template in the **New Project** dialog box, expand **Installed** and then expand the category that corresponds to the `ProjectType` element in the .vstemplate file. For example, a .vstemplate file that contains `<ProjectType>CSharp</ProjectType>` appears under **Installed** > **Visual C#**, by default. You can organize your template into a subdirectory of the project type just by creating a folder in that directory and placing your template's .zip file in it. For more information, see [How to: locate and organize templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

## Other ways to create project templates

You can create project templates manually by gathering the files that constitute the project into a folder, and then creating a .vstemplate XML file with the appropriate metadata. For more information, see [How to: Manually create web templates](../ide/how-to-manually-create-web-templates.md).

If you have the Visual Studio SDK installed, you can wrap the finished template in a VSIX file for deployment by using the **VSIX Project** template. For more information, see [Getting started with the VSIX project template](../extensibility/getting-started-with-the-vsix-project-template.md).

## See also

[Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)  
[How to: Create Item Templates](../ide/how-to-create-item-templates.md)  
[Getting started with the VSIX project template](../extensibility/getting-started-with-the-vsix-project-template.md)
