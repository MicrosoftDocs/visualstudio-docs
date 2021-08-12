---
title: "Creating Web Parts for SharePoint | Microsoft Docs"
description: Create web parts for SharePoint. By using web parts, you can modify the content, appearance, and behavior of pages of a SharePoint site by using a browser.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: overview
f1_keywords:
  - "Microsoft.SharePoint.WebControls.DateTimeControl"
  - "Microsoft.SharePoint.WebControls.CssLink"
  - "Microsoft.SharePoint.WebControls.RssLink"
  - "Microsoft.SharePoint.WebControls.Theme"
  - "Microsoft.SharePoint.WebControls.AspMenu"
  - "Microsoft.SharePoint.WebControls.ListProperty"
  - "Microsoft.SharePoint.WebControls.ProjectProperty"
  - "Microsoft.SharePoint.WebControls.FormsDigest"
  - "Microsoft.SharePoint.WebControls.ScriptLink"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, Web Parts"
  - "Web Parts [SharePoint development in Visual Studio], designing"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Create web parts for SharePoint
  By using web parts, you can modify the content, appearance, and behavior of pages of a SharePoint site by using a browser. Web parts are server-side controls that run inside a web part page: they're the building blocks of pages that appear on a SharePoint site. See [Building Block: Web Parts](/previous-versions/office/developer/sharepoint-2010/ee535520(v=office.14)).

 You can create and debug web parts on a SharePoint site by using templates from Visual Studio.

## Create a web part in Visual Studio
 Create a web part by adding a **Web Part** item to any SharePoint project. You can use a **Web Part** item in a sandboxed solution or a farm solution.

 If you want to design a web part visually by using a designer, create a **Visual Web Part** project or add **Visual Web Part** item to any SharePoint project. You can use a **Visual Web Part** item in a farm solution only.

### Web part item
 A **Web Part** item provides files that you can use to design a web part for a SharePoint site. When you add a **Web Part** item, Visual Studio creates a folder in your project and then adds several files to the folder. The following table describes each file.

|File|Description|
|----------|-----------------|
|*Elements.xml*|Contains information that the Feature definition file in your project uses to deploy the web part.|
|.webpart file|Provides information that SharePoint needs to display your web part in a web part gallery.|
|Code File|Contains methods that add controls to the web part and that generate custom content within the web part.|

 For more information, see [How to: Create a SharePoint web part](../sharepoint/how-to-create-a-sharepoint-web-part.md).

### Visual web part item
 A visual web part is a web part that you create by using the Visual Web Developer designer in Visual Studio. A visual web part functions the same as any other web part. To add controls, such as buttons and text boxes, to a web part, you add code to an XML file. However, you add controls to a visual web part by dragging or copying them onto the web part from the Visual Studio **Toolbox**. The designer then generates the required code in the XML file. See [How to: Create SharePoint web part by using a designer](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md).

## SharePoint controls
 Visual Studio provides some controls for creating SharePoint pages, such as application pages. These controls appear in the **Toolbox** under **SharePoint Controls**. The functionality for these controls derives from the [Microsoft.SharePoint.WebControls](/previous-versions/office/sharepoint-server/ms413880(v=office.15)) namespace, which contains ASP.NET server controls that are used on SharePoint site and list pages.

|Control Name|Description|
|------------------|-----------------|
|[AspMenu](/previous-versions/office/sharepoint-server/ms454108(v=office.15))|Inserts an ASP menu. For more information, see [Menu Control Overview](/previous-versions/ecs0x9w5(v=vs.140)).|
|[CssLink](/previous-versions/office/sharepoint-server/ms439048(v=office.15))|Inserts a **LINK** element into the *.aspx* page and applies one or more external style sheets defined by **CssRegistration**.|
|[DateTimeControl](/previous-versions/office/sharepoint-server/ms414993(v=office.15))|Inserts a DateTime control into the *.aspx* page.|
|[FormDigest](/previous-versions/office/sharepoint-server/ms416616(v=office.15))|Inserts a security validation into the *.aspx* page|
|[ListProperty](/previous-versions/office/sharepoint-server/ms455032(v=office.15))|Returns a property of a specified list.|
|[ProjectProperty](/previous-versions/office/sharepoint-server/ms478990(v=office.15))|Returns a global property of the current website.|
|[RssLink](/previous-versions/office/sharepoint-server/ms457574(v=office.15))|Inserts a link to an RSS feed into the *.aspx* page.|
|[ScriptLink](/previous-versions/office/sharepoint-server/ms411959(v=office.15))|Provides properties and methods for registering resources, such as scripts, on a page so that they can be requested when the page is rendered.|
|[Theme](/previous-versions/office/sharepoint-server/ms460735(v=office.15))|Applies a theme to the *.aspx* page.|

## Debug a web part
 You can debug a SharePoint project that contains a web part just as you would debug other Visual Studio projects. When you start the Visual Studio debugger, Visual Studio opens the SharePoint site.

 To start to debug your code, add the web part to a web part page in SharePoint.

 For more information about how to debug SharePoint projects, see [Troubleshoot SharePoint solutions](../sharepoint/troubleshooting-sharepoint-solutions.md).

## Visual web part limitations
 Starting in Visual Studio, you can add visual web parts to sandboxed SharePoint solutions and farm solutions. However, visual web parts have the following limitations:

- Visual web parts don't support Replaceable parameters. For more information, see [Replaceable parameters](../sharepoint/replaceable-parameters.md).

- User controls or visual web parts can't be dragged and dropped or copied onto visual web parts. This action causes a build error.

- Visual web parts don't directly support SharePoint server tokens such as $SPUrl. For more information, see "Token Restrictions in Sandboxed Visual Web Parts" in the topic [Troubleshoot SharePoint solutions](../sharepoint/troubleshooting-sharepoint-solutions.md).

- Visual web parts in a sandboxed solution occasionally get the error, "The sandboxed code execution request was refused because the Sandboxed Code Host Service was too busy to handle the request." For more information about this error, see this post in the [SharePoint Developer Team Blog](/archive/blogs/sharepointdev/error-the-sandboxed-code-execution-request-was-refused-because-the-sandboxed-code-host-service-was-too-busy-to-handle-the-request-ricky-kirkham#10149157).

- Server-side JavaScript debugging isn't supported in Visual Studio, but client-side JavaScript debugging is supported.

   Although you can add inline JavaScript to a server-side markup file, debugging isn't supported for breakpoints added to the markup. To debug JavaScript, reference an external JavaScript file in the markup file, and then set the breakpoints in the JavaScript file.

- Debugging of inline [!INCLUDE[vstecasp](../sharepoint/includes/vstecasp-md.md)] code must be done in the generated code file instead of in the markup file.

- Visual web parts don't support the use of the `<@ Assembly Src=` directive.

- SharePoint web controls and some [!INCLUDE[vstecasp](../sharepoint/includes/vstecasp-md.md)] controls aren't supported in the SharePoint sandboxed environment. If unsupported controls are used on a visual web part in a sandboxed solution, the error, "The type or namespace name 'Theme' does not exist in the namespace 'Microsoft.SharePoint.WebControls'" appears.

  For more information about sandboxed solutions, see [Differences between sandboxed and farm solutions](../sharepoint/differences-between-sandboxed-and-farm-solutions.md).

## Create older style SharePoint-based web parts
 You can use the templates in Visual Studio to create custom [!INCLUDE[vstecasplong](../sharepoint/includes/vstecasplong-md.md)] web parts for SharePoint. [!INCLUDE[vstecasplong](../sharepoint/includes/vstecasplong-md.md)] web parts are built on top of the [!INCLUDE[vstecasp](../sharepoint/includes/vstecasp-md.md)] web part infrastructure and are the recommended type for new projects.

 In very few cases, you might have to create a web part by using the older style SharePoint-based web part. You can use Visual Studio to create these types of web parts, but Visual Studio doesn't provide any templates that are designed specifically to help you create them.

 For more information about when you might want to create an older style SharePoint-based web part, see [Web Part Infrastructure in Windows SharePoint Services](/previous-versions/office/developer/sharepoint-2010/ms415560(v=office.14)). For more information about how to create a web part by using the older style SharePoint-based web part, see [Walkthrough Creating a Basic SharePoint Web Part](/previous-versions/office/ms452873(v=office.14)).

## Related topics

|Title|Description|
|-----------|-----------------|
|[How to: Create a SharePoint web part](../sharepoint/how-to-create-a-sharepoint-web-part.md)|Shows you how to create web parts for SharePoint pages.|
|[How to: Create a SharePoint web part by using a designer](../sharepoint/how-to-create-a-sharepoint-web-part-by-using-a-designer.md)|Shows you how to create web parts for SharePoint by using a visual design surface.|
|[How to: Create a user control for a SharePoint application page or web part](../sharepoint/how-to-create-a-user-control-for-a-sharepoint-application-page-or-web-part.md)|Shows you how to create custom, reusable controls that can be consumed by application pages and web parts that run in SharePoint.|
|[Walkthrough: Create a web part for SharePoint](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint.md)|Describes how to design a web part for SharePoint.|
|[Walkthrough: Create a web part for SharePoint by using a designer](../sharepoint/walkthrough-creating-a-web-part-for-sharepoint-by-using-a-designer.md)|Describes how to design a web part for SharePoint by dragging controls to a visual design surface.|
|[Walkthrough: Create Silverlight web part that displays OData for SharePoint](../sharepoint/walkthrough-creating-a-silverlight-web-part-that-displays-odata-for-sharepoint.md)|Describes how to design a web part for SharePoint that hosts a Silverlight application and displays data from SharePoint lists.|