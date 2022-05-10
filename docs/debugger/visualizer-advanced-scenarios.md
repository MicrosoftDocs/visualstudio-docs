---
title: "Advanced Visualizer Scenarios | Microsoft Docs"
description: Visual Studio debugger visualizers advanced scenarios and examples for them. 
ms.date: "05/09/2022"
ms.topic: "conceptual"
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
ms.workload:
  - "multiple"
---
# Advanced Visualizer Scenarios

This article provides information that might be useful if you're writing your own custom data visualizers, particularly if the object that is being visualized or the visualizer UI itself is unusually complex.

## Handling long serialization time

There are some cases when calling the default <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetData%2A> method on the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource> will
result in a Timeout Exception being thrown by the visualizer. Custom data visualizer operations are allowed only a maximum of five seconds to guarantee that Visual Studio remains responsive. That is, every
call to <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.GetData%2A>, <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.CreateReplacementObject%2A>, <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.TransferData%2A>, etc., must finish their execution before the time limit is reached or VS will throw. Since there is no plan to provide support for changing this time constraint,
visualizer implementations must handle cases in which an object takes longer than this to be serialized by themselves. To handle this scenario correctly, it is recommended that the visualizer handles passing data from the
*debuggee-side* component to the *debugger-side* component by chunks or pieces.

For example, let us imagine that we have a complex object called `VerySlowObject` that has many fields and properties that must be processed and copied over to the *debugger-side* visualizer component. Among those properties, we have `VeryLongList` which, depending on the instance of `VerySlowObject`, might be serialized within the five seconds or take a little more.

```csharp
public class VerySlowObject
{
    // More properties...

    // One of the properties we want to visualize.
    List<SomeRandomObject> VeryLongList { get; }

    // More properties...
}
```

Therefore, we need to create our own custom <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource> derived class that overrides the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource.TransferData%2A> method.

```csharp
public class CustomVisualizerObjectSource : VisualizerObjectSource
{
    public override void TransferData(object obj, Stream fromVisualizer, Stream toVisualizer)
    {
        // Serialize `obj` into the `toVisualizer` stream...
    }
}
```

At this point we have two alternatives, we either add custom 'Command' and 'Response' types that let the visualizer coordinate between both components on the state of the data transfer; or we let the <xref:Microsoft.VisualStudio.DebuggerVisualizers.VisualizerObjectSource> handle it by itself. If our object had only a simple collection of the same types (and we wanted to send every element to the UI), the latter would be suggested since the *debuggee-side* would just return segments of the collection until the end was reached. In the case where we have several different parts or we might just want to return part of the whole object, the former might be easier. Considering that we decided for the second approach, we would have created the following classes on our debugee-side project.

```csharp
public class GetVeryLongListCommand
{
    public int StartOffset { get; }
    public int Count { get; }

    // Constructor...
}

public class GetVeryLongListResponse
{
    public string[] Values { get; }
    public bool TimoutOccurred { get; }

    // Constructor...
}
```

With all our helper classed in place, the `TransferData` method can be written as follows.

```csharp
public override void TransferData(object obj, Stream fromVisualizer, Stream toVisualizer)
{
    // Serialize `obj` into the `toVisualizer` stream...

    // Start our timer so that we can stop processing the request if we are taking too long.
    long startTime = Environment.TickCount;

    VerySlowObject slowObject = obj as VerySlowObject;

    // Read the supplied command
    fromVisualizer.Seek(0, SeekOrigin.Begin);
    IDeserializableObject deserializableObject = GetDeserializableObject(fromVisualizer);
    GetVeryLongListCommand command = deserializableObject.ToObject<GetVeryLongListCommand>();

    List<string> returnValues = new List<string>();

    for (int i = (int)command.StartOffset; i < slowObject.VeryLongList.Count; i++)
    {
        // If we have taken more than 3 seconds, just return what we have gotten so far and fetch the remaining data on a posterior call.
        if ((Environment.TickCount - startTime) > 3_000)
        {
            break;
        }

        // This call takes a considerable amount of time...
        returnValues.Add(slowObject.VeryLongList[i].ToString());
    }
    
    Serialize(toVisualizer, returnValues.ToArray());
}
```

And finally, our visualizer has just to take into account the possibility of receiving partial data and handle it correctly.

```csharp
public class CustomVisualizer : DialogDebuggerVisualizer
{
    protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
    {
        IVisualizerObjectProvider2 objectProvider2 = objectProvider as IVisualizerObjectProvider2;

        if (objectProvider2 != null)
        {
            List<string> verySlowObjectList = new List<string>();

            // Ask for batches of 100 elements until we get all the elements of our object...
            int requestedCount = 100;
            int fetchedCount;
            // Consider the possibility that we might timeout when fetching the data.
            bool timeoutOccurred;

            do
            {
                // Send the command requesting more elements from the collection.
                Stream commandStream = new MemoryStream();
                objectProvider2.Serialize(new GetVeryLongListCommand(verySlowObjectList.Count, requestedCount), commandStream);

                // Process the response
                Stream deserializableObjectStream = objectProvider2.TransferData(commandStream);
                IDeserializableObject deserializableObject = objectProvider2.GetDeserializableObjectFrom(deserializableObjectStream);

                GetVeryLongListResponse response = deserializableObject.ToObject<GetVeryLongListResponse>();

                // Check if a timeout occurred, if it did we will try fetching more data again.
                timeoutOccurred = response.TimoutOccurred;

                // If no timeout occurred and we did not get all the elements we asked for, then we reached the end
                // of the collection and we can safely exit the loop.
                fetchedCount = response.Values.Length;
                verySlowObjectList.AddRange(response.Values);
            }
            while (requestedCount == fetchedCount || timeoutOccurred);

            // Do some processing of the data before showing it to the user.
            string valuesToBeShown = ProcessList(verySlowObjectList);
            MessageBox.Show(valuesToBeShown);
        }

        MessageBox.Show("Error.");
    }

    // More methods...
}
```

## See also

- [Walkthrough: Write a visualizer in C#](../debugger/walkthrough-writing-a-visualizer-in-csharp.md)
- [Walkthrough: Write a visualizer in Visual Basic](../debugger/walkthrough-writing-a-visualizer-in-visual-basic.md)
- [Visualizer Security Considerations](../debugger/visualizer-security-considerations.md)
- [Visualizer API reference](../debugger/visualizer-api-reference.md)