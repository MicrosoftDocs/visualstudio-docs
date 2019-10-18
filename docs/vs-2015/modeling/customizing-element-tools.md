---
title: "Customizing Element Tools | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
ms.assetid: 6dac48b6-db68-4bcd-8aa2-422c2ad5d28b
caps.latest.revision: 8
author: jillre
ms.author: jillfra
manager: jillfra
---
# Customizing Element Tools
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

In some DSL Definitions, you represent a single concept as a group of elements. For example, if you create a model in which a component has a fixed set of ports, you always want the ports to be created at the same time as their parent component. Therefore, you have to customize the element creation tool so that it creates a group of elements instead of just one. To achieve this, you can customize how the element creation tool is initialized.

 You can also override what happens when the tool is dragged onto the diagram or an element.

## Customizing the Content of an Element Tool
 Each element tool stores an instance of an <xref:Microsoft.VisualStudio.Modeling.ElementGroupPrototype> (EGP), which contains a serialized version of one or more model elements and links. By default, the EGP of an element tool contains one instance of the class that you specify for the tool. You can change this by overriding *YourLanguage*`ToolboxHelper.CreateElementToolPrototype`. This method is called when the DSL package is loaded.

 A parameter of the method is the ID of the class that you specified in the DSL Definition. When the method is called with the class that you are interested in, you can add extra elements into the EGP.

 The EGP must include embedding links from one main element to the subsidiary elements. It can also include reference links.

 The following example creates a main element and two embedded elements. The main class is called Resistor, and it has two embedding relationships to elements named Terminal. The embedding role properties are named Terminal1 and Terminal2, and both have a multiplicity of 1..1.

```
using Microsoft.VisualStudio.Modeling; ...
public partial class CircuitDiagramToolboxHelper
{
  protected override ElementGroupPrototype    CreateElementToolPrototype(Store store, Guid domainClassId)
  {
    // A case for each tool to customize:
    if (domainClassId == Resistor.DomainClassId)
    {
      // Set up the prototype elements and links:
      Resistor resistor = new Resistor(store);
      resistor.Terminal1 = new Terminal(store);
      resistor.Terminal2 = new Terminal(store);
      resistor.Terminal1.Name = "T1"; // embedding
      resistor.Terminal2.Name = "T2"; // embedding
      // We could also set up reference links.

      // Create an element group prototype for the toolbox:
      ElementGroup egp = new ElementGroup(store.DefaultPartition);
      egp.AddGraph(resistor, true);
      // We do not have to explicitly include embedded children.
      return egp.CreatePrototype();
    }
    // Element tools for other classes:
    else
      return base.CreateElementToolPrototype(store, domainClassId);
  }
}
```

## See Also
 [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md)
