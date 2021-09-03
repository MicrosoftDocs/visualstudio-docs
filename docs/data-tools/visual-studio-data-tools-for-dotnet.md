---
title: Data tools for .NET
description: Review Visual Studio data tools for .NET, which provide API and tooling support to connect to databases, model data in memory, and display data in the UI.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: overview
ms.assetid: c3175080-1dfb-4ab8-a460-92dadbb844b4
author: ghogen
ms.author: ghogen
manager: jmartens
ms.technology: vs-data-tools
ms.workload:
- data-storage
- dotnet
---
# Visual Studio data tools for .NET

Visual Studio and .NET together provide extensive API and tooling support for connecting to databases, modeling data in memory, and displaying the data in the user interface. The .NET classes that provide data-access functionality are known as [ADO.NET](/dotnet/framework/data/adonet/index). ADO.NET, along with the data tooling in Visual Studio, was designed primarily to support relational databases and XML. These days, many NoSQL database vendors, or third parties, offer ADO.NET providers.

[.NET Core](/dotnet/core/) supports ADO.NET, except for datasets and their related types. If you're targeting .NET Core and require an object-relational mapping (ORM) layer, use [Entity Framework Core](/ef/core/).

The following diagram shows a simplified view of the basic architecture:

![ADO.NET Architecture](../data-tools/media/raddata-ado-net-architecture-diagram.png)

## Typical workflow

The typical workflow is this:

1. Install a development or test database on your local machine. See [Installing database systems, tools, and samples](../data-tools/installing-database-systems-tools-and-samples.md). If you are using an Azure data service, this step is not necessary.

2. Test the connection to the database (or service or local file) in Visual Studio. See [Add new connections](../data-tools/add-new-connections.md).

3. (Optional) Use the tools to generate and configure a new model. Models based on Entity Framework are the default recommendation for new applications. The model, whichever one you use, is the data source with which the application interacts. The model sits logically between the database or service and the application. See [Add new data sources](../data-tools/add-new-data-sources.md).

4. Drag the data source from the **Data Sources** window onto a Windows Forms, ASP.NET, or Windows Presentation Foundation design surface to generate the data-binding code that will display the data to the user in the way that you specify. See [Bind controls to data in Visual Studio](../data-tools/bind-controls-to-data-in-visual-studio.md).

5. Add custom code for things like business rules, search, and data validation, or to take advantage of custom functionality that the underlying database exposes.

You can skip step 3 and program a .NET application to issue commands directly to a database, rather than using a model. In this case, you will find the relevant documentation here: [ADO.NET](/dotnet/framework/data/adonet/index). Note that you still can use the **Data Source Configuration Wizard** and designers to generate data-binding code when you populate your own objects in memory and then data-bind UI controls to those objects.

## See also

- [Access data in Visual Studio](../data-tools/accessing-data-in-visual-studio.md)
