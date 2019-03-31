---
title: "Step 2: Creating Your First ASP.NET Core Web App"
titleSuffix: ""
description: "Create your first ASP.NET Core Web App with this video tutorial and step-by-step instructions."
ms.custom: "seodec18, get-started"
ms.date: 03/30/2019
ms.technology: vs-ide-general
ms.prod: visual-studio-windows
monikerRange: vs-2019
ms.topic: tutorial
ms.devlang: CSharp
author: ardalis
ms.author: tglee
manager: jillfra
dev_langs:
  - CSharp
ms.workload:
  - "aspnet"
  - "dotnetcore"
---
# Step 2: Creating Your First ASP.NET Core Web App

Create your first ASP.NET Core Web App with this video tutorial and step-by-step instructions.

_Watch this video and follow along to create your first ASP.NET Core app._

> [!Video https://channel9.msdn.com/Shows/XamarinShow/Building-Your-First-Android--iOS-App-in-Visual-Studio-2017/player]

## Run Visual Studio 2019 and Create a New Project

Run Visual Studio Community 2019 and click Create new project. Choose ASP.NET Core Web Application. Choose the Web Application template and keep the default Project name and Location. Click Create. For more detailed instructions, refer to [the previous video in this tutorial series](tutorial-aspnet-ef-step-01.md).

![Visual Studio 2019 Choose ASP.NET Core Project Options](media/vs2019-choose-aspnetcore-project.png)

## Explore the New Project

In the solution explorer window on the right, you can view the contents of the new project. They're described here.

### wwwroot

The wwwroot folder holds static files that will be publicly accessible from the web application. It typically holds stylesheets, client-side script files, and images.

### Pages

The Pages folder holds the site's Razor Pages. The default template provides several pages, including the Index.cshtml page that is the application home page, as well as About, Contact, etc.

### appsettings.json

This file holds configuration settings for the site, in JSON format.

### Program.cs

This file acts as the entry point for the application. When the app is run, its Main method is the first method that is run, and is responsible for creating the Web Host that will contain the application.

### Startup.cs

The Web Host created in Program.cs references the Startup class and calls its methods to configure the application. The ConfigureServices method is responsible for setting up any services the app will use. The Configure method sets up the app's HTTP request pipeline. Each request goes through this pipeline, interacting with each piece of *middleware* as it does so.

### Index.cshtml

The home page for the site includes some HTML markup and some server side Razor code. It uses Razor to specify the page model, IndexModel, which is located in the associated Index.cshtml.cs file. It also sets the page title by setting a value in ViewData. This ViewData value is read in the _Layout.cshtml file, located in the Shared folder inside the Pages folder. The Layout file is shared by many Razor Pages and provides the common look and feel for the application. Each page's content is rendered within the Layout file's HTML.

## Run the Application

Now run the application and view it in the browser. You can run the application using ctrl+F5 or by choosing Debug > Start Without Debugging from Visual Studio's menu.

## Customize the Application

Add a property to the Index.cshtml.cs file and set its value to the current time in the `OnGet` handler:

```csharp
public string Time { get; set; }
public void OnGet()
{
    Time = DateTime.Today.ToShortTimeString();
}
```

Replace the <div> content in Index.cshtml with this markup:

```cshtml
<h2>It's @Model.Time right now on the server!</h2>
```

Run the application again. You should see that the page now displays the current time, but it's always midnight! That's not right.

## Debugging the Application

Add a breakpoint to the OnGet method where we're assigning a value to Time and this time Start Debugging the application.

Execution stops on the line, and you can see that `DateTime.Today` includes the date but the time is always midnight because it doesn't include time data. Change it to use `DateTime.Now` and continue executing. The new code for `OnGet` should be:

```csharp
public void OnGet()
{
    Time = DateTime.Now.ToShortTimeString();
}
```

You should now see the actual server time in the browser when you navigate to the app.

## Next Steps

In the next video, you'll learn how to add data support to your app.

[Tutorial: Working with Data in Your ASP.NET Core App](tutorial-aspnet-ef-step-03.md)

## References

- [Tutorial: Create a Razor Pages web app with ASP.NET Core](https://docs.microsoft.com/en-us/aspnet/core/tutorials/razor-pages/?view=aspnetcore-2.1)
