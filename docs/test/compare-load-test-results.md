---
title: Comparing load test results
description: Learn how to generate Excel load test reports that are based on two or more test results, including run comparison reports and trend reports.
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
helpviewer_keywords: 
  - load tests, reporting
  - load tests, results
ms.assetid: 31874114-459a-45d5-9f8b-2ea503627db8
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Report load tests results for test comparisons or trend analysis

You can generate Microsoft Excel load test reports that are based on two or more test results.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

Two types of load test reports are available:

- Run comparison&mdash;This report is actually two reports that display side-by-side comparison data using tables and bar charts.

- Trend&mdash;You can generate trend analysis on two or more reports. The results are displayed using line charts.

Either report can be used to share performance data with stakeholders and convey whether the overall performance and health of the system is getting better or worse.

Report definitions are stored in the load test database. When a report is saved, the definition for the report is saved in the database and can be reused later.

Also, the spreadsheet file can be shared with stakeholders so that stakeholders do not have to connect to the database to see the report.

> [!NOTE]
> If you add comments to a load test, they appear in the Excel report.

## Tasks

|Tasks|Associated topics|
|-|-|
|**Create a performance and stress report:** You can create reports on your load and web performance tests, using Microsoft Excel.|- [How to: Create load test performance reports using Microsoft Excel](../test/how-to-create-load-test-performance-reports-using-microsoft-excel.md)|
|**Manually create a performance and stress report by using Microsoft Word:** You can create reports on your load and web performance tests manually by copying and pasting summary, table, and graph data to a Microsoft Word document.|- [How to: Manually create a load test performance report using Microsoft Word](../test/how-to-manually-create-a-load-test-performance-report-using-microsoft-word.md)|

## See also

- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
