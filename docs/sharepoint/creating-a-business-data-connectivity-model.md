---
title: "Creating a Business Data Connectivity Model"
description: Create a Business Data Connectivity (BDC) model or customize an existing BDC model by using Visual Studio. Each SharePoint project can contain only one model.
ms.date: "02/02/2017"
ms.topic: concept-article
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], model"
  - "BDC [SharePoint development in Visual Studio], creating a model"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], creating a model"
  - "SharePoint development in Visual Studio, Business Data Connectivity service"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Create a business data connectivity model

  You can create a Business Data Connectivity (BDC) model or customize an existing BDC model by using Visual Studio. Each SharePoint project can contain only one model. For more information, see [Integrate business data into SharePoint](../sharepoint/integrating-business-data-into-sharepoint.md).

## Create a new model
 To create a new model, create a **Business Data Connectivity Model** project or add a **Business Data Connectivity Model** item to an **Empty SharePoint Project**.

> [!NOTE]
> You must have  Microsoft SharePoint Server installed on your computer.

 Visual Studio adds a folder to the project. This folder has the name that you specify for the **Business Data Connectivity Model** item in the **Add New Item** dialog box. If you create a new **Business Data Connectivity Model** project, Visual Studio names the folder **BdcModel1**.

 Visual Studio adds the following files to the new folder:

|File|Description|
|----------|-----------------|
|Model Definition File|Contains XML that defines the entities, methods, Line of Business (LOB) system objects, and other metadata that describes the model.<br /><br /> Modify the metadata in this file by using the BDC Designer, **BDC Explorer**, **BDC Method Details** window, and **Properties** window.|
|Entity Service Code File|Contains methods that retrieve, update, and delete instances of the default entity.|

 To define the properties of an entity, edit the entity code file. For more information, see [How to: Add an entity to a model](../sharepoint/how-to-add-an-entity-to-a-model.md).

 To retrieve, update, and delete instances of an entity, add code to the entity service code file. For more information, see [Designing a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

 When you compile the project, Visual Studio creates an assembly. Ensure that you do not add other items to the project that add code to the project assembly (For example: a **Sequential Workflow** item or a **Web Part** item). The code for that item will not run when you deploy the solution because the solution package does not copy the assembly to the global assembly cache.  The solution package deploys the assembly to the BDC database in SharePoint only.

> [!NOTE]
> Visual Studio copies the assembly to both locations on your local computer when you debug the project.

## Add an existing model
 You can import a model that was created by using other tools such as SharePoint Designer. You might choose to import an existing model to your project in the following situations:

- To customize a model that is already deployed to a SharePoint server farm.

- To package and deploy an existing model to multiple SharePoint server farms.

  In either case, the LOB systems defined in the model that you import are not affected and will continue to work as expected. To add an existing model to a SharePoint project, use the Visual Studio **Add Existing Item** dialog box. For more information, see [How to: Add an existing BDC model file to a SharePoint project](../sharepoint/how-to-add-an-existing-bdc-model-file-to-a-sharepoint-project.md).

  You can add a LOB system of type .NET Framework assembly to the imported model by selecting an option in the **Add .NET assembly LobSystem**. This enables you to write custom code and use a designer to define the metadata for the imported model.

## Related topics

|Title|Description|
|-----------|-----------------|
|[How to: Create a BDC model](../sharepoint/how-to-create-a-bdc-model.md)|Shows you how to create a new BDC model.|
|[How to: Add an existing BDC model file to a SharePoint project](../sharepoint/how-to-add-an-existing-bdc-model-file-to-a-sharepoint-project.md)|Shows you how to import an existing model into a SharePoint project.|
|[How to: Use a resource file to specify localized names, properties, and permissions](../sharepoint/how-to-use-a-resource-file-to-specify-localized-names-properties-and-permissions.md)|Describes how to provide strings that are merged with model metadata when the model is consumed by a Web Part or Web Page.|
|[How to: Include a custom assembly in a BDC feature](../sharepoint/how-to-include-a-custom-assembly-in-a-bdc-feature.md)|Shows you how to include a custom assembly in the feature.|
