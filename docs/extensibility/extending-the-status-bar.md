---
title: Extending the Status Bar
description: Learn how to extend the Visual Studio status bar at the bottom of the IDE, which displays information.
ms.date: 11/06/2025
ms.topic: how-to
helpviewer_keywords:
- status bars, about status bars
- status bars, overview
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Extend the status bar

You can use the Visual Studio status bar at the bottom of the IDE to display information.

 When you extend the status bar, you can display information and UI in four regions: the feedback region, the progress bar, the animation region, and the designer region. The feedback region allows you to display text and highlight the displayed text. The progress bar shows incremental progress for short-running operations such as saving a file. The animation region displays a continuously-looped animation for long-running operations or operation of undetermined length, such as building multiple projects in a solution. And the designer region shows the line and column number of the cursor location.

 You can get the status bar by using the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbar> interface (from the <xref:Microsoft.VisualStudio.Shell.Interop.SVsStatusbar> service). In addition, any object sited on a window frame can register as a status bar client object by implementing the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser> interface. Whenever a window is activated, Visual Studio queries the object sited on that window for the `IVsStatusbarUser` interface. If found, it calls the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser.SetInfo%2A> method on the returned interface and the object can update the status bar from within that method. Document windows, for example, can use the <xref:Microsoft.VisualStudio.Shell.Interop.IVsStatusbarUser.SetInfo%2A> method to update information in the designer region when they become active.

 The following procedures assume that you understand how to create a VSIX project and add a custom menu command. For information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

## Modify the status bar
 This procedure shows you how to set and get text, display static text, and highlight the displayed text in the feedback region of the status bar.

### Read and write to the status bar

1. Create a VSIX project named **TestStatusBarExtension** and add a menu command named **TestStatusBarCommand**.

2. In *TestStatusBarCommand.cs*, replace the command handler method code (`MenuItemCallback`) with the following:

    ```csharp
    private void MenuItemCallback(object sender, EventArgs e)
    {
        IVsStatusbar statusBar = (IVsStatusbar)ServiceProvider.GetService(typeof(SVsStatusbar));

        // Make sure the status bar is not frozen
        int frozen;

        statusBar.IsFrozen(out frozen);

        if (frozen != 0)
        {
            statusBar.FreezeOutput(0);
        }

        // Set the status bar text and make its display static.
        statusBar.SetText("We just wrote to the status bar.");

        // Freeze the status bar.
        statusBar.FreezeOutput(1);

        // Get the status bar text.
        string text;
        statusBar.GetText(out text);
        System.Windows.Forms.MessageBox.Show(text);

        // Clear the status bar text.
        statusBar.FreezeOutput(0);
        statusBar.Clear();
    }
    ```

3. Compile the code and start debugging.

4. Open the **Tools** menu in the experimental instance of Visual Studio. Select the **Invoke TestStatusBarCommand** button.

   The text in the status bar now shows **We just wrote to the status bar.** and the message box that appears uses the same text.

### Update the progress bar

The following procedure shows how to initialize and update the progress bar.

1. Open the *TestStatusBarCommand.cs* file and replace the `MenuItemCallback` method with the following code:

    ```csharp
    private void MenuItemCallback(object sender, EventArgs e)
    {
        IVsStatusbar statusBar = (IVsStatusbar)ServiceProvider.GetService(typeof(SVsStatusbar));
        uint cookie = 0;
        string label = "Writing to the progress bar";

        // Initialize the progress bar.
        statusBar.Progress(ref cookie, 1, "", 0, 0);

        for (uint i = 0, total = 20; i <= total; i++)
        {
            // Display progress every second.
            statusBar.Progress(ref cookie, 1, label, i, total);
            System.Threading.Thread.Sleep(1000);
        }

        // Clear the progress bar.
        statusBar.Progress(ref cookie, 0, "", 0, 0);
    }
    ```

1. Compile the code and start debugging.

1. Open the **Tools** menu in the experimental instance of Visual Studio. Select the **Invoke TestStatusBarCommand** button.

   The text in the status bar now shows **Writing to the progress bar.** The progress bar updates every second for 20 seconds, and the status and progress bars are cleared.

### Display an animation

1. The status bar displays a looping animation that indicates either a long-running operation (for example, building multiple projects in a solution). If you don't see this animation, make sure you have the correct **Tools** > **Options** settings:

   :::moniker range="visualstudio"

   1. Open the **Tools** > **Options** pane and expand the **All Settings** > **Environment** > **Visual Experience** > **Effects** section.

   1. Under **Enable rich client visual experience**, select **Automatic (Enable only when recommended)**. 

   :::moniker-end
   :::moniker range="<=vs-2022"

   1. Open the **Tools** > **Options** dialog and expand the **Environment** > **General** section.

   1. Clear the **Automatically adjust visual experience based on client performance** checkbox.

   1. Select the **Enable rich client visual experience** suboption checkbox.

   1. Select **OK**.

   :::moniker-end

   The animation now displays when you build the project in your experimental instance of Visual Studio.

   This procedure shows how to display the standard Visual Studio animation, which represents building a project or solution.

1. Open the *TestStatusBarCommand.cs* file and replace the `MenuItemCallback` method with the following code:

    ```csharp
    private void MenuItemCallback(object sender, EventArgs e)
    {
        IVsStatusbar statusBar =(IVsStatusbar)ServiceProvider.GetService(typeof(SVsStatusbar));

        // Use the standard Visual Studio icon for building.
        object icon = (short)Microsoft.VisualStudio.Shell.Interop.Constants.SBAI_Build;

        // Display the icon in the Animation region.
        statusBar.Animation(1, ref icon);

        // The message box pauses execution for you to look at the animation.
        System.Windows.Forms.MessageBox.Show("showing?");

        // Stop the animation.
        statusBar.Animation(0, ref icon);
    }
    ```

1. Compile the code and start debugging.

1. Open the **Tools** menu in the experimental instance of Visual Studio and select the **Invoke TestStatusBarCommand** button.

   When you see the message box, you should also see the animation in the status bar on the far right. When you dismiss the message box, the animation disappears.
