---
title: "Creating SharePoint Solution Packages"
description: Create and customize deployment packages for SharePoint solutions using the Package Designer. Explore packaging tools, designer options, and folder structure.
ms.date: "02/02/2017"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, packages"
  - "packages [SharePoint development in Visual Studio]"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Create SharePoint solution packages

  By using the Package Designer, you can create and customize deployment packages. For example, you can add SharePoint project items and Features, reset the IIS server, set Feature activation scopes, and identify Feature dependencies. The designer also generates a manifest, an XML file that describes each package.

## Packaging tools
 You can use the **Package Designer** to customize the package and generate the manifest. You can include SharePoint project items, configure whether the Web server should be reset, and set the deployment server type. For more information, see [How to: Add and remove features and items to a package by using the Package Designer](../sharepoint/how-to-add-and-remove-features-and-items-to-a-package-by-using-the-package-designer.md).

 Alternatively, you can use the **Packaging Explorer** to modify the Features and items in your package file (*.wsp*). For more information, see [How to: Add and remove features and items to a Package by using the Packaging Explorer](../sharepoint/how-to-add-and-remove-features-and-items-to-a-package-by-using-the-packaging-explorer.md).

 You can use Visual Studio and MSBuild to create package (*.wsp*) files to deploy your SharePoint solution. This process generates the manifest files needed for SharePoint deployment. For more information, see [How to: Create a SharePoint Solution Package by using MSBuild tasks](../sharepoint/how-to-create-a-sharepoint-solution-package-by-using-msbuild-tasks.md).

## Package designer options
 The following table shows the properties that you can customize in SharePoint packages with the **Package Designer**.

|Package Designer Property|Description of default setting|
|-------------------------------|------------------------------------|
|Name|Required. The default name of the package is set to *ProjectName*.|
|Reset WebServer|Optional. Select if you want to restart the Web server after the *.wsp* file is installed on the SharePoint server.|
|Deployment Server Type|Optional. Represents the type of server hosting the package. If not set this will default to WebFrontEnd.<br /><br /> ApplicationServer: Describes a server that hosts services.<br /><br /> WebFrontEnd: Describes a server that hosts Web sites.|
|Items in the Solution|All SharePoint project items and Features that can be added to the package.|
|Items in the Package|Optional. All SharePoint items and Features that you want to deploy in your package.|

## Configure the packaging process
 After you develop SharePoint solutions in Visual Studio, you can customize how the projects are packaged.

 The following table shows the two MSBuild targets that you can use to customize how the *.wsp* file is created.

|Target|Description|
|------------|-----------------|
|BeforeLayout|The target that performs tasks immediately before the files are copied to an intermediate directory. You can modify the files before creating a package file (*.wsp*).|
|AfterLayout|The target that performs tasks immediately after the files are copied to an intermediate directory.|

 For more information, [How to: Customize a SharePoint solution package by using MSBuild Targets](../sharepoint/how-to-customize-a-sharepoint-solution-package-by-using-msbuild-targets.md).

## Packaging architecture
 The following steps occur when you create a SharePoint package (*.wsp*) in Visual Studio.

1. The Features and packages are validated to make sure that the physical and semantic structure of the package is correct.

2. The Features, project items, and package files in the package are enumerated. Manifest files for packages and Features are transformed to include all necessary information for deployment and activation. The tokens are replaced with the fully qualified value.

3. The customizable BeforeLayout MSBuild target is performed. You can create this step to make any custom modifications to the package before the *.wsp* file is created.

4. The enumerated files are copied to an intermediate directory.

5. The customizable AfterLayout MSBuild target is performed. You can create this step to make any custom modifications to the package before the *.wsp* file is created.

6. The files in the intermediate directory are added to the *.wsp* file.

## Package folder structure
 When you package your SharePoint project, a *.wsp* file is created for you in the *SolutionFolder\bin\\\<BuildConfiguration>* folder. For example, if your solution is in *C:\Visual Studio 2013\Projects\ListDefinition1* and your build configuration is set to Release, the *.wsp* file is located in *C:\Visual Studio 2013\Projects\ListDefinition1\bin\Release*.

## Related content
- [How to: Customize a SharePoint solution package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md)
- [How to: Add and remove features and items to a package by using the Package Designer](../sharepoint/how-to-add-and-remove-features-and-items-to-a-package-by-using-the-package-designer.md)
- [How to: Create a SharePoint Solution Package by using MSBuild tasks](../sharepoint/how-to-create-a-sharepoint-solution-package-by-using-msbuild-tasks.md)
- [How to: Create a SharePoint Solution Package by using MSBuild tasks](../sharepoint/how-to-create-a-sharepoint-solution-package-by-using-msbuild-tasks.md)
- [How to: Customize a SharePoint solution package by using MSBuild targets](../sharepoint/how-to-customize-a-sharepoint-solution-package-by-using-msbuild-targets.md)
