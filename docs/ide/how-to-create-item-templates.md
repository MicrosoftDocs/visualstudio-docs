---
title: Create item templates
description: Learn how to create, edit, and use item templates in Visual Studio projects.
ms.date: 04/11/2025
ms.topic: how-to
helpviewer_keywords:
- item templates [Visual Studio], creating
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: general-ide

#customer intent: As a developer, I want to create and use item templates in Visual Studio, so I can easily reuse project items in other projects.
---
# Create item templates

This article shows you how to create an item template by using the **Export Template Wizard** or manually, and how to edit and use item templates. If your template consists of multiple files, also see [How to: Create multi-file item templates](how-to-create-multi-file-item-templates.md).

## Add an item template

1. Create or open a project in Visual Studio.
1. Select **Project** > **Add New Item** or press **Ctrl**+**Shift**+**A**.
1. In the **Add New Item** dialog box, select an item and then select **Add** to add it to the project.
1. Modify the item as desired, and indicate where in the item, if anywhere, parameter replacement should take place. For more information, see [How to: Substitute parameters in a template](how-to-substitute-parameters-in-a-template.md).
1. Save the item.
1. Select **Project** > **Export Template**. The **Export Template Wizard** opens.
1. On the **Choose Template Type** page, choose **Item Template**, select the project that contains the item, and then select **Next**.
1. On the **Select Item To Export** page, choose the item you want to create a template for, and then select **Next**.
1. On the **Select Item References** page, select any assembly references to include in the template, and then select **Next**.
1. On the **Select Template Options** page:

   - Enter the template name and optional description, icon image, and preview image.

     Icon files for items are *.ico* files, as described in [Images and icons for Visual Studio](../extensibility/ux-guidelines/images-and-icons-for-visual-studio.md#file-types). The preview image is a 200 x 200 image that appears in the **Add New Item** dialog box. You can download the [Visual Studio image library](https://www.microsoft.com/download/details.aspx?id=35825) to get icons consistent with Visual Studio style.

   - Select whether to **Automatically import the template into Visual Studio** and **Display an explorer window in the output files folder**.

1. Select **Finish**.

The template files are compressed into a *.zip* file and copied to the directory shown in the wizard under **Output location**. The default location is *%USERPROFILE%\Documents\Visual Studio \<version\>\My Exported Templates*.

If you selected **Automatically import the template into Visual Studio**, the *.zip* file is also added to the user *ItemTemplates* directory. The default location is *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ItemTemplates*.

You can now use the item template in your projects.

## Use the item template

1. If you didn't select **Automatically import the template into Visual Studio** when you created the template, copy the *.zip* file to your *ItemTemplates* directory. The default location is *%USERPROFILE%\Documents\Visual Studio \<version\>\Templates\ItemTemplates*.
1. Close Visual Studio and then reopen it.
1. Create a new project, or open an existing project, and select **Project** > **Add New Item**
1. Select the item template from the **Add New Item** dialog box. If you added a description in the **Export Template Wizard**, the description appears on the right side of the dialog box.
1. Select **Add** to add the template item to your project.

## Edit the .vstemplate file

The wizard creates a basic template, but in some cases you need to manually modify the *.vstemplate* file after you export the template. For example, if you want the item to appear in the **Add New Item** dialog for a Universal Windows App project, you must edit the *.vstemplate* file.

1. Extract the exported item template *.zip* file, and open the *.vstemplate* file in Visual Studio.
1. Edit the file as needed. For a C# Universal Windows project, add `<TemplateID>Microsoft.CSharp.Class</TemplateID>` inside the `<TemplateData>` element.
1. Save and close the *.vstemplate* file, and replace it in the *.zip* file.

### Enable templates for specific project subtypes

You can edit the *.vstemplate* file to specify that your item template appears only for certain project subtypes, such as Windows, Office, Database, or Web.

1. Open the *.vstemplate* file for editing.
1. Add a [ProjectSubType](../extensibility/projectsubtype-element-visual-studio-templates.md) element immediately after the `ProjectType` element, with value `Windows`, `Office`, `Database`, or `Web`. For example: `<ProjectSubType>Database</ProjectSubType>`.

The following example shows a *.vstemplate* file for `Office` projects.

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

Instead of using the wizard, you can create an item template manually from scratch.

1. Create a project and add an item.
1. Modify the item as desired, such as adding where any parameter replacement should take place, and save the item.
1. Create an XML file and save it with a *.vstemplate* file extension in the same directory as your project item file.
1. Add item template metadata to the *.vstemplate* XML file, as shown in the preceding example. For more information, see [Template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md).
1. Save and close the *.vstemplate* file.
1. In Windows Explorer, select the files you want to include in your template, including the *.vstemplate* file. Right-click the selection and select **Compress to** > **ZIP File**.
1. Copy the resulting *.zip* file and paste it in the Visual Studio user item template location. The default directory is *%USERPROFILE%\Documents\Visual Studio \<version>\Templates\ItemTemplates*.

## Related content

- [Locate and organize project and item templates](how-to-locate-and-organize-project-and-item-templates.md)
- [Create project and item templates](creating-project-and-item-templates.md)
- [Create multi-file item templates](how-to-create-multi-file-item-templates.md)
- [Visual Studio template schema reference (extensibility)](../extensibility/visual-studio-template-schema-reference.md)
