---
title: "How to: update existing templates | Microsoft Docs"
ms.custom: ""
ms.date: "10/19/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "vs-ide-general"
ms.tgt_pltfrm: ""
ms.topic: "article"
helpviewer_keywords: 
  - "item templates, updating existing templates"
  - "Visual Studio templates, updating existing templates"
  - "project templates, updating existing templates"
ms.assetid: d585e45b-7fe2-45fa-9cf3-7f2bc060f3c4
caps.latest.revision: 19
author: "gewarren"
ms.author: "gewarren"
manager: "ghogen"
---
# How to: update existing templates
After you create a template and compress the files into a .zip file, you may want to modify the template. You can do this by manually changing the files in the template, or by exporting a new template from a project that is based on the template.  
  
## Using the Export Template Wizard to update an existing template  
Visual Studio provides an **Export Template** wizard that can be used to update an existing template.  
  
#### To use Export Template to update an existing template  
  
1.  Open the **New Project** dialog box by choosing **File**, **New**, **Project**.  
  
2.  Select the template that you want to update, enter a name and location for your project, and choose **OK**.  
  
3.  Modify the project in Visual Studio.  
  
4.  On the **Project** menu, choose **Export Template**.  

    The **Export Template Wizard** opens.  

5.  Follow the prompts in the wizard to export the template as a .zip file.  

6.  Delete the old template .zip file.  
  
## Manually updating an existing template  
You can update an existing template outside Visual Studio by modifying the files in the compressed .zip file.  
  
#### To manually update an existing template  
  
1.  Locate the .zip file that contains the template. By default, this file is located in %USERPROFILE%\Documents\Visual Studio \<version\>\My Exported Templates\.  
  
2.  Extract the .zip file.  
  
3.  Modify or delete the current template files, or add new files to the template.  
  
4.  Open, modify, and save the .vstemplate XML file to handle updated behavior or new files.  

    For more information about the .vstemplate schema, see [Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md). For more information about what you can parameterize in the source files, see [Template Parameters](../ide/template-parameters.md).  
  
5.  Select the files in your template, right-click, choose **Send To**, and then choose **Compressed (zipped) Folder**.  

    The files that you selected are compressed into a .zip file.  
  
6.  Put the new .zip file in the same directory as the old .zip file.  
  
7.  Delete the extracted template files and the old template .zip file.  
  
8.  Start an elevated instance of the Developer Command Prompt:  

  1. In the Start menu, navigate to **Visual Studio \<version\>**, **Developer Command Prompt**.  

  2. From the context (right-click) menu, choose **More**, **Run as administrator**.  
  
9. Run the following command: `devenv /installvstemplates`.  
  
## See also  
[Customizing Templates](../ide/customizing-project-and-item-templates.md)   
[Creating Project and Item Templates](../ide/creating-project-and-item-templates.md)   
[Visual Studio Template Schema Reference](../extensibility/visual-studio-template-schema-reference.md)   
[Template Parameters](../ide/template-parameters.md)   
[How to: Create Starter Kits](../ide/how-to-create-starter-kits.md)