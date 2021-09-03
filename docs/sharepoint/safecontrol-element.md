---
title: "SafeControl Element | Microsoft Docs"
description: Get information on the SafeControl element, which represents an ASPX control or web part marked as secure for a user to access on a SharePoint site's ASPX page.
ms.custom: SEO-VS-2020
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "SafeControl element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: sharepoint-development
ms.workload:
  - "office"
---
# SafeControl element
  Represents an ASPX control or Web Part that is designated as secure for any user to access on any ASPX page on the SharePoint site.

## Syntax

```xml
<SafeControl Assembly = "Name of assembly that contains the safe control"
    IsSafe = "true/false"
    IsSafeAgainstScript = "true/false"
    Name = "Name of this safe control entry"
    Namespace = "Namespace of the safe control"
    TypeName = "Type of the safe control" />
```

## Attributes and elements
 The following sections describe attributes, child elements, and parent elements.

### Attributes

|Attribute|Description|
|---------------|-----------------|
|**Assembly**|Optional **xs:string** attribute.<br /><br /> The name of the assembly in which the ASPX control or Web Part is defined. By default, this attribute uses the **$SharePoint.Project.AssemblyFullName$** replaceable parameter for the assembly name. For more information, see [Replaceable parameters](../sharepoint/replaceable-parameters.md).|
|**IsSafe**|Optional **xs:boolean** attribute.<br /><br /> Specifies whether the ASPX control or Web Part is secure for untrusted users to access.|
|**IsSafeAgainstScript**|Optional **xs:boolean** attribute.<br /><br /> Specifies whether untrusted users can view or edit the properties of the ASPX control or Web Part.|
|**Name**|Optional **xs:string** attribute.<br /><br /> The name of this safe control entry in the collection.|
|**Namespace**|Optional **xs:string** attribute.<br /><br /> The namespace of the ASPX control or Web Part.|
|**TypeName**|Optional **xs:string** attribute.<br /><br /> The type name of the ASPX control or Web Part.|

### Child elements
 None.

### Parent elements

|Element|Description|
|-------------|-----------------|
|[SafeControls](../sharepoint/safecontrols-element.md)|Represents a collection of ASPX controls and Web Parts that are designated as secure for any user to access on any ASPX page on the SharePoint site.|

## Remarks
 For more information about safe controls, see [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md).

## Element information

|Property|Value|
|-|-|
|**Namespace**|http:\/\/schemas.microsoft.com/VisualStudio/<br>2010/SharePointTools/SharePointProjectItemModel|
|**Schema name**|SharePoint Project Item Schema|
|**Validation file**|ProjectItemModelSchema.xsd|
|**Can be empty**|No|

## See also
- [SharePoint project item schema reference](../sharepoint/sharepoint-project-item-schema-reference.md)
- [Provide packaging and deployment information in project items](../sharepoint/providing-packaging-and-deployment-information-in-project-items.md)
