---
title: "Walkthrough: Debugging a Web Form | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords: 
  - "Web pages [.NET Framework], debugging"
  - "Web sites [.NET Framework], debugging"
  - "ASP.NET, debugging Web applications"
  - "Web applications [.NET Framework], debugging"
  - "ASP.NET Web sites, debugging"
  - "ASP.NET Web pages, debugging"
  - "debugging ASP.NET Web applications, Web Forms"
  - "debugging [Visual Studio], Web Forms"
ms.assetid: e2b4fa14-8f5b-444d-a903-54070b784bd4
caps.latest.revision: 34
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Debugging a Web Form
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

The steps in this walkthrough show you how to debug an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] Web application, also known as a Web Form. It shows you how to start and stop execution, set breakpoints, and examine variables in the **Watch** window.  
  
> [!NOTE]
> To complete this walkthrough, you must have Administrator privileges on the server computer. By default, the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] process, aspnet_wp.exe or w3wp.exe, runs as an [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] process. To debug [!INCLUDE[vstecasp](../includes/vstecasp-md.md)], you must have Administrator privileges on the computer where [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] runs it. For more information, see [System Requirements](../debugger/aspnet-debugging-system-requirements.md).  
  
 The dialog boxes and menu commands you see might differ from those described in Help, depending on your active settings or edition. To change your settings, choose **Import and Export Settings** on the **Tools** menu. For more information, see [Customizing Development Settings in Visual Studio](https://msdn.microsoft.com/22c4debb-4e31-47a8-8f19-16f328d7dcd3).  
  
### To create the Web Form  
  
1. If you already have a solution open, close it.  
  
2. On the **File** menu, click **New**, and then click **Web Site**.  
  
     The **New Web Site** dialog box appears.  
  
3. In the **Templates** pane, click **ASP.NET Web Site**.  
  
4. On the **Location** line, click **HTTP** from the list, and in the text box, type **http://localhost/WebSite**.  
  
5. In the **Language** list, click **Visual C#** or **Visual Basic**.  
  
6. Click **OK**.  
  
     [!INCLUDE[vsprvs](../includes/vsprvs-md.md)] creates a new project, and displays the default HTML source code. It also creates a new virtual directory named **WebSite** under **Default Web Site** in IIS.  
  
7. Click the **Design** tab on the bottom margin.  
  
8. Click the **Toolbox** tab on the left margin, or select it on the **View** menu.  
  
     The **Toolbox** opens.  
  
9. In the **Toolbox**, click the **Button** control and add it to the main design surface, Default.aspx.  
  
10. In the **Toolbox**, click the **Textbox** control, and drag the control to the main design surface, Default.aspx.  
  
11. Double-click the button control you dropped.  
  
     This takes you to the code page: Default.aspx.cs for C# or Default.aspx.vb for [!INCLUDE[vbprvb](../includes/vbprvb-md.md)]. The cursor should be in the function `Button1_Click`.  
  
12. In the `Button1_Click` function, add the following code:  
  
    ```  
    ' Visual Basic  
    TextBox1.Text = "Button was clicked!"  
  
    // C#  
    TextBox1.Text = "Button was clicked!";  
    ```  
  
13. On the **Build** menu, click **Build Solution**.  
  
     The project should build without errors.  
  
     Now, you are ready to start debugging.  
  
### To debug the Web Form  
  
1. In the Default.aspx.cs or Default.aspx.vb window, click the left margin on the same line as the text you added:  
  
    ```  
    ' Visual Basic  
    TextBox1.Text = "Button was clicked!"  
  
    // C#  
    textBox1.Text = "Button was clicked!";  
    ```  
  
     A red dot appears and the text on the line is highlighted in red. The red dot represents a breakpoint. When you run the application under the debugger, the debugger will break execution at that location when the code is hit. You can then view the state of your application and debug it. For more information, see [Breakpoints](https://msdn.microsoft.com/fe4eedc1-71aa-4928-962f-0912c334d583).  
  
2. On the **Debug** menu, click **Start Debugging**.  
  
3. The **Debugging Not Enabled** dialog box appears. Select **Modify the Web.config file to enable debugging** option, and click **OK**.  
  
     Internet Explorer starts and displays the page that you just designed.  
  
4. In Internet Explorer, click the button.  
  
     In [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], this takes you to the line where you set your breakpoint on the code page Default.aspx.cs or Default.aspx.vb. This line should be highlighted in yellow. You can now view the variables in your application and control its execution. Your application stops executing and waits for a command from you.  
  
5. On the **Debug** menu, click **Windows**, then click **Watch**, and then click **Watch1**.  
  
6. In the **Watch** window, type **TextBox1.Text**.  
  
     The **Watch** window shows the value of the variable `TextBox1.Text`:  
  
    ```  
    ""  
    ```  
  
7. On the **Debug** menu, click **Step Over**.  
  
     The value of `TextBox1.Text` changes in the **Watch** window to read:  
  
    ```  
    "Button was clicked!"  
    ```  
  
8. On the **Debug** menu, click **Continue**.  
  
9. In Internet Explorer, click the button again.  
  
     Execution stops at the breakpoint again.  
  
10. In the Default.aspx.cs or Default.aspx.vb window, click the red dot in the left margin.  
  
     This removes the breakpoint.  
  
11. On the **Debug** menu, click **Stop Debugging**.  
  
### To attach to the Web Form for debugging  
  
1. In [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you can attach the debugger to a running process. For most effective debugging, compile the executable as a Debug version with symbol (PDB) files.  
  
2. In the Default.aspx.cs or Default.aspx.vb window, click in the left margin to again set a breakpoint at the line you added:  
  
    ```  
    ' Visual Basic  
    TextBox1.Text = "Button was clicked!"  
  
    // C#  
    textBox1.Text = "Button was clicked!";  
    ```  
  
3. On the **Debug** menu, click **Start Without Debugging**.  
  
     The Web Form starts to run under Internet Explorer, but the debugger is not attached.  
  
4. Attach to the [!INCLUDE[vstecasp](../includes/vstecasp-md.md)] process. For more information, see [Debugging Deployed Web Applications](../debugger/debugging-deployed-web-applications.md).  
  
5. In Internet Explorer, click the button on your form.  
  
     In [!INCLUDE[vsprvs](../includes/vsprvs-md.md)], you should hit the breakpoint in Default.aspx.cs, Default.aspx.vb, or Default.aspx.  
  
6. When you are finished debugging, on the **Debug** menu, click **Stop Debugging**.  
  
## See Also  
 [Debugging ASP.NET and AJAX Applications](../debugger/debugging-aspnet-and-ajax-applications.md)
