---
title: Understanding the DSL Code
description: Learn how the Domain-Specific Language (DSL) solution generates an API that you can use to read and update instances of the DSL in Visual Studio.
ms.date: 11/04/2016
ms.topic: concept-article
helpviewer_keywords:
- Domain-Specific Language, generated code
author: mgoertz-msft
ms.author: mgoertz
manager: mijacobs
ms.subservice: modeling
---
# Understanding the DSL Code

A Domain-Specific Language (DSL) solution generates an API that you can use to read and update instances of the DSL in Visual Studio. This API is defined in the code that is generated from the DSL definition. This topic describes the generated API.

## The example solution: Component Diagrams

To create the solution that is the source of most of the examples in this topic, create a DSL from the **Component Models** solution template. This is one of the standard templates that appears when you create a new DSL solution.

> [!NOTE]
> The Component Diagrams DSL template is called **Domain-Specific Language Designer**.

Press **F5** and experiment if you are not familiar with this solution template. Notice in particular that you create ports by dragging a port tool onto a component, and that you can connect ports.

![Components and interconnected ports](../modeling/media/componentsample.png)

## The Structure of the DSL Solution
 The **Dsl** project defines the API for your DSL. The **DslPackage** project defines how it integrates with Visual Studio. You can also add your own projects, which can also contain code generated from the model.

### The code directories
 Most of the code in each of these projects is generated from **Dsl\DslDefinition.dsl**. The generated code is in the **Generated Code** folder. To see a generated file, click **[+]** next to the generating **.tt** file.

 We recommend that you inspect the generated code to help you understand the DSL. To see the generated files, expand the *.tt files in Solution Explorer.

 The \*.tt files contain very little generating code. Instead, they use `<#include>` directives to include shared template files. The shared files can be found in **\Program Files\Microsoft Visual Studio 10.0\Common7\IDE\Extensions\Microsoft\DSL SDK\DSL Designer\11.0\TextTemplates**

 When you add your own program code to the DSL solution, add it in a separate file, outside the Generated Code folder. You might want to create a **Custom Code** folder. (When you add a new code file to a custom folder, remember to correct the namespace in the initial code skeleton.)

 We strongly recommend that you do not edit the generated code directly, because your edits will be lost when you rebuild the solution. Instead, to customize your DSL:

- Adjust the many parameters in the DSL Definition.

- Write partial classes in separate code files, to override methods that are defined in, or inherited by, the generated classes. In some cases, you have to set the **Generates Double Derived** option of a class in the DSL Definition, in order to be able to override a generated method.

- Set options in the DSL Definition that cause the generated code to provide 'hooks' for your own code.

     For example, if you set the **Has Custom Constructor** option of a domain class, and then build the solution, you will see error messages. When you double-click one of these error messages, you will see comments in the generated code that explain what your custom code should provide.

- Write your own text templates to generate code specific to your application. You can use include files to share parts of the templates that are common to many projects, and you can create Visual Studio project templates to set up projects that are initialized with your own file structure.

## Generated Files in Dsl
 The following generated files appear in the **Dsl** project.

 *YourDsl* `Schema.xsd`

 The schema for files that contains instances of your DSL. This file is copied to the compilation (**bin**) directory. When you install your DSL, you can copy this file to **\Program Files\Microsoft Visual Studio 11.0\Xml\Schemas** so that model files can be validated. For more information, see [Deploying Domain-Specific Language Solutions](msi-and-vsix-deployment-of-a-dsl.md).

 If you customize serialization by setting options in DSL Explorer, the schema will change accordingly. However, if you write your own serialization code, this file might no longer represent the actual schema. For more information, see [Customizing File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md).

 `ConnectionBuilders.cs`

 A connection builder is a class that creates relationships. It is the code behind a connection tool. This file contains a pair of classes for each connection tool. Their names are derived from the names of the domain relationship and connection tool: *Relationship*Builder, and *ConnectorTool*ConnectAction.

 (In the component solution example, one of the connection builders is called ConnectionBuilder, This is a coincidence, because the domain relationship is named Connection.)

 The relationship is created in the  *Relationship*`Builder.Connect()` method. The default version verifies that the source and target model elements are acceptable, and then instantiates the relationship. For example:

 `CommentReferencesSubject(sourceAccepted, targetAccepted);`

 Each builder class is generated from a node in the **Connection Builders** section in DSL Explorer. One `Connect` method can create relationships between one or more pairs of domain classes. Each pair is defined by a Link Connect Directive, which you can find in DSL Explorer under the builder node.

 For example, you could add to one connection builder Link Connect Directives for each of the three types of relationship in the sample DSL. This would provide the user with a single connection tool. The type of relationship instantiated would depend on the types of the source and target elements selected by the user.  To add Link Connect Directives, right-click a builder in DSL Explorer.

 To write custom code that runs when a specific type of domain relationship is created, select the appropriate Link Connect Directive under the builder node. In the Properties window, set **Uses Custom Connect**. Rebuild the solution, and then supply code to correct the resulting errors.

 To write custom code that runs whenever the user uses this connection tool, set the **Is Custom** property of the connection builder. You can supply code that decides whether a source element is permitted, whether a specific combination of source and target is permitted, and what updates should be made to the model when a connection is made. For example, you could allow a connection only if it would not create a loop in the diagram. Instead of a single relationship link, you could instantiate a more complex pattern of several inter-related elements between the source and target.

 `Connectors.cs`

 Contains the classes for the connectors, which are the diagram elements that typically represent reference relationships. Each class is generated from one connector in the DSL Definition. Every connector class is derived from <xref:Microsoft.VisualStudio.Modeling.Diagrams.BinaryLinkShape>

 To make the color and some other style features variable at run time, right-click the class on the DSL Definition diagram and point to **Add Exposed**.

 To make additional style features variable at run time, see for example <xref:Microsoft.VisualStudio.Modeling.Diagrams.TextField> and <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement>.

 `Diagram.cs`

 Contains the class that defines the diagram. It is derived from <xref:Microsoft.VisualStudio.Modeling.Diagrams.Diagram>.

 To make the color and some other style features variable at run time, right-click the class on the DSL Definition diagram and point to **Add Exposed**.

 In addition, this file contains the `FixupDiagram` rule, which responds when a new element is added to the model. The rule adds a new shape and links the shape to the model element.

 `DirectiveProcessor.cs`

 This directive processor helps your users to write text templates that read an instance of your DSL. The directive processor loads the assemblies (DLLs) for your DSL, and effectively inserts `using` statements for your namespace. This allows the code in the text templates to use the classes and relationships that you have defined in your DSL.

 For more information, see [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md) and [Creating Custom T4 Text Template Directive Processors](../modeling/creating-custom-t4-text-template-directive-processors.md).

 `DomainClasses.cs`

 Implementations of domain classes that you have defined, including abstract classes and the model root class. They are derived from <xref:Microsoft.VisualStudio.Modeling.ModelElement>.

 Each domain class contains:

- A property definition and a nested handler class for each domain property. You can override OnValueChanging() and OnValueChanged(). For more information, see [Domain Property Value Change Handlers](../modeling/domain-property-value-change-handlers.md).

   In the example DSL, the `Comment` class contains a property `Text` and a handler class `TextPropertyHandler`.

- Accessor properties for the relationships in which this domain class participates. (There is no nested class for role properties.)

   In the example DSL, the `Comment` class has accessors that access its parent model through the embedding relationship `ComponentModelHasComments`.

- Constructors. If you want to override these, set **Has Custom Constructor** on the domain class.

- Element Group Prototype (EGP) handler methods. These are necessary if the user can *merge* (add) another element onto instances of this class. Typically the user does this by dragging from an element tool or another shape, or by pasting.

   In the example DSL, an Input Port or Output Port can be merged onto a Component. Also, Components and Comments can be merged onto the model. The

   The EGP handler methods in the Component class allow a Component to accept Ports, but not Comments. The EGP handler in the root model class accepts Comments and Components, but not Ports.

  `DomainModel.cs`

  The class that represents the domain model. It is derived from <xref:Microsoft.VisualStudio.Modeling.DomainModel>.

> [!NOTE]
> This is not the same as the root class of the model.

 Copy and Delete Closures define what other elements should be included when an element is copied or deleted. You can control this behavior by setting the **Propagates Copy** and **Propagates Delete** properties of the roles at each side of every relationship. If you want the values to be determined dynamically, you can write code to override the methods of the Closure classes.

 `DomainModelResx.resx`

 This contains strings such as the descriptions of domain classes and properties, property names, toolbox labels, standard error messages, and other strings that could be displayed to the user. It also contains tool icons and images for image shapes.

 This file is bound into the built assembly, and provides the default values of these resources. You can localize your DSL by creating a satellite assembly that contains a localized version of the resources. That version will be used when the DSL is installed in a culture matching the localized resources. For more information, see [Deploying Domain-Specific Language Solutions](msi-and-vsix-deployment-of-a-dsl.md).

 `DomainRelationships.cs`

 Each link between two elements in a model is represented by an instance of a domain relationship class. All relationship classes are derived from <xref:Microsoft.VisualStudio.Modeling.ElementLink>, which in turn is derived from <xref:Microsoft.VisualStudio.Modeling.ModelElement>. Because it is a ModelElement, an instance of a relationship can have properties and can be the source or target of a relationship.

 `HelpKeywordHelper.cs`

 Provides functions that are used when the user presses F1.

 `MultiplicityValidation.cs`

 In relationship roles where you specify a multiplicity of 1..1 or 1..*, the user should be warned that at least one instance of the relationship is required. This file provides validation constraints that implement those warnings. The 1..1 link to an embedding parent is not verified.

 For these constraints to be executed, you must have set one of the **Uses...** options in the **Editor\Validation** node in DSL Explorer. For more information, see [Validation in a Domain-Specific Language](../modeling/validation-in-a-domain-specific-language.md).

 `PropertiesGrid.cs`

 This file contains code only if you have attached a Custom Type Descriptor to a domain property. For more information, see [Customizing the Properties Window](../modeling/customizing-the-properties-window.md).

 `SerializationHelper.cs`

- A validation method to ensure that no two elements are referenced by the same moniker. For more information, see [Customizing File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md).

- SerializationHelper class, which provides functions that are used in common by the serialization classes.

  `Serializer.cs`

  A serializer class for each domain class, relationship, shape, connector, diagram, and model.

  Many of the features of these classes can be controlled by the settings in DSL Explorer under **Xml Serialization Behavior**.

  `Shapes.cs`

  A class for every shape class in the DSL Definition. Shapes are derived from <xref:Microsoft.VisualStudio.Modeling.Diagrams.NodeShape>. For more information, see [Customizing File Storage and XML Serialization](../modeling/customizing-file-storage-and-xml-serialization.md).

  To override the generated methods with your own methods in a partial class, set **Generates Double Derived** for the connector in the DSL Definition. To replace a constructor with your own code, set **Has Custom Constructor**.

  To make the color and some other style features variable at run time, right-click the class on the DSL Definition diagram and point to **Add Exposed**.

  To make additional style features variable at run time, see for example <xref:Microsoft.VisualStudio.Modeling.Diagrams.TextField> and <xref:Microsoft.VisualStudio.Modeling.Diagrams.ShapeElement>

  `ToolboxHelper.cs`

  Sets up the toolbox by installing element group prototypes into the element tools. Copies of these prototypes are merged with the target elements when the user runs the tool.

  You could override `CreateElementPrototype()` to define a toolbox item that creates a group of several objects. For example, you could define an item to represent objects that have sub-components. After changing the code, reset the experimental instance of Visual Studio to clear the toolbox cache.

## Generated files in the DslPackage project
 DslPackage couples the DSL model to the Visual Studio shell, managing the window, toolbox, and menu commands. Most of the classes are double derived, so that you can override any of their methods.

 `CommandSet.cs`

 The right-click menu commands that are visible on the diagram. You can adapt or add to this set. This file contains the code for the commands. The location of the commands on menus is determined by the Commands.vsct file. For more information, see [Writing User Commands and Actions](how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md).

 `Constants.cs`

 GUIDs.

 `DocData.cs`

 *YourDsl* `DocData` manages loading and saving a model to file, and creates the Store instance.

 For example, if you want to save your DSL in a database instead of a file, you could override `Load` and `Save` methods.

 `DocView.cs`

 *YourDsl* `DocView` manages the window in which the diagram appears. For example, you could embed the diagram inside a windows Form:

 Add a User Control file to the DslPackage project. Add a Panel in which the diagram can be displayed. Add buttons and other controls. In the code view of the form, add the following code, adjusting the names to your DSL:

```csharp
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Shell;

namespace Company.EmbedInForm
{
  public partial class UserControl1 : UserControl
  {
    public UserControl1()
    {
      InitializeComponent();
    }

    private DiagramDocView docView;

    public UserControl1(DiagramDocView docView, Control content)
      : this()
    {
      this.docView = docView;
      panel1.Controls.Add(content);
    }

    private void button1_Click(object sender, EventArgs e)
    {
      ExampleModel modelRoot = this.docView.CurrentDiagram.ModelElement as ExampleModel;
      foreach (ExampleElement element in modelRoot.Elements)
      {
       listBox1.Items.Add(element.Name);
      }
    }
  }
  internal partial class EmbedInFormDocView
  {

    private ContainerControl container;

    /// <summary>
    /// Return a User Control instead of the DSL window.
    /// The user control will contain the DSL window.
    /// </summary>

    public override System.Windows.Forms.IWin32Window Window
    {
      get
      {
        if (container == null)
        {
          // Put the normal DSL Window inside our control
          container = new UserControl1(this, (Control)base.Window);
        }
        return container;
      }
    }
  }

}
```

 `EditorFactory.cs`

 Instantiates `DocData` and `DocView`. It fulfills a standard interface that Visual Studio uses to open an editor when your DSL package starts. It is referenced in the `ProvideEditorFactory` attribute in Package.cs

 `GeneratedVSCT.vsct`

 Locates the standard menu commands on menus, such as the diagram right-click (context) menu, the **Edit** menu, and so on. The code for the commands is in CommandSet.cs. You can relocate or modify the standard commands, and you can add your own commands. For more information, see [Writing User Commands and Actions](how-to-modify-a-standard-menu-command-in-a-domain-specific-language.md).

 `ModelExplorer.cs`

 Defines the Model Explorer for your DSL. This is the tree view of the model that the user sees alongside the diagram.

 For example, you could override `InsertTreeView()` to change the order in which elements appear in the Model Explorer.

 If you want the selection in the model explorer to keep synchronized with the diagram selection, you could use the following code:

```csharp
protected override void OnSelectionChanged(global::System.EventArgs e)
{
base.OnSelectionChanged(e);
// get the selected element
DslModeling::ModelElement selectedElement =
this.PrimarySelection as DslModeling::ModelElement;
// Select in the model explorer
SelectInModelExplorer<YOURLANGUAGEExplorerToolWindow>(selectedElement);
}
private void SelectInModelExplorer<T>(DslModeling::ModelElement modelElement)
where T : DslShell.ModelExplorerToolWindow
{
DslShell::ModelingPackage package =
this.GetService(typeof(VSShell.Package)) as DslShell::ModelingPackage;

if (package != null)
{
// find the model explorer window
T explorerWindow = package.GetToolWindow(typeof(T), true) as T;
if (explorerWindow != null)
{
// get the tree container
DslShell.ModelExplorerTreeContainer treeContainer =
explorerWindow.TreeContainer;
// find the tree node
DslShell.ExplorerTreeNode treeNode =
treeContainer.FindNodeForElement(modelElement);
// select the node
explorerWindow.TreeContainer.ObjectModelBrowser.SelectedNode = treeNode;
}
}
}
```

 `ModelExplorerToolWindow.cs`

 Defines the window in which the model explorer is displayed. Handles the selection of items in the explorer.

 `Package.cs`

 This file defines how the DSL integrates into Visual Studio. Attributes on the package class register the DSL as the handler for files that have your file extension, define its toolbox, and define how to open a new window. The Initialize() method is called one time when the first DSL is loaded into a Visual Studio instance.

 `Source.extension.vsixmanifest`

 To customize this file, edit the `.tt` file.

> [!WARNING]
> If you edit the .tt file to include resources such as icons or images, make sure that the resource is included in the VSIX build. In Solution Explorer, select the file and make sure that the **Include in VSIX** property is `True`.

 This file controls how the DSL is packaged into a Visual Studio Integration Extension (VSIX). For more information, see [Deploying Domain-Specific Language Solutions](msi-and-vsix-deployment-of-a-dsl.md).

## Related content

- [How to Define a Domain-Specific Language](../modeling/how-to-define-a-domain-specific-language.md)
- [Understanding Models, Classes and Relationships](../modeling/understanding-models-classes-and-relationships.md)
- [Customizing and Extending a Domain-Specific Language](../modeling/customizing-and-extending-a-domain-specific-language.md)
- [Writing Code to Customize a Domain-Specific Language](../modeling/writing-code-to-customise-a-domain-specific-language.md)
