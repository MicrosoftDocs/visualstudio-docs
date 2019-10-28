---
title: "How to: Import a Master Page or Theme | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, importing items"
  - "importing items [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Import a master page or theme
  You can give pages on your SharePoint site a consistent appearance by creating and using master pages and themes. [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] doesn't provide templates for these elements, but you can create them in SharePoint Designer and then import them into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. For more information, see [Building Block: Pages and User Interface](/previous-versions/office/developer/sharepoint-2010/ee539040(v=office.14)) on the Microsoft website.

### To import a master page or theme

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], create or open a SharePoint project.

     For information about how to create a SharePoint project, see [SharePoint project and project item templates](../sharepoint/sharepoint-project-and-project-item-templates.md).

2. On the menu bar, choose **Project** > **Add New Item**.

3. In the **Add New Item** dialog box, expand the **SharePoint** node, and then choose the **2010** node.

4. In the list of SharePoint templates, choose the **Module** template, and then specify a name for the module.

     A module contains files (for example, master page or theme files) for deployment to a location that you specify in SharePoint.

5. In the module, delete the default file, which is named *Sample.txt*.

6. Choose the module node.

7. On the menu bar, choose **Project** > **Add Existing Item**, and then choose the master page or theme file.

     Master page files have a .master extension, and theme files have a .thmx extension.

8. If you added a master page, change its **Deployment Conflict Resolution** setting to **Automatic** in the module's properties.

    > [!NOTE]
    > Errors can occur if the name of the master page is the same as the name of an existing master page that's marked as either Default Master Page or Custom Master Page. For information about how to resolve this problem, see [Walkthrough: Import a custom master page and site page with an image](../sharepoint/walkthrough-import-a-custom-master-page-and-site-page-with-an-image.md).

9. In the module, open *Elements.xml*.

     You must update the *Elements.xml* file to reference the master page or theme that you added.

10. For a master page, replace the existing module markup with the following markup.

    ```xml
    <Module Name="[Module Name]" Url="_catalogs/masterpage">
        <File Path="[Module Name]\[Master Page Name].master"
          Url="[Master Page Name].master" Type="GhostableInLibrary" />
    </Module>
    ```

     For a theme, replace the existing module markup with the following markup.

    ```xml
    <Module Name="[Module Name]" Url="_catalogs/theme"
        <File Path="[Module Name]\[Theme Name].thmx" Url="[Theme
          Name].thmx" Type="GhostableInLibrary" />
    </Module>
    ```

     Be sure to replace the placeholder values with the actual names of the module and the master page or theme.

     The attribute `Type="GhostableInLibrary"` indicates that the item is added to the content database, and the `Url` attribute of the module specifies where to store the file in the SharePoint content database.

11. To change the deployment scope for a master page, in **Solution Explorer**, open the feature file in the Feature Designer, and then choose a new deployment scope from the **Scope** list.

     A value of **Web** means that the master page applies only to the website that's currently specified in the project. A value of **Site** means that the master page applies to the current site collection, which includes all subsites and the root web. The other values don't apply.

    > [!NOTE]
    > Because themes apply only to the site collection level, we recommend that you don't set the scope of a theme to anything other than **Site**. Errors can occur if a theme is used in a sub-site.

12. On the menu bar, choose **Build** > **Deploy Solution**.

13. To verify whether the files were deployed correctly, open the SharePoint site, choose the **Site Actions** menu, choose the **Site Settings** command, and then choose either the **Master Pages** link or the **Themes** link.

     The list of either master pages or themes appears and contains either the master page or the theme that you imported.

## See also
- [Master Pages](/previous-versions/office/developer/sharepoint-2010/ms443795(v=office.14))
- [Importing items from an existing SharePoint site](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)
- [Create pages for SharePoint](../sharepoint/creating-pages-for-sharepoint.md)
- [Use modules to include files in the solution](../sharepoint/using-modules-to-include-files-in-the-solution.md)
