---
title: Create custom code and plug-ins for load tests
description: Learn how to use the load test API and the web performance test API to create custom plug-ins for tests to expand to the built-in functionality. 
ms.custom: SEO-VS-2020
ms.date: 10/19/2016
ms.topic: how-to
f1_keywords: 
  - vs.test.dialog.recorderplugin
helpviewer_keywords: 
  - Web performance tests, plug-ins
  - load tests, plug-ins
ms.assetid: 0c0fcc99-673b-4ea0-a268-0475f66e5cb6
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
---
# Create custom code and plug-ins for load tests

A custom plug-in uses code that you write and attach to a load test or a web performance test. You can use the load test API and the web performance test API to create custom plug-ins for tests to expand to the built-in functionality. You can add multiple plug-ins to your load test.

[!INCLUDE [web-load-test-deprecated](includes/web-load-test-deprecated.md)]

## Tasks

|Tasks|Associated topics|
|-|-----------------------|
|**Create a custom plug-in for your load test**: You can use load test API to create a custom plug-in to add more testing functionality to your load test.|-   [How to: Use the load test API](../test/how-to-use-the-load-test-api.md)<br />-   [How to: Create a load test plug-in](../test/how-to-create-a-load-test-plug-in.md)|
|**Create a custom plug-in for your Web Performance test:** You can use web performance test API to create a custom plug-in to add more testing functionality to your web performance test, including at the request level. You can also create a web service test.<br /><br /> Additionally, you can create a web recorder plug-in that can modify a web performance test after it is recorded, but before it appears in the Web Performance Test Result Viewer.|-   [How to: Use the web performance test API](../test/how-to-use-the-web-performance-test-api.md)<br />-   [How to: Create a web performance test plug-in](../test/how-to-create-a-web-performance-test-plug-in.md)<br />-   [How to: Create a request-level plug-in](../test/how-to-create-a-request-level-plug-in.md)<br />-   [How to: Create a web service test](../test/how-to-create-a-web-service-test.md)<br />-   [How to: Create a recorder plug-in](../test/how-to-create-a-recorder-plug-in.md)|
|**Add UI features to Web Performance Test Results Viewer:** You can add more UI features to the Web Performance Test Results Viewer using a Visual Studio add-in.|-   [How to: Create a Visual Studio add-in for the web performance test results viewer](../test/how-to-create-an-add-in-for-the-web-performance-test-results-viewer.md)|
|**Create a custom HTTP body editor:** You can create a custom editor to edit binary or string http XML responses from a web service.|-   [How to: Create a custom HTTP body editor for the web performance test editor](../test/how-to-create-a-custom-http-body-editor-for-the-web-performance-test-editor.md)|

## Reference

<xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestPlugin>

<xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRequestPlugin>

<xref:Microsoft.VisualStudio.TestTools.LoadTesting.ILoadTestPlugin>

<xref:Microsoft.VisualStudio.TestTools.WebTesting.WebTestRecorderPlugin>

<xref:Microsoft.VisualStudio.TestTools.LoadTesting>

## See also

- [Analyze load test results](../test/analyze-load-test-results-using-the-load-test-analyzer.md)
- [Generate and run a coded web performance test](../test/generate-and-run-a-coded-web-performance-test.md)
