---
title: 'Walkthrough: Creating an SDK using JavaScript'
description: Learn how to use JavaScript to create a simple math SDK as a Visual Studio Extension by using this walkthrough.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Create an SDK using JavaScript

This walkthrough teaches how to use JavaScript to create a simple math SDK as a Visual Studio Extension (VSIX).  The walkthrough is divided into these parts:

- [To create the SimpleMathVSIX extension SDK project](../extensibility/walkthrough-creating-an-sdk-using-javascript.md#createSimpleMathVSIX)

- [To create a sample app that uses the SDK](../extensibility/walkthrough-creating-an-sdk-using-javascript.md#createSampleApp)

  For JavaScript, there is no class library project type. In this walkthrough, the sample *arithmetic.js* file is created directly in the VSIX project. In practice, we recommend that you first build and test the JavaScript and CSS files as a Windows Store app—for example, by using the **Blank App** template—before you put them in a VSIX project.

## Prerequisites
 To follow this walkthrough, you must install the Visual Studio SDK. For more information, see [Visual Studio SDK](../extensibility/visual-studio-sdk.md).

## <a name="createSimpleMathVSIX"></a> To create the SimpleMathVSIX extension SDK project

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the list of template categories, under **Visual C#**, select **Extensibility**, and then select the **VSIX Project** template.

3. In the **Name** text box, specify `SimpleMathVSIX` and choose the **OK** button.

4. If the **Visual Studio Package Wizard** appears, choose the **Next** button on the **Welcome** page, and then on **Page 1 of 7**, choose the **Finish** button.

     Although the **Manifest Designer** opens, we'll keep this walkthrough simple by modifying the manifest file directly.

5. In **Solution Explorer**, open the shortcut menu for the **source.extension.vsixmanifest** file, and then choose **View Code**. Use this code to replace the existing content in the file.

    ```xml
    <?xml version="1.0" encoding="utf-8"?>
    <PackageManifest Version="2.0.0" xmlns="http://schemas.microsoft.com/developer/vsx-schema/2011" xmlns:d="http://schemas.microsoft.com/developer/vsx-schema-design/2011">
      <Metadata>
        <Identity Id="SimpleMathVSIX" Version="1.0" Language="en-US" Publisher="myname" />
        <DisplayName>Simple Math</DisplayName>
        <Description>Does basic arithmetic calculations.</Description>
      </Metadata>
      <Installation Scope="Global" AllUsers="true">
        <InstallationTarget Id="Microsoft.ExtensionSDK" TargetPlatformIdentifier="Windows" TargetPlatformVersion="v8.0" SdkName="SimpleMath" SdkVersion="1.0" />
      </Installation>
      <Dependencies>
        <Dependency Id="Microsoft.Framework.NDP" DisplayName="Microsoft .NET Framework" d:Source="Manual" Version="4.5" />
      </Dependencies>
      <Assets>
        <Asset Type="Microsoft.ExtensionSDK" d:Source="File" Path="SDKManifest.xml" />
      </Assets>
    </PackageManifest>
    ```

6. In **Solution Explorer**, open the shortcut menu for the **SimpleMathVSIX** project, and then choose **Add** > **New Item**.

7. In the **Data** category, select **XML file**, name the file `SDKManifest.xml`, and choose the **Add** button.

8. In **Solution Explorer**, open the shortcut menu for the **SDKManifest.xml** file, and then choose **Open** to display the file in the **XML Editor**.

9. Add the following code to the **SDKManifest.xml** file.

    ```xml
    <?xml version="1.0" encoding="utf-8" ?>
    <FileList
      DisplayName="Simple Math"
      MinVSVersion="14.0"
      AppliesTo="JavaScript+WindowsAppContainer"
      SupportsMultipleVersions="Error"
      MoreInfo="https://msdn.microsoft.com/">

      <!-- JS -->
      <File Content="js\arithmetic.js" />
    </FileList>

    ```

10. In **Solution Explorer**, on the shortcut menu for the **SDKManifest.xml** file, choose **Properties**.

11. In the **Properties** window, set the **Include in VSIX** property to **True**.

12. In **Solution Explorer**, on the shortcut menu for the **SimpleMathVSIX** project, choose **Add** > **New Folder**, and then name the folder `Redist`.

13. Add subfolders under Redist to create this folder structure:

     *\Redist\CommonConfiguration\Neutral\SimpleMath\js\\*

14. On the shortcut menu for the **\js\\** folder, choose **Add** > **New Item**.

15. Under **Visual C# items**, select the **Web** category, and then select the **JavaScript File** item. Name the file `arithmetic.js`, and then choose the **Add** button.

16. Insert the following code into *arithmetic.js*:

    ```csharp
    (function (global) {
        "use strict";
        global.Arithmetic = {
            add: function (firstNumber, secondNumber) {
                return firstNumber + secondNumber;
            },

            subtract: function (firstNumber, secondNumber) {
                return firstNumber - secondNumber;
            },

            multiply: function (firstNumber, secondNumber) {
                return firstNumber * secondNumber;
            },

            divide: function (firstNumber, secondNumber) {
                return firstNumber / secondNumber;
            }
        };
    })(this);

    ```

17. In **Solution Explorer**, on the shortcut menu for the **arithmetic.js** file, choose **Properties**. Make these property changes:

    - Set the **Include in VSIX** property to **True**.

    - Set the **Copy to Output Directory** property to **Copy Always**.

18. In **Solution Explorer**, on the shortcut menu for the **SimpleMathVSIX** project, choose **Build**.

19. After the build completes successfully, on the shortcut menu for the project, choose **Open Folder in File Explorer**. Navigate to **\bin\debug\\**, and run `SimpleMathVSIX.vsix` to install it.

20. Choose the **Install** button and let the installation complete.

21. Restart Visual Studio.

## <a name="createSampleApp"></a> To create a sample app that uses the SDK

1. On the menu bar, choose **File** > **New** > **Project**.

2. In the list of template categories, under **JavaScript**, select **Windows Store**, and then select the **Blank App** template.

3. In the **Name** box, specify `ArithmeticUI`. Choose the **OK** button.

4. In **Solution Explorer**, open the shortcut menu for the **ArithmeticUI** project, and then choose **Add** > **Reference**.

5. Under **Windows**, choose **Extensions**, and notice that **Simple Math** is displayed.

6. Select the **Simple Math** check box and then choose the **OK** button.

7. In **Solution Explorer**, under **References**, notice that the **Simple Math** reference is displayed. Expand it and notice that there's a **\js\\** folder that includes **arithmetic.js**. You can open **arithmetic.js** to confirm that your source code was installed.

8. Use the following code to replace the contents of *default.htm*.

   ```html
   <!DOCTYPE html>
   <html>
   <head>
       <meta charset="utf-8" />
       <title>ArithmeticUI</title>

       <!-- WinJS references -->
       <link href="//Microsoft.WinJS.1.0/css/ui-dark.css" rel="stylesheet" />
       <script src="//Microsoft.WinJS.1.0/js/base.js"></script>
       <script src="//Microsoft.WinJS.1.0/js/ui.js"></script>

       <!-- ArithmeticUI references -->
       <link href="/css/default.css" rel="stylesheet" />
       <script src="/js/default.js"></script>
       <script src="/SimpleMath/js/arithmetic.js"></script>
   </head>
   <body>
       <form>
       <div id="calculator" class="ms-grid">
           <input name="firstNumber" id="firstNumber" type="number" step="any">
           <div id="operators">
               <button class="operator" type="button">+</button>
               <button class="operator" type="button">-</button>
               <button class="operator" type="button">*</button>
               <button class="operator" type="button">/</button>
           </div>
           <input id="secondNumber" type="number">
           <button class="calculate" type="button">=</button>
           <input id="result" type="number" name="result" disabled="" readonly="">
       </div>
       </form>
   </body>
   </html>
   ```

9. Use the following code to replace the contents of *\js\default.js*.

    ```csharp
    (function () {
        "use strict";

        var app = WinJS.Application;
        var operation = null;

        function calculateResult() {
            var firstNumber = parseFloat(document.querySelector("#firstNumber").value),
                secondNumber = parseFloat(document.querySelector("#secondNumber").value),
                result = 0;

            if (isNaN(firstNumber) || isNaN(secondNumber)) {
                result = 0;
            }
            else {
                switch (operation) {
                    case "+":
                        result = Arithmetic.add(firstNumber, secondNumber);
                        break;
                    case "-":
                        result = Arithmetic.subtract(firstNumber, secondNumber);
                        break;
                    case "*":
                        result = Arithmetic.multiply(firstNumber, secondNumber);
                        break;
                    case "/":
                        result = Arithmetic.divide(firstNumber, secondNumber);
                        break;
                    default:
                }
            }
            document.querySelector("#result").value = result.toString();
        }

        app.onactivated = function (args) {
            document.querySelector("#calculator").addEventListener("click", function (event) {
                if (event.target.tagName.toLowerCase() === "button") {
                    switch (event.target.className) {
                        case "operator":
                            operation = event.target.innerText;
                            break;
                        case "calculate":
                            calculateResult();
                            break;
                        default:
                            break;
                    }
                }
            });
        };

        app.start();
    })();
    ```

10. Replace the contents of *\css\default.css* with this code:

    ```xml
    form {
        display: -ms-grid;
        -ms-grid-rows: 1fr auto 1fr;
        -ms-grid-columns: 1fr auto 1fr;
        height: 100%;
        width: 100%;
    }

    button, input[type=number] {
        margin-right: 5px;
        -ms-grid-row-align: center;
    }

    #calculator {
        -ms-grid-column: 2;
        -ms-grid-row: 2;
        display: -ms-grid;
        -ms-grid-rows: 1fr;
        -ms-grid-columns: auto min-content auto auto auto;
    }

    .ms-grid input {
        width: 5em;
    }

    #firstNumber {
        -ms-grid-column: 1;
        -ms-grid-row-align: center;
    }

    #operators {
        -ms-grid-column: 2;
        -ms-grid-row-align: center;
    }

        #operators button.operator {
            margin-bottom: 5px;
            height: 40px;
        }

    #secondNumber {
        -ms-grid-column: 3;
    }

    button.calculate {
        -ms-grid-column: 4;
        -ms-grid-row-align: center;
        height: 40px;
    }

    #result {
        -ms-grid-column: 5;
    }

    ```

11. Choose the **F5** key to build and run the app.

12. In the app UI, enter any two numbers, select an operation, and then choose the **=** button. The correct result appears.

## Related content
- [Create a Software Development Kit](../extensibility/creating-a-software-development-kit.md)
