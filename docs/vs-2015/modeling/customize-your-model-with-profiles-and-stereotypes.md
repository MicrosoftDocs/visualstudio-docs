---
title: "Customize your model with profiles and stereotypes | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML model, profiles"
  - "UML model, stereotypes"
  - "UML model, customizing"
ms.assetid: fd607157-0d3a-4583-a84e-427a4b2a5acb
caps.latest.revision: 20
author: jillre
ms.author: jillfra
manager: jillfra
---
# Customize your model with profiles and stereotypes
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can adapt the standard UML model elements, such as classes and components, to customize them for specific purposes. You can apply a *stereotype* to a model element that can change the element's list of properties. Stereotypes are defined within collections called *profiles*.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

 To use a stereotype, you link a package to a profile. This lets you apply the stereotypes that are defined in the profile to the elements in the package. Some profiles are installed together with Visual Studio. In addition, you can define your own profiles.

 Stereotypes can be set in the Properties list of an element. For the major kinds of shape on a diagram, the applied stereotypes also appear in the shape, as shown in the example.

 ![A UML class with a stereotype.](../modeling/media/uml-class-stereotype.png "UML_class_stereotype")

> [!NOTE]
> If you use a profile to create a model, and then share the model with someone else, they will be unable to see the stereotypes unless they have installed the same profile on their computer.

## Related Topics

|Title|Description|
|-----------|-----------------|
|[Add stereotypes to UML model elements](../modeling/add-stereotypes-to-uml-model-elements.md)|Placing a model element in a package, linking the package to a profile, and applying a stereotype to the element.|
|[Standard stereotypes for UML models](../modeling/standard-stereotypes-for-uml-models.md)|The UML Standard Profiles L2 and L3 are installed with Visual Studio, and every model is linked to them by default. They provide stereotypes that you can use to annotate your models.<br /><br /> For example, you could apply the «specification» stereotype to a class to indicate that it is intended only to define the externally-visible behavior of its instances,|
|[Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)|You can define your own stereotypes and tools that are adapted to your own application area.<br /><br /> For example, if you develop banking software, you could define an «Account» stereotype that can be applied to classes. You could then use class diagrams to describe different types of account and their relationships.|
|[Install a UML profile](../modeling/install-a-uml-profile.md)|If someone has given you a UML Profile, you can install it on your computer.|
|[Define a custom modeling toolbox item](../modeling/define-a-custom-modeling-toolbox-item.md)|A custom toolbox item saves you from repeatedly setting a stereotype on new elements.|
