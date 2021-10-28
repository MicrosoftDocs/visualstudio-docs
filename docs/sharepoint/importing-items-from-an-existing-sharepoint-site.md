---
title: "Importing Items from an Existing SharePoint Site | Microsoft Docs"
description: Import items from an existing SharePoint site with the Import SharePoint Solution Package project template, so you can reuse elements in a new SharePoint solution.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: overview
f1_keywords:
  - "VS.SharePointTools.WSPImport.SelectionDependency"
  - "VS.SharepointTools.WSPImport.SpecifyProjectSource"
  - "VS.SharePointTools.WSPImport.SelectionItemsToImport"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, importing items"
  - "SharePoint development in Visual Studio, importing .wsp files"
  - "importing items [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Import items from an existing SharePoint site
  The Import SharePoint Solution Package project template lets you reuse elements such as content types and fields from existing SharePoint sites in a new [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint solution. Although you can run most imported solutions without modification, there are certain restrictions and issues to consider, especially if you modify any items after importing them.

> [!NOTE]
> To import reusable workflows, use the Import Reusable Workflow project template. [!INCLUDE[crdefault](../sharepoint/includes/crdefault-md.md)] [Guidelines for importing reusable workflows](../sharepoint/guidelines-for-importing-reusable-workflows.md).

## Supported SharePoint solutions
 [!INCLUDE[vs_dev11_long](../sharepoint/includes/vs-dev11-long-md.md)] fully supports the importing of solutions created in [!INCLUDE[wss_14_short](../sharepoint/includes/wss-14-short-md.md)] and [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)].

 [!INCLUDE[vs_dev11_long](../sharepoint/includes/vs-dev11-long-md.md)] does not support the importing of solutions created in the following applications:

- [!INCLUDE[winshare3](../sharepoint/includes/winshare3-md.md)]

- [!INCLUDE[offshare7](../sharepoint/includes/offshare7-md.md)]

- [!INCLUDE[vs_orcas_long](../sharepoint/includes/vs-orcas-long-md.md)]

- Microsoft SharePoint Designer 2007

- [!INCLUDE[vs_dev10_long](../sharepoint/includes/vs-dev10-long-md.md)]

  Although you can often successfully import solutions created by these applications, that functionality is not tested and not supported.

## Item import restrictions
 Although most SharePoint items can be imported from an existing *.wsp* file, the following items are not supported and may require modifications to work correctly:

- BDC entities

- Code workflow association elements

- Code workflows

- Visual Web parts (.ascx)

- Web services (*.asmx*)

- Content type bindings

- Event receivers

- List definitions (templates)

- Site definitions

  When you export a solution from [!INCLUDE[wss_14_short](../sharepoint/includes/wss-14-short-md.md)] or [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)], these items are automatically excluded from the *.wsp* file. However, other *.wsp* files generated from unsupported tools may contain these items. (See "Supported SharePoint Solutions" earlier in this topic.)

## What happens when you import a solution
 When you import a solution with the Import SharePoint Solution Package template, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] copies all of the contents of the *.wsp* file and tries to reconcile and retain as many associations and references between imported elements and their files as possible.

 All imported items copy to corresponding folders in **Solution Explorer**. For example, content types appear under the folder **Content types** and list instances appear under **List instances**. Files associated with an imported item are also copied to the item's folder. For example, an imported list instance includes its modules, forms, and ASPX pages.

### Dependent items
 If you select an item in the Import SharePoint Solution Package wizard, but not its dependent items, a message box informs you that the dependent items must also be selected before importing.

### What are features?
 SharePoint Designer users may see unexpected files, called *features*, appear in their imported solutions in **Solution Explorer.** Although features existed in the SharePoint Designer solution, they were hidden from view. Features are now visible in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].

 Features are containers for SharePoint items. Each feature keeps a reference to each item, such as content types and list definitions, that it contains. When you import your solution, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] sets up features for all of the imported elements and attempts to maintain the feature-to-element relationships for the files. Any files whose references could not be resolved are put in the **Other Imported Files** folder.

 For more information about features, see [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md) and [Working with Features](/previous-versions/office/developer/sharepoint-2010/ms460318(v=office.14)).

### Handle special cases
 In some cases, Visual Studio cannot reconcile an item with its dependent files. Any files that [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] could not resolve appear under the folder **Other Imported Files**. In addition, their **DeploymentType** properties are set to **NoDeployment** so that they are not deployed with the solution.

 For example, if you import the list definition ExpenseForms, a list definition with that name appears under the **List definitions** folder in **Solution Explorer** along with its *Elements.xml* and *Schema.xml* files. However, its associated ASPX and HTML forms may be placed in a folder called **ExpenseForms** under the **Other Imported Files** folder. To complete the import, move these files under the ExpenseForms list definition in **Solution Explorer** and change the **DeploymentType** property for each file from **NoDeployment** to **ElementFile**.

 When importing event receivers, the *Elements.xml* file is copied to the correct location, but you must manually include the assembly in the solution package so that it deploys with the solution. [!INCLUDE[crabout](../sharepoint/includes/crabout-md.md)] how to do this, see [How to: Add and remove additional assemblies](../sharepoint/how-to-add-and-remove-additional-assemblies.md).

 When importing workflows, InfoPath forms are copied to the **Other Imported Files** folder. If the *.wsp* file contains a Web template, it is set as the startup page in **Solution Explorer**.

## Import fields and property bags
 When you import a solution that has multiple fields, all of the separate field definitions are merged into a single *Elements.xml* file under a node in **Solution Explorer** called **Fields**. Similarly, all property bag entries are merged into an *Elements.xml* file under a node called **PropertyBags**.

 Fields in SharePoint are columns of a specified data type, such as a text, Boolean, or lookup. For more information, see [Building Block: Columns and Field Types](/previous-versions/office/developer/sharepoint-2010/ee535893(v=office.14)). Property bags enable you to add properties to objects in SharePoint, everything from a farm to a list on a SharePoint site. Property bags are implemented as a hash table of property names and values. For more information, see [Managing SharePoint Configuration](/previous-versions/msp-n-p/ff647766(v=pandp.10)) or [SharePoint Property Bag Settings](https://www.codeproject.com/articles/43601/sharepoint-property-bag).

## Delete items in the project
 Most items in SharePoint solutions have one or more dependent items. For example, list instances depend on content types and content types depend on fields. After you import a SharePoint solution, [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] does not notify you of any reference problems if you delete an item in the solution, but not its dependent items, until you attempt to deploy the solution. For example, if an imported solution has a list instance that depends on a content type and you delete that content type, an error might occur on deployment. The error occurs if the dependent item is not present on the SharePoint server. Similarly, if a deleted item also has a related property bag, then delete those property bag entries from the **PropertyBags** *Elements.xml* file. Therefore, if you delete any items from an imported solution and you get deployment errors, check to see if any dependent items need to also be deleted.

## Restore missing feature attributes
 When importing solutions, some optional feature attributes are omitted from the imported feature manifest. If you want to restore these attributes in the new feature file, identify the missing attributes by comparing the original feature file to the new feature manifest and follow the instructions in the topic [How to: Customize a SharePoint feature](../sharepoint/how-to-customize-a-sharepoint-feature.md).

## Deployment conflict detection is not performed on built-in list instances
 [!include[vsprvs](../sharepoint/includes/vsprvs-md.md)] does not perform deployment conflict detection on built-in list instances (that is, default list instances that come with SharePoint). Not performing conflict detection is done to avoid overwriting the built-in list instances on SharePoint. The built-in list instances are still deployed or updated, but are never deleted or overwritten. [!INCLUDE[crdefault](../sharepoint/includes/crdefault-md.md)] [Troubleshoot SharePoint packaging and deployment](../sharepoint/troubleshooting-sharepoint-packaging-and-deployment.md).

## Import SharePoint Server 2010 workflows
 If you import a workflow created in [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)], it will not run correctly after you deploy it. The workflow does not run correctly because certain assemblies are missing and  [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)] workflows contain InfoPath forms which are not currently supported in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] workflow solutions. However, imported [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)] workflows can be made to work correctly after fixing some items, such as adding references to the [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)] assemblies and reconnecting the InfoPath forms. [!INCLUDE[crdefault](../sharepoint/includes/crdefault-md.md)] [Importing SharePoint Server 2010 Workflows](/sharepoint/dev/).

## Item name character limit
 [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] has a limit of 260 total characters for project and project item names, including the path. When importing a solution, if an item name exceeds this limit, you get the error:

 **The specified path, file name, or both are too long. The fully qualified file name must be less than 260 characters, and the directory name must be less than 248 characters.**

 When you get this error, the item is not created. This problem occurs most often with imported modules. To avoid this problem, do the following:

- Use short names for your project when you enter them in the **Add New Project** dialog box.

- Create the project in a location as close to the root folder as possible, so as to shorten the path.

## The SharePointProductVersion attribute
 If you import a solution created in an earlier version of SharePoint such as [!INCLUDE[winshare3](../sharepoint/includes/winshare3-md.md)] or [!INCLUDE[offshare7](../sharepoint/includes/offshare7-md.md)], either change the SharePointProductVersion attribute value in the package manifest to 12.0, or insert a script manager control into all imported Web pages and leave SharePointProductVersion set to 14.0. Otherwise, imported Web forms will not display in SharePoint.

### Background
 Solutions in [!INCLUDE[wss_14_short](../sharepoint/includes/wss-14-short-md.md)] and [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)] include an attribute called SharePointProductVersion. SharePoint uses this attribute in its package manifests to determine the version of SharePoint the solution is designed for. The two valid values are 12.0 and 14.0. A value of 12.0 indicates that the item is designed for [!INCLUDE[winshare3](../sharepoint/includes/winshare3-md.md)] or [!INCLUDE[offshare7](../sharepoint/includes/offshare7-md.md)]; a value of 14.0 indicates that the item is designed for [!INCLUDE[wss_14_short](../sharepoint/includes/wss-14-short-md.md)] or [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)].

 For enhanced security when rendering ASPX pages, [!INCLUDE[wss_14_short](../sharepoint/includes/wss-14-short-md.md)] and [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)] require that all ASPX or master pages contain a script manager control. For more information about script manager, see [ScriptManager Control Overview](/previous-versions/bb398863(v=vs.140)). Because the script manager control was not available in [!INCLUDE[winshare3](../sharepoint/includes/winshare3-md.md)] and [!INCLUDE[offshare7](../sharepoint/includes/offshare7-md.md)], one must be added to any [!INCLUDE[winshare3](../sharepoint/includes/winshare3-md.md)] or [!INCLUDE[offshare7](../sharepoint/includes/offshare7-md.md)] page that is upgraded to [!INCLUDE[wss_14_short](../sharepoint/includes/wss-14-short-md.md)] or [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)]. ASPX pages that use a standard master page do not require a script manager control because one is already added to the standard master page. However, ASPX pages that do not use a master page or that use a custom master page must add a script control in order to work in [!INCLUDE[wss_14_short](../sharepoint/includes/wss-14-short-md.md)] or [!INCLUDE[moss_14_short](../sharepoint/includes/moss-14-short-md.md)].

 The absence of a script manager control can be a problem when you import a [!INCLUDE[winshare3](../sharepoint/includes/winshare3-md.md)] or [!INCLUDE[offshare7](../sharepoint/includes/offshare7-md.md)] project into [!INCLUDE[vs_dev10_long](../sharepoint/includes/vs-dev10-long-md.md)], because the SharePointProductVersion attribute of all new projects is set to 14.0. If you deploy an upgraded project that has a Web form without a script manager, the form will not display in SharePoint.

## See also
- [Walkthrough: Import items from an existing SharePoint site](../sharepoint/walkthrough-import-items-from-an-existing-sharepoint-site.md)
- [Guidelines for importing reusable workflows](../sharepoint/guidelines-for-importing-reusable-workflows.md)
- [Walkthrough: Import a SharePoint Designer reusable workflow into Visual Studio](../sharepoint/walkthrough-import-a-sharepoint-designer-reusable-workflow-into-visual-studio.md)
- [How to: Add an existing BDC model file to a SharePoint project](../sharepoint/how-to-add-an-existing-bdc-model-file-to-a-sharepoint-project.md)
