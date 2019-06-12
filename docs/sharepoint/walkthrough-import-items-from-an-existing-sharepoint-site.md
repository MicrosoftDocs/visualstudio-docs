---
title: "Walkthrough: Import Items from an Existing SharePoint Site | Microsoft Docs"
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
# Walkthrough: Import items from an existing SharePoint site
  This walkthrough demonstrates how to import items from an existing SharePoint site into a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint project.

 This walkthrough demonstrates the following tasks:

- Customizing a SharePoint site by adding a custom site column (also known as a *field*.

- Exporting a SharePoint site to a .wsp file.

- Importing the .wsp file into [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint by using the .wsp Import project.

  [!INCLUDE[note_settings_general](../sharepoint/includes/note-settings-general-md.md)]

## Prerequisites
 You need the following components to complete this walkthrough:

- Supported editions of [!INCLUDE[TLA#tla_win](../sharepoint/includes/tlasharptla-win-md.md)] and SharePoint.

- Visual Studio.

## Customize a SharePoint site
 For this example, you will create and customize a SharePoint subsite by adding a new site column to it and by creating another subsite for use later. Later, you will export the first subsite to a .wsp file and then import the custom site column into the second subsite by using the .wsp Import project.

### To create and customize a SharePoint site

1. Open a SharePoint site using a Web browser, such as http://<em>system name</em>/SitePages/Home.aspx.

2. Create a subsite off of the main SharePoint site by opening the **Site Actions** menu and then choosing **New Site**.

3. In the site's **Create** dialog box, choose the **Blank Site** type.

4. In the **Title** box, enter **Site Column Test 1**; in the **URL name** box, enter **columntest1**; leave the other settings at their default values; and then choose the **Create** button.

5. After the site is created, navigate in the browser back to the main site, http://<em>system name</em>/SitePages/Home.aspx.

6. Again, create a blank subsite off of the main SharePoint site by opening the **Site Actions** menu, choosing **New Site**, and then choosing the **Blank Site** type.

7. In the **Title** box, enter **Site Column Test 2**; in the **URL name** box, enter **columntest2**; leave the other settings at their default values; and then choose the **Create** button.

8. Navigate back to the first subsite, http://<em>SystemName</em>/columntest1/default.aspx.

9. On the **Site Actions** menu, choose **Site Settings** to display the Site Settings page.

10. In the **Galleries** section, choose the **Site columns** link.

11. At the top of the **Site Column Gallery** page, choose the **Create** button.

12. In the **Column name** box, enter **Test Column**, keep the other default values, and then choose the **OK** button.

13. The **Test Column** column appears under the Custom Columns heading in the Site Column Gallery.

## Exporting the SharePoint site
 Next, obtain a SharePoint setup (.wsp) file that contains the SharePoint items and elements that you want to import into your [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint project. If you do not already have a .wsp file, then you must create one from an existing SharePoint site. For this example, you will export the default SharePoint site into a .wsp file.

> [!IMPORTANT]
> If you receive a runtime error performing the following procedure, you have to perform the procedure on a system that has access to the SharePoint site.

### To export an existing SharePoint site

1. In the SharePoint site, choose **Site Settings** on the **Site Actions** tab to display the Site Settings page.

2. In the **Site Actions** section of the Site Settings page, choose the **Save site as template** link.

3. In the **File name** box, enter **ExampleSite**, and in the **Template name** box, enter **Example Site**.

4. For this example, leave the **Include Content** check box clear.

     If you select this box, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] saves all lists and document libraries, and their contents, to the .wsp file. Although this is useful in some circumstances, it is not required for this example.

5. When the operation completes successfully, choose the **solution gallery** link to view the .wsp file.

     To view the solutions gallery page later, open the **Site Actions** menu, choose **Site Settings**, choose the **Go to top level site settings** link in the **Site Collection Administration** section, and then choose the **Solutions** link in the **Galleries** section.

6. In the solutions gallery, choose the **ExampleSite** link.

7. In the **File Download** dialog box, choose the **Save** button to save the file on your local system, by default, in your Downloads folder.

## Import the .wsp file
 Now that you have a *.wsp* file that contains an item that you want to reuse (the custom site column Test Column), import the *.wsp* file to access it.

### To import a .wsp file

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], on the menu bar, choose **File** > **New** > **Project** to display the **New Project** dialog box. If your IDE is set to use Visual Basic development settings, on the menu bar, choose **File** > **New Project**.

2. Expand the **SharePoint** node under either **Visual C#** or **Visual Basic**, and then choose the **2010** node.

3. Choose the **Import SharePoint 2010 Solution Package** template in the **Templates** pane, leave the name of the project as WspImportProject1, and then choose the **OK** button.

    The **SharePoint Customization Wizard** appears.

4. On the **Specify the site and security level for debugging** page, enter the [!INCLUDE[TLA2#tla_url](../sharepoint/includes/tla2sharptla-url-md.md)] for the second SharePoint subsite that you created earlier. You will add the new custom Field item, http://<em>system name</em>/columntest2, to that subsite.

5. In the **What is the trust level for this SharePoint solution?** section, leave the selection as **Deploy as a sandboxed solution**.

6. In the **Specify the new project source** page, browse to the location on the system where you saved the *.wsp* file previously and then choose the **Next** button.

   > [!NOTE]
   > If you choose the **Finish** button on this page, all available items in the *.wsp* file will be imported.

7. In the **Select items to import** box, clear all of the check boxes in the list except for **Test Column**, and then choose the **Finish** button.

    Because the list contains many items, you can choose the **Ctrl**+**A** keys to choose all items in the list, choose the Spacebar key to clear all of the check boxes, and then select only the check box next to the **Test Column** item.

    After the import operation is finished, a new project named **WspImportProject1** is created that contains a folder named **Fields**. In this folder is the custom site column **Test Column** and its definition file *Elements.xml*.

## Deploy the project
 Finally, deploy **WspImportProject1** to the second SharePoint subsite that you created earlier to view the custom site column.

### To deploy the project

1. In [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)], choose the **F5** key to deploy and run the *.wsp* import project.

2. On the SharePoint site, open the **Site Actions** menu, and then choose **Site Settings** to display the Site Settings page.

3. In the **Galleries** section, choose the **Site columns** link.

4. Scroll down to the **Custom Columns** section.

     Notice that the custom site column that you imported from the first SharePoint site appears in the list.

## See also
- [Import items from an existing SharePoint site](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
- [Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)
