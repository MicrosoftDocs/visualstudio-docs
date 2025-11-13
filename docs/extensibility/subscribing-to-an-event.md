---
title: Subscribing to an Event
description: Learn how to create a tool window that responds to events in a running document table in the Visual Studio SDK.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- running document table (RDT), responding to events
- running document table (RDT), subscribing to events
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Subscribing to an Event

This walkthrough explains how to create a tool window that responds to events in a running document table (RDT). A tool window hosts a user control that implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents>. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.AdviseRunningDocTableEvents%2A> method connects the interface to the events.

## Subscribing to RDT Events

#### To create an extension with a tool window

1. Create a project named **RDTExplorer** using the VSIX template, and add a custom tool window item template named **RDTExplorerWindow**.

     For more information about creating an extension with a tool window, see [Creating an Extension with a Tool Window](../extensibility/creating-an-extension-with-a-tool-window.md).

#### To subscribe to RDT events

1. Open the RDTExplorerWindowControl.xaml file and delete the button named `button1`. Add a <xref:System.Windows.Forms.ListBox> control and accept the default name. The Grid element should look like this:

    ```xml
    <Grid>
        <StackPanel Orientation="Vertical" Margin="-10,10,10,0">
            <TextBlock Margin="10" HorizontalAlignment="Center">RDTExplorerWindow</TextBlock>
            <ListBox x:Name="listBox" Height="100" />
        </StackPanel>
    </Grid>
    ```

2. Open the RDTExplorerWindow.cs file in code view. Add the following using directives to the start of the file.

    ```csharp
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.Shell;
    using Microsoft.VisualStudio.Shell.Interop;
    ```

3. Modify the `RDTExplorerWindow` class so that, in addition to deriving from the <xref:Microsoft.VisualStudio.Shell.ToolWindowPane> class, it implements the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents> interface.

    ```csharp
    public class RDTExplorerWindow : ToolWindowPane, IVsRunningDocTableEvents
    {. . .}
    ```

4. Implement <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents>.

    - Implement the interface. Place the cursor on the IVsRunningDocTableEvents name. You should see a light bulb in the left margin. Click the Down arrow to the right of the light bulb and select **Implement interface**.

5. In each method in the interface, replace the line `throw new NotImplementedException();` with this:

    ```csharp
    return VSConstants.S_OK;
    ```

6. Add a cookie field to the RDTExplorerWindow class.

    ```csharp
    private uint rdtCookie;
    ```

     This holds the cookie that is returned by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.AdviseRunningDocTableEvents%2A> method.

7. Override the RDTExplorerWindow's Initialize() method to register for RDT events. You should always get services in the ToolWindowPane's Initialize() method, not in the constructor.

    ```csharp
    protected override void Initialize()
    {
        IVsRunningDocumentTable rdt = (IVsRunningDocumentTable)
        this.GetService(typeof(SVsRunningDocumentTable));
        rdt.AdviseRunningDocTableEvents(this, out rdtCookie);
    }
    ```

     The <xref:Microsoft.VisualStudio.Shell.Interop.SVsRunningDocumentTable> service is called to obtain an <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable> interface. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.AdviseRunningDocTableEvents%2A> method connects RDT events to an object that implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents>, in this case, a RDTExplorer object.

8. Update the RDTExplorerWindow's Dispose() method.

    ```csharp
    protected override void Dispose(bool disposing)
    {
        // Release the RDT cookie.
        IVsRunningDocumentTable rdt = (IVsRunningDocumentTable)
            Package.GetGlobalService(typeof(SVsRunningDocumentTable));
        rdt.UnadviseRunningDocTableEvents(rdtCookie);

        base.Dispose(disposing);
    }
    ```

     The <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocumentTable.UnadviseRunningDocTableEvents%2A> method deletes the connection between `RDTExplorer` and RDT event notification.

9. Add the following line to the body of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents.OnBeforeLastDocumentUnlock%2A> handler, just before the `return` statement.

    ```csharp
    public int OnBeforeLastDocumentUnlock(uint docCookie, uint dwRDTLockType, uint dwReadLocksRemaining, uint dwEditLocksRemaining)
    {
        ((RDTExplorerWindowControl)this.Content).listBox.Items.Add("Entering OnBeforeLastDocumentUnlock");
        return VSConstants.S_OK;
    }
    ```

10. Add a similar line to the body of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsRunningDocTableEvents.OnAfterFirstDocumentLock%2A> handler and to other events that you want to see in the list box.

    ```csharp
    public int OnAfterFirstDocumentLock(uint docCookie, uint dwRDTLockType, uint dwReadLocksRemaining, uint dwEditLocksRemaining)
    {
        ((RDTExplorerWindowControl)this.Content).listBox.Items.Add("Entering OnAfterFirstDocumentLock");
        return VSConstants.S_OK;
    }
    ```

11. Build the project and start debugging. The Visual Studio experimental instance appears.

12. Open the **RDTExplorerWindow** (**View / Other Windows / RDTExplorerWindow**).

     The **RDTExplorerWindow** window opens with an empty event list.

13. Open or create a solution.

     As `OnBeforeLastDocument` and `OnAfterFirstDocument` events are fired, notification of each event appears in the event list.
