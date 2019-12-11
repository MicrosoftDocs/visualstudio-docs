---
title: "Create SharePoint solution package using MSBuild tasks"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, packages"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# How to: Create a SharePoint Solution Package by using MSBuild tasks
  You can build, clean, and validate a SharePoint package (*.wsp*) using command-line MSBuild tasks on a development computer. You can also use these commands to automate the build process by using Team Foundation Server on a build computer.

## Build a SharePoint package

#### To build a SharePoint package

1. On the Windows **Start** menu, choose **All Programs** > **Accessories** > **Command Prompt**.

2. Change to the directory where your SharePoint project is located.

3. Enter the following command to create a package for the project. Replace *ProjectFileName* with the name of the project.

    ```cmd
    msbuild /t:Package ProjectFileName
    ```

     For example, you could run one of the following commands to package a SharePoint project called ListDefinition1.

    ```cmd
    msbuild /t:Package ListDefinition1.vbproj
    msbuild /t:Package ListDefinition1.csproj
    ```

## Clean a SharePoint package

#### To clean a SharePoint package

1. Open a command prompt window.

2. Change to the directory where your SharePoint project is located.

3. Enter the following command to clean a package for the project. Replace *ProjectFileName* with the name of the project.

    ```cmd
    msbuild /t:CleanPackage ProjectFileName
    ```

     For example, you could run one of the following commands to clean a SharePoint project called ListDefinition1.

    ```cmd
    msbuild /t:CleanPackage ListDefinition1.vbproj
    msbuild /t:CleanPackage ListDefinition1.csproj
    ```

## Validate a SharePoint package

#### To validate a SharePoint package

1. Open a command prompt window.

2. Change to the directory where your SharePoint project is located.

3. Enter the following command to validate a package for the project. Replace *ProjectFileName* with the name of the project.

    ```cmd
    msbuild /t:ValidatePackage ProjectFileName
    ```

     For example, you could run one of the following commands to validate a SharePoint project called ListDefinition1.

    ```cmd
    msbuild /t:ValidatePackage ListDefinition1.vbproj
    msbuild /t:ValidatePackage ListDefinition1.csproj
    ```

## Set properties in a SharePoint package

#### To set a property in a SharePoint package

1. Open a command prompt window.

2. Change to the directory where your SharePoint project is located.

3. Enter the following command to set a property in a package for the project. Replace *PropertyName* with the property that you want to set.

    ```cmd
    msbuild /property:PropertyName=Value
    ```

     For example, you could run the following command to set the warning level.

    ```cmd
    msbuild /property:WarningLevel = 2
    ```

## See also
- [Create SharePoint features](../sharepoint/creating-sharepoint-features.md)
- [How to: Customize a SharePoint feature](../sharepoint/how-to-customize-a-sharepoint-feature.md)
- [How to: Add and remove items to SharePoint features](../sharepoint/how-to-add-and-remove-items-to-sharepoint-features.md)
