---
title: "Developing SharePoint Solutions | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
f1_keywords:
  - "VS.SharePointTools.Project.ProjectProperties"
  - "VS.SharePointTools.Project.ProjectItemProperties"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, overview"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Develop SharePoint solutions
  Several SharePoint project type templates are available in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] for creating SharePoint sites and site elements. For a list of the available project types, see [SharePoint project and project item templates](../sharepoint/sharepoint-project-and-project-item-templates.md). Following is a description of the elements and properties of a SharePoint project.

 For information about SharePoint 2013 and SharePoint add-ins, see [SharePoint 2013](https://products.office.com/previous-versions/microsoft-sharepoint-2013) and [Build SharePoint add-ins](/sharepoint/dev/sp-add-ins/sharepoint-add-ins).

## Elements of a SharePoint project
 The nodes under a SharePoint project are known as *SharePoint items*. SharePoint items may also contain one or more subfiles, referred to as *SharePoint item files*, such as [!INCLUDE[TLA2#tla_xml](../sharepoint/includes/tla2sharptla-xml-md.md)] configuration files, .aspx forms, and more.

 Instead of creating projects by using project templates that are already populated with project item files, you can use the **Empty Project** template to create an empty SharePoint project and then add project items manually. SharePoint projects can also optionally contain one or more feature files (for activation in SharePoint) and a package file in which to distribute the project.

### Special nodes
 Every SharePoint project contains two nodes that cannot be renamed, deleted, cut, copied, or dragged from the project. These nodes are as follows:

- Features
- Package

  Both nodes always appear in all SharePoint projects even if no features or packages are defined for the project.

#### Features node
 The **Features** node contains one or more SharePoint project features. A feature is a container of extensions for SharePoint. After a feature is deployed to SharePoint server, it can be included in site definitions or activated individually by SharePoint administrators on SharePoint sites. For more information, see [Working with Features](/previous-versions/office/developer/sharepoint-2010/ms460318(v=office.14)).

 When you add an item, such as a content type or a list instance, to a SharePoint project, it is added to a feature in the **Features** node. The scope of the item determines whether it is added to a new or existing feature. If the new item has the same scope as an existing feature, then it is added to that feature. Otherwise, the item is added to a new feature.

 To manually add a feature, execute the **Add Feature** command on the feature node's shortcut menu. You can view or change the contents of a feature by using the Feature Designer. For more information, see [How to: Customize a SharePoint feature](../sharepoint/how-to-customize-a-sharepoint-feature.md).

 When a feature is added to a SharePoint project, it appears in **Solution Explorer** as a node with the default name Feature*x*.feature, where *x* is a unique number. After a feature is deployed to the SharePoint Server, a SharePoint administrator can activate it, making it available to SharePoint site users.

#### Package node
 The **Package** node contains a single file that serves as the distribution mechanism for the SharePoint project. This file, known as a *solution package*, is .CAB-based with a .WSP extension. A solution package is a deployable, reusable file that contains a set of features, site definitions, and assemblies that apply to SharePoint sites, and that you can enable or disable individually. The **Package** node also always contains a file that is named Package.wspdef, an [!INCLUDE[TLA2#tla_xml](../sharepoint/includes/tla2sharptla-xml-md.md)] definition file for the package. Once a package is deployed to the server that's running SharePoint, the SharePoint administrator can install it and activate its features.

 You can view or change the package's contents in the Package Designer either by double-clicking the package node or by opening its shortcut menu and then choosing **Open**. For more information, see [Create SharePoint solution packages](../sharepoint/creating-sharepoint-solution-packages.md).

## SharePoint project and project item properties
 SharePoint projects, just like other [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] projects, display properties in the Properties window and the Properties Page. The properties that are displayed depend on the node that is selected.

 When a SharePoint project, project item, or project item file node is selected in **Solution Explorer**, the following properties appear in the Properties window or the Properties Page:

### Project properties

|Property Name|Description|
|-------------------|-----------------|
|Active Deployment Configuration|Specifies the series of steps performed during deployment. For more information, see [How to: Edit a SharePoint deployment configuration](../sharepoint/how-to-edit-a-sharepoint-deployment-configuration.md).|
|Assembly Deployment Target|Determines where *SharePoint application assemblies* are located. Valid assembly location values are either *GlobalAssemblyCache* (default), or *WebApplication*.<br /><br /> If the *Sandboxed Solution* property is set to **true**, then this property is disabled.|
|Auto-retract after debugging|Specifies whether the deployed solution automatically retracts from SharePoint after running the application in debug mode in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)]. When selected, the solution retracts when the IDE goes back to design view after debugging. When cleared, the solution does not retract. For more information, see [Retracting a Solution](/previous-versions/office/developer/sharepoint-2010/aa543958(v=office.14)).|
|Edit Configurations|Specifies the deployment configuration to use for the project. For more information, see [How to: Edit a SharePoint deployment configuration](../sharepoint/how-to-edit-a-sharepoint-deployment-configuration.md) and [Deploy, publish, and upgrade SharePoint solution packages](../sharepoint/deploying-publishing-and-upgrading-sharepoint-solution-packages.md).|
|Enable Silverlight Debugging (instead of Script debugging)|When selected, the Silverlight debugger attaches to the debugging process. When cleared, the Script debugger attaches to the debugging process. For more information, see [Silverlight Debugging Overview](/previous-versions/windows/).|
|Include Assembly in Package|Specifies whether the project assembly is packaged at build time or not.|
|Post-deployment Command Line|Specifies the commands to run after deploying the SharePoint solution. This line supports any batch commands as well as the resolution of MSBuild variables. For more information, see [How to: Set SharePoint Deployment Commands](../sharepoint/how-to-set-sharepoint-deployment-commands.md).|
|Pre-deployment Command Line|Specifies the commands to run before deploying the SharePoint solution. This line supports any batch commands as well as the resolution of MSBuild variables. For more information, see [How to: Set SharePoint Deployment Commands](../sharepoint/how-to-set-sharepoint-deployment-commands.md).|
|Project File|The name of the file containing build, configuration, and other information about the project.|
|Project Folder|The location of the project file on the system. (Read-only.)|
|Sandboxed Solution|Specifies whether the project should be deployed as a *sandboxed solution*, also known as a *user-created solution*. Sandboxed solutions are not necessarily trustworthy. A value of **true** means that the project is deployed as a sandboxed solution, a value of **false** means that the project is deployed as a farm solution. For more information, see [Sandboxed Solution Considerations](../sharepoint/sandboxed-solution-considerations.md) and [Differences Between Sandboxed and Farm Solutions](../sharepoint/differences-between-sandboxed-and-farm-solutions.md).|
|Site URL|Specifies the [!INCLUDE[TLA2#tla_url](../sharepoint/includes/tla2sharptla-url-md.md)] of the target site for this project.|
|Startup Item|Specifies the first item in the project to run.|

 When you choose a SharePoint item file (such as a workflow or a feature in the Features node), the following properties appear in the Properties window:

### Project item properties

|Property Name|Description|
|-------------------|-----------------|
|Deployment Conflict Resolution|Specifies the action to take when deploying a project item whose properties are identical to those of an item already on the server. For more information, see [Troubleshooting SharePoint Packaging and Deployment](../sharepoint/troubleshooting-sharepoint-packaging-and-deployment.md).|
|Feature Properties|Specifies a set of values (stored as key/value pairs) that is included with a feature when it deploys to SharePoint. After the feature is deployed, you can access the property values in your code. For more information, see [Providing Packaging and Deployment Information in Project Items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).|
|Feature Receiver|Provides code that executes when certain events occur to a project item's containing feature. For more information, see [Providing Packaging and Deployment Information in Project Items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).|
|Folder Name|The name of the SharePoint project item folder.|
|Project Output References|Specifies a dependency, such as an assembly, that your project item needs to run. For more information, see [Providing Packaging and Deployment Information in Project Items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).|
|Safe Control Entries|Specifies controls that are safe for untrusted users to edit. For more information, see [Providing Packaging and Deployment Information in Project Items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).|

### Project item file properties

|Property Name|Description|
|-------------------|-----------------|
|Build Action|Specifies how the file relates to the build and deployment processes. For more information, see [File Properties](/previous-versions/visualstudio/visual-studio-2010/0c6xyb66\(v\=vs.100\)).|
|Copy to Output Directory|Specifies whether the source file(s) will be copied to the Output directory. Can be one of the following values:<br /><br /> -   *Do not copy*<br />-   *Copy always*<br />-   *Copy if newer*<br /><br /> For more information, see [File Properties](/previous-versions/visualstudio/visual-studio-2010/0c6xyb66\(v\=vs.100\)).|
|Custom Tool|Specifies the name of a tool, if any, that transforms the file at design time and puts the output of the transformation into another file. For example, a dataset (.[!INCLUDE[TLA2#tla_xsd](../sharepoint/includes/tla2sharptla-xsd-md.md)]) file has a default custom tool. For more information, see [File Properties](/previous-versions/visualstudio/visual-studio-2010/0c6xyb66\(v\=vs.100\)).|
|Custom Tool Namespace|The namespace into which the output of the custom tool is copied. For more information, see [File Properties](/previous-versions/visualstudio/visual-studio-2010/0c6xyb66\(v\=vs.100\)).|
|Deployment Location|The fully-qualified path of the file on the SharePoint server. This path is composed of the Deployment Root and Deployment Path sub-properties.|
|Deployment Path|The relative path of the file on the SharePoint Server file, such as Workflow1\\. The fully-qualified path for the file is created by concatenating the *Deployment Path* value to the end of the *Deployment Root* value.<br /><br /> Selecting a value of *RootFile* for the *Deployment Type* property changes the *Deployment Root* property to \<SharePointRoot>\\, resulting in a fully-qualified path of \<SharePointRoot>\Workflow1\\. For more information, see [Packaging and Deploying SharePoint Solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md).|
|Deployment Root|String. The root folder where the file is deployed on the SharePoint Server. For example, \<SharePointRoot>\Template\Features\\\<FeatureName>\\.<br /><br /> The value of the *Deployment Root* property is determined by the *Deployment Type* setting.|
|Deployment Type|The file's deployment type, which determines its *Deployment Root* value. Can be one of the following values:<br /><br /> NoDeployment: *\<no value>*<br /><br /> ElementManifest: *\<SharePointRoot>\Template\Features\\\<FeatureName>*\\<br /><br /> ElementFile: *\<SharePointRoot>\Template\Features\\\<FeatureName>\\*<br /><br /> TemplateFile: *\<SharePointRoot>\Template\\*<br /><br /> RootFile: *\<SharePointRoot>\\*<br /><br /> GlobalResource: *\<SharePointRoot>\Resources\\*<br /><br /> ClassResource: *\<ClassResourcePath>\\*<br /><br /> For more information, see <xref:Microsoft.VisualStudio.SharePoint.DeploymentType>.|
|File Name|The name of the file or folder for the item file.|
|Full Path|The location of the file for the item. (Read-only.)|

## Related topics

|Title|Description|
|-----------|-----------------|
|[SharePoint Project and Project Item Templates](../sharepoint/sharepoint-project-and-project-item-templates.md)|Describes the SharePoint project and project item templates available to you in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].|
|[How to: Add Items to a SharePoint Project](../sharepoint/how-to-add-items-to-a-sharepoint-project.md)|Describes how to add new or existing items to a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint project.|
|[Walkthrough: Create a site column, content type, and list for SharePoint](../sharepoint/walkthrough-create-a-site-column-content-type-and-list-for-sharepoint.md)|Leads you step-by-step in creating a customer field, content type, list definition, and list instance.|
|[How to: Create an Event receiver](../sharepoint/how-to-create-an-event-receiver.md)|Describes how to add an event receiver for the project created in [Walkthrough: Create a site column, content type, and list for SharePoint](../sharepoint/walkthrough-create-a-site-column-content-type-and-list-for-sharepoint.md).|
|[Create SharePoint workflow solutions](../sharepoint/creating-sharepoint-workflow-solutions.md)|Describes how to create workflow projects that includes workflow association forms and workflow initiation forms.|
|[Create pages for SharePoint](../sharepoint/creating-pages-for-sharepoint.md)|Describes how you can create pages such as application pages, site pages, master pages, and page layouts for SharePoint.|
|[Create web parts for SharePoint](../sharepoint/creating-web-parts-for-sharepoint.md)|Describes how to add controls that enable users to directly modify the content, appearance, and behavior of SharePoint site pages by using a browser.|
|[Create reusable controls for web parts or application pages](../sharepoint/creating-reusable-controls-for-web-parts-or-application-pages.md)|Describes how to create user controls that can be consumed by application pages and Web Parts that run in SharePoint.|
|[Integrate business data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md)|Describes how to integrate data from Web services and back-end server applications into a SharePoint application.|
|[Create site definitions for SharePoint](../sharepoint/creating-site-definitions-for-sharepoint.md)|Describes how to create site definitions: templates that are used to create SharePoint sites.|
|[Importing Items from an Existing SharePoint Site](../sharepoint/importing-items-from-an-existing-sharepoint-site.md)|Describes how to import items such as content types and modules from an existing SharePoint site into a [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] SharePoint project.|
|[Using Modules to Include Files in the Solution](../sharepoint/using-modules-to-include-files-in-the-solution.md)|Describes how to use modules to deploy files from your [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)] project to the SharePoint site.|
|[Browse SharePoint connections using Server Explorer](../sharepoint/browsing-sharepoint-connections-using-server-explorer.md)|Describes how to browse local SharePoint sites by using Server Explorer.|
|[Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)|Describes how to use project item properties to provide packaging and deployment information for projects, such as safe control entries, project output references, and feature properties.|
|[How to: Add and remove mapped folders](../sharepoint/how-to-add-and-remove-mapped-folders.md)|Describes how mapped folders can be added to your project to provide easier access to SharePoint resources.|
|[Sandboxed solution considerations](../sharepoint/sandboxed-solution-considerations.md)|Describes the issues associated with sandboxed solutions.|
|[Security for SharePoint Solutions](../sharepoint/security-for-sharepoint-solutions.md)|Describes security considerations for developing SharePoint solutions in [!INCLUDE[vsprvs](../sharepoint/includes/vsprvs-md.md)].|
|[URL picker dialog box &#40;SharePoint development in Visual Studio&#41;](../sharepoint/url-picker-dialog-box-sharepoint-development-in-visual-studio.md)|Describes a dialog box that you can use to add path references to resources in your project or on the local SharePoint server.|

## See also
- [Get started &#40;SharePoint Development in Visual Studio&#41;](../sharepoint/getting-started-sharepoint-development-in-visual-studio.md)
- [Browse SharePoint connections using Server Explorer](../sharepoint/browsing-sharepoint-connections-using-server-explorer.md)
- [Build and debug SharePoint solutions](../sharepoint/building-and-debugging-sharepoint-solutions.md)
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
