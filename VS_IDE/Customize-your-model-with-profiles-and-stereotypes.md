---
title: "Customize your model with profiles and stereotypes"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: fd607157-0d3a-4583-a84e-427a4b2a5acb
caps.latest.revision: 18
manager: kamrani
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Customize your model with profiles and stereotypes
In Visual Studio, you can adapt the standard UML model elements, such as classes and components, to customize them for specific purposes. You can apply a *stereotype* to a model element that can change the element's list of properties. Stereotypes are defined within collections called *profiles*.  
  
 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../VS_IDE/What-s-new-for-design-in-Visual-Studio.md#VersionSupport).  
  
 To use a stereotype, you link a package to a profile. This lets you apply the stereotypes that are defined in the profile to the elements in the package. Some profiles are installed together with Visual Studio. In addition, you can define your own profiles.  
  
 Stereotypes can be set in the Properties list of an element. For the major kinds of shape on a diagram, the applied stereotypes also appear in the shape, as shown in the example.  
  
 ![A UML class with a stereotype.](../VS_IDE/media/UML_class_stereotype.png "UML_class_stereotype")  
  
> [!NOTE]
>  If you use a profile to create a model, and then share the model with someone else, they will be unable to see the stereotypes unless they have installed the same profile on their computer.  
  
## Related Topics  
  
|Title|Description|  
|-----------|-----------------|  
|[Add stereotypes to UML model elements](../VS_IDE/Add-stereotypes-to-UML-model-elements.md)|Placing a model element in a package, linking the package to a profile, and applying a stereotype to the element.|  
|[Standard stereotypes for UML models](../VS_IDE/Standard-stereotypes-for-UML-models.md)|The UML Standard Profiles L2 and L3 are installed with Visual Studio, and every model is linked to them by default. They provide stereotypes that you can use to annotate your models.<br /><br /> For example, you could apply the «specification» stereotype to a class to indicate that it is intended only to define the externally-visible behavior of its instances,|  
|[Define a profile to extend UML](../VS_IDE/Define-a-profile-to-extend-UML.md)|You can define your own stereotypes and tools that are adapted to your own application area.<br /><br /> For example, if you develop banking software, you could define an «Account» stereotype that can be applied to classes. You could then use class diagrams to describe different types of account and their relationships.|  
|[Install a UML profile](../VS_IDE/Install-a-UML-profile.md)|If someone has given you a UML Profile, you can install it on your computer.|  
|[Define a custom modeling toolbox item](../VS_IDE/Define-a-custom-modeling-toolbox-item.md)|A custom toolbox item saves you from repeatedly setting a stereotype on new elements.|  
|[Color UML Classes by Stereotype](http://code.msdn.microsoft.com/UML-Color-Classes-by-07de2b70)|This sample code extends the UML diagrams. It automatically sets the color of a UML shape according to the stereotype of the element.|