---
title: "Create a web performance and load test project in Visual Studio"
ms.date: 03/14/2018
ms.topic: quickstart
helpviewer_keywords:
  - "load testing, quickstart"
author: gewarren
ms.author: gewarren
manager: douge
ms.prod: visual-studio-dev15
ms.technology: vs-ide-test
---
# Quickstart: Create a load test project

In this 10-minute quickstart, you'll learn how to create and run a Web performance and load test project in Visual Studio. Load tests execute Web performance or unit tests to simulate many users accessing a server at the same time.

> [!IMPORTANT]
> Web performance and load test projects are only available in the Enterprise edition of Visual Studio 2017.

## Install the load testing component

If you don't already have the Web performance and load testing tools component installed, you'll need to install it through the Visual Studio Installer.

1. Open Visual Studio Installer from the Start menu of Windows. You can also access it in Visual Studio from the **New Project** dialog box, or by choosing **Tools** > **Get Tools and Features...** from the menu bar.

1. In the Visual Studio Installer, choose the **Individual components** tab, and scroll down to the **Debugging and testing** section. Select **Web performance and load testing tools**.

   ![Web performance and load testing tools component](media/web-perf-load-testing-tools-component.png)

1. Choose the **Modify** button.

   The Web performance and load testing tools component is installed.

## Create a load test project

In this section, we'll create a C# load test project. You can also create a Visual Basic load test project, if you prefer.

1. Open Visual Studio, and choose **File** > **New** > **Project...** from the menu bar.

   The **New Project** dialog box opens.

1. In the **New Project** dialog box, expand **Installed** and **Visual C#**, and then select the **Test** category. Choose the **Web Performance and Load Test Project** template.

   ![Web performance and load test project template](media/web-perf-load-test-project-template.png)

1. Enter a name for the project if you don't want to use the default name, and then choose **OK**.

   Visual Studio creates the project, and displays the files in **Solution Explorer**. The project initially contains one Web test file named *WebTest1.webtest*.

## Add a load test to the project

1. From the right-click menu, or context menu, of the project node in **Solution Explorer**, choose **Add** > **Load Test...**.

   The **New Load Test Wizard** opens.

1. Select the **On-premises Load Test** option, and then choose **Next**. You can learn more about cloud-based load testing [here](/vsts/load-test/get-started-simple-cloud-load-test).

   ![New load test wizard - first page](media/load-test-wizard-page-1.png)

1. Choose **Next** to step through the wizard until you reach the **Add tests to a load test scenario and edit the test mix** page. Choose the **Add** button.

   The **Add Tests** dialog box opens.

1. Under **Available tests**, select **WebTest1**, and then choose the right arrow to move it over to the **Selected tests** box. Choose the **OK** button.

   ![Add Tests dialog box](media/add-tests-dialog-box.png)

1. Back in the **New Load Test Wizard**, choose the **Finish** button.

   The load test is added to the project, and the load test file opens in the editor window.

## Run the load test

We've created a load test that doesn't do very much, but let's run it anyway.

From the right-click menu, or context menu, of the load test that's open in the editor, choose **Run Load Test**.

![Run Load Test menu](media/run-load-test.png)

The load test starts running. The **Test Results** window shows that the test is in progress, and the load test analyzer is displayed in the editor window. After the test completes, which should be five minutes if you accepted the defaults, a summary is shown in the editor. You can choose **Graphs**, **Tables**, or **Detail** to get different information about the results of the load test.

![Load test analyzer window](media/load-test-analyzer.png)

## Next steps

Now that you've created a simple load test project, the next step is to configure scenarios, counter sets, and run settings.

> [!div class="nextstepaction"]
> [Edit test settings](edit-load-tests.md)