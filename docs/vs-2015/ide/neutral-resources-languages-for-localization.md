---
title: "Neutral Resources Languages for Localization | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-general"
ms.topic: conceptual
helpviewer_keywords:
  - "localization [Visual Studio], resources"
  - "NeutralResourcesLanguageAttribute class"
  - "globalization [Visual Studio], resources"
  - "resources [Visual Studio], fallback system"
  - "culture, locating resources"
  - "neutral resources"
ms.assetid: ef064995-3b84-4698-a708-9689b7723533
caps.latest.revision: 9
author: jillre
ms.author: jillfra
manager: jillfra
---
# Neutral Resources Languages for Localization
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The <xref:System.Resources.NeutralResourcesLanguageAttribute> class specifies the culture of the resources included in the main assembly. This attribute is used as a performance enhancement, so that the <xref:System.Resources.ResourceManager> object does not search for resources that are included in the main assembly.

 The following code shows how to set the neutral resources language. The code can be placed in either a build script or in the AssemblyInfo.vb or AssemblyInfo.cs file.

```vb
' Set neutral resources language for assembly.
<Assembly: NeutralResourcesLanguageAttribute("en")>

```

```csharp
// Set neutral resources language for assembly.
[assembly: NeutralResourcesLanguageAttribute("en")]
```

## See Also
 <xref:System.Resources.ResourceManager>
 [Introduction to International Applications Based on the .NET Framework](../ide/introduction-to-international-applications-based-on-the-dotnet-framework.md)
 [Hierarchical Organization of Resources for Localization](../ide/hierarchical-organization-of-resources-for-localization.md)
 [Localizing Applications](../ide/localizing-applications.md)
 [Globalizing and Localizing Applications](../ide/globalizing-and-localizing-applications.md)
