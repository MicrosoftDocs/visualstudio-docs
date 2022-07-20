---
title: 'How to: Specify build events (C#)'
description: Learn how to use build events to specify commands that run before the build starts or after the build finishes.
ms.custom: SEO-VS-2020
ms.date: 03/04/2022
ms.technology: vs-ide-compile
ms.topic: how-to
helpviewer_keywords:
- pre-build events
- events [Visual Studio], builds
- post-build events
- build events [Visual Studio]
- builds [Visual Studio], events
ms.assetid: b4ce1ad9-5215-4b6f-b6a2-798b249aa335
author: ghogen
ms.author: ghogen
manager: jmartens
ms.workload:
- dotnet
---
# How to: Specify build events (C#)

 [!INCLUDE [Visual Studio](~/includes/applies-to-version/vs-windows-only.md)]

Use build events to specify commands that run before the build starts or after the build finishes.

When a project is built, pre-build events are added to a file named *PreBuildEvent.bat* and post-build events are added to a file named *PostBuildEvent.bat*. If you want to ensure error checking, add your own error-checking commands to the build steps.

## Specify a build event

:::moniker range="<=vs-2019"

1. In **Solution Explorer**, select the project for which you want to specify the build event.

2. On the **Project** menu, click **Properties**.

3. Select the **Build Events** tab.

4. In the **Pre-build event command line** box, specify the syntax of the build event.

   > [!NOTE]
   > Pre-build events do not run if the project is up to date and no build is triggered.

5. In the **Post-build event command line** box, specify the syntax of the build event.

   > [!NOTE]
   > Add a `call` statement before all post-build commands that run *.bat* files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

6. In the **Run the post-build event** box, specify under what conditions to run the post-build event.

   > [!NOTE]
   > To add lengthy syntax, or to select any build macros from the [Pre-build event/post-build event command line dialog box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md), click the ellipsis button (**...**) to display an edit box.

:::moniker-end
:::moniker range=">=vs-2022"

1. In **Solution Explorer**, select the project for which you want to specify the build event.

2. On the **Project** menu, click **Properties** (or from **Solution Explorer**, press **Alt**+**Enter**).

3. Select **Build > Events**.

   ![Screenshot showing the Build Events settings.](media/vs-2022/build-events.png)

4. In the **Pre-build event** section, specify the syntax of the build event.

   > [!NOTE]
   > Pre-build events do not run if the project is up to date and no build is triggered.

5. In the **Post-build event** section, specify the syntax of the build event.

   > [!NOTE]
   > Add a `call` statement before all post-build commands that run *.bat* files. For example, `call C:\MyFile.bat` or `call C:\MyFile.bat call C:\MyFile2.bat`.

6. In the **When to run the post-build event** section, specify under what conditions to run the post-build event.

:::moniker-end

The build event syntax can include any command that is valid at a command prompt or in a *.bat* file. The name of a batch file should be preceded by `call` to ensure that all subsequent commands are executed.

> [!NOTE]
> If your pre-build or post-build event does not complete successfully, you can terminate the build by having your event action exit with a code other than zero (0), which indicates a successful action.

## Macros

Commonly available "macros" (actually MSBuild properties) are listed at [MSBuild common properties](../msbuild/common-msbuild-project-properties.md). For .NET SDK projects (.NET Core or .NET 5 and later), additional properties are listed at [MSBuild properties for Microsoft.NET.Sdk](/dotnet/core/project-sdk/msbuild-props).

In your scripts for build events, you might want to reference the values of some project-level variables such as the name of the project or the location of the output folder. In prior versions of Visual Studio, these were called *macros*. The equivalent to macros in recent versions of Visual Studio are MSBuild properties. MSBuild is the build engine that Visual Studio uses to process your project file when it performs a build. A build event in the IDE results in an MSBuild [target](../msbuild/msbuild-targets.md) in the project file. You can use any MSBuild property that is available in the target in your project file (for example, `$(OutDir)` or `$(Configuration)`) . The MSBuild properties that are available to you in these events depend on the files implicitly or explicitly imported in a project file, such `.props` and `.targets` files, and properties set in your project file, such as in `PropertyGroup` elements. Be careful to use the exact spelling of each property. No error is reported if you misspell a property; instead, an undefined property evaluates to an empty string.

For example, suppose you specify a pre-build event as follows:

![Screenshot showing pre-build event example.](./media/vs-2022/pre-build-event-example.png)

That pre-build event results in the following entry, called a `Target` in your project file:

```xml
  <Target Name="PreBuild" BeforeTargets="PreBuildEvent">
    <Exec Command="echo Configuration: $(Configuration)&#xD;&#xA;echo DevEnvDir: $(DevEnvDir)&#xD;&#xA;echo OutDir: $(OutDir)&#xD;&#xA;echo ProjectDir: $(ProjectDir)&#xD;&#xA;echo VisualStudioVersion: $(VisualStudioVersion)&#xD;&#xA;echo AssemblySearchPaths: $(AssemblySearchPaths)&#xD;&#xA;echo AssemblyName: $(AssemblyName)&#xD;&#xA;echo BaseIntermediateOutputPath: $(BaseIntermediateOutputPath)&#xD;&#xA;echo CscToolPath: $(CscToolPath)" />
  </Target>
```

The build event appears as a target that includes the [Exec task](../msbuild/exec-task.md) with the input you specified as the `Command`. Newlines are encoded in the XML.

When you build the project in this example, the pre-build event prints the values of some properties. In this example, `$(CscToolPath)` doesn't produce any output, because it's not defined. It is an optional property that you can define in your project file to give the path to a customized instance of the C# compiler (for example, if you were testing a different version of *csc.exe*, or an experimental compiler).

Output from your build events is written to the build output, which can be found in the **Output** window. In the **Show output from** dropdown, choose **Build**.

```output
Build started...
1>------ Build started: Project: ConsoleApp4, Configuration: Debug Any CPU ------
1>You are using a preview version of .NET. See: https://aka.ms/dotnet-core-preview
1>Configuration: Debug
1>DevEnvDir: C:\Program Files\Microsoft Visual Studio\2022\Preview\Common7\IDE\
1>OutDir: bin\Debug\net6.0\
1>ProjectDir: C:\source\repos\ConsoleApp4\ConsoleApp4\
1>VisualStudioVersion: 17.0
1>ALToolsPath:
1>AssemblySearchPaths: {CandidateAssemblyFiles};{HintPathFromItem};{TargetFrameworkDirectory};{RawFileName}
1>AssemblyName: ConsoleApp4
1>BaseIntermediateOutputPath: obj\
1>CscToolsPath:
1>Skipping analyzers to speed up the build. You can execute 'Build' or 'Rebuild' command to run analyzers.
1>ConsoleApp4 -> C:\Users\ghogen\source\repos\ConsoleApp4\ConsoleApp4\bin\Debug\net6.0\ConsoleApp4.dll
```

## Example

The following procedure shows how to set the minimum operating system version in the application manifest by using an *.exe* command that is called from a post-build event (the *.exe.manifest* file in the project directory). The minimum operating system version is a four-part number such as 4.10.0.0. To set the minimum operating system version, the command will change the `<dependentOS>` section of the manifest:

```xml
<dependentOS>
   <osVersionInfo>
      <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
   </osVersionInfo>
</dependentOS>
```

### Create an .exe command to change the application manifest

1. Create a new **Console App** project for the command. Name the project **ChangeOSVersionCS**.

2. In *Program.cs*, add the following line to the other `using` directives at the top of the file:

   ```csharp
   using System.Xml;
   ```

3. In the `ChangeOSVersionCS` namespace, replace the `Program` class implementation with the following code:

   ```csharp
   class Program
   {
      /// <summary>
      /// This function sets the minimum operating system version for a ClickOnce application.
      /// </summary>
      /// <param name="args">
      /// Command Line Arguments:
      /// 0 - Path to application manifest (.exe.manifest)
      /// 1 - Version of OS
      ///</param>
      static void Main(string[] args)
      {
         string applicationManifestPath = args[0];
         Console.WriteLine("Application Manifest Path: " + applicationManifestPath);

         // Get version name.
         Version osVersion = null;
         if (args.Length >=2 ){
            osVersion = new Version(args[1]);
         }else{
            throw new ArgumentException("OS Version not specified.");
         }
         Console.WriteLine("Desired OS Version: " + osVersion.ToString());

         XmlDocument document;
         XmlNamespaceManager namespaceManager;
         namespaceManager = new XmlNamespaceManager(new NameTable());
         namespaceManager.AddNamespace("asmv1", "urn:schemas-microsoft-com:asm.v1");
         namespaceManager.AddNamespace("asmv2", "urn:schemas-microsoft-com:asm.v2");

         document = new XmlDocument();
         document.Load(applicationManifestPath);

         string baseXPath;
         baseXPath = "/asmv1:assembly/asmv2:dependency/asmv2:dependentOS/asmv2:osVersionInfo/asmv2:os";

         // Change minimum required operating system version.
         XmlNode node;
         node = document.SelectSingleNode(baseXPath, namespaceManager);
         node.Attributes["majorVersion"].Value = osVersion.Major.ToString();
         node.Attributes["minorVersion"].Value = osVersion.Minor.ToString();
         node.Attributes["buildNumber"].Value = osVersion.Build.ToString();
         node.Attributes["servicePackMajor"].Value = osVersion.Revision.ToString();

         document.Save(applicationManifestPath);
      }
   }
   ```

   The command takes two arguments: the path of the application manifest (that is, the folder in which the build process creates the manifest, typically *Projectname.publish*), and the new operating system version.

4. Build the project.

5. Copy the *.exe* file to a directory such as *C:\TEMP\ChangeOSVersionVB.exe*.

Next, invoke this command in a post-build event to modify the application manifest.

### Invoke a post-build event to modify the application manifest

1. Create a new **Windows Forms App** project and name it **CSWinApp**.

2. With the project selected in **Solution Explorer**, on the **Project** menu, choose **Properties**.

3. In the **Project Designer**, locate the **Publish** page and set **Publishing location** to *C:\TEMP*.

4. Publish the project by clicking **Publish Now**.

   The manifest file is built and saved to *C:\TEMP\CSWinApp_1_0_0_0\CSWinApp.exe.manifest*. To view the manifest, right-click the file, click **Open with**, select **Select the program from a list**, and then click **Notepad**.

   Search in the file for the `<osVersionInfo>` element. For example, the version might be:

   ```xml
   <os majorVersion="4" minorVersion="10" buildNumber="0" servicePackMajor="0" />
   ```

5. Back in the **Project Designer**, click the **Build Events** tab.

6. In the **Post-build event** section, enter the following command:

   `C:\TEMP\ChangeOSVersionCS.exe "$(TargetPath).manifest" 5.1.2600.0`

   When you build the project, this command changes the minimum operating system version in the application manifest to 5.1.2600.0.

   Because the `$(TargetPath)` macro expresses the full path for the executable being created, `$(TargetPath).manifest` specifies the application manifest created in the *bin* directory. Publishing copies this manifest to the publishing location that you set earlier.

7. Publish the project again.

   The manifest version should now read:

   ```xml
   <os majorVersion="5" minorVersion="1" buildNumber="2600" servicePackMajor="0" />
   ```

> [!NOTE]
> Some scenarios may require more intelligent build actions than the build events are capable of. For example, for many common code-generation scenarios, you need to handle clean and rebuild operations, and you might want to enable incremental build for code-generation steps, so that the step only runs if the output is out-of-date with respect to the inputs. For such scenarios, consider creating a [custom target](../msbuild/target-build-order.md) that specifies `AfterTargets` or `BeforeTargets` to run during a specific point in the build process, and for further control in advanced scenarios, consider creating a [custom task](../msbuild/task-writing.md).

## See also

- [Build Events page, Project Designer (C#)](../ide/reference/build-events-page-project-designer-csharp.md)
- [Pre-build event/Post-build event command line dialog box](../ide/reference/pre-build-event-post-build-event-command-line-dialog-box.md)
- [How to: Specify build events (Visual Basic)](../ide/how-to-specify-build-events-visual-basic.md)
- [Compile and build](../ide/compiling-and-building-in-visual-studio.md)
