---
title: "Analyze CPU Usage in a Windows Universal App | Microsoft Docs"
ms.date: 11/15/2016
ms.prod: "visual-studio-dev14"
ms.technology: "vs-ide-debug"
ms.topic: conceptual
dev_langs: 
  - "FSharp"
  - "VB"
  - "CSharp"
  - "C++"
ms.assetid: c122b08e-e3bf-43e6-bd6c-e776e178fd9a
caps.latest.revision: 21
author: MikeJo5000
ms.author: mikejo
manager: jillfra
robots: noindex,nofollow
---
# Analyze CPU Usage in a Windows Universal App
[!INCLUDE[vs2017banner](../includes/vs2017banner.md)]

Applies to Windows and Windows Phone](../Image/windows_and_phone_content.png "windows_and_phone_content")  
  
 When you need to investigate performance issues in your app, a good place to start is understanding how it uses the CPU. The **CPU Usage** tool shows you where the CPU is spending time executing code. To focus on specific scenarios, CPU Usage can be run with the [XAML UI Responsiveness](https://msdn.microsoft.com/library/4ff84cd1-4e63-4fda-b34f-3ef862a6e480) tool, the [CPU Usage Tool](../profiling/cpu-usage.md) tool, or both tools in a single diagnostic session.  
  
> [!NOTE]
> The **CPU Usage** tool cannot be used with Windows Phone Silverlight 8.1 apps.  
  
 This walkthrough takes you through collecting and analyzing CPU usage for a simple Windows Universal XAML app.  
  
## <a name="BKMK_Create_the_CpuUseDemo_project"></a> Create the CpuUseDemo project  
 **CpuUseDemo** is an app that was created to demonstrate how to collect and analyze CPU usage data. The buttons generate a number by calling a method that selects the maximum value from multiple calls to a function. The called function creates a very large number of random values and then returns the last one. The data is displayed in a text box.  
  
1. Create a new C# Windows Universal app project named **CpuUseDemo** using the **BlankApp** template.  
  
     ![Create the CpuUseDemoProject](../profiling/media/cpu-use-newproject.png "CPU_USE_NewProject")  
  
2. Replace MainPage.xaml with [this code](#BKMK_MainPage_xaml).  
  
3. Replace MainPage.xaml.cs with [this code](#BKMK_MainPage_xaml_cs).  
  
4. Build the app and try it out. The app is simple enough to show you some common cases of CPU Usage data analysis.  
  
## <a name="BKMK_Collect_CPU_usage_data"></a> Collect CPU usage data  
 ![Run a release build of the app in the simulator](../profiling/media/cpu-use-wt-setsimulatorandretail.png "CPU_USE_WT_SetSimulatorAndRetail")  
  
1. In Visual Studio, set the deployment target to **Simulator** and the solution configuration to **Release**.  
  
   - Running the app in the simulator lets you switch easily between the app and the Visual Studio IDE.  
  
   - Running this app in **Release** mode gives you a better view of the actual performance of your app.  
  
2. On the **Debug** menu, choose **Performance Profiler...**.  
  
3. In the Performance and Diagnostic hub, choose **CPU Usage** and then choose **Start**.  
  
    ![Start the CpuUsage diagnostic session](../profiling/media/cpu-use-wt-perfdiaghub.png "CPU_USE_WT_PerfDiagHub")  
  
4. When the app starts, click **Get Max Number**. Wait about a second after the output is displayed, then choose **Get Max Number Async**. Waiting between button clicks makes it easier to isolate the button click routines in the diagnostic report.  
  
5. After the second output line appears, choose **Stop Collection** in the Performance and Diagnostic hub.  
  
   ![Stop CpuUsage data collection](../profiling/media/cpu-use-wt-stopcollection.png "CPU_USE_WT_StopCollection")  
  
   The CPU Usage tool analyzes the data and displays the report.  
  
   ![CpuUsage report](../profiling/media/cpu-use-wt-report.png "CPU_USE_WT_Report")  
  
## <a name="BKMK_Analyze_the_CPU_Usage_report"></a> Analyze the CPU Usage report  
  
### <a name="BKMK_CPU_utilization_timeline_graph"></a> CPU utilization timeline graph  
 ![CpuUtilization &#40;%&#41; timeline graph](../profiling/media/cpu-use-wt-timelinegraph.png "CPU_USE_WT_TimelineGraph")  
  
 The CPU utilization graph shows the CPU activity of the app as a percent of all CPU time from all the processor cores on the device. The data of this report was collected on a dual-core machine. The two large spikes represent the CPU activity of the two button clicks. `GetMaxNumberButton_Click` performs synchronously on a single core, so that it makes sense that method’s graph height never exceeds 50%. `GetMaxNumberAsycButton_Click` runs asynchronously across both cores, so it so it again looks right that its spike gets closer to utilizing all of the CPU resources on both cores.  
  
#### <a name="BKMK_Select_timeline_segments_to_view_details"></a> Select timeline segments to view details  
 Use the selection bars on the **Diagnostic session** timeline to focus on the GetMaxNumberButton_Click data:  
  
 ![GetMaxNumberButton&#95;Click selected](../profiling/media/cpu-use-wt-getmaxnumberreport.png "CPU_USE_WT_GetMaxNumberReport")  
  
 The **Diagnostic session** timeline now displays the time spent in the selected segment (a bit more than 2 seconds in this report) and filters the call tree to those methods that ran in the selection.  
  
 Now select the `GetMaxNumberAsyncButton_Click` segment.  
  
 ![GetMaxNumberAsyncButton&#95;Click report selection](../profiling/media/cpu-use-wt-getmaxnumberasync-selected.png "CPU_USE_WT_GetMaxNumberAsync_Selected")  
  
 This method completes about a second faster than `GetMaxNumberButton_Click`, but the meaning of the call tree entries are less obvious.  
  
### <a name="BKMK_The_CPU_Usage_call_tree"></a> The CPU Usage call tree  
 To get started understanding call tree information, reselect the `GetMaxNumberButton_Click` segment, and look at the call tree details.  
  
#### <a name="BKMK_Call_tree_structure"></a> Call tree structure  
 ![GetMaxNumberButton&#95;Click call tree](../profiling/media/cpu-use-wt-getmaxnumbercalltree-annotated.png "CPU_USE_WT_GetMaxNumberCallTree_annotated")  
  
|||  
|-|-|  
|![Step 1](../profiling/media/procguid-1.png "ProcGuid_1")|The top-level node in CPU Usage call trees is a pseudo-node|  
|![Step 2](../profiling/media/procguid-2.png "ProcGuid_2")|In most apps, when the **Show External Code** option is disabled, the second-level node is an **[External Code]** node that contains the system and framework code that starts and stops the app, draws the UI, controls thread scheduling, and provides other low-level services to the app.|  
|![Step 3](../profiling/media/procguid-3.png "ProcGuid_3")|The children of the second-level node are the user-code methods and asynchronous routines that are called or created by the second-level system and framework code.|  
|![Step 4](../profiling/media/procguid-4.png "ProcGuid_4")|Child nodes of a method contain data only for the calls of the parent method. When **Show External Code** is disabled, app methods can also contain an **[External Code]** node.|  
  
#### <a name="BKMK_External_Code"></a> External Code  
 External code consists of functions in system and framework components that are executed by the code you write. External code includes functions that start and stop the app, draw the UI, control threading, and provide other low-level services to the app. In most cases, you won’t be interested in external code, and so the CPU Usage call tree gathers the external functions of a user method into one **[External Code]** node.  
  
 When you want to view the call paths of external code, choose **Show External Code** from the **Filter view** list and then choose **Apply**.  
  
 ![Choose Filter View, then Show External Code](../profiling/media/cpu-use-wt-filterview.png "CPU_USE_WT_FilterView")  
  
 Be aware that many external code call chains are deeply nested, so that the width of the Function Name column can exceed the display width of all but the largest of computer monitors. When this happens, function names are shown as **[…]**:  
  
 ![Nested external code in the call tree](../profiling/media/cpu-use-wt-showexternalcodetoowide.png "CPU_USE_WT_ShowExternalCodeTooWide")  
  
 Use the search box to find a node that you are looking for, then use the horizontal scroll bar to bring the data into view:  
  
 ![Search for nested external code](../profiling/media/cpu-use-wt-showexternalcodetoowide-found.png "CPU_USE_WT_ShowExternalCodeTooWide_Found")  
  
### <a name="BKMK_Call_tree_data_columns"></a> Call tree data columns  
  
|||  
|-|-|  
|**Total CPU (%)**|![Total % data equation](../profiling/media/cpu-use-wt-totalpercentequation.png "CPU_USE_WT_TotalPercentEquation")<br /><br /> The percentage of the app's CPU activity in the selected time range that was used by calls to the function and the functions called by the function. Note that this is different from the **CPU Utilization** timeline graph, which compares the total activity of the app in a time range to the total available CPU capacity.|  
|**Self CPU (%)**|![Self % equation](../profiling/media/cpu-use-wt-selflpercentequation.png "CPU_USE_WT_SelflPercentEquation")<br /><br /> The percentage of the app's CPU activity in the selected time range that was used by the calls to the function, excluding the activity of functions called by the function.|  
|**Total CPU (ms)**|The number of milliseconds spent in calls to the function in the selected time range and the functions that were called by the function.|  
|**Self CPU (ms)**|The number of milliseconds spent in calls to the function in the selected time range and the functions that were called by the function.|  
|**Module**|The name of the module containing the function, or the number of modules containing the functions in an [External Code] node.|  
  
### <a name="BKMK_Asynchronous_functions_in_the_CPU_Usage_call_tree"></a> Asynchronous functions in the CPU Usage call tree  
 When the compiler encounters an asynchronous method, it creates a hidden class to control the method’s execution. Conceptually, the class is a state machine that includes a list of compiler-generated functions that call operations of the original method asynchronously, and the callbacks, scheduler, and iterators required to them correctly. When the original method is called by a parent method, the runtime removes the method from the execution context of the parent, and runs the methods of the hidden class in the context of the system and framework code that control the app’s execution. The asynchronous methods are often, but not always, executed on one or more different threads. This code is shown in the CPU Usage call tree as children of the **[External Code]** node immediately below the top node of the tree.  
  
 To see this in our example, re-select the `GetMaxNumberAsyncButton_Click` segment in the timeline.  
  
 ![GetMaxNumberAsyncButton&#95;Click report selection](../profiling/media/cpu-use-wt-getmaxnumberasync-selected.png "CPU_USE_WT_GetMaxNumberAsync_Selected")  
  
 The first two nodes under **[External Code]** are the compiler-generated methods of the state machine class. The third is the call to original method. Expanding the generated methods shows you what’s going on.  
  
 ![Expanded GetMaxNumberAsyncButton&#95;Click call tree](../profiling/media/cpu-use-wt-getmaxnumberasync-expandedcalltree.png "CPU_USE_WT_GetMaxNumberAsync_ExpandedCallTree")  
  
- `MainPage::GetMaxNumberAsyncButton_Click` does very little; it manages a list of the task values, computes the maximum of the results, and displays the output.  
  
- `MainPage+<GetMaxNumberAsyncButton_Click>d__3::MoveNext` shows you the activity required to schedule and launch the 48 tasks that wrap the call to `GetNumberAsync`.  
  
- `MainPage::<GetNumberAsync>b__b` shows you the activity of the tasks that call `GetNumber`.  
  
## <a name="BKMK_Next_steps"></a> Next steps  
 The CpuUseDemo app is not the most brilliant of apps, but you can extend its utility by using it to experiment with asynchronous operation and other tools in the Performance and Diagnostics hub.  
  
- Note that `MainPage::<GetNumberAsync>b__b` spends more time in [External Code] than it does executing the GetNumber method. Much of this time is the overhead of the asynchronous operations. Try increasing the number of tasks (set in the `NUM_TASKS` constant of MainPage.xaml.cs) and reducing the number of iterations in `GetNumber` (change the `MIN_ITERATIONS` value). Run the collection scenario and compare the CPU activity of `MainPage::<GetNumberAsync>b__b`to that in the original CPU Usage diagnostic session. Try reducing the tasks and increasing the iterations.  
  
- Users often don’t care about the real performance of your app; they do care about the perceived performance and responsiveness of the app. The XAML UI Responsive tool shows you details of activity on the UI thread that effect perceived responsiveness.  
  
     Create a new session in the Diagnostic and Performance hub, and add both the XAML UI Responsive tool and the CPU Usage tool. Run the collection scenario. If you’ve read this far, the report probably doesn’t tell you anything that you haven’t already figured out, but the differences in the **UI Thread utilization** timeline graph for the two methods is striking. In complex, real-world apps, the combination of tools can be very helpful.  
  
## <a name="BKMK_MainPage_xaml"></a> MainPage.xaml  
  
```csharp  
<Page  
    x:Class="CpuUseDemo.MainPage"  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
    xmlns:local="using:CpuUseDemo"  
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"  
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"  
    mc:Ignorable="d">  
  
    <Page.Resources>  
        <Style TargetType="TextBox">  
            <Setter Property="FontFamily"  Value="Lucida Console" />  
        </Style>  
    </Page.Resources>  
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">  
        <Grid.RowDefinitions>  
            <RowDefinition Height="Auto" />  
            <RowDefinition Height="*" />  
        </Grid.RowDefinitions>  
        <StackPanel Grid.Row="0" Orientation="Horizontal"  Margin="0,40,0,0">  
            <Button Name="GetMaxNumberButton" Click="GetMaxNumberButton_Click"  Content="Get Max Number" />  
            <Button Name="GetMaxNumberAsyncButton" Click="GetMaxNumberAsyncButton_Click"  Content="Get Max Number Async" />  
        </StackPanel>  
        <StackPanel Grid.Row="1">  
            <TextBox Name="TextBox1" AcceptsReturn="True" />  
        </StackPanel>  
    </Grid>  
  
</Page>  
  
```  
  
## <a name="BKMK_MainPage_xaml_cs"></a> MainPage.xaml.cs  
  
```csharp  
using System;  
using System.Collections.Generic;  
using System.IO;  
using System.Linq;  
using System.Runtime.InteropServices.WindowsRuntime;  
using Windows.Foundation;  
using Windows.Foundation.Collections;  
using Windows.UI.Xaml;  
using Windows.UI.Xaml.Controls;  
using Windows.UI.Xaml.Controls.Primitives;  
using Windows.UI.Xaml.Data;  
using Windows.UI.Xaml.Input;  
using Windows.UI.Xaml.Media;  
using Windows.UI.Xaml.Navigation;  
using Windows.Foundation.Diagnostics;  
using System.Threading;  
using System.Threading.Tasks;  
using System.Collections.Concurrent;  
  
// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238  
  
namespace CpuUseDemo  
{  
    /// <summary>  
    /// An empty page that can be used on its own or navigated to within a Frame.  
    /// </summary>  
    public sealed partial class MainPage : Page  
    {  
        public MainPage()  
        {  
            this.InitializeComponent();  
        }  
  
        const int NUM_TASKS = 48;  
        const int MIN_ITERATIONS = int.MaxValue / 1000;  
        const int MAX_ITERATIONS = MIN_ITERATIONS + 10000;  
  
        long m_totalIterations = 0;  
        readonly object m_totalItersLock = new object();  
  
        private void GetMaxNumberButton_Click(object sender, RoutedEventArgs e)  
        {  
            GetMaxNumberAsyncButton.IsEnabled = false;  
            lock (m_totalItersLock)  
            {  
                m_totalIterations = 0;  
            }  
            List<int> tasks = new List<int>();  
            for (var i = 0; i < NUM_TASKS; i++)  
            {  
                var result = 0;  
                result = GetNumber();  
                tasks.Add(result);  
            }  
            var max = tasks.Max();  
            var s = GetOutputString("GetMaxNumberButton_Click", NUM_TASKS, max, m_totalIterations);  
            TextBox1.Text += s;  
            GetMaxNumberAsyncButton.IsEnabled = true;  
        }  
  
        private async void GetMaxNumberAsyncButton_Click(object sender, RoutedEventArgs e)  
        {  
            GetMaxNumberButton.IsEnabled = false;  
            GetMaxNumberAsyncButton.IsEnabled = false;  
            lock (m_totalItersLock)  
            {  
                m_totalIterations = 0;  
            }  
            var tasks = new ConcurrentBag<Task<int>>();  
            for (var i = 0; i < NUM_TASKS; i++)  
            {  
                tasks.Add(GetNumberAsync());  
            }  
            await Task.WhenAll(tasks.ToArray());  
            var max = 0;  
            foreach (var task in tasks)  
            {  
                max = Math.Max(max, task.Result);  
            }  
            var func = "GetMaxNumberAsyncButton_Click";  
            var outputText = GetOutputString(func, NUM_TASKS, max, m_totalIterations);  
            TextBox1.Text += outputText;  
            this.GetMaxNumberButton.IsEnabled = true;  
            GetMaxNumberAsyncButton.IsEnabled = true;  
        }  
  
        private int GetNumber()  
        {  
            var rand = new Random();  
            var iters = rand.Next(MIN_ITERATIONS, MAX_ITERATIONS);  
            var result = 0;  
            lock (m_totalItersLock)  
            {  
                m_totalIterations += iters;  
            }  
            // we're just spinning here  
            // and using Random to frustrate compiler optimizations  
            for (var i = 0; i < iters; i++)  
            {  
                result = rand.Next();  
            }  
            return result;  
        }  
  
        private Task<int> GetNumberAsync()  
        {  
            return Task<int>.Run(() =>  
            {  
                return GetNumber();  
            });  
        }  
  
        string GetOutputString(string func, int cycles, int max, long totalIters)  
        {  
            var fmt = "{0,-35}Tasks:{1,3}    Maximum:{2, 12}    Iterations:{3,12}\n";  
            return String.Format(fmt, func, cycles, max, totalIters);  
        }  
  
    }  
}  
  
```
