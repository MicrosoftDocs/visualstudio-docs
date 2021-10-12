---
title: Extend Coded UI Tests and Action Recordings
description: Learn how to create an extension to the coded UI test framework for your specific UI by taking advantage of the extensibility of the coded UI test framework.
ms.custom: SEO-VS-2020
ms.date: 11/04/2016
ms.topic: how-to
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-test
ms.workload: 
  - multiple
author: mikejo5000
---
# Extend coded UI tests and action recordings

The testing framework for coded UI tests and action recordings does not support every possible user interface. It might not support the specific UI that you want to test. For example, you cannot immediately create a coded UI test or an action recording for a Microsoft Excel spreadsheet. However, you can create your own extension to the coded UI test framework that supports your specific UI by taking advantage of the extensibility of the coded UI test framework.

![UI Test Architecture](../test/media/ui_testarch.png)

[!INCLUDE [coded-ui-test-deprecation](includes/coded-ui-test-deprecation.md)]

## Sample extension to test Microsoft Excel

This [blog post](/archive/blogs/gautamg/3-introducing-sample-excel-extension) contains a link to a sample extension for the coded UI test framework. You can also view the entire [blog post series for coded UI test extensibility](/archive/blogs/gautamg/series-on-coded-ui-test-extensibility).

> [!NOTE]
> The sample is intended for use with Microsoft Excel 2010. It may or may not work with other versions of Excel.

## See also

- <xref:Microsoft.VisualStudio.TestTools.UITesting.UITestPropertyProvider>
- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITechnologyElement>
- [UITestActionFilter](/previous-versions/visualstudio/visual-studio-2012/dd985757(v=vs.110))
- <xref:Microsoft.VisualStudio.TestTools.UITest.Extension.UITestExtensionPackage>
- [Use UI automation to test your code](../test/use-ui-automation-to-test-your-code.md)
- [Best practices for coded UI tests](../test/best-practices-for-coded-ui-tests.md)
- [Supported configurations and platforms for coded UI tests and action recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)