---
title: Create item templates
description: Learn how to use the Export Template Wizard to create an item template in Visual Studio.
ms.custom: SEO-VS-2020
ms.date: 01/02/2018
ms.topic: how-to
helpviewer_keywords:
- item templates [Visual Studio], creating
author: TerryGLee
ms.author: tglee
manager: jmartens
ms.technology: vs-ide-general
---
# How to: Create item templates

This article shows you how to create an item template by using the **Export Template Wizard**. If your template will consist of multiple files, see [How to: Create multi-file item templates](../ide/how-to-create-multi-file-item-templates.md).

## Add an item template to the Add New Item dialog box

1. Create or open a project in Visual Studio.

1. Add an item to the project, and modify it if you want to.

1. Modify the code file to indicate where parameter replacement should take place. For more information, see [How to: Substitute parameters in a template](../ide/how-to-substitute-parameters-in-a-template.md).

1. On the **Project** menu, choose **Export Template**.

1. On the **Choose Template Type** page, choose **Item Template**, select the project that contains the item, and then choose **Next**.

1. On the **Select Item To Export** page, choose the item you want to create a template for, and then choose **Next**.

1. On the **Select Item References** page, select the assembly references to include in the template, and then choose **Next**.

1. On the **Select Template Options** page, enter the template name and optional description, icon image and preview image, and then choose **Finish**.

    The files for the template are added to a *.zip* file and copied to the directory you specified in the wizard. The default location is *%USERPROFILE%\Documents\Visual Studio \<version\>\My Exported Templates*.

1. If you did not select the option **Automatically import the template into Visual Studio** in the **Export Template Wizard**, locate the exported template. Then, copy it to the user item template directory. The default location is *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ItemTemplates*.

1. Close Visual Studio and then reopen it.

1. Create a new project, or open an existing project, and then choose **Project** > **Add New Item** or press **Ctrl**+**Shift**+**A**.

   The item template appears in the **Add New Item** dialog box. If you added a description in the **Export Template Wizard**, the description appears on the right side of the dialog box.

## Enable the item template to be used in a Universal Windows App project

The wizard does much of the work to create a basic template, but in many cases you need to manually modify the *.vstemplate* file after you have exported the template. For example, if you want the item to appear in the **Add New Item** dialog for a Universal Windows App project, you have to perform a few extra steps.

1. Follow the steps in the previous section to export an item template.

1. Extract the *.zip* file that was created, and open the *.vstemplate* file in Visual Studio.

1. For a C# Universal Windows project, add the following XML inside the `<TemplateData>` element:

   ```xml
   <TemplateID>Microsoft.CSharp.Class</TemplateID>
   ```

1. In Visual Studio, save the *.vstemplate* file and close it.

1. Copy and paste the *.vstemplate* file back to the *.zip* file.

     If the **Copy File** dialog box appears, choose the **Copy and Replace** option.

You can now add an item based on this template to a Universal Windows project from the **Add New Item** dialog box.

## Enable templates for specific project subtypes

You can specify that your template should only appear for only certain project subtypes, such as Windows, Office, Database, or Web.

1. Locate the `ProjectType` element in the *.vstemplate* file for the item template.

1. Add a [ProjectSubType](../extensibility/projectsubtype-element-visual-studio-templates.md) element immediately after the `ProjectType` element.

1. Set the text value of the element to one of the following values:

    - Windows
    - Office
    - Database
    - Web

For example: `<ProjectSubType>Database</ProjectSubType>`.

The following example shows an item template for **Office** projects.

```xml
<VSTemplate Version="2.0.0" Type="Item" Version="2.0.0">
   <TemplateData>
      <Name>Class</Name>
      <Description>An empty class file</Description>
      <Icon>Class.ico</Icon>
      <ProjectType>CSharp</ProjectType>
      <ProjectSubType>Office</ProjectSubType>
      <DefaultName>Class.cs</DefaultName>
   </TemplateData>
   <TemplateContent>
      <ProjectItem>Class1.cs</ProjectItem>
   </TemplateContent>
</VSTemplate>
```

## Manually create an item template

In some cases you may want to create an item template manually, from scratch.

1. Create a project and project item.

2. Modify the project item until it is ready to be saved as a template.

3. Modify the code file to indicate where parameter replacement should occur, if anywhere. For more information about parameter replacement, see [How to: Substitute parameters in a template.](../ide/how-to-substitute-parameters-in-a-template.md)

4. Create an XML file and save it with a *.vstemplate* file extension in the same directory as your project item file.

5. Edit the *.vstemplate* XML file to provide item template metadata. For more information, see [Template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md) and the example in the previous section.

6. Save the *.vstemplate* file and close it.

7. In **Windows Explorer**, select the files you want to include in your template. Right-click the selection, and choose **Send to** > **Compressed (zipped) folder**. The files that you selected are compressed into a *.zip* file.

::: moniker range="vs-2017"

8. Copy the *.zip* file and paste it in the user item template location. The default directory is *%USERPROFILE%\Documents\Visual Studio 2017\Templates\ItemTemplates*. For more information, see [How to: Locate and organize project and item templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

::: moniker-end

::: moniker range=">=vs-2019"

8. Copy the *.zip* file and paste it in the user item template location. The default directory is *%USERPROFILE%\Documents\Visual Studio 2019\Templates\ItemTemplates*. For more information, see [How to: Locate and organize project and item templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

::: moniker-end

## See also

- [Create project and item templates](../ide/creating-project-and-item-templates.md)
- [How to: Create multi-file item templates](../ide/how-to-create-multi-file-item-templates.md)
- [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)
