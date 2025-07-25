---
title: Data science and analytical applications workload
description: Review a Visual Studio workload that combines Python, F#, and their respective runtime distributions, including Anaconda, and also R for earlier versions of Visual Studio.
ms.date: 04/18/2024
ms.topic: overview
author: cwebster-99
ms.author: cowebster
manager: mijacobs
ms.subservice: python

# CustomerIntent: As a developer, I want to use the Data science and analytical applications workload in Visual Studio so I can work with multiple languages and runtime distributions.
---

# Data science and analytical applications workload in Visual Studio

The Data science and analytical applications workload in Visual Studio brings together several languages and their respective runtime distributions:

- [Python](../python/overview-of-python-tools-for-visual-studio.md)
- [F# with the .NET Framework](/dotnet/fsharp/)

Python is a primary scripting language used for data science. Python is easy to learn and has support from a rich ecosystem of packages. Those packages address a wide range of scenarios such as data acquisition, cleaning, model training, deployment, and plotting. F# is also a powerful functional-first .NET language applicable for a wide variety of data processing tasks.

:::image type="content" source="media/workload/data-science-workload-screens.png" alt-text="Screenshot that shows Visual Studio with R, Python, and F# code projects." border="false" lightbox="media/workload/data-science-workload-screens.png":::

## Workload installation

The Data science and analytical applications workload is available in the Visual Studio Installer under **Workloads** > **Other Toolsets**:

::: moniker range=">=vs-2022"

:::image type="content" source="media/workload/data-science-workload-2022.png" alt-text="Screenshot that shows how to select the Data science and analytics applications workload in the Visual Studio Installer." border="false" lightbox="media/workload/data-science-workload-2022.png":::

::: moniker-end
::: moniker range="<=vs-2019"

:::image type="content" source="media/workload/data-science-workload-2019.png" alt-text="Screenshot that shows how to select the Data science and analytics applications workload in the Visual Studio Installer 2019." border="false" lightbox="media/workload/data-science-workload-2019.png":::

::: moniker-end

By default, the workload installs the following options, which you can modify in the summary section for the workload in the Visual Studio Installer:

- F# desktop language support
- Python:
   - Python language support
   - Python web support
   - Python native development tools

## SQL Server integration

SQL Server supports using Python to do advanced analytics directly inside SQL Server. Python support is available in SQL Server 2017 CTP 2.0 and later.

You enjoy the following advantages by running your code where your data already lives:

- **Elimination of data movement**: Instead of moving data from the database to your application or model, you can build applications in the database. This capability eliminates barriers of security, compliance, governance, integrity, and a host of similar issues related to moving vast amounts of data. You can also consume datasets that don't fit into the memory of a client machine.

- **Easy deployment**: After you have a model ready, deploying it to production is a simple matter of embedding the model in a T-SQL script. Any SQL client application written in any language can then take advantage of the models and intelligence through a stored procedure call. No specific language integrations are necessary.

- **Enterprise-grade performance and scale**: You can use SQL Server's advanced capabilities like in-memory table and column-store indexes with the high-performance scalable APIs in the RevoScale packages. The elimination of data movement also means that you avoid client memory constraints as your data grows or you want to increase the performance of the application.

- **Rich extensibility**: You can install and run any of the latest open source packages in SQL Server to build deep learning and AI applications on huge amounts of data in SQL Server. Installing a package in SQL Server is as simple as installing a package on your local machine.

- **Wide availability at no additional cost**: Language integrations are available in all editions of SQL Server 2017 and later, including the Express edition.

## SQL Server integration installation

To take full advantage of SQL Server integration, use the Visual Studio Installer to install the **Workloads** > **Other Toolsets** > **Data storage and processing** workload. Select the **SQL Server Data Tools** option to enable SQL IntelliSense, syntax highlighting, and deployment:

::: moniker range=">=vs-2022"

:::image type="content" source="media/workload/data-storage-workload-2022.png" alt-text="Screenshot that shows how to select the Data storage and processing workload in the Visual Studio Installer." border="false" lightbox="media/workload/data-storage-workload-2022.png":::

::: moniker-end
::: moniker range="<=vs-2019"

:::image type="content" source="media/workload/data-storage-workload-2019.png" alt-text="Screenshot that shows how to select the Data storage and processing workload in the Visual Studio Installer 2019." border="false" lightbox="media/workload/data-storage-workload-2019.png":::

::: moniker-end

For more information, see [Python in SQL Server 2017: Enhanced in-database machine learning (blog)](https://blogs.technet.microsoft.com/dataplatforminsider/2017/04/19/python-in-sql-server-2017-enhanced-in-database-machine-learning/).

## Other services and SDKs

In addition to what's in the Data science and analytics applications workload directly, Notebooks in Visual Studio Code and the Azure SDK for Python are also helpful for data science.

The Azure SDK for Python makes it easy to consume and manage Microsoft Azure services from applications running on Windows, Mac, and Linux. For more information, see [Azure for Python Developers](/azure/developer/python/).

You can combine the Jupyter extension with Notebooks in Visual Studio Code to support Jupyter development and enhance your project with extra language extensions. The service includes sample notebooks in Python, R, and F# to get you started. For more information, see [Notebooks experiences from Microsoft and GitHub](https://visualstudio.microsoft.com/vs/features/notebooks-at-microsoft/).

:::image type="content" source="media/workload/data-science-workload-notebooks.png" alt-text="Screenshot that shows the use of Notebooks with Jupyter in an introduction to R sample." border="false" lightbox="media/workload/data-science-workload-notebooks.png":::
