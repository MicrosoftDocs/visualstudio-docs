1. When prompted to install external packages, select **Install into a virtual environment**. Note the **Show required packages** control at the bottom of the dialog that will show which packages will be installed:

  ![Installing required packages](../media/tutorial-common-external-packages.png)

1. Select your preferred base interpreter for the virual environment (for example, **Python 2.7** or **Python 3.4**) and click **Create**:

  ![Adding a virtual environment when creating a project](../media/tutorials-common-add-virtual-environment.png)

1. Once the project is created, test it by selecting **Debug > Start Debugging** or pressing F5. By default, the application uses an in-memory repository which doesn't require any configuration. All data is lost when the web server is stopped.

1. Click around in the application to see its operation. You can see what type of repository is being used on the **About** page.

1. Stop the debugger when you're finished (**Debug > Stop Debugging** or Shift-F5).