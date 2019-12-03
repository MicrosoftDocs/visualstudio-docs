---
title: "Visual Studio Shell (Integrated) | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-sdk"
ms.topic: conceptual
helpviewer_keywords: 
  - "Visual Studio shell, integrated mode features"
  - "Shell [Visual Studio], integrated mode features"
ms.assetid: 0b40d495-f17f-4bb9-ace8-b365a7172784
caps.latest.revision: 26
ms.author: gregvanl
manager: jillfra
---
# Visual Studio Shell (Integrated)
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The Visual Studio integrated shell includes the integrated development environment (IDE), debugger, and source control integration. No programming language is included. However, the integrated shell does provide a framework that allows you to add programming languages.  
  
 The Visual Studio integrated shell is actually a combination of the Visual Studio isolated shell plus an additional install which include integrated shell specific components.  Your integrated shell application should include both the isolated shell redistributable package from [Microsoft Visual Studio Shell (Isolated) Redistributable Package](https://go.microsoft.com/fwlink/?LinkId=616022) as well as the integrated shell redistributable package from [Microsoft Visual Studio Shell (Integrated) Redistributable Package](https://go.microsoft.com/fwlink/?LinkId=616021).  
  
> [!NOTE]
> Before you can access the isolated and integrated shell redistributable packages, you will be asked to fill out a brief customer survey.  After filling out the survey, you’ll be directed to a Visual Studio Connect page with redistributable package download links.  You can find the download links on subsequent visits to the Visual Studio Connect site under the **PROGRAMS &#124; VISUAL STUDIO 2015 INTEGRATED AND ISOLATED SHELL** tab.  
  
 If you install your integrated shell application on the same computer as a full version of Visual Studio, your application’s components will be integrated directly into Visual Studio.  
  
## Features in the Integrated Shell  
  
|||  
|-|-|  
|Feature Area|Feature|  
|Language Support|-   None|  
|IDE|<ul><li>Settings<br /><br /> <ul><li>Create settings</li><li>Import and export settings</li><li>Reset settings</li></ul></li><li>**Toolbox** integration</li><li>**Task List** integration</li><li>Help integration</li><li>**Options** dialog box</li><li>Fonts and colors management</li><li>**Output** window</li><li>**Command** window</li><li>Window management</li><li>Commands, menus, and key bindings</li><li>Domain-specific language (DSL) runtime</li></ul>|  
|Project System and Project Types|-   Solutions and solution folders<br />-   Solution configuration manager<br />-   Item management<br />-   Single-project and multi-project solutions<br />-   Application Designer (simplified project properties)<br />-   Add Web Reference<br />-   Add Service Reference<br />-   Single-project<br />-   Web site project types<br />-   Web application projects|  
|Build|-   Custom build steps in IDE<br />-   Pre-compilation for intellectual property (IP) protection<br />-   Code signing<br />     MSBuild|  
|Editor|-   Code browsing tools (unified find, source definition, inheritance)<br />-   Code navigation<br />-   IntelliSense<br />-   SmartTags<br />-   Refactoring<br />-   Pretty listing<br />-   IntelliSense filtering<br />-   **Code Definition** window|  
|Designer|-   Windows Presentation Foundation Designer<br />-   Windows Forms Designer<br />-   Web Designer and HTML Editor|  
|Data|-   **Server Explorer** (Simplified: data only). See Note 1.<br />-   **Data Sources** window<br />-   Full set of data controls<br />-   XML Editor<br />-   Data bind to local data source (.MDF or .MDB)<br />-   Data bind to object<br />-   Data bind to Web service<br />-   Data bind to local database server<br />-   Data bind to remote database server<br />-   DDL tools for remote data<br />-   **Server Explorer** extensibility ([!INCLUDE[vsipsdk](../includes/vsipsdk-md.md)] samples)|  
|Debugger|-   Local debugging. See Note 2.<br />-   Managed debugging<br />-   Local debugging<br />-   Attach to local process<br />-   Attach to remote process<br />-   Anonymous delegate<br />-   Application domains<br />-   ASPX Debugging<br />-   Attributes<br />-   Break during Func-eval<br />-   Breakpoints<br />-   Breakpoint constraints<br />-   Callstack<br />-   **Command** window<br />-   Cross-thread debugging<br />-   Data Tips<br />-   Data visualizer<br />-   Debugger support for managed debugging assistants (MDAs)<br />-   Debugger support for type forwarder<br />-   DTEEvents support for OTB<br />-   JMC Stepper<br />-   Debugger AppID test (DBGCLR)<br />-   Debugger profile<br />-   Debugger tools and options<br />-   Debugging iterator<br />-   Design-time expression evaluation<br />-   C# Expression Evaluator<br />-   Disassembly<br />-   Edit and Continue<br />-   Expression evaluator windows (Watch, Locals, Autos)<br />-   Exception Helper<br />-   Exceptions<br />-   Execution<br />-   Generics<br />-   Getting right source<br />-   HPC/Cluster debugging<br />-   Integrated multi-language debugging<br />-   InterOp debugging<br />-   Just-in-time debugging<br />-   Local debugging<br />-   Managed debugging<br />-   Manual control (Processes window)<br />-   Memory<br />-   MiniDump support<br />-   Modules<br />-   Multi-process debugging<br />-   Native debugging<br />-   New debug engine support<br />-   Optimized code debugging<br />-   Output windows filtering<br />-   Process hosting for managed debugging<br />-   Processes<br />-   Quickwatch<br />-   Registers<br />-   Registers in stack<br />-   Remote debugging<br />-   Return values<br />-   Script debugging<br />-   Source service support<br />-   Security<br />-   Side-by-side<br />-   SQL<br />-   Symbol server<br />-   Trace points<br />-   Thread<br />-   Visualizations<br />-   Extensible Stylesheet Language Transformations (XSLT) debugger|  
|64-bit Support|-   64-bit debugging for both managed and native code, all languages<br />-   x64 native support|  
|Source Code Control (SCC)|-   Basic SCC integration. See Note 3.<br />-   Tools and options verification|  
|Extensibility|-   Consume VSPackages and MEF components|  
  
## Notes  
  
#### 1. Data Tools  
 The integrated shell includes database development tools such as data extensibility support and the simplified **Solution Explorer**. However, SQL Server Express, SQL Reporting, and Crystal Reports are not included in the integrated shell.  
  
#### 2. Debugging Support  
 The integrated shell includes the same debugging engine that is included in the Community version of Visual Studio. The debugging engine includes the common debugger for managed code, and also related features, such as Run, Attach, Set Breakpoint, Edit and Continue, and others. However, the debugging engine does not support SQL Server database debugging.  
  
 Although support for native debugging is included in the basic debugger package, you cannot extend it to support additional languages.  
  
#### 3. Source Code Control Integration  
 The integrated shell provides APIs for implementing source-code control (SCC) and for providing the MSSCCI-based common source control integration components.  
  
 Although SCC integration is not a regular feature of the Pro edition of Visual Studio, SCC integration is provided in the integrated shell.  
  
#### 4. Build Support  
 The integrated shell provides build support. You can find information about builds in the [MSBuild Reference](../msbuild/msbuild-reference.md).  
  
## Features Not Included in the Integrated Shell  
 The following is a list of features that are not included in the integrated shell:  
  
- Class Designer  
  
- PreEmptive Protection - Dotfuscator  
  
- Language features  
  
- VSHost  
  
- No Visual Studio languages or their associated project templates or project item templates, are included in the integrated shell. No language-specific implementations of other features are included, for example Visual Basic code snippets.  
  
## See Also  
 [Extending Visual Studio Overview](https://msdn.microsoft.com/library/3e9078d7-2763-4cc4-8e20-fac69d747f59)