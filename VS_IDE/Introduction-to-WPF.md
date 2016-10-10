---
title: "Introduction to WPF"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-general
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b8d7cf43-d1f2-4f3d-adb0-4f3a6428edc0
caps.latest.revision: 5
manager: ghogen
translation.priority.ht: 
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - ru-ru
  - zh-cn
  - zh-tw
translation.priority.mt: 
  - cs-cz
  - pl-pl
  - pt-br
  - tr-tr
---
# Introduction to WPF
Windows Presentation Foundation (WPF) lets you create desktop client applications for Windows with visually stunning user experiences.  
  
 ![Contoso Healthcare UI sample](../VS_IDE/media/WPFIntroFigure24.png "WPFIntroFigure24")  
  
 The core of WPF is a resolution-independent and vector-based rendering engine that is built to take advantage of modern graphics hardware. WPF extends the core with a comprehensive set of application-development features that include Extensible Application Markup Language (XAML), controls, data binding, layout, 2-D and 3-D graphics, animation, styles, templates, documents, media, text, and typography. WPF is included in the .NET Framework, so you can build applications that incorporate other elements of the .NET Framework class library.  
  
 This overview is intended for newcomers and covers the key capabilities and concepts of WPF.  
  
##  <a name="Programming_with_WPF"></a> Programming with WPF  
 WPF exists as a subset of .NET Framework types that are for the most part located in the <xref:System.Windows?qualifyHint=False> namespace. If you have previously built applications with .NET Framework using managed technologies like ASP.NET and Windows Forms, the fundamental WPF programming experience should be familiar; you instantiate classes, set properties, call methods, and handle events, all using your favorite .NET programming language, such as C# or Visual Basic.  
  
 WPF includes additional programming constructs that enhance properties and events: [dependency properties](https://msdn.microsoft.com/en-us/library/ms752914\(v=vs.100\).aspx) and [routed events](https://msdn.microsoft.com/en-us/library/ms742806\(v=vs.100\).aspx).  
  
##  <a name="Markup_And_Codebehind"></a> Markup and Code-Behind  
 WPF lets you develop an application using both *markup* and *code-behind*, an experience that ASP.NET developers should be familiar with. You generally use XAML markup to implement the appearance of an application while using managed programming languages (code-behind) to implement its behavior. This separation of appearance and behavior has the following benefits:  
  
-   Development and maintenance costs are reduced because appearance-specific markup is not tightly coupled with behavior-specific code.  
  
-   Development is more efficient because designers can implement an application's appearance simultaneously with developers who are implementing the application's behavior.  
  
-   [Globalization and localization](https://msdn.microsoft.com/en-us/library/ms788718\(v=vs.100\).aspx) for WPF applications is simplified.  
  
 The following is a brief introduction to WPF markup and code-behind.  
  
### Markup  
 XAML is an XML-based markup language that is used to implement an application's appearance declaratively. It is typically used to create windows, dialog boxes, pages, and user controls, and to fill them with controls, shapes, and graphics.  
  
 The following example uses XAML to implement the appearance of a window that contains a single button.  
  
```xaml  
<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
    Title="Window with Button"  
    Width="250" Height="100">  
  
  <!-- Add button to window -->  
  <Button Name="button">Click Me!</Button>  
  
</Window>  
```  
  
 Specifically, this XAML defines a window and a button by using the `Window` and `Button` elements, respectively. Each element is configured with attributes, such as the `Window` element's `Title` attribute to specify the window's title-bar text. At run time, WPF converts the elements and attributes that are defined in markup to instances of WPF classes. For example, the `Window` element is converted to an instance of the <xref:System.Windows.Window?qualifyHint=False> class whose <xref:System.Windows.Window.Title?qualifyHint=False> property is the value of the `Title` attribute.  
  
 The following figure shows the user interface (UI) that is defined by the XAML in the previous example.  
  
 ![A window that contains a button](../VS_IDE/media/WPFIntroFigure10.png "WPFIntroFigure10")  
  
 Since XAML is XML-based, the UI that you compose with it is assembled in a hierarchy of nested elements known as an [element tree](https://msdn.microsoft.com/en-us/library/ms753391\(v=vs.100\).aspx). The element tree provides a logical and intuitive way to create and manage UIs.  
  
### Code-Behind  
 The main behavior of an application is to implement the functionality that responds to user interactions, including handling events (for example, clicking a menu, tool bar, or button) and calling business logic and data access logic in response. In WPF, this behavior is generally implemented in code that is associated with markup. This type of code is known as code-behind. The following example shows the updated markup from the previous example and the code-behind.  
  
```xaml  
<Window  
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"  
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"  
    x:Class="SDKSample.AWindow"  
    Title="Window with Button"  
    Width="250" Height="100">  
  
  <!-- Add button to window -->  
  <Button Name="button" Click="button_Click">Click Me!</Button>  
  
</Window>  
```  
  
```c#  
using System.Windows; // Window, RoutedEventArgs, MessageBox   
  
namespace SDKSample  
{  
    public partial class AWindow : Window  
    {  
        public AWindow()  
        {  
            // InitializeComponent call is required to merge the UI   
            // that is defined in markup with this class, including    
            // setting properties and registering event handlers  
            InitializeComponent();  
        }  
  
        void button_Click(object sender, RoutedEventArgs e)  
        {  
            // Show message box when button is clicked  
            MessageBox.Show("Hello, Windows Presentation Foundation!");  
        }  
    }  
}  
```  
  
```vb  
Namespace SDKSample  
  
    Partial Public Class AWindow  
        Inherits System.Windows.Window  
  
        Public Sub New()  
  
            ' InitializeComponent call is required to merge the UI   
            ' that is defined in markup with this class, including    
            ' setting properties and registering event handlers  
            InitializeComponent()  
  
        End Sub   
  
        Private Sub button_Click(ByVal sender As Object, ByVal e As RoutedEventArgs)  
  
            ' Show message box when button is clicked  
            MessageBox.Show("Hello, Windows Presentation Foundation!")  
  
        End Sub   
  
    End Class   
  
End Namespace  
  
```  
  
 In this example, the code-behind implements a class that derives from the <xref:System.Windows.Window?qualifyHint=False> class. The `x:Class` attribute is used to associate the markup with the code-behind class. `InitializeComponent` is called from the code-behind class's constructor to merge the UI that is defined in markup with the code-behind class. (`InitializeComponent` is generated for you when your application is built, which is why you don't need to implement it manually.) The combination of `x:Class` and `InitializeComponent` ensure that your implementation is correctly initialized whenever it is created. The code-behind class also implements an event handler for the button's <xref:System.Windows.Controls.Primitives.ButtonBase.Click?qualifyHint=False> event. When the button is clicked, the event handler shows a message box by calling the <xref:System.Windows.MessageBox.Show?qualifyHint=True> method.  
  
 The following figure shows the result when the button is clicked.  
  
 ![A MessageBox](../VS_IDE/media/WPFIntroFigure25.png "WPFIntroFigure25")  
  
##  <a name="Controls"></a> Controls  
 The user experiences that are delivered by the application model are constructed controls. In WPF, "control" is an umbrella term that applies to a category of WPF classes that are hosted in either a window or a page, have a user interface, and implement some behavior.  
  
 For more information, see [Controls](../Topic/Controls.md).  
  
### WPF Controls by Function  
 The built-in WPF controls are listed here.  
  
-   **Buttons**: <xref:System.Windows.Controls.Button?qualifyHint=False> and <xref:System.Windows.Controls.Primitives.RepeatButton?qualifyHint=False>.  
  
-   **Data Display**: <xref:System.Windows.Controls.DataGrid?qualifyHint=False>, <xref:System.Windows.Controls.ListView?qualifyHint=False>,and <xref:System.Windows.Controls.TreeView?qualifyHint=False>.  
  
-   **Date Display and Selection**: <xref:System.Windows.Controls.Calendar?qualifyHint=False> and <xref:System.Windows.Controls.DatePicker?qualifyHint=False>.  
  
-   **Dialog Boxes**: <xref:Microsoft.Win32.OpenFileDialog?qualifyHint=False>, <xref:System.Windows.Controls.PrintDialog?qualifyHint=False>, and <xref:Microsoft.Win32.SaveFileDialog?qualifyHint=False>.  
  
-   **Digital Ink**: <xref:System.Windows.Controls.InkCanvas?qualifyHint=False> and <xref:System.Windows.Controls.InkPresenter?qualifyHint=False>.  
  
-   **Documents**: <xref:System.Windows.Controls.DocumentViewer?qualifyHint=False>, <xref:System.Windows.Controls.FlowDocumentPageViewer?qualifyHint=False>, <xref:System.Windows.Controls.FlowDocumentReader?qualifyHint=False>, <xref:System.Windows.Controls.FlowDocumentScrollViewer?qualifyHint=False>, and <xref:System.Windows.Controls.StickyNoteControl?qualifyHint=False>.  
  
-   **Input**: <xref:System.Windows.Controls.TextBox?qualifyHint=False>, <xref:System.Windows.Controls.RichTextBox?qualifyHint=False>, and <xref:System.Windows.Controls.PasswordBox?qualifyHint=False>.  
  
-   **Layout**: <xref:System.Windows.Controls.Border?qualifyHint=False>, <xref:System.Windows.Controls.Primitives.BulletDecorator?qualifyHint=False>, <xref:System.Windows.Controls.Canvas?qualifyHint=False>, <xref:System.Windows.Controls.DockPanel?qualifyHint=False>, <xref:System.Windows.Controls.Expander?qualifyHint=False>, <xref:System.Windows.Controls.Grid?qualifyHint=False>, <xref:System.Windows.Controls.GridView?qualifyHint=False>, <xref:System.Windows.Controls.GridSplitter?qualifyHint=False>, <xref:System.Windows.Controls.GroupBox?qualifyHint=False>, <xref:System.Windows.Controls.Panel?qualifyHint=False>, <xref:System.Windows.Controls.Primitives.ResizeGrip?qualifyHint=False>, <xref:System.Windows.Controls.Separator?qualifyHint=False>, <xref:System.Windows.Controls.Primitives.ScrollBar?qualifyHint=False>, <xref:System.Windows.Controls.ScrollViewer?qualifyHint=False>, <xref:System.Windows.Controls.StackPanel?qualifyHint=False>, <xref:System.Windows.Controls.Primitives.Thumb?qualifyHint=False>, <xref:System.Windows.Controls.Viewbox?qualifyHint=False>, <xref:System.Windows.Controls.VirtualizingStackPanel?qualifyHint=False>, <xref:System.Windows.Window?qualifyHint=False>, and <xref:System.Windows.Controls.WrapPanel?qualifyHint=False>.  
  
-   **Media**: <xref:System.Windows.Controls.Image?qualifyHint=False>, <xref:System.Windows.Controls.MediaElement?qualifyHint=False>, and <xref:System.Windows.Controls.SoundPlayerAction?qualifyHint=False>.  
  
-   **Menus**: <xref:System.Windows.Controls.ContextMenu?qualifyHint=False>, <xref:System.Windows.Controls.Menu?qualifyHint=False>, and <xref:System.Windows.Controls.ToolBar?qualifyHint=False>.  
  
-   **Navigation**: <xref:System.Windows.Controls.Frame?qualifyHint=False>, <xref:System.Windows.Documents.Hyperlink?qualifyHint=False>, <xref:System.Windows.Controls.Page?qualifyHint=False>, <xref:System.Windows.Navigation.NavigationWindow?qualifyHint=False>, and <xref:System.Windows.Controls.TabControl?qualifyHint=False>.  
  
-   **Selection**: <xref:System.Windows.Controls.CheckBox?qualifyHint=False>, <xref:System.Windows.Controls.ComboBox?qualifyHint=False>, <xref:System.Windows.Controls.ListBox?qualifyHint=False>, <xref:System.Windows.Controls.RadioButton?qualifyHint=False>, and <xref:System.Windows.Controls.Slider?qualifyHint=False>.  
  
-   **User Information**: <xref:System.Windows.Controls.AccessText?qualifyHint=False>, <xref:System.Windows.Controls.Label?qualifyHint=False>, <xref:System.Windows.Controls.Primitives.Popup?qualifyHint=False>, <xref:System.Windows.Controls.ProgressBar?qualifyHint=False>, <xref:System.Windows.Controls.Primitives.StatusBar?qualifyHint=False>, <xref:System.Windows.Controls.TextBlock?qualifyHint=False>, and <xref:System.Windows.Controls.ToolTip?qualifyHint=False>.  
  
##  <a name="Input_And_Commanding"></a> Input and Commanding  
 Controls most often detect and respond to user input. The [WPF input system](https://msdn.microsoft.com/en-us/library/ms754010\(v=vs.100\).aspx) uses both direct and routed events to support text input, focus management, and mouse positioning.  
  
 Applications often have complex input requirements. WPF provides a [command system](https://msdn.microsoft.com/en-us/library/ms752308\(v=vs.100\).aspx) that separates user input actions from the code that responds to those actions.  
  
##  <a name="Layout"></a> Layout  
 When you create a user interface, you arrange your controls by location and size to form a layout. A key requirement of any layout is to adapt to changes in window size and display settings. Rather than forcing you to write the code to adapt a layout in these circumstances, WPF provides a first-class, extensible layout system for you.  
  
 The cornerstone of the layout system is relative positioning, which increases the ability to adapt to changing window and display conditions. In addition, the layout system manages the negotiation between controls to determine the layout. The negotiation is a two-step process: first, a control tells its parent what location and size it requires; second, the parent tells the control what space it can have.  
  
 The layout system is exposed to child controls through base WPF classes. For common layouts such as grids, stacking, and docking, WPF includes several layout controls:  
  
-   <xref:System.Windows.Controls.Canvas?qualifyHint=False>: Child controls provide their own layout.  
  
-   <xref:System.Windows.Controls.DockPanel?qualifyHint=False>: Child controls are aligned to the edges of the panel.  
  
-   <xref:System.Windows.Controls.Grid?qualifyHint=False>: Child controls are positioned by rows and columns.  
  
-   <xref:System.Windows.Controls.StackPanel?qualifyHint=False>: Child controls are stacked either vertically or horizontally.  
  
-   <xref:System.Windows.Controls.VirtualizingStackPanel?qualifyHint=False>: Child controls are virtualized and arranged on a single line that is either horizontally or vertically oriented.  
  
-   <xref:System.Windows.Controls.WrapPanel?qualifyHint=False>: Child controls are positioned in left-to-right order and wrapped to the next line when there are more controls on the current line than space allows.  
  
 The following example uses a <xref:System.Windows.Controls.DockPanel?qualifyHint=False> to lay out several <xref:System.Windows.Controls.TextBox?qualifyHint=False> controls.  
  
 [!CODE [IntroToWPFSnippets#LayoutMARKUP](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#layoutmarkup)]  
  
 The <xref:System.Windows.Controls.DockPanel?qualifyHint=False> allows the child <xref:System.Windows.Controls.TextBox?qualifyHint=False> controls to tell it how to arrange them. To do this, the <xref:System.Windows.Controls.DockPanel?qualifyHint=False> implements a <xref:System.Windows.Controls.DockPanel.Dock?qualifyHint=False> property that is exposed to the child controls to allow each of them to specify a dock style.  
  
> [!NOTE]
>  A property that is implemented by a parent control for use by child controls is a WPF construct called an [attached property](https://msdn.microsoft.com/en-us/library/ms749011\(v=vs.100\).aspx).  
  
 The following figure shows the result of the XAML markup in the preceding example.  
  
 ![DockPanel page](../VS_IDE/media/WPFIntroFigure11.png "WPFIntroFigure11")  
  
##  <a name="Data_Binding"></a> Data Binding  
 Most applications are created to provide users with the means to view and edit data. For WPF applications, the work of storing and accessing data is already provided for by technologies such as SQL Server and ADO .NET. After the data is accessed and loaded into an application's managed objects, the hard work for WPF applications begins. Essentially, this involves two things:  
  
1.  Copying the data from the managed objects into controls, where the data can be displayed and edited.  
  
2.  Ensuring that changes made to data by using controls are copied back to the managed objects.  
  
 To simplify application development, WPF provides a data binding engine to automatically perform these steps. The core unit of the data binding engine is the <xref:System.Windows.Data.Binding?qualifyHint=False> class, whose job is to bind a control (the binding target) to a data object (the binding source). This relationship is illustrated by the following figure.  
  
 ![Basic data binding diagram](../VS_IDE/media/DataBindingMostBasic.png "DataBindingMostBasic")  
  
 The following example demonstrates how to bind a <xref:System.Windows.Controls.TextBox?qualifyHint=False> to an instance of a custom `Person` object. The `Person` implementation is shown in the following code.  
  
 [!CODE [SimpleDataBindingSnippets#PersonClassCODE](../CodeSnippet/VS_Snippets_Wpf/SimpleDataBindingSnippets#personclasscode)]  
  
 The following markup binds the <xref:System.Windows.Controls.TextBox?qualifyHint=False> to an instance of a custom `Person` object.  
  
 [!CODE [SimpleDataBindingSnippets#DataBindingMARKUP1](../CodeSnippet/VS_Snippets_Wpf/SimpleDataBindingSnippets#databindingmarkup1)]  
[!CODE [SimpleDataBindingSnippets#DataBindingMARKUP2](../CodeSnippet/VS_Snippets_Wpf/SimpleDataBindingSnippets#databindingmarkup2)]  
[!CODE [SimpleDataBindingSnippets#DataBindingMARKUP3](../CodeSnippet/VS_Snippets_Wpf/SimpleDataBindingSnippets#databindingmarkup3)]  
  
 [!CODE [SimpleDataBindingSnippets#DataBindingCODEBEHIND](../CodeSnippet/VS_Snippets_Wpf/SimpleDataBindingSnippets#databindingcodebehind)]  
  
 In this example, the `Person` class is instantiated in code-behind and is set as the data context for the `DataBindingWindow`. In markup, the <xref:System.Windows.Controls.TextBox.Text?qualifyHint=False> property of the <xref:System.Windows.Controls.TextBox?qualifyHint=False> is bound to the `Person.Name` property (using the "`{Binding ... }`" XAML syntax). This XAML tells WPF to bind the <xref:System.Windows.Controls.TextBox?qualifyHint=False> control to the `Person` object that is stored in the <xref:System.Windows.FrameworkElement.DataContext?qualifyHint=False> property of the window.  
  
 The WPF data binding engine provides additional support that includes validation, sorting, filtering, and grouping. Furthermore, data binding supports the use of data templates to create custom user interface for bound data when the user interface displayed by the standard WPF controls is not appropriate.  
  
 For more information, see [Data Binding Overview](https://msdn.microsoft.com/en-us/library/ms752347\(v=vs.100\).aspx).  
  
##  <a name="Graphics"></a> Graphics  
 WPF introduces an extensive, scalable, and flexible set of graphics features that have the following benefits:  
  
-   **Resolution-independent and device-independent graphics**. The basic unit of measurement in the WPF graphics system is the device independent pixel, which is 1/96th of an inch, regardless of actual screen resolution, and provides the foundation for resolution-independent and device-independent rendering. Each device-independent pixel automatically scales to match the dots-per-inch (dpi) setting of the system it renders on.  
  
-   **Improved precision**. The WPF coordinate system is measured with double-precision floating-point numbers rather than single-precision. Transformations and opacity values are also expressed as double-precision. WPF also supports a wide color gamut (scRGB) and provides integrated support for managing inputs from different color spaces.  
  
-   **Advanced graphics and animation support**. WPF simplifies graphics programming by managing animation scenes for you; there is no need to worry about scene processing, rendering loops, and bilinear interpolation. Additionally, WPF provides hit-testing support and full alpha-compositing support.  
  
-   **Hardware acceleration**. The WPF graphics system takes advantage of graphics hardware to minimize CPU usage.  
  
### 2-D Shapes  
 WPF provides a library of common vector-drawn 2-D shapes, such as the rectangles and ellipses that are shown in the following illustration.  
  
 ![Ellipses and rectangles](../VS_IDE/media/WPFIntroFigure4.PNG "WPFIntroFigure4")  
  
 An interesting capability of shapes is that they are not just for display; shapes implement many of the features that you expect from controls, including keyboard and mouse input. The following example shows the <xref:System.Windows.UIElement.MouseUp?qualifyHint=False> event of an <xref:System.Windows.Shapes.Ellipse?qualifyHint=False> being handled.  
  
 [!CODE [IntroToWPFSnippets#HandleEllipseMouseUpEventMARKUP](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#handleellipsemouseupeventmarkup)]  
  
 [!CODE [IntroToWPFSnippets#HandleEllipseMouseUpEventCODEBEHIND](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#handleellipsemouseupeventcodebehind)]  
  
 The following figure shows what is produced by the preceding code.  
  
 ![A window with the text "you clicked the ellipse&#33;"](../VS_IDE/media/WPFIntroFigure12.png "WPFIntroFigure12")  
  
 For more information, see [Shapes and Basic Drawing in WPF Overview](https://msdn.microsoft.com/en-us/library/ms747393\(v=vs.100\).aspx).  
  
### 2-D Geometries  
 The 2-D shapes provided by WPF cover the standard set of basic shapes. However, you may need to create custom shapes to facilitate the design of a customized user interface. For this purpose, WPF provides geometries. The following figure demonstrates the use of geometries to create a custom shape that can be drawn directly, used as a brush, or used to clip other shapes and controls.  
  
 <xref:System.Windows.Shapes.Path?qualifyHint=False> objects can be used to draw closed or open shapes, multiple shapes, and even curved shapes.  
  
 <xref:System.Windows.Media.Geometry?qualifyHint=False> objects can be used for clipping, hit-testing, and rendering 2-D graphic data.  
  
 ![Various uses of a Path](../VS_IDE/media/WPFIntroFigure5.PNG "WPFIntroFigure5")  
  
 For more information, see [Geometry Overview](https://msdn.microsoft.com/en-us/library/ms751808\(v=vs.100\).aspx)  
  
### 2-D Effects  
 A subset of WPF 2-D capabilities includes visual effects, such as gradients, bitmaps, drawings, painting with videos, rotation, scaling, and skewing. These are all achieved with brushes; the following figure shows some examples.  
  
 ![Illustration of different brushes](../VS_IDE/media/WPFIntroFigure6.PNG "WPFIntroFigure6")  
  
 For more information, see [WPF Brushes Overview](https://msdn.microsoft.com/en-us/library/aa970904\(v=vs.100\).aspx).  
  
### 3-D Rendering  
 WPF also includes 3-D rendering capabilities that integrate with 2-d graphics to allow the creation of more exciting and interesting user interfaces. For example, the following figure shows 2-D images rendered onto 3-D shapes.  
  
 ![Visual3D sample screen shot](../VS_IDE/media/WPFIntroFigure13.png "WPFIntroFigure13")  
  
 For more information, see [3-D Graphics Overview](https://msdn.microsoft.com/en-us/library/ms747437\(v=vs.100\).aspx).  
  
##  <a name="Animation"></a> Animation  
 WPF animation support lets you make controls grow, shake, spin, and fade, to create interesting page transitions, and more. You can animate most WPF classes, even custom classes. The following figure shows a simple animation in action.  
  
 ![Images of an animated cube](../VS_IDE/media/WPFIntroFigure7.png "WPFIntroFigure7")  
  
 For more information, see [Animation Overview](https://msdn.microsoft.com/en-us/library/ms752312\(v=vs.100\).aspx).  
  
##  <a name="Media"></a> Media  
 One way to convey rich content is through the use of audiovisual media. WPF provides special support for images, video, and audio.  
  
### Images  
 Images are common to most applications, and WPF provides several ways to use them. The following figure shows a user interface with a list box that contains thumbnail images. When a thumbnail is selected, the image is shown full-size.  
  
 ![Thumbnail images and a full&#45;size image](../VS_IDE/media/WPFIntroFigure8.PNG "WPFIntroFigure8")  
  
 For more information, see [Imaging Overview](https://msdn.microsoft.com/en-us/library/ms748873\(v=vs.100\).aspx).  
  
### Video and Audio  
 The <xref:System.Windows.Controls.MediaElement?qualifyHint=False> control is capable of playing both video and audio, and it is flexible enough to be the basis for a custom media player. The following XAML markup implements a media player.  
  
 [!CODE [IntroToWPFSnippets#MediaElementMARKUP](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#mediaelementmarkup)]  
  
 The window in the following figure shows the <xref:System.Windows.Controls.MediaElement?qualifyHint=False> control in action.  
  
 ![A MediaElement control with audio and video](../VS_IDE/media/WPFIntroFigure1.png "WPFIntroFigure1")  
  
 For more information, see [WPF Graphics, Animation, and Media Overview](https://msdn.microsoft.com/en-us/library/ms742562\(v=vs.100\).aspx).  
  
##  <a name="Text_and_Typography"></a> Text and Typography  
 To facilitate high-quality text rendering, WPF offers the following features:  
  
-   OpenType font support.  
  
-   ClearType enhancements.  
  
-   High performance that takes advantage of hardware acceleration.  
  
-   Integration of text with media, graphics, and animation.  
  
-   International font support and fallback mechanisms.  
  
 As a demonstration of text integration with graphics, the following figure shows the application of text decorations.  
  
 ![Text with various text decorations](../VS_IDE/media/WPFIntroFigure23.png "WPFIntroFigure23")  
  
 For more information, see [Typography in Windows Presentation Foundation](https://msdn.microsoft.com/en-us/library/ms742190\(v=vs.100\).aspx).  
  
##  <a name="WPF_Customization"></a> Customizing WPF Applications  
 Up to this point, you've seen the core WPF building blocks for developing applications. You use the application model to host and deliver application content, which consists mainly of controls. To simplify the arrangement of controls in a user interface, and to ensure the arrangement is maintained in the face of changes to window size and display settings, you use the WPF layout system. Because most applications allow users to interact with data, you use data binding to reduce the work of integrating your user interface with data. To enhance the visual appearance of your application, you use the comprehensive range of graphics, animation, and media support provided by WPF.  
  
 Often, though, the basics are not enough for creating and managing a truly distinct and visually stunning user experience. The standard WPF controls may not integrate with the desired appearance of your application. Data may not be displayed in the most effective way. Your application's overall user experience may not be suited to the default look and feel of Windows themes. In many ways, a presentation technology needs visual extensibility as much as any other kind of extensibility.  
  
 For this reason, WPF provides a variety of mechanisms for creating unique user experiences, including a rich content model for controls, triggers, control and data templates, styles, user interface resources, and themes and skins.  
  
### Content Model  
 The main purpose of a majority of the WPF controls is to display content. In WPF, the type and number of items that can constitute the content of a control is referred to as the control's *content model*. Some controls can contain a single item and type of content; for example, the content of a <xref:System.Windows.Controls.TextBox?qualifyHint=False> is a string value that is assigned to the <xref:System.Windows.Controls.TextBox.Text?qualifyHint=False> property. The following example sets the content of a <xref:System.Windows.Controls.TextBox?qualifyHint=False>.  
  
 [!CODE [IntroToWPFSnippets#TextBoxContentMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#textboxcontentmarkup1)]  
[!CODE [IntroToWPFSnippets#TextBoxContentMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#textboxcontentmarkup2)]  
[!CODE [IntroToWPFSnippets#TextBoxContentMARKUP3](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#textboxcontentmarkup3)]  
  
 The following figure shows the result.  
  
 ![A TextBox control that contains text](../VS_IDE/media/WPFIntroFigure21.png "WPFIntroFigure21")  
  
 Other controls, however, can contain multiple items of different types of content; the content of a <xref:System.Windows.Controls.Button?qualifyHint=False>, specified by the <xref:System.Windows.Controls.ContentControl.Content?qualifyHint=False> property, can contain a variety of items including layout controls, text, images, and shapes. The following example shows a <xref:System.Windows.Controls.Button?qualifyHint=False> with content that includes a <xref:System.Windows.Controls.DockPanel?qualifyHint=False>, a <xref:System.Windows.Controls.Label?qualifyHint=False>, a <xref:System.Windows.Controls.Border?qualifyHint=False>, and a <xref:System.Windows.Controls.MediaElement?qualifyHint=False>.  
  
 [!CODE [IntroToWPFSnippets#ButtonContentMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#buttoncontentmarkup1)]  
[!CODE [IntroToWPFSnippets#ButtonContentMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#buttoncontentmarkup2)]  
[!CODE [IntroToWPFSnippets#ButtonContentMARKUP3](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#buttoncontentmarkup3)]  
  
 The following figure shows the content of this button.  
  
 ![A button that contains multiple types of content](../VS_IDE/media/WPFIntroFigure22.png "WPFIntroFigure22")  
  
 For more information on the kinds of content that is supported by various controls, see [WPF Content Model](https://msdn.microsoft.com/en-us/library/bb613548\(v=vs.100\).aspx).  
  
### Triggers  
 Although the main purpose of XAML markup is to implement an application's appearance, you can also use XAML to implement some aspects of an application's behavior. One example is the use of triggers to change an application's appearance based on user interactions. For more information, see [Styling and Templating](https://msdn.microsoft.com/en-us/library/ms745683\(v=vs.100\).aspx).  
  
### Control Templates  
 The default user interfaces for WPF controls are typically constructed from other controls and shapes. For example, a <xref:System.Windows.Controls.Button?qualifyHint=False> is composed of both <xref:Microsoft.Windows.Themes.ButtonChrome?qualifyHint=False> and <xref:System.Windows.Controls.ContentPresenter?qualifyHint=False> controls. The <xref:Microsoft.Windows.Themes.ButtonChrome?qualifyHint=False> provides the standard button appearance, while the <xref:System.Windows.Controls.ContentPresenter?qualifyHint=False> displays the button's content, as specified by the <xref:System.Windows.Controls.ContentControl.Content?qualifyHint=False> property.  
  
 Sometimes the default appearance of a control may be incongruent with the overall appearance of an application. In this case, you can use a <xref:System.Windows.Controls.ControlTemplate?qualifyHint=False> to change the appearance of the control's user interface without changing its content and behavior.  
  
 For example, the following example shows how to change the appearance of a <xref:System.Windows.Controls.Button?qualifyHint=False> by using a <xref:System.Windows.Controls.ControlTemplate?qualifyHint=False>.  
  
 [!CODE [IntroToWPFSnippets#ButtonControlTemplateWindowMARKUP](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#buttoncontroltemplatewindowmarkup)]  
  
 [!CODE [IntroToWPFSnippets#ButtonControlTemplateWindowCODEBEHIND](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#buttoncontroltemplatewindowcodebehind)]  
  
 In this example, the default button user interface has been replaced with an <xref:System.Windows.Shapes.Ellipse?qualifyHint=False> that has a dark blue border and is filled using a <xref:System.Windows.Media.RadialGradientBrush?qualifyHint=False>. The <xref:System.Windows.Controls.ContentPresenter?qualifyHint=False> control displays the content of the <xref:System.Windows.Controls.Button?qualifyHint=False>, "Click Me!" When the <xref:System.Windows.Controls.Button?qualifyHint=False> is clicked, the <xref:System.Windows.Controls.Primitives.ButtonBase.Click?qualifyHint=False> event is still raised as part of the <xref:System.Windows.Controls.Button?qualifyHint=False> control's default behavior. The result is shown in the following figure.  
  
 ![An elliptical button and a second window](../VS_IDE/media/WPFIntroFigure2.png "WPFIntroFigure2")  
  
### Data Templates  
 Whereas a control template lets you specify the appearance of a control, a data template lets you specify the appearance of a control's content. Data templates are frequently used to enhance how bound data is displayed. The following figure shows the default appearance for a <xref:System.Windows.Controls.ListBox?qualifyHint=False> that is bound to a collection of `Task` objects, where each task has a name, description, and priority.  
  
 ![A list box with the default appearance](../VS_IDE/media/WPFIntroFigure18.png "WPFIntroFigure18")  
  
 The default appearance is what you would expect from a <xref:System.Windows.Controls.ListBox?qualifyHint=False>. However, the default appearance of each task contains only the task name. To show the task name, description, and priority, the default appearance of the <xref:System.Windows.Controls.ListBox?qualifyHint=False> control's bound list items must be changed by using a <xref:System.Windows.DataTemplate?qualifyHint=False>. The following XAML defines such a <xref:System.Windows.DataTemplate?qualifyHint=False>, which is applied to each task by using the <xref:System.Windows.Controls.ItemsControl.ItemTemplate?qualifyHint=False> attribute.  
  
 [!CODE [IntroToWPFSnippets#DataTemplateMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#datatemplatemarkup1)]  
[!CODE [IntroToWPFSnippets#DataTemplateMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#datatemplatemarkup2)]  
[!CODE [IntroToWPFSnippets#DataTemplateMARKUP3](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#datatemplatemarkup3)]  
[!CODE [IntroToWPFSnippets#DataTemplateMARKUP4](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#datatemplatemarkup4)]  
  
 The following figure shows the effect of this code.  
  
 ![Llist box that uses a data template](../VS_IDE/media/WPFIntroFigure19.png "WPFIntroFigure19")  
  
 Note that the <xref:System.Windows.Controls.ListBox?qualifyHint=False> has retained its behavior and overall appearance; only the appearance of the content being displayed by the list box has changed.  
  
 For more information, see [Data Templating Overview](https://msdn.microsoft.com/en-us/library/ms742521\(v=vs.100\).aspx).  
  
### Styles  
 Styles enable developers and designers to standardize on a particular appearance for their product. WPF provides a strong style model, the foundation of which is the <xref:System.Windows.Style?qualifyHint=False> element. The following example creates a style that sets the background color for every <xref:System.Windows.Controls.Button?qualifyHint=False> on a window to `Orange`.  
  
 [!CODE [IntroToWPFSnippets#StyleMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#stylemarkup1)]  
[!CODE [IntroToWPFSnippets#StyleMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#stylemarkup2)]  
[!CODE [IntroToWPFSnippets#StyleMARKUP3](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#stylemarkup3)]  
[!CODE [IntroToWPFSnippets#StyleMARKUP4](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#stylemarkup4)]  
  
 Because this style targets all <xref:System.Windows.Controls.Button?qualifyHint=False> controls, the style is automatically applied to all the buttons in the window, as shown in the following figure.  
  
 ![Two orange buttons](../VS_IDE/media/WPFIntroFigure20.png "WPFIntroFigure20")  
  
 For more information, see [Styling and Templating](https://msdn.microsoft.com/en-us/library/ms745683\(v=vs.100\).aspx).  
  
### Resources  
 Controls in an application should share the same appearance, which can include anything from fonts and background colors to control templates, data templates, and styles. You can use WPF's support for user interface resources to encapsulate these resources in a single location for reuse.  
  
 The following example defines a common background color that is shared by a <xref:System.Windows.Controls.Button?qualifyHint=False> and a <xref:System.Windows.Controls.Label?qualifyHint=False>.  
  
 [!CODE [IntroToWPFSnippets#ResourceWindowMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#resourcewindowmarkup1)]  
[!CODE [IntroToWPFSnippets#ResourceWindowMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#resourcewindowmarkup2)]  
[!CODE [IntroToWPFSnippets#ResourceWindowMARKUP3](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#resourcewindowmarkup3)]  
  
 This example implements a background color resource by using the `Window.Resources` property element. This resource is available to all children of the <xref:System.Windows.Window?qualifyHint=False>. There are a variety of resource scopes, including the following, listed in the order in which they are resolved:  
  
1.  An individual control (using the inherited <xref:System.Windows.FrameworkElement.Resources?qualifyHint=True> property).  
  
2.  A <xref:System.Windows.Window?qualifyHint=False> or a <xref:System.Windows.Controls.Page?qualifyHint=False> (also using the inherited <xref:System.Windows.FrameworkElement.Resources?qualifyHint=True> property).  
  
3.  An <xref:System.Windows.Application?qualifyHint=False> (using the <xref:System.Windows.Application.Resources?qualifyHint=True> property).  
  
 The variety of scopes gives you flexibility with respect to the way in which you define and share your resources.  
  
 As an alternative to directly associating your resources with a particular scope, you can package one or more resources by using a separate <xref:System.Windows.ResourceDictionary?qualifyHint=False> that can be referenced in other parts of an application. For example, the following example defines a default background color in a resource dictionary.  
  
 [!CODE [IntroToWPFSnippets#ResourceDictionaryMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#resourcedictionarymarkup1)]  
[!CODE [IntroToWPFSnippets#ResourceDictionaryMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#resourcedictionarymarkup2)]  
  
 The following example references the resource dictionary defined in the previous example so that it is shared across an application.  
  
 [!CODE [IntroToWPFSnippets#ApplicationScopedResourceDictionaryMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#applicationscopedresourcedictionarymarkup1)]  
[!CODE [IntroToWPFSnippets#ApplicationScopedResourceDictionaryMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#applicationscopedresourcedictionarymarkup2)]  
  
 Resources and resource dictionaries are the foundation of WPF support for themes and skins.  
  
 For more information, see [Resources Overview](https://msdn.microsoft.com/en-us/library/ms750613\(v=vs.100\).aspx).  
  
### Custom Controls  
 Although WPF provides a host of customization support, you may encounter situations where existing WPF controls do not meet the needs of either your application or its users. This can occur when:  
  
-   The user interface that you require cannot be created by customizing the look and feel of existing WPF implementations.  
  
-   The behavior that you require is not supported (or not easily supported) by existing WPF implementations.  
  
 At this point, however, you can take advantage of one of three WPF models to create a new control. Each model targets a specific scenario and requires your custom control to derive from a particular WPF base class. The three models are listed here:  
  
-   **User Control Model**. A custom control derives from <xref:System.Windows.Controls.UserControl?qualifyHint=False> and is composed of one or more other controls.  
  
-   **Control Model**. A custom control derives from <xref:System.Windows.Controls.Control?qualifyHint=False> and is used to build implementations that separate their behavior from their appearance using templates, much like the majority of WPF controls. Deriving from <xref:System.Windows.Controls.Control?qualifyHint=False> allows you more freedom for creating a custom user interface than user controls, but it may require more effort.  
  
-   **Framework Element Model**. A custom control derives from <xref:System.Windows.FrameworkElement?qualifyHint=False> when its appearance is defined by custom rendering logic (not templates).  
  
 The following example shows a custom numeric up/down control that derives from <xref:System.Windows.Controls.UserControl?qualifyHint=False>.  
  
 [!CODE [IntroToWPFSnippets#UserControlMARKUP](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#usercontrolmarkup)]  
  
 [!CODE [IntroToWPFSnippets#UserControlCODEBEHIND1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#usercontrolcodebehind1)]  
[!CODE [IntroToWPFSnippets#UserControlCODEBEHIND2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#usercontrolcodebehind2)]  
[!CODE [IntroToWPFSnippets#UserControlCODEBEHIND3](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#usercontrolcodebehind3)]  
  
 The next example illustrates the XAML that is required to incorporate the user control into a <xref:System.Windows.Window?qualifyHint=False>.  
  
 [!CODE [IntroToWPFSnippets#UserControlWindowMARKUP1](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#usercontrolwindowmarkup1)]  
[!CODE [IntroToWPFSnippets#UserControlWindowMARKUP2](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#usercontrolwindowmarkup2)]  
[!CODE [IntroToWPFSnippets#UserControlWindowMARKUP3](../CodeSnippet/VS_Snippets_Wpf/IntroToWPFSnippets#usercontrolwindowmarkup3)]  
  
 The following figure shows the `NumericUpDown` control hosted in a <xref:System.Windows.Window?qualifyHint=False>.  
  
 ![A custom UserControl](../VS_IDE/media/WPFIntroFigure3.png "WPFIntroFigure3")  
  
 For more information on custom controls, see [Control Authoring Overview](https://msdn.microsoft.com/en-us/library/ms745025\(v=vs.100\).aspx).  
  
##  <a name="WPF_Best_Practices"></a> WPF Best Practices  
 As with any development platform, WPF can be used in a variety of ways to achieve the desired result. As a way of ensuring that your WPF applications provide the required user experience and meet the demands of the audience in general, there are recommended best practices for accessibility, globalization and localization, and performance. See the following for more information:  
  
-   [Accessibility Best Practices](https://msdn.microsoft.com/en-us/library/aa350483\(v=vs.100\).aspx)Accessibility Best Practices  
  
-   [WPF Globalization and Localization Overview](https://msdn.microsoft.com/en-us/library/ms788718\(v=vs.100\).aspx)  
  
-   [Optimizing WPF Application Performance](https://msdn.microsoft.com/en-us/library/aa970683\(v=vs.100\).aspx)  
  
-   [Windows Presentation Foundation Security](https://msdn.microsoft.com/en-us/library/aa970906\(v=vs.100\).aspx)  
  
##  <a name="Summary"></a> Summary  
 WPF is a comprehensive presentation technology for building a wide variety of visually stunning client applications. This introduction has provided a look at the key features of WPF.  
  
 The next step is to build WPF applications!  
  
 As you build them, you can come back to this introduction for a refresher on the key features and to find references to more detailed coverage of the features covered in this introduction.  
  
## See Also  
 [Getting Started with WPF](../VS_IDE/Getting-Started-with-WPF.md)   
 [Create Modern Desktop Applications with Windows Presentation Foundation](../VS_IDE/Create-Modern-Desktop-Applications-with-Windows-Presentation-Foundation.md)   
 [Windows Presentation Foundation](https://msdn.microsoft.com/en-us/library/ms754130\(v=vs.100\).aspx)