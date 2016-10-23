---
title: "How To: Use the Concurrency Visualizer Markers SDK"
ms.custom: na
ms.date: 10/07/2016
ms.prod: visual-studio-dev14
ms.reviewer: na
ms.suite: na
ms.technology: 
  - vs-ide-debug
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: 19a45032-f8a7-4137-890e-2ceeec938b8d
caps.latest.revision: 7
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
# How To: Use the Concurrency Visualizer Markers SDK
<?xml version="1.0" encoding="utf-8"?>
<developerHowToDocument xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5" xmlns:xlink="http://www.w3.org/1999/xlink" xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xsi:schemaLocation="http://ddue.schemas.microsoft.com/authoring/2003/5 http://clixdevr3.blob.core.windows.net/ddueschema/developer.xsd">
  <introduction>
    <para>This topic shows how to use the Concurrency Visualizer SDK to create spans and write flags, messages, and alerts.</para>
  </introduction>
  <procedure>
    <title>To use C++</title>
    <steps class="ordered">
      <step>
        <content>
          <para>Add Concurrency Visualizer SDK support to your application. For more information, see <link xlink:href="4b22cdf9-59b1-4c88-a6d8-1644a4a11e08">Concurrency Visualizer SDK</link>.</para>
        </content>
      </step>
      <step>
        <content>
          <para>Add an <codeInline>include</codeInline> statement and a <codeInline>using</codeInline> statement for the SDK.</para>
          <code language="cpp">
#include &lt;cvmarkersobj.h&gt;
using namespace Concurrency::diagnostic;
               </code>
        </content>
      </step>
      <step>
        <content>
          <para>Add code to create three spans in the default marker series and write a flag, a message, and an alert, one to each span. The methods to write flags, messages, and alerts are members of the <legacyLink xlink:href="b8445ed0-c512-4f92-b6b4-3d05c044f939">marker_series</legacyLink> class. The constructor for the span class requires a <unmanagedCodeEntityReference>marker_series</unmanagedCodeEntityReference> object, so that each span is associated with a specific marker series. A <unmanagedCodeEntityReference>span</unmanagedCodeEntityReference> ends when it is deleted.</para>
          <code language="cpp">
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
</code>
        </content>
      </step>
      <step>
        <content>
          <para>On the menu bar, choose <ui>Analyze</ui>, <ui>Concurrency Visualizer</ui>, <ui>Start with Current Project</ui> to run the app and display the Concurrency Visualizer. The following illustration shows the three spans and three markers in the Concurrency Visualizer.</para>
          <mediaLink>
            <image xlink:href="928098b8-a47b-4eb5-beca-05c819239584" />
          </mediaLink>
        </content>
      </step>
      <step>
        <content>
          <para>Add code to create additional, custom marker series by calling the constructor for <unmanagedCodeEntityReference>marker_series</unmanagedCodeEntityReference> that takes a string name for the marker series.</para>
          <code language="cpp">
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
</code>
        </content>
      </step>
      <step>
        <content>
          <para>Start the current project to display the Concurrency Visualizer. The two marker series appear in their own lanes in Threads View. The following illustration shows the two new spans.</para>
          <mediaLink>
            <image xlink:href="807b148a-3e34-42f8-9349-4e1d09d83717" />
          </mediaLink>
        </content>
      </step>
    </steps>
  </procedure>
  <procedure>
    <title>To Use Visual Basic or C#</title>
    <steps class="ordered">
      <step>
        <content>
          <para>Add Concurrency Visualizer SDK support to your application. For more information, see <link xlink:href="4b22cdf9-59b1-4c88-a6d8-1644a4a11e08">Concurrency Visualizer SDK</link>.</para>
        </content>
      </step>
      <step>
        <content>
          <para>Add a <codeInline>using</codeInline> or <codeInline>Imports</codeInline> statement for the SDK.</para>
          <code language="vb">Imports Microsoft.ConcurrencyVisualizer.Instrumentation
</code>
          <code language="c#">using Microsoft.ConcurrencyVisualizer.Instrumentation;</code>
        </content>
      </step>
      <step>
        <content>
          <para>Add code to create three spans on the default marker series and write a flag, a message, and an alert, one to each span. You create a <codeEntityReference>T:Microsoft.ConcurrencyVisualizer.Instrumentation.Span</codeEntityReference> object by calling the static <codeEntityReference>EnterSpan</codeEntityReference> method. To write to the default series, you use the static write methods of the <codeEntityReference>T:Microsoft.ConcurrencyVisualizer.Instrumentation.Markers</codeEntityReference> class.</para>
          <code language="vb">        
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
</code>
          <code language="c#">            
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
alertSpan.Leave();</code>
        </content>
      </step>
      <step>
        <content address="b0d3a357-9de3-44a0-91a3-ade740f5e819">
          <para>On the menu bar, choose <ui>Analyze</ui>, <ui>Concurrency Visualizer</ui>, <ui>Start with Current Project</ui> to run the app and display the Concurrency Visualizer. The following illustration shows the three spans and three markers in the Threads View of the Concurrency Visualizer.</para>
          <mediaLink>
            <image xlink:href="b0d3a357-9de3-44a0-91a3-ade740f5e819" />
          </mediaLink>
        </content>
      </step>
      <step>
        <content>
          <para>Add code to create customer marker series by using the static <codeEntityReference>M:Microsoft.ConcurrencyVisualizer.Instrumentation.Markers.CreateMarkerSeries(System.String)</codeEntityReference> method. The <codeEntityReference>T:Microsoft.ConcurrencyVisualizer.Instrumentation.MarkerSeries</codeEntityReference> class contains methods for creating spans and writing flags, messages, and alerts.</para>
          <code language="vb">
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
messageSeriesSpan.Leave()</code>
          <code language="c#">
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
messageSeriesSpan.Leave();</code>
        </content>
      </step>
      <step>
        <content>
          <para>Start the current project to display the Concurrency Visualizer. The three marker series appear in their own lanes in the Threads View. The following illustration shows the three new spans.</para>
          <mediaLink>
            <image xlink:href="a572e17d-235f-4ee8-b356-223f97294547" />
          </mediaLink>
        </content>
      </step>
    </steps>
  </procedure>
  <relatedTopics>
    <link xlink:href="4b22cdf9-59b1-4c88-a6d8-1644a4a11e08">Concurrency Visualizer SDK</link>
  </relatedTopics>
</developerHowToDocument>