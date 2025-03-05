---
title: Create project templates with wizard or XML file
description: Create project templates in Visual Studio with the Export Template Wizard, or by grouping the project files and using a .vstemplate XML file.
ms.date: 04/04/2024
ms.topic: how-to
f1_keywords:
- VS.ExportTemplateWizard
helpviewer_keywords:
- project templates [Visual Studio], creating
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide
---
# Create project templates

This article shows you how to create a template by using the **Export Template Wizard**, which packages your template in a *.zip* file.

## Use the Export Template Wizard

1. Create a project.

    > [!NOTE]
    > Use only valid identifier characters when you name a project that is the source for a template. Otherwise, compilation errors can occur in projects that are created from the template. For more information about valid identifier characters, see [Declared element names (Visual Basic)](/dotnet/visual-basic/programming-guide/language-features/declared-elements/declared-element-names) or [Identifiers (C++)](/cpp/cpp/identifiers-cpp). Alternatively, you can use [Template parameters](template-parameters.md) to use "safe" names for classes and namespaces.

2. Edit the project until it is ready to be exported as a template. For example, you might want to edit code files to indicate where parameter replacement should take place. For more information, see [How to: Substitute parameters in a template](how-to-substitute-parameters-in-a-template.md).

3. On the **Project** menu, choose **Export Template**.

   > [!NOTE]
   > If you don not see the **Export Template** menu item, you can add it by choosing **Tools** > **Customize**, and then select **Commands**, choose the **Project** menu bar, select the **Add Command** button, and then under **Project**, select **Export Template...**.

   The **Export Template Wizard** opens.

4. On the **Choose Template Type** page, select **Project Template**. Select the project you want to export to a template, and then choose **Next**.

5. On the **Select Template Options** page, enter a name and optional description, icon image, and preview image for your template. These items will appear in the dialog box where you create a new project. Select **Finish**.

   The project is exported into a *.zip* file and placed in the specified output location, and, if selected, imported into Visual Studio.

To find your template in the dialog box where you create a new project, search for it by name or scroll through the list. (Filtering based on language or project type is not currently possible for user templates.)

## Other ways to create project templates

You can create project templates manually by gathering the files that constitute the project into a folder and creating a *.vstemplate* XML file with the appropriate metadata. For more information, see [How to: Manually create web templates](how-to-manually-create-web-templates.md).

If you have the Visual Studio SDK installed, you can wrap the finished template in a VSIX file for deployment by using the **VSIX Project** template. For more information, see [Get started with the VSIX project template](../extensibility/getting-started-with-the-vsix-project-template.md).

## Related content

- [About project and item templates](creating-project-and-item-templates.md)
