---
title: "Manage Load Test Results"
ms.date: 10/19/2016
ms.topic: conceptual
helpviewer_keywords:
  - "load tests, results repository"
  - "results, load test"
  - "load test results, repository"
  - "Load Test Results Repository"
ms.assetid: 1cd63c4b-4f74-4133-b675-5e8fbeab25f3
author: jillre
ms.author: jillfra
manager: jillfra
---
# Manage load test results in the Load Test Results Repository

When you run your load tests, any information gathered during a load test run may be stored in the *Load Test Results Repository*, which is a SQL database. The Load Test Results Repository contains performance counter data and any information about recorded errors. The Results Repository database is created by setup for controllers, or created automatically on the first local run of a load test. For a local run, the database will be created automatically if the load test schema is not present.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

If you modify the controller's results repository connection string to use a different server, the new server must have the *loadtestresultsrepository.sql* script run to create the schema.

Visual Studio Enterprise provides named counter sets which collect common performance counters based on a technology. These sets are useful when you are analyzing an IIS server, an ASP.NET server, or a SQL server. All of the data collected with counter sets is stored in the Load Test Results Repository.

> [!IMPORTANT]
> There is a difference between a counter set and the performance counter data. A counter set is metadata. It defines a group of performance counters that should be collected from a computer that is performing a particular role such as IIS or SQL Server. The counter set is part of the load test definition. Performance counter data is collected based on the counter sets, the mapping of the counter set to a specific computer, and the sample rate.

## SQL Server versions

To use load tests, you can use SQL Server Express LocalDB, which is installed with Visual Studio. It is the default database server for load tests (including Microsoft Excel integration). SQL Server Express LocalDB is an execution mode of SQL Server Express that is targeted to program developers. SQL Server Express LocalDB installation copies a minimal set of files necessary to start the SQL Server Database Engine.

If your team expects heavy database needs, or your projects outgrow SQL Server Express LocalDB, you should consider upgrading to either SQL Express or full SQL Server to provide further scaling potential. If you upgrade SQL Server, the MDF and LDF files for the SQL Server Express LocalDB are stored in the user profile folder. These files can be used to import the load test database to SQL Server Express or SQL Server.

## Load test results store considerations

When Visual Studio Enterprise is installed, the load test results store is set up to use an instance of SQL Express that is installed on the computer. SQL Express is limited to using a maximum of 4 GB of disk space. If you will run many load tests over a long period of time, you should consider configuring the load test results store to use an instance of the full SQL Server product if available.

## Load Test Analyzer tasks

|Tasks|Associated topics|
|-|-----------------------|
|**Set up a load test results repository:** You can set up a load test results repository on a SQL database. **Note:**  A load test repository can also be created when you install a test controller. For more information, see [Install and configure test agents](../test/lab-management/install-configure-test-agents.md).||
|**Selecting and viewing a results repository:** You can select a specific results repository. You are not limited to a local results store. Frequently, load tests are run on a remote set of Agent computers. Test results from your agents or your local computer can be saved to any SQL server on which you have created a load test results store. In either case, you must identify where to store your load test results by using the **Administer Test Controllers** window.|-   [How to: Select a load test results repository](../test/how-to-select-a-load-test-results-repository.md)<br />-   [How to: Access load test results for analysis](../test/how-to-access-load-test-results-for-analysis.md)|
|**Deleting a load test result from the repository:** You can remove a load test result from the **Load Test Editor** by using the **Open and Manage Load Test Results** dialog box.|-   [How to: Delete load test results from a repository](../test/how-to-delete-load-test-results-from-a-repository.md)|
|**Import and export results into a repository:** You can import and export load test results from the **Load Test Editor**.|-   [How to: Import load test results into a repository](../test/how-to-import-load-test-results-into-a-repository.md)<br />-   [How to: Export load test results from a repository](../test/how-to-export-load-test-results-from-a-repository.md)|

## Related tasks

[Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)

You can view the results of both a running load test and a completed load test by using the **Load Test Analyzer**.

## See also

- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [How to: Access load test results for analysis](../test/how-to-access-load-test-results-for-analysis.md)