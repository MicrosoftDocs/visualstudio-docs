
		void eventSource_ProjectStarted(object sender, ProjectStartedEventArgs e)
		{
			Console.WriteLine("Project Started: " + e.ProjectFile);			
		}

		void eventSource_ProjectFinished(object sender, ProjectFinishedEventArgs e)
		{
			Console.WriteLine("Project Finished: " + e.ProjectFile);
		}