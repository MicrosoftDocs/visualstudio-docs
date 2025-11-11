---
title: Handle code generation in a build
description: Edit an MSBuild project file to handle code generation such as REST API client generation, either by using the Exec task to run a tool, or by creating a custom task.
ms.date: 03/07/2022
ms.topic: tutorial
helpviewer_keywords:
- MSBuild, tutorial
- MSBuild, code generation
author: ghogen
ms.author: ghogen
manager: mijacobs
ms.subservice: msbuild
---
# Tutorial: Generate a REST API client

An application which consumes a REST API is a very common scenario. Usually, you need to generate client code that your application can use to call the REST API. In this tutorial, you'll learn how to generate the REST API client automatically during build process using MSBuild. You'll use [NSwag](/aspnet/core/tutorials/getting-started-with-nswag?tabs=visual-studio), a tool that generates client code for a REST API.

The complete sample code is available at [REST API client generation](https://github.com/dotnet/samples/tree/main/msbuild/rest-api-client-generation) in the .NET samples repo on GitHub.

The example shows a console app that consumes the public [Pet Store API](https://petstore.swagger.io), which publishes an [OpenAPI spec](https://petstore.swagger.io/v2/swagger.json).

The tutorial assumes basic knowledge of MSBuild terms such as tasks, targets, properties, or runtimes; for the necessary background, see [MSBuild Concepts article](msbuild-concepts.md).

When you want to run a command-line tool as part of a build, there are two approaches to consider. One is to use the MSBuild [Exec task](exec-task.md), which lets you run a command-line tool and specify its parameters. The other method is to create a custom task derived from [ToolTask](xref:Microsoft.Build.Utilities.ToolTask), which gives you greater control.

## Prerequisites

You should have an understanding of MSBuild concepts such as tasks, targets, and properties. See [MSBuild concepts](msbuild-concepts.md).

The examples require MSBuild, which is installed with Visual Studio, but can also be installed separately. See [Download MSBuild without Visual Studio](https://visualstudio.microsoft.com/downloads/#build-tools-for-visual-studio-2022).

## Option 1: Exec task

The [Exec task](/dotnet/api/microsoft.build.tasks.exec) simply invokes the specified process with the specified arguments, waits for it to complete, and then returns `true` if the process completes successfully, and `false` if an error occurs.

NSwag code generation can be used from MSBuild; see [NSwag.MSBuild](https://github.com/RicoSuter/NSwag/wiki/NSwag.MSBuild).

The complete code is in the *PetReaderExecTaskExample* folder; you can download and take a look. In this tutorial, you'll go through step by step and learn the concepts on the way.

1. Create a new console application named `PetReaderExecTaskExample`. Use .NET 6.0 or later.

1. Create another project in the same solution: `PetShopRestClient` (This solution is going to contain the generated client as a library). For this project, use .NET Standard 2.1. The generated client doesn't compile on .NET Standard 2.0.

1. In the `PetReaderExecTaskExample` project, and add a project dependency to `PetShopRestClient` project.

1. In the `PetShopRestClient` project, include the following NuGet packages:

   - Nswag.MSBuild, which allows access to the code generator from MSBuild
   - Newtonsoft.Json, needed to compile the generated client
   - System.ComponentModel.Annotations, needed to compile the generated client

1. In the `PetShopRestClient` project, add a folder (named `PetShopRestClient`) for the code generation and delete the *Class1.cs* that was automatically generated.

1. Create a text file named *petshop-openapi-spec.json* at the root of the project. Copy the OpenAPI spec from [here](https://petstore.swagger.io/v2/swagger.json) and save it in the file. It's best to copy a snapshot of the spec instead of reading it online during the build. You always want a consistently reproducible build that depends only on the input. Consuming the API directly could transform a build which works today to a build which fails tomorrow from the same source. The snapshot saved on *petshop-openapi-spec.json* will allow us to still have a version that builds even if the spec changes.

1. Next, modify PetShopRestClient.csproj and add a [MSBuild targets](msbuild-targets.md) to generate the client during build process.

   First, add some properties useful for client generation:

   ```xml
    <PropertyGroup>
        <PetOpenApiSpecLocation>petshop-openapi-spec.json</PetOpenApiSpecLocation>
        <PetClientClassName>PetShopRestClient</PetClientClassName>
        <PetClientNamespace>PetShopRestClient</PetClientNamespace>
        <PetClientOutputDirectory>PetShopRestClient</PetClientOutputDirectory>
    </PropertyGroup>
   ```

   Add the following targets:

   ```xml
    <Target Name="generatePetClient" BeforeTargets="CoreCompile" Inputs="$(PetOpenApiSpecLocation)" Outputs="$(PetClientOutputDirectory)\$(PetClientClassName).cs">
        <Exec Command="$(NSwagExe) openapi2csclient /input:$(PetOpenApiSpecLocation)  /classname:$(PetClientClassName) /namespace:$(PetClientNamespace) /output:$(PetClientOutputDirectory)\$(PetClientClassName).cs" ConsoleToMSBuild="true">
        <Output TaskParameter="ConsoleOutput" PropertyName="OutputOfExec" />
      </Exec>
    </Target>
    <Target Name="forceReGenerationOnRebuild" AfterTargets="CoreClean">
       <Delete Files="$(PetClientOutputDirectory)\$(PetClientClassName).cs"></Delete>
    </Target>
   ```

   Notice that this target uses the attributes [BeforeTarget and AfterTarget](target-build-order.md#beforetargets-and-aftertargets) as way to define build order. The first target called `generatePetClient` will be executed before the core compilation target, so the source will be created before the compiler executes. The input and output parameter are related to [Incremental Build](how-to-build-incrementally.md). MSBuild can compare the timestamps of the input files with the timestamps of the output files and determine whether to skip, build, or partially rebuild a target.

   After installing the `NSwag.MSBuild` NuGet package in your project, you can use the variable `$(NSwagExe)` in your `.csproj` file to run the NSwag command-line tool in an MSBuild target. This way, the tools can easily be updated via NuGet. Here, you're using the `Exec` MSBuild task to execute the NSwag program with the required parameters to generate the client Rest Api. See [NSwag command and parameters](https://github.com/RicoSuter/NSwag/wiki/NSwag.MSBuild).

   You can capture output from `<Exec>` adding `ConsoleToMsBuild="true"` to your `<Exec>` tag and then capturing the output using the `ConsoleOutput` parameter in an `<Output>` tag. `ConsoleOutput` returns the output as an `Item`. Whitespace is trimmed. `ConsoleOutput` is enabled when `ConsoleToMSBuild` is true.

   The second target called `forceReGenerationOnRebuild` deletes the generated class during cleanup to force the regeneration of the generated code during rebuild target execution. This target runs after the `CoreClean` MSBuild predefined target.

1. Execute a Visual Studio Solution rebuild and see the client generated on the `PetShopRestClient` folder.

1. Now, use the generated client. Go to the client *Program.cs*, and copy the following code:

   ```csharp
   using System;
   using System.Net.Http;

   namespace PetReaderExecTaskExample
   {
      internal class Program
      {
          private const string baseUrl = "https://petstore.swagger.io/v2";
          static void Main(string[] args)
          {
              HttpClient httpClient = new HttpClient();
              httpClient.BaseAddress = new Uri(baseUrl);
              var petClient = new PetShopRestClient.PetShopRestClient(httpClient);
              var pet = petClient.GetPetByIdAsync(1).Result;
              Console.WriteLine($"Id: {pet.Id} Name: {pet.Name} Status: {pet.Status} CategoryName: {pet.Category.Name}");
          }
      }
   }
   ```

   >[!NOTE]
   > This code uses `new HttpClient()` because it's simple to demonstrate, but it is not the best practice for real-world code. The best practice is to use `HttpClientFactory` to create an `HttpClient` object which addresses the known issues of `HttpClient` request like Resource Exhaustion or Stale DNS problems. See [Use IHttpClientFactory to implement resilient HTTP requests](/dotnet/architecture/microservices/implement-resilient-applications/use-httpclientfactory-to-implement-resilient-http-requests).

Congratulations! Now, you can execute the program to see how it works.

## Option 2: Custom task derived from ToolTask

In many cases, using the `Exec` task is good enough to execute an external tool to do something like REST API client code generation, but what if you want to allow REST API client code generation if and only if you don't use an absolute Windows path as input? Or what if you need to calculate in some way where the executable is? When there's any situation where you need to execute some code to do extra work, the [MSBuild Tool Task](/dotnet/api/microsoft.build.utilities.tooltask) is the best solution. The `ToolTask` class is an abstract class derived from MSBuild `Task`. You can define a concrete subclass, which creates a custom MSBuild task. This approach lets you run any code that is needed to prepare for command execution. You should read the tutorial [Create a custom task for code generation](tutorial-custom-task-code-generation.md) first.

You'll create a custom task derived from [MSBuild ToolTask](/dotnet/api/microsoft.build.utilities.tooltask) which will generate a REST API client, but it will be designed to emit an error if you try to reference the OpenAPI spec using an http address. NSwag supports an http address as OpenAPI spec input, but for the purposes of this example, let's suppose there's a design requirement to disallow that.

The complete code is in this `PetReaderToolTaskExample` folder; you can download and take a look. In this tutorial, you'll go through step by step and learn some concepts that you can apply to your own scenarios.

1. Create a new Visual Studio Project for the custom task. Call it `RestApiClientGenerator` and use the **Class Library (C#)** template with .NET Standard 2.0. Name the solution `PetReaderToolTaskExample`.

1. Delete *Class1.cs*, which was automatically generated.

1. Add the `Microsoft.Build.Utilities.Core` NuGet packages:

   - Create a class called `RestApiClientGenerator`
   - Inherit from MSBuild `ToolTask` and implement the abstract method as shown in the following code:

     ```csharp
     using Microsoft.Build.Utilities;

     namespace RestApiClientGenerator
     {
         public class RestApiClientGenerator : ToolTask
         {
             protected override string ToolName => throw new System.NotImplementedException();
 
             protected override string GenerateFullPathToTool()
             {
                 throw new System.NotImplementedException();
             }
         }
     }
     ```

1. Add the following parameters:

   - InputOpenApiSpec, where the spec is
   - ClientClassName, name of the generated class
   - ClientNamespaceName, namespace where the class is generated
   - FolderClientClass, path to the folder where the class will be located
   - NSwagCommandFullPath, full path to the directory where NSwag.exe is located

   ```csharp
        [Required]
        public string InputOpenApiSpec { get; set; }
        [Required]
        public string ClientClassName { get; set; }
        [Required]
        public string ClientNamespaceName { get; set; }
        [Required]
        public string FolderClientClass { get; set; }
        [Required]
        public string NSwagCommandFullPath { get; set; }
   ```

1. Install [NSwag command line tool](https://github.com/RicoSuter/NSwag/releases). You'll need the full path to the directory where NSwag.exe is located.

1. Implement the abstract methods:

   ```csharp
      protected override string ToolName => "RestApiClientGenerator";

      protected override string GenerateFullPathToTool()
      {
          return $"{NSwagCommandFullPath}\\NSwag.exe";
      }
   ```

1. There are many methods that you can override. For the current implementation, define these two:

   - Define the command parameter:

    ```csharp
      protected override string GenerateCommandLineCommands()
      {
          return $"openapi2csclient /input:{InputOpenApiSpec}  /classname:{ClientClassName} /namespace:{ClientNamespaceName} /output:{FolderClientClass}\\{ClientClassName}.cs";
      }
    ```

   - Parameter validation:

    ```csharp
    protected override bool ValidateParameters()
    {
          //http address is not allowed
          var valid = true;
          if (InputOpenApiSpec.StartsWith("http:") || InputOpenApiSpec.StartsWith("https:"))
          {
              valid = false;
              Log.LogError("URL is not allowed");
          }

          return valid;
    }
    ```

    > [!NOTE]
    > This simple validation could be done in other way on the MSBuild file, but it is recommended do it in C# code and encapsulate the command and the logic.

1. Build the project.

## Create a console app to use the new MSBuild task

The next step is to create an app that uses the task.

1. Create a **Console App** project, and call it `PetReaderToolTaskConsoleApp`. Choose the desired .NET version. Mark it as startup project.

1. Create a **Class Library** project to generate the code, called `PetRestApiClient`.  Use .NET Standard.

1. In the `PetReaderToolTaskConsoleApp` project, create a project dependency to `PetRestApiClient`.

1. In the `PetRestApiClient` project, create a folder `PetRestApiClient`. This folder will contain the generated code.

1. Delete *Class1.cs*, which was automatically generated.

1. On `PetRestApiClient`, add the following NuGet packages:

   - Newtonsoft.Json, needed to compile the generated client
   - System.ComponentModel.Annotations, needed to compile the generated client

1. In the `PetRestApiClient` project, create a text file named *petshop-openapi-spec.json* (in the project folder). To add the OpenAPI spec, copy the content from [here](https://petstore.swagger.io/v2/swagger.json) into the file. We like a reproducible build that depends only on the input, as discussed previously. In this example, you'll raise a build error if a user chooses a URL as the OpenAPI spec input.

   > [!IMPORTANT]
   > A general rebuild won't work. You'll see errors that indicate it's unable to copy or delete `RestApiClientGenerator`.dll'. This is because it's trying to build the MBuild custom task in the same build process which uses it. Select `PetReaderToolTaskConsoleApp` and rebuild only that project. The another solution is put the custom task in a completely independent Visual Studio solution as you did in [Tutorial: Create a custom task](tutorial-custom-task-code-generation.md) example.

1. Copy the following code into *Program.cs*:

   ```csharp
    using System;
    using System.Net.Http;
    namespace PetReaderToolTaskConsoleApp
    {
      internal class Program
      {
          private const string baseUrl = "https://petstore.swagger.io/v2";
          static void Main(string[] args)
          {
              HttpClient httpClient = new HttpClient();
              httpClient.BaseAddress = new Uri(baseUrl);
              var petClient = new PetRestApiClient.PetRestApiClient(httpClient);
              var pet = petClient.GetPetByIdAsync(1).Result;
              Console.WriteLine($"Id: {pet.Id} Name: {pet.Name} Status: {pet.Status} CategoryName: {pet.Category.Name}");
          }
      }
    }
   ```

1. Change the MSBuild instructions to call the task and generate the code. Edit *PetRestApiClient.csproj* by following these steps:

   1. Register the use of the MSBuild custom task:

       ```xml
       <UsingTask TaskName="RestApiClientGenerator.RestApiClientGenerator" AssemblyFile="..\RestApiClientGenerator\bin\Debug\netstandard2.0\RestApiClientGenerator.dll" />
       ```

   1. Add some properties needed to execute the task:

      ```xml
       <PropertyGroup>
          <!--The place where the OpenAPI spec is in-->
         <PetClientInputOpenApiSpec>petshop-openapi-spec.json</PetClientInputOpenApiSpec>
         <PetClientClientClassName>PetRestApiClient</PetClientClientClassName>
         <PetClientClientNamespaceName>PetRestApiClient</PetClientClientNamespaceName>
         <PetClientFolderClientClass>PetRestApiClient</PetClientFolderClientClass>
         <!--The directory where NSawg.exe is in-->
         <NSwagCommandFullPath>C:\Nsawg\Win</NSwagCommandFullPath>
        </PropertyGroup>
      ```

      > [!IMPORTANT]
      > Select the proper `NSwagCommandFullPath` value based on the installation location on your system.

   1. Add an [MSBuild target](msbuild-targets.md) to generate the client during the build process. This target should execute before `CoreCompile` executes to generate the code used in the compilation.

      ```xml
      <Target Name="generatePetClient" BeforeTargets="CoreCompile" Inputs="$(PetClientInputOpenApiSpec)" Outputs="$(PetClientFolderClientClass)\$(PetClientClientClassName).cs">
        <!--Calling our custom task derivated from MSBuild Tool Task-->
        <RestApiClientGenerator InputOpenApiSpec="$(PetClientInputOpenApiSpec)" ClientClassName="$(PetClientClientClassName)" ClientNamespaceName="$(PetClientClientNamespaceName)" FolderClientClass="$(PetClientFolderClientClass)" NSwagCommandFullPath="$(NSwagCommandFullPath)"></RestApiClientGenerator>
      </Target>

      <Target Name="forceReGenerationOnRebuild" AfterTargets="CoreClean">
        <Delete Files="$(PetClientFolderClientClass)\$(PetClientClientClassName).cs"></Delete>
      </Target>
      ```

     `Input` and `Output` are related to [Incremental Build](how-to-build-incrementally.md), and the `forceReGenerationOnRebuild` target deletes the generated file after `CoreClean`, which forces the client to be regenerated during the rebuild operation.

1. Select `PetReaderToolTaskConsoleApp` and rebuild only that project. Now, the client code is generated and the code compiles. You can execute it and see how it works. This code generates the code from a file, and that is allowed.

1. In this step, you'll demonstrate the parameter validation. In *PetRestApiClient.csproj*, change the property `$(PetClientInputOpenApiSpec)` to use the URL:

   ```xml
     <PetClientInputOpenApiSpec>https://petstore.swagger.io/v2/swagger.json</PetClientInputOpenApiSpec>
   ```

1. Select `PetReaderToolTaskConsoleApp` and rebuild only that project. You'll get the error, "URL is not allowed" in accordance with the design requirement.

## Download the code

Install the [NSwag command line tool](https://github.com/RicoSuter/NSwag/releases). Then, you'll need the full path to the directory where NSwag.exe is located. After that, edit *PetRestApiClient.csproj* and select the proper `$(NSwagCommandFullPath)` value based on the installation path on your computer. Now, select `RestApiClientGenerator` and build only that project, and finally select and rebuild `PetReaderToolTaskConsoleApp`. You can execute `PetReaderToolTaskConsoleApp`. to verify that everything works as expected.

## Next steps

You might want to publish your custom task as a NuGet package.

> [!div class="nextstepaction"]
> [Tutorial: Create a custom task](tutorial-custom-task-code-generation.md#package-the-task-for-distribution)

Or, learn how to test a custom task.

> [!div class="nextstepaction"]
> [Test a custom MSBuild task](tutorial-test-custom-task.md)