---
title: "Create site columns, content types, and lists for SharePoint"
titleSuffix: ""
description: Create site columns (fields), content types, and lists for SharePoint with project item templates provided in Visual Studio.
ms.date: "02/02/2017"
ms.topic: article
f1_keywords:
  - "VS.SharePointTools.ListDesigner.ContentTypeSetting"
  - "VS.SharePointTools.ContentTypeDesigner.CommonPropertiesPage"
  - "VS.SharePointTools.ListDesigner.CreatingLists"
  - "VS.SharePointTools.ListDesigner.ListPage"
  - "VS.SharePointTools.ListDesigner.ViewPage"
  - "VS.SharePointTools.ListDesigner.CommonPropertiesPage"
  - "VS.SharePointTools.ContentTypeDesigner.ColumnsPage"
dev_langs:
  - "VB"
  - "CSharp"
author: John-Hart
ms.author: johnhart
manager: mijacobs
ms.subservice: sharepoint-development
---
# Create site columns, content types, and lists for SharePoint

  Visual Studio provides project item templates for many different fundamental SharePoint items, including *lists* and *content types*, both of which can incorporate site columns (or *fields*). The new designers for content types and lists make creating these items easier than ever.

## Site columns
 Site columns are one of the most basic elements you can add to a SharePoint project. A site column represents a type of data, such as a telephone number, a comment, or the city name of a contact in a contact list.

 The new site column project item template makes creating site columns easier than in the earlier version of Visual Studio. After creating a new site column, you can modify the XML in the site column's *Elements.xml* file to include the information that you want, such as its display name, its data type, and the group in which you want the site column to appear in SharePoint. For more information about site columns, see [Introduction to Columns](/previous-versions/office/developer/sharepoint-2010/ms450825(v=office.14)).

## Content types and lists
 Content types and lists are among the most frequently used elements in SharePoint.

 A content type defines the metadata, workflow, and behavior for a category of items in a SharePoint list or document library. For example, you can create a content type for information in a contacts list or a task list. A contact content type might include columns such as Name, Email, Telephone Number, and Address. A content type that you define at the site level is independent of any list or document library in the site. You can use the same content type with different lists or document libraries on the SharePoint site. You can also use several content types on the same list or document library.

 A list is a collection of information in SharePoint that you can share with others. Lists consist of rows of columns that contain data. Some examples of lists include: a task list, a contacts list, and an announcements list.

 The new Content Type and List designers in Visual Studio make creating site content types and lists much easier and more intuitive than in the earlier version of Visual Studio. The UI enables you to visually construct content types and lists in a familiar manner, and lets you sort and group data in lists and use group headings. For more information about content types, see [Content Types](/previous-versions/office/developer/sharepoint-2010/ms479905(v=office.14)). For more information about lists, see [List Forms](/previous-versions/office/developer/sharepoint-2010/aa543232(v=office.14)) and [List Views](/previous-versions/office/developer/sharepoint-2010/ff604021(v=office.14)).

## Related topics

|Title|Description|
|-----------|-----------------|
|[Walkthrough: Create a site column, content type, and list for SharePoint](../sharepoint/walkthrough-create-a-site-column-content-type-and-list-for-sharepoint.md)|Demonstrates how to create site columns that are used in a custom content type. The content type is then used in a custom list.|

## See also
- [Get Started Developing on SharePoint 2010](/sharepoint/dev/)
