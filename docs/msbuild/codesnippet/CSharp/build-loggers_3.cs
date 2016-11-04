		void eventSource_TargetStarted(object sender, TargetStartedEventArgs e)
		{
			if (Verbosity == LoggerVerbosity.Detailed)
			{
				Console.WriteLine("Target Started: " + e.TargetName);
			}
		}