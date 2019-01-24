---
title: "&lt;postActions&gt; element (Office development in Visual Studio)"
ms.date: "02/02/2017"
ms.topic: "conceptual"
dev_langs:
  - "VB"
  - "CSharp"
helpviewer_keywords:
  - "application manifests [Office development in Visual Studio], <postActions> element"
  - "postActions element"
  - "<postActions> element"
author: John-Hart
ms.author: johnhart
manager: jillfra
ms.workload:
  - "office"
---
# &lt;postActions&gt; element (Office development in Visual Studio)
  The `postActions` element of the `vstav3` namespace contains all the `postAction` elements that describe post-deployment actions, which run after Office solutions are installed.

## Syntax

```xml
<postActions>
  <postAction>
    <entryPoint>
    </entryPoint>
    <postActionData>
    </postActionData>
  </postAction>
</postActions>
```

## Elements and attributes
 The `postActions` element is optional and it is in the `vstav3` namespace. There is only one `postActions` element defined in an application manifest.

 The `postActions` element has no attributes.

 `postActions` has the following element.

### postAction
 Optional. The role of the `postAction` element in the `vstav3` namespace is defined in [&#60;postAction&#62; element &#40;Office development in Visual Studio&#41;](../vsto/postaction-element-office-development-in-visual-studio.md).

## Post-deployment action example

### Description
 The following code example illustrates the `postActions` element in an application manifest for an Office solution deployed by using [!INCLUDE[ndptecclick](../vsto/includes/ndptecclick-md.md)]. This code example is part of a larger example provided in [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md).

### Code

```xml
<vstav3:postActions>
  <vstav3:postAction>
    <vstav3:entryPoint
      class="PostDeploymentAction.PostDeploymentActionSample">
      <assemblyIdentity
        name="PostDeploymentAction"
        version="1.0.0.0"
        language="neutral"
        processorArchitecture="msil" />
    </vstav3:entryPoint>
    <vstav3:postActionData>
    </vstav3:postActionData>
  </vstav3:postAction>
</vstav3:postActions>
```

## See also

- [Application manifests for Office solutions](../vsto/application-manifests-for-office-solutions.md)
- [Deployment manifests for Office solutions](../vsto/deployment-manifests-for-office-solutions.md)
- [ClickOnce application manifest](../deployment/clickonce-application-manifest.md)
