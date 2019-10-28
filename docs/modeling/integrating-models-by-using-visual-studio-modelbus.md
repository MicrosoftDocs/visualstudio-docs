---
title: Integrating Models by using Modelbus
ms.date: 11/04/2016
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Integrate models by using Visual Studio Modelbus

Visual Studio ModelBus provides a method for creating links between models and from other tools into models. For example, you could link domain-specific language (DSL) models and UML models. You can create an integrated set of DSLs.

ModelBus lets you create a unique reference to a model or to a specific element inside a model. This reference can be stored outside the model, for example, in an element in another model. When, on a later occasion, a tool wants to obtain access to the element, the Model Bus infrastructure will load the appropriate model and return the element. If you want, you can display the model to the user. If the file cannot be accessed in its previous location, ModelBus will ask the user to find it. If the user finds the file, ModelBus will fix all the references to that file.

> [!NOTE]
> In the current Visual Studio implementation of ModelBus, the linked models must be items in the same Visual Studio solution.

For additional information and sample code, see:

- [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md)

- [Modeling SDK for Visual Studio](https://www.microsoft.com/download/details.aspx?id=48148)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]

## <a name="provide"></a> Providing Access to a DSL
 Before you can create ModelBus references to a model or its elements, you must define a ModelBusAdapter for the DSL. The easiest way to do this is to use the Visual Studio Model Bus Extension, which adds commands to the DSL Designer.

### <a name="expose"></a> To expose a DSL Definition to Model Bus

1. Open the DSL definition file. Right-click the design surface and then click **Enable Modelbus**.

2. In the dialog box, choose **I want to expose this DSL to the ModelBus**. You can choose both options if you want this DSL both to expose its models and to consume references to other DSLs.

3. Click **OK**. A new project "ModelBusAdapter" is added to the DSL solution.

4. If you want to access the DSL from a text template, you must modify AdapterManager.tt in the new project. Omit this step if you want to access the DSL from other code such as commands and event handlers. For more information, see [Using Visual Studio ModelBus in a Text Template](../modeling/using-visual-studio-modelbus-in-a-text-template.md).

   1. Change the base class of AdapterManagerBase to [VsTextTemplatingModelingAdapterManager](/previous-versions/ee844317(v=vs.140)).

   2. Near the end of the file, insert this additional attribute in front of class AdapterManager:

       `[Microsoft.VisualStudio.Modeling.Integration.HostSpecific(HostName)]`

   3. In the References of ModelBusAdapter project, add **Microsoft.VisualStudio.TextTemplating.Modeling.11.0**.

      If you want to access the DSL both from text templates and from other code, you need two adapters, one modified and one unmodified.

5. Click **Transform All Templates**.

6. Rebuild the solution.

   It is now possible for ModelBus to open instances of this DSL.

   The folder `ModelBusAdapters\bin\*` contains the assemblies built by the `Dsl` project and the `ModelBusAdapters` project. To reference this DSL from another DSL, you should import these assemblies.

### Ensure that elements can be referenced

Visual Studio ModelBus adapters use the guid of an element to identify it, by default. These identifiers must therefore be persisted in the model file.

To ensure that element IDs are persisted:

1. Open DslDefinition.dsl.

2. In DSL Explorer, expand **Xml Serialization Behavior**, then **Class Data**.

3. For each class to which you want to create Model Bus references:

    Click the class node, and in the Properties window, make sure that **Serialize ID** is set to `true`.

   Alternatively, if you want to use element names to identify elements instead of GUIDs, you can override parts of the generated adapters. Override the following methods in the adapter class:

- Override `GetElementId` to return the identifier you want to use. This method is called when creating references.

- Override `ResolveElementReference` to locate the correct element from a Model Bus reference.

## <a name="editRef"></a> Accessing a DSL from another DSL

You can store model bus references in a domain property in a DSL, and you can write custom code that uses them. You can also let the user create a model bus reference by picking a model file and an element within it.

To enable a DSL to use references to another DSL, you should first make it a *consumer* of model bus references.

### To enable a DSL to consume references to an exposed DSL

1. In the DSL Definition diagram, right-click the main part of the diagram and then click **Enable Modelbus**.

2. In the dialog box, select **I want to enable this model to consume model bus references**.

3. In the Dsl project of the consuming DSL, add the following assemblies to the project references. You will find these assemblies (.dll files) in the ModelBusAdapter\bin\\* directory of the exposed DSL.

    - The exposed DSL assembly, for example **Fabrikam.FamilyTree.Dsl.dll**

    - The exposed model bus adapter assembly, for example **Fabrikam.FamilyTree.ModelBusAdapter.dll**

4. Add the following .NET assemblies to the project references of the consuming DSL project.

    1. **Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0.dll**

    2. **Microsoft.VisualStudio.Modeling.Sdk.Integration.Shell.11.0.dll**

### To store a Model Bus Reference in a domain property

1. In the DSL Definition of the consuming DSL, add a domain property to a domain class and set its name.

2. In the Properties window, with the domain property selected, set **Type** to `ModelBusReference`.

   At this stage, program code can set the property value, but it is read-only in the Properties window.

   You can allow users to set the property with a specialized ModelBus reference editor. There are two versions of this editor or *picker:* one allows users to choose a model file, and the other allows users to choose a model file and an element within the model.

### To allow the user to set a Model Bus Reference in a domain property

1. Right-click the domain property and then click **Edit ModelBusReference specific properties**. A dialog box opens. This is the *Model Bus Picker*.

2. Select the appropriate **Kind of ModelBusReference**: to a model or to an element inside a model.

3. In file dialog filter string, enter a string such as `Family Tree files |*.ftree`. Substitute the file extension of your exposed DSL.

4. If you chose to reference an element in a model, you can add a list of types that the user can select, for example Company.FamilyTree.Person.

5. Click **OK**, and then click **Transform All Templates** in the **Solution Explorer** toolbar.

    > [!WARNING]
    > If you have not selected a valid model or entity, the OK button will have no effect, even though it might appear enabled.

6. If you specified a list of target types such as Company.FamilyTree.Person, then you must add an assembly reference to your DSL project, referencing the DLL of the target DSL, for example Company.FamilyTree.Dsl.dll

### To test a Model Bus Reference

1. Build both the exposed and consuming DSLs.

2. Run one of the DSLs in experimental mode by pressing F5 or CTRL+F5.

3. In the Debugging project in the experimental instance of Visual Studio, add files that are instances of each DSL.

    > [!NOTE]
    > Visual Studio ModelBus can only resolve references to models that are items in the same Visual Studio solution. For example, you cannot create a reference to a model file in another part of your file system.

4. Create some elements and links in the instance of the exposed DSL, and save it.

5. Open an instance of the consuming DSL, and select a model element that has a model bus reference property.

6. In Properties window, double-click the model bus reference property. The picker dialog opens.

7. Click **Browse** and select the instance of the exposed DSL.

     The picker will also let you choose an item in the model, if you specified the element-specific kind of model bus reference.

## Creating References in Program Code

When you want to store a reference to a model or an element inside a model, you create a `ModelBusReference`. There are two kinds of `ModelBusReference`: model references and element references.

To create a model reference, you need the AdapterManager of the DSL of which the model is an instance, and the filename or Visual Studio project item of the model.

To create an element reference, you need an adapter for the model file, and the element you want to refer to.

> [!NOTE]
> With the Visual Studio ModelBus, you can create references only to items in the same Visual Studio solution.

### Import the exposed DSL assemblies

In the consuming project, add project references to the DSL and ModelBusAdapter assemblies of the exposed DSL.

For example, suppose that you want to store ModelBus References in elements of a MusicLibrary DSL. The ModelBus References will refer to elements of the FamilyTree DSL. In the `Dsl` project of the MusicLibrary solution, in the References node, add references to the following assemblies:

- Fabrikam.FamilyTree.Dsl.dll - the exposed DSL.

- Fabrikam.FamilyTree.ModelBusAdapters.dll - the ModelBus adapter of the exposed DSL.

- Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0

- Microsoft.VisualStudio.Modeling.Sdk.Integration.Shell.11.0

  These assemblies can be found in the `ModelBusAdapters` project of the exposed DSL, under `bin\*`.

  In the code file where you will create references, you will typically have to import these namespaces:

```csharp
// The namespace of the DSL you want to reference:
using Fabrikam.FamilyTree;  // Exposed DSL
using Fabrikam.FamilyTree.ModelBusAdapters;
using Microsoft.VisualStudio.Modeling.Integration;
using System.Linq;
...
```

### To create a reference to a model

To create a model reference, you access the AdapterManager for the exposed DSL, and use it to create a reference to the model. You can specify either a file path, or a `EnvDTE.ProjectItem`.

From the AdapterManager, you can obtain an Adapter, which provides access to individual elements in the model.

> [!NOTE]
> You must dispose an Adapter when you have finished with it. The most convenient way to achieve this is with a `using` statement. The following example illustrates this.

```csharp
// The file path of a model instance of the FamilyTree DSL:
string targetModelFile = "TudorFamilyTree.ftree";
// Get the ModelBus service:
IModelBus modelBus =
    this.Store.GetService(typeof(SModelBus)) as IModelBus;
// Get an adapterManager for the target DSL:
FamilyTreeAdapterManager manager =
    (modelbus.GetAdapterManager(FamilyTreeAdapter.AdapterId)
     as FamilyTreeAdapterManager;
// or: (modelBus.FindAdapterManagers(targetModelFile).First())
// or could provide an EnvDTE.ProjectItem

// Create a reference to the target model:
// NOTE: the target model must be a file in this project.
ModelBusReference modelReference =
     manager.CreateReference(targetModelFile);
// or can use an EnvDTE.ProjectItem instead of the filename

// Get the root element of this model:
using (FamilyTreeAdapter adapter =
     modelBus.CreateAdapter(modelReference) as FamilyTreeAdapter)
{
  FamilyTree modelRoot = adapter.ModelRoot;
  // Access elements under the root in the usual way:
  foreach (Person p in modelRoot.Persons) {...}
  // You can create adapters for individual elements:
  ModelBusReference elementReference =
     adapter.GetElementReference(person);
  ...
} // Dispose adapter
```

If you want to be able to use `modelReference` later, you can store it in a domain property that has the External Type `ModelBusReference`:

```csharp
using Transaction t = this.Store.TransactionManager
    .BeginTransaction("keep reference"))
{
  artist.FamilyTreeReference = modelReference;
  t.Commit();
}
```

To allow users to edit this domain property, use `ModelReferenceEditor` as the parameter in the Editor attribute. For more information, see [Allow the User to Edit a Reference](#editRef).

### To create a reference to an element

The adapter that you created for the model can be used to create and resolve references.

```csharp
// person is an element in the FamilyTree model:
ModelBusReference personReference =
  adapter.GetElementReference(person);
```

If you want to be able to use `elementReference` later, you can store it in a domain property that has the External Type `ModelBusReference`. To allow users to edit it, use `ModelElementReferenceEditor` as the parameter in the Editor attribute. For more information, see [Allow the User to Edit a Reference](#editRef).

### Resolving references

If you have a `ModelBusReference` (MBR) you can obtain the model or the model element to which it refers. If the element is presented on a diagram or other view, you can open the view and select the element.

You can create an adapter from an MBR. From the adapter, you can obtain the root of the model. You can also resolve MBRs that refer to specific elements within the model.

```csharp
using Microsoft.VisualStudio.Modeling.Integration; ...
ModelBusReference elementReference = ...;

// Get the ModelBus service:
IModelBus modelBus =
    this.Store.GetService(typeof(SModelBus)) as IModelBus;
// Use a model reference or an element reference
// to obtain an adapter for the target model:
using (FamilyTreeAdapter adapter =
   modelBus.CreateAdapter(elementReference) as FamilyTreeAdapter)
   // or CreateAdapter(modelReference)
{
  // Get the root of the model:
  FamilyTree tree = adapter.ModelRoot;

  // Get a model element:
  MyDomainClass mel =
    adapter.ResolveElementReference<MyDomainClass>(elementReference);
  if (mel != null) {...}

  // Get the diagram or other view, if there is one:
  ModelBusView view = adapter.GetDefaultView();
  if (view != null)
  {
   view.Open();
   // Display the diagram:
   view.Show();
   // Attempt to select the shape that presents the element:
   view.SetSelection(elementReference);
  }
} // Dispose the adapter.
```

#### To resolve ModelBus References in a Text Template

1. The DSL you want to access must have a ModelBus Adapter that has been configured for access by text templates. For more information, see [Providing Access to a DSL](#provide).

2. Typically, you will be accessing a target DSL using a Model Bus Reference (MBR) stored in a source DSL. Your template therefore includes the directive of the source DSL, plus code to resolve the MBR. For more information about text templates, see [Generating Code from a Domain-Specific Language](../modeling/generating-code-from-a-domain-specific-language.md).

   ```
   <#@ template debug="true" hostspecific="true"
   inherits="Microsoft.VisualStudio.TextTemplating.Modeling.ModelBusEnabledTextTransformation" #>
   <#@ SourceDsl processor="SourceDslDirectiveProcessor" requires="fileName='Sample.source'" #>
   <#@ output extension=".txt" #>
   <#@ assembly name = "Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0" #>
   <#@ assembly name = "System.Core" #>
   <#@ assembly name = "Company.CompartmentDragDrop.Dsl.dll" #>
   <#@ assembly name = "Company.CompartmentDragDrop.ModelBusAdapter.dll" #>
   <#@ import namespace="Microsoft.VisualStudio.Modeling.Integration" #>
   <#@ import namespace="System.Linq" #>
   <#@ import namespace="Company.CompartmentDragDrop" #>
   <#@ import namespace="Company.CompartmentDragDrop.ModelBusAdapters" #>
   <# // Get source root from directive processor:
     ExampleModel source = this.ExampleModel;
     // This DSL has a MBR in its root:
   using (ModelBusAdapter adapter = this.ModelBus.CreateAdapter(source.ModelReference) as ModelBusAdapter)
     {
     ModelBusAdapterManager manager = this.ModelBus.FindAdapterManagers(this.Host.ResolvePath("Sample.compDD1")).FirstOrDefault();
     ModelBusReference modelReference =
       manager.CreateReference(this.Host.ResolvePath("Sample.compDD1"));

     // Get the root element of this model:
     using (CompartmentDragDropAdapter adapter =
        this.ModelBus.CreateAdapter(modelReference) as CompartmentDragDropAdapter)
     {
       ModelRoot root = adapter.ModelRoot;
   #>
   [[<#= root.Name #>]]
   <#
     }
   #>
   ```

   For more information and a walkthrough, see [Using Visual Studio ModelBus in a Text Template](../modeling/using-visual-studio-modelbus-in-a-text-template.md)

## Serializing a ModelBusReference

If you want to store a `ModelBusReference` (MBR) in the form of a string, you can serialize it:

```csharp
string serialized = modelBus.SerializeReference(elementReference);
// Store it anywhere, then get it back again:
ModelBusReference elementReferenceRestored =
    modelBus.DeserializeReference(serialized, null);
```

A MBR that is serialized in this manner is independent of context. If you are using the simple file-based Model Bus Adapter, the MBR contains an absolute file path. This is sufficient if the instance model files will never move. However, the model files will typically be items in a Visual Studio project. Your users will expect to be able to move the whole project to different parts of the file system. They will also expect to be able to keep the project under source control and open it on different computers. Path names should therefore be serialized relative to the location of the project that contains the files.

### Serializing Relative to a Specified File Path

A `ModelBusReference` contains a `ReferenceContext`, which is a dictionary in which you can store information such as the file path relative to which it should be serialized.

To serialize relative to a path:

```csharp
elementReference.ReferenceContext.Add(
   ModelBusReferencePropertySerializer.FilePathSaveContextKey,
   currentProjectFilePath);
string serialized = modelBus.SerializeReference(elementReference);
```

To retrieve the reference from the string:

```csharp
ReferenceContext context = new ReferenceContext();
context.Add(ModelBusReferencePropertySerializer.FilePathLoadContextKey,
    currentProjectFilePath);
ModelBusReference elementReferenceRestored =
    modelBus.DeserializeReference(serialized, context);
```

### ModelBusReferences created by other Adapters
 The following information is useful if you want to create your own adapter.

 A `ModelBusReference` (MBR) consists of two parts: the MBR header, which is deserialized by the model bus, and an adapter-specific that is handled by the specific adapter manager. This lets you provide your own adapter serialization format. For example, you could reference a database rather than a file, or you could store additional information in the adapter reference. Your own adapter can place additional information in the `ReferenceContext`.

 When you deserialize an MBR, you must provide a ReferenceContext, which is then stored in the MBR object. When you serialize an MBR, the stored ReferenceContext is used by the adapter to help generate the string. The deserialized string does not contain all the information in the ReferenceContext. For example, in the simple file-based adapter, the ReferenceContext contains a root file path, which is not stored in the serialized MBR string.

 The MBR is deserialized in two stages:

- `ModelBusReferencePropertySerializer` is the standard serializer that deals with the MBR header. It uses the standard DSL `SerializationContext` property bag, which is stored in the `ReferenceContext` using the key `ModelBusReferencePropertySerializer.ModelBusLoadContextKey`. In particular, the `SerializationContext` should contain an instance of `ModelBus`.

- Your ModelBus Adapter deals with the adapter-specific part of the MBR. It can use additional information stored in the ReferenceContext of the MBR. The simple file-based adapter keeps root file paths using the keys `FilePathLoadContextKey` and `FilePathSaveContextKey`.

     An adapter reference in a model file is deserialized only when it is used.

## To Create a Model

### Creating, opening and editing a model
 The following fragment is taken from the State Machine sample on the VMSDK website. It illustrates the use of ModelBusReferences to create and open a model, and to obtain the diagram associated with the model.

 In this sample, the name of the target DSL is StateMachine. Several names are derived from it, such as the name of the model class and the name of the ModelBusAdapter.

```csharp
using Fabrikam.StateMachine.ModelBusAdapters;
using Microsoft.VisualStudio.Modeling;
using Microsoft.VisualStudio.Modeling.Diagrams;
using Microsoft.VisualStudio.Modeling.Integration;
using Microsoft.VisualStudio.Modeling.Integration.Shell;
using Microsoft.VisualStudio.Modeling.Shell;
...
// Create a new model.
ModelBusReference modelReference =
   StateMachineAdapterManager    .CreateStateMachineModel(modelName, fileName);
//Keep reference of new model in this model.
using (Transaction t = ...)
{
  myModelElement.ReferenceProperty = modelReference;
  t.Commit();
}
// Get the ModelBus service from Visual Studio.
IModelBus modelBus = Microsoft.VisualStudio.Shell.Package.
    GetGlobalService(typeof(SModelBus)) as IModelBus;
// Get a modelbus adapter on the new model.
ModelBusAdapter modelBusAdapter;
modelBus.TryCreateAdapter(modelReference,
    this.ServiceProvider, out modelBusAdapter);
using (StateMachineAdapter adapter =
      modelBusAdapter as StateMachineAdapter)
{
    if (adapter != null)
    {
        // Obtain a Diagram from the adapter.
        Diagram targetDiagram =
           ((StandardVsModelingDiagramView)
                 adapter.GetDefaultView()
            ).Diagram;

        using (Transaction t =
             targetDiagram.Store.TransactionManager
                .BeginTransaction("Update diagram"))
        {
            DoUpdates(targetDiagram);
            t.Commit();
        }

        // Display the new diagram.
        adapter.GetDefaultView().Show();
    }
}
```

## Validating references
 The BrokenReferenceDetector tests all the domain properties in a Store that can hold ModelBusReferences. It calls the action you that provide where any action is found. This is particularly useful for validation methods. The following validation method tests the store on an attempt to save the model, and reports broken references in the errors window:

```csharp
[ValidationMethod(ValidationCategories.Save)]
public void ValidateModelBusReferences(ValidationContext context)
{
  BrokenReferenceDetector.DetectBrokenReferences(this.Store,
    delegate(ModelElement element, // parent of property
             DomainPropertyInfo property, // identifies property
             ModelBusReference reference) // invalid reference
    {
      context.LogError(string.Format(INVALID_REF_FORMAT,
             property.Name,
             referenceState.Name,
             new ModelBusReferenceTypeConverter().
                 ConvertToInvariantString(reference)),
         "Reference",
         element);
      });
}}
private const string INVALID_REF_FORMAT =
    "The '{0}' domain property of ths ReferenceState instance "
  + "named '{1}' contains reference value '{2}' which is invalid";
```

## Actions performed by the ModelBus Extension

The following information is not essential, but might be useful if you make extensive use of ModelBus.

The ModelBus Extension makes the following changes in your DSL solution.

When you right-click the DSL Definition diagram, click **Enable Modelbus**, and then select **Enable this DSL to Consume the ModelBus**:

- In the DSL project, a reference is added to **Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0.dll**

- In the DSL Definition, an External Type reference is added: `Microsoft.VisualStudio.Modeling.Integration.ModelBusReference`.

   You can see the reference in **DSL Explorer**, under **Domain Types**. To add external type references manually, right-click the root node.

- A new template file is added, **Dsl\GeneratedCode\ModelBusReferencesSerialization.tt**.

When you set the type of a domain property to ModelBusReference, and then right-click the property and click **Enable ModelBusReference specific properties**:

- Several CLR attributes are added to the domain property. You can see them in the Custom Attributes field in the Properties window. In **Dsl\GeneratedCode\DomainClasses.cs**, you can see the attributes on the property declaration:

  ```csharp
  [System.ComponentModel.TypeConverter(typeof(
  Microsoft.VisualStudio.Modeling.Integration.ModelBusReferenceTypeConverter))]
  [System.ComponentModel.Editor(typeof(
    Microsoft.VisualStudio.Modeling.Integration.Picker
    .ModelReferenceEditor // or ModelElementReferenceEditor
    ), typeof(System.Drawing.Design.UITypeEditor))]
  [Microsoft.VisualStudio.Modeling.Integration.Picker
    .SupplyFileBasedBrowserConfiguration
    ("Choose a model file", "Target model|*.target")]
  ```

When you right click the DSL Definition Diagram, click **Enable ModelBus**, and select **Expose this DSL to the ModelBus**:

- A new project `ModelBusAdapter` is added to the solution.

- A reference to `ModelBusAdapter` is added to the `DslPackage` project. `ModelBusAdapter` has a reference to the `Dsl` project.

- In **DslPackage\source.extention.tt**, `|ModelBusAdapter|` is added as a MEF Component.

## See also

- [How to: Open a Model from File in Program Code](../modeling/how-to-open-a-model-from-file-in-program-code.md)
- [How to: Add a Drag-and-Drop Handler](../modeling/how-to-add-a-drag-and-drop-handler.md)
- [Using Visual Studio ModelBus in a Text Template](../modeling/using-visual-studio-modelbus-in-a-text-template.md)
