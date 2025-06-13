---
title: Adding Search to a Tool Window
description: Add search functionality, including a search box, filtering, and a progress indicator, to a tool window in Visual Studio.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- tool windows, adding search
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Add search to a tool window

When you create or update a tool window in your extension, you can add the same search functionality that appears elsewhere in Visual Studio. This functionality includes the following features:

- A search box that's always located in a custom area of the toolbar.

- A progress indicator that's overlaid on the search box itself.

- The ability to show results as soon as you enter each character (instant search) or only after you choose the **Enter** key (search on demand).

- A list that shows terms for which you've searched most recently.

- The ability to filter searches by specific fields or aspects of the search targets.

By following this walkthrough, you'll learn how to perform the following tasks:

1. Create a VSPackage project.

2. Create a tool window that contains a UserControl with a read-only TextBox.

3. Add a search box to the tool window.

4. Add the search implementation.

5. Enable instant search and display of a progress bar.

6. Add a **Match case** option.

7. Add a **Search even lines only** filter.

## To create a VSIX project

1. Create a VSIX project named `TestToolWindowSearch` with a tool window named **TestSearch**. If you need help doing this, see [Creating an extension with a tool window](../extensibility/creating-an-extension-with-a-tool-window.md).

## To create a tool window

1. In the `TestToolWindowSearch` project, open the *TestSearchControl.xaml* file.

2. Replace the existing `<StackPanel>` block with the following block, which adds a read-only <xref:System.Windows.Controls.TextBox> to the <xref:System.Windows.Controls.UserControl> in the tool window.

    ```xaml
    <StackPanel Orientation="Vertical">
        <TextBox Name="resultsTextBox" Height="800.0"
            Width="800.0"
            IsReadOnly="True">
        </TextBox>
    </StackPanel>
    ```

3. In the *TestSearchControl.xaml.cs* file, add the following using directive:

    ```csharp
    using System.Text;
    ```

4. Remove the `button1_Click()` method.

     In the **TestSearchControl** class, add the following code.

     This code adds a public <xref:System.Windows.Controls.TextBox> property  named **SearchResultsTextBox** and a public string property named **SearchContent**. In the constructor, SearchResultsTextBox is set to the text box, and SearchContent is initialized to a newline-delimited set of strings. The content of the text box is also initialized to the set of strings.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VBCSharp/toolwindowsearch/cs/mycontrol.xaml.cs" id="Snippet1":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VBCSharp/toolwindowsearch/vb/mycontrol.xaml.vb" id="Snippet1":::
     ---

5. Build the project and start debugging. The experimental instance of Visual Studio appears.

6. On the menu bar, choose **View** > **Other Windows** > **TestSearch**.

     The tool window appears, but the search control doesn't yet appear.

## To add a search box to the tool window

1. In the *TestSearch.cs* file, add the following code to the `TestSearch` class. The code overrides the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowSearch.SearchEnabled%2A> property so that the get accessor returns `true`.

     To enable search, you must override the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowSearch.SearchEnabled%2A> property. The <xref:Microsoft.VisualStudio.Shell.ToolWindowPane> class implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowSearch> and provides a default implementation that doesn't enable search.

    ```csharp
    public override bool SearchEnabled
    {
        get { return true; }
    }
    ```

2. Build the project and start debugging. The experimental instance appears.

3. In the experimental instance of Visual Studio, open **TestSearch**.

     At the top of the tool window, a search control appears with a **Search** watermark and a magnifying-glass icon. However, search doesn't work yet because the search process hasn't been implemented.

## To add the search implementation
 When you enable search on a <xref:Microsoft.VisualStudio.Shell.ToolWindowPane>, as in the previous procedure, the tool window creates a search host. This host sets up and manages search processes, which always occur on a background thread. Because the <xref:Microsoft.VisualStudio.Shell.ToolWindowPane> class manages the creation of the search host and the setting up of the search, you need only create a search task and provide the search method. The search process occurs on a background thread, and calls to the tool window control occur on the UI thread. Therefore, you must use the [ThreadHelper.Invoke*](/previous-versions/visualstudio/visual-studio-2013/ee197798%28v%3dvs.120%29) method to manage any calls that you make in dealing with the control.

1. In the *TestSearch.cs* file, add the following `using` directives:

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using System.Text;
    using System.Windows.Controls;
    using Microsoft.Internal.VisualStudio.PlatformUI;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.PlatformUI;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;
    ```

2. In the `TestSearch` class, add the following code, which performs the following actions:

    - Overrides the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowSearch.CreateSearch%2A> method to create a search task.

    - Overrides the <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowSearch.ClearSearch%2A> method to restore the state of the text box. This method is called when a user cancels a search task and when a user sets or unsets options or filters. Both <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowSearch.CreateSearch%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsWindowSearch.ClearSearch%2A> are called on the UI thread. Therefore, you don't need to access the text box by means of the [ThreadHelper.Invoke*](/previous-versions/visualstudio/visual-studio-2013/ee197798%28v%3dvs.120%29) method.

    - Creates a class that's named `TestSearchTask` that inherits from <xref:Microsoft.VisualStudio.Shell.VsSearchTask>, which provides a default implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsSearchTask>.

         In `TestSearchTask`, the constructor sets a private field that references the tool window. To provide the search method, you override the <xref:Microsoft.VisualStudio.Shell.VsSearchTask.OnStartSearch%2A> and <xref:Microsoft.VisualStudio.Shell.VsSearchTask.OnStopSearch%2A> methods. The <xref:Microsoft.VisualStudio.Shell.VsSearchTask.OnStartSearch%2A> method is where you implement the search process. This process includes performing the search, displaying the search results in the text box, and calling the base class implementation of this method to report that the search is complete.

    ```csharp
    public override IVsSearchTask CreateSearch(uint dwCookie, IVsSearchQuery pSearchQuery, IVsSearchCallback pSearchCallback)
    {
        if (pSearchQuery == null || pSearchCallback == null)
            return null;
         return new TestSearchTask(dwCookie, pSearchQuery, pSearchCallback, this);
    }

    public override void ClearSearch()
    {
        TestSearchControl control = (TestSearchControl)this.Content;
        control.SearchResultsTextBox.Text = control.SearchContent;
    }

    internal class TestSearchTask : VsSearchTask
    {
        private TestSearch m_toolWindow;

        public TestSearchTask(uint dwCookie, IVsSearchQuery pSearchQuery, IVsSearchCallback pSearchCallback, TestSearch toolwindow)
            : base(dwCookie, pSearchQuery, pSearchCallback)
        {
            m_toolWindow = toolwindow;
        }

        protected override void OnStartSearch()
        {
            // Use the original content of the text box as the target of the search.
            var separator = new string[] { Environment.NewLine };
            TestSearchControl control = (TestSearchControl)m_toolWindow.Content;
            string[] contentArr = control.SearchContent.Split(separator, StringSplitOptions.None);

            // Get the search option.
            bool matchCase = false;
            // matchCase = m_toolWindow.MatchCaseOption.Value;

                // Set variables that are used in the finally block.
                StringBuilder sb = new StringBuilder("");
                uint resultCount = 0;
                this.ErrorCode = VSConstants.S_OK;

                try
                {
                    string searchString = this.SearchQuery.SearchString;

                    // Determine the results.
                    uint progress = 0;
                    foreach (string line in contentArr)
                    {
                        if (matchCase == true)
                        {
                            if (line.Contains(searchString))
                            {
                                sb.AppendLine(line);
                                resultCount++;
                            }
                        }
                        else
                            {
                                if (line.ToLower().Contains(searchString.ToLower()))
                                {
                                    sb.AppendLine(line);
                                    resultCount++;
                                }
                            }

                            // SearchCallback.ReportProgress(this, progress++, (uint)contentArr.GetLength(0));

                            // Uncomment the following line to demonstrate the progress bar.
                            // System.Threading.Thread.Sleep(100);
                        }
                    }
                    catch (Exception e)
                    {
                        this.ErrorCode = VSConstants.E_FAIL;
                    }
                    finally
                    {
                        ThreadHelper.Generic.Invoke(() =>
                        { ((TextBox)((TestSearchControl)m_toolWindow.Content).SearchResultsTextBox).Text = sb.ToString(); });

                        this.SearchResults = resultCount;
                    }

            // Call the implementation of this method in the base class.
            // This sets the task status to complete and reports task completion.
            base.OnStartSearch();
        }

        protected override void OnStopSearch()
        {
            this.SearchResults = 0;
        }
    }
    ```

3. Test your search implementation by performing the following steps:

    1. Rebuild the project and start debugging.

    2. In the experimental instance of Visual Studio, open the tool window again, enter some search text in the search window, and click **ENTER**.

         The correct results should appear.

## To customize the search behavior
 By changing the search settings, you can make a variety of changes in how the search control appears and how the search is carried out. For example, you can change the watermark (the default text that appears in the search box), the minimum and maximum width of the search control, and whether to show a progress bar. You can also change the point at which search results start to appear (on demand or instant search) and whether to show a list of terms for which you recently searched. You can find the complete list of settings in the <xref:Microsoft.VisualStudio.PlatformUI.SearchSettingsDataSource> class.

1. In the* TestSearch.cs* file, add the following code to the `TestSearch` class. This code enables instant search instead of on-demand search (meaning that the user doesn't have to click **ENTER**). The code overrides the `ProvideSearchSettings` method in the `TestSearch` class, which is necessary to change the default settings.

    ```csharp
    public override void ProvideSearchSettings(IVsUIDataSource pSearchSettings)
    {
        Utilities.SetValue(pSearchSettings,
            SearchSettingsDataSource.SearchStartTypeProperty.Name,
            (uint)VSSEARCHSTARTTYPE.SST_INSTANT);}
    ```

2. Test the new setting by rebuilding the solution and restarting the debugger.

     Search results appear every time that you enter a character in the search box.

3. In the `ProvideSearchSettings` method, add the following line, which enables the display of a progress bar.

    ```csharp
    public override void ProvideSearchSettings(IVsUIDataSource pSearchSettings)
    {
        Utilities.SetValue(pSearchSettings,
            SearchSettingsDataSource.SearchStartTypeProperty.Name,
             (uint)VSSEARCHSTARTTYPE.SST_INSTANT);
        Utilities.SetValue(pSearchSettings,
            SearchSettingsDataSource.SearchProgressTypeProperty.Name,
             (uint)VSSEARCHPROGRESSTYPE.SPT_DETERMINATE);
    }
    ```

     For the progress bar to appear, the progress must be reported. To report the progress, uncomment the following code in the `OnStartSearch` method of the `TestSearchTask` class:

    ```csharp
    SearchCallback.ReportProgress(this, progress++, (uint)contentArr.GetLength(0));
    ```

4. To slow processing enough that the progress bar is visible, uncomment the following line in the `OnStartSearch` method of the `TestSearchTask` class:

    ```csharp
    System.Threading.Thread.Sleep(100);
    ```

5. Test the new settings by rebuilding the solution and starting to debug.

     The progress bar appears in the search window (as a blue line below the search text box) every time that you perform a search.

## To enable users to refine their searches
 You can allow users to refine their searches by means of options such as **Match case** or **Match whole word**. Options can be boolean, which appear as check boxes, or commands, which appear as buttons. For this walkthrough, you'll create a boolean option.

1. In the *TestSearch.cs* file, add the following code to the `TestSearch` class. The code overrides the `SearchOptionsEnum` method, which allows the search implementation to detect whether a given option is on or off. The code in `SearchOptionsEnum` adds an option to match case to an <xref:Microsoft.VisualStudio.Shell.Interop.IVsEnumWindowSearchOptions> enumerator. The option to match case is also made available as the `MatchCaseOption` property.

    ```csharp
    private IVsEnumWindowSearchOptions m_optionsEnum;
    public override IVsEnumWindowSearchOptions SearchOptionsEnum
    {
        get
        {
            if (m_optionsEnum == null)
            {
                List<IVsWindowSearchOption> list = new List<IVsWindowSearchOption>();

                list.Add(this.MatchCaseOption);

                m_optionsEnum = new WindowSearchOptionEnumerator(list) as IVsEnumWindowSearchOptions;
            }
            return m_optionsEnum;
        }
    }

    private WindowSearchBooleanOption m_matchCaseOption;
    public WindowSearchBooleanOption MatchCaseOption
    {
        get
        {
            if (m_matchCaseOption == null)
            {
                m_matchCaseOption = new WindowSearchBooleanOption("Match case", "Match case", false);
            }
            return m_matchCaseOption;
        }
    }
    ```

2. In the `TestSearchTask` class, uncomment the following line in the `OnStartSearch` method:

    ```csharp
    matchCase = m_toolWindow.MatchCaseOption.Value;
    ```

3. Test the option:

    1. Build the project and start debugging. The experimental instance appears.

    2. In the tool window, choose the Down arrow on the right side of the text box.

         The **Match case** check box appears.

    3. Select the **Match case** check box, and then perform some searches.

## To add a search filter
 You can add search filters that allow users to refine the set of search targets. For example, you can filter files in File Explorer by the dates on which they were modified most recently and their file name extensions. In this walkthrough, you'll add a filter for even lines only. When the user chooses that filter, the search host adds the strings that you specify to the search query. You can then identify these strings inside your search method and filter the search targets accordingly.

1. In the *TestSearch.cs* file, add the following code to the `TestSearch` class. The code implements `SearchFiltersEnum` by adding a <xref:Microsoft.VisualStudio.PlatformUI.WindowSearchSimpleFilter> that specifies to filter the search results so that only even lines appear.

    ```csharp
    public override IVsEnumWindowSearchFilters SearchFiltersEnum
    {
        get
        {
            List<IVsWindowSearchFilter> list = new List<IVsWindowSearchFilter>();
            list.Add(new WindowSearchSimpleFilter("Search even lines only", "Search even lines only", "lines", "even"));
            return new WindowSearchFilterEnumerator(list) as IVsEnumWindowSearchFilters;
        }
    }

    ```

     Now the search control displays the search filter `Search even lines only`. When the user chooses the filter, the string `lines:"even"` appears in the search box. Other search criteria can appear at the same time as the filter. Search strings may appear before the filter, after the filter, or both.

2. In the *TestSearch.cs* file, add the following methods to the `TestSearchTask` class, which is in the `TestSearch` class. These methods support the `OnStartSearch` method, which you'll modify in the next step.

    ```csharp
    private string RemoveFromString(string origString, string stringToRemove)
    {
        int index = origString.IndexOf(stringToRemove);
        if (index == -1)
            return origString;
        else 
             return (origString.Substring(0, index) + origString.Substring(index + stringToRemove.Length)).Trim();
    }

    private string[] GetEvenItems(string[] contentArr)
    {
        int length = contentArr.Length / 2;
        string[] evenContentArr = new string[length];

        int indexB = 0;
        for (int index = 1; index < contentArr.Length; index += 2)
        {
            evenContentArr[indexB] = contentArr[index];
            indexB++;
        }

        return evenContentArr;
    }
    ```

3. In the `TestSearchTask` class, update the `OnStartSearch` method with the following code. This change updates the code to support the filter.

    ```csharp
    protected override void OnStartSearch()
    {
        // Use the original content of the text box as the target of the search. 
        var separator = new string[] { Environment.NewLine };
        string[] contentArr = ((TestSearchControl)m_toolWindow.Content).SearchContent.Split(separator, StringSplitOptions.None);

        // Get the search option. 
        bool matchCase = false;
        matchCase = m_toolWindow.MatchCaseOption.Value;

        // Set variables that are used in the finally block.
        StringBuilder sb = new StringBuilder("");
        uint resultCount = 0;
        this.ErrorCode = VSConstants.S_OK;

        try
        {
            string searchString = this.SearchQuery.SearchString;

            // If the search string contains the filter string, filter the content array. 
            string filterString = "lines:\"even\"";

            if (this.SearchQuery.SearchString.Contains(filterString))
            {
                // Retain only the even items in the array.
                contentArr = GetEvenItems(contentArr);

                // Remove 'lines:"even"' from the search string.
                searchString = RemoveFromString(searchString, filterString);
            }

            // Determine the results. 
            uint progress = 0;
            foreach (string line in contentArr)
            {
                if (matchCase == true)
                {
                    if (line.Contains(searchString))
                    {
                        sb.AppendLine(line);
                        resultCount++;
                    }
                }
                else
                {
                    if (line.ToLower().Contains(searchString.ToLower()))
                    {
                        sb.AppendLine(line);
                        resultCount++;
                    }
                }

                SearchCallback.ReportProgress(this, progress++, (uint)contentArr.GetLength(0));

                // Uncomment the following line to demonstrate the progress bar. 
                // System.Threading.Thread.Sleep(100);
            }
        }
        catch (Exception e)
        {
            this.ErrorCode = VSConstants.E_FAIL;
        }
        finally
        {
            ThreadHelper.Generic.Invoke(() =>
            { ((TextBox)((TestSearchControl)m_toolWindow.Content).SearchResultsTextBox).Text = sb.ToString(); });

            this.SearchResults = resultCount;
        }

        // Call the implementation of this method in the base class. 
        // This sets the task status to complete and reports task completion. 
        base.OnStartSearch();
    }
    ```

4. Test your code.

5. Build the project and start debugging. In the experimental instance of Visual Studio, open the tool window, and then choose the Down arrow on the search control.

     The **Match case** check box and the **Search even lines only** filter appear.

6. Choose the filter.

     The search box contains **lines:"even"**, and the following results appear:

     2 good

     4 Good

     6 Goodbye

7. Delete `lines:"even"` from the search box, select the **Match case** check box, and then enter `g` in the search box.

     The following results appear:

     1 go

     2 good

     5 goodbye

8. Choose the X on the right side of the search box.

     The search is cleared, and the original contents appear. However, the **Match case** check box is still selected.
