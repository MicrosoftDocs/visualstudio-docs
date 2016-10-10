---
title: "How to: Create Project Templates"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: a1a6999d-a34c-48a8-b1cf-027eb5c76398
caps.latest.revision: 19
manager: ghogen
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# How to: Create Project Templates
This procedure enables you to create a template using the **Export Template** wizard, which packages your template in a .zip file. You can also create templates in the VSIX file format for improved deployment by using the Export Template Wizard extension, or with templates included in the Visual Studio SDK, or you can create templates manually.  
  
### To create a custom project template with the standard Export Template wizard  
  
1.  Create a project.  
  
    > [!NOTE]
    >  Use only valid identifier characters when naming a project that will be the source for a template. A template exported from a project named with invalid characters can cause compilation errors in future projects based on the template. For more information on valid identifier characters, see [Declared Element Names](../Topic/Declared%20Element%20Names%20\(Visual%20Basic\).md).  
  
2.  Edit the project until it is ready to be exported as a template.  
  
3.  As appropriate, edit the code files to indicate where parameter replacement should take place. For more information on parameter replacement, see [How to: Substitute Parameters in a Template](../VS_IDE/How-to--Substitute-Parameters-in-a-Template.md).  
  
4.  On the **File** menu, click **Export Template**. The **Export Template** wizard opens.  
  
5.  Click **Project Template**.  
  
6.  If you have more than one project in your current solution, select the projects you want to export to a template.  
  
7.  Click **Next**.  
  
8.  Select an icon and a preview image for your template. These will appear in the **New Project** dialog box.  
  
9. Enter a template name and description.  
  
10. Click **Finish**. Your project is exported into a .zip file and placed in the specified output location, and, if selected, imported into Visual Studio.  
  
     If you have the Visual Studio SDK installed, you can wrap the finished template in a .vsix file for deployment by using the **VSIX Project** template. For more information, see [Getting Started with the VSIX Project Template](../Topic/Getting%20Started%20with%20the%20VSIX%20Project%20Template.md).  
  
## See Also  
 [Creating Project and Item Templates](../VS_IDE/Creating-Project-and-Item-Templates.md)   
 [How to: Create Item Templates](../VS_IDE/How-to--Create-Item-Templates.md)