---
title: Test a custom task | Microsoft Docs
description: Learn how to test an MSBuild custom task
ms.date: 03/17/2022
ms.topic: tutorial
helpviewer_keywords:
- MSBuild, test custom task
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Tutorial: Test a custom task

You can use unit testing functionality in Visual Studio to test an MSBuild custom task before distribution to ensure the correctness of the code. For information about the benefits of doing tests and basic test tooling, see [basics about unit tests](../test/walkthrough-creating-and-running-unit-tests-for-managed-code.md). In this tutorial, you use the code examples used in other MSBuild custom task tutorials. The following projects used in those tutorials are available in GitHub and include unit and integration tests for MSBuild custom tasks:

1. [Custom Task](tutorial-custom-task-code-generation.md)
1. [Code Generation](tutorial-rest-api-client-msbuild.md)

## Unit Test

A MSBuild custom task is a class which inherits from <xref:Microsoft.Build.Utilities.Task> (directly or indirectly, because <xref:Microsoft.Build.Utilities.ToolTask> inherits from <xref:Microsoft.Build.Utilities.Task>). The method which performs the actions associated with the task is `Execute()`. This method takes some input values (parameters), and has output parameters which you can use assert to test validity. In this case, some input parameters are paths to files, so this examples has test input files in a folder called *Resources*. This MSBuild task also generates files, so the test asserts the generated files.

A build engine is needed, which a class which implements [IBuildEngine](/dotnet/api/microsoft.build.framework.ibuildengine). In this example there is a mock using [Moq](https://github.com/Moq/moq4/wiki/Quickstart), but you can use other mock tools. The example collects the errors, but you can collect other information and then assert it.

The Engine mock is needed on all the tests, so it's included as `TestInitialize` (it is executed before each test, and each test has own build engine). 

For the complete code, see[AppSettingStronglyTypedTest.cs](https://github.com/dotnet/samples/blob/main/msbuild/custom-task-code-generation/AppSettingStronglyTyped/AppSettingStronglyTyped.Test/AppSettingStronglyTypedTest.cs) in the .NET samples repo  on GitHub.

```csharp
       private Mock<IBuildEngine> buildEngine;
       private List<BuildErrorEventArgs> errors;

        [TestInitialize()]
        public void Startup()
        {
            buildEngine = new Mock<IBuildEngine>();
            errors = new List<BuildErrorEventArgs>();
            buildEngine.Setup(x => x.LogErrorEvent(It.IsAny<BuildErrorEventArgs>())).Callback<BuildErrorEventArgs>(e => errors.Add(e));
        }

```

The code creates the task and set the parameters as part of the test arrangement:

```csharp
   //Arrange
   var item = new Mock<ITaskItem>();
   item.Setup(x => x.GetMetadata("Identity")).Returns($".\\Resources\\complete-prop.setting");

   var appSettingStronglyTyped = new AppSettingStronglyTyped { SettingClassName = "MyCompletePropSetting", SettingNamespaceName = "MyNamespace", SettingFiles = new[] { item.Object } };

   appSettingStronglyTyped.BuildEngine = buildEngine.Object;
```

First, it creates the <xref:Microsoft.Build.Framework.ITaskItem> parameter mock (using [Moq](https://github.com/Moq/moq4/wiki/Quickstart)), and point to the file to be parsed. Then, it creates the `AppSettingStronglyTyped` custom task with its parameters. Finally, set the build engine to our MSBuild custom task:

At this point it needs to execute the task code to perform the actual task action:

```csharp
    //Act
    var success = appSettingStronglyTyped.Execute();
```

Finally, it needs to assert the expected outcome from the test:

```csharp
   //Assert
   Assert.IsTrue(success); // The execution was success
   Assert.AreEqual(errors.Count, 0); //Not error were found
   Assert.AreEqual($"MyCompletePropSetting.generated.cs", appSettingStronglyTyped.ClassNameFile); // The Task expected output
   Assert.AreEqual(true, File.Exists(appSettingStronglyTyped.ClassNameFile)); // The file was generated
   Assert.IsTrue(File.ReadLines(appSettingStronglyTyped.ClassNameFile).SequenceEqual(File.ReadLines(".\\Resources\\complete-prop-class.txt"))); // Assenting the file content
```

The other tests follow this pattern and expand all the possibilities.

> [!NOTE] 
> When there are files generated, you need to use different file name for each test to avoid collision. Remember to delete the generated files as test cleanup.

## Integration tests

Unit tests are important, but you also need to test the custom MSBuild task in a realistic build context.

[System.Diagnostics.Process Class](/dotnet/api/system.diagnostics.process) provides access to local and remote processes and enables you to start and stop local system processes. This example runs a build on a unit test using test MSBuild files.

The test code needs to initialize the execution context for each test. Pay attention to ensure the path to the `dotnet` command is accurate for your environment. The complete example is [here](https://github.com/dotnet/samples/blob/main/msbuild/custom-task-code-generation/AppSettingStronglyTyped/AppSettingStronglyTyped.Test/AppSettingStronglyTypedIntegrationTest.cs).

```csharp
        public const string MSBUILD = "C:\\Program Files\\dotnet\\dotnet.exe";

        private Process buildProcess;
        private List<string> output;

        [TestInitialize()]
        public void Startup()
        {
            output = new List<string>();
            buildProcess = new Process();
            buildProcess.StartInfo.FileName = MSBUILD;
            buildProcess.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
            buildProcess.StartInfo.CreateNoWindow = true;
            buildProcess.StartInfo.RedirectStandardOutput = true;
        }
```

On cleanup, the test needs to finish the process:

```csharp
       [TestCleanup()]
        public void Cleanup()
        {
            buildProcess.Close();
        }
```

Now, create each test. Each test will need its own MSBuild file definition to be executed. For example [testscript-success.msbuild](https://github.com/dotnet/samples/blob/main/msbuild/custom-task-code-generation/AppSettingStronglyTyped/AppSettingStronglyTyped.Test/Resources/testscript-success.msbuild). For understanding the file please read [Tutorial: Crete a custom task](tutorial-custom-task-code-generation.md).

```xml
<Project Sdk="Microsoft.NET.Sdk">
    <UsingTask TaskName="AppSettingStronglyTyped.AppSettingStronglyTyped" AssemblyFile="..\AppSettingStronglyTyped.dll" />
    <PropertyGroup>
        <TargetFramework>netstandard2.1</TargetFramework>
    </PropertyGroup>

    <PropertyGroup>
        <SettingClass>MySettingSuccess</SettingClass>
        <SettingNamespace>example</SettingNamespace>
    </PropertyGroup>

    <ItemGroup>
        <SettingFiles Include="complete-prop.setting" />
    </ItemGroup>

    <Target Name="generateSettingClass">
        <AppSettingStronglyTyped SettingClassName="$(SettingClass)" SettingNamespaceName="$(SettingNamespace)" SettingFiles="@(SettingFiles)">
            <Output TaskParameter="ClassNameFile" PropertyName="SettingClassFileName" />
        </AppSettingStronglyTyped>
    </Target>
</Project>
```

The test arrangement is the indication to build this MSBuild file.

```csharp
 //Arrage
 buildProcess.StartInfo.Arguments = "build .\\Resources\\testscript-success.msbuild /t:generateSettingClass";
```

Execute and get the output:

```csharp
 //Act
  ExecuteCommandAndCollectResults();
```

Where `ExecuteCommandAndCollectResults()` is defined as:

```csharp
    private void ExecuteCommandAndCollectResults()
    {
        buildProcess.Start();
        while (!buildProcess.StandardOutput.EndOfStream)
        {
            output.Add(buildProcess.StandardOutput.ReadLine() ?? string.Empty);
        }
        buildProcess.WaitForExit();
    }
```

Finally, assess the expected result:

```csharp
  //Assert
  Assert.AreEqual(0, buildProcess.ExitCode); //Finished success
  Assert.IsTrue(File.Exists(".\\Resources\\MySettingSuccess.generated.cs")); // the expected resource was generated
  Assert.IsTrue(File.ReadLines(".\\Resources\\MySettingSuccess.generated.cs").SequenceEqual(File.ReadLines(".\\Resources\\testscript-success-class.txt"))); // asserting the file content
```

## Conclusion

Unit testing is useful because you can test and debug the code to ensure correctness of each specific piece of code, but having some integration test is important to ensure the task executes in a realistic build context. In this tutorial you learned how to test an MSBuild custom task.
