---
title: "Walkthrough: Identifying Performance Problems | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
helpviewer_keywords: 
  - "profiling tools, walkthroughs"
  - "performance tools, walkthroughs"
  - "performance, analyzing"
  - "profiling applications, walkthroughs"
ms.assetid: 36f6f123-0c14-4763-99c3-bd60ecb95b87
caps.latest.revision: 58
author: MikeJo5000
ms.author: mikejo
manager: jillfra
---
# Walkthrough: Identifying Performance Problems
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

This walkthrough demonstrates how to profile an application to identify performance problems.  
  
 In this walkthrough, you will step through the process of profiling a managed application and using sampling and instrumentation to isolate and identify performance problems in the application.  
  
 In this walkthrough, you will follow these steps:  
  
- Profile an application by using the sampling method.  
  
- Analyze sampled profiling results to locate and fix a performance issue.  
  
- Profile an application by using the instrumentation method.  
  
- Analyze instrumented profiling results to locate and fix a performance issue.  
  
## Prerequisites  
  
- Intermediate understanding of C#.  
  
- A copy of the [PeopleTrax Sample](../profiling/peopletrax-sample-profiling-tools.md).  
  
  To work with the information provided by profiling, it is best to have debugging symbol information available.  
  
## Profiling by Using the Sampling Method  
 Sampling is a profiling method by which the process in question is periodically polled to determine the active function. The resulting data provides a count of how frequently the function in question was on top of the call stack when the process was sampled.  
  
#### To profile an application by using the sampling method  
  
1. Open [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] with Administrator privileges. Running as an administrator is required for profiling.  
  
2. Open the PeopleTrax solution.  
  
     The PeopleTrax solution now populates Solution Explorer.  
  
3. Set the project configuration setting to **Release**.  
  
     You should use a release build to detect performance problems in your application. A release build is recommended for profiling because a debug build has additional information compiled into it that might adversely affect performance and do not illustrate performance issues accurately.  
  
4. On the **Analyze** menu, click **Launch Performance Wizard**.  
  
     The Performance Wizard appears.  
  
5. Make sure **CPU Sampling (recommended)** is selected and then click **Next**.  
  
6. In **Which application would you like to target for profiling**, select PeopleTrax, and then click **Next**.  
  
     [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] builds the project and starts to profile the application. The **PeopleTrax** application window appears.  
  
7. Click **Get People**.  
  
8. Click **ExportData**.  
  
     Notepad opens and displays a new file that contains the exported data from **PeopleTrax**.  
  
9. Close Notepad, and then close **PeopleTrax** application.  
  
     The profiler generates a profiling data (\*.vsp) file, lists the file name in the Reports section of the Performance Explorer window, and automatically loads the **Summary** view of the data file in the main window of [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)].  
  
#### To analyze sampled profiling results  
  
1. The Summary view displays a timeline of the CPU utilization over the course of the profiling run, the **Hot Path** list that represents the branch of the application's call tree that was most active, and a list of the **Functions Doing Most Individual Work** that shows the functions that were most heavily sampled while executing code in their own function body.  
  
     Examine the **Hot Path** list and notice that the PeopleNS.People.GetNames method is the PeopleTrax function closest to the end of the list. Its position makes it a good candidate for analysis. Click the function name to display details of GetNames in the **Function Details** view.  
  
2. The **Function Details** view contains two windows. The cost distribution window provides a graphical view of the work done by the function, the work done by the functions that it called, and the contribution of functions that called the function to the number of instances that were sampled. You can change the function that is the focus of the view by clicking a function name. For example, you can click PeopleNS.People.GetPeople to make GetPeople the selected function.  
  
     The **Function Code View** window shows you the source code for the function if it is available and highlights the most expensive lines in the selected function. When GetNames is selected, you can see that this function reads a string from the application resources and then uses a <xref:System.IO.StringReader> to add each line in the string to an <xref:System.Collections.ArrayList>. There is no obvious way to optimize this function.  
  
3. Because PeopleNS.People.GetPeople is the only caller of GetNames, click GetPeople in the cost distribution window to examine its code. This method returns an <xref:System.Collections.ArrayList> of PersonInformationNS.PersonInformation objects from the names of people and companies produced by GetNames. However, GetNames is called twice every time that a PersonInformation object is created. You can see that the method can be easily optimized by creating the lists only once at the start of the method and indexing into those lists during the PersonInformation creation loop.  
  
4. An alternative version of GetPeople is provided with the sample application code and you can call the optimized function by adding a conditional compilation symbol to the build properties. In the Solution Explorer window, right-click the People project and then click **Properties**. Click **Build** on the property page menu and then type **OPTIMIZED_GETPEOPLE** in the Conditional compilation symbol text box. The optimized version of GetPeople replaces the original method in the next build.  
  
5. Rerun the performance session. On the Performance Explorer toolbar, click **Launch with Profiling**. Click **Get People** and then click **Export Data**. Close the Notepad window that appears and then close the People Trax application.  
  
     A new profiling data file is generated, and a **Summary** view for the new data appears in the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] main window.  
  
6. To compare the two profiling runs, select the two data files in the Performance Explorer, right-click the files, and then click **Compare Performance Reports**. A Comparison Report window appears in the [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] main window. The **Delta** column shows the change in the performance value of functions from the earlier **Baseline** value to the later **Comparison** value. You can select the values to compare from the **Column** drop down list. Select **Inclusive Samples %**.  
  
     Notice that the GetPeople and GetNames methods show considerable performance gains.  
  
## Profiling by Using the Instrumentation Method  
 Instrumentation is a profiling method in which the profiler inserts probe functions into specially built versions of the profiled binaries. The probes collect timing information at the entry and exit of functions in the instrumented modules and at all call site in those functions. The instrumentation process is useful for investigating issues related to input/output operations such as writing to disk and communicating over a network. Instrumentation provides more detailed information than sampling, but it is more intrusive in process execution and incurs a greater amount of overhead. Instrumented binaries are also larger than debug or release binaries and are not intended for deployment.  
  
 In this section of the walkthrough, we will use the instrumentation method to discover more code we can optimize in the PeopleTrax application we profiled previously. By using the filter of the Summary view timeline, we will focus our analysis on the export data scenario in our profiled application in which the list of people is written to a Notepad file.  
  
#### To profile an existing application by using the instrumentation method  
  
1. If necessary, open the PeopleTrax application in Visual Studio.  
  
     Make sure that you are running as Administrator and that the build configuration for the solution is set to **Release**.  
  
2. In Performance Explorer, click **Instrumentation**.  
  
3. On the Performance Explorer toolbar, click the **Launch with Profiling**.  
  
     The profiler builds the project and starts to profile the application. The PeopleTrax application window appears.  
  
4. Click **Get People**.  
  
     The PeopleTrax data grid populates with data.  
  
5. Wait for about 10 seconds and then click **Export Data**.  
  
     **Notepad** starts and displays a new file that contains a list of people from PeopleTrax. Waiting enables you to more easily identify the data export procedure for filtering.  
  
6. Close **Notepad**, and then close **PeopleTrax** application.  
  
     [!INCLUDE[vs_current_short](../includes/vs-current-short-md.md)] generates a performance session report (*.vsp).  
  
#### To analyze instrumented profiling results  
  
1. The timeline graph of the **Summary** view of the report shows the CPU utilization of the program over the duration of the profiling run. The export data operation should be the large peak or plateau on the right side of the graph. We can filter the performance session to display and analyze only the data that was collected in the export operation. Click to the left of the point on the graph where the export data operation begins. Click again to the right side of the operation. Then click **Filter by Selection** in the list of links to the right of the timeline.  
  
    The **Hot Path** tree show that the <xref:System.String.Concat%2A> method that is called by PeopleTrax.Form1.ExportData method consumes a large percentage of the time. Because **System.String.Concat** is also at the top of the **Functions With Most Individual Work** list, reducing the time spent in the function is a likely point of optimization.  
  
2. Double-click **System.String.Concat** in either of the summary tables to see more information in the Function Details view.  
  
3. You can see that the PeopleTrax.Form1.ExportData is the only method that calls Concat. Click **PeopleTrax.Form1.ExportData** in the **Calling Functions** list to select the method is as the target of the Function Details view.  
  
4. Examine the method in the Function Code View window. Notice that there are no literal calls to **System.String.Concat**. Instead, there are several uses of the += operand, which the compiler replaces with calls to **System.String.Concat**. Any modifications to a string in the .NET Framework cause a new string to be allocated. The .NET Framework includes a <xref:System.Text.StringBuilder> class that is optimized for string concatenation  
  
5. To replace this problem area with optimized code, add OPTIMIZED_EXPORTDATA as a conditional compilation symbol to the PeopleTrax project.  
  
6. In Solution Explorer, right-click the PeopleTrax project and then click **Properties**.  
  
    The PeopleTrax project properties form appears.  
  
7. Click the **Build** tab.  
  
8. In the **Conditional Compilation Symbols** text box, type **OPTIMIZED_EXPORTDATA**.  
  
9. Close the project property form and choose **save all** when you are prompted.  
  
   When you run the application again, you will see marked improvements in performance. It is recommended that you run the profiling session again, even if there are user visible improvements in performance. Reviewing the data after you fix a problem is important because the first problem might obscure some other problem.  
  
## See Also  
 [Overviews](../profiling/overviews-performance-tools.md)   
 [Getting Started](../profiling/getting-started-with-performance-tools.md)   
 [/Z7, /Zi, /ZI (Debug Information Format)](https://msdn.microsoft.com/library/ce9fa7e1-0c9b-47e3-98ea-26d1a16257c8)
