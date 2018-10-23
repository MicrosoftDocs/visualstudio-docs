---
title: "Debug user code with Just My Code | Microsoft Docs"
ms.custom: ""
ms.date: "05/18/2018"
ms.technology: "vs-ide-debug"
ms.topic: "conceptual"
ms.assetid: 0f0df097-bbaf-46ad-9ad1-ef5f40435079
author: "mikejo5000"
ms.author: "mikejo"
manager: douge
ms.workload: 
  - "multiple"
---
# Debug only user code with Just My Code 

*Just My Code* is a Visual Studio debugging feature that automatically steps over system, framework, and other non-user calls and collapses them in the **Call Stack** window. 

Just My Code works differently in .NET Framework, C++, and JavaScript projects.

##  <a name="BKMK_Enable_or_disable_Just_My_Code"></a> Enable or disable Just My Code  

For most programming languages, Just My Code is enabled by default. 

- To enable or disable Just My Code in Visual Studio, under **Tools** > **Options** (or **Debug** > **Options**) > **Debugging** > **General**, select or deselect **Enable Just My Code**.
  
 ![Enable Just My Code in the Options dialog box](../debugger/media/dbg_justmycode_options.png "Enable Just My Code")  
  
> [!NOTE]
> **Enable Just My Code** is a global setting that applies to all Visual Studio projects in all languages.  
  
##  <a name="BKMK_Override_call_stack_filtering"></a> Show non-user code in the Call Stack window  

Just My Code collapses non-user code into a grayed-out line labeled `[External Code]` in the **Call Stack** or **Tasks** window. You can view the collapsed code. 

To open the **Call Stack** or **Tasks** window, you must be in a debugging session. From **Debug** > **Windows**, select **Call Stack** (or press **Alt**+**7**), or select **Tasks**. 

##  Just My Code debugging

During a debugging session, the **Modules** window shows which code modules the debugger is treating as My Code (user code), along with their symbol loading status. To open the **Modules** window, during debugging, select **Debug** > **Windows** > **Modules**. For more information, see [Get more familiar with how the debugger attaches to your app](../debugger/debugger-tips-and-tricks.md#modules_window).

Just My Code collapses non-user code into a grayed-out line labeled `[External Code]` in the **Call Stack** or **Tasks** window. 

To open the **Call Stack** or **Tasks** window, during debugging, select **Debug** > **Windows**, and then select **Call Stack** (or press **Alt**+**7**), or select **Tasks**. 

To view the code in a collapsed **[External Code]** frame, right-click in the **Call Stack** or **Task** window, and select **Show External Code** from the context menu. The expanded external code lines replace the **[External Code**] frame. 

 ![Show External Code in the Call Stack window](../debugger/media/dbg_justmycode_showexternalcode.png "Show External Code")
  
> [!NOTE]
> **Show External Code** is a current user profiler setting that applies to all projects in all languages that are opened by the user.

Double-clicking the expanded external code lines in the **Call Stack** window has different effects depending on code language, calling function, and whether there is a source file corresponding to the stack frame. 

Either the calling user code is highlighted in green in the source code, or the symbol file not loaded page appears, allowing you to search for and load a *.pdb* file. 

##  <a name="BKMK__NET_Framework_Just_My_Code"></a>Just My Code in .NET Framework projects 
  
###  <a name="BKMK_NET_User_and_non_user_code"></a> .NET Framework user and non-user code  

In .NET Framework projects, Just My Code uses symbol (*.pdb*) files and program optimizations to distinguish user code from non-user code. The .NET Framework debugger considers optimized binaries and non-loaded *.pdb* files to be non-user code.
  
Three compiler attributes also affect what the debugger considers to be user code:  
- <xref:System.Diagnostics.DebuggerNonUserCodeAttribute> tells the debugger that the code it is applied to is not user code.  
- <xref:System.Diagnostics.DebuggerHiddenAttribute> hides the code from the debugger, even if Just My Code is turned off.  
- <xref:System.Diagnostics.DebuggerStepThroughAttribute> tells the debugger to step through the code it is applied to, rather than step into the code.  

The .NET Framework debugger considers all other code to be user code.  
  
###  <a name="BKMK_NET_Stepping_behavior"></a> .NET Framework debugging behavior  

In .NET Framework projects with Just My Code enabled:
- **Debug** > **Step Into** (or **F11**) on non-user code steps over the code to the next line of user code. 
- **Debug** > **Step Out** (or **Shift**+**F11**) on non-user code runs to the next line of user code. 

If there is no more user code, execution continues until the app exits, a breakpoint is hit, or an error occurs.  
  
<a name="BKMK_NET_Breakpoint_behavior"></a> 
If the debugger breaks in non-user code (for example, you use **Debug** > **Break All** and pause in non-user code), the **No Source** window appears. You can then use a **Debug** > **Step** command to go to the next line of user code.

If an unhandled exception occurs in non-user code, the debugger breaks at the user code line where the exception was generated.  
  
If first-chance exceptions are enabled for the exception, the user-code line is highlighted in green in source code, and the **Call Stack** window displays the annotated frame labeled **[External Code]**.  
  
##  <a name="BKMK_C___Just_My_Code"></a> Just My Code in C++ projects  
  
In C++, enabling Just My Code is the same as using the [/JMC (Just my code debugging)](/cpp/build/reference/jmc) compiler switch.
  
###  <a name="BKMK_CPP_User_and_non_user_code"></a> C++ user and non-user code  

Just My Code is different in C++ than in .NET Framework and JavaScript, because you can specify non-user files separately for stepping behavior and the **Call Stack** window. 

Just My Code in C++ considers only these functions to be non-user code:

- For the **Call Stack** window:  
  - Functions with stripped source information in their symbols file.  
  - Functions where the symbol files indicate that there is no source file corresponding to the stack frame.  
  - Functions specified in *\*.natjmc* files in the *%VsInstallDirectory%\Common7\Packages\Debugger\Visualizers* folder.  
  
- For stepping behavior:
  - Functions specified in *\*.natstepfilter* files in the *%VsInstallDirectory%\Common7\Packages\Debugger\Visualizers* folder.  
  
You can create *.natstepfilter* and *.natjmc* files to customize Just My Code stepping behavior and the **Call Stack** window display. See [Customize C++ stepping behavior](#BKMK_CPP_Customize_stepping_behavior) and {Customize C++ call stack behavior](#BKMK_CPP_Customize_call_stack_behavior). 
  
###  <a name="BKMK_CPP_Stepping_behavior"></a> C++ debugging behavior  

In C++ projects with Just My Code enabled:
- **Debug** > **Step Into** (or **F11**) on non-user code steps over the code to the next line of user code. 
- **Debug** > **Step Out** (or **Shift**+**F11**) on non-user code runs to the next line of user code. 

If there is no more user code, the debugger runs until the app exits, a breakpoint is hit, or an error occurs.  

If the debugger breaks in non-user code (for example, you use **Debug** > **Break All** and pause in non-user code), stepping continues in the non-user code.

If the debugger hits an exception, it stops on the exception whether it is in user or non-user code. **User-unhandled** options in the **Exception Settings** dialog box are ignored.  
  
###  <a name="BKMK_CPP_Customize_stepping_behavior"></a> Customize C## stepping behavior  

 In C++ projects, you can specify functions to step over by listing them as non-user code in *\*.natstepfilter* files.  
  
- To specify non-user code for all local Visual Studio users, add the *.natstepfilter* file to the *%VsInstallDirectory%\Common7\Packages\Debugger\Visualizers* folder.  
- To specify non-user code for an individual user, add the *.natstepfilter* file to the *%USERPROFILE%\My Documents\Visual Studio 2017\Visualizers* folder.  
  
A *.natstepfilter* file is an XML file with this syntax:  
  
```xml  
<?xml version="1.0" encoding="utf-8"?>  
<StepFilter xmlns="http://schemas.microsoft.com/vstudio/debugger/natstepfilter/2010">  
    <Function>  
        <Name>FunctionSpec</Name>  
        <Action>StepAction</Action>  
    </Function>  
    <Function>  
        <Name>FunctionSpec</Name>  
        <Module>ModuleSpec</Module>  
        <Action>StepAction</Action>  
    </Function>  
</StepFilter>  
  
```  
  
|Element|Description|  
|-------------|-----------------|  
|`Function`|Required. Specifies one or more functions as non-user functions.|  
|`Name`|Required. An ECMA-262 formatted regular expression specifying the full function name to match. For example:<br /><br /> `<Name>MyNS::MyClass.*</Name>`<br /><br /> tells the debugger that all methods in `MyNS::MyClass` are to be considered non-user code. The match is case-sensitive.|  
|`Module`|Optional. An ECMA-262 formatted regular expression specifying the full path to the module containing the function. The match is case-insensitive.|  
|`Action`|Required. One of these case-sensitive values:<br /><br /> -   `NoStepInto`  - tells the debugger to step over the function.<br />-   `StepInto`  - tells the debugger to step into the function, overriding any other `NoStepInto` for the matched function.|  
  
###  <a name="BKMK_CPP_Customize_call_stack_behavior"></a> Customize C++ call stack behavior  

For C++ projects, you can specify the modules, source files, and functions the **Call Stack** window treats as non-user code by specifying them in *\*.natjmc* files.  
  
-   To specify non-user code for all users of the Visual Studio machine, add the *.natjmc* file to the *%VsInstallDirectory%\Common7\Packages\Debugger\Visualizers* folder.  
-   To specify non-user code for an individual user, add the *.natjmc* file to the *%USERPROFILE%\My Documents\Visual Studio 2017\Visualizers* folder.  

A *.natjmc* file is an XML file with this syntax:  
  
```xml  
<?xml version="1.0" encoding="utf-8"?>  
<NonUserCode xmlns="http://schemas.microsoft.com/vstudio/debugger/jmc/2015">  
  
  <!-- Modules -->  
  <Module Name="ModuleSpec" />  
  <Module Name="ModuleSpec" Company="CompanyName" />  
  
  <!-- Files -->  
  <File Name="FileSpec"/>  
  
  <!-- Functions -->  
  <Function Name="FunctionSpec" />  
  <Function Name="FunctionSpec" Module ="ModuleSpec" />  
  <Function Name="FunctionSpec" Module ="ModuleSpec" ExceptionImplementation="true" />  
  
</NonUserCode>  
  
```  
  
 **Module element attributes**  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Name`|Required. The full path of the module or modules. You can use the Windows wildcard characters `?` (zero or one character) and `*` (zero or more characters). For example,<br /><br /> `<Module Name="?:\3rdParty\UtilLibs\*" />`<br /><br /> tells the debugger to treat all modules in *\3rdParty\UtilLibs* on any drive as external code.|  
|`Company`|Optional. The name of the company that publishes the module that is embedded in the executable file. You can use this attribute to disambiguate the modules.|  
  
 **File element attributes**  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Name`|Required. The full path of the source file or files to treat as external code. You can use the Windows wildcard characters `?` and `*` when specifying the path.|  
  
 **Function element attributes**  
  
|Attribute|Description|  
|---------------|-----------------|  
|`Name`|Required. The fully qualified name of the function to treat as external code.|  
|`Module`|Optional. The name or full path to the module that contains the function. You can use this attribute to disambiguate functions with the same name.|  
|`ExceptionImplementation`|When set to `true`, the call stack displays the function that threw the exception rather than this function.|  
  
##  <a name="BKMK_JavaScript_Just_My_Code"></a> JavaScript Just My Code  
  
###  <a name="BKMK_JS_User_and_non_user_code"></a> JavaScript user and non-user code  

JavaScript Just My Code controls stepping and call stack display by categorizing code in one of these classifications:  

|||  
|-|-|  
|**MyCode**|User code that you own and control.|  
|**LibraryCode**|Non-user code from libraries that you use regularly and your application relies on to function correctly (for example WinJS or jQuery).|  
|**UnrelatedCode**|Non-user code that could be running in your application, but you don't own it and your application doesn't directly rely on it to function correctly. For example, this could include an advertising SDK that displays ads. In UWP projects, any code that is loaded into your app from an HTTP or HTTPS URI is also considered UnrelatedCode.|  
  
 The JavaScript debugger classifies these types of code by default:  
  
-   Script that is executed by passing a string to the host-provided `eval` function is classified as **MyCode**.  
-   Script that is executed by passing a string to the `Function` constructor is classified as **LibraryCode**.  
-   Script that is contained in a framework reference, such as WinJS or the Azure SDK, is classified as **LibraryCode**.  
-   Script that is executed by passing a string to the `setTimeout`, `setImmediate`, or `setInterval` functions is classified as **UnrelatedCode**.  

The *%VSInstallDirectory%\JavaScript\JustMyCode\mycode.default.wwa.json* file specifies other user and non-user code for all Visual Studio JavaScript projects.  

You can modify the default classifications, and classify specific files and URLs, by adding a *.json* file named *mycode.json* to the root folder of a JavaScript project. See [Customize JavaScript Just My Code](#BKMK_JS_Customize_Just_My_Code). 

The JavaScript debugger classifies code as user or non-user in this order:  
  
1. The default classifications.  
2. The classifications in the *%VSInstallDirectory%\JavaScript\JustMyCode\mycode.default.wwa.json* file.  
3. The classifications in the *mycode.json* file of the current project.  
  
Each classification step overrides the previous steps. 

All other code is classified as **MyCode**.  

###  <a name="BKMK_JS_Stepping_behavior"></a> JavaScript debugging behavior  
  
-   If a function is non-user code, **Debug** > **Step Into** (or **F11**) behaves the same as **Debug** > **Step Over** (or **F10**).  
-   If a step begins in non-user (**LibraryCode** or **UnrelatedCode**) code, stepping temporarily behaves as if Just My Code is not enabled. When you step back to user code, Just My Code stepping is re-enabled.  
-   When a step in user code results in leaving the current execution context (such as doing a step on the last line of an event handler), the debugger stops at the next executed line of user code. For example, if a callback executes in **LibraryCode** code, the debugger continues until the next line of user code executes.
-   **Step Out** (or **Shift**+**F11**) stops on the next line of user code. 

If there is no more user code, the debugger continues until the app exits, a breakpoint is hit, or an exception occurs.  
  
Breakpoints set in code are always hit, regardless of the classification of that code.  

- If the `debugger` keyword occurs in **LibraryCode**, the debugger always breaks.  
- If the `debugger` keyword occurs in **UnrelatedCode**, the debugger doesn't stop.  
  
<a name="BKMK_JS_Exception_behavior"></a>
If an unhandled exception occurs in **MyCode** or **LibraryCode** code, the debugger always breaks.  

If an unhandled exception occurs in **UnrelatedCode**, and **MyCode** or **LibraryCode** is on the call stack, the debugger breaks.  
  
If first-chance exceptions are enabled for the exception in the **Exception Settings** dialog box, and the exception occurs in **LibraryCode** or **UnrelatedCode**:  
  
-   If the exception is handled, the debugger doesn't break.  
-   If the exception is not handled, the debugger breaks.  
  
###  <a name="BKMK_JS_Customize_Just_My_Code"></a> Customize JavaScript Just My Code  

To categorize user and non-user code for a single Visual Studio project, you can add a *.json* file named *mycode.json* to the root folder of the project.  
  
Specifications in this file override the default classifications or those in the *mycode.default.wwa.json* file. The *mycode.json* file does not need to list all key value pairs, and the **MyCode**, **Libraries**, and **Unrelated** values can be empty arrays.  
  
*Mycode.json* files use this syntax:  
  
```json  
{  
    "Eval" : "Classification",  
    "Function" : "Classification",  
    "ScriptBlock" : "Classification",  
    "MyCode" : [  
        "UrlOrFileSpec",  
        . . .  
        "UrlOrFileSpec"  
    ],  
    "Libraries" : [  
        "UrlOrFileSpec",  
        . .  
        "UrlOrFileSpec"  
    ],  
    "Unrelated" : [  
        "UrlOrFileSpec",  
        . . .  
        "UrlOrFileSpec"  
    ]  
}  
  
```  
  
 **Eval, Function, and ScriptBlock**  
  
 The **Eval**, **Function**, and **ScriptBlock** key value pairs determine how dynamically generated code is classified.  
  
|||  
|-|-|  
|**Eval**|Script that is executed by passing a string to the host-provided `eval` function. By default, Eval script is classified as **MyCode**.|  
|**Function**|Script that is executed by passing a string to the `Function` constructor. By default, Function script is classified as **LibraryCode**.|  
|**ScriptBlock**|Script that is executed by passing a string to the `setTimeout`, `setImmediate`, or `setInterval` functions. By default, ScriptBlock script is classified as **UnrelatedCode**.|  
  
 You can change the value to one of these keywords:  
  
-   `MyCode`  classifies the script as **MyCode**.  
-   `Library`  classifies the script as **LibraryCode**.  
-   `Unrelated`  classifies the script as **UnrelatedCode**.  
  
 **MyCode, Libraries, and Unrelated**  
  
 The **MyCode**, **Libraries**, and **Unrelated** key value pairs specify the URLs or files that you want to include in a classification:  
  
|||  
|-|-|  
|**MyCode**|An array of URLs or files that are classified as **MyCode**.|  
|**Libraries**|An array of URLs or files that are classified as **LibraryCode**.|  
|**Unrelated**|An array of URLs or files that are classified as **UnrelatedCode**.|  
  
 The URL or file string can contain one or more `*` characters, which match zero or more characters. `*` is the equivalent of the regular expression `.*`.
