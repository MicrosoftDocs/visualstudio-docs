	public class MySimpleLogger : Logger
	{
		public override void Initialize(Microsoft.Build.Framework.IEventSource eventSource)
		{
			//Register for the ProjectStarted, TargetStarted, and ProjectFinished events
			eventSource.ProjectStarted += new ProjectStartedEventHandler(eventSource_ProjectStarted);
			eventSource.TargetStarted += new TargetStartedEventHandler(eventSource_TargetStarted);
			eventSource.ProjectFinished += new ProjectFinishedEventHandler(eventSource_ProjectFinished);
		}
	 }
