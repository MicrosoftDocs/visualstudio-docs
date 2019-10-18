---
title: Use ModelBus in a Text Template
ms.date: 11/04/2016
ms.topic: conceptual
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "multiple"
---
# Using Visual Studio ModelBus in a Text Template

If you write text templates that read a model that contains Visual Studio ModelBus references, you might want to resolve the references to access the target models. In that case, you have to adapt the text templates and the referenced domain-specific languages (DSLs):

- The DSL that is the target of the references must have a ModelBus Adapter that is configured for access from text templates. If you also access the DSL from other code, the reconfigured adapter is required in addition to the standard ModelBus Adapter.

     The adapter manager must inherit from [VsTextTemplatingModelingAdapterManager](/previous-versions/ee844317(v=vs.140)) and must have the attribute `[HostSpecific(HostName)]`.

- The template must inherit from [ModelBusEnabledTextTransformation](/previous-versions/ee844263(v=vs.140)).

> [!NOTE]
> If you want to read DSL models that do not contain ModelBus references, you can use the directive processors that are generated in your DSL projects. For more information, see [Accessing Models from Text Templates](../modeling/accessing-models-from-text-templates.md).

For more information about text templates, see [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md).

## Create a Model Bus Adapter for Access from Text Templates

To resolve a ModelBus reference in a text template, the target DSL must have a compatible adapter. Text templates execute in a separate AppDomain from the Visual Studio document editors, and therefore the adapter has to load the model instead of accessing it through DTE.

1. If the target DSL solution does not have a **ModelBusAdapter** project, create one by using the Modelbus Extension wizard:

    1. Download and install the Visual Studio ModelBus Extension, if you have not already done this. For more information, see [Visualization and Modeling SDK](https://devblogs.microsoft.com/devops/the-visual-studio-modeling-sdk-is-now-available-with-visual-studio-2017/).

    2. Open the DSL definition file. Right-click the design surface and then click **Enable Modelbus**.

    3. In the dialog box, select **I want to expose this DSL to the ModelBus**. You can select both options if you want this DSL both to expose its models and to consume references to other DSLs.

    4. Click **OK**. A new project "ModelBusAdapter" is added to the DSL solution.

    5. Click **Transform All Templates**.

    6. Rebuild the solution.

2. If you want to access the DSL both from a text template and from other code, such as command, duplicate the **ModelBusAdapter** project:

    1. In Windows Explorer, copy and paste the folder that contains **ModelBusAdapter.csproj**.

    2. Rename the project file (for example, to **T4ModelBusAdapter.csproj**).

    3. In **Solution Explorer**, right-click the solution node, point to **Add**, and then click **Existing Project**. Locate the new adapter project, **T4ModelBusAdapter.csproj**.

    4. In each `*.tt` file of the new project, change the namespace.

    5. Right-click the new project in **Solution Explorer** and then click **Properties**. In the properties editor, change the names of the generated assembly and the default namespace.

    6. In the DslPackage project, add a reference to the new adapter project so that it has references to both adapters.

    7. In DslPackage\source.extension.tt, add a line that references your new adapter project.

        ```
        <MefComponent>|T4ModelBusAdapter|</MefComponent>
        ```

    8. **Transform All Templates** and rebuild the solution. No build errors should occur.

3. In the new adapter project, add references to the following assemblies:

    - Microsoft.VisualStudio.TextTemplating.11.0
    - Microsoft.VisualStudio.TextTemplating.Modeling.11.0

4. In AdapterManager.tt:

    - Change the declaration of AdapterManagerBase so that it inherits from [VsTextTemplatingModelingAdapterManager](/previous-versions/ee844317(v=vs.140)).

         `public partial class <#= dslName =>AdapterManagerBase :`

         `Microsoft.VisualStudio.TextTemplating.Modeling.VsTextTemplatingModelingAdapterManager { ...`

    - Near the end of the file, replace the HostSpecific attribute before the AdapterManager class. Remove the following line:

         `[DslIntegration::HostSpecific(DslIntegrationShell::VsModelingAdapterManager.HostName)]`

         Insert the following line:

         `[Microsoft.VisualStudio.Modeling.Integration.HostSpecific(HostName)]`

         This attribute filters the set of adapters that is available when a modelbus consumer searches for an adapter.

5. **Transform All Templates** and rebuild the solution. No build errors should occur.

## Write a Text Template That Can Resolve ModelBus References

Typically, you begin with a template that reads and generates files from a "source" DSL. This template uses the directive that is generated in the source DSL project to read source model files in the manner that is described in [Accessing Models from Text Templates](../modeling/accessing-models-from-text-templates.md). However, the source DSL contains ModelBus References to a "target" DSL. You therefore want to enable the template code to resolve the references and access the target DSL. You therefore must adapt the template by following these steps:

- Change the base class of the template to [ModelBusEnabledTextTransformation](/previous-versions/ee844263(v=vs.140)).

- Include `hostspecific="true"` in the template directive.

- Add assembly references to the target DSL and its adapter, and to enable ModelBus.

- You do not need the directive that is generated as part of the target DSL.

```
<#@ template debug="true" hostspecific="true" language="C#"
inherits="Microsoft.VisualStudio.TextTemplating.Modeling.ModelBusEnabledTextTransformation" #>
<#@ SourceDsl processor="SourceDslDirectiveProcessor" requires="fileName='Sample.source'" #>
<#@ output extension=".txt" #>
<#@ assembly name = "Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0" #>
<#@ assembly name = "Company.TargetDsl.Dsl.dll" #>
<#@ assembly name = "Company.TargetDsl.T4ModelBusAdapter.dll" #>
<#@ assembly name = "System.Core" #>
<#@ import namespace="Microsoft.VisualStudio.Modeling.Integration" #>
<#@ import namespace="Company.TargetDsl" #>
<#@ import namespace="Company.TargetDsl.T4ModelBusAdapters" #>
<#@ import namespace="System.Linq" #>
<#
  SourceModelRoot source = this.ModelRoot; // Usual access to source model.
  // In the source DSL Definition, the root element has a model reference:
  using (TargetAdapter adapter = this.ModelBus.CreateAdapter(source.ModelReference) as TargetAdapter)
  {if (adapter != null)
   {
      // Get the root of the target model:
      TargetRoot target = adapter.ModelRoot;
    // The source DSL Definition has a class "SourceElement" embedded under the root.
    // (Let's assume they're all in the same model file):
    foreach (SourceElement sourceElement in source.Elements)
    {
      // In the source DSL Definition, each SourceElement has a MBR property:
      ModelBusReference elementReference = sourceElement.ReferenceToTarget;
      // Resolve the target model element:
      TargetElement element = adapter.ResolveElementReference<TargetElement>(elementReference);
#>
     The source <#= sourceElement.Name #> is linked to: <#= element.Name #> in target model: <#= target.Name #>.
<#
    }
  }}
  // Other useful code: this.Host.ResolvePath(filename) gets an absolute filename
  // from a path that is relative to the text template.
#>
```

 When this text template is executed, the `SourceDsl` directive loads the file `Sample.source`. The template can access the elements of that model, starting from `this.ModelRoot`. The code can use the domain classes and properties of that DSL.

 In addition, the template can resolve ModelBus References. Where the references point to the Target model, the assembly directives let the code use the domain classes and properties of that model's DSL.

- If you do not use a directive that is generated by a DSL project, you should also include the following.

    ```
    <#@ assembly name = "Microsoft.VisualStudio.Modeling.Sdk.11.0" #>
    <#@ assembly name = "Microsoft.VisualStudio.TextTemplating.Modeling.11.0" #>
    ```

- Use `this.ModelBus` to obtain access to the ModelBus.

## Walkthrough: Testing a Text Template That Uses ModelBus
 In this walkthrough, you follow these steps:

1. Construct two DSLs. One DSL, the *Consumer*, has a `ModelBusReference` property that can refer to the other DSL, the *Provider*.

2. Create two ModelBus Adapters in the Provider: one for access by text templates, the other for ordinary code.

3. Create instance models of the DSLs in a single experimental project.

4. Set a domain property in one model to point to the other model.

5. Write a double-click handler that opens the model that is pointed to.

6. Write a text template that can load the first model, follow the reference to the other model, and read the other model.

### Construct a DSL that is accessible to ModelBus

1. Create a new DSL solution. For this example, select the Task Flow solution template. Set the language name to `MBProvider` and the file name extension to ".provide".

2. In the DSL Definition diagram, right-click a blank part of the diagram that is not near the top, and then click **Enable Modelbus**.

   If you don't see **Enable Modelbus**, download and install the VMSDK ModelBus extension.

3. In the **Enable Modelbus** dialog box, select **Expose this DSL to the ModelBus**, and then click **OK**.

    A new project, `ModelBusAdapter`, is added to the solution.

You now have a DSL that can be accessed by text templates through ModelBus. References to it can be resolved in the code of commands, event handlers, or rules, all of which operate in the AppDomain of the model file editor. However, text templates run in a separate AppDomain and cannot access a model when it is being edited. If you want to access ModelBus references to this DSL from a text template, you must have a separate ModelBusAdapter.

### Create a ModelBus Adapter that is configured for Text Templates

1. In File Explorer, copy and paste the folder that contains *ModelBusAdapter.csproj*.

    Name the folder **T4ModelBusAdapter**.

    Rename the project file *T4ModelBusAdapter.csproj*.

2. In Solution Explorer, add T4ModelBusAdapter to the MBProvider solution. Right-click the solution node, point to **Add**, and then click **Existing Project**.

3. Right-click the T4ModelBusAdapter project node and then click Properties. In the project properties window, change the **Assembly Name** and **Default Namespace** to `Company.MBProvider.T4ModelBusAdapters`.

4. In each *.tt file in T4ModelBusAdapter, insert "T4" into the last part of the namespace, so that the line resembles the following.

    `namespace <#= CodeGenerationUtilities.GetPackageNamespace(this.Dsl) #>.T4ModelBusAdapters`

5. In the `DslPackage` project, add a project reference to `T4ModelBusAdapter`.

6. In DslPackage\source.extension.tt, add the following line under `<Content>`.

    `<MefComponent>|T4ModelBusAdapter|</MefComponent>`

7. In the `T4ModelBusAdapter` project, add a reference to: **Microsoft.VisualStudio.TextTemplating.Modeling.11.0**

8. Open T4ModelBusAdapter\AdapterManager.tt:

   1. Change the base class of AdapterManagerBase to [VsTextTemplatingModelingAdapterManager](/previous-versions/ee844317(v=vs.140)). This part of the file now resembles the following.

       ```
       namespace <#= CodeGenerationUtilities.GetPackageNamespace(this.Dsl) #>.T4ModelBusAdapters
       {
           /// <summary>
           /// Adapter manager base class (double derived pattern) for the <#= dslName #> Designer
           /// </summary>
           public partial class <#= dslName #>AdapterManagerBase
           : Microsoft.VisualStudio.TextTemplating.Modeling.VsTextTemplatingModelingAdapterManager
           {
       ```

   2. Near the end of the file, insert the following additional attribute in front of class AdapterManager.

        `[Microsoft.VisualStudio.Modeling.Integration.HostSpecific(HostName)]`

        The result resembles the following.

       ```
       /// <summary>
       /// ModelBus modeling adapter manager for a <#= dslName #>Adapter model adapter
       /// </summary>
       [Mef::Export(typeof(DslIntegration::ModelBusAdapterManager))]
       [Mef::ExportMetadata(DslIntegration::CompositionAttributes.AdapterIdKey,<#= dslName #>Adapter.AdapterId)]
       [DslIntegration::HostSpecific(DslIntegrationShell::VsModelingAdapterManager.HostName)]
       [Microsoft.VisualStudio.Modeling.Integration.HostSpecific(HostName)]
       public partial class <#= dslName #>AdapterManager : <#= dslName #>AdapterManagerBase
       {
       }
       ```

9. Click **Transform All Templates** in the title bar of Solution Explorer.

10. Press **F5**.

11. Verify that the DSL is working. In the experimental project, open `Sample.provider`. Close the experimental instance of Visual Studio.

    ModelBus References to this DSL can now be resolved in text templates and also in ordinary code.

### Construct a DSL with a ModelBus Reference domain property

1. Create a new DSL by using the Minimal Language solution template. Name the language MBConsumer and set the file name extension to ".consume".

2. In the DSL project, add a reference to the MBProvider DSL assembly. Right-click  `MBConsumer\Dsl\References` and then click **Add Reference**. In the **Browse** tab, locate `MBProvider\Dsl\bin\Debug\Company.MBProvider.Dsl.dll`

    This enables you to create code that uses the other DSL. If you want to create references to several DSLs, add them also.

3. In the DSL Definition diagram, right-click the diagram and then click **Enable ModelBus**. In the dialog box, select **Enable this DSL to Consume the ModelBus**.

4. In the class `ExampleElement`, add a new domain property `MBR`, and in the Properties window, set its type to `ModelBusReference`.

5. Right-click the domain property on the diagram and then click **Edit ModelBusReference specific properties**. In the dialog box, select **a model element**.

    Set the file dialog filter to the following.

    `Provider File|*.provide`

    The substring after "&#124;" is a filter for the file selection dialog box. You could set it to allow any files by using *.\*

    In the **Model Element type** list, enter the names of one ore more domain classes in the provider DSL (for example, Company.MBProvider.Task). They can be abstract classes. If you leave the list blank, the user can set the reference to any element.

6. Close the dialog and **Transform All Templates**.

   You have created a DSL that can contain references to elements in another DSL.

### Create a ModelBus reference to another file in the solution

1. In the MBConsumer solution, press CTRL+F5. An experimental instance of Visual Studio opens in the **MBConsumer\Debugging** project.

2. Add a copy of Sample.provide to the **MBConsumer\Debugging** project. This is necessary because a ModelBus reference must refer to a file in the same solution.

   1. Right-click the Debugging project, point to **Add**, and then click **Existing Item**.

   2. In the **Add Item** dialog, set the filter to **All Files (\*.\*)**.

   3. Navigate to `MBProvider\Debugging\Sample.provide` and then click **Add**.

3. Open `Sample.consume`.

4. Click one example shape, and in the Properties window, click **[...]** in the MBR property. In the dialog box, click **Browse** and select `Sample.provide`. In the elements window, expand the type Task and select one of the elements.

5. Save the file. (Do not yet close the experimental instance of Visual Studio.)

   You've created a model that contains a ModelBus reference to an element in another model.

### Resolve a ModelBus Reference in a text template

1. In the experimental instance of Visual Studio, open a sample text template file. Set its content as follows.

    ```
    <#@ template debug="true" hostspecific="true" language="C#"
    inherits="Microsoft.VisualStudio.TextTemplating.Modeling.ModelBusEnabledTextTransformation" #>
    <#@ MBConsumer processor="MBConsumerDirectiveProcessor" requires="fileName='Sample.consume'" #>
    <#@ output extension=".txt" #>
    <#@ assembly name = "Microsoft.VisualStudio.Modeling.Sdk.Integration.11.0" #>
    <#@ assembly name = "Company.MBProvider.Dsl.dll" #>
    <#@ import namespace="Microsoft.VisualStudio.Modeling.Integration" #>
    <#@ import namespace="Company.MBProvider" #>
    <#
      // Property provided by the Consumer directive processor:
      ExampleModel consumerModel = this.ExampleModel;
      // Iterate through Consumer model, listing the elements:
      foreach (ExampleElement element in consumerModel.Elements)
      {
    #>
       <#= element.Name #>
    <#
        if (element.MBR != null)
      using (ModelBusAdapter adapter = this.ModelBus.CreateAdapter(element.MBR))
      {
              // If we allowed multiple types or DSLs in the MBR, discover type here.
        Task task = adapter.ResolveElementReference<Task>(element.MBR);
    #>
            <#= element.Name #> is linked to Task: <#= task==null ? "(null)" : task.Name #>
    <#
          }
      }
    #>

    ```

     Notice the following points:

    - The `hostSpecific` and `inherits` attributes of the `template` directive must be set.

    - The consumer model is accessed in the usual manner through the directive processor that was generated in that DSL.

    - The assembly and import directives must be able to access ModelBus and the types of the provider DSL.

    - If you know that many MBRs are linked to the same model, it is better to call CreateAdapter only one time.

2. Save the template. Verify that the resulting text file resembles the following.

    ```
    ExampleElement1
    ExampleElement2
         ExampleElement2 is linked to Task: Task2
    ```

### Resolve a ModelBus reference in a gesture handler

1. Close the experimental instance of Visual Studio, if it is running.

2. Add a file named *MBConsumer\Dsl\Custom.cs* and set its content to the following:

    ```csharp
    namespace Company.MB2Consume
    {
      using Microsoft.VisualStudio.Modeling.Integration;
      using Company.MB3Provider;

      public partial class ExampleShape
      {
        public override void OnDoubleClick(Microsoft.VisualStudio.Modeling.Diagrams.DiagramPointEventArgs e)
        {
          base.OnDoubleClick(e);
          ExampleElement element = this.ModelElement as ExampleElement;
          if (element.MBR != null)
          {
            IModelBus modelbus = this.Store.GetService(typeof(SModelBus)) as IModelBus;
            using (ModelBusAdapter adapter = modelbus.CreateAdapter(element.MBR))
            {
              Task task = adapter.ResolveElementReference<Task>(element.MBR);
              // Open a window on this model:
              ModelBusView view = adapter.GetDefaultView();
              view.Show();
              view.SetSelection(element.MBR);
            }
          }
        }
      }
    }
    ```

3. Press **Ctrl**+**F5**.

4. In the experimental instance of Visual Studio, open `Debugging\Sample.consume`.

5. Double-click one shape.

    If you have set the MBR on that element, the referenced model opens and the referenced element is selected.

## See also

- [Integrating Models by using Visual Studio Modelbus](../modeling/integrating-models-by-using-visual-studio-modelbus.md)
- [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md)

[!INCLUDE[modeling_sdk_info](includes/modeling_sdk_info.md)]
