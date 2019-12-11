---
title: "Integrating Business Data into SharePoint | Microsoft Docs"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "Business Data Connectivity service [SharePoint development in Visual Studio], business data"
  - "BDC [SharePoint development in Visual Studio], aggregating data"
  - "BDC [SharePoint development in Visual Studio], business data"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], aggregating data"
  - "BDC [SharePoint development in Visual Studio], creating a model"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], creating a model"
  - "Business Data Connectivity service [SharePoint development in Visual Studio], data"
  - "BDC [SharePoint development in Visual Studio], data"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# Integrate business data into SharePoint
  You can integrate business data into SharePoint. Business data can come from back-end server applications, such as [!INCLUDE[TLA#tla_sqlsvr](../sharepoint/includes/tlasharptla-sqlsvr-md.md)], Siebel, and SAP, or a Web service. Users can view, add, update, or delete business data by using external lists or Business Data Web Parts in SharePoint.  Users can also access this data offline in a Microsoft Office application such as Microsoft Outlook. For more information, see [Where Can You Show External Data](/previous-versions/office/developer/sharepoint-2010/ee558737(v=office.14)).

 To integrate data into SharePoint, create a model for the Business Data Connectivity (BDC) service. The BDC service is an application in SharePoint that stores information about data in business applications. For more information, see [Business Data Connectivity (BDC) Service](/previous-versions/office/developer/sharepoint-2010/ee556407(v=office.14)).

## Models in Visual Studio
 Models in Visual Studio enable you to write custom code to retrieve and update data from back-end data sources. You can also aggregate data from multiple data sources. For example, you can display a list of customers that contains data from a [!INCLUDE[ssNoVersion](../sharepoint/includes/ssnoversion-md.md)] database and a Web service.

 You can also import models that are already deployed to SharePoint. After you import a model, you can add custom code or just use Visual Studio to package and deploy the model to multiple SharePoint server farms. For more information, see [Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md).

## Design a model in Visual Studio
 You can design a model by using a designer and several tool windows. As you design the model, Visual Studio generates the model XML. For more information, see [BDC model design tools overview](../sharepoint/bdc-model-design-tools-overview.md).

 A model contains entities and methods.

### Entities
 An entity describes a collection of fields. For example, an entity can represent a table in a database. An entity appears as an external content type in SharePoint. For more information about external content types, see [What are External Content Types?](/previous-versions/office/developer/sharepoint-2010/ee556391(v=office.14))

### Methods
 A method enables the consumers of an external content type to perform an action on the fields of an entity. For example, an Updater method might enable users to change the address, and birth date of a customer where `Address` and `BirthDate` are fields of the `Customer` entity.

 Visual Studio generates a service code file for each entity in your model. When you add a method to your model, Visual Studio generates a corresponding method in the service code file. Add code to each method to perform the appropriate task. For example, if you add a Creator method to the model, Visual Studio generates a Creator method in your service code file. This method is called by the BDC service when a user clicks the **New Item** button in a list that is based on the model. Therefore, add code to the Creator method that adds new data to a data source. For more information, see [Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md).

## Related topics

|Title|Description|
|-----------|-----------------|
|[Create a business data connectivity model](../sharepoint/creating-a-business-data-connectivity-model.md)|Shows you how create a new model or import a model that you export from SharePoint.|
|[Design a business data connectivity model](../sharepoint/designing-a-business-data-connectivity-model.md)|Explains how to design the elements of a model by using Visual Studio design tools.|
|[When to Use SharePoint Designer vs. Visual Studio When Building Solutions Using BCS](/previous-versions/office/developer/sharepoint-2010/ee558875(v=office.14))|Helps you decide whether to use Visual Studio or use SharePoint Designer to create a model for the BDC.|
