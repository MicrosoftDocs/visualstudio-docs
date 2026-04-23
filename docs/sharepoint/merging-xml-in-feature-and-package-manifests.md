---
title: "Merging XML in Feature and Package Manifests"
description: Merge designer-generated and user-added XML code in SharePoint feature and package manifests. Learn feature and package manifest elements, and merge exceptions.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SharePoint development in Visual Studio, packaging"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Merge XML in feature and package manifests

  Features and packages are defined by XML manifest files. These packaged manifests are a combination of data generated from designers and custom XML entered in the manifest template by users. At packaging time, Visual Studio merges the custom XML statements with the designer-provided XML to form the packaged XML manifest file. Similar elements, with the exceptions noted later in Merge Exceptions, are merged to avoid XML validation errors after you deploy the files to SharePoint, and to make the manifest files smaller and more efficient.

## Modify the manifests
 You cannot directly modify the packaged manifest files until you disable the feature or package designers. However, you can manually add custom XML elements to the manifest template either through the feature and package designers or the XML editor. For more information, see [How to: Customize a SharePoint Feature](../sharepoint/how-to-customize-a-sharepoint-feature.md) and [How to: Customize a SharePoint solution package](../sharepoint/how-to-customize-a-sharepoint-solution-package.md).

## Feature and package manifest merge process
 When combining custom elements together with designer-provided elements, Visual Studio uses the following process. Visual Studio checks whether each element has a unique key value. If an element has no unique key value, it is appended to the packaged manifest file. Similarly, elements that have multiple keys cannot be merged. Therefore, they are appended to the manifest file.

 If an element has a unique key, Visual Studio compares the values of the designer and custom keys. If the values match, they merge into a single value. If the values differ, the designer key value is discarded and the custom key value is used. Collections are also merged. For example, if the designer-generated XML and the custom XML both contain an Assemblies collection, the packaged manifest contains only one Assemblies collection.

## Merge exceptions
 Visual Studio merges most designer XML elements together with similar custom XML elements as long as they have a single, unique identifying attribute. However, some elements lack the unique identifier required for XML merging. These elements are known as *merge exceptions*. In these cases, Visual Studio does not merge the custom XML elements together with the designer-provided XML elements, but instead appends them to the packaged manifest file.

 Following is a list of merge exceptions for feature and package XML manifest files.

|Designer|XML Element|
|--------------|-----------------|
|Feature designer|ActivationDependency|
|Feature designer|UpgradeAction|
|Package designer|SafeControl|
|Package designer|CodeAccessSecurity|

## Feature manifest elements
 The following table is a list of all feature manifest elements that can be merged and their unique key that is used for matching.

|Element Name|Unique Key|
|------------------|----------------|
|Feature (all attributes)|*Attribute Name* (Each attribute name of the Feature element is a unique key.)|
|ElementFile|Location|
|ElementManifests/ElementManifest|Location|
|Properties/Property|Key|
|CustomUpgradeAction|Name|
|CustomUpgradeActionParameter|Name|

> [!NOTE]
> Because the only way to modify the CustomUpgradeAction element is in the custom XML editor, the effect of not merging is low.

## Package manifest elements
 The following table is a list of all package manifest elements that can be merged and their unique key that is used for matching.

|Element Name|Unique Key|
|------------------|----------------|
|Solution (all attributes)|*Attribute Name* (Each attribute name of the Solution element is a unique key.)|
|ApplicationResourceFiles/ApplicationResourceFile|Location|
|Assemblies/Assembly|Location|
|ClassResources/ClassResource|Location|
|DwpFiles/DwpFile|Location|
|FeatureManifests/FeatureManifest|Location|
|Resources/Resource|Location|
|RootFiles/RootFile|Location|
|SiteDefinitionManifests/SiteDefinitionManifest|Location|
|WebTempFile|Location|
|TemplateFiles/TemplateFile|Location|
|SolutionDependency|SolutionID|

## Manually add deployed files
 Some manifest elements, such as ApplicationResourceFile and DwpFiles, specify a location that includes a file name. However, adding a file name entry to the manifest template does not add the underlying file to the package. You must add the file to the project to include it in the package and set its Deployment Type property accordingly.

## Related content
- [Package and deploy SharePoint solutions](../sharepoint/packaging-and-deploying-sharepoint-solutions.md)
- [Build and debug SharePoint solutions](../sharepoint/building-and-debugging-sharepoint-solutions.md)
