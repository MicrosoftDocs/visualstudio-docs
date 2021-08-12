---
title: "&lt;update&gt; element (Office development in Visual Studio)"
description: "The update element specifies the interval at which the solution will check for updates."
ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "update element"
  - "<update> element"
  - "application manifests [Office development in Visual Studio], <update> element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# &lt;update&gt; element (Office development in Visual Studio)
  The `update` element specifies the interval at which the solution will check for updates.

## Syntax

```xml
<update
  enabled>
  <expiration
    maximumAge
    unit
  />
</update>
```

## Elements and attributes
 The `update` element is required and is in the `vstav3` namespace.

 The `update` element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`enabled`|Required. Set enabled to one of the following values:<br /><br /> -   **true** to check for updates.<br />-   **false** to prevent checking for updates.|

 The `update` element has the following child elements.

### expiration
 The `expiration` element is required and is in the `vstav3` namespace. This element specifies the interval at which the solution checks for updates.

 The `expiration` element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`maximumAge`| Required. Set this equal to an integer.|
|`unit`|Required. Set `unit` to one of the following values:<br /><br /> -   **hours**<br />-   **days**<br />-   **weeks**|

## Example of always checking for updates

### Description
 The following code example illustrates an `update` element that is set to always check for updates in Office solutions.

### Code

```xml
<vstav3:update enabled="true" />
```

## Example of setting a default update interval

### Description
 The following code example illustrates an `update` element in an application manifest for Office solutions. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstav3:update enabled="true">
    <vstav3:expiration maximumAge="7" unit="days" />
</vstav3:update>
```

## See also

- [Deploy an Office solution by using ClickOnce](../vsto/deploying-an-office-solution-by-using-clickonce.md)
- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
