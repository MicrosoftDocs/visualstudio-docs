---
title: "How to: Create Item Templates | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "project item templates, XML reference"
  - "project item templates, custom template locations"
  - "project item templates, creating"
  - "project item templates, metadata files"
ms.assetid: 77bc53d4-d607-4820-a032-7e3b365891b5
caps.latest.revision: 23
author: jillre
ms.author: jillfra
manager: jillfra
---
# How to: Create Item Templates
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The steps in the [first procedure](#to-add-a-custom-project-item-template-to-the-add-new-item-dialog-box) of this topic show you how to create an item template by using the **Export Template** wizard. If your template will consist of multiple files, see [How to: Create Multi-file Item Templates](../ide/how-to-create-multi-file-item-templates.md).

 The wizard does a lot of work for you to create the basic template, but in many cases you will need to manually modify the .vstemplate file after you have exported the template. For example, if you want the item to appear in the **Add New Item** dialog for a [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] app project, you’ll have to perform a few extra steps. The [second procedure](#to-enable-the-item-template-to-be-used-in-a-store-project) in this topic helps you accomplish that task.

 In some cases you may want or need to create an item template manually from scratch. The [third procedure](#to-enable-templates-for-specific-project-sub-types) shows how to do that.

 See the [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md) for information about the elements that can be used in the .vstemplate file.

### To add a custom project item template to the Add New Item dialog box

1. Create or open a project in [!INCLUDE[vsprvs](../includes/vsprvs-md.md)].

2. Add an item to the project and modify it if you want to.

3. Modify the code file to indicate where parameter replacement should take place. For more information, see [How to: Substitute Parameters in a Template](../ide/how-to-substitute-parameters-in-a-template.md).

4. On the **File** menu, click **Export Template**.

5. Click **Item Template**, select the project that contains the item, and click **Next**.

6. Select the item for which you want to create a template, and click **Next**.

7. Select the assembly references to include in the template, and click **Next**.

8. Type the icon file name, preview image, template name, and template description, and click **Finish**.

     The files for the template are added to a .zip file and copied whatever directory you specify in the dialog. The default location is **..\Users\\<username\>\Documents\Visual Studio \<Version>\My Exported Templates\\** folder.

    > [!WARNING]
    > In earlier versions of Visual Studio, the default location is **..\Users\\<username\>\Documents\Visual Studio \<Version>\Templates\ItemTemplates**.

### To enable the item template to be used in a store project

1. Follow the steps in the procedure above to export an item template.

2. Extract the .vstemplate file from the .zip file that was copied to the ..\Users\\*username*\Documents\Visual Studio *Version*\Templates\ItemTemplates\ (or **My Exported Templates**) folder.

3. Open the .vstemplate file in Visual Studio.

4. For a Windows 8.1 store C# project, in the .vstemplate file, add the following XML within the opening and closing `<TemplateData>` tag: `<TemplateGroupID>WinRT-Managed</TemplateGroupID>`.

    A C++ Windows 8.1 store project uses a value of `WinRT-Native-6.3`. For Windows 10 and other project types, see [TemplateGroupID Element (Visual Studio Templates)](../extensibility/templategroupid-element-visual-studio-templates.md).

    The following example shows the entire contents of a .vstemplate file after the line of XML `<TemplateGroupID>WinRT-Managed</TemplateGroupID>` has been added to it. This example is specific to C# projects. You can modify the \<ProjectType> and \< [TemplateGroupID](../extensibility/templategroupid-element-visual-studio-templates.md)> elements to specify other language and project types.

   ```xml
   <VSTemplate Version="3.0.0" xmlns="http://schemas.microsoft.com/developer/vstemplate/2005" Type="Item">
     <TemplateData>
       <DefaultName>MyItemStoreTemplate.xaml</DefaultName>
       <Name>MyItemStoreTemplate</Name>
       <Description>This is an example itemtemplate</Description>
       <ProjectType>CSharp</ProjectType>
       <SortOrder>10</SortOrder>
       <Icon>__TemplateIcon.ico</Icon>
       <TemplateGroupID>WinRT-Managed</TemplateGroupID>
     </TemplateData>
     <TemplateContent>
       <References />
       <ProjectItem SubType="Designer" TargetFileName="$fileinputname$.xaml" ReplaceParameters="true">MyItemTemplate.xaml</ProjectItem>
       <ProjectItem SubType="Code" TargetFileName="$fileinputname$.xaml.cs" ReplaceParameters="true">MyItemTemplate.xaml.cs</ProjectItem>
     </TemplateContent>
   </VSTemplate>
   ```

    For other possible TemplateGroupID values, see [TemplateGroupID Element (Visual Studio Templates)](../extensibility/templategroupid-element-visual-studio-templates.md)). For the complete .vstemplate reference, see [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)

5. In Visual Studio, save the .vstemplate file and close it.

6. Copy and paste the .vstemplate file back to the .zip file located in the ..\Users\\*username*\Documents\Visual Studio *Version*\Templates\ItemTemplates\ folder.

    If the **Copy File** dialog box appears, choose the **Copy and Replace** option.

   You can now add an item based on this template to a [!INCLUDE[win8_appname_long](../includes/win8-appname-long-md.md)] project by using the **Add New Item** dialog box.

   For more information about parameter names, see [Template Parameters](../ide/template-parameters.md).

### To enable templates for specific project sub-types

1. The development environment enables you to make project items available from the Add Item dialog box for certain projects. Use this procedure to make custom items available for Windows, Web, Office, or database projects.

    Locate the ProjectType element in the .vstemplate file for the item template.

    Add a [ProjectSubType](../extensibility/projectsubtype-element-visual-studio-templates.md) element immediately after the ProjectType element.

2. Set the text value of the element to one of the following values:

   1. Windows

   2. Office

   3. Database

   4. Web

      For example: `<ProjectSubType>Database</ProjectSubType>`.

      The following example shows an item template available for Office projects.

   ```
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

### To manually create an item template without using the Export Template wizard

1. Create a project and project item.

2. Modify the project item until it is ready to be saved as a template.

3. As appropriate, modify the code file to indicate where parameter replacement should occur. For more information about parameter replacement, see How to: Substitute Parameters in a Template.

4. Create an XML file and save it by using a .vstemplate file name extension, in the same directory as your new item template.

5. Author the .vstemplate XML file to provide item template metadata. For more information, see [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md) and the example in the previous section.

6. Save the .vstemplate file and close it.

7. In Windows Explorer, select the files you want to include in your template, right-click the selection, click Send To, and then click Compressed (zipped) Folder. The files that you selected are compressed into a .zip file.

8. Copy the .zip file and paste it in the user item template location. In Visual Studio 2015, the default directory is ..\Users\\<username\>\Documents\Visual Studio 2015\Templates\ItemTemplates\\. For more information, see How to: Locate and Organize Project and Item Templates.

## See Also
 [Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)
 [How to: Create Multi-file Item Templates](../ide/how-to-create-multi-file-item-templates.md)
 [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)
