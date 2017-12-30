---
title: "How to: Create Project Templates | Microsoft Docs"
ms.custom: ""
ms.date: "12/29/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
f1_keywords: 
  - "VS.ExportTemplateWizard"
helpviewer_keywords: 
  - "Visual Studio templates, creating project templates"
  - "project templates, metadata files"
  - "Visual Studio templates, project templates"
  - "project templates, custom template locations"
  - "project templates, creating"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: Create project templates

This procedure enables you to create a template using the **Export Template Wizard**, which packages your template in a .zip file. You can also create templates in the VSIX file format for improved deployment by using the Export Template Wizard extension, with templates included in the [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)], or you can create templates manually.

## To create a custom project template with the Export Template Wizard

1. Create a project.

    > [!NOTE]
    > Use only valid identifier characters when naming a project that will be the source for a template. Otherwise, compilation errors can occur in projects that are created from the template. For more information about valid identifier characters, see [Declared element names (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/declared-elements/declared-element-names) or [Identifiers (C++)](/cpp/cpp/identifiers-cpp). Alternatively, you can use [template parameters](../ide/template-parameters.md) to use "safe" names for classes and namespaces.

1. Edit the project until it is ready to be exported as a template. For example, you might want to edit code files to indicate where parameter replacement should take place. See [How to: Substitute parameters in a template](../ide/how-to-substitute-parameters-in-a-template.md).

1. On the **Project** menu, choose **Export Template...**.

   The **Export Template Wizard** opens.

1. On the **Choose Template Type** page, select **Project Template**. Select the project you want to export to a template, and then choose **Next**.

1. On the **Select Template Options** page, enter a name, description, icon, and preview image for your template. These will appear in the **New Project** dialog box. Choose **Finish**.

  The project is exported into a .zip file and placed in the specified output location, and, if selected, imported into Visual Studio.

  If you have the [!INCLUDE[vsipsdk](../extensibility/includes/vsipsdk_md.md)] installed, you can wrap the finished template in a .vsix file for deployment by using the **VSIX Project** template. For more information, see [Getting Started with the VSIX Project Template](../extensibility/getting-started-with-the-vsix-project-template.md).

## See also

[Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)  
[How to: Create Item Templates](../ide/how-to-create-item-templates.md)
