---
title: "How to: Include Files by Using a Module | Microsoft Docs"
description: Know how to include files by using a module, which is a container that lets you deploy files such as ASPX master pages, text files, or images to SharePoint.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, modules"
  - "modules [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# How to: Include files by using a module
  *Modules* (not to be confused with [!INCLUDE[vbprvb](../sharepoint/includes/vbprvb-md.md)] modules) are containers that enable you to deploy files such as ASPX master pages, text files, or images to SharePoint.

 You can choose to deploy a file into a document library or as a normal file (for example, default.aspx) outside a document library. To add a file to a document library, specify `Type="GhostableInLibrary"` as an attribute in the **File** element. This setting instructs SharePoint to create a list item to go with your file when it is added to the library. To deploy a file outside a document library, either specify `Type="Ghostable"` or just omit the **Type** attribute.

## Add a module to a SharePoint solution

#### To add a module

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], open or create a SharePoint project.

     For more information, see [SharePoint project and project item templates](../sharepoint/sharepoint-project-and-project-item-templates.md).

2. In **Solution Explorer**, choose the project node, and then, on the menu bar, choose **Project** > **Add New Item**.

     The **Add New Item** dialog box opens.

3. In the list of SharePoint templates, choose the **Module** template, and then choose the **Add** button.

     This step creates a node in the project named Module1.

4. Under Module1, delete the *Sample.txt* file.

     Sample.txt is included in all new modules for example purposes and is not needed. (Note that deleting the file also removes its entry from the module's *Elements.xml* file.)

5. If you want your files to deploy to a particular folder structure in SharePoint, create those folders under Module1 in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] by choosing the Module1 node, and then, on the menu bar, choosing **Project**, **New Folder**.

6. Choose the folder in which you want to add the file, and then, on the menu bar, choose **Project**, **Add Existing Item**.

7. Choose one or more files that you want to deploy to SharePoint, and then choose the **Add** button.

     When you add a file to the project, an entry for it is automatically added to the module's Elements.xml file. When the project is deployed, the files are copied to SharePoint server, relative to the project's root directory, which is specified by the **File** element's **Url** attribute, such as `Url="Module1/New Folder/SomeFile.doc`. If you want to change the deployment location for a file, either move it to another folder in **Solution Explorer** or change its **Url** setting.

8. For any files that you want to appear in a document library, append the `Type="GhostableInLibrary"` attribute to their entry in *Elements.xml*. For example,

    ```xml
    <File Path="Module1\Some Folder\SomePage.aspx" Url="Module1/Some Folder/SomePage.aspx" Type="GhostableInLibrary" />
    ```

9. Deploy the project.

     The files copy to the specified locations in SharePoint.

## See also
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
- [Developing SharePoint Solutions](../sharepoint/developing-sharepoint-solutions.md)
