---
description: "Each entryPoint element of the vstav3 namespace identifies a customization assembly that should be run when this ClickOnce application is installed."
title: "&lt;entryPoint&gt; element (Office development in Visual Studio)"
titleSuffix: ""

ms.date: "02/02/2017"
ms.topic: "reference"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <entryPoint> element"
  - "<entryPoint> element"
  - "entryPoint element"
author: John-Hart
ms.author: johnhart
manager: jmartens
ms.technology: office-development
ms.workload:
  - "office"
---
# &lt;entryPoint&gt; element (Office development in Visual Studio)
  Each `entryPoint` element of the `vstav3` namespace identifies a customization assembly that should be run when this [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] application is installed.

## Syntax

```xml
<entryPoint class>
    <assemblyIdentity />
</entryPoint>
```

## Elements and attributes
 The `entryPoint` element is required and is in the `vstav3` namespace.

 Each `entryPoint` element can contain only one customization assembly. There can be multiple `entryPoint` elements defined in an application manifest.

 The `entryPoint` element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`class`|Required. Identifies a customization assembly to be executed. The syntax for this attribute is *NamespaceName.ClassName*.|

 `entryPoint` has the following element.

### assemblyIdentity
 Required. The `assemblyIdentity` element in the `vstav3` namespace refers to an existing `assemblyIdentity` element in the [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)] application manifest.

 The role of `assemblyIdentity` and its attributes is defined in [&#60;assemblyIdentity&#62; element &#40;ClickOnce application&#41;](../deployment/assemblyidentity-element-clickonce-application.md).

## Document-level customization example

### Description
 The following code example illustrates `entryPoint` elements in an application manifest for a document-level Office solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstav3:entryPoint
  class="ContosoExcelWorkbook.ThisWorkbook">
  <assemblyIdentity
    name="ContosoExcelWorkbook"
    version="1.0.0.0"
    language="neutral"
    processorArchitecture="msil" />
</vstav3:entryPoint>
<vstav3:entryPoint
  class="ContosoExcelWorkbook.Sheet1">
  <assemblyIdentity
    name="ContosoExcelWorkbook"
    version="1.0.0.0"
    language="neutral"
    processorArchitecture="msil" />
</vstav3:entryPoint>
<vstav3:entryPoint
  class="ContosoExcelWorkbook.Sheet2">
  <assemblyIdentity
    name="ContosoExcelWorkbook"
    version="1.0.0.0"
    language="neutral"
    processorArchitecture="msil" />
</vstav3:entryPoint>
<vstav3:entryPoint
  class="ContosoExcelWorkbook.Sheet3">
  <assemblyIdentity
    name="ContosoExcelWorkbook"
    version="1.0.0.0"
    language="neutral"
    processorArchitecture="msil" />
</vstav3:entryPoint>
```

## VSTO Add-in example

### Description
 The following code example illustrates an `entryPoint` element in an application manifest for an application-level Office solution deployed using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstav3:entryPoint
  class="ContosoOutlookAddIn.ThisAddIn">
  <assemblyIdentity
    name="ContosoOutlookAddIn"
    version="1.0.0.0"
    language="neutral"
    processorArchitecture="msil" />
</vstav3:entryPoint>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
