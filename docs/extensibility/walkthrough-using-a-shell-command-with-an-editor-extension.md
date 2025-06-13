---
title: Use a shell command with an editor extension
description: Learn how to add an adornment to a text view in the editor by invoking a menu command. From a VSPackage, you can add features like menu commands to the editor.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- editors [Visual Studio SDK], new - add a menu command
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Walkthrough: Use a shell command with an editor extension

From a VSPackage, you can add features such as menu commands to the editor. This walkthrough shows how to add an adornment to a text view in the editor by invoking a menu command.

 This walkthrough demonstrates the use of a VSPackage together with a Managed Extensibility Framework (MEF) component part. You must use a VSPackage to register the menu command with the Visual Studio shell. And, you can use the command to access the MEF component part.

## Create an extension with a menu command
 Create a VSPackage that puts a menu command named **Add Adornment** on the **Tools** menu.

1. Create a C# VSIX project named `MenuCommandTest`, and add a Custom Command item template name **AddAdornment**. For more information, see [Create an extension with a menu command](../extensibility/creating-an-extension-with-a-menu-command.md).

2. A solution named MenuCommandTest opens. The MenuCommandTestPackage file has the code that creates the menu command and puts it on the **Tools** menu. At this point, the command just causes a message box to appear. Later steps will show how to change this to display the comment adornment.

3. Open the *source.extension.vsixmanifest* file in the VSIX Manifest Editor. The `Assets` tab should have a row for a Microsoft.VisualStudio.VsPackage named MenuCommandTest.

4. Save and close the *source.extension.vsixmanifest* file.

## Add a MEF extension to the command extension

1. In **Solution Explorer**, right-click the solution node, click **Add**, and then click **New Project**. In the **Add New Project** dialog box, click **Extensibility** under **Visual C#**, then **VSIX Project**. Name the project `CommentAdornmentTest`.

2. Because this project will interact with the strong-named VSPackage assembly, you must sign the assembly. You can reuse the key file already created for the VSPackage assembly.

    1. Open the project properties and select the **Signing** tab.

    2. Select **Sign the assembly**.

    3. Under **Choose a strong name key file**, select the *Key.snk* file that was generated for the MenuCommandTest assembly.

## Refer to the MEF extension in the VSPackage project
 Because you are adding a MEF component to the VSPackage, you must specify both kinds of assets in the manifest.

> [!NOTE]
> For more information about MEF, see [Managed Extensibility Framework (MEF)](/dotnet/framework/mef/index).

### To refer to the MEF component in the VSPackage project

1. In the MenuCommandTest project, open the *source.extension.vsixmanifest* file in the VSIX Manifest Editor.

2. On the **Assets** tab, click **New**.

3. In the **Type** list, choose **Microsoft.VisualStudio.MefComponent**.

4. In the **Source** list, choose **A project in current solution**.

5. In the **Project** list, choose **CommentAdornmentTest**.

6. Save and close the *source.extension.vsixmanifest* file.

7. Make sure that the MenuCommandTest project has a reference to the CommentAdornmentTest project.

8. In the CommentAdornmentTest project, set the project to produce an assembly. In the **Solution Explorer**, select the project and look in the **Properties** window for the **Copy Build Output to OutputDirectory** property, and set it to **true**.

## Define a comment adornment
 The comment adornment itself consists of an <xref:Microsoft.VisualStudio.Text.ITrackingSpan> that tracks the selected text, and some strings that represent the author and the description of the text.

#### To define a comment adornment

1. In the CommentAdornmentTest project, add a new class file and name it `CommentAdornment`.

2. Add the following references:

    1. Microsoft.VisualStudio.CoreUtility

    2. Microsoft.VisualStudio.Text.Data

    3. Microsoft.VisualStudio.Text.Logic

    4. Microsoft.VisualStudio.Text.UI

    5. Microsoft.VisualStudio.Text.UI.Wpf

    6. System.ComponentModel.Composition

    7. PresentationCore

    8. PresentationFramework

    9. WindowsBase

3. Add the following `using` directive.

    ```csharp
    using Microsoft.VisualStudio.Text;
    ```

4. The file should contain a class named `CommentAdornment`.

    ```csharp
    internal class CommentAdornment
    ```

5. Add three fields to the `CommentAdornment` class for the <xref:Microsoft.VisualStudio.Text.ITrackingSpan>, the author, and the description.

    ```csharp
    public readonly ITrackingSpan Span;
    public readonly string Author;
    public readonly string Text;
    ```

6. Add a constructor that initializes the fields.

    ```csharp
    public CommentAdornment(SnapshotSpan span, string author, string text)
    {
        this.Span = span.Snapshot.CreateTrackingSpan(span, SpanTrackingMode.EdgeExclusive);
        this.Author = author;
        this.Text = text;
    }
    ```

## Create a visual element for the adornment
 Define a visual element for your adornment. For this walkthrough, define a control that inherits from the Windows Presentation Foundation (WPF) class <xref:System.Windows.Controls.Canvas>.

1. Create a class in the CommentAdornmentTest project, and name it `CommentBlock`.

2. Add the following `using` directives.

    ```csharp
    using Microsoft.VisualStudio.Text;
    using System;
    using System.Windows;
    using System.Windows.Controls;
    using System.Windows.Media;
    using System.Windows.Shapes;
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Utilities;
    ```

3. Make the `CommentBlock` class inherit from <xref:System.Windows.Controls.Canvas>.

    ```csharp
    internal class CommentBlock : Canvas
    { }
    ```

4. Add some private fields to define the visual aspects of the adornment.

    ```csharp
    private Geometry textGeometry;
    private Grid commentGrid;
    private static Brush brush;
    private static Pen solidPen;
    private static Pen dashPen;
    ```

5. Add a constructor that defines the comment adornment and adds the relevant text.

    ```csharp
    public CommentBlock(double textRightEdge, double viewRightEdge,
            Geometry newTextGeometry, string author, string body)
    {
        if (brush == null)
        {
            brush = new SolidColorBrush(Color.FromArgb(0x20, 0x00, 0xff, 0x00));
            brush.Freeze();
            Brush penBrush = new SolidColorBrush(Colors.Green);
            penBrush.Freeze();
            solidPen = new Pen(penBrush, 0.5);
            solidPen.Freeze();
            dashPen = new Pen(penBrush, 0.5);
            dashPen.DashStyle = DashStyles.Dash;
            dashPen.Freeze();
        }

        this.textGeometry = newTextGeometry;

        TextBlock tb1 = new TextBlock();
        tb1.Text = author;
        TextBlock tb2 = new TextBlock();
        tb2.Text = body;

        const int MarginWidth = 8;
        this.commentGrid = new Grid();
        this.commentGrid.RowDefinitions.Add(new RowDefinition());
        this.commentGrid.RowDefinitions.Add(new RowDefinition());
        ColumnDefinition cEdge = new ColumnDefinition();
        cEdge.Width = new GridLength(MarginWidth);
        ColumnDefinition cEdge2 = new ColumnDefinition();
        cEdge2.Width = new GridLength(MarginWidth);
        this.commentGrid.ColumnDefinitions.Add(cEdge);
        this.commentGrid.ColumnDefinitions.Add(new ColumnDefinition());
        this.commentGrid.ColumnDefinitions.Add(cEdge2);

        System.Windows.Shapes.Rectangle rect = new System.Windows.Shapes.Rectangle();
        rect.RadiusX = 6;
        rect.RadiusY = 3;
        rect.Fill = brush;
        rect.Stroke = Brushes.Green;

            Size inf = new Size(double.PositiveInfinity, double.PositiveInfinity);
            tb1.Measure(inf);
            tb2.Measure(inf);
            double middleWidth = Math.Max(tb1.DesiredSize.Width, tb2.DesiredSize.Width);
            this.commentGrid.Width = middleWidth + 2 * MarginWidth;

        Grid.SetColumn(rect, 0);
        Grid.SetRow(rect, 0);
        Grid.SetRowSpan(rect, 2);
        Grid.SetColumnSpan(rect, 3);
        Grid.SetRow(tb1, 0);
        Grid.SetColumn(tb1, 1);
        Grid.SetRow(tb2, 1);
        Grid.SetColumn(tb2, 1);
        this.commentGrid.Children.Add(rect);
        this.commentGrid.Children.Add(tb1);
        this.commentGrid.Children.Add(tb2);

        Canvas.SetLeft(this.commentGrid, Math.Max(viewRightEdge - this.commentGrid.Width - 20.0, textRightEdge + 20.0));
        Canvas.SetTop(this.commentGrid, textGeometry.GetRenderBounds(solidPen).Top);

        this.Children.Add(this.commentGrid);
    }
    ```

6. Also implement an <xref:System.Windows.Controls.Panel.OnRender%2A> event handler that draws the adornment.

    ```csharp
    protected override void OnRender(DrawingContext dc)
    {
        base.OnRender(dc);
        if (this.textGeometry != null)
        {
            dc.DrawGeometry(brush, solidPen, this.textGeometry);
            Rect textBounds = this.textGeometry.GetRenderBounds(solidPen);
            Point p1 = new Point(textBounds.Right, textBounds.Bottom);
            Point p2 = new Point(Math.Max(Canvas.GetLeft(this.commentGrid) - 20.0, p1.X), p1.Y);
            Point p3 = new Point(Math.Max(Canvas.GetLeft(this.commentGrid), p1.X), (Canvas.GetTop(this.commentGrid) + p1.Y) * 0.5);
            dc.DrawLine(dashPen, p1, p2);
            dc.DrawLine(dashPen, p2, p3);
        }
    }
    ```

## Add an IWpfTextViewCreationListener
 The <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener> is a MEF component part that you can use to listen to view creation events.

1. Add a class file to the CommentAdornmentTest project and name it `Connector`.

2. Add the following `using` directives.

    ```csharp
    using System.ComponentModel.Composition;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Utilities;
    ```

3. Declare a class that implements <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener>, and export it with a <xref:Microsoft.VisualStudio.Utilities.ContentTypeAttribute> of "text" and a <xref:Microsoft.VisualStudio.Text.Editor.TextViewRoleAttribute> of <xref:Microsoft.VisualStudio.Text.Editor.PredefinedTextViewRoles.Document>. The content type attribute specifies the kind of content to which the component applies. The text type is the base type for all non-binary file types. Therefore, almost every text view that is created will be of this type. The text view role attribute specifies the kind of text view to which the component applies. Document text view roles generally show text that is composed of lines and is stored in a file.

     ### [C#](#tab/csharp)
     :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkmenucommandtest/cs/commentadornmenttest/connector.cs" id="Snippet11":::

     ### [VB](#tab/vb)
     :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkmenucommandtest/vb/commentadornmenttest/connector.vb" id="Snippet11":::
     ---

4. Implement the <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewCreationListener.TextViewCreated%2A> method so that it calls the static `Create()` event of the `CommentAdornmentManager`.

    ```csharp
    public void TextViewCreated(IWpfTextView textView)
    {
        CommentAdornmentManager.Create(textView);
    }
    ```

5. Add a method that you can use to execute the command.

    ```csharp
    static public void Execute(IWpfTextViewHost host)
    {
        IWpfTextView view = host.TextView;
        //Add a comment on the selected text. 
        if (!view.Selection.IsEmpty)
        {
            //Get the provider for the comment adornments in the property bag of the view.
            CommentAdornmentProvider provider = view.Properties.GetProperty<CommentAdornmentProvider>(typeof(CommentAdornmentProvider));

            //Add some arbitrary author and comment text. 
            string author = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
            string comment = "Four score....";

            //Add the comment adornment using the provider.
            provider.Add(view.Selection.SelectedSpans[0], author, comment);
        }
    }
    ```

## Define an adornment layer
 To add a new adornment, you must define an adornment layer.

### To define an adornment layer

1. In the `Connector` class, declare a public field of type <xref:Microsoft.VisualStudio.Text.Editor.AdornmentLayerDefinition>, and export it with a <xref:Microsoft.VisualStudio.Utilities.NameAttribute> that specifies a unique name for the adornment layer and an <xref:Microsoft.VisualStudio.Utilities.OrderAttribute> that defines the Z-order relationship of this adornment layer to the other text view layers (text, caret, and selection).

    ```csharp
    [Export(typeof(AdornmentLayerDefinition))]
    [Name("CommentAdornmentLayer")]
    [Order(After = PredefinedAdornmentLayers.Selection, Before = PredefinedAdornmentLayers.Text)]
    public AdornmentLayerDefinition commentLayerDefinition;

    ```

## Provide comment adornments
 When you define an adornment, also implement a comment adornment provider and a comment adornment manager. The comment adornment provider keeps a list of comment adornments, listens to <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> events on the underlying text buffer, and deletes comment adornments when the underlying text is deleted.

1. Add a new class file to the CommentAdornmentTest project and name it `CommentAdornmentProvider`.

2. Add the following `using` directives.

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Editor;
    ```

3. Add a class named `CommentAdornmentProvider`.

    ```csharp
    internal class CommentAdornmentProvider
    {
    }
    ```

4. Add private fields for the text buffer and the list of comment adornments related to the buffer.

    ```csharp
    private ITextBuffer buffer;
    private IList<CommentAdornment> comments = new List<CommentAdornment>();

    ```

5. Add a constructor for `CommentAdornmentProvider`. This constructor should have private access because the provider is instantiated by the `Create()` method. The constructor adds the `OnBufferChanged` event handler to the <xref:Microsoft.VisualStudio.Text.ITextBuffer.Changed> event.

    ```csharp
    private CommentAdornmentProvider(ITextBuffer buffer)
    {
        this.buffer = buffer;
        //listen to the Changed event so we can react to deletions. 
        this.buffer.Changed += OnBufferChanged;
    }

    ```

6. Add the `Create()` method.

    ```csharp
    public static CommentAdornmentProvider Create(IWpfTextView view)
    {
        return view.Properties.GetOrCreateSingletonProperty<CommentAdornmentProvider>(delegate { return new CommentAdornmentProvider(view.TextBuffer); });
    }

    ```

7. Add the `Detach()` method.

    ```csharp
    public void Detach()
    {
        if (this.buffer != null)
        {
            //remove the Changed listener 
            this.buffer.Changed -= OnBufferChanged;
            this.buffer = null;
        }
    }
    ```

8. Add the `OnBufferChanged` event handler.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkmenucommandtest/cs/commentadornmenttest/commentadornmentprovider.cs" id="Snippet21":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkmenucommandtest/vb/commentadornmenttest/commentadornmentprovider.vb" id="Snippet21":::
    ---

9. Add a declaration for a `CommentsChanged` event.

    ```csharp
    public event EventHandler<CommentsChangedEventArgs> CommentsChanged;
    ```

10. Create an `Add()` method to add the adornment.

    ```csharp
    public void Add(SnapshotSpan span, string author, string text)
    {
        if (span.Length == 0)
            throw new ArgumentOutOfRangeException("span");
        if (author == null)
            throw new ArgumentNullException("author");
        if (text == null)
            throw new ArgumentNullException("text");

        //Create a comment adornment given the span, author and text.
        CommentAdornment comment = new CommentAdornment(span, author, text);

        //Add it to the list of comments. 
        this.comments.Add(comment);

        //Raise the changed event.
        EventHandler<CommentsChangedEventArgs> commentsChanged = this.CommentsChanged;
        if (commentsChanged != null)
            commentsChanged(this, new CommentsChangedEventArgs(comment, null));
    }

    ```

11. Add a `RemoveComments()` method.

    ```csharp
    public void RemoveComments(SnapshotSpan span)
    {
        EventHandler<CommentsChangedEventArgs> commentsChanged = this.CommentsChanged;

        //Get a list of all the comments that are being kept
        IList<CommentAdornment> keptComments = new List<CommentAdornment>(this.comments.Count);

        foreach (CommentAdornment comment in this.comments)
        {
            //find out if the given span overlaps with the comment text span. If two spans are adjacent, they do not overlap. To consider adjacent spans, use IntersectsWith. 
            if (comment.Span.GetSpan(span.Snapshot).OverlapsWith(span))
            {
                //Raise the change event to delete this comment. 
                if (commentsChanged != null)
                    commentsChanged(this, new CommentsChangedEventArgs(null, comment));
            }
            else
                keptComments.Add(comment);
        }

        this.comments = keptComments;
    }
    ```

12. Add a `GetComments()` method that returns all the comments in a given snapshot span.

    ```csharp
    public Collection<CommentAdornment> GetComments(SnapshotSpan span)
    {
        IList<CommentAdornment> overlappingComments = new List<CommentAdornment>();
        foreach (CommentAdornment comment in this.comments)
        {
            if (comment.Span.GetSpan(span.Snapshot).OverlapsWith(span))
                overlappingComments.Add(comment);
        }

        return new Collection<CommentAdornment>(overlappingComments);
    }
    ```

13. Add a class named `CommentsChangedEventArgs`, as follows.

    ```csharp
    internal class CommentsChangedEventArgs : EventArgs
    {
        public readonly CommentAdornment CommentAdded;

        public readonly CommentAdornment CommentRemoved;

        public CommentsChangedEventArgs(CommentAdornment added, CommentAdornment removed)
        {
            this.CommentAdded = added;
            this.CommentRemoved = removed;
        }
    }
    ```

## Manage comment adornments
 The comment adornment manager creates the adornment and adds it to the adornment layer. It listens to the <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged> and <xref:Microsoft.VisualStudio.Text.Editor.ITextView.Closed> events so that it can move or delete the adornment. It also listens to the `CommentsChanged` event that is fired by the comment adornment provider when comments are added or removed.

1. Add a class file to the CommentAdornmentTest project and name it `CommentAdornmentManager`.

2. Add the following `using` directives.

    ```csharp
    using System;
    using System.Collections.Generic;
    using System.Windows.Media;
    using Microsoft.VisualStudio.Text;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Text.Formatting;
    ```

3. Add a class named `CommentAdornmentManager`.

    ```csharp
    internal class CommentAdornmentManager
        {
        }
    ```

4. Add some private fields.

    ```csharp
    private readonly IWpfTextView view;
    private readonly IAdornmentLayer layer;
    private readonly CommentAdornmentProvider provider;
    ```

5. Add a constructor that subscribes the manager to the <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged> and <xref:Microsoft.VisualStudio.Text.Editor.ITextView.Closed> events, and also to the `CommentsChanged` event. The constructor is private because the manager is instantiated by the static `Create()` method.

    ```csharp
    private CommentAdornmentManager(IWpfTextView view)
    {
        this.view = view;
        this.view.LayoutChanged += OnLayoutChanged;
        this.view.Closed += OnClosed;

        this.layer = view.GetAdornmentLayer("CommentAdornmentLayer");

        this.provider = CommentAdornmentProvider.Create(view);
        this.provider.CommentsChanged += OnCommentsChanged;
    }
    ```

6. Add the `Create()` method that gets a provider or creates one if necessary.

    ```csharp
    public static CommentAdornmentManager Create(IWpfTextView view)
    {
        return view.Properties.GetOrCreateSingletonProperty<CommentAdornmentManager>(delegate { return new CommentAdornmentManager(view); });
    }
    ```

7. Add the `CommentsChanged` handler.

    ```csharp
    private void OnCommentsChanged(object sender, CommentsChangedEventArgs e)
    {
        //Remove the comment (when the adornment was added, the comment adornment was used as the tag). 
        if (e.CommentRemoved != null)
            this.layer.RemoveAdornmentsByTag(e.CommentRemoved);

        //Draw the newly added comment (this will appear immediately: the view does not need to do a layout). 
        if (e.CommentAdded != null)
            this.DrawComment(e.CommentAdded);
    }
    ```

8. Add the <xref:Microsoft.VisualStudio.Text.Editor.ITextView.Closed> handler.

    ```csharp
    private void OnClosed(object sender, EventArgs e)
    {
        this.provider.Detach();
        this.view.LayoutChanged -= OnLayoutChanged;
        this.view.Closed -= OnClosed;
    }
    ```

9. Add the <xref:Microsoft.VisualStudio.Text.Editor.ITextView.LayoutChanged> handler.

    ```csharp
    private void OnLayoutChanged(object sender, TextViewLayoutChangedEventArgs e)
    {
        //Get all of the comments that intersect any of the new or reformatted lines of text.
        List<CommentAdornment> newComments = new List<CommentAdornment>();

        //The event args contain a list of modified lines and a NormalizedSpanCollection of the spans of the modified lines.  
        //Use the latter to find the comments that intersect the new or reformatted lines of text. 
        foreach (Span span in e.NewOrReformattedSpans)
        {
            newComments.AddRange(this.provider.GetComments(new SnapshotSpan(this.view.TextSnapshot, span)));
        }

        //It is possible to get duplicates in this list if a comment spanned 3 lines, and the first and last lines were modified but the middle line was not. 
        //Sort the list and skip duplicates.
        newComments.Sort(delegate(CommentAdornment a, CommentAdornment b) { return a.GetHashCode().CompareTo(b.GetHashCode()); });

        CommentAdornment lastComment = null;
        foreach (CommentAdornment comment in newComments)
        {
            if (comment != lastComment)
            {
                lastComment = comment;
                this.DrawComment(comment);
            }
        }
    }
    ```

10. Add the private method that draws the comment.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../snippets/csharp/VS_Snippets_VSSDK/vssdkmenucommandtest/cs/commentadornmenttest/commentadornmentmanager.cs" id="Snippet35":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../snippets/visualbasic/VS_Snippets_VSSDK/vssdkmenucommandtest/vb/commentadornmenttest/commentadornmentmanager.vb" id="Snippet35":::
    ---

## Use the menu command to add the comment adornment
 You can use the menu command to create a comment adornment by implementing the `MenuItemCallback` method of the VSPackage.

1. Add the following references to the MenuCommandTest project:

    - Microsoft.VisualStudio.TextManager.Interop

    - Microsoft.VisualStudio.Editor

    - Microsoft.VisualStudio.Text.UI.Wpf

2. Open the *AddAdornment.cs* file and add the following `using` directives.

    ```csharp
    using Microsoft.VisualStudio.TextManager.Interop;
    using Microsoft.VisualStudio.Text.Editor;
    using Microsoft.VisualStudio.Editor;
    using CommentAdornmentTest;
    ```

3. Delete the `Execute()` method and add the following command handler.

    ```csharp
    private async void AddAdornmentHandler(object sender, EventArgs e)
    {
    }
    ```

4. Add code to get the active view. You must get the `SVsTextManager` of the Visual Studio shell to get the active `IVsTextView`.

    ```csharp
    private async void AddAdornmentHandler(object sender, EventArgs e)
    {
        IVsTextManager txtMgr = (IVsTextManager) await ServiceProvider.GetServiceAsync(typeof(SVsTextManager));
        IVsTextView vTextView = null;
        int mustHaveFocus = 1;
        txtMgr.GetActiveView(mustHaveFocus, null, out vTextView);
    }
    ```

5. If this text view is an instance of an editor text view, you can cast it to the <xref:Microsoft.VisualStudio.TextManager.Interop.IVsUserData> interface and then get the <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost> and its associated <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextView>. Use the <xref:Microsoft.VisualStudio.Text.Editor.IWpfTextViewHost> to call the `Connector.Execute()` method, which gets the comment adornment provider and adds the adornment. The command handler should now look like this code:

    ```csharp
    private async void AddAdornmentHandler(object sender, EventArgs e)
    {
        IVsTextManager txtMgr = (IVsTextManager) await ServiceProvider.GetServiceAsync(typeof(SVsTextManager));
        IVsTextView vTextView = null;
        int mustHaveFocus = 1;
        txtMgr.GetActiveView(mustHaveFocus, null, out vTextView);
        IVsUserData userData = vTextView as IVsUserData;
         if (userData == null)
        {
            Console.WriteLine("No text view is currently open");
            return;
        }
        IWpfTextViewHost viewHost;
        object holder;
        Guid guidViewHost = DefGuidList.guidIWpfTextViewHost;
        userData.GetData(ref guidViewHost, out holder);
        viewHost = (IWpfTextViewHost)holder;
        Connector.Execute(viewHost);
    }
    ```

6. Set the AddAdornmentHandler method as the handler for the AddAdornment command in the AddAdornment constructor.

    ```csharp
    private AddAdornment(AsyncPackage package, OleMenuCommandService commandService)
    {
        this.package = package ?? throw new ArgumentNullException(nameof(package));
        commandService = commandService ?? throw new ArgumentNullException(nameof(commandService));

        var menuCommandID = new CommandID(CommandSet, CommandId);
        var menuItem = new MenuCommand(this.AddAdornmentHandler, menuCommandID);
        commandService.AddCommand(menuItem);
    }
    ```

## Build and test the code

1. Build the solution and start debugging. The experimental instance should appear.

2. Create a text file. Type some text and then select it.

3. On the **Tools** menu, click **Invoke Add Adornment**. A balloon should display on the right side of the text window, and should contain text that resembles the following text.

     YourUserName

     Fourscore...

## Related content
- [Walkthrough: Link a content type to a file name extension](../extensibility/walkthrough-linking-a-content-type-to-a-file-name-extension.md)
