---
title: Debug HTML and CSS in UWP apps | Microsoft Docs
description: Know how to debug HTML and CSS in Universal Windows Platform (UWP) apps in Visual Studio. JavaScript debugging features are supported for UWP apps.
ms.custom: SEO-VS-2020
ms.date: 07/17/2018
ms.topic: how-to
f1_keywords:
  - VS.WebClient.DomExplorer
dev_langs:
  - JavaScript
helpviewer_keywords:
  - debugging, CSS
  - debugging, HTML
  - debugging, JavaScript [UWP apps]
  - DOM Explorer [UWP apps]
author: mikejo5000
ms.author: mikejo
manager: jmartens
ms.technology: vs-ide-debug
monikerRange: vs-2017
ms.workload:
  - uwp
---
# Debug HTML and CSS in UWP apps in Visual Studio

For JavaScript apps, Visual Studio provides a comprehensive debugging experience that includes features that are familiar to Internet Explorer and Visual Studio developers. These features are supported for UWP apps and for apps created using Visual Studio Tools for Apache Cordova.

Using the interactive debugging model provided by the DOM inspection tools, you can view and modify the rendered HTML and CSS code. You can do all this without stopping and restarting the debugger.

For info on other JavaScript debugging features, such as using the JavaScript Console window and setting breakpoints, see [QuickStart: Debug JavaScript](../debugger/quickstart-debug-javascript-using-the-console.md) and [Debug apps in Visual Studio](debugging-windows-store-and-windows-universal-apps.md).

## <a name="InspectingDOM"></a> Inspecting the live DOM
DOM Explorer shows you a view of the rendered page, and you can use DOM Explorer to change values and immediately see the results. This enables you to test changes without stopping and restarting the debugger. The source code in your project doesn't change when you interact with the page by using this method, so when you find the desired code corrections, you make the changes to your source code.

> [!TIP]
> To avoid stopping and restarting the debugger when you make changes to your source code, you can refresh your app by using the **Refresh Windows app** button on the Debug toolbar (or by pressing F4). For more info, see [Refresh an app (JavaScript)](../debugger/refresh-an-app-javascript.md).

You can use DOM Explorer to:

- Navigate the DOM element subtree and inspect rendered HTML, CSS, and JavaScript code.

- Dynamically edit attributes and CSS styles for rendered elements and immediately see the results.

- Inspect how CSS styles have been applied to page elements, and trace the rules that have been applied.

  When debugging apps, you often need to select elements in DOM Explorer. When you select an element, the values that appear on the tabs on the right side of the DOM Explorer automatically update to reflect the selected element in DOM Explorer. These are the tabs: **Styles**, **Computed**, **Layout**. UWP apps also support the **Events** and **Changes** tabs. For more info about selecting elements, see [Selecting elements](#SelectingElements).

> [!TIP]
> If the DOM Explorer window is closed, choose **Debug**>**Windows** > **DOM Explorer** to re-open it. The window only appears during a script debugging session.

In the procedure that follows, we'll go through the process of interactively debugging an app by using DOM Explorer. We'll create an app that uses a `FlipView` control and then debug it. The app contains several errors.

> [!WARNING]
> The following sample app is a UWP app. The same features are supported for Cordova, but the app would be different.

#### To debug by inspecting the live DOM

1. Create a new solution in Visual Studio by choosing **File** > **New Project**.

2. Choose **JavaScript** > **Windows Universal**, and then choose **WinJS App**.

3. Type a name for the project, such as `FlipViewApp`, and choose **OK** to create the app.

4. In the BODY element of index.html, add this code:

    ```html
    <div id="flipTemplate" data-win-control="WinJS.Binding.Template"
            style="display:none">
        <div class="fixedItem" >
            <img src="#" data-win-bind="src: flipImg" />
        </div>
    </div>
    <div id="fView" style="width:100px;height:100px"
        data-win-control="WinJS.UI.FlipView" data-win-options="{
        itemDataSource: Data.items.dataSource, itemTemplate: flipTemplate }">
    </div>
    ```

5. Open default.css, and add the following CSS:

    ```css
    #fView {
        background-color:#0094ff;
        height: 100%;
        width: 100%;
        margin: 25%;
    }
    ```

6. Replace the code in default.js with this code:

    ```javascript
    (function () {
        "use strict";

        var app = WinJS.Application;
        var activation = Windows.ApplicationModel.Activation;

        var myData = [];
        for (var x = 0; x < 4; x++) {
            myData[x] = { flipImg: "/images/logo.png" }
        };

        var pages = new WinJS.Binding.List(myData, { proxy: true });

        app.onactivated = function (args) {
            if (args.detail.kind === activation.ActivationKind.launch) {
                if (args.detail.previousExecutionState !==
                activation.ApplicationExecutionState.terminated) {
                    // TODO: . . .
                } else {
                    // TODO: . . .
                }
                args.setPromise(WinJS.UI.processAll());

                updateImages();
            }
        };

        function updateImages() {

            pages.setAt(0, { flipImg: "http://public-domain-photos.com/free-stock-photos-1/flowers/cactus-76.jpg" });
            pages.setAt(1, { flipImg: "http://public-domain-photos.com/free-stock-photos-1/flowers/cactus-77.jpg" });
            pages.setAt(2, { flipImg: "http://public-domain-photos.com/free-stock-photos-1/flowers/cactus-78.jpg" });
        };

        app.oncheckpoint = function (args) {
        };

        app.start();

        var publicMembers = {
            items: pages
        };

        WinJS.Namespace.define("Data", publicMembers);

    })();
    ```

    The following illustration shows what we want to see if we run this app. However, to get the app into this state we will have to fix a number of bugs first.

    ![FlipView app showing expected results](../debugger/media/js_dom_appfixed.png "JS_DOM_AppFixed")

7. Choose **Local Machine** from the drop-down list next to the **Start Debugging** button on the **Debug** toolbar:

    ![Select debug target list](../debugger/media/js_select_target.png "JS_Select_Target")

8. Choose **Debug** > **Start Debugging**, or press F5, to run your app in debug mode.

    This runs the app, but you'll see a mostly blank screen because the styling has a few bugs in it. The first `FlipView` image appears in a small square near the middle of the screen.

9. Switch to Visual Studio and choose the **DOM Explorer** tab.

    > [!TIP]
    > You can press Alt+Tab or F12 to switch between Visual Studio and the running app.

10. In the DOM Explorer window, select the DIV element for the section that has an ID of `"fView"`. Use the arrow keys to view and select the correct DIV element. (The right arrow key allows you to view an element's children.)

    ![DOM Explorer](../debugger/media/js_dom_explorer.png "JS_DOM_Explorer")

    > [!TIP]
    > You can also select the DIV element in the lower left corner of the JavaScript Console window by typing `select(fView)` at the >> input prompt and then pressing Enter.

    The values that appear on the tabs on the right side of the DOM Explorer window automatically update to reflect the current element in DOM Explorer.

11. Choose the **Computed** tab on the right.

    This tab shows the computed, or final, value for each property of the selected DOM element.

12. Open the height CSS rule. Notice that there's an inline style set to 100px, which appears inconsistent with the height value of 100% set for the `#fView` CSS selector. Strikethrough text for the `#fView` selector indicates that the inline style is taking precedence over this style.

    The following illustration shows the **Computed** tab.

    ![DOM Explorer Computed tab](../debugger/media/js_dom_explorer_computed.png "JS_DOM_Explorer_Computed")

13. In the main DOM Explorer window, double-click the inline style for the height and width of the `fView` DIV element. You can now edit the values here. In this scenario, we want to remove them completely.

14. In the main window, double-click `width: 100px;height: 100px;`, press the **Delete** key, and then press **Enter**. After you press Enter, the new values are immediately reflected in the app, although you haven't stopped your debugging session.

    > [!IMPORTANT]
    > As you can update attributes in the DOM Explorer window, you can also update values that appear on the **Styles**, **Computed**, and **Layout** tabs.

15. Switch to the app by selecting it or by using Alt+Tab.

    Now the `FlipView` control appears larger than the Simulator's or the Phone Emulator's screen size. This is not the intended result. To investigate, switch back to Visual Studio.

16. In the DOM Explorer, select the **Computed** tab again and open the height rule. The fView element still shows a value of 100%, as expected from the CSS, but the computed value is equal to the app's screen height (for example, 800px, 667.67px, or some other value), which is not what we want for this app. To investigate, in the next steps we remove the height and width for the `fView` DIV element.

17. In the **Styles** tab, uncheck the height and width properties for the `#fView` CSS selector.

    The **Computed** tab now shows a height of 400px. The information indicates that this value comes from the .win-flipview selector specified in ui-dark.css, which is a platform CSS file.

18. Switch back to the app.

    Things have improved. However, there is still one more problem to fix: the margins appear too large.

19. To investigate, switch to Visual Studio and choose the **Layout** tab to look at the element's box model.

    In the **Layout** tab, you'll see the following:

    - 255px (Offset) and 255px (Margin) or similar values, depending on your device resolution.

      The following illustration shows how the **Layout** tab looks if you're using an emulator with 100px offset and margin).

      ![DOM Explorer Layout tab](../debugger/media/js_dom_explorer_layout.png "JS_DOM_Explorer_Layout")

      This doesn't seem right. The **Computed** tab also shows the same margin values.

20. Choose the **Styles** tab and locate the `#fView` CSS selector. Here, you see a value of 25% for the **margin** property.

21. Select the 25% and change it to 25px, and press Enter.

22. Also in the **Styles** tab, choose the height rule for the .win-flipview selector and change 400px to 500px, and press Enter.

23. Switch back to the app and you see that the placement of elements appears correct. To make fixes to the source and refresh the app without stopping and restarting the debugger, see the following procedure.

#### To refresh your app while debugging

1. While the app is still running, switch to Visual Studio.

2. Open default.html and modify your source code by changing the height and width of the `"fView"` DIV element to 100%.

3. Choose the **Refresh Windows app** button on the Debug toolbar (or press F4). The button looks like this: ![Refresh Windows app button](../debugger/media/js_refresh.png "JS_Refresh").

    The app pages reload and the Simulator or Phone Emulator returns to the foreground.

    For more info about the Refresh feature, see [Refresh an app (JavaScript)](../debugger/refresh-an-app-javascript.md).

## <a name="SelectingElements"></a> Selecting elements
You can select DOM elements in three ways when debugging an app:

- By clicking on elements directly in the DOM Explorer window (or by using the arrow keys).

- By using the **Select Element** button (Ctrl+B).

- By using the `select` command, which is one of the [JavaScript Console commands](../debugger/javascript-console-commands.md?view=vs-2017&preserve-view=true).

  When you use the DOM Explorer window to select elements, and rest the mouse pointer on an element, the corresponding element is highlighted in the running app. You must click on the element in DOM Explorer to select it, or you can use the arrow keys to highlight and select elements.You can also select elements in DOM Explorer by using the **Select element** button. The following illustration shows the **Select Element** button.

  ![Select Element Button in DOM Explorer](../debugger/media/js_dom_select_element_button.png "JS_DOM_Select_Element_Button")

  When you click **Select element** (or press Ctrl+B), this changes the selection mode so that you can select an item in DOM Explorer by clicking it in the running app. The mode changes back to normal selection mode after a single click. When you click **Select element**, the app comes to the foreground and the cursor changes to reflect the new selection mode. When you click the outlined element, DOM Explorer returns to the foreground with the specified element selected.

  Before you choose **Select Element**, you can specify whether to highlight elements in the running app by toggling the **Display web page highlights** button. The following illustration shows this button. Highlights are displayed by default.

  ![Display web page highlights button](../debugger/media/js_dom_display_highlights_button.png "JS_DOM_Display_Highlights_Button")

  When you choose to highlight elements, elements that you hover over in the Simulator are highlighted. Colors for highlighted elements match the box model that appears in the **Layout** tab of DOM Explorer.

> [!NOTE]
> Highlighting elements by hovering over them is only partially supported in the Windows Phone Emulator.

## See also

- [Debug apps in Visual Studio](debugging-windows-store-and-windows-universal-apps.md)
- [Refresh an app (JavaScript)](../debugger/refresh-an-app-javascript.md)
- [Debug a WebView control](../debugger/debug-a-webview-control.md)
- [Keyboard shortcuts](../debugger/keyboard-shortcuts-html-and-javascript.md?view=vs-2017&preserve-view=true)
- [JavaScript Console commands](../debugger/javascript-console-commands.md?view=vs-2017&preserve-view=true)
- [Debug HTML, CSS, and JavaScript sample code](../debugger/debug-html-css-and-javascript-sample-code.md)
- [Product Support and Accessibility](/previous-versions/tzbxw1af(v=vs.120))