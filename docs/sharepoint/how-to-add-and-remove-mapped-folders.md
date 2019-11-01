---
title: "How to: Add and Remove Mapped Folders | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.Project.MappedFolder"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, mapped folders"
  - "mapped folders [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: add and remove mapped folders
  Some commonly used folders in SharePoint, such as Images and Layouts, are deeply embedded in the file hierarchy. You can map these folders into a SharePoint project to access them more easily. Mapped folders are folders in the SharePoint project that correspond to the physical location of the files in the installation of SharePoint Server.

 When you deploy a SharePoint application, the contents of the mapped folder and all its subfolders are copied by the solution package (.wsp) onto the server that's running SharePoint at the specified location in the SharePoint folder tree. This location is determined by the **Deployment Location** property that's set for the mapped folder. Any subfolders in the mapped folder are relative to **Deployment Location** of the mapped folder. Note that the **Deployment Location** property, not the name of the mapped folder, determines where items are deployed.
 You can add mapped folders to a project by using commands on the menu bar or the shortcut menu for the project. You can use the **Add SharePoint "Images" Mapped Folder** and **Add SharePoint "Layouts" folder** commands to add those mapped folders that are used most often. You can map any of the other available SharePoint folders to your project by using the **Add SharePoint Mapped Folder** command on the shortcut menu and then specifying the folders in the **Add SharePoint Mapped Folder** dialog box.

## Add mapped folders to a project
 The following procedure describes how to add two mapped folders to a visual web part project. To start, you create a visual web part project.

#### To add mapped folders to a project

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the **New Project** dialog box, expand either the **Visual Basic** or **Visual C#** node, expand the **Office/SharePoint** node, and then choose the **SharePoint Solutions** node.

3. In the list of project templates, choose the **SharePoint 2013 Visual Web Part** template.

4. In the **Name** box, enter **TestProject1**, and then choose the **OK** button.

5. In the **SharePoint Customization Wizard**, choose the **Finish** button to retain the default settings.

6. In **Solution Explorer**, choose the project node, and then, on the menu bar, choose **Project** > **Add SharePoint "Images" Mapped Folder**.

     A folder that's named **Images** appears in your project and contains a subfolder that's named TestProject1. This mapped folder will contain images for the visual web part project.

7. In **Solution Explorer**, choose the project node, and then, on the menu bar, choose **Project** > **Add SharePoint Mapped Folder** to display the **Add SharePoint Mapped Folder** dialog box.

8. In the tree view of folders that are available for mapping, choose the **Resources** folder, and then choose the **OK** button.

     A folder that's named **Resources** appears in your project. This folder can store items such as string resource files. Sub-folders can be useful for organizing the contents of a mapped folder, but they're not automatically created when you add a mapped folder by using the **Add SharePoint Mapped Folder** command. To add a sub-folder, choose the **Resources** folder, and then, on the menu bar, choose **Project** > **New Folder**.

## Change the deployment location of a mapped folder
 By default, mapped folders are added to specific locations relative to the SharePoint root installation path, which the token \<SharePointRoot> denotes. However, you can change this location by changing the **Deployment location** property of the mapped folder. Each mapped folder has its own **Deployment location** property.

#### To change the deployment location of a mapped folder

1. In the project that you created earlier, choose a mapped folder.

2. In the **Properties** window, choose the ellipsis (![ASP.NET Mobile Designer ellipse](../sharepoint/media/mwellipsis.gif "ASP.NET Mobile Designer ellipse")) button on the **Deployment location** property.

3. In the **Add SharePoint Mapped Folder** dialog box, browse to the folder to which you want the mapped folder to point.

4. Choose the node, and then choose the **OK** button.

## Rename or remove mapped folders

#### To rename or remove a mapped folder

1. In the project that you created earlier, choose a mapped folder.

2. To rename the mapped folder, open its shortcut menu, choose **Rename**, enter the new name, and then choose the Enter key.

     As an alternative, you can choose the mapped folder that you want to rename, open the **Properties** window, and then set the value of the **Folder name** property to the new name.

3. To remove a mapped folder from the project, open its shortcut menu, choose **Delete**, and then choose the **OK** button in the dialog box to confirm the removal.

## See also
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
