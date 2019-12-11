---
title: "Create elements and relationships in UML models | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML API"
ms.assetid: cae81d32-8cc7-4f7c-9f00-20119952bc51
caps.latest.revision: 17
author: jillre
ms.author: jillfra
manager: jillfra
---
# Create elements and relationships in UML models
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In the program code for an extension to Visual Studio, you can create and delete elements and relationships.

## Create a Model Element

### Namespace Imports
 You must include the following `using` statements.

 The creation methods are defined as extension methods in this namespace:

 `using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;`

### Obtain the owner of the element you want to create
 A model forms a single tree, so that every item has one owner, except for the model root. The model root is of type `IModel`, which is a type of `IPackage`.

 If you are creating an element that will be displayed in a particular diagram, for example, the user's current diagram, you should usually create it in the package that is linked to that diagram. For example:

```
IPackage linkedPackage = Context.CurrentDiagram.Element as IPackage;
```

 This table summarizes the ownership of common model elements:

|Element to be Created|Owner|
|---------------------------|-----------|
|`IActor, IUseCase, IComponent, IClass, IInterface, IEnumeration`<br /><br /> `IActivity, IInteraction`|`IPackage, IModel`|
|`IAttribute, IOperation`|`IClass, IInterface`|
|`IPart, IPort`|`IComponent`|
|`IAction, IObjectNode`|`IActivity`|
|`ILifeline, IMessage, ICombinedFragment`|`IInteraction`|

### Invoke the Create method on the owner
 The method name is of the form: `Create`*OwnedType*`()`. For example:

```
IUseCase usecase1 = linkedPackage.CreateUseCase();
```

 Some types have more complex creation methods, particularly in Sequence Diagrams. See [Edit UML sequence diagrams by using the UML API](../modeling/edit-uml-sequence-diagrams-by-using-the-uml-api.md).

 For some types of element, you can change the owner of an element during its lifetime, using `SetOwner(newOwner)`.

### Set the name and other properties

```
usecase1.Name = "user logs in";
```

### Example

```
using Microsoft.VisualStudio.Uml.Classes;
using Microsoft.VisualStudio.Uml.Extensions;
...
 void InstantiateObserverPattern (IPackage package, string namePrefix)
 {    IInterface observer = package.CreateInterface();
      observer.Name = namePrefix + "Observer";
      IOperation operation = observer.CreateOperation();
      operation.Name = "Update";
      IClass subject = package.CreateClass();
      subject.Name = namePrefix + "Subject"; ...
```

## Create an Association

#### To create an association

1. Obtain the owner of the association, which is usually the package or model containing the source end of the relationship.

2. Invoke the required Create method on the owner.

3. Set the relationship's properties such as its name.

     For example:

    ```
    IAssociation association = subject.Package.CreateAssociation(subject, observer);
    association .Name = "Observes";
    ```

4. Set the properties of each end of the relationship. There are always two `MemberEnds`. For example:

    ```
    association .MemberEnds[0].Name = "subject";   // role name
    association .MemberEnds[1].Name = "observers"; // role name
    association .MemberEnds[1].SetBounds("0..*");
                // multiplicity defaults to "1"
    association.MemberEnds[0].Aggregation = AggregationKind.Composite;
    ```

## Create a Generalization

```
IGeneralization generalization =
  subclass.CreateGeneralization(superClass);
```

## Delete an Element, Relationship, or Generalization from the Model

```
anElement.Delete();
```

 When you delete an element from a model:

- Every relationship that links to it is also deleted.

- Every shape that represented it on a diagram is also deleted.

## See Also
 [Extend UML models and diagrams](../modeling/extend-uml-models-and-diagrams.md)
 [Display a UML model on diagrams](../modeling/display-a-uml-model-on-diagrams.md)
