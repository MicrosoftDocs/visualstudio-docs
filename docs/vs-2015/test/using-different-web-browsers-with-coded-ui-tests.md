---
title: "Using Different Web Browsers with Coded UI Tests | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: a859595f-6517-43f2-9d61-c706cb55a388
caps.latest.revision: 25
ms.author: jillfra
manager: jillfra
---
# Using Different Web Browsers with Coded UI Tests
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Coded UI tests can automate testing for web applications by recording your tests using Internet Explorer. You can then customize your test and play it back using either Internet Explorer or other browser types for these web applications.

 **Requirements**

- Visual Studio Enterprise

- Operating systems:

  - Microsoft Windows 7

  - Microsoft Windows 8

  - Microsoft Windows Server 2008 R2 SP1

- Web browser versions:

  - Windows Internet Explorer 9

  - Windows Internet Explorer 10

  - For supported versions of Mozilla Firefox and Google Chrome, go [here](https://marketplace.visualstudio.com/items?itemName=AtinBansal.SeleniumcomponentsforCodedUICrossBrowserTesting)

- Install the [Selenium components for Coded UI Cross Browser Testing](https://marketplace.visualstudio.com/items?itemName=AtinBansal.SeleniumcomponentsforCodedUICrossBrowserTesting).

  **What’s supported across all web browsers?**

- [Add custom code for controlling features](https://devblogs.microsoft.com/devops/coded-ui-test-configuring-search-properties-while-recording-on-internet-explorer/) such as properties, search, and playback waiters.

- Pop-ups and dialog boxes

- [Execute basic JavaScript with no return type](https://devblogs.microsoft.com/devops/introducing-javascript-execution-on-internetexplorer-and-crossbrowser-in-coded-ui-test/)

- Search resilience (using smart match) and [performance improvements](https://devblogs.microsoft.com/devops/guidelines-on-improving-performance-of-coded-ui-test-playback/)

## Why should I use coded UI tests across multiple web browser types?
 By testing your web application using a variety of web browser types, you better emulate the UI experience of your users who may run different browsers. For example, your application might include a control or code in Internet Explorer that is not compatible with other web browsers. By running your coded UI tests across other browsers, you can discover and correct any issue before it impacts your customers.

## How do I record and play back coded UI tests on web applications using the supported web browsers?
 **Recording:** You must use the Coded UI Test Builder to record your web application test using Internet Explorer. You can optionally add validation and custom code for the tested controls using a predefined set of properties as you would normally do for coded UI tests. For more information, see [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md).

> [!NOTE]
> You cannot record coded UI tests using Google Chrome or Mozilla Firefox browsers.

 **Play back with Internet Explorer:** When no browser is explicitly specified, tests will run on Internet Explorer by default. You can explicitly state the browser to be used by setting the **BrowserWindow.CurrentBrowser** property in your test code. For Internet Explorer, this property should be set to **IE** or **Internet Explorer**.

 **Play back with non-Internet Explorer web browsers:** To play back on non-Internet Explorer web browsers, change BrowserWindow.CurrentBrowser property in your test code to either **Firefox** or **Chrome**.

 To play back tests on non-IE web browsers, you must install the **Selenium components for Coded UI Cross Browser Testing**.

#### Installing Selenium components

1. On the **Tools** menu, choose **Extensions and Updates**.

2. In the Extension and Updates dialog box, search for `Selenium components for Cross Browser Testing`.

3. Highlight the extension and choose **Download**.

   > [!TIP]
   > You can also download the Selenium components for Coded UI Cross Browser Testing from [here](https://marketplace.visualstudio.com/items?itemName=AtinBansal.SeleniumcomponentsforCodedUICrossBrowserTesting).

   For more information about creating and using coded UI tests, see [Creating Coded UI Tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate).

### Enable debugging
 To enable debugging your web application, you must complete the following configuration options:

1. Enable Just My Code:

    1. On the **Tools** menu, choose **Options** and then choose **Debugging**.

    2. Select **Enable Just My Code**.

2. Disable CLR exceptions:

    1. On the **Debug** menu, choose **Exceptions**.

    2. For **Common Language Runtime Exceptions**, uncheck **User-unhandled**.

## <a name="generate"></a> *I don't see the option to change BrowserWindow.CurrentBrowser in the coded UI test.*
 You might be using a version of [!INCLUDE[vs2011_first](../includes/vs2011-first-md.md)] that does not support coded UI tests using various web browsers. To use such coded UI tests, you must use Visual Studio Enterprise.

 *What else should I know?*
 **Notes**

- ![Prerequsite](../test/media/prereq.png "Prereq") Apple Safari web browser is not supported.

- ![Prerequsite](../test/media/prereq.png "Prereq") The action of starting the web browser must be part of the coded UI test.

   If you have a web browser already open and you want to run steps on it, the playback will fail unless you are using Internet Explorer. Therefore, it is a best practice to include the startup of your web browser as part of your coded UI tests.

- ![Prerequsite](../test/media/prereq.png "Prereq") Automating browser specific based UI actions such as maximize, minimize and restore is not supported.

  **Tips**

- ![Tip](../test/media/tip.png "Tip") You can configure the output to include screenshots in the coded UI logs. To do so, you need to set some configuration settings in the QTAgent32.exe.config file. By default, this file is installed in the following location:

   **C:\Program Files (x86)\Microsoft Visual Studio 11.0\Common7\IDE**

   Set the following values:

  - `EqtTraceLevel` in the `system.diagnostics` section.

  - `<add name="EqtTraceLevel" value="4" />`

     By setting the value to be 3 or higher, screenshots are taken for each action. When the value is set to either 1 or 2, screenshots are taken for error actions only.

    For more information, see [Analyzing Coded UI Tests Using Coded UI Test Logs](../test/analyzing-coded-ui-tests-using-coded-ui-test-logs.md).

## External Resources

### Videos
 [Record on IE and Playback everywhere](https://skydrive.live.com/redir?resid=AE5CD7309CCCC43C!183&authkey=!ANqaLtCZbtJrImU)

 [Author cross browser tests with Coded UI Test Builder](https://skydrive.live.com/redir?resid=AE5CD7309CCCC43C!184&authkey=!AKG8CSow_qmeTq8)

 [Author cross browser tests using plain hand coding without UI Map](https://skydrive.live.com/redir?resid=AE5CD7309CCCC43C!186&authkey=!AJaEvxJnsefyAT4)

 [Run cross browser tests sequentially on multiple browsers](https://skydrive.live.com/redir?resid=AE5CD7309CCCC43C!187&authkey=!ADI8eCQkxHnpOR8)

 [Troubleshoot cross browser test failures](https://skydrive.live.com/redir?resid=AE5CD7309CCCC43C!182&authkey=!AEpS48i295B49FI)

### Guidance
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 2: Unit Testing: Testing the Inside](https://go.microsoft.com/fwlink/?LinkID=255188)

 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 5: Automating System Tests](https://go.microsoft.com/fwlink/?LinkID=255196)

### FAQ
 [Coded UI Tests FAQ - 1](https://go.microsoft.com/fwlink/?LinkID=230576)

 [Coded UI Tests FAQ -2](https://go.microsoft.com/fwlink/?LinkID=230578)

### Forum
 [Visual Studio UI Automation Testing (includes Coded UI)](https://go.microsoft.com/fwlink/?LinkID=224497)

## See Also
 [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)
 [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)
 [Analyzing Coded UI Tests Using Coded UI Test Logs](../test/analyzing-coded-ui-tests-using-coded-ui-test-logs.md)
