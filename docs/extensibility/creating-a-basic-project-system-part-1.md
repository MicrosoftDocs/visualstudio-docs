---
title: Creating a Basic Project System, Part 1
description: Create a basic project in Visual Studio to hold and organize source code files and other assets, and work with the project template and instance.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- writing a project system
- project system
- tutorial
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Create a basic project system, part 1

In Visual Studio, projects are the containers that developers use to organize source code files and other assets. Projects appear as children of solutions in the **Solution Explorer**. Projects let you organize, build, debug, and deploy source code and create references to Web services, databases, and other resources.

 Projects are defined in project files, for example a *.csproj* file for a Visual C# project. You can create your own project type that has your own project file name extension. For more information about project types, see [Project types](../extensibility/internals/project-types.md).

> [!NOTE]
> If you need to extend Visual Studio with a custom project type, we strongly recommend leveraging the [Visual Studio project system](https://github.com/Microsoft/VSProjectSystem) (VSPS) which has a number of advantages over building a project system from scratch:
>
> - Easier onboarding.  Even a basic project system requires tens of thousands of lines of code.  Leveraging VSPS reduces the onboarding cost to a few clicks before you are ready to customize it to your needs.
> - Easier maintenance.  By leveraging VSPS, you only need to maintain your own scenarios.  We handle the upkeep of all of the project system infrastructure.
>
>   If you need to target versions of Visual Studio older than Visual Studio 2013, you will not be able to leverage VSPS in a Visual Studio extension.  If that is the case, this walkthrough is a good place to get started.

 This walkthrough shows you how to create a project type that has the project file name extension *.myproj*. This walkthrough borrows from the existing Visual C# project system.

> [!NOTE]
> For more examples of extension projects, see [VSSDK samples](https://github.com/Microsoft/VSSDK-Extensibility-Samples).

 This walkthrough teaches how to accomplish these tasks:

- Create a basic project type.

- Create a basic project template.

- Register the project template with Visual Studio.

- Create a project instance by opening the **New Project** dialog box and then using your template.

- Create a project factory for your project system.

- Create a project node for your project system.

- Add custom icons for the project system.

- Implement basic template parameter substitution.

## Prerequisites

 Download the source code for the [Managed Package Framework for projects](https://github.com/tunnelvisionlabs/MPFProj10). Extract the file to a location that is accessible to the solution you are going to create.

## Create a basic project type
 Create a C# VSIX project named **SimpleProject**. (**File** > **New** > **Project** and then **Visual C#** > **Extensibility** > **VSIX Project**). Add a Visual Studio Package project item template (on the **Solution Explorer**, right-click the project node and select **Add** > **New Item**, then go to **Extensibility** > **Visual Studio Package**). Name the file *SimpleProjectPackage*.

## Creating a basic project template
 Now, you can modify this basic VSPackage to implement the new *.myproj* project type. To create a project that is based on the *.myproj* project type, Visual Studio has to know which files, resources, and references to add to the new project. To provide this information, put project files in a project template folder. When a user uses the *.myproj* project to create a project, the files are copied to the new project.

### To create a basic project template

1. Add three folders to the project, one under the other: *Templates\Projects\SimpleProject*. (In **Solution Explorer**, right-click the **SimpleProject** project node, point to **Add**, and then click **New Folder**. Name the folder *Templates*. In the *Templates* folder, add a folder named *Projects*. In the *Projects* folder, add a folder named *SimpleProject*.)

2. In the *Templates\Projects\SimpleProject* folder, add a Bitmap Image file to use as the icon named *SimpleProject.ico*. When you click **Add**, the icon editor opens.

3. Make the icon distinctive. This icon will appear in the **New Project** dialog box later in the walkthrough.

    ![Simple Project Icon](../extensibility/media/simpleprojicon.png "SimpleProjIcon")

4. Save the icon and close the icon editor.

5. In the *Templates\Projects\SimpleProject* folder, add a **Class** item named *Program.cs*.

6. Replace the existing code with the following lines.

   ```csharp
   using System;
   using System.Collections.Generic;
   using System.Text;

   namespace $nameSpace$
   {
       public class $className$
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Hello VSX!!!");
               Console.ReadKey();
           }
       }
   }
   ```

   > [!IMPORTANT]
   > This is not the final form of the *Program.cs* code; the replacement parameters will be dealt with in a later step. You may see compile errors, but as long as the file's **BuildAction** is **Content**, you should be able to build and run the project as usual.

7. Save the file.

8. Copy the *AssemblyInfo.cs* file from the *Properties* folder to the *Projects\SimpleProject* folder.

9. In the *Projects\SimpleProject* folder add an XML file named *SimpleProject.myproj*.

   > [!NOTE]
   > The file name extension for all projects of this type is *.myproj*. If you want to change it, you must change it everywhere it is mentioned in the walkthrough.

10. Replace the existing content with the following lines.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <Project DefaultTargets="Build" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
      <PropertyGroup>
        <Configuration Condition=" '$(Configuration)' == '' ">Debug</Configuration>
        <SchemaVersion>2.0</SchemaVersion>
        <ProjectGuid></ProjectGuid>
        <OutputType>Exe</OutputType>
        <RootNamespace>MyRootNamespace</RootNamespace>
        <AssemblyName>MyAssemblyName</AssemblyName>
        <EnableUnmanagedDebugging>false</EnableUnmanagedDebugging>
      </PropertyGroup>
      <PropertyGroup Condition=" '$(Configuration)' == 'Debug' ">
        <DebugSymbols>true</DebugSymbols>
        <OutputPath>bin\Debug\</OutputPath>
      </PropertyGroup>
      <PropertyGroup Condition=" '$(Configuration)' == 'Release' ">
        <DebugSymbols>false</DebugSymbols>
        <OutputPath>bin\Release\</OutputPath>
      </PropertyGroup>
      <ItemGroup>
        <Reference Include="mscorlib" />
        <Reference Include="System" />
        <Reference Include="System.Data" />
        <Reference Include="System.Xml" />
      </ItemGroup>
      <ItemGroup>
        <Compile Include="AssemblyInfo.cs">
          <SubType>Code</SubType>
        </Compile>
        <Compile Include="Program.cs">
          <SubType>Code</SubType>
        </Compile>
      </ItemGroup>
      <Import Project="$(MSBuildBinPath)\Microsoft.CSharp.targets" />
    </Project>
    ```

11. Save the file.

12. In the **Properties** window, set the **Build Action** of *AssemblyInfo.cs*, *Program.cs*, *SimpleProject.ico*, and *SimpleProject.myproj* to **Content**, and set their **Include in VSIX** properties to **True**.

    This project template describes a basic Visual C# project that has both a Debug configuration and a Release configuration. The project includes two source files, *AssemblyInfo.cs* and *Program.cs*, and several assembly references. When a project is created from the template, the ProjectGuid value is automatically replaced by a new GUID.

    In **Solution Explorer**, the expanded **Templates** folder should appear as follows:

```
Templates
   Projects
      SimpleProject
         AssemblyInfo.cs
         Program.cs
         SimpleProject.ico
         SimpleProject.myproj
```

## Create a basic project factory
 You must tell Visual Studio the location of your project template folder. To do this, add an attribute to the VSPackage class that implements the project factory so that the template location is written to the system registry when the VSPackage is built. Start by creating a basic project factory that is identified by a project factory GUID. Use the <xref:Microsoft.VisualStudio.Shell.ProvideProjectFactoryAttribute> attribute to connect the project factory to the `SimpleProjectPackage` class.

### To create a basic project factory

1. Create GUIDs for your project factory (on the **Tools** menu, click **Create GUID**), or use the one in the following example. Add the GUIDs to the `SimpleProjectPackage` class near the section with the already defined `PackageGuidString`. The GUIDs must be in both GUID form and string form. The resulting code should resemble the following example.

   ```csharp
       public sealed class SimpleProjectPackage : Package
       {
           ...
           public const string SimpleProjectPkgString = "96bf4c26-d94e-43bf-a56a-f8500b52bfad";
           public const string SimpleProjectFactoryString = "471EC4BB-E47E-4229-A789-D1F5F83B52D4";

           public static readonly Guid guidSimpleProjectFactory = new Guid(SimpleProjectFactoryString);
       }
   ```

2. Add a class to the top *SimpleProject* folder named *SimpleProjectFactory.cs*.

3. Add the following using directives:

   ```csharp
   using System.Runtime.InteropServices;
   using Microsoft.VisualStudio.Shell;
   ```

4. Add a GUID attribute to the `SimpleProjectFactory` class. The value of the attribute is the new project factory GUID.

   ```csharp
   [Guid(SimpleProjectPackage.SimpleProjectFactoryString)]
   class SimpleProjectFactory
   {
   }
   ```

   Now you can register your project template.

### To register the project template

1. In *SimpleProjectPackage.cs*, add a <xref:Microsoft.VisualStudio.Shell.ProvideProjectFactoryAttribute> attribute to the `SimpleProjectPackage` class, as follows.

   ```csharp
   [ProvideProjectFactory(    typeof(SimpleProjectFactory),     "Simple Project",
       "Simple Project Files (*.myproj);*.myproj", "myproj", "myproj",
       @"Templates\Projects\SimpleProject",     LanguageVsTemplate = "SimpleProject")]
   [Guid(SimpleProjectPackage.PackageGuidString)]
   public sealed class SimpleProjectPackage : Package
   ```

2. Rebuild the solution and verify that it builds without errors.

    Rebuilding registers the project template.

   The parameters `defaultProjectExtension` and `possibleProjectExtensions` are set to the project file name extension (*.myproj*). The `projectTemplatesDirectory` parameter is set to the relative path of the *Templates* folder. During the build, this path will be converted to a full build and added to the registry to register the project system.

## Test the template registration
 Template registration tells Visual Studio the location of your project template folder so that Visual Studio can display the template name and icon in the **New Project** dialog box.

### To test the template registration

1. Press **F5** to start debugging an experimental instance of Visual Studio.

2. In the experimental instance, create a new project of your newly-created project type. In the **New Project** dialog box, you should see **SimpleProject** under **Installed templates**.

   Now you have a project factory that is registered. However, it cannot yet create a project. The project package and project factory work together to create and initialize a project.

## Add the Managed Package Framework code
 Implement the connection between the project package and the project factory.

- Import the source-code files for the Managed Package Framework.

    1. Unload the SimpleProject project (in **Solution Explorer**, select the project node and on the context menu click **Unload Project**.) and open the project file in the XML editor.

    2. Add the following blocks to the project file (just above the \<Import> blocks). Set `ProjectBasePath` to the location of the *ProjectBase.files* file in the Managed Package Framework code you just downloaded. You might have to add a backslash to the pathname. If you do not, the project might fail to find the Managed Package Framework source code.

        ```
        <PropertyGroup>
             <ProjectBasePath>your path here\</ProjectBasePath>
             <RegisterWithCodebase>true</RegisterWithCodebase>
          </PropertyGroup>
          <Import Project="$(ProjectBasePath)\ProjectBase.Files" />
        ```

        > [!IMPORTANT]
        > Don't forget the backslash at the end of the path.

    3. Reload the project.

    4. Add references to the following assemblies:

        - `Microsoft.VisualStudio.Designer.Interfaces` (in *\<VSSDK install>\VisualStudioIntegration\Common\Assemblies\v2.0*)

        - `WindowsBase`

        - `Microsoft.Build.Tasks.v4.0`

### To initialize the project factory

1. In the *SimpleProjectPackage.cs* file, add the following `using` directive.

    ```csharp
    using Microsoft.VisualStudio.Project;
    ```

2. Derive the `SimpleProjectPackage` class from `Microsoft.VisualStudio.Package.ProjectPackage`.

    ```csharp
    public sealed class SimpleProjectPackage : ProjectPackage
    ```

3. Register the project factory. Add the following line to the `SimpleProjectPackage.Initialize` method, just after `base.Initialize`.

    ```csharp
    base.Initialize();
    this.RegisterProjectFactory(new SimpleProjectFactory(this));
    ```

4. Implement the abstract property `ProductUserContext`:

    ```csharp
    public override string ProductUserContext
        {
            get { return ""; }
    }
    ```

5. In *SimpleProjectFactory.cs*, add the following `using` directive after the existing `using` directives.

    ```csharp
    using Microsoft.VisualStudio.Project;
    ```

6. Derive the `SimpleProjectFactory` class from `ProjectFactory`.

    ```csharp
    class SimpleProjectFactory : ProjectFactory
    ```

7. Add the following dummy method to the `SimpleProjectFactory` class. You will implement this method in a later section.

    ```csharp
    protected override ProjectNode CreateProject()
    {
        return null;
    }
    ```

8. Add the following field and constructor to the `SimpleProjectFactory` class. This `SimpleProjectPackage` reference is cached in a private field so that it can be used in setting a service provider site.

    ```csharp
    private SimpleProjectPackage package;

    public SimpleProjectFactory(SimpleProjectPackage package)
        : base(package)
    {
        this.package = package;
    }
    ```

9. Rebuild the solution and verify that it builds without errors.

## Test the project factory implementation
 Test whether the constructor for your project factory implementation is called.

### To test the project factory implementation

1. In the *SimpleProjectFactory.cs* file, set a breakpoint on the following line in the `SimpleProjectFactory` constructor.

    ```csharp
    this.package = package;
    ```

2. Press **F5** to start an experimental instance of Visual Studio.

3. In the experimental instance, start to create a new project. In the **New Project** dialog box, select the **SimpleProject** project type and then click **OK**. Execution stops at the breakpoint.

4. Clear the breakpoint and stop debugging. Since we have not created a project node yet, the project creation code still throws exceptions.

## Extend the ProjectNode class
 Now you can implement the `SimpleProjectNode` class, which derives from the `ProjectNode` class. The `ProjectNode` base class handles the following tasks of project creation:

- Copies the project template file, *SimpleProject.myproj*, to the new project folder. The copy is renamed according to the name that is entered in the **New Project** dialog box. The `ProjectGuid` property value is replaced by a new GUID.

- Traverses the MSBuild elements of the project template file, *SimpleProject.myproj*, and looks for `Compile` elements. For each `Compile` target file, copies the file to the new project folder.

  The derived `SimpleProjectNode` class handles these tasks:

- Enables icons for project and file nodes in **Solution Explorer** to be created or selected.

- Enables additional project template parameter substitutions to be specified.

### To extend the ProjectNode class

1. Add a class named `SimpleProjectNode.cs`.

2. Replace the existing code with the following code.

   ```csharp
   using System;
   using System.Collections.Generic;
   using Microsoft.VisualStudio.Project;

   namespace SimpleProject
   {
       public class SimpleProjectNode : ProjectNode
       {
           private SimpleProjectPackage package;

           public SimpleProjectNode(SimpleProjectPackage package)
           {
               this.package = package;
           }
           public override Guid ProjectGuid
           {
               get { return SimpleProjectPackage.guidSimpleProjectFactory; }
           }
           public override string ProjectType
           {
               get { return "SimpleProjectType"; }
           }

           public override void AddFileFromTemplate(
               string source, string target)
           {
               this.FileTemplateProcessor.UntokenFile(source, target);
               this.FileTemplateProcessor.Reset();
           }
       }
   }
   ```

   This `SimpleProjectNode` class implementation has these overridden methods:

- `ProjectGuid`, which returns the project factory GUID.

- `ProjectType`, which returns the localized name of the project type.

- `AddFileFromTemplate`, which copies selected files from the template folder to the destination project. This method is further implemented in a later section.

  The `SimpleProjectNode` constructor, like the `SimpleProjectFactory` constructor, caches a `SimpleProjectPackage` reference in a private field for later use.

  To connect the `SimpleProjectFactory` class to the `SimpleProjectNode` class, you must instantiate a new `SimpleProjectNode` in the `SimpleProjectFactory.CreateProject` method and cache it in a private field for later use.

### To connect the project factory class and the node class

1. In the *SimpleProjectFactory.cs* file, add the following `using` directive:

    ```csharp
    using IOleServiceProvider =    Microsoft.VisualStudio.OLE.Interop.IServiceProvider;
    ```

2. Replace the `SimpleProjectFactory.CreateProject` method by using the following code.

    ```csharp
    protected override ProjectNode CreateProject()
    {
        SimpleProjectNode project = new SimpleProjectNode(this.package);

        project.SetSite((IOleServiceProvider)        ((IServiceProvider)this.package).GetService(            typeof(IOleServiceProvider)));
        return project;
    }
    ```

3. Rebuild the solution and verify that it builds without errors.

## Test the ProjectNode class
 Test your project factory to see whether it creates a project hierarchy.

### To test the ProjectNode class

1. Press **F5** to start debugging. In the experimental instance, create a new SimpleProject.

2. Visual Studio should call your project factory to create a project.

3. Close the experimental instance of Visual Studio.

## Add a custom project node icon
 The project node icon in the earlier section is a default icon. You can change it to a custom icon.

### To add a custom project node icon

1. In the **Resources** folder, add a bitmap file named *SimpleProjectNode.bmp*.

2. In the **Properties** windows, reduce the bitmap to 16 by 16 pixels. Make the bitmap distinctive.

    ![Simple Project Comm](../extensibility/media/simpleprojprojectcomm.png "SimpleProjProjectComm")

3. In the **Properties** window, change the **Build action** of the bitmap to **Embedded Resource**.

4. In *SimpleProjectNode.cs*, add the following `using` directives:

   ```csharp
   using System.Drawing;
   using System.Windows.Forms;
   ```

5. Add the following static field and constructor to the `SimpleProjectNode` class.

   ```csharp
   private static ImageList imageList;

   static SimpleProjectNode()
   {
       imageList =        Utilities.GetImageList(            typeof(SimpleProjectNode).Assembly.GetManifestResourceStream(                "SimpleProject.Resources.SimpleProjectNode.bmp"));
   }
   ```

6. Add the following property to the beginning of the `SimpleProjectNode` class.

   ```csharp
   internal static int imageIndex;
      public override int ImageIndex
      {
          get { return imageIndex; }
      }
   ```

7. Replace the instance constructor with the following code.

   ```csharp
   public SimpleProjectNode(SimpleProjectPackage package)
   {
       this.package = package;

       imageIndex = this.ImageHandler.ImageList.Images.Count;

       foreach (Image img in imageList.Images)
       {
           this.ImageHandler.AddImage(img);
       }
   }
   ```

   During static construction, `SimpleProjectNode` retrieves the project node bitmap from the assembly manifest resources and caches it in a private field for later use. Notice the syntax of the <xref:System.Reflection.Assembly.GetManifestResourceStream%2A> image path. To see the names of the manifest resources embedded in an assembly, use the <xref:System.Reflection.Assembly.GetManifestResourceNames%2A> method. When this method is applied to the `SimpleProject` assembly, the results should be as follows:

- *SimpleProject.Resources.resources*

- *VisualStudio.Project.resources*

- *SimpleProject.VSPackage.resources*

- *Resources.imagelis.bmp*

- *Microsoft.VisualStudio.Project.DontShowAgainDialog.resources*

- *Microsoft.VisualStudio.Project.SecurityWarningDialog.resources*

- *SimpleProject.Resources.SimpleProjectNode.bmp*

  During instance construction, the `ProjectNode` base class loads *Resources.imagelis.bmp*, in which are embedded commonly used 16 x 16 bitmaps from *Resources\imagelis.bmp*. This bitmap list is made available to `SimpleProjectNode` as `ImageHandler.ImageList`. `SimpleProjectNode` appends the project node bitmap to the list. The offset of the project node bitmap in the image list is cached for later use as the value of the public `ImageIndex` property. Visual Studio uses this property to determine which bitmap to display as the project node icon.

## Test the custom project node icon
 Test your project factory to see whether it creates a project hierarchy that has your custom project node icon.

### To test the custom project node icon

1. Start debugging, and in the experimental instance create a new SimpleProject.

2. In the newly-created project, notice that *SimpleProjectNode.bmp* is used as the project node icon.

     ![Simple Project New Project Node](../extensibility/media/simpleprojnewprojectnode.png "SimpleProjNewProjectNode")

3. Open *Program.cs* in the code editor. You should see source code that resembles the following code.

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace $nameSpace$
    {
        public class $className$
        {
            static void Main(string[] args)
            {
                Console.WriteLine("Hello VSX!!!");
                Console.ReadKey();
            }
        }
    }
    ```

     Notice that the template parameters $nameSpace$ and $className$ do not have new values. You will learn how to implement template parameter substitution in the next section.

## Substitute template parameters
 In an earlier section, you registered the project template with Visual Studio by using the `ProvideProjectFactory` attribute. Registering the path of a template folder in this manner lets you enable basic template parameter substitution by overriding and expanding the `ProjectNode.AddFileFromTemplate` class. For more information, see [New project generation: Under the hood, part two](../extensibility/internals/new-project-generation-under-the-hood-part-two.md).

 Now add replacement code to the `AddFileFromTemplate` class.

### To substitute template parameters

1. In the *SimpleProjectNode.cs* file, add the following `using` directive.

   ```csharp
   using System.IO;
   ```

2. Replace the `AddFileFromTemplate` method by using the following code.

   ```csharp
   public override void AddFileFromTemplate(
       string source, string target)
   {
       string nameSpace =
           this.FileTemplateProcessor.GetFileNamespace(target, this);
       string className = Path.GetFileNameWithoutExtension(target);

       this.FileTemplateProcessor.AddReplace("$nameSpace$", nameSpace);
       this.FileTemplateProcessor.AddReplace("$className$", className);

       this.FileTemplateProcessor.UntokenFile(source, target);
       this.FileTemplateProcessor.Reset();
   }
   ```

3. Set a breakpoint in the method, just after the `className` assignment statement.

   The assignment statements determine reasonable values for a namespace and a new class name. The two `ProjectNode.FileTemplateProcessor.AddReplace` method calls replace the corresponding template parameter values by using these new values.

## Test the template parameter substitution
 Now you can test template parameter substitution.

### To test the template parameter substitution

1. Start debugging, and in the experimental instance create a new SimpleProject.

2. Execution stops at the breakpoint in the `AddFileFromTemplate` method.

3. Examine the values for the `nameSpace` and `className` parameters.

   - `nameSpace` is given the value of the \<RootNamespace> element in the *\Templates\Projects\SimpleProject\SimpleProject.myproj* project template file. In this case, the value is `MyRootNamespace`.

   - `className` is given the value of the class source file name, without the file name extension. In this case, the first file to be copied to the destination folder is *AssemblyInfo.cs*; therefore, the value of className is `AssemblyInfo`.

4. Remove the breakpoint and press **F5** to continue execution.

    Visual Studio should finish creating a project.

5. Open *Program.cs* in the code editor. You should see source code that resembles the following code.

   ```csharp
   using System;
   using System.Collections.Generic;
   using System.Linq;
   using System.Text;

   namespace MyRootNamespace
   {
       public class Program
       {
           static void Main(string[] args)
           {
               Console.WriteLine("Hello VSX!!!");
               Console.ReadKey();
           }
       }
   }
   ```

    Notice that the namespace is now `MyRootNamespace` and the class name is now `Program`.

6. Start debugging the project. The new project should compile, run, and display "Hello VSX!!!" in the console window.

    ![Simple Project Command](../extensibility/media/simpleprojcommand.png "SimpleProjCommand")

   Congratulations! You have implemented a basic managed project system.
