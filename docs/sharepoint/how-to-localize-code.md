---
title: "How to: Localize Code | Microsoft Docs"
ms.custom: ""
ms.date: "02/02/2017"
ms.reviewer: ""
ms.suite: ""
ms.technology: 
  - "office-development"
ms.tgt_pltfrm: ""
ms.topic: "article"
dev_langs: 
  - "VB"
  - "CSharp"
  - "VB"
  - "CSharp"
helpviewer_keywords: 
  - "localizing code [SharePoint development in Visual Studio]"
  - "SharePoint development in Visual Studio, localizing"
author: TerryGLee
ms.author: tglee
manager: ghogen
ms.workload: 
  - "office"
---
# How to: Localize Code
  Unlocalized code uses hard-coded string values. To localize code strings, replace them with calls to <xref:System.Web.HttpContext.GetGlobalResourceObject%2A>, which is a method that references localized resources.  
  
## Localizing Code  
  
#### To localize code  
  
1.  In **Solution Explorer**, open the shortcut menu for a project item, and then choose **Add**, **Module**.  
  
     Choose the **Resources File** template.  
  
    > [!NOTE]  
    >  Be sure to add the resource file to a SharePoint project item so that the Deployment Type property is available. This property is required later in this procedure.  
  
2.  Give the default language resource file a name of your choice appended with a .resx extension, such as MyAppResources.resx.  
  
3.  Repeat steps 1 and 2 to add separate resource files to the SharePoint project item: one for each localized language.  
  
     Use the same base name for each localized resource file, but add the culture ID. For example, name a German localized resource MyAppResources.de-DE.resx.  
  
4.  Open each resource file and add localized strings. Use the same string IDs in each file.  
  
5.  Change the value of the **Deployment Type** property of each resource file to **AppGlobalResource** to cause each file to deploy to the server's App_GlobalResources folder.  
  
6.  Leave the value of the **Build Action** property of each file as **Embedded Resource**.  
  
     Embedded resources are compiled into the project's DLL.  
  
7.  Build the project to create the resource satellite DLLs.  
  
8.  In the **Package Designer**, choose the **Advanced** tab, and then add the satellite assembly.  
  
9. In the **Location** box, prepend a culture ID folder to the Location path, such as de-DE\\*Project Item Name*.resources.dll.  
  
10. If your solution does not already reference the System.Web assembly, add a reference to it, and add a directive in your code to <xref:System.Web>.  
  
11. Locate all hard-coded strings in your code that are visible to users, such as UI text, errors, and message text. Replace them with a call to the <xref:System.Web.HttpContext.GetGlobalResourceObject%2A> method using the following syntax:  
  
    ```  
    HttpContext.GetGlobalResourceObject("Resource File Name", "String ID")  
    ```  
  
12. Choose the F5 key to build and run the application.  
  
13. In SharePoint, change the display language from the default.  
  
     The localized strings appear in the application. To display localized resources, the SharePoint server must have a language pack installed that matches the resource file's culture.  
  
## See Also  
 [Localizing SharePoint Solutions](../sharepoint/localizing-sharepoint-solutions.md)   
 [How to: Localize a Feature](../sharepoint/how-to-localize-a-feature.md)   
 [How to: Localize ASPX Markup](../sharepoint/how-to-localize-aspx-markup.md)   
 [How to: Add a Resource File](../sharepoint/how-to-add-a-resource-file.md)  
  
  