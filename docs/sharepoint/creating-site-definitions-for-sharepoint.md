---
title: "Creating Site Definitions for SharePoint | Microsoft Docs"
description: Create site definitions for SharePoint. Site definitions determine the appearance and behavior of the SharePoint site and its default content and functionality.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: overview
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, site definitions"
  - "site definitions [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Create site definitions for SharePoint
  The SharePoint Site Definition project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] lets you create a *site definition*, which serves as a foundation for a new SharePoint site. These definitions not only determine the appearance and behavior of the SharePoint site, but also its default content and functionality. In the definition you can put preconfigured lists, content types, event receivers, images, and other items. SharePoint includes some site definitions such as BLOG, for example. When you create a site based on the BLOG site definition, the site contains the lists, Web parts, and other items that a blogging site requires.

 For more information about site definitions, see [Site Templates and Definitions](/previous-versions/office/developer/sharepoint-2010/ms434313(v=office.14)).

## Site definition projects
 Site definition projects in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] provide only the basic files that a SharePoint site needs; they do not provide any default functionality. You must add files and content to provide the functionality that you want. You can build the site manually, by creating and adding the files that you need.

## Feature stapling
 One benefit of creating site definitions in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] is that they automatically use *Feature Stapling*. Feature Stapling attaches a feature to a site definition instead of embedding its functionality in the site definition itself. Doing this lets you add the feature to any site created by using the site definition without modifying the original site definition. For more information, see [Feature Stapling](/previous-versions/office/developer/sharepoint-2007/bb861862(v=office.12)).

## Site definition project components
 When you create a site definition solution, the following default files are added to its **SiteDefinition** node.

|File Name|Description|
|---------------|-----------------|
|*default.aspx*|The default ASPX home page for the new SharePoint site.|
|*onet.xml*|Specifies the configuration of the new site, the components of the site definition template, and default behavior. These settings can include attributes such as the content types that are enabled, the default list views, document template files, and Web parts included with the site. By default, the `Modules` section lists the files to be added to the SharePoint site and how they are configured.|
|*webtemp_\<SiteDefinitionName>.xml*|Specifies the site definition configurations that appears in the **Template Selection** section of the **New SharePoint Site** page.|

 By default, all site definitions are stored in the *\<drive:>\Program Files\Common Files\Microsoft Shared\Web Server Extensions\14\TEMPLATE\SiteTemplates* folder. Each site definition has its own subfolder.

## Related topics

|Title|Description|
|-----------|-----------------|
|[Walkthrough: Create a Basic Site Definition Project](../sharepoint/walkthrough-create-a-basic-site-definition-project.md)|Leads you step-by-step through the creation of a basic site definition project in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].|
|[How to: Create a Custom Site Definition and Configuration](/previous-versions/office/developer/sharepoint-2010/ms454677(v=office.14))|Describes how to create a custom site definition in SharePoint by copying an existing site definition and then modifying the copy.|
|[*WebTemp.xml*](/previous-versions/office/developer/sharepoint-2010/ms447717(v=office.14))|Describes the original file that specifies the site definitions available in the **Template Selection** section of the **New SharePoint Site** page.|
|[Localize SharePoint solutions](../sharepoint/localizing-sharepoint-solutions.md)|Describes how to prepare your SharePoint solutions for global use.|
|[Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)|Describes how you can create parts of a SharePoint page that users can modify.|
|[Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)|Describes how you can create reusable controls that run in application pages and Web Parts.|
|[Visual Web Developer](/previous-versions/visualstudio/visual-studio-2010/ms178093(v=vs.100))|Describes how to use the designer that appears when you open a Web page in your project.|
|[ASP.NET Web Pages Overview](/previous-versions/aspnet/428509ah(v=vs.100))|Provides general information about the structure of [!INCLUDE[vstecasp](../sharepoint/includes/vstecasp-md.md)] Web pages, how pages are processed by [!INCLUDE[vstecasp](../sharepoint/includes/vstecasp-md.md)], and how [!INCLUDE[vstecasp](../sharepoint/includes/vstecasp-md.md)] pages display markup that complies with XHTML standards.|
|[ASP.NET Web Page Syntax](/previous-versions/aspnet/k33801s3(v=vs.100))|Describes the markup elements that make up an ASP.NET page.|
|[Programming ASP.NET Web Pages](/previous-versions/aspnet/0yt4zca8(v=vs.100))|Provides information about how to create event handlers in [!INCLUDE[vstecasp](../sharepoint/includes/vstecasp-md.md)] pages and how to work with client script.|
|[Programming in Windows SharePoint Services](/previous-versions/office/developer/sharepoint-services/ms430674(v=office.12))|Describes how to use the managed object model that is provided in [!INCLUDE[sharepointShort](../sharepoint/includes/sharepointshort-md.md)].|

## See also
- [Develop SharePoint solutions](../sharepoint/developing-sharepoint-solutions.md)
