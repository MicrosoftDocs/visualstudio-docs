---
title: "Anatomy of a Coded UI Test | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: vs-ide-test
ms.topic: conceptual
helpviewer_keywords:
  - "coded UI tests"
ms.assetid: 9c5d82fc-3fb7-4bb1-a9ac-ac1fa3a4b500
caps.latest.revision: 25
ms.author: jillfra
manager: jillfra
---
# Anatomy of a Coded UI Test
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

When you create a Coded UI Test in a coded UI test project, several files are added to your solution. In this topic, we will use an example Coded UI Test to explore these files.

 **Requirements**

- Visual Studio Enterprise

## Contents of a Coded UI Test
 When you create a Coded UI Test, the **Coded UI Test Builder** creates a map of the user interface under test, and also the test methods, parameters, and assertions for all tests. It also creates a class file for each test.

|File|Contents|Editable?|
|----------|--------------|---------------|
|[UIMap.Designer.cs](#UIMapDesignerFile)|[Declarations section](#UIMapDesignerFile)<br /><br /> [UIMap class](#UIMapClass) (partial, auto-generated)<br /><br /> [Methods](#UIMapMethods)<br /><br /> [Properties](#UIMapProperties)|No|
|[UIMap.cs](#UIMapCS)|[UIMap class](#UIMapCS) (partial)|Yes|
|[CodedUITest1.cs](#CodedUITestCS)|[CodedUITest1 class](#CodedUITestCS)<br /><br /> [Methods](#CodedUITestMethods)<br /><br /> [Properties](#CodedUITestProperties)|Yes|
|[UIMap.uitest](#UIMapuitest)|The XML map of the UI for the test.|No|

### <a name="UIMapDesignerFile"></a> UIMap.Designer.cs
 This file contains code that is automatically created by the **Coded UI Test Builder** when a test is created. This file is re-created every time that a test changes, so that it is not a file in which you can add or modify code.

#### Declarations section
 This section includes the following declarations for a Windows UI.

```csharp
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Input;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
using MouseButtons = System.Windows.Forms.MouseButtons;
```

 The <xref:Microsoft.VisualStudio.TestTools.UITesting.WinControls> namespace is included for a Windows user interface (UI). For a Web page UI, the namespace would be <xref:Microsoft.VisualStudio.TestTools.UITesting.HtmlControls>; for a Windows Presentation Foundation UI, the namespace would be <xref:Microsoft.VisualStudio.TestTools.UITesting.WpfControls>.

#### <a name="UIMapClass"></a> UIMap class
 The next section of the file is the [UIMap](/previous-versions/dd580454(v=vs.140)) class.

```
[GeneratedCode("Coded UITest Builder", "10.0.21221.0")]
public partial class UIMap
```

 The class code starts with a <xref:System.CodeDom.Compiler.GeneratedCodeAttribute> that is applied to the class, which is declared as a partial class. You will notice that the attribute is also applied to every class in this file. The other file that can contain more code for this class is `UIMap.cs`, which is discussed later.

 The generated `UIMap` class includes code for each method that was specified when the test was recorded.

```
public void LaunchCalculator()
public void AddItems()
public void VerifyTotal()
public void CleanUp()
```

 This part of the [UIMap](/previous-versions/dd580454(v=vs.140)) class also includes the generated code for each property that is required by the methods.

```
public virtual LaunchCalculatorParams LaunchCalculatorParams
public virtual AddItemsParams AddItemsParams
public virtual VerifyTotalExpectedValues VerifyTotalExpectedValues
public virtual CalculateItemsParams CalculateItemsParams
public virtual VerifyMathAppTotalExpectedValues
    VerifyMathAppTotalExpectedValues
public UIStartMenuWindow UIStartMenuWindow
public UIRunWindow UIRunWindow
public UICalculatorWindow UICalculatorWindow
public UIStartWindow UIStartWindow
public UIMathApplicationWindow UIMathApplicationWindow
```

##### <a name="UIMapMethods"></a> UIMap methods
 Each method has a structure that resembles the `AddItems()` method. This is explained in more detail under the code, which is presented together with line breaks to add clarity.

```
/// <summary>
/// AddItems - Use 'AddItemsParams' to pass parameters into this method.
/// </summary>
public void AddItems()
{
    #region Variable Declarations
    WinControl uICalculatorDialog =
        this.UICalculatorWindow.UICalculatorDialog;
    WinEdit uIItemEdit =
        this.UICalculatorWindow.UIItemWindow.UIItemEdit;
    #endregion

    // Type '{NumPad7}' in 'Calculator' Dialog
    Keyboard.SendKeys(uICalculatorDialog,
        this.AddItemsParams.UICalculatorDialogSendKeys,
        ModifierKeys.None);

    // Type '{Add}{NumPad2}{Enter}' in 'Unknown Name' text box
    Keyboard.SendKeys(uIItemEdit,
        this.AddItemsParams.UIItemEditSendKeys,
        ModifierKeys.None);
}
```

 The summary comment for each method definition tells which class to use for parameter values for that method. In this case, it is the `AddItemsParams` class, which is defined later in the `UIMap.cs` file, and which is also the value type that is returned by the `AddItemsParams` property.

 At the top of the method code is a `Variable Declarations` region that defines local variables for the UI objects that will be used by the method.

 In this method, both `UIItemWindow` and `UIItemEdit` are properties that are accessed by using the `UICalculatorWindow` class, which is defined later in the `UIMap.cs` file.

 Next are lines that send text from the keyboard to the Calculator application by using properties of the `AddItemsParams` object.

 The `VerifyTotal()` method has a very similar structure, and includes the following assertion code.

```
// Verify that 'Unknown Name' text box's property 'Text' equals '9. '
Assert.AreEqual(
    this.VerifyTotalExpectedValues.UIItemEditText,
    uIItemEdit.Text);
```

 The text box name is listed as unknown because the developer of the Windows Calculator application did not provide a publicly available name for the control. The <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual%2A?displayProperty=fullName> method fails when the actual value is not equal to the expected value, which would cause the test to fail. Also notice that the expected value includes a decimal point that is followed by a space. If you ever have to modify the functionality of this particular test, you must allow for that decimal point and the space.

##### <a name="UIMapProperties"></a> UIMap properties
 The code for each property is also very standard throughout the class. The following code for the `AddItemsParams` property is used in the `AddItems()` method.

```
public virtual AddItemsParams AddItemsParams
{
    get
    {
        if ((this.mAddItemsParams == null))
        {
            this.mAddItemsParams = new AddItemsParams();
        }
        return this.mAddItemsParams;
    }
}
```

 Notice that the property uses a private local variable that is named `mAddItemsParams` to hold the value before it returns it. The property name and the class name for the object it returns are the same. The class is defined later in the `UIMap.cs` file.

 Each class that is returned by a property is structured similarly. The following is the `AddItemsParams` class.

```
/// <summary>
/// Parameters to be passed into 'AddItems'
/// </summary>
[GeneratedCode("Coded UITest Builder", "10.0.21221.0")]
public class AddItemsParams
{
    #region Fields
    /// <summary>
    /// Type '{NumPad7}' in 'Calculator' Dialog
    /// </summary>
    public string UICalculatorDialogSendKeys = "{NumPad7}";

    /// <summary>
    /// Type '{Add}{NumPad2}{Enter}' in 'Unknown Name' text box
    /// </summary>
    public string UIItemEditSendKeys = "{Add}{NumPad2}{Enter}";
    #endregion
}
```

 As with all classes in the `UIMap.cs` file, this class starts with the <xref:System.CodeDom.Compiler.GeneratedCodeAttribute>. In this small class is a `Fields` region that defines the strings to use as parameters for the <xref:Microsoft.VisualStudio.TestTools.UITesting.Keyboard.SendKeys%2A?displayProperty=fullName> method that is used in the `UIMap.AddItems()` method that was discussed earlier. You can write code to replace the values in these string fields before the method in which these parameters are used is called.

### <a name="UIMapCS"></a> UIMap.cs
 By default, this file contains a partial `UIMap` class that has no methods or properties.

#### UIMap class
 This is where you can create custom code to extend the functionality of the [UIMap](/previous-versions/dd580454(v=vs.140)) class. The code that you create in this file will not be regenerated by the **Coded UI Test Builder** every time that a test is modified.

 All parts of the [UIMap](/previous-versions/dd580454(v=vs.140)) can use the methods and properties from any other part of the [UIMap](/previous-versions/dd580454(v=vs.140)) class.

### <a name="CodedUITestCS"></a> CodedUITest1.cs
 This file is generated by the **Coded UI Test Builder**, but is not re-created every time that the test is modified, so that you can modify the code in this file. The name of the file is generated from the name that you specified for the test when you created it.

#### CodedUITest1 class
 By default, this file contains the definition for only one class.

```
[CodedUITest]
public class CodedUITest1
```

 The [CodedUITestAttribute](/previous-versions/visualstudio/visual-studio-2013/ff430233(v=vs.120)) is automatically applied to the class, which allows the testing framework to recognize it as a testing extension. Also notice that this is not a partial class. All class code is contained in this file.

##### <a name="CodedUITestProperties"></a> CodedUITest1 properties
 The class contains two default properties that are located at the bottom of the file. They must not be modified.

```
/// <summary>
/// Gets or sets the test context which provides
/// information about and functionality for the current test run.
///</summary>
public TestContext TestContext
public UIMap UIMap
```

##### <a name="CodedUITestMethods"></a> CodedUITest1 methods
 By default, the class contains only one method.

```
public void CodedUITestMethod1()
```

 This method calls each `UIMap` method that you specified when you recorded your test, which is described in the section on the [UIMap Class](#UIMapClass).

 A region that is titled `Additional test attributes`, if uncommented, contains two optional methods.

```
// Use TestInitialize to run code before running each test
[TestInitialize()]
public void MyTestInitialize()
{
    // To generate code for this test, select "Generate Code for Coded
    // UI Test" from the shortcut menu and select one of the menu items.
    // For more information on generated code, see
    // http://go.microsoft.com/fwlink/?LinkId=179463

    // You could move this line from the CodedUITestMethod1() method
    this.UIMap.LaunchCalculator();
}

// Use TestCleanup to run code after each test has run
[TestCleanup()]
public void MyTestCleanup()
{
    // To generate code for this test, select "Generate Code for Coded
    // UI Test" from the shortcut menu and select one of the menu items.
    // For more information on generated code, see
    // http://go.microsoft.com/fwlink/?LinkId=179463

    // You could move this line from the CodedUITestMethod1() method
    this.UIMap.CloseCalculator();
}
```

 The `MyTestInitialize()` method has the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute> applied to it, which tells the testing framework to call this method before any other test methods. Similarly, the `MyTestCleanup()` method has the <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute> applied to it, which tells the testing framework to call this method after all other test methods have been called. Use of these methods is optional. For this test, the `UIMap.LaunchCalculator()` method could be called from `MyTestInitialize()` and the `UIMap.CloseCalculator()` method could be called from `MyTestCleanup()` instead of from `CodedUITest1Method1()`.

 If you add more methods to this class by using the [CodedUITestAttribute](/previous-versions/visualstudio/visual-studio-2013/ff430233(v=vs.120)), the testing framework will call each method as part of the test.

### <a name="UIMapuitest"></a> UIMap.uitest
 This is an XML file that represents the structure of the coded UI test recording and all its parts. These include the actions and the classes in addition to the methods and properties of those classes. The [UIMap.Designer.cs](#UIMapDesignerFile) file contains the code that is generated by the Coded UI Builder to reproduce the structure of the test and provides the connection to the testing framework.

 The `UIMap.uitest` file is not directly editable. However, you can use the Coded UI Builder to modify the test, which automatically modifies the `UIMap.uitest` file and the [UIMap.Designer.cs](#UIMapDesignerFile) file.

## See also

- [UIMap](/previous-versions/dd580454(v=vs.140))
- <xref:Microsoft.VisualStudio.TestTools.UITesting.WinControls>
- <xref:Microsoft.VisualStudio.TestTools.UITesting.HtmlControls>
- <xref:Microsoft.VisualStudio.TestTools.UITesting.WpfControls>
- <xref:System.CodeDom.Compiler.GeneratedCodeAttribute>
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual%2A?displayProperty=fullName>
- <xref:Microsoft.VisualStudio.TestTools.UITesting.Keyboard.SendKeys%2A?displayProperty=fullName>
- [CodedUITestAttribute](/previous-versions/visualstudio/visual-studio-2013/ff430233(v=vs.120))
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestInitializeAttribute>
- <xref:Microsoft.VisualStudio.TestTools.UnitTesting.TestCleanupAttribute>
- [Use UI Automation To Test Your Code](../test/use-ui-automation-to-test-your-code.md)
- [Creating Coded UI Tests](../test/use-ui-automation-to-test-your-code.md#VerifyingCodeUsingCUITCreate)
- [Best Practices for Coded UI Tests](../test/best-practices-for-coded-ui-tests.md)
- [Testing a Large Application with Multiple UI Maps](../test/testing-a-large-application-with-multiple-ui-maps.md)
- [Supported Configurations and Platforms for Coded UI Tests and Action Recordings](../test/supported-configurations-and-platforms-for-coded-ui-tests-and-action-recordings.md)
