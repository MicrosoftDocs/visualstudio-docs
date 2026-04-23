---
title: Managing Universal Windows Projects
description: To support Universal Windows apps, Visual Studio extensions that manage projects should be aware of the Universal Windows app project structure.
ms.date: 11/04/2016
ms.topic: how-to
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Manage Universal Windows projects

Universal Windows apps are apps that target both Windows 8.1 and Windows Phone 8.1, allowing developers to use code and other assets on both platforms. The shared code and resources are kept in a shared project, while the platform-specific code and resources are kept in separate projects, one for Windows and the other for Windows Phone. For more information about universal Windows apps, see [Universal Windows apps](/windows/uwp/get-started/create-uwp-apps). Visual Studio extensions that manage projects should be aware that universal Windows app projects have a structure that differs from single-platform apps. This walkthrough shows you how to navigate the shared project and manage the shared items.

### Navigate the shared project

1. Create a C# VSIX project named **TestUniversalProject**. (**File** > **New** > **Project** and then **C#** > **Extensibility** > **Visual Studio Package**). Add a **Custom Command** project item template (on the **Solution Explorer**, right-click the project node and select **Add** > **New Item**, then go to **Extensibility**). Name the file **TestUniversalProject**.

2. Add a reference to *Microsoft.VisualStudio.Shell.Interop.12.1.DesignTime.dll* and *Microsoft.VisualStudio.Shell.Interop.14.0.DesignTime.dll* (in the **Extensions** section).

3. Open *TestUniversalProject.cs* and add the following `using` directives:

    ```csharp
    using EnvDTE;
    using EnvDTE80;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.PlatformUI;
    using Microsoft.Internal.VisualStudio.PlatformUI;
    using System.Collections.Generic;
    using System.IO;
    using System.Windows.Forms;
    ```

4. In the `TestUniversalProject` class add a private field pointing to the **Output** window.

    ```csharp
    public sealed class TestUniversalProject
    {
        IVsOutputWindowPane output;
    . . .
    }
    ```

5. Set the reference to the output pane inside TestUniversalProject constructor:

    ```csharp
    private TestUniversalProject(Package package)
    {
        if (package == null)
        {
            throw new ArgumentNullException("package");
        }

        this.package = package;

        OleMenuCommandService commandService = this.ServiceProvider.GetService(typeof(IMenuCommandService)) as OleMenuCommandService;
        if (commandService != null)
        {
            CommandID menuCommandID = new CommandID(MenuGroup, CommandId);
            EventHandler eventHandler = this.ShowMessageBox;
            MenuCommand menuItem = new MenuCommand(eventHandler, menuCommandID);
            commandService.AddCommand(menuItem);
        }

        // get a reference to the Output window
        output = (IVsOutputWindowPane)ServiceProvider.GetService(typeof(SVsGeneralOutputWindowPane));
    }
    ```

6. Remove the existing code from the `ShowMessageBox` method:

    ```csharp
    private void ShowMessageBox(object sender, EventArgs e)
    {
    }
    ```

7. Get the DTE object, which we will use for several different purposes in this walkthrough. Also, make sure that a solution is loaded when the menu button is clicked.

    ```csharp
    private void ShowMessageBox(object sender, EventArgs e)
    {
        var dte = (EnvDTE.DTE)this.ServiceProvider.GetService(typeof(EnvDTE.DTE));
        if (dte.Solution != null)
        {
            . . .
        }
        else
        {
            MessageBox.Show("No solution is open");
            return;
        }
    }
    ```

8. Find the shared project. The shared project is a pure container; it does not build or produce outputs. The following method finds the first shared project in the solution by looking for the <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy> object that has the shared project capability.

    ```csharp
    private IVsHierarchy FindSharedProject()
    {
        var sln = (IVsSolution)this.ServiceProvider.GetService(typeof(SVsSolution));
        Guid empty = Guid.Empty;
        IEnumHierarchies enumHiers;

        //get all the projects in the solution
        ErrorHandler.ThrowOnFailure(sln.GetProjectEnum((uint)__VSENUMPROJFLAGS.EPF_LOADEDINSOLUTION, ref empty, out enumHiers));
        foreach (IVsHierarchy hier in ComUtilities.EnumerableFrom(enumHiers))
        {
            if (PackageUtilities.IsCapabilityMatch(hier, "SharedAssetsProject"))
            {
                return hier;
            }
        }
        return null;
    }
    ```

9. In the `ShowMessageBox` method, output the caption (the project name that appears in the **Solution Explorer**) of the shared project.

    ```csharp
    private void ShowMessageBox(object sender, EventArgs e)
    {
        var dte = (DTE)this.ServiceProvider.GetService(typeof(DTE));

        if (dte.Solution != null)
        {
            var sharedHier = this.FindSharedProject();
            if (sharedHier != null)
            {
                string sharedCaption = HierarchyUtilities.GetHierarchyProperty<string>(sharedHier, (uint)VSConstants.VSITEMID.Root,
                     (int)__VSHPROPID.VSHPROPID_Caption);
                output.OutputStringThreadSafe(string.Format("Found shared project: {0}\n", sharedCaption));
            }
            else
            {
                MessageBox.Show("Solution has no shared project");
                return;
            }
        }
        else
        {
            MessageBox.Show("No solution is open");
            return;
        }
    }
    ```

10. Get the active platform project. Platform projects are the projects that contain platform-specific code and resources. The following method uses the new field <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID7.VSHPROPID_SharedItemContextHierarchy> to get the active platform project.

    ```csharp
    private IVsHierarchy GetActiveProjectContext(IVsHierarchy hierarchy)
    {
        IVsHierarchy activeProjectContext;
        if (HierarchyUtilities.TryGetHierarchyProperty(hierarchy, (uint)VSConstants.VSITEMID.Root,
             (int)__VSHPROPID7.VSHPROPID_SharedItemContextHierarchy, out activeProjectContext))
        {
            return activeProjectContext;
        }
        else
        {
            return null;
        }
    }
    ```

11. In the `ShowMessageBox` method, output the caption of the active platform project.

    ```csharp
    private void ShowMessageBox(object sender, EventArgs e)
    {
        var dte = (DTE)this.ServiceProvider.GetService(typeof(DTE));

        if (dte.Solution != null)
        {
            var sharedHier = this.FindSharedProject();
            if (sharedHier != null)
            {
                string sharedCaption = HierarchyUtilities.GetHierarchyProperty<string>(sharedHier, (uint)VSConstants.VSITEMID.Root,
                     (int)__VSHPROPID.VSHPROPID_Caption);
                output.OutputStringThreadSafe(string.Format("Shared project: {0}\n", sharedCaption));

                var activePlatformHier = this.GetActiveProjectContext(sharedHier);
                if (activePlatformHier != null)
                {
                    string activeCaption = HierarchyUtilities.GetHierarchyProperty<string>(activePlatformHier,
                         (uint)VSConstants.VSITEMID.Root, (int)__VSHPROPID.VSHPROPID_Caption);
                    output.OutputStringThreadSafe(string.Format("Active platform project: {0}\n", activeCaption));
                }
                else
                {
                    MessageBox.Show("Shared project has no active platform project");
                }
            }
            else
            {
                MessageBox.Show("Solution has no shared project");
            }
        }
        else
        {
            MessageBox.Show("No solution is open");
        }
    }
    ```

12. Iterate through the platform projects. The following method gets all the importing (platform) projects from the shared project.

    ```csharp
    private IEnumerable<IVsHierarchy> EnumImportingProjects(IVsHierarchy hierarchy)
    {
        IVsSharedAssetsProject sharedAssetsProject;
        if (HierarchyUtilities.TryGetHierarchyProperty(hierarchy, (uint)VSConstants.VSITEMID.Root,
            (int)__VSHPROPID7.VSHPROPID_SharedAssetsProject, out sharedAssetsProject)
            && sharedAssetsProject != null)
        {
            foreach (IVsHierarchy importingProject in sharedAssetsProject.EnumImportingProjects())
            {
                yield return importingProject;
            }
        }
    }
    ```

    > [!IMPORTANT]
    > If the user has opened a C++ universal Windows app project in the experimental instance, the code above throws an exception. This is a known issue. To avoid the exception, replace the `foreach` block above with the following:

    ```csharp
    var importingProjects = sharedAssetsProject.EnumImportingProjects();
    for (int i = 0; i < importingProjects.Count; ++i)
    {
        yield return importingProjects[i];
    }
    ```

13. In the `ShowMessageBox` method, output the caption of each platform project. Insert the following code after the line that outputs the caption of the active platform project. Only the platform projects that are loaded appear in this list.

    ```csharp
    output.OutputStringThreadSafe("Platform projects:\n");

    IEnumerable<IVsHierarchy> projects = this.EnumImportingProjects(sharedHier);

    bool isActiveProjectSet = false;
    foreach (IVsHierarchy platformHier in projects)
    {
        string platformCaption = HierarchyUtilities.GetHierarchyProperty<string>(platformHier, (uint)VSConstants.VSITEMID.Root,
            (int)__VSHPROPID.VSHPROPID_Caption);
        output.OutputStringThreadSafe(string.Format(" * {0}\n", platformCaption));
    }
    ```

14. Change the active platform project. The following method sets the active project using <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.SetProperty%2A>.

    ```csharp
    private int SetActiveProjectContext(IVsHierarchy hierarchy, IVsHierarchy activeProjectContext)
    {
        return hierarchy.SetProperty((uint)VSConstants.VSITEMID.Root, (int)__VSHPROPID7.VSHPROPID_SharedItemContextHierarchy, activeProjectContext);
    }
    ```

15. In the `ShowMessageBox` method, change the active platform project. Insert this code inside the `foreach` block.

    ```csharp
    bool isActiveProjectSet = false;
    string platformCaption = null;
    foreach (IVsHierarchy platformHier in projects)
    {
        platformCaption = HierarchyUtilities.GetHierarchyProperty<string>(platformHier, (uint)VSConstants.VSITEMID.Root,
             (int)__VSHPROPID.VSHPROPID_Caption);
        output.OutputStringThreadSafe(string.Format(" * {0}\n", platformCaption));

        // if this project is neither the shared project nor the current active platform project,
        // set it to be the active project
        if (!isActiveProjectSet && platformHier != activePlatformHier)
        {
            this.SetActiveProjectContext(sharedHier, platformHier);
            activePlatformHier = platformHier;
            isActiveProjectSet = true;
        }
    }
    output.OutputStringThreadSafe("set active project: " + platformCaption +'\n');
    ```

16. Now try it out. Press F5 to launch the experimental instance. Create a C# universal hub app project in the experimental instance (in the **New Project** dialog box, **Visual C#** > **Windows** > **Windows 8** > **Universal** > **Hub App**). After the solution is loaded, go to the **Tools** menu and click **Invoke TestUniversalProject**, and then check the text in the **Output** pane. You should see something like the following:

    ```
    Found shared project: HubApp.Shared
    The active platform project: HubApp.Windows
    Platform projects:
     * HubApp.Windows
     * HubApp.WindowsPhone
    set active project: HubApp.WindowsPhone
    ```

### Manage the shared items in the platform project

1. Find the shared items in the platform project. The items in the shared project appear in the platform project as shared items. You can't see them in the **Solution Explorer**, but you can walk the project hierarchy to find them. The following method walks the hierarchy and collects all the shared items. It optionally outputs the caption of each item,. The shared items are identified by the new property <xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID7.VSHPROPID_IsSharedItem>.

    ```csharp
    private void InspectHierarchyItems(IVsHierarchy hier, uint itemid, int level, List<uint> itemIds, bool getSharedItems, bool printItems)
    {
        string caption = HierarchyUtilities.GetHierarchyProperty<string>(hier, itemid, (int)__VSHPROPID.VSHPROPID_Caption);
        if (printItems)
            output.OutputStringThreadSafe(string.Format("{0}{1}\n", new string('\t', level), caption));

        // if getSharedItems is true, inspect only shared items; if it's false, inspect only unshared items
        bool isSharedItem;
        if (HierarchyUtilities.TryGetHierarchyProperty(hier, itemid, (int)__VSHPROPID7.VSHPROPID_IsSharedItem, out isSharedItem)
            && (isSharedItem == getSharedItems))
        {
            itemIds.Add(itemid);
        }

        uint child;
        if (HierarchyUtilities.TryGetHierarchyProperty(hier, itemid, (int)__VSHPROPID.VSHPROPID_FirstChild, Unbox.AsUInt32, out child)
            && child != (uint)VSConstants.VSITEMID.Nil)
        {
            this.InspectHierarchyItems(hier, child, level + 1, itemIds, isSharedItem, printItems);

            while (HierarchyUtilities.TryGetHierarchyProperty(hier, child, (int)__VSHPROPID.VSHPROPID_NextSibling, Unbox.AsUInt32, out child)
                && child != (uint)VSConstants.VSITEMID.Nil)
            {
                this.InspectHierarchyItems(hier, child, level + 1, itemIds, isSharedItem, printItems);
            }
        }
    }
    ```

2. In the `ShowMessageBox` method, add the following code to walk the platform project hierarchy items. Insert it inside the `foreach` block.

    ```csharp
    output.OutputStringThreadSafe("Walk the active platform project:\n");
    var sharedItemIds = new List<uint>();
    this.InspectHierarchyItems(activePlatformHier, (uint)VSConstants.VSITEMID.Root, 1, sharedItemIds, true, true);
    ```

3. Read the shared items. The shared items appear in the platform project as hidden linked files, and you can read all the properties as ordinary linked files. The following code reads the full path of the first shared item.

    ```csharp
    var sharedItemId = sharedItemIds[0];
    string fullPath;
    ErrorHandler.ThrowOnFailure(((IVsProject)activePlatformHier).GetMkDocument(sharedItemId, out fullPath));
    output.OutputStringThreadSafe(string.Format("Shared item full path: {0}\n", fullPath));
    ```

4. Now try it out. Press **F5** to launch the experimental instance. Create a C# universal hub app project in the experimental instance (in the **New Project** dialog box, **Visual C#** > **Windows** > **Windows 8** > **Universal** > **Hub App**) go to the **Tools** menu and click **Invoke TestUniversalProject**, and then check the text in the **Output** pane. You should see something like the following:

    ```
    Found shared project: HubApp.Shared
    The active platform project: HubApp.Windows
    Platform projects:
     * HubApp.Windows
     * HubApp.WindowsPhone
    set active project: HubApp.WindowsPhone
    Walk the active platform project:
        HubApp.WindowsPhone
            <HubApp.Shared>
                App.xaml
                    App.xaml.cs
                Assets
                    DarkGray.png
                    LightGray.png
                    MediumGray.png
                Common
                    NavigationHelper.cs
                    ObservableDictionary.cs
                    RelayCommand.cs
                    SuspensionManager.cs
                DataModel
                    SampleData.json
                    SampleDataSource.cs
                HubApp.Shared.projitems
                Strings
                    en-US
                        Resources.resw
            Assets
                HubBackground.theme-dark.png
                HubBackground.theme-light.png
                Logo.scale-240.png
                SmallLogo.scale-240.png
                SplashScreen.scale-240.png
                Square71x71Logo.scale-240.png
                StoreLogo.scale-240.png
                WideLogo.scale-240.png
            HubPage.xaml
                HubPage.xaml.cs
            ItemPage.xaml
                ItemPage.xaml.cs
            Package.appxmanifest
            Properties
                AssemblyInfo.cs
            References
                .NET for Windows Store apps
                HubApp.Shared
                Windows Phone 8.1
            SectionPage.xaml
                SectionPage.xaml.cs
    ```

### Detect changes in platform projects and shared projects

1. You can use hierarchy and project events to detect changes in shared projects, just as you can for platform projects. However, the project items in the shared project are not visible, which means that certain events do not fire when shared project items are changed.

    Consider the sequence of events when a file in a project is renamed:

   1. The file name is changed on disk.

   2. The project file is updated to include the new name of the file.

      Hierarchy events (for example, <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents>) generally track the changes displayed in the UI, as in the **Solution Explorer**. Hierarchy events consider a file rename operation to consist of a file deletion and then a file addition. However, when invisible items are changed, the hierarchy event system fires an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted%2A> event but not an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded%2A> event. Therefore, if you rename a file in a platform project, you get both <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted%2A> and <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded%2A>, but if you rename a file in a shared project, you get only <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted%2A>.

      To track changes in project items, you can handle DTE project item events (the ones found in <xref:EnvDTE.ProjectItemsEventsClass>). However, if you are handling large numbers of events, you can get better performance handling the events in <xref:Microsoft.VisualStudio.Shell.Interop.IVsTrackProjectDocuments2>. In this walkthrough we show only the hierarchy events and the DTE events. In this procedure you add an event listener to a shared project and a platform project. Then, when you rename one file in a shared project and another file in a platform project, you can see the events that are fired for each rename operation.

      In this procedure you add an event listener to a shared project and a platform project. Then, when you rename one file in a shared project and another file in a platform project, you can see the events that are fired for each rename operation.

2. Add an event listener. Add a new class file to the project and call it *HierarchyEventListener.cs*.

3. Open the *HierarchyEventListener.cs* file and add the following using directives:

   ```csharp
   using Microsoft.VisualStudio.Shell.Interop;
   using Microsoft.VisualStudio;
   using System.IO;
   ```

4. Have the `HierarchyEventListener` class implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents>:

   ```csharp
   class HierarchyEventListener : IVsHierarchyEvents
   { }
   ```

5. Implement the members of <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents>, as in the code below.

   ```csharp
   class HierarchyEventListener : IVsHierarchyEvents
   {
       private IVsHierarchy hierarchy;
       IVsOutputWindowPane output;

       internal HierarchyEventListener(IVsHierarchy hierarchy, IVsOutputWindowPane outputWindow) {
            this.hierarchy = hierarchy;
            this.output = outputWindow;
       }

       int IVsHierarchyEvents.OnInvalidateIcon(IntPtr hIcon) {
           return VSConstants.S_OK;
       }

       int IVsHierarchyEvents.OnInvalidateItems(uint itemIDParent) {
           return VSConstants.S_OK;
       }

       int IVsHierarchyEvents.OnItemAdded(uint itemIDParent, uint itemIDSiblingPrev, uint itemIDAdded) {
           output.OutputStringThreadSafe("IVsHierarchyEvents.OnItemAdded: " + itemIDAdded + "\n");
           return VSConstants.S_OK;
       }

       int IVsHierarchyEvents.OnItemDeleted(uint itemID) {
           output.OutputStringThreadSafe("IVsHierarchyEvents.OnItemDeleted: " + itemID + "\n");
           return VSConstants.S_OK;
       }

       int IVsHierarchyEvents.OnItemsAppended(uint itemIDParent) {
           output.OutputStringThreadSafe("IVsHierarchyEvents.OnItemsAppended\n");
           return VSConstants.S_OK;
       }

       int IVsHierarchyEvents.OnPropertyChanged(uint itemID, int propID, uint flags) {
           output.OutputStringThreadSafe("IVsHierarchyEvents.OnPropertyChanged: item ID " + itemID + "\n");
           return VSConstants.S_OK;
       }
   }
   ```

6. In the same class add another event handler for the DTE event <xref:EnvDTE.ProjectItemsEventsClass.ItemRenamed>, which occurs whenever a project item is renamed.

   ```csharp
   public void OnItemRenamed(EnvDTE.ProjectItem projItem, string oldName)
   {
       output.OutputStringThreadSafe(string.Format("[Event] Renamed {0} to {1} in project {2}\n",
            oldName, Path.GetFileName(projItem.get_FileNames(1)), projItem.ContainingProject.Name));
   }
   ```

7. Sign up for the hierarchy events. You need to sign up separately for every project you are tracking. Add the following code in `ShowMessageBox`, one for the shared project, and the other for one of the platform projects.

   ```csharp
   // hook up the event listener for hierarchy events on the shared project
   HierarchyEventListener listener1 = new HierarchyEventListener(sharedHier, output);
   uint cookie1;
   sharedHier.AdviseHierarchyEvents(listener1, out cookie1);

   // hook up the event listener for hierarchy events on the
   active project
   HierarchyEventListener listener2 = new HierarchyEventListener(activePlatformHier, output);
   uint cookie2;
   activePlatformHier.AdviseHierarchyEvents(listener2, out cookie2);
   ```

8. Sign up for the DTE project item event <xref:EnvDTE.ProjectItemsEventsClass.ItemRenamed>. Add the following code after you hook up the second listener.

   ```csharp
   // hook up DTE events for project items
   Events2 dteEvents = (Events2)dte.Events;
   dteEvents.ProjectItemsEvents.ItemRenamed += listener1.OnItemRenamed;
   ```

9. Modify the shared item. You can't modify shared items in a platform project; instead, you must modify them in the shared project that is the actual owner of these items. You can get the corresponding item ID in the shared project with <xref:Microsoft.VisualStudio.Shell.Interop.IVsProject.IsDocumentInProject%2A>, giving it the shared item's full path. Then you can modify the shared item. The change is propagated to the platform projects.

    > [!IMPORTANT]
    > You should find out whether or not a project item is a shared item before modifying it.

     The following method modifies the name of a project item file.

    ```csharp
    private void ModifyFileNameInProject(IVsHierarchy project, string path)
    {
        int found;
        uint projectItemID;
        VSDOCUMENTPRIORITY[] priority = new VSDOCUMENTPRIORITY[1];
        if (ErrorHandler.Succeeded(((IVsProject)project).IsDocumentInProject(path, out found, priority, out projectItemID))
            && found != 0)
        {
            var name = DateTime.Now.Ticks.ToString() + Path.GetExtension(path);
            project.SetProperty(projectItemID, (int)__VSHPROPID.VSHPROPID_EditLabel, name);
            output.OutputStringThreadSafe(string.Format("Renamed {0} to {1}\n", path,name));
        }
    }
    ```

10. Call this method after all the other code in `ShowMessageBox` to modify the file name the item in the shared project. Insert this after the code that gets the full path of the item in the shared project.

    ```csharp
    // change the file name of an item in a shared project
    this.InspectHierarchyItems(activePlatformHier, (uint)VSConstants.VSITEMID.Root, 1, sharedItemIds, true, true);
    ErrorHandler.ThrowOnFailure(((IVsProject)activePlatformHier).GetMkDocument(sharedItemId, out fullPath));
    output.OutputStringThreadSafe(string.Format("Shared project item ID = {0}, full path = {1}\n", sharedItemId, fullPath));
    this.ModifyFileNameInProject(sharedHier, fullPath);
    ```

11. Build and run the project. Create a C# universal hub app in the experimental instance, go to the **Tools** menu and click **Invoke TestUniversalProject**, and check the text in the general output pane. The name of the first item in the shared project (we expect it to be the *App.xaml* file) should be changed, and you should see that the <xref:EnvDTE.ProjectItemsEventsClass.ItemRenamed> event has fired. In this case, since renaming *App.xaml* causes *App.xaml.cs* to be renamed as well, you should see four events (two for each platform project). (DTE events do not track the items in the shared project.) You should see two <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted%2A> events (one for each of platform projects), but no <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded%2A> events.

12. Now try renaming a file in a platform project, and you can see the difference in the events that get fired. Add the following code in `ShowMessageBox` after the call to `ModifyFileName`.

    ```csharp
    // change the file name of an item in a platform project
    var unsharedItemIds = new List<uint>();
    this.InspectHierarchyItems(activePlatformHier, (uint)VSConstants.VSITEMID.Root, 1, unsharedItemIds, false, false);

    var unsharedItemId = unsharedItemIds[0];
    string unsharedPath;
    ErrorHandler.ThrowOnFailure(((IVsProject)activePlatformHier).GetMkDocument(unsharedItemId, out unsharedPath));
    output.OutputStringThreadSafe(string.Format("Platform project item ID = {0}, full path = {1}\n", unsharedItemId, unsharedPath));

    this.ModifyFileNameInProject(activePlatformHier, unsharedPath);
    ```

13. Build and run the project. Create a C# Universal Project in the experimental instance, go to the **Tools** menu and click **Invoke TestUniversalProject**, and check the text in the general output pane. After the file in the platform project is renamed, you should see both an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemAdded%2A> event and an <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchyEvents.OnItemDeleted%2A> event. Since changing the file caused no other files to be changed, and since changes to items in a platform project don't get propagated anywhere, there is only one each of these events.
