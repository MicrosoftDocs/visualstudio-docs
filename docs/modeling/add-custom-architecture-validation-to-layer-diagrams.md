---
title: Add custom architecture validation to dependency diagrams
ms.date: 11/04/2016
ms.topic: conceptual
helpviewer_keywords:
  - "dependency diagrams, adding custom validation"
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Add custom architecture validation to dependency diagrams

In Visual Studio, users can validate the source code in a project against a layer model so that they can verify that the source code conforms to the dependencies on a dependency diagram. There is a standard validation algorithm, but you can define your own validation extensions.

When the user selects the **Validate Architecture** command on a dependency diagram, the standard validation method is invoked, followed by any validation extensions that have been installed.

> [!NOTE]
> In a dependency diagram, the main purpose of validation is to compare the diagram with the program code in other parts of the solution.

You can package your layer validation extension into a Visual Studio Integration Extension (VSIX), which you can distribute to other Visual Studio users. You can either place your validator in a VSIX by itself, or you can combine it in the same VSIX as other extensions. You should write the code of the validator in its own Visual Studio project, not in the same project as other extensions.

> [!WARNING]
> After you have created a validation project, copy the [example code](#example) at the end of this topic and then edit that to your own needs.

## Requirements

See [Requirements](../modeling/extend-layer-diagrams.md#requirements).

## Defining a Layer Validator in a New VSIX

The quickest method of creating a validator is to use the project template. This places the code and the VSIX manifest into the same project.

### To define an extension by using a project template

1. Create a new **Layer Designer Validation Extension** project.

    The template creates a project that contains a small example.

   > [!WARNING]
   > To make the template work properly:
   >
   > - Edit calls to `LogValidationError` to remove the optional arguments `errorSourceNodes` and `errorTargetNodes`.
   > - If you use custom properties, apply the update mentioned in [Add custom properties to dependency diagrams](../modeling/add-custom-properties-to-layer-diagrams.md).

2. Edit the code to define your validation. For more information, see [Programming Validation](#programming).

3. To test the extension, see [Debugging Layer Validation](#debugging).

   > [!NOTE]
   > Your method will be called only in specific circumstances, and breakpoints will not work automatically. For more information, see [Debugging Layer Validation](#debugging).

::: moniker range="vs-2017"

4. To install the extension in the main instance of Visual Studio, or on another computer, find the *.vsix* file in the *bin* directory. Copy it to the computer where you want to install it, and then double-click it. To uninstall it, choose **Extensions and Updates** on the **Tools** menu.

::: moniker-end

::: moniker range=">=vs-2019"

4. To install the extension in the main instance of Visual Studio, or on another computer, find the *.vsix* file in the *bin* directory. Copy it to the computer where you want to install it, and then double-click it. To uninstall it, choose **Manage Extensions** on the **Extensions** menu.

::: moniker-end

## Adding a Layer Validator to a Separate VSIX

If you want to create one VSIX that contains layer validators, commands, and other extensions, we recommend that you create one project to define the VSIX, and separate projects for the handlers.

### To add layer validation to a separate VSIX

1. Create a new **Class Library** project. This project will contain the layer validation class.

2. Find or create a **VSIX Project** in your solution. A VSIX project contains a file that is named **source.extension.vsixmanifest**.

3. In **Solution Explorer**, on the right-click menu of the VSIX project, choose **Set as Startup Project**.

4. In **source.extension.vsixmanifest**, under **Assets**, add the layer validation project as a MEF component:

    1. Choose **New**.

    2. In the **Add New Asset** dialog box, set:

         **Type** = **Microsoft.VisualStudio.MefComponent**

         **Source** = **A project in current solution**

         **Project** = *your validator project*

5. You must also add it as a layer validation:

    1. Choose **New**.

    2. In the **Add New Asset** dialog box, set:

         **Type** = **Microsoft.VisualStudio.ArchitectureTools.Layer.Validator**. This is not one of the options in the drop-down list. You must enter it from the keyboard.

         **Source** = **A project in current solution**

         **Project** = *your validator project*

6. Return to the layer validation project, and add the following project references:

    |**Reference**|**What this allows you to do**|
    |-|-|
    |Microsoft.VisualStudio.GraphModel.dll|Read the architecture graph|
    |Microsoft.VisualStudio.ArchitectureTools.Extensibility.CodeSchema.dll|Read the code DOM associated with layers|
    |Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer.dll|Read the Layer model|
    |Microsoft.VisualStudio.ArchitectureTools.Extensibility|Read and update shapes and diagrams.|
    |System.ComponentModel.Composition|Define the validation component using Managed Extensibility Framework (MEF)|
    |Microsoft.VisualStudio.Modeling.Sdk.[version]|Define modeling extensions|

7. Copy the example code at the end of this topic into the class file in the validator library project to contain the code for your validation. For more information, see [Programming Validation](#programming).

8. To test the extension, see [Debugging Layer Validation](#debugging).

    > [!NOTE]
    > Your method will be called only in specific circumstances, and breakpoints will not work automatically. For more information, see [Debugging Layer Validation](#debugging).

9. To install the VSIX in the main instance of Visual Studio, or on another computer, find the **.vsix** file in the **bin** directory of the VSIX project. Copy it to the computer where you want to install the VSIX. Double-click the VSIX file in Windows Explorer.

## <a name="programming"></a> Programming Validation

To define a layer validation extension, you define a class that has the following characteristics:

- The overall form of the declaration is as follows:

  ```csharp
  using System.ComponentModel.Composition;
  using Microsoft.VisualStudio.ArchitectureTools.Extensibility.CodeSchema;
  using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer;
  using Microsoft.VisualStudio.GraphModel;
  ...
   [Export(typeof(IValidateArchitectureExtension))]
    public partial class Validator1Extension :
                    IValidateArchitectureExtension
    {
      public void ValidateArchitecture(Graph graph)
      {
         GraphSchema schema = graph.DocumentSchema;
        ...
    } }
  ```

- When you discover an error, you can report it by using `LogValidationError()`.

  > [!WARNING]
  > Do not use the optional parameters of `LogValidationError`.

When the user invokes the **Validate Architecture** menu command, the layer runtime system analyses the layers and their artifacts to produce a graph. The graph has four parts:

- The layer models of the Visual Studio solution that are represented as nodes and links in the graph.

- The code, project items, and other artifacts that are defined in the solution and represented as nodes, and links that represent the dependencies discovered by the analysis process.

- Links from the layer nodes to the code artifact nodes.

- Nodes that represent errors discovered by the validator.

When the graph has been constructed, the standard validation method is called. When this is complete, any installed extension validation methods are called in unspecified order. The graph is passed to each `ValidateArchitecture` method, which can scan the graph and report any errors that it finds.

> [!NOTE]
> This is not the same as the validation process that can be used in domain-specific languages.

Validation methods should not change the layer model or the code that is being validated.

The graph model is defined in <xref:Microsoft.VisualStudio.GraphModel>. Its principal classes are <xref:Microsoft.VisualStudio.GraphModel.GraphNode> and <xref:Microsoft.VisualStudio.GraphModel.GraphLink>.

Each Node and each Link has one or more Categories which specify the type of element or relationship that it represents. The nodes of a typical graph have the following categories:

- Dsl.LayerModel

- Dsl.Layer

- Dsl.Reference

- CodeSchema_Type

- CodeSchema_Namespace

- CodeSchema_Type

- CodeSchema_Method

- CodeSchema_Field

- CodeSchema_Property

Links from layers to elements in the code have the category "Represents".

## <a name="debugging"></a> Debugging Validation

To debug your layer validation extension, press CTRL+F5. An experimental instance of Visual Studio opens. In this instance, open or create a layer model. This model must be associated with code, and must have at least one dependency.

### Test with a Solution that contains Dependencies

Validation is not executed unless the following characteristics are present:

- There is at least one dependency link on the dependency diagram.

- There are layers in the model that are associated with code elements.

The first time that you start an experimental instance of Visual Studio to test your validation extension, open or create a solution that has these characteristics.

### Run Clean Solution before Validate Architecture

Whenever you update your validation code, use the **Clean Solution** command on the **Build** menu in the experimental solution, before you test the Validate command. This is necessary because the results of validation are cached. If you have not updated the test dependency diagram or its code, the validation methods will not be executed.

### Launch the Debugger Explicitly

Validation runs in a separate process. Therefore, the breakpoints in your validation method will not be triggered. You must attach the debugger to the process explicitly when validation has started.

To attach the debugger to the validation process, insert a call to `System.Diagnostics.Debugger.Launch()` at the start of your validation method. When the debugging dialog box appears, select the main instance of Visual Studio.

Alternatively, you can insert a call to `System.Windows.Forms.MessageBox.Show()`. When the message box appears, go to the main instance of Visual Studio and on the **Debug** menu click **Attach to Process**. Select the process that is named **Graphcmd.exe**.

Always start the experimental instance by pressing CTRL+F5 (**Start without Debugging**).

### Deploying a Validation Extension

To install your validation extension on a computer on which a suitable version of Visual Studio is installed, open the VSIX file on the target computer.

## <a name="example"></a> Example code

```csharp
using System;
using System.ComponentModel.Composition;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.CodeSchema;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Layer;
using Microsoft.VisualStudio.GraphModel;

namespace Validator3
{
    [Export(typeof(IValidateArchitectureExtension))]
    public partial class Validator3Extension : IValidateArchitectureExtension
    {
        /// <summary>
        /// Validate the architecture
        /// </summary>
        /// <param name="graph">The graph</param>
        public void ValidateArchitecture(Graph graph)
        {
            if (graph == null) throw new ArgumentNullException("graph");

            // Uncomment the line below to debug this extension during validation
            // System.Windows.Forms.MessageBox.Show("Attach 2 to GraphCmd.exe with process id " + System.Diagnostics.Process.GetCurrentProcess().Id);

            // Get all layers on the diagram
            foreach (GraphNode layer in graph.Nodes.GetByCategory("Dsl.Layer"))
            {
                System.Threading.Thread.Sleep(100);
                // Get the required regex property from the layer node
                string regexPattern = "^[a-zA-Z]+$"; //layer[customPropertyCategory] as string;
                if (!string.IsNullOrEmpty(regexPattern))
                {
                    Regex regEx = new Regex(regexPattern);

                    // Get all referenced types in this layer including those from nested layers so each
                    // type is validated against all containing layer constraints.
                    foreach (GraphNode containedType in layer.FindDescendants().Where(node => node.HasCategory("CodeSchema_Type")))
                    {
                        // Check the type name against the required regex
                        CodeGraphNodeIdBuilder builder = new CodeGraphNodeIdBuilder(containedType.Id, graph);
                        string typeName = builder.Type.Name;
                        if (!regEx.IsMatch(typeName))
                        {
                            // Log an error
                            string message = string.Format(CultureInfo.CurrentCulture, Resources.InvalidTypeNameMessage, typeName);
                            this.LogValidationError(graph, typeName + "TypeNameError", message, GraphErrorLevel.Error, layer);
                        }
                    }
                }

            }

        }
    }
}
```

## See also

- [Extend dependency diagrams](../modeling/extend-layer-diagrams.md)
