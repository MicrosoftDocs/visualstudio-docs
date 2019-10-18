---
title: "Generate code from UML class diagrams | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
f1_keywords:
  - "vs.teamarch.logicalclassdiagram.shapes.properties.Templates"
  - "vs.teamarch.logicalclassdiagram.shapes.properties.Templates.TextTransformationDataCollectionEditor"
helpviewer_keywords:
  - "code generation, UML class diagrams"
  - "class diagrams - UML, generating code"
  - "UML diagrams, generating code"
ms.assetid: 2790e64d-7728-4c2e-a4dd-4131e795f730
caps.latest.revision: 53
author: jillre
ms.author: jillfra
manager: jillfra
---
# Generate code from UML class diagrams
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

To generate Visual C# .NET code from UML class diagrams in Visual Studio, use the **Generate Code** command. By default, the command generates a C# type for each UML type that you select. You can modify and extend this behavior by modifying or copying the text templates that generate the code. You can specify different behavior for the types that are contained in different packages in your model.

 The **Generate Code** command is particularly suited to generating code from the user's selection of elements, and to generating one file for each UML class or other element. For example, the screenshot shows two C# files that have been generated from two UML classes.

 As an alternative, if you want to generate code in which the generated files do not have a 1:1 relationship with the UML elements, you could consider writing text templates that are invoked with the **Transform All Templates** command. For more information about that method, see [Generate files from a UML model](../modeling/generate-files-from-a-uml-model.md).

 ![UML class diagram and generated C&#35; class files.](../modeling/media/oob-gencode1.png "oob_GenCode1")

 For more information about UML class diagrams in Visual Studio, see the following topics:

- [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)

- [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)

  To see which versions of Visual Studio support UML class diagrams, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Using the Generate Code Command
 The following procedure describes the default behavior of the **Generate Code** command:

#### To generate a separate file for each element

1. Create a UML model that contains classes. You might want to apply stereotypes to the model elements.

    For more information, see [Default Code Generation Transforms](#default).

2. On a class diagram or in **UML Model Explorer**, select elements from which you want to generate code. You can select one of the following:

   - A specific set of elements.

   - A package or the model, to generate code from its contents.

   - The diagram, to select all the elements on the diagram.

3. Open the shortcut menu for a selected element, and then choose **Generate Code**.

    The first time that you use **Generate Code** in a particular model, a dialog box appears. This dialog box lets you edit the code generation parameters of the model.

    Choose **OK** unless you know that you want to change these parameters.

    To return to this dialog box later, open **UML Model Explorer**. Open the modeling project shortcut menu, and then choose **Set Up Code Generation**. For more information, see [Customizing the Generate Code Command](#custom).

   Files that contain C# code are generated. In the default case, a file is generated for each type, and the files are generated in a C# class library project. However, you can customize this behavior. For more information, see [Customizing the Generate Code Command](#custom).

   Some validation tests are applied to the model to ensure that it can be translated to C#. If these tests fail, an error message is displayed and code generation is not performed. If you have created a validation menu command, code is not generated for any element for which your validation command fails. For more information, see [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md).

## <a name="default"></a> Default Code Generation Transforms
 This section summarizes the results that are produced by the **Generate Code** command, unless you customize the command. For more information, see [Customizing the Generate Code Command](#custom).

- One C# type is produced for each type that you have selected in the UML model. Each type is placed in a separate code file under the **GeneratedCode** folder.

- If the UML type is contained in a package, the generated C# type is placed inside a namespace, and the file is generated in a folder that has the same name as the namespace.

- A C# property is generated for each `Attribute` of a UML class.

- A C# method is generated for each `Operation` of a UML type.

- A C# field is generated for each navigable association in which the class participates.

  By adding a stereotype to each UML type, you can control more properties of the generated C# type.

|**To create this C# type**|**Draw this UML type**|**Apply this stereotype**|
|---------------------------------|----------------------------|-------------------------------|
|Class|Class|\<none> or<br /><br /> C# class|
|Interface|Interface|\<none> or<br /><br /> C# interface|
|Enumeration|Enumeration|\<none> or<br /><br /> C# enum|
|Delegate|Class|C# delegate|
|Struct|Class|C# struct|

#### To set a stereotype on a type or other element

1. Open the shortcut menu for the element on a diagram or in **UML Model Explorer**, and then choose **Properties**.

2. In the **Properties** window, choose the drop-down arrow in the **Stereotypes** property, and then select the check box for the stereotype that you want to apply.

   > [!TIP]
   > If the C# stereotypes do not appear, enable the C# Profile for the model or for a package that contains the model elements in which you are interested. Select the package or the root of the model in **UML Model Explorer**. Then in the **Properties** window, choose **Profile**, and then enable the C# Profile.

3. Expand the **Stereotypes** property to see the additional properties that you can set.

   The **Description** properties of types, attributes, operations, and associations are written to `<summary>` comments in the generated code. Comment elements that are linked to types are written to `<remarks>` comments.

## Varying the generated code
 The generated code varies dependent on the properties of each type, attribute or operation. For example, if you set the **Is Abstract** property of a class to true, then the `abstract` keyword will appear on the generated class. If you set the **Multiplicity** of an attribute to **0..\***, then the generated property will have an `IEnumerable<>` type.

 In addition, each stereotype provides several additional properties that you can set. These values are translated to appropriate keywords in the C# code. For example, if you set the property `Is Static` on a class, then the C# class will be `static`.

 To set these additional properties, select the class or other element in the diagram. In the Properties window, expand **Stereotypes**, and then expand the C# stereotype, such as **C# Class**.  For classes, these additional properties include:

- CLR Attributes

- Is Partial

- Is Static

- Is Unsafe

- Package Visibility

  Each attribute and operation also has stereotype properties that you can set. If you do not see the properties on a new attribute, run **Generate Code**.

## <a name="custom"></a> Customizing the Generate Code Command
 The **Generate Code** command works by transforming your model elements using a set of text templates. For more information about text templates, see [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md).

 The templates are specified in a set of *text template bindings*. A text template binding specifies what template should be applied, where the generated output should be placed, and other parameters of the **Generate Code** command.

 When you first run the **Generate Code** command on a particular model, it attaches a default set of template bindings to the root of the model. These bindings apply to all the elements in the model.

 However, you can override and add to these default bindings by attaching your own bindings to packages, classes, or other elements. A binding applies to all the elements contained inside the element to which it is attached. For example, if you want all the types inside a particular package to be transformed by a different set of templates, or to be output to a different folder, you can attach template bindings to the package.

 To inspect the template bindings attached to a model element, choose the ellipsis **[...]** in the **Text Template Bindings** property in the Properties window.

 The **Generate Code** command applies templates to each model element that you have selected. For each element, the set of templates applied is the combined set of templates that are attached to its containers, up to and including the root of the model.

 If two template bindings in this set have the same name, the binding in the smaller container overrides the binding in the larger container. For example, the model root has a binding with the name **Class Template**. To have your own template applied to the contents of a particular package, define your own template binding that has the name **Class Template**.

 More than one template can be applied to a model element. You can generate more than one file from each model element.

> [!NOTE]
> The bindings attached to the root of the model act as defaults for all elements in the model. To see these default bindings, open **UML Model Explorer**. Open the modeling project's shortcut menu, then choose **Set Up Code Generation**. Alternatively, you can select the root of the model in UML Model Explorer. In the Properties window, choose **[…]** in the **Text Template Bindings** property. The bindings will not appear until you have used the **Generate Code** command at least once. Template bindings cannot be attached to a diagram.

#### To attach text template bindings to a package or other model element

1. In **UML Model Explorer**, open the shortcut menu for a model element, and then choose **Properties**. Generally, you would attach text template bindings to a package or to the root of the model.

2. In the **Properties** window, choose the ellipsis button (**[…]**) in the **Text Template Bindings** property.

    The **Text Template Bindings** dialog box appears.

3. Choose **Add** to create a new text template binding.

    \- or -

    Choose an existing binding to edit it.

    Each template binding defines how a specified template should be applied to the model element that you selected, and other model elements that it contains.

4. In the dialog box, set the properties of the text template binding.

   |    **Property**    |                                                                                                                                                                                                                                                                                                                    **Description**                                                                                                                                                                                                                                                                                                                    |
   |--------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   |        Name        |                                                                                                                                                                                                                                                  A name for this binding. To override a binding inherited from a containing package or model, use the same name as the binding you want to override.                                                                                                                                                                                                                                                  |
   |     Overwrite      |                                                                                                                                                                                                                                                                                                      If true, any existing code is overwritten.                                                                                                                                                                                                                                                                                                       |
   |    Target Name     | The name of the file that is generated.<br /><br /> You can insert expressions into this string such as `{Name}` or `{Owner.Name}`. For example, you could write: `{Owner.Name}_{Name}`. The expression is evaluated on the model element. It can use properties of elements, but not methods. To find what properties can be used, look at the properties of types in **Microsoft.VisualStudio.Uml.\***. \*\*Important:\*\*  `{Name}` or `{Owner.Name}` can be used only in the **Target Name** property. To change the name of the generated class, you have to modify the template. For more information, see [Writing a Text Template](#writing). |
   |    Project Path    |                                                                      Specifies the path to the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project that will contain the transformation's output files. Use typed values to create a new project. Choose the ellipsis button (**[…]**) to select an existing project.<br /><br /> A new project will be created if it does not exist. It will be a C# class library project.<br /><br /> To do this, you must type the project directly. You can include environment variable macros such as %ProgramFiles% or %LocalAppData%.                                                                       |
   |  Target Directory  |                                                                                          The folder in which the target file is generated. The path is relative to the project folder.<br /><br /> You can use the `{PackageStructure}` expression to insert a path that corresponds to the names of the containing packages. The default value is `\GeneratedCode\{PackageStructure}`. You can also include environment variables such as %TEMP% or %HomePath%. **Important:**  `{PackageStructure}` can be used only in the **Target Directory** property.                                                                                          |
   | Template File Path |                                                                                                                                                           The template that will perform the transform.<br /><br /> You can either use the provided templates or create your own. You can find the provided templates in the following location:<br /><br /> …\Program Files\Microsoft Visual Studio 12.0\Common7\IDE\Extensions\Microsoft\Architecture Tools\Extensibility\Templates\Text\                                                                                                                                                           |

5. You can attach as many bindings to an element as you want.

## <a name="writing"></a> Writing a Text Template
 You can write your own text templates. Text templates can generate program code or any other kind of text file.

 We recommend that you start by modifying copies of the standard templates. You can copy the templates from the following locations:

 …\Program Files\Microsoft Visual Studio 12.0\Common7\IDE\Extensions\Microsoft\Architecture Tools\Extensibility\Templates\Text\

 To understand the text templates, refer to the following topics.

- A text template is a prototype of the resulting file, and contains both the resulting text and the program code that reads the model. For more information, see [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md).

- To navigate the UML model in the program code, you have to use the UML API. For more information, see [Navigate the UML model](../modeling/navigate-the-uml-model.md) and [API Reference for UML Modeling Extensibility](../modeling/api-reference-for-uml-modeling-extensibility.md).

  To use the templates with the **Generate Code** command, you must include the Modeling directive. For example:

  `<#@ Modeling ElementType="Microsoft.VisualStudio.Uml.Classes.IClass" Processor="ModelingProcessor" #>`

  The `ElementType` attribute defines the type of UML element to which this template applies.

  In the template, `this` belongs to a temporary class that has the following properties:

- `Element` = the UML [IElement](/previous-versions/dd516035(v=vs.140)) to which the template is being applied.

- `Errors`: <xref:System.CodeDom.Compiler.CompilerErrorCollection>

- `Host`: [ITextTemplatingEngineHost](/previous-versions/visualstudio/visual-studio-2012/bb126505(v=vs.110))

- `ModelBus`: [ModelBus](/previous-versions/ee904639(v=vs.140)). For more information, see [Integrate UML models with other models and tools](../modeling/integrate-uml-models-with-other-models-and-tools.md).

- `ProfileName` = "C#Profile"

- `ServiceProvider`: <xref:System.IServiceProvider>

- `Session`: <xref:Microsoft.VisualStudio.TextTemplating.TextTemplatingSession>.

- `Store`: <xref:Microsoft.VisualStudio.Modeling.Store>. This is the Visualization and Modeling SDK Store on which the UML ModelStore is implemented. To obtain the UML [IModelStore](/previous-versions/ee789385(v=vs.140)), use `this.Element.GetModelStore()`.

  You might find the following points helpful while you write a text template. This information is described in detail in [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md).

- You can set the file name extension of the result in the `Output` directive. One `Output` directive is required in every text template.

- Some assemblies are automatically referenced by the template. These assemblies include, for example, System.dll and Microsoft.VisualStudio.Uml.Interfaces.dll.

   To use other assemblies in your generating program code, you must use an `Assembly` directive. For example:

   `<#@ Assembly Name="%ProgramFiles%\Microsoft Visual Studio 12.0\Common7\IDE\PublicAssemblies\Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll" #>`

- Some namespaces such as `System` are automatically imported into your program code. For other namespaces, you can use the `Import` directive in the same manner that you would use a `using` statement. For example:

   `<#@ Import Namespace="Microsoft.VisualStudio.Uml.Classes" #>`

   `<#@ Import Namespace="Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml" #>`

- Use the `Include` directive to reference the text of another file.

- The parts of the template enclosed in brackets `<# ... #>` are executed by the **Generate Code** command. Parts of the template outside those brackets are copied to the result file. It is important to distinguish between the generating code and the generated text. The generated text can be in any language.

- `<#= Expressions #>` are evaluated and converted to strings.

## See Also
 [UML Class Diagrams: Reference](../modeling/uml-class-diagrams-reference.md)
 [UML Class Diagrams: Guidelines](../modeling/uml-class-diagrams-guidelines.md)
 [Generate files from a UML model](../modeling/generate-files-from-a-uml-model.md)
