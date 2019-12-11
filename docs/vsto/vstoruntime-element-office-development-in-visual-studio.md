---
title: "&lt;vstoRuntime&gt; element (Office development in Visual Studio)"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <vstoRuntime> element"
  - "<vstoRuntime> element"
  - "vstoRuntime element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# &lt;vstoRuntime&gt; element (Office development in Visual Studio)
  The `vstoRuntime` element of the `vstav3` namespace contains a supported version of the Visual Studio Tools for Office runtime for a specific Office solution.

## Syntax

```xml
<vstoRuntime
    release
    version
    supportUrl />
```

## Elements and attributes
 The `vstoRuntime` element is required and is in the `vstav3` namespace. If an Office solution supports two versions of the Visual Studio Tools for Office runtime, there are two `vstoRuntime` elements in the application manifest.

 The `vstoRuntime` element has the following attributes.

|Attribute|Description|
|---------------|-----------------|
|`release`|Required. The release version of the Visual Studio Tools for Office runtime.|
|`version`|Required. Version number of the Visual Studio Tools for Office runtime.|
|`supportUrl`|Optional. Link to the installation location of the Visual Studio Tools for Office runtime.|

 `vstoRuntime` has no elements.

## Example
 The following code example illustrates the `vstoRuntime` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

```xml
<vstav3:vstoRuntime
    release="VSTOR40Beta1"
    version="10.0.20303"
    supportUrl="http://www.microsoft.com" />
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
