---
title: "How To: Use the Concurrency Visualizer Markers SDK | Microsoft Docs"
ms.date: "11/04/2016"
ms.topic: "conceptual"
ms.assetid: 19a45032-f8a7-4137-890e-2ceeec938b8d
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# How To: Use the Concurrency Visualizer markers SDK
This topic shows how to use the Concurrency Visualizer SDK to create spans and write flags, messages, and alerts.

### To use C++

1. Add Concurrency Visualizer SDK support to your application. For more information, see [Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md).

2. Add an `include` statement and a `using` statement for the SDK.

    ```cpp
    #include <cvmarkersobj.h>
    using namespace Concurrency::diagnostic;
    ```

3. Add code to create three spans in the default marker series and write a flag, a message, and an alert, one to each span. The methods to write flags, messages, and alerts are members of the [marker_series](../profiling/marker-series-class.md) class. The constructor for the [span](../profiling/span-class.md) class requires a `marker_series` object, so that each span is associated with a specific marker series. A `span` ends when it is deleted.

    ```cpp
    marker_series series;
    span *flagSpan = new span(series, 1, _T("flag span"));
    series.write_flag(_T("Here is the flag."));
    delete flagSpan;

    span *messageSpan = new span(series, 2, _T("message span"));
    series.write_flag(_T("Here is the message."));
    delete messageSpan;

    span *alertSpan = new span(series, 3, _T("alert span"));
    series.write_flag(_T("Here is the alert."));
    delete alertSpan;
    ```

4. On the menu bar, choose **Analyze**, **Concurrency Visualizer**, **Start with Current Project** to run the app and display the Concurrency Visualizer. The following illustration shows the three spans and three markers in the Concurrency Visualizer.

     ![Concurrency Visualizer with 3 markers and alerts](../profiling/media/cvmarkersnative.png "CvMarkersNative")

5. Add code to create additional, custom marker series by calling the constructor for `marker_series` that takes a string name for the marker series.

    ```cpp
    marker_series flagSeries(_T("flag series"));
    span *flagSeriesSpan = new span(flagSeries, 1, _T("flag span"));
    flagSeries.write_flag(1, _T("flag"));
    // Sleep to even out the display in the Concurrency Visualizer.
    Sleep(50);
    delete flagSeriesSpan;

    marker_series messageSeries(_T("message series"));
    span *messageSeriesSpan = new span(messageSeries, 1, _T("message span"));
    messageSeries.write_message(1, _T("message"));
    // Sleep to even out the display in the Concurrency Visualizer.
    Sleep(50);
    delete messageSeriesSpan;
    ```

6. Start the current project to display the Concurrency Visualizer. The two marker series appear in their own lanes in Threads View. The following illustration shows the two new spans.

     ![Concurrency Visualizer with 3 custom marker series](../profiling/media/cvmarkerseriesnative.png "CvMarkerSeriesNative")

### To Use Visual Basic or C\#

1. Add Concurrency Visualizer SDK support to your application. For more information, see [Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md).

2. Add a `using` or `Imports` statement for the SDK.

    ```vb
    Imports Microsoft.ConcurrencyVisualizer.Instrumentation
    ```

    ```csharp
    using Microsoft.ConcurrencyVisualizer.Instrumentation;
    ```

3. Add code to create three spans on the default marker series and write a flag, a message, and an alert, one to each span. You create a [Span](/previous-versions/hh694189(v=vs.140)) object by calling the static `EnterSpan` method. To write to the default series, you use the static write methods of the [Markers](/previous-versions/hh694099(v=vs.140)) class.

    ```vb
    Dim flagSpan As Span = Markers.EnterSpan("flag span")
    Markers.WriteFlag("Here is the flag.")
    flagSpan.Leave()

    Dim messageSpan As Span = Markers.EnterSpan("message span")
    ' Sleep for a millisecond to even out the display in the Concurrency Visualizer.
    System.Threading.Thread.Sleep(1)
    Markers.WriteMessage("Here is a message")
    messageSpan.Leave()

    Dim alertSpan As Span = Markers.EnterSpan("alert span")
    ' Sleep for a millisecond to even out the display in the Concurrency Visualizer.
    System.Threading.Thread.Sleep(1)
    Markers.WriteAlert("Here is an alert")
    alertSpan.Leave()
    ```

    ```csharp
    Span flagSpan = Markers.EnterSpan("flag span");
    Markers.WriteFlag("Here is the flag.");
    flagSpan.Leave();

    Span messageSpan = Markers.EnterSpan("message span");
    // Sleep for a millisecond to even out the display in the Concurrency Visualizer.
    System.Threading.Thread.Sleep(1);
    Markers.WriteMessage("Here is a message");
    messageSpan.Leave();

    Span alertSpan = Markers.EnterSpan("alert span");
    // Sleep for a millisecond to even out the display in the Concurrency Visualizer.
    System.Threading.Thread.Sleep(1);
    Markers.WriteAlert("Here is an alert");
    alertSpan.Leave();
    ```

4. On the menu bar, choose **Analyze**, **Concurrency Visualizer**, **Start with Current Project** to run the app and display the Concurrency Visualizer. The following illustration shows the three spans and three markers in the Threads View of the Concurrency Visualizer.

     ![Concurrency Visualizer with markers and alerts](../profiling/media/cvmarkersmanaged.png "CvMarkersManaged")

5. Add code to create customer marker series by using the static [CreateMarkerSeries](/previous-versions/hh694171(v=vs.140)) method. The [MarkerSeries](/previous-versions/hh694127(v=vs.140)) class contains methods for creating spans and writing flags, messages, and alerts.

    ```VB

    Dim flagSeries As MarkerSeries = Markers.DefaultWriter.CreateMarkerSeries("flag series")
    Dim flagSeriesSpan As Span = flagSeries.EnterSpan("flag span")
    System.Threading.Thread.Sleep(1)
    flagSeries.WriteFlag(1, "flag")
    System.Threading.Thread.Sleep(1)
    flagSeriesSpan.Leave()

    Dim messageSeries As MarkerSeries = Markers.DefaultWriter.CreateMarkerSeries("message series")
    Dim messageSeriesSpan As Span = messageSeries.EnterSpan("message span")
    messageSeries.WriteMessage("message")
    System.Threading.Thread.Sleep(1)
    messageSeriesSpan.Leave()
    ```

    ```csharp

    MarkerSeries flagSeries = Markers.DefaultWriter.CreateMarkerSeries("flag series");
    Span flagSeriesSpan = flagSeries.EnterSpan("flag span");
    System.Threading.Thread.Sleep(1);
    flagSeries.WriteFlag(1, "flag");
    System.Threading.Thread.Sleep(1);
    flagSeriesSpan.Leave();

    MarkerSeries messageSeries = Markers.DefaultWriter.CreateMarkerSeries("message series");
    Span messageSeriesSpan = messageSeries.EnterSpan("message span");
    messageSeries.WriteMessage("message");
    System.Threading.Thread.Sleep(1);
    messageSeriesSpan.Leave();
    ```

6. Start the current project to display the Concurrency Visualizer. The three marker series appear in their own lanes in the Threads View. The following illustration shows the three new spans.

     ![Concurrency Visualizer with 3 custom marker series](../profiling/media/cvmarkerseriesmanaged.png "CvMarkerSeriesManaged")

## See also
- [Concurrency Visualizer SDK](../profiling/concurrency-visualizer-sdk.md)
