---
title: "Standard stereotypes for UML models | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML, stereotypes"
  - "UML diagrams, stereotypes"
ms.assetid: 8a8c2321-1cae-4ba8-bb9e-23495c3404d8
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# Standard stereotypes for UML models
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can add stereotypes to UML model elements to provide additional information for the reader, or for machine processing. Stereotypes are defined in profiles and each profile provides set of stereotypes. Several profiles are provided with Visual Studio. You can also define your own profiles that can contain your own stereotypes. For more information, see [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md).

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## The standard profiles
 The following profiles are available in a supported edition of Visual Studio as soon as you have installed it.

|Profile|Purpose|
|-------------|-------------|
|[UML Standard Profile L2](#L2)|A standard set of stereotypes that can be used to add extra information about an element or a relationship.|
|[UML Standard Profile L3](#L3)|A standard set of stereotypes that can be used to add extra information about an element or a relationship.|
|[C# Profile](#NetProfile)|If you intend a class or other element in a UML model to represent program code, you can indicate this by applying one of the stereotypes from the C# profile.<br /><br /> These stereotypes also add properties to the model elements.|

 When you create a new UML model, the UML Standard Profiles L2 and L3 are linked to the model, unless you remove the links.

 To use the stereotypes in any of these profiles, you must first link the profile to a package or a model that contains the elements you want to apply them to.

#### To link a profile to a model or a package

1. Open **UML Model Explorer**. On the **Architecture** menu, point to **Windows**, and then click **UML Model Explorer**.

2. Locate either a package or a model that contains all the elements to which you will want to apply the stereotypes in the profile.

3. Right-click the package or the model and then click **Properties**.

4. In the **Properties** window, set the **Profiles** property to the profiles that you want.

#### To remove the link between a profile and a model or package

1. In UML Model Explorer, right-click the model or package and then click **Properties**.

2. In the Properties window, set the **Profiles** property to empty.

    > [!NOTE]
    > You can unlink a profile only if none of the elements in the model or package use that profile's stereotypes.

#### To apply a stereotype to a model element

1. Right-click the model element either on a diagram or in **UML Model Explorer**, and then click **Properties**.

2. Click the **Stereotypes** property and select the stereotypes you want to apply.

     The selected stereotypes appear within «chevrons» in the model element, for most kinds of element.

    > [!NOTE]
    > If you cannot see the **Stereotypes** property, or if the stereotype you want does not appear, verify that the model element is inside a package or a model to which the appropriate profile has been linked.

3. Some stereotypes allow you to set the values of additional properties for the model element. To see these properties, expand the **Stereotypes** property.

### <a name="L2"></a> UML Standard Profile L2
 The following stereotypes can be used to specialize the meaning of UML model elements, unless the link to the profile has been removed from the model.

 The exact meaning of these stereotypes is determined by your own local conventions, and by any tools that you might use to process the model.

|Stereotype|Applies to|Meaning|
|----------------|----------------|-------------|
|auxiliary|Class|A class that supports another class, typically by implementing additional logic. The other class may have the «focus» stereotype.|
|call|Dependency|The client class calls the operations of the supplier.|
|create|Dependency|The client class creates instances of the supplier.|
|create|Message|The sender creates the receiver.|
|create|Operation|This operation is a constructor.|
|derive|Dependency|The client element is computed completely or partly from the supplier.|
|destroy|Operation|The operation destroys its instance.|
|document|Artifact|A «file» that is not a source or an executable.|
|entity|Component|The component represents a business concept.|
|executable|Artifact|An executable «file».|
|file|Artifact|A physical file.|
|focus|Class|A class defining the core business logic, that is supported by several «auxiliary» classes.|
|framework|Package|This package defines a reusable design pattern.|
|implement|Component|The implementation of a «specification».|
|implementationClass|Class|The class describes an implementation, and each runtime instance has one fixed implementation class. Contrast with «type».|
|instantiate|Dependency|The client creates instances of the supplier.|
|library|Artifact|A library «file».|
|metaclass|Class|Instances of this class are also classes.|
|modelLibrary|Package|Contains model elements intended to be reused by importing packages. Typically defined as part of a profile, and imported automatically by application of the profile.|
|process|Component|A transaction-based component, or one that carries a thread.|
|realization|Class, Interface, Component|Describes an implementation.|
|refine|Dependency|The client class, component, or package provides more information about the specification or design than the supplier.|
|responsibility|Dependency|The Comment at the supplier end of the Dependency defines the responsibilities of the client class or component.|
|script|Artifact|An interpretable «file».|
|send|Dependency|The source Operation sends the target Signal.|
|service|Component|A stateless component.|
|source|Artifact|A compilable «file».|
|specification|Class, Interface, Component|Defines the behavior of a component or object without defining how it works internally.|
|subsystem|Component|A part of a large system. A subsystem on a use case diagram is a component with the subsystem stereotype.|
|trace|Dependency|The client element is part of the design that realizes the supplier. The two ends of this dependency are typically in different models. One of these models is a realization of the other.|
|type|Class|Specifies the behavior of an object without stating how it is implemented. An object is a member of a type if it conforms to the specification.|
|utility|Class|A collection of static functions. The class has no instances.|

### <a name="L3"></a> UML Standard Profile L3
 The following stereotypes can be used to specialize the meaning of UML model elements, unless the profile has been unlinked from the model.

 The exact meaning of these stereotypes is determined by your own local conventions, and by any tools that you might use to process the model.

|Stereotype|Applies to|Description|
|----------------|----------------|-----------------|
|buildComponent|Component|A collection of elements used to define a build.|
|metaModel|Model|Defines a modeling language such as a variant of UML, or a domain specific language.|
|systemModel|Model|A model that is a collection of models that apply to the same system, for example, a specification, a realization, and trace relationships between them.|

## <a name="NetProfile"></a> C# Profile
 The stereotypes defined in this profile let you indicate that a model element is intended for translation to program code. Each stereotype defines additional properties that you can set on the model element.

 To make these stereotypes available, link a model or package to the C# Profile. You can then apply the stereotypes to model elements in that model or package.

 The available stereotypes, the elements to which they apply, and the additional properties that they make available are summarized in the following table.

|Stereotype|Applies to|Properties|
|----------------|----------------|----------------|
|**C# Class**|UML Class<br /><br /> Component|**Clr Attributes**<br /><br /> **Is Partial**<br /><br /> **Is Sealed**<br /><br /> **Is Static**<br /><br /> **Is Unsafe**<br /><br /> **Package visibility**|
|**C# struct**|UML Class<br /><br /> Component|**Clr Attributes**<br /><br /> **Is Partial**<br /><br /> **Is Unsafe**<br /><br /> **Package visibility**|
|**C# global members**|UML Class<br /><br /> Component|**Clr Attributes**|
|**C# Interface**|UML Interface|**Clr Attributes**<br /><br /> **Is Partial**<br /><br /> **Package visibility**|
|**C# enum**|UML Enumeration|**ClrAttributes**<br /><br /> **Base Type**|
|**C# namespace**|UML Package|**Clr Attributes**<br /><br /> **Base Name**<br /><br /> **Using namespaces**|

## See Also
 [Add stereotypes to UML model elements](../modeling/add-stereotypes-to-uml-model-elements.md)
 [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md)
 [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md)
