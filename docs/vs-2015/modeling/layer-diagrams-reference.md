---
title: "Layer Diagrams: Reference | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: reference
f1_keywords:
  - "vs.teamarch.layerdiagram.layerexplorer.artifactlink"
  - "vs.teamarch.layerdiagram.layerexplorer.artifactlink.properties"
  - "vs.teamarch.layerdiagram.diagram"
  - "vs.teamarch.UMLModelExplorer.layerdiagram"
  - "vs.teamarch.layerdiagram.layerexplorer"
  - "vs.teamarch.layerdiagram.shapes.properties"
  - "vs.teamarch.layerdiagram.toolbox"
helpviewer_keywords:
  - "architecture, layer diagrams"
  - "layer diagrams"
  - "diagrams - modeling, layer"
  - "constraints, architectural"
ms.assetid: f26c986c-1e79-420e-b29a-a283e6d8a71d
caps.latest.revision: 35
author: jillre
ms.author: jillfra
manager: jillfra
---
# Layer Diagrams: Reference
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In Visual Studio, you can use a *layer diagram* to visualize the high-level, logical architecture of your system. A layer diagram organizes the physical artifacts in your system into logical, abstract groups called *layers*. These layers describe major tasks that the artifacts perform or the major components of your system. Each layer can also contain nested layers that describe more detailed tasks.

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

 You can specify the intended or existing dependencies between layers. These dependencies, which are represented as arrows, indicate which layers can use or currently use the functionality represented by other layers. By organizing your system into layers that describe distinct roles and functions, a layer diagram can help make it easier for you to understand, reuse, and maintain your code.

 Use a layer diagram to help you perform the following tasks:

- Communicate the existing or intended logical architecture of your system.

- Discover conflicts between your existing code and the intended architecture.

- Visualize the impact of changes on the intended architecture when you refactor, update, or evolve your system.

- Reinforce the intended architecture during the development and maintenance of your code by including validation with your check-in and build operations.

  This topic describes the elements that you can use on a layer diagram. For more detailed information about how to create and draw layer diagrams, see [Layer Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md). For more information about layering patterns, visit the [Patterns & Practices site](https://go.microsoft.com/fwlink/?LinkId=145794).

## Reading Layer Diagrams
 ![Elements on layer diagrams](../modeling/media/uml-layerrefreading.png "UML_LayerRefReading")

 The following table describes the elements that you can use on a layer diagram.

|**Shape**|**Element**|**Description**|
|---------------|-----------------|---------------------|
|1|**Layer**|A logical group of physical artifacts in your system. These artifacts can be namespaces, projects, classes, methods, and so on.<br /><br /> To see the artifacts that are linked to a layer, open the shortcut menu for the layer, and then choose **View Links** to open **Layer Explorer**.<br /><br /> For more information, see [Layer Explorer](#Explorer).<br /><br /> -   **Forbidden Namespace Dependencies** - Specifies that artifacts associated with this layer cannot depend on the specified namespaces.<br />-   **Forbidden Namespaces** - Specifies that artifacts associated with this layer must not belong to the specified namespaces.<br />-   **Required Namespaces** - Specifies that artifacts associated with this layer must belong to one of the specified namespaces.|
|2|**Dependency**|Indicates that one layer can use the functionality in another layer, but not vice versa.<br /><br /> -   **Direction** - Specifies the direction of the dependency.|
|3|**Bidirectional Dependency**|Indicates that one layer can use the functionality in another layer, and vice versa.<br /><br /> -   **Direction** - Specifies the direction of the dependency.|
|4|**Comment**|Use to add general notes to the diagram or elements on the diagram.|
|5|**Comment Link**|Use to link comments to elements on the diagram.|

## <a name="Explorer"></a> Layer Explorer
 You can link each layer to artifacts in your solution, such as projects, classes, namespaces, project files, and other parts of your software. The number on a layer shows the number of artifacts that are linked to the layer. However, when reading the number of artifacts on a layer, remember the following:

- If a layer links to an artifact that contains other artifacts, but the layer does not link directly to the other artifacts, then the number includes only the linked artifact. However, the other artifacts are included for analysis during layer validation.

   For example, if a layer is linked to a single namespace, then the number of linked artifacts is 1, even if the namespace contains classes. If the layer also has links to each class in the namespace, then the number will include the linked classes.

- If a layer contains other layers that are linked to artifacts, then the container layer is also linked to those artifacts, even though the number on the container layer does not include those artifacts.

  For more information about linking layers and artifacts, see:

- [Layer Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md)

- [Create layer diagrams from your code](../modeling/create-layer-diagrams-from-your-code.md)

#### To examine the linked artifacts

- On the layer diagram, open the shortcut menu for one or more layers, and then choose **View Links**.

     **Layer Explorer** opens and shows the artifacts that are linked to the selected layers. **Layer Explorer** has a column that shows each of the properties of the artifact links.

    > [!NOTE]
    > If you cannot see all of these properties, expand the **Layer Explorer** window.

    |**Column in Layer Explorer**|**Description**|
    |----------------------------------|---------------------|
    |**Categories**|The kind of artifact, such as a class, namespace, source file, and so on|
    |**Layer**|The layer that links to the artifact|
    |**Supports Validation**|If **True**, then the layer validation process can verify that the project conforms to dependencies to or from this element.<br /><br /> If **False**, then the link does not participate in the layer validation process.<br /><br /> For more information, see [Layer Diagrams: Guidelines](../modeling/layer-diagrams-guidelines.md).|
    |**Identifier**|The reference to the linked artifact|

## See Also
 [Create models for your app](../modeling/create-models-for-your-app.md)
