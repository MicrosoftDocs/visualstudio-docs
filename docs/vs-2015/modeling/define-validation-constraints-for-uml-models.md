---
title: "Define validation constraints for UML models | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML model, validation constraints"
ms.assetid: 87b3b0da-122d-4121-9318-200c38ff49d0
caps.latest.revision: 49
author: jillre
ms.author: jillfra
manager: jillfra
---
# Define validation constraints for UML models
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

You can define validation constraints that test whether the model meets a condition you specify. For example, you could define a constraint to make sure that a user does not create a loop of inheritance relationships. The constraint is invoked when the user tries to open or save the model, and can also be invoked manually. If the constraint fails, an error message that you define is added to the error window. You can package these constraints into a Visual Studio Integration Extension ([VSIX](https://go.microsoft.com/fwlink/?LinkId=160780)) and distribute it to other Visual Studio users.

 You can also define constraints that validate the model against external resources such as databases. If you want to validate program code against a layer diagram, see [Add custom architecture validation to layer diagrams](../modeling/add-custom-architecture-validation-to-layer-diagrams.md).

 To see which versions of Visual Studio support UML models, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Requirements
 See [Requirements](../modeling/extend-uml-models-and-diagrams.md#Requirements).

 To see which versions of Visual Studio support this feature, see [Version support for architecture and modeling tools](../modeling/what-s-new-for-design-in-visual-studio.md#VersionSupport).

## Applying Validation Constraints
 Validation constraints are applied in three cases: when you save a model; when you open a model; and when you click **Validate UML Model** on the **Architecture** menu. In each case, only those constraints that have been defined for that case will be applied, although typically you would define each constraint to apply in more than one case.

 Validation errors are reported in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] errors window, and you can double-click the error to select the model elements that are in error.

 For more information about applying validation, see [Validate your UML model](../modeling/validate-your-uml-model.md).

## Defining a Validation Extension
 To create a validation extension for a UML designer, you must create a class that defines the validation constraints, and embed the class in a Visual Studio Integration Extension (VSIX). The VSIX acts as a container that can install the constraint. There are two alternative methods of defining a validation extension:

- **Create a validation extension in its own VSIX using a project template.** This is the quicker method. Use it if you do not want to combine your validation constraints with other types of extension such as menu commands, custom toolbox items, or gesture handlers. You can define several constraints in one class.

- **Create separate validation class and VSIX projects.** Use this method if you want to combine several types of extension into the same VSIX. For example, if your menu command expects the model to observe specific constraints, you could embed it into the same VSIX as a validation method.

#### To create a validation extension in its own VSIX

1. In the **New Project** dialog box, under **Modeling Projects**, select **Validation Extension**.

2. Open the **.cs** file in the new project and modify the class to implement your validation constraint.

    For more information, see [Evaluating the Validation Constraint](#Implementing).

   > [!IMPORTANT]
   > Make sure that your **.cs** files contain the following `using` statement:
   >
   >  `using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;`

3. You can add additional constraints by defining new methods. To identify a method as a validation method, it must be tagged with the attributes in the same way as the initial validation method.

4. Test your constraints by pressing F5. For more information, see [Executing a Validation Constraint](#Executing).

5. Install the menu command on another computer by copying the file **bin\\\*\\\*.vsix** that is built by your project. For more information, see [Installing and uninstalling an extension](#Installing).

   When you add other **.cs** files, you will typically require the following `using` statements:

```csharp
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.Modeling.Validation;
using Microsoft.VisualStudio.Uml.Classes;

```

 Here is the alternative procedure:

#### To create a separate validation constraint in a class library project

1. Create a class library project, either adding it to an existing VSIX solution, or creating a new solution.

    1. On the **File** menu, choose **New**, **Project**.

    2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, and then in the middle column choose **Class Library**.

2. Unless your solution already contains one, create a VSIX project:

    1. In **Solution Explorer**, on the shortcut menu of the solution, choose  **Add**, **New Project**.

    2. Under **Installed Templates**, expand **Visual C#** or **Visual Basic**, then choose **Extensibility**. In the middle column, click **VSIX Project**.

3. Set the VSIX project as the startup project of the solution.

    - In Solution Explorer, on the shortcut menu of the VSIX project choose **Set as StartUp project**.

4. In **source.extension.vsixmanifest**, under **Content**, add the class library project as a MEF Component:

    1. On the **MetaData** tab, set a name for the VSIX.

    2. On the **Install Targets** tab, set the Visual Studio versions as the targets.

    3. On the **Assets** tab, choose a **New**, and in the dialog box, set:

         **Type** = **MEF Component**

         **Source** = **A project in current solution**

         **Project** = *Your class library project*

#### To define the Validation Class

1. You do not need this procedure if you have created a validation class with its own VSIX from the validation project template.

2. In the validation class project, add references to the following [!INCLUDE[TLA2#tla_net](../includes/tla2sharptla-net-md.md)] assemblies:

     `Microsoft.VisualStudio.Modeling.Sdk.[version]`

     `Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml`

     `Microsoft.VisualStudio.Uml.Interfaces`

     `System.ComponentModel.Composition`

3. Add a file to the class library project containing code that is similar to the following example.

    - Each validation constraint is contained within a method that is marked with a specific attribute. The method accepts a parameter of a model element type. When validation is invoked, the validation framework will apply every validation method to every model element that conforms to its parameter type.

    - You can place these methods in any classes and namespaces. Change them to your preference.

    ```
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using System.Linq;
    using Microsoft.VisualStudio.Modeling.Validation;
    using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
    using Microsoft.VisualStudio.Uml.Classes;
    // You might also need the other Microsoft.VisualStudio.Uml namespaces.

    namespace Validation
    {
      public class MyValidationExtensions
      {
        // SAMPLE VALIDATION METHOD.
        // All validation methods have the following attributes.
        [Export(typeof(System.Action<ValidationContext, object>))]
        [ValidationMethod(
           ValidationCategories.Save
         | ValidationCategories.Open
         | ValidationCategories.Menu)]
        public void ValidateClassNames
          (ValidationContext context,
           // This type determines what elements
           // will be validated by this method:
           IClass elementToValidate)
        {
          // A validation method should not change the model.

          List<string> attributeNames = new List<string>();
          foreach (IProperty attribute in elementToValidate.OwnedAttributes)
          {
            string name = attribute.Name;
            if (!string.IsNullOrEmpty(name) && attributeNames.Contains(name))
            {
              context.LogError(
                string.Format("Duplicate attribute name '{0}' in class {1}", name, elementToValidate.Name),
                "001", elementToValidate);
            }
            attributeNames.Add(name);
          }

        }
        // Add more validation methods for different element types.
      }
    }
    ```

## <a name="Executing"></a> Executing a Validation Constraint
 For test purposes, execute your validation methods in debug mode.

#### To test the validation constraint

1. Press **F5**, or on the **Debug** menu, choose **Start Debugging**.

     An experimental instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] starts.

     **Troubleshooting**: If a new [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] does not start:

    - If you have more than one project, make sure that the VSIX project is set as the Startup project of the solution.

    - In Solution Explorer, on the shortcut menu of the startup or only project, choose **Properties**. In the project properties editor, select the **Debug** tab. Make sure that the string in the **Start external program** field is the full pathname of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], typically:

         `C:\Program Files\Microsoft Visual Studio [version]\Common7\IDE\devenv.exe`

2. In the experimental [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], open or create a modeling project, and open or create a modeling diagram.

3. To set up a test for the sample constraint given in the previous section:

    1. Open a class diagram.

    2. Create a class, and add two attributes that have the same name.

4. On the shortcut menu anywhere on the diagram, choose **Validate**.

5. Any errors in the model will be reported in the errors window.

6. Double-click the error report. If the elements mentioned in the report are visible on the screen, they will be highlighted.

     **Troubleshooting**: If the **Validate** command does not appear on the menu, make sure that:

    - The validation project is listed as a MEF component in the **Assets** tab in **source.extensions.manifest** in the VSIX project.

    - The correct `Export` and `ValidationMethod` attributes are attached to the validation methods.

    - `ValidationCategories.Menu` is included in the argument for the `ValidationMethod` attribute, and it is composed with other values using Logical OR (&#124;).

    - The parameters of all the `Import` and `Export` attributes are valid.

## <a name="Implementing"></a> Evaluating the Constraint
 The validation method should determine whether the validation constraint that you want to apply is true or false. If true, it should do nothing. If false, it should report an error using the methods provided by the `ValidationContext` parameter.

> [!NOTE]
> Validation methods should not change the model. There is no guarantee when or in what order the constraints will be executed. If you have to pass information between successive executions of a validation method within a validation run, you can use the context cache described under [Coordinating Multiple Validations](#ContextCache).

 For example, if you want to ensure that every type (class, interface, or enumerator) has a name that is at least three characters long, you could use this method:

```
public void ValidateTypeName(ValidationContext context, IType type)
{
  if (!string.IsNullOrEmpty(type.Name) && type.Name.Length < 3)
  {
    context.LogError(
      string.Format("Type name {0} is too short", type.Name),
               "001", type);
   }
 }
```

 See [Programming with the UML API](../modeling/programming-with-the-uml-api.md) for information about the methods and types you can use to navigate and read the model.

### About Validation Constraint Methods
 Each validation constraint is defined by a method of the following form:

```
[Export(typeof(System.Action<ValidationContext, object>))]
 [ValidationMethod(ValidationCategories.Save
  | ValidationCategories.Menu
  | ValidationCategories.Open)]
public void ValidateSomething
  (ValidationContext context, IClassifier elementToValidate)
{...}
```

 The attributes and parameters of every validation method are as follows:

|||
|-|-|
|`[Export(typeof(System.Action <ValidationContext, object>))]`|Defines the method as a validation constraint using Managed Extensibility Framework (MEF).|
|`[ValidationMethod (ValidationCategories.Menu)]`|Specifies when validation will be performed. Use bitwise OR (&#124;) if you want to combine more than one option.<br /><br /> `Menu` = invoked by the Validate menu.<br /><br /> `Save` = invoked on saving the model.<br /><br /> `Open` = invoked on opening the model. `Load` = invoked on saving the model, but for a contravention warns the user that it may not be possible to re-open the model. Also called on loading, before the model is parsed.|
|`public void ValidateSomething`<br /><br /> `(ValidationContext context,`<br /><br /> `IElement element)`|Replace the second parameter `IElement` by the type of element to which you want the constraint to apply. The constraint method will be invoked on all elements in the specified type.<br /><br /> The name of the method is unimportant.|

 You can define as many validation methods as you want, with different types in the second parameter. When validation is invoked, each validation method will be called on each model element that conforms to the parameter type.

### Reporting Validation Errors
 To create an error report, use the methods provided by `ValidationContext`:

 `context.LogError("error string", errorCode, elementsWithError);`

- `"error string"` appears in the [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Error List

- `errorCode` is a string that should be a unique identifier of the error

- `elementsWithError` identifies elements in the model. When the user double-clicks the error report, the shape representing this element will be selected.

  `LogError(),` `LogWarning()` and `LogMessage()` place messages in different sections of the error list.

## How Validation Methods are Applied
 Validation is applied to every element in the model, including relationships and the parts of larger elements, such as attributes of a class and parameters of an operation.

 Each validation method is applied to each element that conforms to the type in its second parameter. This means that, for example, if you define a validation method with a second parameter of `IUseCase` and another with its supertype `IElement`, then both of these methods will be applied to each use case in the model.

 The hierarchy of types is summarized in [UML model element types](../modeling/uml-model-element-types.md).

 You can also access elements by following relationships. For example, if you were to define a validation method on `IClass`, you could loop through its owned properties:

```
public void ValidateTypeName(ValidationContext context, IClass c)
{
   foreach (IProperty property in c.OwnedAttributes)
   {
       if (property.Name.Length < 3)
       {
            context.LogError(
                 string.Format(
                        "Property name {0} is too short",
                        property.Name),
                 "001", property);
        }
   }
}
```

### Creating a validation method on the Model
 If you want to ensure that a validation method is called exactly once during each validation run, you can validate the `IModel`:

```
using Microsoft.VisualStudio.Uml.AuxiliaryConstructs; ...
[Export(typeof(System.Action<ValidationContext, object>))]
[ValidationMethod(ValidationCategories.Menu)]
public void ValidateModel(ValidationContext context, IModel model)
{  foreach (IElement element in model.OwnedElements)
   { ...
```

### Validating shapes and diagrams
 Validation methods are not invoked on display elements such as diagrams and shapes, because the primary purpose of validation methods is to validate the model. But you can access the current diagram using the diagram context.

 In your validation class, declare `DiagramContext` as an imported property:

```
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
...
[Import]
public IDiagramContext DiagramContext { get; set; }
```

 In a validation method, you can use `DiagramContext` to access the current focus diagram, if there is one:

```
[Export(typeof(System.Action<ValidationContext, object>))]
[ValidationMethod(ValidationCategories.Menu)]
public void ValidateModel(ValidationContext context, IModel model)
{
  IDiagram focusDiagram = DiagramContext.CurrentDiagram;
  if (focusDiagram != null)
  {
    foreach (IShape<IUseCase> useCaseShape in
              focusDiagram.GetChildShapes<IUseCase>())
    { ...
```

 To log an error, you must obtain the model element that the shape represents, because you cannot pass a shape to `LogError`:

```
IUseCase useCase = useCaseShape.Element;
context.LogError(... , usecase);
```

### <a name="ContextCache"></a> Coordinating Multiple Validations
 When validation is invoked, for example by the user from a diagram menu, each validation method is applied to each model element. This means that, in a single invocation of the validation framework, the same method may be applied many times to different elements.

 This presents a problem for validations that deal with the relationships between elements. For example, you might write a validation that starts from, say, a use case, and traverses the **include** relationships to verify that there are no loops. But when the method is applied to each use case in a model that has many **include** links, it is likely to repeatedly process the same areas of the model.

 To avoid this situation, there is a context cache in which information is preserved during a validation run. You can use it to pass information between different executions of the validation methods. For example, you could store a list of the elements that have already been dealt with in this validation run. The cache is created at the start of each validation run, and cannot be used to pass information between different validation runs.

|||
|-|-|
|`context.SetCacheValue<T> (name, value)`|Store a value|
|`context.TryGetCacheValue<T> (name, out value)`|Get a value. Returns true if successful.|
|`context.GetValue<T>(name)`|Get a value.|
|`Context.GetValue<T>()`|Get a value of the specified type.|

## <a name="Installing"></a> Installing and uninstalling an extension
 You can install a [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] extension both on your own computer and on other computers.

#### To install an extension

1. On your computer, find the **.vsix** file that was built by your VSIX project.

    1. In **Solution Explorer**, on the shortcut menu of the VSIX project, choose **Open Folder in Windows Explorer**.

    2. Locate the file **bin\\\*\\**_YourProject_**.vsix**

2. Copy the **.vsix** file to the target computer on which you want to install the extension. This can be your own computer or another one.

    - The target computer must have one of the editions of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] that you specified in **source.extension.vsixmanifest**.

3. On the target computer, open the **.vsix** file.

     **Visual Studio Extension Installer** opens and installs the extension.

4. Start or restart [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)].

#### To uninstall an extension

1. On the **Tools** menu, choose **Extensions and Updates**.

2. Expand **Installed Extensions**.

3. Select the extension, and then choose **Uninstall**.

   Rarely, a faulty extension fails to load and creates a report in the error window, but does not appear in Extension Manager. In that case, you can remove the extension by deleting the file from the following location where *%LocalAppData%* is typically *DriveName*:\Users\\*UserName*\AppData\Local:

   *%LocalAppData%* **\Microsoft\VisualStudio\\[version]\Extensions**

## <a name="Example"></a> Example
 This example finds loops in the Dependency relationship between elements.

 It will validate both on save and on the validate menu command.

```
/// <summary>
/// Verify that there are no loops in the dependency relationsips.
/// In our project, no element should be a dependent of itself.
/// </summary>
/// <param name="context">Validation context for logs.</param>
/// <param name="element">Element to start validation from.</param>
[Export(typeof(System.Action<ValidationContext, object>))]
[ValidationMethod(ValidationCategories.Menu
     | ValidationCategories.Save | ValidationCategories.Open)]
public void NoDependencyLoops(ValidationContext context, INamedElement element)
{
    // The validation framework will call this method
    // for every element in the model. But when we follow
    // the dependencies from one element, we will validate others.
    // So we keep a list of the elements that we don't need to validate again.
    // The list is kept in the context cache so that it is passed
    // from one execution of this method to another.
    List<INamedElement> alreadySeen = null;
    if (!context.TryGetCacheValue("No dependency loops", out alreadySeen))
    {
       alreadySeen = new List<INamedElement>();
       context.SetCacheValue("No dependency loops", alreadySeen);
    }

    NoDependencyLoops(context, element,
                new INamedElement[0], alreadySeen);
}

/// <summary>
/// Log an error if there is any loop in the dependency relationship.
/// </summary>
/// <param name="context">Validation context for logs.</param>
/// <param name="element">The element to be validated.</param>
/// <param name="dependants">Elements we've followed in this recursion.</param>
/// <param name="alreadySeen">Elements that have already been validated.</param>
/// <returns>true if no error was detected</returns>
private bool NoDependencyLoops(ValidationContext context,
    INamedElement element, INamedElement[] dependants,
    List<INamedElement> alreadySeen)
{
    if (dependants.Contains(element))
    {
        context.LogError(string.Format("{0} should not depend on itself", element.Name),
        "Fabrikam.UML.NoGenLoops", // unique code for this error
        dependants.SkipWhile(e => e != element).ToArray());
            // highlight elements that are in the loop
        return false;
    }
    INamedElement[] dependantsPlusElement =
        new INamedElement[dependants.Length + 1];
    dependants.CopyTo(dependantsPlusElement, 0);
    dependantsPlusElement[dependantsPlusElement.Length - 1] = element;

    if (alreadySeen.Contains(element))
    {
        // We have already validated this when we started
        // from another element during this validation run.
        return true;
    }
    alreadySeen.Add(element);

    foreach (INamedElement supplier in element.GetDependencySuppliers())
    {
        if (!NoDependencyLoops(context, supplier,
             dependantsPlusElement, alreadySeen))
        return false;
    }
    return true;
}
```

## See Also
 [Define and install a modeling extension](../modeling/define-and-install-a-modeling-extension.md)
 [Programming with the UML API](../modeling/programming-with-the-uml-api.md)
