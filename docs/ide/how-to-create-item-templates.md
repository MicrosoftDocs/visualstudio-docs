---
title: "Create item templates for Visual Studio | Microsoft Docs"
ms.custom: ""
ms.date: "01/02/2018"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "item templates [Visual Studio]"
  - "item templates, creating"
author: "gewarren"
ms.author: "gewarren"
manager: ghogen
---
# How to: Create item templates

This topic shows you how to create an item template by using the **Export Template Wizard**. If your template will consist of multiple files, see [How to: Create Multi-file Item Templates](../ide/how-to-create-multi-file-item-templates.md).

## To add a custom project item template to the Add New Item dialog box

1. Create or open a project in Visual Studio.

1. Add an item to the project, and modify it if you want to.

1. Modify the code file to indicate where parameter replacement should take place. For more information, see [How to: Substitute parameters in a template](../ide/how-to-substitute-parameters-in-a-template.md).

1. On the **Project** menu, choose **Export Template..**.

1. Choose **Item Template**, select the project that contains the item, and then choose **Next**.

1. Select the item for which you want to create a template, and choose **Next**.

1. Select the assembly references to include in the template, and choose **Next**.

1. Enter the icon file name, preview image, template name, and template description, and then choose **Finish**.

    The files for the template are added to a .zip file and copied to the directory you specified in the wizard. The default location is %USERPROFILE%\Documents\Visual Studio <version>\My Exported Templates.

### To enable the item template to be used in a Universal Windows App project

The wizard does much of the work to create a basic template, but in many cases you need to manually modify the .vstemplate file after you have exported the template. For example, if you want the item to appear in the **Add New Item** dialog for a Universal Windows App project, you have to perform a few extra steps.

1. Follow the steps in the previous section to export an item template.

1. Extract the .zip file that was created, and open the .vstemplate file in Visual Studio.

1. For a C# Universal Windows project, add the following XML inside the `<TemplateData>` element:

   ```xml
   <TemplateID>Microsoft.CSharp.Class</TemplateID>
   ```

   For Windows 8.1 C# projects, in the .vstemplate file, add the following XML within the opening and closing `<TemplateData>` tag: `<TemplateGroupID>WinRT-Managed</TemplateGroupID>`. For Windows 8.1 C++  projects, use a value of `WinRT-Native-6.3`. For Windows 10 and other project types, see [TemplateGroupID element (Extensibility)](../extensibility/templategroupid-element-visual-studio-templates.md). For the complete .vstemplate reference, see [Template schema reference (Extensibility)](../extensibility/visual-studio-template-schema-reference.md).

1. In Visual Studio, save the .vstemplate file and close it.

1. Copy and paste the .vstemplate file back to the .zip file.

     If the **Copy File** dialog box appears, choose the **Copy and Replace** option.

You can now add an item based on this template to a Universal Windows project from the **Add New Item** dialog box.

### To enable templates for specific project subtypes

You can specify that your template should only appear for only certain project subtypes, such as Windows, Office, Database, or Web.

1. Locate the ProjectType element in the .vstemplate file for the item template.

     Add a [ProjectSubType](../extensibility/projectsubtype-element-visual-studio-templates.md) element immediately after the ProjectType element.

1. Set the text value of the element to one of the following values:

    - Windows

    - Office

    - Database

    - Web

    For example: `<ProjectSubType>Database</ProjectSubType>`.

The following example shows an item template available for Office projects.

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

### To manually create an item template without using the Export Template Wizard

In some cases you may want to create an item template manually, from scratch.

1. Create a project and project item.

1. Modify the project item until it is ready to be saved as a template.

1. Modify the code file to indicate where parameter replacement should occur, if anywhere. For more information about parameter replacement, see [How to: Substitute Parameters in a Template.](../ide/how-to-substitute-parameters-in-a-template.md)

1. Create an XML file and save it with a .vstemplate file extension in the same directory as your new item template.

1. Edit the .vstemplate XML file to provide item template metadata. For more information, see [Template schema reference (Extensibility)](../extensibility/visual-studio-template-schema-reference.md) and the example in the previous section.

1. Save the .vstemplate file and close it.

1. In Windows Explorer, select the files you want to include in your template, right-click the selection, and choose **Send to** > **Compressed (zipped) folder**. The files that you selected are compressed into a .zip file.

1. Copy the .zip file and paste it in the user item template location. In Visual Studio 2017, the default directory is %USERPROFILE%\Documents\Visual Studio 2017\Templates\ItemTemplates. For more information, see [How to: Locate and Organize Project and Item Templates](../ide/how-to-locate-and-organize-project-and-item-templates.md).

## See also

[Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)  
[How to: Create Multi-file Item Templates](../ide/how-to-create-multi-file-item-templates.md)  
[Visual Studio Template Schema Reference (Extensibility)](../extensibility/visual-studio-template-schema-reference.md)
