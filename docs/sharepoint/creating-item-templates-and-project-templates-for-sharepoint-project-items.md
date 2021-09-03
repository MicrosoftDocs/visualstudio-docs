---
title: "Item templates/project templates for SharePoint project items"
description: Create item templates and project templates for SharePoint project items. Create wizards for item templates and project templates.
ms.custom: SEO-VS-2020
titleSuffix: ""
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint project items, creating custom templates"
  - ".spdata files"
  - "projects [SharePoint development in Visual Studio], creating custom templates"
  - "SharePoint projects, creating custom templates"
  - "SharePoint development in Visual Studio, creating custom project and item templates"
  - "project items [SharePoint development in Visual Studio], creating custom templates"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# Create item templates and project templates for SharePoint project items

When you define a custom SharePoint project item type, you can associate it with an item template or a project template. This association allows other developers to use the project item in Visual Studio. You can also create a wizard for the template.

For example, Visual Studio does not include a project template or item template for adding a field to a SharePoint site. You can define a SharePoint project item type that represents a field and then construct an item template that other developers can use to add the field item to a SharePoint project. Or, you can construct a project template so that developers can create a new SharePoint project that has the field item. In both cases, you can also provide a wizard that appears when developers use your template. This wizard can collect information from developers to configure the new item or project.

Item templates and project templates are *.zip* files that contain files that are used by Visual Studio to create a project item or project. For more information about the fundamentals of item templates and project templates, see [Create project and item templates](../ide/creating-project-and-item-templates.md).

## Create item templates
 When you create an item template for a SharePoint project item, there are some files that are always required, and optional files that might be used by certain types of project items. For a walkthrough that demonstrates how to define a SharePoint project item type and create an item template for it, see [Walkthrough: create custom action project item with an item template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md).

 The following table lists the required files to create an item template for a SharePoint project item.

|Required file|Description|
|-------------------|-----------------|
|An *.spdata* file|This XML file specifies the contents and default behavior of the project item. This file must be included in the item template. For more information about the contents of *.spdata* files, see [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md).|
|A *.vstemplate* file.|This file provides Visual Studio with the information required to display the template in the **Add New Item** dialog box and to create a project item from the template. This file must be included in the item template. For more information, see [Visual Studio Template Metadata Files](/previous-versions/visualstudio/visual-studio-2010/xsxc3ete\(v\=vs.100\)).|
|A Visual Studio extension assembly that implements the <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> interface.|This assembly defines the run time behavior of the project item. This assembly must be included in the VSIX package with the item template. For more information, see [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md) and [Deploy extensions for the SharePoint tools in Visual Studio](../sharepoint/deploying-extensions-for-the-sharepoint-tools-in-visual-studio.md).|

 The following table lists some of the most common optional files that can be included in the item template. Some types of project items might require other files not listed here.

| Optional File | Description |
|----------------------| - |
| *Elements.xml* | A *Feature element* file. This file defines the UI and behavior of the customization created by the project item. Each type of customization, such as list instances, content types, or custom actions, has a different schema that defines the contents of this file. For more information, see [Building Block: Features](/previous-versions/office/developer/sharepoint-2010/ee537350(v=office.14)) and [Feature Schemas](/previous-versions/office/developer/sharepoint-2010/ms414322(v=office.14)). |
| *Schema.xml* | The schema file for list definitions. For more information, see [Building Block: Lists and Document Libraries](/previous-versions/office/developer/sharepoint-2010/ee534985(v=office.14)) and [Schema.xml](/previous-versions/office/developer/sharepoint-2010/ms459356(v=office.14)). |
| *.webpart* | A *Web Part definition* file. This file contains property settings for a Web Part. For more information, see [Building Block: Web Parts](/previous-versions/office/developer/sharepoint-2010/ee535520(v=office.14)). |
| *.ascx* | An ASP.NET UserControl file. This file defines the UI of a Visual Web Part. |
| *.aspx* | An ASP.NET page file. This file contains XML markup that defines an application page. |
| *.cs* or *.vb* files | These code files define the behavior of SharePoint customizations that have a programming model that can be accessed from Visual C# or Visual Basic code, such as application pages, Web parts, and workflows. |

## Create project templates
 When you create a SharePoint project template, there are some files that are always required, and optional files that might be used by certain types of projects. Typically, SharePoint projects include at least one SharePoint project item. However, this is not required. For example, you could define a SharePoint project template that is intended to be used only to deploy SharePoint solutions created in other projects.

 For a walkthrough that demonstrates how to define a SharePoint project item type and create a project template for it, see [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md).

 The following table lists the files that must be included in a SharePoint project template.

|Required file|Description|
|-------------------|-----------------|
|A *.vstemplate* file|This file provides Visual Studio with the information required to display the template in the **New Project** dialog box and to create a project from the template. For more information, see [Visual Studio Template Metadata Files](/previous-versions/visualstudio/visual-studio-2010/xsxc3ete\(v\=vs.100\)).|
|A *.csproj* or *.vbproj* file|This is the project file. It defines the contents and configuration settings of the project.|
|*Package.package*|This file defines the deployment package for the project. When you use the Package Designer to customize the solution package for your project, Visual Studio stores data about the solution package in this file.<br /><br /> When you create a custom SharePoint project template, we recommend that you include only the minimum required content in the *Package.package* file, and that you configure the solution package by using the APIs in the <xref:Microsoft.VisualStudio.SharePoint.Packages> namespace in an extension that is associated with the project template. If you do this, your project template is protected from future changes to the structure of the *Package.package* file. For an example that demonstrates how to create a *Package.package* file with only the minimum required content, see [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md).<br /><br /> If you want to modify the *Package.package* file directly, you can verify the contents by using the schema at *%Program Files (x86)%\Microsoft Visual Studio 11.0\Xml\Schemas\PackageModelSchema.xsd*.|
|*Package.Template.xml*|This file provides the basis for the solution manifest file (*manifest.xml*) for the SharePoint solution package (*.wsp*) that is generated from the project. You can add content to this file if you want to specify some behavior that is not intended to be changed by users of your project type. For more information, see [Building Block: Solutions](/previous-versions/office/developer/sharepoint-2010/ee537008(v=office.14)) and [Solution Schema](/sharepoint/dev/schema/solution-schema).<br /><br /> When you build a solution package from the project, Visual Studio merges the contents of the *Package.package* and the *Package.Template.xml* files into the solution manifest file. For more information about building solution packages, see [How to: Create a SharePoint Solution Package by using MSBuild tasks](../sharepoint/how-to-create-a-sharepoint-solution-package-by-using-msbuild-tasks.md).|

 The following table lists the optional files that can be included in the project template.

|Optional file|Description|
|-------------------|-----------------|
|SharePoint project items|You can include one or more .spdata files that define SharePoint project item types. Each *.spdata* file must have a matching <xref:Microsoft.VisualStudio.SharePoint.ISharePointProjectItemTypeProvider> implementation in an extension assembly that is included in the VSIX package with the project template. For more information, see [Create item templates](#create-item-templates).<br /><br /> Typically, SharePoint projects include at least one SharePoint project item. However, this is not required.|
|*\<featureName>.feature*|This file defines a SharePoint Feature that is used to group several project items for deployment. When you use the Feature Designer to customize a Feature in your project, Visual Studio stores data about the Feature in this file. If you want to group the project items into different Features, you can include multiple *.feature* files.<br /><br /> When you create a custom SharePoint project template, we recommend that you include only the minimum required content in each *.feature* file, and that you configure Features by using the APIs in the <xref:Microsoft.VisualStudio.SharePoint.Features> namespace in an extension that is associated with the project template. If you do this, your project template is protected from future changes to the structure of the *.feature* file. For an example that demonstrates how to create a *.feature* file with only the minimum required content, see [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md).<br /><br /> If you want to modify a *.feature* file directly, you can verify the contents by using the schema at *%Program Files (x86)%\Microsoft Visual Studio 11.0\Xml\Schemas\FeatureModelSchema.xsd*.|
|*\<featureName>.Template.xml*|This file provides the basis for the feature manifest file (*Feature.xml*) for each Feature that is generated from the project. You can add content to this file if you want to specify some behavior that is not intended to be changed by users of your project type. For more information, see [Building Block: Features](/previous-versions/office/developer/sharepoint-2010/ee537350(v=office.14)) and [Feature.xml](/sharepoint/dev/schema/feature-xml-files) Files.<br /><br /> When you build a solution package from the project, Visual Studio merges the contents of each pair of *\<featureName>.feature* file and *\<featureName>.Template.xml* files into a feature manifest file. For more information about building solution packages, see [How to: Create a SharePoint Solution Package by using MSBuild tasks](../sharepoint/how-to-create-a-sharepoint-solution-package-by-using-msbuild-tasks.md).|

## Create wizards for item templates and project templates
 After you define a SharePoint project item type and associate it with an item or project template, you can also create a wizard. The wizard displays when a developer uses the item template to add the SharePoint project item to a project, or when a developer uses the project template to create a new project that contains the SharePoint project item. The wizard can be used to collect information from developers and to initialize the new SharePoint project item.

 For walkthroughs that demonstrate how to create wizards for item templates and project templates, see [Walkthrough: Create a custom action project item with an item template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md) and [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md).

## See also

- [Define custom SharePoint project item types](../sharepoint/defining-custom-sharepoint-project-item-types.md)
- [Walkthrough: Create a custom action project item with an item template, Part 1](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-1.md)
- [Walkthrough: Create a custom action project item with an item template, Part 2](../sharepoint/walkthrough-creating-a-custom-action-project-item-with-an-item-template-part-2.md)
- [Walkthrough: Create a site column project item with a project template, Part 1](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-1.md)
- [Walkthrough: Create a site column project item with a project template, Part 2](../sharepoint/walkthrough-creating-a-site-column-project-item-with-a-project-template-part-2.md)
- [Create project and item templates](../ide/creating-project-and-item-templates.md)
