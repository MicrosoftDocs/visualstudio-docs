---
title: Hierarchical organization of resources for localization
ms.date: 11/04/2016
ms.prod: visual-studio-dev15
ms.technology: vs-ide-general
ms.topic: conceptual
helpviewer_keywords:
  - "resource files, localized"
  - "localization [Visual Studio], resources"
  - "fallback resources"
  - "international applications [Visual Studio], storing resources"
  - "satellite assemblies, resource hierarchies"
  - "globalization [Visual Studio], resources"
  - "satellite assemblies"
  - "resources [Visual Studio], fallback system"
  - "resource files, fallback processes"
ms.assetid: dadf8f2c-f74c-44d7-bec0-a1e956d8d38d
author: gewarren
ms.author: gewarren
manager: douge
ms.workload:
  - "multiple"
---
# Hierarchical organization of resources for localization

In Visual Studio, localized resources (data such as strings and images appropriate to each culture) are stored in separate files and loaded according to the UI culture setting. To understand how localized resources are loaded, it is useful to think of them as organized in a hierarchical manner.

## Kinds of resources in the hierarchy

-   The fallback resources for your default culture, for example English ("en"), sit at the top of the hierarchy. These fallback resources are the only ones that do not have their own file; they are stored in the main assembly.

-   Below the fallback resources are the resources for any neutral cultures. A neutral culture is associated with a language but not a country/region. For example, French ("fr") is a neutral culture. (The fallback resources are also for a neutral culture, but a special one.)

-   Below the neutral culture resources are the resources for any specific cultures. A specific culture is associated with a language and a country/region. For example, French Canadian ("fr-CA") is a specific culture.

 If an application tries to load any localized resource, such as a string, and does not find it, it will travel up the hierarchy until it finds a resource file containing the requested resource.

 The best way to store your resources is to generalize them as much as possible. That means to store localized strings, images, and so forth in resource files for neutral cultures rather than specific cultures whenever possible. For instance, if you have resources for the French Belgian ("fr-BE") culture and the resources immediately above are the fallback resources in English, a problem may result when someone uses your application on a system configured for the French Canadian culture. The system looks for a satellite assembly for "fr-CA" but doesn't find it, so loads the main assembly containing the fallback resource, English, instead of loading French resources. The following picture shows this undesirable scenario.

 ![Specific Resources Only](../ide/media/vbspecificresourcesonly.gif "vbSpecificResourcesOnly")

 If you follow the recommended practice of placing as many resources as possible in a neutral resource file for the "fr" culture, the French Canadian user would not see resources marked for the "fr-BE" culture, but would be shown strings in French. The following situation shows this preferred scenario.

 ![NeutralSpecificResources graphic](../ide/media/vbneutralspecificresources.gif "vbNeutralSpecificResources")

## See also

- [Neutral resources languages for localization](../ide/neutral-resources-languages-for-localization.md)
- [Security and localized satellite assemblies](../ide/security-and-localized-satellite-assemblies.md)
- [Localizing applications](../ide/localizing-applications.md)
- [Globalizing and localizing applications](../ide/globalizing-and-localizing-applications.md)