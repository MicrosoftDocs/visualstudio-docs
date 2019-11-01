---
title: "Define packages and namespaces | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML model, namespaces"
  - "UML, namespaces"
  - "UML, packages"
  - "UML model, packages"
ms.assetid: 79147068-02d5-4b70-933d-f647c1da3829
caps.latest.revision: 22
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define packages and namespaces
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, a *package* is a container for the definitions of UML elements such as classes, use cases, and components. A package can also contain other packages.

 In UML Model Explorer, all the definitions inside a package are nested underneath the package. The UML model is a kind of package, and forms the root of the tree.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## In this Topic
 [Namespaces](#Namespaces)

 [Creating and Viewing Packages](#Packages)

 [Creating Model Elements inside Packages](#Elements)

 [Moving Elements into or out of a Package](#Moving)

 [Pasting Elements into a Package](#Pasting)

 [Import Relationships between Packages](#Import)

 [References from One Namespace to Another](#References)

 [Properties of Packages](#Properties)

## <a name="Namespaces"></a> Namespaces
 Packages are useful for separating work into different areas. Each package defines a namespace so that names that are defined in different packages do not conflict with each other.

 The qualified name property of each element is the qualified name of the package to which it belongs, followed by the element's own name. For example, if your package is called `MyPackage`, a class within the package will have a qualified name like `MyPackage::MyClass`. Because every element is contained inside a model, every qualified name begins with the model's name.

 A model also defines a namespace, so that the qualified name of every element in a model begins with the name of the model.

 Other model elements also define namespaces. For example, an operation belongs to the namespace defined by its parent class, so that its qualified name is like `MyModel ::MyPackage ::MyClass ::MyOperation`. In the same manner, an action belongs to the namespace defined by its parent activity.

 Packages are containers. If you move or delete a package, the classes, packages, and other things defined inside it are also moved or deleted. The same is true of other elements that define namespaces.

## <a name="Packages"></a> Creating and Viewing Packages
 You can create a package either on a UML class diagram, or in UML Model Explorer.

#### To create a package in a UML class diagram

1. Open a UML class diagram, or create a new one.

2. Click the **Package** tool.

3. Click anywhere on the diagram. A new package shape will appear.

     You can click inside an existing package to nest one package in another.

4. Type a new name for the package.

#### To create a package in UML Model Explorer

1. Open **UML Model Explorer**. On the **Architecture** menu, point to **Windows**, and then click the **UML Model Explorer**.

2. Right-click a package or a model to which you want to add a new package.

   > [!NOTE]
   > You can nest a package inside another package.

3. Point to **Add** and then click **Package**.

    A new package appears in the model.

4. Type a new name for the package.

   If you have created a package in UML Model Explorer, you can display it on a UML class diagram. You can also display a package on more than one UML class diagram.

#### To show an existing package on a UML Class Diagram

- Drag the package from UML Model Explorer onto the class diagram.

    > [!NOTE]
    > This creates a view of the package on this diagram. It will not necessarily show all the elements that the package contains. To make sure that you see all of a package's contents, view it in UML Model Explorer.

## <a name="Elements"></a> Creating Model Elements inside Packages
 There are four ways in which you can place model elements inside a package:

- Add a new element to a package in UML Model Explorer.

- Add classes and other types to packages in a UML class diagram.

- Set the **LinkedPackage** property of a diagram so that new elements created on the diagram are placed inside the package you specify. Class diagrams, component diagrams, and use-case diagrams can be linked to a package in this manner.

- Move elements into or out of a package in UML Model Explorer.

  An element in a package appears underneath the package in UML Model Explorer, and its qualified name begins with the qualified name of the package. To see the qualified name of any element, right-click the element and then click **Properties**. The **Qualified Name** property appears in the **Properties** window.

#### To create an element in a package in UML Model Explorer

1. Open **UML Model Explorer**. On the **View** menu, point to **Other Windows**, and then click **UML Model Explorer**.

2. Right-click a package or a model to which you want to add a new element.

3. Point to **Add**, and then click the kind of element that you want to add.

     The new element appears underneath the package.

4. Type a name for the new element.

    > [!NOTE]
    > The new element does not appear on any diagram. To create a view of the new element, you can drag it from UML Model Explorer onto a diagram. The diagram must be a type that will display this kind of element.

#### To create an element in a package on a UML class diagram

1. Open a class diagram on which the package appears.

    - Create a new package, if you have not already done this.

    - To make an existing package appear on a class diagram, you can drag the package from **UML Model Explorer** onto the class diagram.

2. Click the tool for a class, interface, or enumeration, or package.

3. Click the package where you want to put the new element.

     The new element appears inside the package.

#### To create all the elements of a diagram in a specified package

1. Create the package, if you have not already done this.

2. Open a component diagram, use case diagram, or UML class diagram.

3. Open the properties of the diagram. Right-click in a blank part of the diagram and then click **Properties**.

4. In the **Linked Package** property, choose the package that you want to contain the diagram's content.

5. Create new elements in the diagram. These will be placed into the package.

    - The **Qualified Name** of each element will begin with the package's qualified name.

    - In **UML Model Explorer**, each element will appear under the package.

## <a name="Moving"></a> Moving Elements into and out of Packages
 You can move one or more elements in or out of a package.

 If you move a package, everything inside it moves with it.

#### To move an element into or out of a package

- In UML Model Explorer, drag the element into or out of the tree whose root is the package.

     The qualified name of the element will change to show its new owning package or model.

     \- or -

- In a class diagram, drag the element into a package shape.

     The qualified name of the element will change to show its new owning package.

    > [!NOTE]
    > If you drag an element out of a package into a blank part of the diagram, its owning package does not change. This lets you make a diagram that shows elements from several packages without having to show the packages themselves.

## <a name="Pasting"></a> Pasting Elements into a Package
 You can paste an element into a package. If you paste a group of related elements into a package, the relationships between them will also be pasted.

#### To paste elements into a package on a UML class diagram

1. On a UML class diagram, select all the elements that you want to copy. Right-click one of them and then click **Copy**.

2. Right-click the package and then click **Paste**.

    > [!NOTE]
    > The package can be on a different diagram.

## <a name="Import"></a> Import Relationships between Packages
 You can define an import relationship between packages, using the **Import** tool.

 Import means that the elements defined in the imported package, which are the elements at the arrow end of the relationship, are effectively defined also in the importing package. Any elements whose visibility is defined as **Package** will be visible also in the importing package.

 Avoid creating loops in import relationships.

## <a name="References"></a> References from One Namespace to Another
 If you want to refer to an element of one package from another, you must use the element's qualified name.

 For example, suppose that package `SalesCommon` defines type `CustomerAddress`. In another package `RestaurantSales`, you want to define a type `MealOrder`, which has an attribute of type Customer Address. You have two options:

- Specify the type of the attribute using the fully qualified name `SalesCommon::CustomerAddress`. You should do this can only if `CustomerAddress` has its **Visibility** property set to **Public**.

- Create an Import relationship from the `RestaurantSales` package to the `SalesCommon` package. Then you can use `CustomerAddress` without using its qualified name.

## <a name="Properties"></a> Properties of Packages
 Each package has the following properties. To see the properties, right-click the package, either on a diagram or in UML Model Explorer, and then click **Properties**.

|Property|Default value|Description|
|--------------|-------------------|-----------------|
|**Name**|(a new name)|The package name. You can change it either on the diagram or in the Properties window.|
|**Qualified Name**|*Container* :: *package name*|The full name, prefixed by the name of the package or model that contains this package. For more information, see [Namespaces](#Namespaces).|
|**Profiles**|(empty)|A list of the profiles linked to this package. These profiles provide stereotypes that can be applied to the elements inside the package. For more information, see [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md).|
|**Visibility**|**Public**|The visibility of the package outside its parent package.|
|**Work Items**|(empty)|A list of linked work items. For more information, see [Link model elements and work items](../modeling/link-model-elements-and-work-items.md).|
|**Definition Location**|(a name)|The file name where the details of the package are stored. The files are inside the **ModelDefinition** project folder. This information can be useful for source control purposes.|
|**Description**|(empty)|A description of the package.|
|**Stereotypes**|(empty)|Stereotypes that are applied to this package. The list of stereotypes available is determined by the profiles that you have chosen for this package and the packages that contain it. For more information, see [Customize your model with profiles and stereotypes](../modeling/customize-your-model-with-profiles-and-stereotypes.md).|

## How Packages are Stored
 When you create a new package, a new **.uml** file is created in the **ModelDefinition** project folder. The root model, which is also a package, is also stored in a **.uml** file.

 In addition, each diagram is stored in two files, one that represents the diagram's shapes, and a **.layout** file that records the positions of the shapes.

## See Also
 [Edit UML models and diagrams](../modeling/edit-uml-models-and-diagrams.md)
 [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)
 [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)
 [Manage models and diagrams under version control](../modeling/manage-models-and-diagrams-under-version-control.md)
