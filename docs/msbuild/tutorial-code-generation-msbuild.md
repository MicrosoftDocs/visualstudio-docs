---
title: Handle code generation in a build
description: Learn how to handle code generation such as REST API client generation in MSBuild, either using the Exec task to run a tool, or create a custom task.
ms.date: 03/07/2022
ms.topic: tutorial
helpviewer_keywords:
- MSBuild, tutorial
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: msbuild
ms.workload:
- multiple
---
# Tutorial: Use REST API Client Generation with MSBuild

An application which consumes RestApi is a very common scenario. In this tutorial you'll learn how to generate the Rest API client automatically during build process using MSBuild. You'll use [NSawg](https://docs.microsoft.com/aspnet/core/tutorials/getting-started-with-nswag?view=aspnetcore-6.0&tabs=visual-studio), a tool that generates client code for a REST API.

The example shows a console app that consumes the public [Pet Store API](https://petstore.swagger.io), which publishes an [OpenAPI spec](https://petstore.swagger.io/v2/swagger.json).

If you are not clear on terms such as tasks, targets, properties, or runtimes, you could first check out the docs that explain these concepts, starting with the [MSBuild Concepts article](https://docs.microsoft.com/visualstudio/msbuild/msbuild-concepts).

When you want to run a command-line tool as part of a build, there are two approaches to consider. One is to use the MSBuild [Exec task](exec-task.md), which lets you run a command-line tool and specify its parameters. The other method is to create a custom task derived from [ToolTask](xref:Microsoft.Build.Utilities.ToolTask), which gives you greater control.

## Option 1: Use the MSBuild Exec Task

We will use the ["Exec" MSBuild task](https://docs.microsoft.com/dotnet/api/microsoft.build.tasks.exec?view=msbuild-17-netcore), which simply invokes the specified process with the specified arguments, waits for it to complete, and then returns `true` if the process completes successfully, and `false` if an error occurs.

NSwag code generation can be used from MSBuild, by [NSwag.MSBuild](https://github.com/RicoSuter/NSwag/wiki/NSwag.MSBuild)

The complete code is in the PetReaderExecTaskExample folder; you can download and take a look. In this tutorial, you'll go through step by step and learn the concepts on the way.

1. Create a new console application named PetReaderExecTaskExample. Use .NET 6.0 or greater.

1. Create another project in the same solution: PetShopRestClient (This is going to contain the generated client as a library). For this project, use netstandard 2.1. The generated client doesn't compile on netstandard 2.0.

1. In the PetReaderExecTaskExample project, and add a project dependency to PetShopRestClient project.

1. In the PetShopRestClient project, include the following NuGet packages:

   - Nswag.MSBuild - this allows access to the code generator from MSBuild
   - Newtonsoft.Json, needed to compile the generated client
   - System.ComponentModel.Annotations, needed to compile the generated client

1. In the PetShopRestClient project, add a folder (named PetShopRestClient) for the code generation and delete the Class1.cs that was automatically generated.

1. Create a text file named petshop-openapi-spec.json (on root). We are going to add the OpenApi spec; copy the content from [here](https://petstore.swagger.io/v2/swagger.json) inside the file. It's best to copy a snapshot of the spec instead of reading it online during the build. You always want a consistently reproducible build that depends only on the input. Consuming the API directly could transform a build which works today to a build which fails tomorrow from the same source. The picture saved on petshop-openapi-spec.json will allow us to still have a version which builds even if the spec changes.

1. Next, modify PetShopRestClient.csproj and add a [MSBuild targets](https://docs.microsoft.com/visualstudio/msbuild/msbuild-targets) to generate the client during build process.

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

    Notice that this target uses the attributes [BeforeTarget and AfterTarget](target-build-order.md#beforetargets-and-aftertargets) as way to define build order. The first target called "generatePetClient" will be executed before the core compilation target, so the source will be created before the compiler executes. The input and output parameter are related to [Incremental Build](how-to-build-incrementally.md). MSBuild can compare the timestamps of the input files with the timestamps of the output files and determine whether to skip, build, or partially rebuild a target.

    After installing the NSwag.MSBuild NuGet package in your project, you can use the variable $(NSwagExe) in your `.csproj` file to run the NSwag command line tool in an MSBuild target. This way the tools can easily be updated via NuGet. Here we are using the _Exec MSBuild Task_ to execute the NSwag program with the required parameters to generate the client Rest Api. [More about Nsawg command and parameters](https://github.com/RicoSuter/NSwag/wiki/NSwag.MSBuild).

    You can capture output from `<Exec>` adding `ConsoleToMsBuild="true"` to your `<Exec>` tag and then capturing the output using the `ConsoleOutput` parameter in an `<Output>` tag. `ConsoleOutput` returns the output as an Item. Whitespace is trimmed. ConsoleOutput is enabled when ConsoleToMSBuild is true.

    The second target called `forceReGenerationOnRebuild` deletes the generated class during clean up to force the re generation on rebuild target execution. This target runs after core clean MSBuild predefined target.

1. Execute a Visual Studio Solution rebuild and see the client generated on the PetShopRestClient folder.

1. Now, use the generated client. Go to the client Program.cs and copy the following code:

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

Congratulations! Now, you can execute the program to see how it is working.

## Option 2: Use the Custom task derived from MSBuild Tool Task

In many cases, using the `Exec` task is good enough to execute an external tools to do something, like REST API Client Code Generation.

In this tutorial, you'll continue with the same example, but the ideas can be used for other more complex examples.
What if you want to allow Rest Api Client Code Generation if only if you don't use absolute Windows path as input? Or what if you need to calculate in some way where the executable is? When there is any situation where you need to execute some code to do extra work, the [MSBuild Tool Task](https://docs.microsoft.com/dotnet/api/microsoft.build.utilities.tooltask) is the best solution. This is an abstract class derived from MSBuild `Task`. You can define a concrete subclass, which creates a custom MSBuild task. This lets you run any code that is needed to prepare for command execution. You should read about [Custom task code generation](../custom-task-code-generation/) first.

You'll create a custom task derived from [MSBuild Tool Task](https://docs.microsoft.com/dotnet/api/microsoft.build.utilities.tooltask) which will generate a REST API client but it will fail if you try to reference the OpenApi spec using a http address. NSwag supports a http address as OpenApi spec input, but for the purposes of this example, let's suppose there's a design requirement to disallow that.

The complete code version is in this PetReaderToolTaskExample folder; you can download and take a look. In this tutorial, you'll go through step by step and learn some concepts that you can apply to your own scenarios.

1. Create a new Visual Studio Project for the Custom Task. We will call it "RestApiClientGenerator" and it must be library C# netstandard2.0. The solution name will be "PetReaderToolTaskExample"

1. Delete Class1.cs, which was automatically generated.

1. Add _Microsoft.Build.Utilities.Core_ NuGet packages:

   - Create a class called `RestApiClientGenerator`
   - Inherit from MSBuild Tool Task and implement the abstract method as shown in the following code:

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

## Create a console app to use our new MSBuild Task

1. Create a Console App, we will call "PetReaderToolTaskConsoleApp". We are going to use net6.0 in our case. Mark it as startup project

1. Create a Library project to generate the code, called "PetRestApiClient". NetStandard2.1

1. On "PetReaderToolTaskConsoleApp" create dependency to "PetRestApiClient"

1. On PetRestApiClient project create a folder "PetRestApiClient", this folder will contain the generated code and delete Class1.cs automatically generated.

1. On PetRestApiClient add the following NuGet packages:

   - Newtonsoft.Json, it will be needed to compile the generated client
   - System.ComponentModel.Annotations, it will be needed to compile the generated client

1. On PetRestApiClient, create a text file named petshop-openapi-spec.json (on root). We are going to add the OpenApi spec, please copy the content from [here](https://petstore.swagger.io/v2/swagger.json) inside the file. We like repetitive build and depending only from the input, consuming directly the api could transform a build which works today to a build which fails tomorrow from the same source. In this example, we are going to raise a build error if you choose a URL as OpenApi spec input.

> [!WARNING]
> A general rebuild won't work. You will see errors like 'unable to copy or delete RestApiClientGenerator.dll'. This is because we are trying to build the MBuild Custom Task on the same build process which use it. Select "PetReaderToolTaskConsoleApp" and rebuild only that project. The another solution is put the Custom Task in a complete independent Visual Studio Solutions as we did on [Custom task code generation](../custom-task-code-generation/) example. We are testing different flavors.

1. Define the Program.cs

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

1. We need to change the MSBuild instructions to call our task and generate the code. Edit PetRestApiClient.csproj

  1. Register to the MSBuild custom task

     ```xml
     <UsingTask TaskName="RestApiClientGenerator.RestApiClientGenerator" AssemblyFile="..\RestApiClientGenerator\bin\Debug\netstandard2.0\RestApiClientGenerator.dll" />
     ```

  1. Add some props needed to execute our task

     ```xml
 	   <PropertyGroup>
  		   <!--The place where the OpenApi spec is in-->
  		   <PetClientInputOpenApiSpec>petshop-openapi-spec.json</PetClientInputOpenApiSpec>
  		   <PetClientClientClassName>PetRestApiClient</PetClientClientClassName>
  		   <PetClientClientNamespaceName>PetRestApiClient</PetClientClientNamespaceName>
  		   <PetClientFolderClientClass>PetRestApiClient</PetClientFolderClientClass>
  		   <!--The directory where NSawg.exe is in-->
  		   <NSwagCommandFullPath>C:\Nsawg\Win</NSwagCommandFullPath>
      </PropertyGroup>
     ```

  > [!WARNING]
  > Select the proper NSwagCommandFullPath value based on your computer

  1. Add a [MSBuild targets](https://docs.microsoft.com/visualstudio/msbuild/msbuild-targets) to generate the client during build process. We are going to execute before the core compile execute to generates the code.

     ```xml
     <Target Name="generatePetClient" BeforeTargets="CoreCompile" Inputs="$(PetClientInputOpenApiSpec)" Outputs="$(PetClientFolderClientClass)\$(PetClientClientClassName).cs">
        <!--Calling our custom task derivated from MSBuild Tool Task-->
		   <RestApiClientGenerator InputOpenApiSpec="$(PetClientInputOpenApiSpec)" ClientClassName="$(PetClientClientClassName)" ClientNamespaceName="$(PetClientClientNamespaceName)" FolderClientClass="$(PetClientFolderClientClass)" NSwagCommandFullPath="$(NSwagCommandFullPath)"></RestApiClientGenerator>
	 </Target>
	
     <Target Name="forceReGenerationOnRebuild" AfterTargets="CoreClean">
	 	<Delete Files="$(PetClientFolderClientClass)\$(PetClientClientClassName).cs"></Delete>
	 </Target>
     ```

     Input and Output are related to [Incremental Build](https://docs.microsoft.com/visualstudio/msbuild/how-to-build-incrementally), and _forceReGenerationOnRebuild_ target delete the generated file after core clean, and it force the client re generation during the rebuild target execution.

1. Select "PetReaderToolTaskConsoleApp" and rebuild only that project. Now, the client code must be generated and the code compiles. It is possible to be executed and see how it works. We are generating from a file, and that is allowed.

1. On this step, we are going to show the parameter validation. On _PetRestApiClient.csproj_ change the prop _PetClientInputOpenApiSpec_ to use the url

   ```xml
     <PetClientInputOpenApiSpec>https://petstore.swagger.io/v2/swagger.json</PetClientInputOpenApiSpec>
   ```

1. Select "PetReaderToolTaskConsoleApp" and rebuild only that project. You will get the error "URL is not allowed"

   > [!NOTE]
   > If you like to publish your custom task as NuGet package, please read the [Custom task code generation](../custom-task-code-generation/) example.

## Downloading code

Install the [NSwag command line tool](https://github.com/RicoSuter/NSwag/releases). Then, you'll need the full path to the directory where NSwag.exe is located. After that, edit PetRestApiClient.csproj and select the proper NSwagCommandFullPath value based on your computer. Now, select "RestApiClientGenerator" and build only that project, and finally select and rebuild "PetReaderToolTaskConsoleApp". You can execute "PetReaderToolTaskConsoleApp".
