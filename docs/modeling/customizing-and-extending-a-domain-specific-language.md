---
title: Customizing and Extending a Domain-Specific Language
description: Learn how the Visual Studio Modeling and Visualization SDK (VMSDK) provides several levels at which you can define modeling tools.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- Domain-Specific Language Tools, creating solutions
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Customize and extend a domain-specific language

Visual Studio Modeling and Visualization SDK (VMSDK) provides several levels at which you can define modeling tools:

1. Define a domain-specific language (DSL) using the DSL Definition diagram. You can quickly create a DSL with a diagrammatic notation, a readable XML form, and the basic tools that are required to generate code and other artifacts. For more information, see [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md).

2. Fine-tune the DSL by using more advanced features of the DSL Definition. For example, you can make additional links appear when the user creates an element. These techniques are mostly achieved in the DSL Definition, and some require a few lines of program code.

3. Extend your modeling tools by using program code. VMSDK is designed specifically to make it easy to integrate your extensions with the code that is generated from the DSL Definition. For more information, see [Writing Code to Customize a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md).

> [!NOTE]
> When you have updated the DSL Definitions file, don't forget to click **Transform All Templates** in the toolbar of **Solution Explorer** before rebuilding your solution.

## Article reference

|To achieve this effect|Refer to this topic|
|-|-|
|Allow the user to set the color and style properties of a shape.|Right-click the shape or connector class, point to **Add Exposed**, and click an item.|
|Different classes of model element look similar on the diagram, sharing properties such as initial height and width, color, tooltips.|Use inheritance between shapes or connector classes. Mappings between derived shapes and derived domain classes inherit the mapping details of the parents.<br /><br /> Or, map different domain classes to the same shape class.|
|A class of model element is displayed by different shapes contexts.|Map more than one shape class to the same domain class. When you build the solution, follow the error report and provide the requested code to decide what shape to use.|
|Shape color or other features such as font indicate current state.|See [Updating Shapes and Connectors to Reflect the Model](../modeling/updating-shapes-and-connectors-to-reflect-the-model.md).<br /><br /> Create a rule that updates the exposed properties. See [Rules Propagate Changes Within the Model](../modeling/rules-propagate-changes-within-the-model.md).<br /><br /> Or, use OnAssociatedPropertyChanged() to update non-exposed features such as link arrows or font.|
|Icon on shape changes to indicate state.|Set the visibility of the decorator mapping in the DSL Details window. Locate several image decorators on the same position. See  [Updating Shapes and Connectors to Reflect the Model](../modeling/updating-shapes-and-connectors-to-reflect-the-model.md).<br /><br /> Or, override `ImageField.GetDisplayImage()`. See example in <xref:Microsoft.VisualStudio.Modeling.Diagrams.ImageField>.|
|Set a background image on any shape|Override InitializeInstanceResources() to add an anchored ImageField.|
|Nest shapes to any depth|Set up a recursive embedding tree. Define BoundsRules to contain the shapes.|
|Attach connectors at fixed points on an element's boundary.|Define embedded terminal elements, represented by small ports on the diagram. Use BoundsRules to fix the ports in place. See the Circuit Diagram sample at [Visualization and Modeling SDK](https://code.msdn.microsoft.com/Visualization-and-Modeling-313535db).|
|Text field displays a value derived from other values.|Map the text decorator to a Calculated or Custom Storage domain property. For more information, see [Calculated and Custom Storage Properties](../modeling/calculated-and-custom-storage-properties.md).|
|Propagate changes between model elements, or between shapes|See [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md).|
|Propagate changes to resources such as other Visual Studio extensions outside the store.|See [Event Handlers Propagate Changes Outside the Model](../modeling/event-handlers-propagate-changes-outside-the-model.md).|
|Property window displays properties of a related element.|Set up Property Forwarding. See [Customizing the Properties Window](../modeling/customizing-the-properties-window.md).|
|Property categories|The properties window is divided into sections called categories. Set the **Category** of your domain properties. Properties with the same category name will appear in the same section. You can also set the **Category** of a relationship role.|
|Control user access to domain properties|Set **Is Browsable** false to prevent a domain property from appearing in the Properties window at run time. You can still map it to text decorators.<br /><br /> **Is UI Read Only** prevents users from changing a domain property.<br /><br /> Program access to the domain property is not affected.|
|Change the name, icon, and visibility of nodes in your DSL's model explorer.|See [Customizing the Model Explorer](../modeling/customizing-the-model-explorer.md).|
|Enable copy, cut and paste|Set the **Enable Copy Paste** property of the **Editor** node in DSL Explorer.|
|Copy reference links and their targets whenever an element is copied. For example, copy Comments attached to an item.|Set the **Propagates Copy** property of the source role (represented by the line at one side of the domain relationship in the DSL Definition diagram).<br /><br /> Write code to override ProcessOnCopy to achieve more complex effects.<br /><br /> See [Customizing Copy Behavior](../modeling/customizing-copy-behavior.md).|
|Delete, reparent, or relink related elements when an element is deleted.|Set the **Propagates Delete** value of a relationship role. For more complex effects, override `ShouldVisitRelationship` and `ShouldVisitRolePlayer` methods in the `MyDslDeleteClosure` class, defined in **DomainModel.cs**.|
|Preserve shape layout and appearance on copy and drag-drop.|Add the shapes and connectors to the copied `ElementGroupPrototype`. The most convenient method to override is `ElementOperations.CreateElementGroupPrototype()`<br /><br /> See [Customizing Copy Behavior](../modeling/customizing-copy-behavior.md).|
|Paste shapes in a chosen location, such as the current cursor position.|Override `ClipboardCommandSet.ProcessOnCopy()` to use the location-specific version of `ElementOperations.Merge().` See [Customizing Copy Behavior](../modeling/customizing-copy-behavior.md).|
|Create additional links on paste|Override ClipboardCommandSet.ProcessOnPasteCommand()|
|Enable drag and drop from this diagram, other DSLs and Windows elements|See [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md)|
|Allow a shape or tool to be dragged onto a child shape, such as a port, as if it were dragged onto the parent.|Define an Element Merge Directive on the target object class, to forward the dropped object to the parent. See [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md).|
|Allow a shape or tool to be dragged onto a shape and have additional links or objects created. For example, to allow a comment to be dropped onto an item to which it is to be linked.|Define an Element Merge Directive on the target domain class, and define the links to be generated. In complex cases, you can add custom code. See [Customizing Element Creation and Movement](../modeling/customizing-element-creation-and-movement.md).|
|Create a group of elements with one tool. For example, a component with a fixed set of ports.|Override the toolbox initialization method in ToolboxHelper.cs. Create an Element Group Prototype (EGP) containing the elements and their relationship links. See [Customizing Tools and the Toolbox](../modeling/customizing-tools-and-the-toolbox.md).<br /><br /> Either include the principal and port shapes in the EGP, or define BoundsRules to position the port shapes when the EGP is instantiated.|
|Use one connection tool to instantiate several types of relationship.|Add Link Connect Directives (LCD) to the Connection Builder that is invoked by the tool. The LCDs determine the type of the relationship from the types of the two elements. To make this depend on the states of the elements, you can add custom code. See [Customizing Tools and the Toolbox](../modeling/customizing-tools-and-the-toolbox.md).|
|Sticky tools - the user can double-click any tool to create many shapes or connectors in succession.|In DSL Explorer, select the `Editor` node. In the Properties window, set **Uses Sticky Toolbox Items**.|
|Define menu commands|See [How to: Modify a Standard Menu Command](../modeling/how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md)|
|Constrain the model with validation rules|See [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md)|
|Generate code, configuration files, or documents from a DSL.|[Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md)|
|Customize how models are saved to file.|See [Customizing File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md)|
|Save models to databases or other media.|Override *YourLanguage*DocData<br /><br /> See [Customizing File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md)|
|Integrate several DSLs so that they work as part of one application.|See [Integrating Models by using Visual Studio Modelbus](../modeling/integrating-models-by-using-visual-studio-modelbus.md).|
|Allow your DSL to be extended by third parties, and control the extension.|[Extend your DSL by using MEF](../modeling/extend-your-dsl-by-using-mef.md)<br /><br /> [Sharing Classes between DSLs by using a DSL Library](../modeling/sharing-classes-between-dsls-by-using-a-dsl-library.md)<br /><br /> [Defining a Locking Policy to Create Read-Only Segments](../modeling/defining-a-locking-policy-to-create-read-only-segments.md)|

## Related content

- [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)
- [Writing Code to Customize a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
- [Modeling SDK for Visual Studio - Domain-Specific Languages](../modeling/modeling-sdk-for-visual-studio-domain-specific-languages.md)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]
