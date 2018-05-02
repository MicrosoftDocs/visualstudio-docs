---
title: "Azure Functions"
description: "Using Azure functions in Visual Studio for Mac."
author: asb3993
ms.author: amburns
ms.date: 04/30/2018
ms.topic: article
ms.technology: vs-ide-install
ms.assetid: 38FD2070-5151-482E-B0A9-993715128736
---

# Getting started building Azure Functions in Visual Studio for Mac

In this lab, you'll learn how to get started building Azure Functions using Visual Studio for Mac. You'll also integrate with Azure storage tables, which represents one of the many kinds of bindings and triggers available to Azure Functions developers.

## Objectives

- Create and debug local Azure Functions
- Integrate with web and Azure storage resources
- Orchestrate a workflow involving multiple Azure Functions

## Requirements

- Visual Studio for Mac 7.5 or higher ([https://www.visualstudio.com/vs/visual-studio-mac](https://www.visualstudio.com/vs/visual-studio-mac)).
- Azure subscription (available free from [https://azure.com/free](https://azure.com/free))


## Exercise 1: Getting started building Azure Functions in Visual Studio for Mac

### Task 1: Creating an Azure Functions project

1. Launch **Visual Studio for Mac**.

1. Select **File > New Solution**.

1. From the **Cloud > General** category, select the **Azure Functions** template. You will use C# to create a .NET class library that hosts Azure Functions. Click **Next**.

    ![]()

1. Set the **Project Name** to **"AzureFunctionsLab"** and click **Create**.

    ![](https://user-images.githubusercontent.com/3944468/29033687-bddf2f34-7b4a-11e7-9080-67df103a06c9.png)

1. Expand the nodes in **Solution Pad**. The default project template includes NuGet references to a variety of Azure WebJobs packages, as well as the Newtonsoft.Json package. 

     There are also two files: **host.json** for describing the global configuration options for the host and **local.settings.json** for configuring service settings. The project template also creates a default HttpTrigger. For the sake of this lab, you should delete the **HttpTrigger.cs** file from the project. 

    Open **local.settings.json**. It defaults to having two empty connection string settings.

    ![](https://user-images.githubusercontent.com/3944468/29033694-bdf5276c-7b4a-11e7-8ce6-d4be00112687.png)

### Task 2: Creating an Azure storage account

1. Log on to your Azure account at [https://portal.azure.com](https://portal.azure.com).
 
1. Under the **Favorites** section, located on the left of the screen, select **Storage Accounts**:
    ![]()

1. Select **Add** to create a new storage account:
    ![]()

1. Enter a globally unique name for the **Name** and reuse it for the **Resource group**. You can keep all the other items as their default.
    ![]()

1. Click **Create**. It might take a few minutes to create the storage account. You'll get a notification once it has been successfully created.

1. Select the **Go to resource** button from the notification:
    ![]())

1. Select the **Access keys** tab.

    ![](https://user-images.githubusercontent.com/3944468/29033691-bdf03e14-7b4a-11e7-821d-89171c7c4446.png)

1. Copy the first **Connection String**. This will be used to integrate Azure storage with your Azure Functions later on.

    ![](https://user-images.githubusercontent.com/3944468/29033711-be655942-7b4a-11e7-9c9a-52b8efcd95a9.png)

1. Return to **Visual Studio for Mac** and paste the full connection string in as the **AzureWebJobsStorage** setting in **local.settings.json**. Now you can reference the name of the setting in attributes for functions that need access to its resources.

    ![](https://user-images.githubusercontent.com/3944468/29033695-bdff3342-7b4a-11e7-9297-8bb89db3f1d7.png)

<a name="Ex1Task3"></a>
### Task 3: Creating and debugging an Azure Function ###

1. You're now ready to start adding some code. When working with a .NET class library, Azure Functions are added as static methods. From **Solution Pad**, right-click the **AzureFunctions** project node and select **Add > New File**.

    ![](https://user-images.githubusercontent.com/3944468/29033698-be0ace3c-7b4a-11e7-9b0a-90b3cfacbe8b.png)

1. From the **General** category, select the **Empty Class** template. Set the **Name** to **"Functions"** and click **New**.

    ![](https://user-images.githubusercontent.com/3944468/29033696-be06a73a-7b4a-11e7-8e67-0fd634462731.png)

1. At the top of the new file, add the **using** statements below. These provide shorthand access to a variety of helper methods for working with features such as LINQ and HTTP, as well as objects in the Azure Functions stack.

    ```csharp
    using System.Linq;
    using System.Net;
    using System.Net.Http;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Azure.WebJobs.Host;
    using Microsoft.WindowsAzure.Storage.Table;
    ```
1. Add the method below to the class as your first Azure Function.

    ```csharp
    [FunctionName("Add")]
    public static int Add(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
        HttpRequestMessage req,
        TraceWriter log)
    {
        int x = 1;
        int y = 2;
    
        return x + y;
    }
    ```
1. Let's walk through the method definition piece by piece. The first thing you'll see is the **FunctionName** attribute that marks this method as an Azure Function. It takes a single parameter, which is the public name of the function. It does not need to match the actual method name itself (although it does here).

    ![](https://user-images.githubusercontent.com/3944468/29033697-be09d874-7b4a-11e7-8cdb-de931938b664.png)

1. Next, the method itself is marked as a **public static** method, which is required. You'll also notice that the return value is an **int**. Unless otherwise specified using method attributes, any non-void return value of an Azure Function will be rendered and returned to the client as text. By default it will be returned as **XML**, but you can easily change that to **JSON**, which you'll do later on in the lab.

    ![](https://user-images.githubusercontent.com/3944468/29033699-be0def0e-7b4a-11e7-97bf-e2301cddbb9a.png)

1. The first parameter is marked with the **HttpTrigger** attribute, which indicates that this method is invoked by an HTTP request. The attribute also specifies the authorization level of the method, as well as the verbs it supports (only **"GET"** in this case). You may also optionally define a **Route** that overrides the path to the method and offers a way to automatically extract variables from the path. Since the **Route** is null here, the path to this method will default to **/api/Add**.

    ![](https://user-images.githubusercontent.com/3944468/29033700-be12666a-7b4a-11e7-9f48-b571da2082e2.png)

1. The final parameter to the method is a **TraceWriter** that can be used to log messages for diagnostics and errors.

    ![](https://user-images.githubusercontent.com/3944468/29033701-be193a76-7b4a-11e7-94ff-70b06862b57c.png)

1. Set a breakpoint on the **return** line of the method by either clicking in the margin of the line or setting the cursor on the line and pressing **F9**.

    ![](https://user-images.githubusercontent.com/3944468/29033703-be200f86-7b4a-11e7-9723-de3c48050b5e.png)

1. Build and run the project in a debug session by pressing **F5** or selecting **Run > Start Debugging**. You could alternatively click the **Run** button. These all perform the same task. The rest of this lab will reference **F5**, but you can use the method you find most comfortable.

    ![](https://user-images.githubusercontent.com/3944468/29033702-be1bc2aa-7b4a-11e7-883c-1c1ba781f1a8.png)

1. Select **View > Pads > Application Output - AzureFunctionsLab**.

1. After the project builds, it will go through a process of detecting Azure Functions based on method attributes and a file convention we'll cover shortly. In this case it will detect a single Azure Function and will "generate" 1 job function.

    ![](https://user-images.githubusercontent.com/3944468/29033704-be221e20-7b4a-11e7-97ea-5fae7e6e256b.png)

1. At the bottom of the startup messages, the Azure Functions host will print the URLs of any HTTP trigger APIs. There should only be one. Open that URL in a new browser tab. For the rest of this lab you should keep one tab open to the Azure portal and another open for testing your Azure Function code.

    ![](https://user-images.githubusercontent.com/3944468/29033708-be445404-7b4a-11e7-92a7-49503277b92c.png)

1. The breakpoint should trigger immediately. The web request has been routed to the function and can now be debugged. Mouse over the **x** variable to see its value. You now have the full power of the Visual Studio debugger behind you and can perform any tasks you need to in order to refine the project.

    ![](https://user-images.githubusercontent.com/3944468/29033706-be42311a-7b4a-11e7-9507-4fcbf67655be.png)

1. Remove the breakpoint using the same method used to add it earlier (click on the margin or select the line and press **F9**).

1. Press **F5** to continue running.

1. In the browser, the XML result of the method will be rendered. As expected, the hardcoded addition operation produces a plausible sum. Note, if you only see "3" in Safari, go to **Safari > Preferences > Advanced** and tick the "**Show Develop menu in menu bar**" checkbox and reload the page.

    ![](https://user-images.githubusercontent.com/3944468/29033712-be6cfa4e-7b4a-11e7-9653-4288abec5464.png)

1. In **Visual Studio for Mac**, click the **Stop** button to end the debug session. Don't forget to restart (stop and then run) the debugging session each time you make changes in order for those changes to apply to the code being tested.

    ![](https://user-images.githubusercontent.com/3944468/29033707-be447574-7b4a-11e7-82e6-2f7b92b82f59.png)

1. In the **Add** method, replace the **x** and **y** definitions with the code below. This code extracts values from the URL's query string so that the addition operation can be performed dynamically based on the provided parameters.

    ```csharp
    int x = int.Parse(req.GetQueryNameValuePairs()
                .FirstOrDefault(q => string.Compare(q.Key, "x", true) == 0)
                            .Value);
    int y = int.Parse(req.GetQueryNameValuePairs()
                .FirstOrDefault(q => string.Compare(q.Key, "y", true) == 0)
                            .Value);
    ```
1. Press **F5** to build and run the application.

1. Return to the browser window and append the string **"/?x=2&y=3"** to the URL. The whole URL should now be **"http://localhost:7071/api/Add?x=2&y=3"**. Navigate to the new URL.

1. This time the result should reflect the new parameters. Feel free to try this a few more times with different values. Note that we haven't put in any error checking, so invalid or missing parameters will throw an error.

    ![](https://user-images.githubusercontent.com/3944468/29033705-be3ed1c8-7b4a-11e7-98a1-0427dcf6896c.png)

1. Stop the debugging session.

<a name="Ex1Task4"></a>
### Task 4: Working with function.json ###

1.  It was mentioned earlier that Visual Studio for Mac "generated" a job function for the Azure Function defined in the library. This is because Azure Functions doesn't actually use the method attributes at runtime, but rather uses a compile-time file system convention to configure where and how Azure Functions are made available. From **Solution Explorer**, right-click the **AzureFunctionsLab** project node and select **Reveal in Finder**.

    ![](https://user-images.githubusercontent.com/3944468/29033709-be5ab64a-7b4a-11e7-9ff1-a3712de6176a.png)

1. Navigate down the file system until you reach **bin/Debug/net461**. There will be a folder named **"Add"**. This folder was created to correspond with the function name attribute in the C# code. Expand that folder and there will be a single **function.json**. This is the file the runtime uses to host and manage the Azure Function itself. For other language models without compile-time support (such as C# script or JavaScript), these folders must be manually created and maintained. For C# developers, they are automatically generated from attribute metadata upon build. Open **function.json**.

    ![](https://user-images.githubusercontent.com/3944468/29033714-be75becc-7b4a-11e7-9d66-1a6f6e609e5e.png)

1. Given your familiarity with the C# attributes, this JSON should be pretty easy to understand. However, there are a few items we didn't explicitly discuss earlier. For example, each **binding** must have its **direction** set. As you might infer, **"in"** means that the parameter is input, whereas **"out"** indicates that the parameter is either a return value (via **$return**) or an **out** parameter to the method. You also need to specify the **scriptFile** (relative to this final location) and the **entryPoint** method (public and static) within the assembly. In the next few steps you'll add a custom function path using this model, so copy the contents of this file to the clipboard.

    ![](https://user-images.githubusercontent.com/3944468/29033713-be744d94-7b4a-11e7-84ff-961069474e49.png)

1. In **Solution Explorer**, right-click the **AzureFunctionsLab** project node and select **Add > New Folder**. Name the new folder **"Adder"**. By default convention, the name of this folder will define the path to the API, such as **api/Adder**.

    ![](https://user-images.githubusercontent.com/3944468/29033710-be639300-7b4a-11e7-8b52-0ee95ef26d9a.png)

1. Right-click the **Adder** folder and select **Add > New File**.

    ![](https://user-images.githubusercontent.com/3944468/29033715-be7864d8-7b4a-11e7-9f27-6808f2e497f2.png)

1. Select the **Web** category and the **Empty JSON File** template. Set the **Name** to **"function"** and click **New**.

    ![](https://user-images.githubusercontent.com/3944468/29033716-be79a726-7b4a-11e7-9110-e751facb1ac6.png)

1. Paste the contents of the other **function.json** in to replace the default contents of the newly created file.

1. At the end of the first binding (after the **"name": "req"** line), add the property below. Don't forget to include a comma on the previous line. This overrides the default root such that it will now extract **int** parameters from the path (if they're there) and place them into method parameters named **x** and **y**.

    ```json
    "route": "Adder/{x:int?}/{y:int?}"
    ```
1. Also update the **entryPoint** property at the bottom of the file to use a method called **"Add2"**, such as shown below. This is to illustrate that the path **api/Adder...** could map to an appropriate method with any name (**Add2** here).

    ```json
    "entryPoint": "AzureFunctionsLab.Functions.Add2"
    ```
1. Your final **function.json** file should look like this.

    ![](https://user-images.githubusercontent.com/3944468/29033717-be8222f2-7b4a-11e7-8810-fc5be2af4821.png)

1. The one final step required to make this all work is to instruct Visual Studio for Mac to copy this file to the same relative path in the output directory every time it changes.

    ![](https://user-images.githubusercontent.com/3944468/29033718-be85ad78-7b4a-11e7-80c6-3ea89629ffc7.png)

1. In **Functions.cs**, add the following method to fulfill the expected function. It's very similar to **Add**, except that it uses no attributes and has explicit parameters for **x** and **y**.

    ```csharp
    public static int Add2(
        HttpRequestMessage req,
        int x,
        int y,
        TraceWriter log)
    {
        return x + y;
    }
    ```
1. Press **F5** to build and run the project.

1. As the build completes and platform spins up, it will now indicate that there is a second route available for requests that maps to the newly added method.

    ![](https://user-images.githubusercontent.com/3944468/29033719-be891a58-7b4a-11e7-92a8-072d95d9bf12.png)

1. Return the browser window and navigate to **http://localhost:7071/api/Adder/3/5**.

1. This time the method works once again, pulling parameters from the path and producing a sum.

    ![](https://user-images.githubusercontent.com/3944468/29033721-be9427ea-7b4a-11e7-8d90-9963295fbf9f.png)

1. Return to **Visual Studio for Mac** and end the debugging session.

<a name="Ex1Task5"></a>
### Task 5: Working with Azure storage tables ###

1. Oftentimes the service you build might be much more complex than what we have built so far and require a significant amount of time and/or infrastructure to execute. In that case, you might find it effective to accept requests that are queued for processing when the resources become available, which Azure Functions provides support for. In other cases, you’ll want to store data centrally and Azure storage tables let you do that quickly. Add the class below to **Functions.cs**. It should go inside the namespace, but outside the **Functions** class.

    ```csharp
    public class TableRow : TableEntity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Sum { get; set; }
    }
    ```
1. Within the **Functions** class, add the code below to introduce another function. Note that this one is unique so far in that it doesn't involve an HTTP response. The final line returns a new **TableRow** populated with some key information that will make it easy to retrieve later on (**PartitionKey** and **RowKey**), as well as its parameters and sum. The code within the method also uses the **TraceWriter** to make it easier to know when the function runs.

    ```csharp
    [FunctionName("Process")]
    [return: Table("Results")]
    public static TableRow Process(
        [HttpTrigger(AuthorizationLevel.Function, "get",
            Route = "Process/{x:int}/{y:int}")]
        HttpRequestMessage req,
        int x,
        int y,
        TraceWriter log)
    {
        log.Info($"Processing {x} + {y}");
    
        return new TableRow()
        {
            PartitionKey = "sums",
            RowKey = $"{x}_{y}",
            X = x,
            Y = y,
            Sum = x + y
        };
    }
    ```
1. Press **F5** to build and run the project.

1. In the browser tab, navigate to **http://localhost:7071/api/Process/4/6**. This will put another message into the queue, which should eventually result in another row being added to the table.

1. Return to **Visual Studio for Mac** and watch the application log for the incoming request for **4 + 6**.

    ![](https://user-images.githubusercontent.com/3944468/29033722-be958388-7b4a-11e7-9d71-656f89bb33e3.png)

1. Return to the browser to refresh the request to the same URL. This time you'll see an error after the **Process** method. This is because the code is attempting to add a row to the Azure Table Storage table using a partition and row key combination that already exists.

    ![](https://user-images.githubusercontent.com/3944468/29033720-be90af52-7b4a-11e7-8021-a110b5318527.png)

1. End the debugging session.

1. To mitigate the error, add the following parameter to the method definition immediately before the **TraceWriter** parameter. This parameter instructs the Azure Functions platform to attempt to retrieve a **TableRow** from the **Results** table on the **PartitionKey** we've been using to store results. However, some of the real magic comes into play when you notice that the **RowKey** is being dynamically generated based on the other **x** and **y** parameters for the very same method. If that row already exists, then **tableRow** will have it when the method begins with no extra work required by the developer. If the row doesn't exist, then it'll just be null. This sort of efficiency enables developers to focus on the important business logic and not the infrastructure.

    ```csharp
    [Table("Results", "sums", "{x}_{y}")]
    TableRow tableRow,
    ```
1. Add the code below to the beginning of the method. If **tableRow** isn't null, then we already have the results for the operation being requested and can return it immediately. Otherwise, the function continues as before. While this may not be the most robust way to return the data, it illustrates the point that you can orchestrate incredibly sophisticated operations across multiple scalable tiers with very little code.

    ```csharp
    if (tableRow != null)
    {
        log.Info($"{x} + {y} already exists");
        return null;
    }
    ```
1. Press **F5** to build and run the project.

1. In the browser tab, refresh the URL at **http://localhost:7071/api/Process/4/6**. Since the table row for this record exists, it should return immediately and without error. Since there is no HTTP output, you can see the log in the application output.

    ![](https://user-images.githubusercontent.com/3944468/29033724-be9adb44-7b4a-11e7-86d0-85c159f428eb.png)

1. Update the URL to reflect a combination not yet tested, such as **http://localhost:7071/api/Process/5/7**. Note the message in the application log, which indicates that the table row was not found (as expected).

    ![](https://user-images.githubusercontent.com/3944468/29033723-be9af048-7b4a-11e7-8ec2-16d9f8a94210.png)

1. Return to **Visual Studio for Mac** and end the debugging session.

1. Finally, let's take a look at what it's like to work with multiple input records. Rather than specify a specific **TableRow**, you can request an **IQueryable<TableRow>** using the same attributes, and the runtime will fill it with the appropriate resource you need. Add the code below to create a **List** function that lists all items that currently exist in the Azure table we've been working with. Also note that we're specifying that the MIME type of the response is **application/json**, so the runtime will automatically render as JSON. It's just that easy.

    ```csharp
    [FunctionName("List")]
    public static HttpResponseMessage List(
        [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)]
        HttpRequestMessage req,
        [Table("Results", "sums")]
        IQueryable<TableRow> table,
        TraceWriter log)
    {
        return req.CreateResponse(HttpStatusCode.OK, table, "application/json");
    }
    ```
1. Press **F5** to build and run the project.

1. In the browser tab, navigate to **http://localhost:7071/api/List**. This should pull down the list of all items in the Azure table and render it as JSON.

    ![](https://user-images.githubusercontent.com/3944468/29033725-be9d5a5e-7b4a-11e7-8b55-df0a200b6320.png)

<a name="Summary"></a>
## Summary ##

In this lab, you've learned how to get started building Azure Functions with Visual Studio for Mac.

