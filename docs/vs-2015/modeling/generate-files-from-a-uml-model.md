---
title: "Generate files from a UML model | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: visual-studio-dev14
ms.technology: vs-ide-modeling
ms.topic: conceptual
helpviewer_keywords:
  - "UML model, generating files"
ms.assetid: 4e28b0e6-ce8f-45ee-9e3a-e4d600a0ad81
caps.latest.revision: 21
author: jillre
ms.author: jillfra
manager: jillfra
---
# Generate files from a UML model
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

From a UML model, you can generate program code, schemas, documents, resources, and other artifacts of any kind. One convenient method of generating text files from a UML model is to use [text templates](../modeling/code-generation-and-t4-text-templates.md). These let you embed program code inside the text that you want to generate.

 There are three principal scenarios:

- [Generating files from a menu command](#Command) or gesture. You define a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] command that is available on UML models.

- [Generating files from an application](#Application). You write an application that reads UML models and generates files.

- [Generating at design time](#Design). You use a model to define some of your application's functionality, and generate code, resources, and so on within your [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] solution.

  This topic ends with a discussion of [how to use text generation](#What). For more information, see [Code Generation and T4 Text Templates](../modeling/code-generation-and-t4-text-templates.md).

## <a name="Command"></a> Generating files from a menu command
 You can use preprocess text templates within a UML menu command. Within the code of the text template, or in a separate partial class, you can read the model that is viewed by the diagram.

 For more information about these features, read the following topics:

- [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md)

- [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md)

- [Navigate the UML model](../modeling/navigate-the-uml-model.md)

  The approach demonstrated in the following example is suitable for generating text from a single model, when you initiate the operation from one of the model diagrams. To process a model in a separate context, consider using [Visual Studio Modelbus](../modeling/integrate-uml-models-with-other-models-and-tools.md) to access the model and its elements.

### Example
 To run this example, create a [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] Extension (VSIX) project. The project name that is used in this example is `VdmGenerator`. In the **source.extension.vsixmanifest** file, click **Add Content** and set the type field to **MEF Component** and source path referencing the current project. For more information about how to set up this type of project, see [Define a menu command on a modeling diagram](../modeling/define-a-menu-command-on-a-modeling-diagram.md).

 Add to the project a C# file that contains the following code. This class defines a menu command that will appear on a UML class diagram.

```
using System;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;

namespace VdmGenerator
{
  [Export(typeof(ICommandExtension))]
  [ClassDesignerExtension]
  public class GenerateVdmFromClasses : ICommandExtension
  {
    [Import] public IDiagramContext DiagramContext { get; set; }
    public void Execute(IMenuCommand command)
    {
      // Initialize the template with the Model Store.
      VdmGen generator = new VdmGen(
             DiagramContext.CurrentDiagram.ModelStore);
      // Generate the text and write it.
      System.IO.File.WriteAllText
        (System.IO.Path.Combine(
            Environment.GetFolderPath(
                Environment.SpecialFolder.Desktop),
            "Generated.txt")
         , generator.TransformText());
    }
    public void QueryStatus(IMenuCommand command)
    {
      command.Enabled = command.Visible = true;
    }
    public string Text
    { get { return "Generate VDM"; } }
  }
}
```

 The following file is the text template. It generates a line of text for each UML class in the model, and a line for each attribute in each class. Code for reading the model is embedded in the text, delimited by `<# ... #>`.

 To create this file, right-click the project in Solution Explorer, point to **Add**, and then click **New Item**. Select **Preprocessed Text Template**. The file name for this example should be **VdmGen.tt**. The **Custom Tool** property of the file should be **TextTemplatingFilePreprocessor**. For more information about preprocessed text templates, see [Run-Time Text Generation with T4 Text Templates](../modeling/run-time-text-generation-with-t4-text-templates.md).

```
<#@ import namespace="Microsoft.VisualStudio.Uml.Classes" #>
<#
   foreach (IClass classElement in store.AllInstances<IClass>())   {
#>
Type <#= classElement.Name #> ::
<#
     foreach (IProperty attribute in classElement.OwnedAttributes)     {
#>
       <#= attribute.Name #> : <#=
           attribute.Type == null ? ""
                                  : attribute.Type.Name #>
<#
     }   }
#>
```

 The text template generates a C# partial class, which becomes part of your [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project. In a separate file, add another partial declaration of the same class. This code provides the template with access to the UML model store:

```
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
namespace VdmGenerator
{
    public partial class VdmGen
    {
        private IModelStore store;
        public VdmGen(IModelStore s)
        { store = s; }
    }
}
```

 To test the project, press **F5**. A new instance of [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] will start. In this instance, open or create a UML model that contains a class diagram. Add some classes to the diagram, and add some attributes to each class. Right-click in the diagram and then click the example command `Generate VDM`. The command creates the file `C:\Generated.txt`. Inspect this file. Its contents should resemble the following text, but it will list your own classes and attributes:

```
Type Class1 ::
          Attribute1 : int
          Attribute2 : string
Type Class2 ::
          Attribute3 : string
```

## <a name="Application"></a> Generating Files from an Application
 You can generate files from an application that reads a UML model. For this purpose, the most flexible and robust method of accessing the model and its elements is [Visual Studio Modelbus](../modeling/integrate-uml-models-with-other-models-and-tools.md).

 You can also use the basic API to load the model, and pass the model to text templates using the same techniques as in the previous section. For more information about loading a model, see [Read a UML model in program code](../modeling/read-a-uml-model-in-program-code.md).

## <a name="Design"></a> Generating Files at Design Time
 If your project has a standard method of interpreting UML as code, you can create text templates that let you generate code within your project from a UML model. Typically you would have a solution that contains the UML model project, and one or more projects for the application code. Each code project could contain several templates that generate program code, resources, and configuration files, based on the content of the model. The developer can run all the templates by clicking the **Transform All Templates** in the Solution Explorer toolbar. Program code is usually generated in the form of partial classes, to make it easy to integrate manually-written parts.

 A [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] project of this kind can be distributed in the form of a template, so that every member of a team is able to create projects that generate code from a model in the same way. Typically, the template is part of an extension package that includes validation constraints on the model to ensure that the preconditions of the generation code are met.

### Outline procedure for generating files

- To add a template to a project, select **Text Template** in the Add New File dialog box. You can add a template to most types of project, but not modeling projects.

- The Custom Tools property of the template file should be **TextTemplatingFileGenerator**, and the file name extension should be .tt.

- The template should have at least an output directive:

     `<#@ output extension=".cs" #>`

     Set the extension field according to the language of your project.

- To allow the generating code in your template to access the model, write `<#@ assembly #>` directives for the assemblies needed to read a UML model. Use `ModelingProject.LoadReadOnly()` to open the model. For more information, see [Read a UML model in program code](../modeling/read-a-uml-model-in-program-code.md).

- The template is executed when you save it and when you click **Transform All Templates** in the Solution Explorer toolbar.

- For more information about this type of template, see [Design-Time Code Generation by using T4 Text Templates](../modeling/design-time-code-generation-by-using-t4-text-templates.md).

- In a typical project, you will have several templates that generate different files from the same model. The first part of every template will be the same. To reduce this duplication, move the common parts to a separate text file, and then invoke it by using the directive `<#@include file="common.txt"#>` in each template.

- You can also define a specialized directive processor that lets you provide parameters to the text generation process. For more information, see [Customizing T4 Text Transformation](../modeling/customizing-t4-text-transformation.md).

### Example
 This example generates a C# class for each UML class in the source model.

##### To set up a Visual Studio solution for this example

1. Create a UML class diagram in a modeling project in a new solution.

   1. In the **Architecture** menu, click **New Diagram**.

   2. Select **UML Class Diagram**.

   3. Follow the prompts to create a new solution and modeling project.

   4. Add some classes to the diagram by dragging the UML Class tool from the toolbox.

   5. Save the file.

2. Create a C# or Visual Basic project in the same solution.

   - In Solution Explorer, right-click the solution, point to **Add**, and then click **New Project**. Under **Installed Templates**, click **Visual Basic** or **Visual C#,** and then select a project type such as **Console Application**.

3. Add a plain text file to the C# or Visual Basic project. This file will contain code that is shared if you want to write several text templates.

   - In Solution Explorer, right-click the project, point to **Add**, and then click **New Item**. Select **Text File**.

     Insert the text that is shown in the following section.

4. Add a Text Template file to the C# or Visual Basic project.

   - In Solution Explorer, right-click the project, point to **Add**, and then click **New Item**. Select **Text Template**.

     Insert the code that follows into the text template file.

5. Save the text template file.

6. Inspect the code in the subsidiary file. It should contain a class for each UML class in the model.

   1. In a Visual Basic project, click **Show All Files** in the Solution Explorer toolbar.

   2. Expand the template file node in Solution Explorer.

#### Content of the shared text file
 In this example, the file is called SharedTemplateCode.txt, and it is in the same folder as the text templates.

```
<# /* Common material for inclusion in my model templates */ #>
<# /* hostspecific allows access to the Visual Studio API */ #>
<#@ template debug="false" hostspecific="true" language="C#" #>
<#@ assembly name="Microsoft.VisualStudio.Uml.Interfaces.dll"#>
<#@ assembly name="Microsoft.VisualStudio.ArchitectureTools.Extensibility.dll"#>
<#@ assembly name="EnvDTE" #>
<#@ import namespace="Microsoft.VisualStudio.Uml.Classes" #>
<#@ import namespace="Microsoft.VisualStudio.ArchitectureTools.Extensibility" #>
<#@ import namespace="Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml" #>
<#+  // Note this is a Class Feature Block
///<summary>
/// Text templates are run in a common AppDomain, so
/// we can cache the model store that we find.
///</summary>
private IModelStore StoreCache
{
  get { return AppDomain.CurrentDomain.GetData("ModelStore") as IModelStore; }
  set { AppDomain.CurrentDomain.SetData("ModelStore", value); }
}
private bool CacheIsOld()
{
    DateTime? dt = AppDomain.CurrentDomain
           .GetData("latestAccessTime") as DateTime?;
    DateTime t = dt.HasValue ? dt.Value : new DateTime();
    DateTime now = DateTime.Now;
    AppDomain.CurrentDomain.SetData("latestAccessTime", now);
    return now.Subtract(t).Seconds > 3;
}

///<summary>
/// Find the UML modeling project in this solution,
/// and load the model.
///</summary>
private IModelStore ModelStore
{
  get
  {
    // Avoid loading the model for every template:
    if (StoreCache == null || CacheIsOld())
    {
      // Use Visual Studio API to find modeling project:
      EnvDTE.DTE dte = (EnvDTE.DTE) ((IServiceProvider) this.Host)
                       .GetService(typeof(EnvDTE.DTE));
      EnvDTE.Project project = null;
      foreach (EnvDTE.Project p in dte.Solution.Projects)
      {
        if (p.FullName.EndsWith(".modelproj"))
        {
          project = p;
          break;
        }
      }
      if (project == null) return null;

      // Load UML model into this AppDomain
      // and access model store:
      IModelingProjectReader reader =
           ModelingProject.LoadReadOnly(project.FullName);
      StoreCache = reader.Store;
    }
    return StoreCache;
  }
}
#>
```

#### Content of the text template file
 The following text is placed in the **.tt** file. This example generates classes in a C# file from the UML classes in the model. However, you can generate files of any type. The language of the generated file is not related to the language in which the text template code is written.

```
<#@include file="SharedTemplateCode.txt"#>
<#@ output extension=".cs" #>
namespace Test{
<#
      foreach (IClass c in ModelStore.AllInstances<IClass>())
      {
#>
   public partial class <#=c.Name#>
   {   }
<#
      }
#>
}
```

## <a name="What"></a> How to Use Text Generation
 The real power of modeling is obtained when you use models to design at the level of requirements or architecture. You can use text templates to do some of the work of converting the high-level ideas into code. In many cases, this does not lead to a one-to-one correspondence between the elements in the UML models and classes or other parts of the program code.

 Furthermore, the transformation depends on your problem domain; there is no universal mapping between models and code.

 Here are some examples of generating code from models:

- **Product Lines**. Fabrikam, Inc. builds and installs airport baggage handling systems. Much of the software is very similar between one installation and the next, but the software configuration depends on what bag handling machinery is installed, and how these parts are interconnected by conveyor belts. At the beginning of a contract, Fabrikam's analysts discuss the requirements with the airport management, and capture the hardware plan using a UML activity diagram. From this model, the development team generates configuration files, program code, plans, and user documents. They complete the work by manual additions and adjustments to the code. As they gain experience from one job to the next, they extend the scope of the generated material.

- **Patterns**. The developers in Contoso, Ltd often build Web sites, and design the navigation scheme using UML class diagrams. Each Web page is represented by a class, and associations represent navigation links. The developers generate much of the code of a Web site from the model. Each Web page corresponds to several classes and resource file entries.  This method has the benefits that the construction of each page conforms to a single pattern, making it more reliable and flexible than hand-written code. The pattern is in the generating templates, while the model is used to capture the variable aspects.

- **Schemas**. Humongous Insurance has thousands of systems worldwide. These systems use different databases, languages, and interfaces. The central architecture team publishes internally models of business concepts and processes. From these models, local teams generate parts of their database and interchange schemas, declarations in program code, and so on. The graphical presentation of the models helps teams discuss proposals. The teams create multiple diagrams that show subsets of the model that apply to different business areas. They also use color to highlight areas subject to change.

## Important techniques for generating artifacts
 In the previous examples, models are used for diverse business-dependent purposes, and the interpretation of modeling elements such as classes and activities varies from one application to another. The following techniques are useful when you generate artifacts from models.

- **Profiles**. Even within one business area, the interpretation of an element type can vary. For example on a Web site diagram, some classes might represent Web pages, and others represent content blocks. To make it easy for the users to record these distinctions, define stereotypes. Stereotypes also make it possible to attach additional properties that apply to elements of that kind. Stereotypes are packaged within profiles. For more information, see [Define a profile to extend UML](../modeling/define-a-profile-to-extend-uml.md).

     In template code, it is easy to access the stereotypes that are defined on an object. For example:

    ```
    public bool HasStereotype(IClass c, string profile, string stereo)
    { return c.AppliedStereotypes.Any
       (s => s.Profile == profile && s.Name == stereo ); }
    ```

- **Constrained models**. Not all the models that you can create are valid for every purpose. For example, in Fabrikam's airport baggage models, it would be incorrect to have a check-in desk without an outgoing conveyor. You can define validation functions that help users to observe these constraints. For more information, see [Define validation constraints for UML models](../modeling/define-validation-constraints-for-uml-models.md).

- **Preserve manual changes**. Only some of the solution files can be generated from a model. In most cases, you need to be able to add or adjust the generated content by hand. However, it is important that these manual changes should be preserved when template transformation is run again.

     Where your templates generate code in [!INCLUDE[TLA2#tla_net](../includes/tla2sharptla-net-md.md)] languages, they should generate partial classes so that developers can add methods and code. It is also useful to generate each class as a pair: an abstract base class that contains the methods, and an inheriting class that contains only the constructor. This lets developers override the methods. To allow for initialization to be overridden, it is done in a separate method, instead of in the constructors.

     Where a template generates XML and other types of output, it can be more difficult to keep the manual content separate from the generated content. One method is to create a task in the build process that combines two files. Another method is for the developers to adjust a local copy of the generating template.

- **Move code into separate assemblies**. We do not recommend writing large bodies of code in templates. It is preferable to keep generated content separate from computation, and text templates are not well supported for editing code.

     Instead, if you have to perform substantial computations to generate text, build those functions in a separate assembly, and call its methods from the template.
