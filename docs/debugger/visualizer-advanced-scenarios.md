---
title: "Advanced Visualizer Scenarios"
description: Visual Studio debugger visualizers advanced scenarios and examples for them. 
ms.date: "05/09/2022"
ms.topic: article
f1_keywords:
  - "vs.debug.visualizer.troubleshoot"
dev_langs:
  - "CSharp"
  - "VB"
  - "FSharp"
helpviewer_keywords:
  - "debugger, visualizers"
  - "visualizers, writing"
  - "visualizers"
author: "mpeyrotc"
ms.author: "mapeyrot"
manager: caslan
---
# Advanced visualizer scenarios

This article provides information that might be useful if you're writing your own custom data visualizers, particularly if the object that is being visualized or the visualizer UI itself is complex.

The following examples are based on a Visual Studio solution that has two projects. The first corresponds to a .NET Framework 4.7.2 project that is the *debugger-side* component for the UI logic. The second is a .NET Standard 2.0 project that is the *debuggee-side* component so that it can be used in .NET Core applications.

The *debugger-side* comprises a WPF window that might contain an indeterminate `ProgressBar` control that's visible on load and two labels called `DataLabel` and `ErrorLabel`, both collapsed on load. Once it finishes fetching the data from the object it's trying to visualize, the progress bar will be collapsed and the visualizer shows the data label with the relevant information. In the case of an error, the progress bar is also hidden, but it shows an error message using the error label. The following is a simplified example:

```xml
<Window x:Class="AdvancedVisualizer.DebuggerSide.VisualizerDialog"
        xmlns:local="clr-namespace:AdvancedVisualizer.DebuggerSide">

    <Grid>
        <StackPanel x:Name="progressControl" Orientation="Vertical" HorizontalAlignment="Center" VerticalAlignment="Center">
            <ProgressBar IsIndeterminate="True" Width="200" Height="10"/>
            <Label HorizontalAlignment="Center">Loading...</Label>
        </StackPanel>
        <Label x:Name="DataLabel" Visibility="Collapsed" HorizontalAlignment="Center" VerticalAlignment="Center" />
        <Label x:Name="ErrorLabel" Visibility="Collapsed" HorizontalAlignment="Center" VerticalAlignment="Center" />
    </Grid>

</Window>
```

To simplify the example, the `VisualizerDialog` interaction logic has a simple constructor that registers an event handler to its `Loaded` event. This event handler is in charge of fetching the data and changes depending on each example, so it is shown separately in each section.

```csharp
public partial class VisualizerDialog : Window
{
    private AdvancedVisualizerViewModel ViewModel => (AdvancedVisualizerViewModel)this.DataContext;

    public VisualizerDialog()
    {
        InitializeComponent();

        this.Loaded += VisualizerLoaded;
    }

    public void VisualizerLoaded(object sender, RoutedEventArgs e)
    {
        // Logic to fetch and show the data in the UI.
    }
}
```

The *debugger-side* has a view model called `AdvancedVisualizerViewModel` to handle the visualizer's logic for fetching its data from the *debuggee-side*. This changes depending on each example, so it's shown separately in each section. Finally, the visualizer entry point appears as follows:

```csharp
[assembly: DebuggerVisualizer(typeof(AdvancedVisualizer.DebuggerSide.AdvancedVisualizer), typeof(AdvancedVisualizer.DebuggeeSide.CustomVisualizerObjectSource), Target = typeof(VerySlowObject), Description = "Very Slow Object Visualizer")]
namespace AdvancedVisualizer.DebuggerSide
{
    public class AdvancedVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            IAsyncVisualizerObjectProvider asyncObjectProvider = (IAsyncVisualizerObjectProvider)objectProvider;

            AdvancedVisualizerViewModel viewModel = new AdvancedVisualizerViewModel(asyncObjectProvider);
            Window advancedVisualizerWindow = new VisualizerDialog() { DataContext = viewModel };

            advancedVisualizerWindow.ShowDialog();
        }
    }
}
```

  > [!NOTE]
  > In the preceding code, we are performing a cast on the `objectProvider`. The reasoning behind this cast is explained in the [Using the new Async API](#using-the-new-async-api) section.

The *debugee-side* varies depending on the example, so it's shown separately in each section.

## Using the new Async API

For compatibility reasons, the `Show` method that gets overridden by your `DialogDebuggerVisualizer` still receives an object provider instance of type `IVisualizerObjectProvider`. However, this type also implements the `IAsyncVisualizerObjectProvider` interface. Therefore, it's safe to cast it when using VS 2022 17.2 onward. That provider adds an async implementation of the methods present in `IVisualizerObjectProvider2`.

## Handling long serialization time

There are some cases when calling the default <xref:Microsoft.VisualStudio.DebuggerVisualizers.IAsyncVisualizerObjectProvider.GetDeserializableObjectAsync%2A> method on the <xref:Microsoft.VisualStudio.DebuggerVisualizers.IAsyncVisualizerObjectProvider> will result in a Timeout Exception thrown by the visualizer. Custom data visualizer operations are allowed only a maximum of five seconds to guarantee that Visual Studio remains responsive. That is, every call to <xref:Microsoft.VisualStudio.DebuggerVisualizers.IAsyncVisualizerObjectProvider.GetDeserializableObjectAsync%2A>, <xref:Microsoft.VisualStudio.DebuggerVisualizers.IAsyncVisualizerObjectProvider.ReplaceDataAsync%2A>, <xref:Microsoft.VisualStudio.DebuggerVisualizers.IAsyncVisualizerObjectProvider.TransferDeserializableObjectAsync%2A>, etc., must finish execution before the time limit is reached or VS will throw an exception. Because there's no plan to provide support for changing this time constraint, visualizer implementations must handle cases where an object takes longer than five seconds to be serialized. To handle this scenario correctly, we recommend that the visualizer handles passing data from the *debuggee-side* component to the *debugger-side* component by chunks or pieces.

  > [!NOTE]
  > The projects from where these code snippets were obtained can be downloaded from the [VSSDK-Extensibility-Samples](https://github.com/microsoft/VSSDK-Extensibility-Samples/tree/master/Advanced_Visualizer_Scenarios/EvaluationTimeoutSample) repository.

For example, imagine that you have a complex object called `VerySlowObject` that has many fields and properties that must be processed and copied over to the *debugger-side* visualizer component. Among those properties, you have `VeryLongList` which, depending on the instance of `VerySlowObject`, might be serialized within the five seconds or take a little more.

```csharp
public class VerySlowObject
{
    // More properties...

    // One of the properties we want to visualize.
    public List<SomeRandomObject> VeryLongList { get; }

    // More properties...
}
```

That's why you need to create our own *debugee-side* component, which is a class that derives from <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource> and overrides the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.TransferData%2A> method.

```csharp
public class CustomVisualizerObjectSource : VisualizerObjectSource
{
    public override void TransferData(object obj, Stream fromVisualizer, Stream toVisualizer)
    {
        // Serialize `obj` into the `toVisualizer` stream...
    }
}
```

At this point, you have two alternatives; you either add custom 'Command' and 'Response' types that let the visualizer coordinate between both components on the state of the data transfer; or you let the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource> handle it by itself. If your object had only a simple collection of the same types (and you wanted to send every element to the UI), the latter would be suggested since the *debuggee-side* would just return segments of the collection until the end was reached. In the case where you have several different parts or you might just want to return part of the whole object, the former might be easier. Considering that you decided on the second approach, you would have created the following classes on your *debugee-side* project.

```csharp
[Serializable]
public class GetVeryLongListCommand
{
    public int StartOffset { get; }

    // Constructor...
}

[Serializable]
public class GetVeryLongListResponse
{
    public string[] Values { get; }
    public bool IsComplete { get; }

    // Constructor...
}
```

With your helper classes in place, your view model can have an async method to fetch the data and process it for it to be displayed in the UI. In this example, call it `GetDataAsync`.

```csharp
public async Task<string> GetDataAsync()
{
    List<string> verySlowObjectList = new List<string>();

    // Consider the possibility that we might timeout when fetching the data.
    bool isRequestComplete;

    do
    {
        // Send the command requesting more elements from the collection and process the response.
        IDeserializableObject deserializableObject = await m_asyncObjectProvider.TransferDeserializableObjectAsync(new GetVeryLongListCommand(verySlowObjectList.Count), CancellationToken.None);
        GetVeryLongListResponse response = deserializableObject.ToObject<GetVeryLongListResponse>();

        // Check if a timeout occurred. If it did we try fetching more data again.
        isRequestComplete = response.IsComplete;

        // If no timeout occurred and we did not get all the elements we asked for, then we reached the end
        // of the collection and we can safely exit the loop.
        verySlowObjectList.AddRange(response.Values);
    }
    while (!isRequestComplete);

    // Do some processing of the data before showing it to the user.
    string valuesToBeShown = ProcessList(verySlowObjectList);
    return valuesToBeShown;
}

private string ProcessList(List<string> verySlowObjectList)
{
    // Do some processing of the data before showing it to the user...
}
```

The `GetDataAsync` method creates the `GetVeryLongListCommand` instance in a loop, send it over to the *debuggee-side* for it to process, and based on the response it either resends it to get the rest of the data or ends the cycle since it has fetched all of it. The `TransferData` method on the *debuggee-side* can handle the request as follows.

```csharp
public override void TransferData(object obj, Stream fromVisualizer, Stream toVisualizer)
{
    // Serialize `obj` into the `toVisualizer` stream...

    // Start the timer so that we can stop processing the request if it's are taking too long.
    long startTime = Environment.TickCount;

    if (obj is VerySlowObject slowObject)
    {
        bool isComplete = true;

        // Read the supplied command
        fromVisualizer.Seek(0, SeekOrigin.Begin);
        IDeserializableObject deserializableObject = GetDeserializableObject(fromVisualizer);
        GetVeryLongListCommand command = deserializableObject.ToObject<GetVeryLongListCommand>();

        List<string> returnValues = new List<string>();

        for (int i = (int)command.StartOffset; i < slowObject.VeryLongList?.Count; i++)
        {
            // If the call takes more than 3 seconds, just return what we have received so far and fetch the remaining data on a posterior call.
            if ((Environment.TickCount - startTime) > 3_000)
            {
                isComplete = false;
                break;
            }

            // This call takes a considerable amount of time...
            returnValues.Add(slowObject.VeryLongList[i].ToString());
        }

        GetVeryLongListResponse response = new GetVeryLongListResponse(returnValues.ToArray(), isComplete);
        Serialize(toVisualizer, response);
    }
    else
    {
        // Handle failure case...
    }
}
```

Once the view model has all the data, your visualizer's `VisualizerLoaded` event handler makes the call to the view model so that it can request the data.

```csharp
public void VisualizerLoaded(object sender, RoutedEventArgs e)
{
    _ = Dispatcher.InvokeAsync(async () =>
    {
        try
        {
            string data = await this.ViewModel.GetDataAsync();

            this.DataLabel.Visibility = Visibility.Visible;
            this.DataLabel.Content = data;
        }
        catch
        {
            this.ErrorLabel.Content = "Error getting data.";
        }
        finally
        {
            this.progressControl.Visibility = Visibility.Collapsed;
        }
    });
}
```
  > [!NOTE]
  > It's important to handle errors that might happen with the request and to inform the user of them here.

With these changes, your visualizer should be able to handle objects that take a long time to serialize from the *debuggee-side* to the *debugger-side*.

## Related content

- [Walkthrough: Write a visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)
- [Walkthrough: Write a visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md)
- [Visualizer Security Considerations](../debugger/visualizer-security-considerations.md)
- [Visualizer API reference](../debugger/visualizer-api-reference.md)
