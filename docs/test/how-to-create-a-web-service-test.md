---
title: Create web service test to locate web service pages
description: Learn how to use a performance test for web services and customize requests in the Web Performance Test Editor to locate web service pages.
ms.date: 08/03/2023
ms.topic: how-to
helpviewer_keywords: 
  - Web performance tests, creating Web service tests
  - Web services [Visual Studio ALM], creating
  - service tests, Web
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: test-tools
---
# Create a web service test

You can use a web performance test to test web services. For the most current documentation, see [How to create a web service test](/previous-versions/visualstudio/visual-studio-2017/test/how-to-create-a-web-service-test).

>[!NOTE]
> Web performance and load test functionality is deprecated in Visual Studio 2019. For Application Insights, multi-step web tests depend on Visual Studio webtest files. It was [announced](https://devblogs.microsoft.com/devops/cloud-based-load-testing-service-eol/) that Visual Studio 2019 will be the last version with webtest functionality. However, support has been extended to Visual Studio 2022. It's important to understand that while no new features will be added, webtest functionality in Visual Studio 2022 is still currently supported and will continue to be supported during the support lifecycle of the product. (You can run existing web/load tests, but the templates to create new ones were removed.) The Azure Monitor product team has addressed questions regarding the future of multi-step availability tests. We recommend using [Apache JMeter](https://jmeter.apache.org) in [Azure Load Test](https://azure.microsoft.com/services/load-testing/) as an alternative.

**Requirements**

* Visual Studio Enterprise
* Internet Explorer

>[!NOTE]
> Web performance and load test functionality only supports Internet Explorer which isn't available on Windows 11 and some versions of Windows 10. The web recorder feature is also deprecated because it requires Internet Explorer. Read more on [Internet Explorer Lifecycle policy](/lifecycle/faq/internet-explorer-microsoft-edge#what-is-the-lifecycle-policy-for-internet-explorer-).