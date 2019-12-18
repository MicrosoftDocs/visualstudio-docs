---
title: "Testing SharePoint 2010 Applications with Coded UI Tests | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
ms.assetid: 51b53778-469c-4cc9-854c-4e4992d6389b
caps.latest.revision: 32
ms.author: jillfra
manager: jillfra
---
# Testing SharePoint 2010 Applications with Coded UI Tests
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Including coded UI tests in a SharePoint application lets you verify that the whole application, including its UI controls, is functioning correctly. Coded UI tests can also validate values and logic in the user interface.

 **Requirements**

- Visual Studio Enterprise

## What else should I know about coded UI tests?
 To learn more about the benefits of using coded UI tests, see [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md) and [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 5 Automating System Tests](https://go.microsoft.com/fwlink/?LinkID=255196).

 **Notes**

- ![Prerequsite](../test/media/prereq.png "Prereq") Coded UI tests for SharePoint applications are supported only with SharePoint 2010.

- ![Prerequsite](../test/media/prereq.png "Prereq") Support for Visio and PowerPoint 2010 controls in your SharePoint application is not supported.

## Creating a coded UI test for your SharePoint app
 [Creating coded UI tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate) for your SharePoint 2010 applications is the same as creating tests for other types of applications. Record and Playback is supported for all controls on the Web Editing interface. The interface for selecting categories and web parts are all standard web controls.

 ![SharePoint web parts](../test/media/cuit-sharepoint.png "CUIT_SharePoint")

> [!NOTE]
> If you are recording action, validate the actions before generating code. Since there are several behaviors associated with Mouse hover, it is on by default. Be careful to remove redundant hovers from your coded UI tests. You can do this by editing the code for the test, or by using the [Coded UI Test Editor](../test/editing-coded-ui-tests-using-the-coded-ui-test-editor.md).

## Including testing of Office 2010 controls within your SharePoint app
 To enable automation for some office 2010 web parts in your SharePoint app, you have to make some minor code modifications.

> [!WARNING]
> Support for Visio and PowerPoint 2010 controls is not supported.

### Excel 2010 cell controls
 To include Excel cell controls, you must make some changes in the coded UI test’s code.

> [!WARNING]
> Entering text in any Excel cell, followed by an arrow key action, does not record correctly. Use the mouse to select cells.

 If you are recording actions on an empty cell, you must modify the code by double clicking on the cell and then performing a set text operation. This is needed because a click on the cell, followed by any keyboard action activates the `textarea` within the cell. Simply recording a `setvalue` on the empty cell would search for the `editbox` which is not present until the cell has been clicked. For example:

```csharp
Mouse.DoubliClick(uiItemCell,new Point(31,14));
uiGridKeyboardInputEdit.Text=value;
```

 If you are recording actions on a non-empty cell, then recording gets a little more complicated, because the moment you add text to a cell, a new \<div> control is added as a child of the cell. The new \<div> control contains the text that you just entered. The recorder needs to record actions on the new \<div> control; however, it can’t because the new \<div> control does not exist until after the test is entered. You must manually make the following code changes to accommodate this issue.

1. Go to cell initialization and make `RowIndex` and `ColumnIndex` primary properties:

    ```csharp
    this.mUIItemCell.SearchProperties[HtmlCell.PropertyNames. RowIndex] = "3";
    this.mUIItemCell.SearchProperties[HtmlCell.PropertyNames. ColumnIndex] = "3";
    ```

2. Find the `HtmlDiv` child of the cell:

    ```csharp
    private UITestControl getControlToDoubleClick(HtmlCell cell)
    {
         if (String.IsNullOrEmpty(cell.InnerText)) return cell;
         HtmlDiv pane = new HtmlDiv(cell);
         pane.FilterProperties[HtmlDiv.PropertyNames.InnerText] = cell.InnerText;
         // Class is an important property in finding pane
         pane.FilterProperties[HtmlDiv.PropertyNames.Class] = "cv-nwr";
         UITestControlCollection panes = pane.FindMatchingControls();
         return panes[0];
    }

    ```

3. Add code for a mouse double-click action on `HtmlDiv`:

    ```csharp
    Mouse.DoubleClick(uIItemPane, new Point(31, 14)); )
    ```

4. Add code to set text on `TextArea`:

    ```csharp
    uIGridKeyboardInputEdit.Text = value; }
    ```

## Enabling coded UI testing of Silverlight web parts in your SharePoint 2010 app
 Silverlight testing isn't supported in Visual Studio 2012 and later. But, if you want to test the Silverlight web parts in your SharePoint 2010 app, you can install a separate Silverlight plug-in from the Visual Studio Gallery.

#### Setting up your machine

1. Make sure that you have Visual Studio 2012.1 or later installed.

2. Install the [Microsoft Visual Studio UI Test Plugin for Silverlight](https://marketplace.visualstudio.com/items?itemName=PrachiBoraMSFT.MicrosoftVisualStudioUITestPluginforSilverlight).

3. Install [Fiddler](http://www.fiddler2.com/fiddler2/). This is simply a tool that captures and logs the HTTP traffic.

4. Download the [fiddlerXap project](https://40jajy3iyl373v772m19fybm-wpengine.netdna-ssl.com/wp-content/uploads/sites/6/2019/02/FiddlerXapProxy.zip). Unzip it, build it, and run the “CopySLHelper.bat” script to install the helper DLL that is required to test Silverlight web parts when you use the Fiddler tool.

   After setting up your machine, to start testing your SharePoint 2010 app with Silverlight web parts, follow these steps:

#### Testing Silverlight web parts

1. Start Fiddler.

2. Clear the browser cache. This is necessary because the XAP file, which contains the Silverlight UI Automation Helper DLL, is typically cached. We have to make sure that the modified XAP file is picked up, so we clear the browser cache.

3. Open the web page.

4. Start the recorder and generate code like you would for a regular web application testing.

5. You should confirm that the generated code references the Microsoft.VisualStudio.TestTools.UITest.Extension.Silverlight.dll.

     For more information, see [UI Testing SharePoint 2010 with Visual Studio 2012](https://devblogs.microsoft.com/devops/ui-testing-sharepoint-2010-with-visual-studio-2012/)

## External resources

### Blogs
 [UI Testing SharePoint 2010 with Visual Studio 2012](https://devblogs.microsoft.com/devops/ui-testing-sharepoint-2010-with-visual-studio-2012/)

 [Understanding the Search logic for Silverlight controls in Coded UI Test](https://tapas-techsnips.blogspot.com/)

 [Fetching Property of a Silverlight control](https://tapas-techsnips.blogspot.com/)

 [Content Index for Coded UI Test](https://blogs.msdn.microsoft.com/mathew_aniyan/2013/02/18/content-index-for-coded-ui-test/)

### Guidance
 [Testing for Continuous Delivery with Visual Studio 2012 – Chapter 5 Automating System Tests](https://go.microsoft.com/fwlink/?LinkID=255196)

### Forum
 [Visual Studio ALM + Team Foundation Server Blog](https://go.microsoft.com/fwlink/?LinkID=254496)

## See Also
 [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)
 [Web performance and load testing SharePoint 2010 and 2013 applications](https://msdn.microsoft.com/library/20c2e469-0e4e-4296-a739-c0e8fff36e54)
 [Create SharePoint Solutions](https://msdn.microsoft.com/library/4bfb1e59-97c9-4594-93f8-3068b4eb9631)
 [Verifying and Debugging SharePoint Code](https://msdn.microsoft.com/library/b5f3bce2-6a51-41b1-a292-9e384bae420c)
 [Building and Debugging SharePoint Solutions](https://msdn.microsoft.com/library/c9e7c9ab-4eb3-40cd-a9b9-6c2a896f70ae)
 [Profiling the Performance of SharePoint Applications](https://msdn.microsoft.com/library/61ae02e7-3f37-4230-bae1-54a498c2fae8)
