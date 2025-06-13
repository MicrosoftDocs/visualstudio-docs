---
title: Use a shortcut key with an editor extension
description: Learn how to add a view adornment to a text view by using a shortcut key. This walkthrough is based on the viewport adornment editor template.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - link keystrokes to commands
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Use a shortcut key with an editor extension

You can respond to shortcut keys in your editor extension. The following walkthrough shows how to add a view adornment to a text view by using a shortcut key. This walkthrough is based on the viewport adornment editor template, and it allows you to add the adornment by using the + character.

## Create a Managed Extensibility Framework (MEF) Project

1. Create a C# VSIX project. (In the **New Project** dialog, select **Visual C# / Extensibility**, then **VSIX Project**.) Name the solution `KeyBindingTest`.

2. Add an Editor Text Adornment item template to the project and name it `KeyBindingTest`. For more information, see [Create an Extension with an Editor Item Template](../extensibility/creating-an-extension-with-an-editor-item-template.md).

3. Add the following references and set **CopyLocal** to `false`:

    Microsoft.VisualStudio.Editor

    Microsoft.VisualStudio.OLE.Interop

    Microsoft.VisualStudio.Shell.14.0

    Microsoft.VisualStudio.TextManager.Interop

   In the KeyBindingTest class file, change the class name to PurpleCornerBox. Use the light bulb that appears in the left margin to make the other appropriate changes. Inside the constructor, change the name of the adornment layer from **KeyBindingTest** to **PurpleCornerBox**:

```csharp
this.layer = view.GetAdornmentLayer("PurpleCornerBox");
```

In the KeyBindingTestTextViewCreationListener.cs class file, change the name of the AdornmentLayer from **KeyBindingTest** to **PurpleCornerBox**:

```csharp
[Export(typeof(AdornmentLayerDefinition))]
[Name("PurpleCornerBox")]
[Order(After = PredefinedAdornmentLayers.Selection, Before = PredefinedAdornmentLayers.Text)]
public AdornmentLayerDefinition editorAdornmentLayer;
```

## Handle TYPECHAR command
Prior to Visual Studio 2017 version 15.6 the only way to handle commands in an editor extension was implementing an <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget> based command filter. Visual Studio 2017 version 15.6 introduced a modern simplified approach based on editor command handlers. The next two sections demonstrate how to handle a command using both the legacy and modern approach.

## Define the command filter (prior to Visual Studio 2017 version 15.6)

 The command filter is an implementation of <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>, which handles the command by instantiating the adornment.

1. Add a class file and name it `KeyBindingCommandFilter`.

2. Add the following using directives.

    ```csharp
    using System;
    using System.Runtime.InteropServices;
    using Microsoft.VisualStudio.OLE.Interop;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.Text.Editor;

    ```

3. The class named KeyBindingCommandFilter should inherit from <xref:Microsoft.VisualStudio.OLE.Interop.IOleCommandTarget>.

    ```csharp
    internal class KeyBindingCommandFilter : IOleCommandTarget
    ```

4. Add private fields for the text view, the next command in the command chain, and a flag to represent whether the command filter has already been added.

    ```csharp
    private IWpfTextView m_textView;
    internal IOleCommandTarget m_nextTarget;
    internal bool m_added;
    internal bool m_adorned;
    ```

5. Add a constructor that sets the text view.

    ```csharp
    public KeyBindingCommandFilter(IWpfTextView textView)
    {
        m_textView = textView;
        m_adorned = false;
    }
    ```

6. Implement the `QueryStatus()` method as follows.

    ```csharp
    int IOleCommandTarget.QueryStatus(ref Guid pguidCmdGroup, uint cCmds, OLECMD[] prgCmds, IntPtr pCmdText)
    {
        return m_nextTarget.QueryStatus(ref pguidCmdGroup, cCmds, prgCmds, pCmdText);
    }
    ```

7. Implement the `Exec()` method so that it adds a purple box to the view if a plus sign (**+**) character is typed.

    ```csharp
    int IOleCommandTarget.Exec(ref Guid pguidCmdGroup, uint nCmdID, uint nCmdexecopt, IntPtr pvaIn, IntPtr pvaOut)
    {
        if (m_adorned == false)
        {
            char typedChar = char.MinValue;

            if (pguidCmdGroup == VSConstants.VSStd2K && nCmdID == (uint)VSConstants.VSStd2KCmdID.TYPECHAR)
            {
                typedChar = (char)(ushort)Marshal.GetObjectForNativeVariant(pvaIn);
                if (typedChar.Equals('+'))
                {
                    new PurpleCornerBox(m_textView);
                    m_adorned = true;
                }
            }
        }
        return m_nextTarget.Exec(ref pguidCmdGroup, nCmdID, nCmdexecopt, pvaIn, pvaOut);
    }

    ```

## Add the command filter (prior to Visual Studio 2017 version 15.6)
 The adornment provider must add a command filter to the text view. In this example, the provider implements <xref:Microsoft.VisualStudio.Editor.IVsTextViewCreationListener> to listen to text view creation events. This adornment provider also exports the adornment layer, which defines the Z-order of the adornment.

1. In the KeyBindingTestTextViewCreationListener file, add the following using directives:

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio;
    using Microsoft.VisualStudio.OLE.Interop;
    using Microsoft.VisualStudio.Utilities;
    using Microsoft.VisualStudio.Editor;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.TextManager.Interop;

    ```

2. To get the text view adapter, you must import the <xref:Microsoft.VisualStudio.Editor.IVsEditorAdaptersFactoryService>.

    ```csharp
    [Import(typeof(IVsEditorAdaptersFactoryService))]
    internal IVsEditorAdaptersFactoryService editorFactory = null;

    ```

3. Change the <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener.TextViewCreated%2A> method so that it adds the `KeyBindingCommandFilter`.

    ```csharp
    public void TextViewCreated(IWpfTextView textView)
    {
        AddCommandFilter(textView, new KeyBindingCommandFilter(textView));
    }
    ```

4. The `AddCommandFilter` handler gets the text view adapter and adds the command filter.

    ```csharp
    void AddCommandFilter(IWpfTextView textView, KeyBindingCommandFilter commandFilter)
    {
        if (commandFilter.m_added == false)
        {
            //get the view adapter from the editor factory
            IOleCommandTarget next;
            IVsTextView view = editorFactory.GetViewAdapter(textView);

            int hr = view.AddCommandFilter(commandFilter, out next);

            if (hr == VSConstants.S_OK)
            {
                commandFilter.m_added = true;
                 //you'll need the next target for Exec and QueryStatus
                if (next != null)
                commandFilter.m_nextTarget = next;
            }
        }
    }
    ```

## Implement a command handler (starting in Visual Studio 2017 version 15.6)

First, update the project's Nuget references to reference the latest editor API:

1. Right-click on the project and select **Manage Nuget Packages**.

2. In **Nuget Package Manager**, select the **Updates** tab, select the **Select all packages** checkbox, and then select **Update**.

The command handler is an implementation of <xref:Microsoft.VisualStudio.Commanding.ICommandHandler%601>, which handles the command by instantiating the adornment.

1. Add a class file and name it `KeyBindingCommandHandler`.

2. Add the following using directives.

   ```csharp
   using Microsoft.VisualStudio.Commanding;
   using Microsoft.VisualStudio.Text.Editor;
   using Microsoft.VisualStudio.Text.Editor.Commanding.Commands;
   using Microsoft.VisualStudio.Utilities;
   using System.ComponentModel.Composition;
   ```

3. The class named KeyBindingCommandHandler should inherit from `ICommandHandler<TypeCharCommandArgs>`, and export it as <xref:Microsoft.VisualStudio.Commanding.ICommandHandler>:

   ```csharp
   [Export(typeof(ICommandHandler))]
   [ContentType("text")]
   [Name("KeyBindingTest")]
   internal class KeyBindingCommandHandler : ICommandHandler<TypeCharCommandArgs>
   ```

4. Add a display name of the command handler:

   ```csharp
   public string DisplayName => "KeyBindingTest";
   ```

5. Implement the `GetCommandState()` method as follows. Because this command handler handles core editor TYPECHAR command, it can delegate enabling the command to the core editor.

   ```csharp
   public CommandState GetCommandState(TypeCharCommandArgs args)
   {
       return CommandState.Unspecified;
   }
   ```

6. Implement the `ExecuteCommand()` method so that it adds a purple box to the view if a plus sign (**+**) character is typed.

   ```csharp
   public bool ExecuteCommand(TypeCharCommandArgs args, CommandExecutionContext executionContext)
   {
       if (args.TypedChar == '+')
       {
           bool alreadyAdorned = args.TextView.Properties.TryGetProperty(
               "KeyBindingTextAdorned", out bool adorned) && adorned;
           if (!alreadyAdorned)
           {
               new PurpleCornerBox((IWpfTextView)args.TextView);
               args.TextView.Properties.AddProperty("KeyBindingTextAdorned", true);
           }
       }

       return false;
   }
   ```

   7. Copy adornment layer definition from *KeyBindingTestTextViewCreationListener.cs* file to the *KeyBindingCommandHandler.cs* and then delete *KeyBindingTestTextViewCreationListener.cs* file:

   ```csharp
   /// <summary>
   /// Defines the adornment layer for the adornment. This layer is ordered
   /// after the selection layer in the Z-order.
   /// </summary>
   [Export(typeof(AdornmentLayerDefinition))]
   [Name("PurpleCornerBox")]
   [Order(After = PredefinedAdornmentLayers.Selection, Before = PredefinedAdornmentLayers.Text)]
   private AdornmentLayerDefinition editorAdornmentLayer;
   ```

## Make the adornment appear on every line

The original adornment appeared on every character 'a' in a text file. Now that we have changed the code to add the adornment in response to the **+** character, it adds the adornment only on the line where the **+** character is typed. We can change the adornment code so that the adornment once more appears on every 'a'.

In the *KeyBindingTest.cs* file, change the `CreateVisuals()` method to iterate through all the lines in the view to decorate the 'a' character.

```csharp
private void CreateVisuals(ITextViewLine line)
{
    IWpfTextViewLineCollection textViewLines = this.view.TextViewLines;

    foreach (ITextViewLine textViewLine in textViewLines)
    {
        if (textViewLine.ToString().Contains("a"))
        {
            // Loop through each character, and place a box around any 'a'
            for (int charIndex = textViewLine.Start; charIndex < textViewLine.End; charIndex++)
            {
                if (this.view.TextSnapshot[charIndex] == 'a')
                {
                    SnapshotSpan span = new SnapshotSpan(this.view.TextSnapshot, Span.FromBounds(charIndex, charIndex + 1));
                    Geometry geometry = textViewLines.GetMarkerGeometry(span);
                    if (geometry != null)
                    {
                        var drawing = new GeometryDrawing(this.brush, this.pen, geometry);
                        drawing.Freeze();

                        var drawingImage = new DrawingImage(drawing);
                        drawingImage.Freeze();

                        var image = new Image
                        {
                            Source = drawingImage,
                        };

                        // Align the image with the top of the bounds of the text geometry
                        Canvas.SetLeft(image, geometry.Bounds.Left);
                        Canvas.SetTop(image, geometry.Bounds.Top);

                        this.layer.AddAdornment(AdornmentPositioningBehavior.TextRelative, span, null, image, null);
                    }
                }
            }
        }
    }
}
```

## Build and test the code

1. Build the KeyBindingTest solution and run it in the experimental instance.

2. Create or open a text file. Type some words containing the character 'a', and then type **+** anywhere in the text view.

     A purple square should appear on every 'a' character in the file.
