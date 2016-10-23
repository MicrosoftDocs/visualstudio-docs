---
title: "Lab management workflow activities"
ms.custom: na
ms.date: 10/03/2016
ms.prod: visual-studio-tfs-dev14
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: article
ms.assetid: b3f645d4-2db0-40e7-b8bf-eedca5d82ba8
caps.latest.revision: 37
manager: douge
translation.priority.ht: 
  - cs-cz
  - de-de
  - es-es
  - fr-fr
  - it-it
  - ja-jp
  - ko-kr
  - pl-pl
  - pt-br
  - ru-ru
  - tr-tr
  - zh-cn
  - zh-tw
---
# Lab management workflow activities
When you customize a Lab Management workflow template (LabDefaultTemplate.11.xaml), you can use one or more of the pre-defined Lab Management activities. You can also access objects that are created by the Lab Management wizard. This topic describes the Team Foundation Lab Management activities and objects that are available when you customize a workflow template to build, deploy, and test your application. For information about how to use these activities in a customized workflow, see [Customizing lab management workflow](../dv_TeamTestALM/Customizing-lab-management-workflow.md).  
  
 **Requirements**  
  
-   Visual Studio Enterprise, Visual Studio Test Professional  
  
##  <a name="BKMK_Top"></a> This topic contains the following sections:  
  
-   [Lab Management Activities](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabManagementActivities)  
  
-   [Lab Management Classes](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabManagementArgumentsAndObjects)  
  
##  <a name="BKMK_LabManagementActivities"></a> Lab Management Activities  
 The following table describes the individual Lab Management workflow activities.  
  
|Activity|Description|  
|--------------|-----------------|  
|[CreateLabEnvironment](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_CreateLabEnvironment)|Creates a new environment from a stored template and deploys it on the specified host group.|  
|[DeleteLabEnvironment](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_DeleteLabEnvironment)|Deletes an environment.|  
|[DeleteSnapshot](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_DeleteSnapshot)|Deletes a snapshot of an environment.|  
|[ExecuteRemoteTestRun](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_ExecuteRemoteTestRun)|Creates a test run on an environment and waits for it to finish.|  
|[GenerateEnvironmentViewerFile](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GenerateEnvironmentViewerFile)|Generates an environment viewer file that has snapshot link ID. It is used to connect to a snapshot of the environment.|  
|[GetBuildLocationAndBuildNumber](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetBuildLocationAndBuildNumber)|Returns the build location and build number for a build, deploy, and test scenario.|  
|[GetLabEnvironmentInUseMarker](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentInUseMarker)|Returns the In Use marker for an environment.|  
|[GetLabEnvironmentSnapshotId](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentSnapshotId)|Gets the ID of a snapshot of an environment.|  
|[GetLabEnvironmentStatus](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentStatus)|Gets the environment status.|  
|[GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri)|Gets the environment URI for a given environment name and lab location name.|  
|[InitializeAgentSpecAndEnvironmentVariables](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_InitializeAgentSpecAndEnvironmentVariables)|Parses the deploy script details specified by property|  
|[ResetLabEnvironmentInuseMarker](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_ResetLabEnvironmentInuseMarker)|Resets the In Use marker for an environment.|  
|[RestoreLabEnvironment](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RestoreLabEnvironment)|Restores the environment to the specified snapshot.|  
|[RunDeploymentScript](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RunDeploymentScript)|Runs the deployment script. On failure, throws or writes a build warning as specified in the **ThrowOnError** property.|  
|[RunWorkflow](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RunWorkflow)|Queues a new workflow on a build controller of a build server.|  
|[SaveLabEnvironment](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_SaveLabEnvironment)|Creates a new environment and stores it in a team project library share.|  
|[SetLabEnvironmentInuseMarker](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_SetLabEnvironmentInuseMarker)|Sets the In Use marker on environment.|  
|[SnapshotLabEnvironment](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_SnapshotLabEnvironment)|Takes a snapshot of an environment.|  
|[StartLabEnvironment](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_StartLabEnvironment)|Starts the environment.|  
|[StopLabEnvironment](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_StopLabEnvironment)|Stops the environment.|  
|[WaitForTestCapabilityServices](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_WaitForTestCapabilityServices)|Waits the specified maximum time for the testing capability of environment to be ready. At the end of the wait time, if the test capability is not ready, a time-out exception is thrown.|  
|[WaitForWorkflow](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_WaitForWorkflow)|Type of workflow.|  
|[WaitForWorkflowCapabilityServices](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_WaitForWorkflowCapabilityServices)|Waits for the queued build to complete for a given maximum wait time. If the build workflow does not finish in the given maximum time, the TimeOutException is thrown. The activity checks the queued build status periodically to determine which builds are finished. This interval is configured by using the **RefreshInterval** property.|  
|[WriteDeploymentInformation](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_WriteDeploymentInformation)|Writes deployment information that is included in the build summary.|  
  
###  <a name="BKMK_CreateLabEnvironment"></a> CreateLabEnvironment  
 Creates a new environment from a stored template and deploys it on the specified host group. This is a long-running activity and will wait until the new environment is created. If the new lab environment cannot be created, this activity throws a LabDeploymentProcessException exception.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentName**|Name of the new environment. If this property is null or empty, the environment template name will be used.|  
|**LabEnvironmentTemplateUri**|URI of a stored environment template. The lab environment template URI can be obtained by using [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity. Required.|  
|**TeamProjectHostGroupName**|Host group where the new environment will be deployed. If the specified host group is not found, a NoTeamProjectHostGroupFoundException exception is thrown. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_DeleteLabEnvironment"></a> DeleteLabEnvironment  
 Deletes an environment. This is a long-running activity and will wait until the environment is deleted. If the environment deletion fails, this activity throws a LabDeploymentProcessException exception.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of environment to be deleted. The lab environment URI can be obtained by using [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_DeleteSnapshot"></a> DeleteSnapshot  
 Deletes a snapshot of an environment. This is a long-running activity and will wait for the snapshot to be deleted. If the snapshot deletion fails this activity throws a LabDeploymentProcessException exception.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the lab environment whose snapshot will be deleted. The lab environment URI can be obtained by using [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity. Required.|  
|**SnapshotId**|ID of snapshot to be deleted. The snapshot ID can be obtained by using the [GetLabEnvironmentSnapshotId](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentSnapshotId)activity. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_ExecuteRemoteTestRun"></a> ExecuteRemoteTestRun  
 Creates a test run on an environment and waits for it to finish. This is a long-running activity that waits until the test run finishes or time-out occurs. You can set the time-out using the **MaxWaitTime** property. This activity checks the test run status periodically to determine which test runs are finished. This interval is configurable using the **RefreshInterval** property. The **MaxConsecutiveFailuresToIgnoreDuringWaitForCompletion** property can be used to specify the number of consecutive times to ignore Team Foundation Server errors while checking for the test run status.  
  
 **Return value**  
  
 A [TestRunStatistics](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_TestRunStatisticsClass) object that stores the details of the test run.  
  
 **Properties**  
  
|||  
|-|-|  
|**BuildNumber**|Build number on which tests are run.|  
|**LabEnvironmentUri**|URI of the environment on which test cases will be executed. The environment URI can be obtained by using the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity.|  
|**MaxConsecutiveFailuresToIgnoreDuringWaitForCompletion**|Maximum number of consecutive failures that should be ignored while the activity waits for the tests to run. The default value of this property is 3.|  
|**MaxWaitTime**|A <xref:System.TimeSpan?qualifyHint=False> that specifies the maximum wait time for the test run to finish. A time-out exception is thrown at the end of specified time duration. The default value is 0 (zero), which means that the activity waits indefinitely.|  
|**RefreshInterval**|A <xref:System.TimeSpan?qualifyHint=False> that specifies the interval after which the status of the test run is refreshed. The default value of this interval is 60 seconds.|  
|**TestDirectory**|Path to the test executables.|  
|**TestEnvironment**|Name of the test environment on which test cases will be executed.|  
|**TestParameters**|A [RunTestDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RunTestDetailsObject) object that specifies test parameters such as the test plan, the test suite, the test settings, and the test configuration. Required.|  
|**Title**|Name of the test run. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_GenerateEnvironmentViewerFile"></a> GenerateEnvironmentViewerFile  
 Generates an environment viewer file which contains the ID of the snapshot link. This activity is used to connect to a snapshot of the environment. The name of the environment viewer file is the snapshot name without any of the following special characters: @"[`~!@#$%^&*()+=[{\\]}&#124;\\\\;:',/?]" + "\\"".  
  
 **Properties**  
  
|||  
|-|-|  
|**FilePath**|UNC path of where to store the environment viewer file. The build service account must have write permission for the path. Required.|  
|**LabEnvironmentUri**|URI of the environment. The environment URI can be obtained by using the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity. Required.|  
|**SnapshotId**|ID of the snapshot. Snapshot ID can be obtained by using the [GetLabEnvironmentSnapshotId](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentSnapshotId)activity. If the snapshot is not valid, an InvalidSnapshotException exception is thrown. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_GetBuildLocationAndBuildNumber"></a> GetBuildLocationAndBuildNumber  
 Returns the build location and build number for a build, deploy, and test scenario. If "team build" is selected and build the URI is null, the last good build is selected and details are returned. If no last good build is found, a System.ArgumentException is thrown. If "team build" is not selected, only the build location specified by the user is returned.  
  
 **Return value**  
  
 A <xref:System.String?qualifyHint=False> that specifies the build location.  
  
 **Properties**  
  
|||  
|-|-|  
|**BuildDetails**|A Microsoft.TeamFoundation.Lab.Workflow.Activities.BuildDetails object that contains build-related information in build, deploy, and test scenario.|  
|**BuildNumber**|Build number of the selected build. This is an outArgument. This is null for non "team build" builds.|  
|**SelectedBuild**|Build information about the build server. This is an outArgument. This is null for non "team build" builds.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_GetLabEnvironmentInUseMarker"></a> GetLabEnvironmentInUseMarker  
 Gets the In Use marker for an environment.  
  
 **Return value**  
  
 A [LabEnvironmentInUseMarker](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabEnvironmentInUseMarker) that specifies the details of the environment marker  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_GetLabEnvironmentSnapshotId"></a> GetLabEnvironmentSnapshotId  
 Gets the snapshot ID of a snapshot of an environment. If no snapshot with specified name is found, this activity throws a NoSnapshotFoundException exception.  
  
 **Return value**  
  
 An <xref:System.Int64?qualifyHint=False> that specifies the identifier of the snapshot.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
|**SnapshotName**|Snapshot name. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_GetLabEnvironmentStatus"></a> GetLabEnvironmentStatus  
 Gets the status of the environment.  
  
 **Return value**  
  
 A [LabEnvironmentState](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabEnvironmentState) enumerated value that indicates the current state of the environment.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_GetLabEnvironmentUri"></a> GetLabEnvironmentUri  
 Gets the environment URI for a given environment name and lab location name. The lab location can be either a host group or a library share. If environment is not found, this activity throws LabEnvironmentNotFoundException exception.  
  
 **Return value**  
  
 A <xref:System.String?qualifyHint=False> that specifies the uri of the environment.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentName**|Environment name. Required.|  
|**ProjectName**|Name of the team project. If this property value is null or is not specified, the current project of the build is used.|  
|**TeamProjectLabLocationName**|Lab location name. Can be either a host group name or a library share name. If the lab location is not found, a NoLabLocationFoundException exception is thrown. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_InitializeAgentSpecAndEnvironmentVariables"></a> InitializeAgentSpecAndEnvironmentVariables  
 Initializes the arguments required for the [RunDeploymentScript](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RunDeploymentScript) activity. InitializeAgentSpecAndEnvironmentVariables extracts the properties of the virtual machines in the environment, that are required to target the deployment script on the machines.  
  
 **Return value**  
  
 A [ScriptDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_ScriptDetailsObject) object that stores the script details that are required for deployment.  
  
 **Properties**  
  
|||  
|-|-|  
|**BuildLocation**|Build location path. This is used to expand the macro $(BuildLocation). Required.|  
|**DeploymentScriptDetails**|Deployment details in the format " labsystemname &#124; script arguments &#124; working directory". Required.|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_ResetLabEnvironmentInuseMarker"></a> ResetLabEnvironmentInuseMarker  
 Resets the In Use marker for an environment.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_RestoreLabEnvironment"></a> RestoreLabEnvironment  
 Restores the environment to the specified snapshot. If the snapshot is not valid, the activity throws an InvalidSnapshotException exception.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
|**SnapshotId**|ID of the snapshot to restore the environment to. The snapshot ID can be obtained by using [GetLabEnvironmentSnapshotId](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentSnapshotId) activity. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_RunDeploymentScript"></a> RunDeploymentScript  
 Runs the deployment script. If the script fails, throws or writes a build warning as specified in the **ThrowOnError** property.  
  
 **Return value**  
  
 A <xref:Microsoft.TeamFoundation.Build.Client.BuildStatus?qualifyHint=False> enumerated value that specifies the status of the deployment operation.  
  
 **Properties**  
  
|||  
|-|-|  
|**MaximumAttemptsForNetUse**|Maximum number of attempts to add net use.|  
|**ScriptDetails**|A Script Details object for a lab system. Required.|  
|**SharedLocationForNetUse**|Location that should be accessible by the lab service account.|  
|**ThrowOnError**|Flag to indicate if exception should be thrown for error. Default value is True.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_RunWorkflow"></a> RunWorkflow  
 Queues a new workflow on a build controller of a build server. There are two ways that you can specify on which build controller the build has to be queued:  
  
1.  Use the **LabEnvironmentUri** property. If this environment is configured for workflow integration, it will use its build controller of the environment for queuing workflow. Otherwise, a LabDeploymentProcessException is thrown.  
  
2.  Use the **BuildControler** property to specify the build controller.  
  
 **Return value**  
  
 An <xref:System.Int32?qualifyHint=False> that specifies the ID of the queued build.  
  
 **Properties**  
  
|||  
|-|-|  
|**BuildController**|Build Controller Name. If this property and the **LabEnvironmentUri** property value are null or are not specified, the current build controller is used to queue the build.|  
|**BuildDefinition**|Build definition to be queued. Required.|  
|**LabEnvironmentUri**|URI of environment with workflow capabilities. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
|**ProjectName**|Name of the team project. If this property is null or is not specified, the current project of the build is used.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_SaveLabEnvironment"></a> SaveLabEnvironment  
 Creates a new environment and stores it in a team project library share. This is a long-running activity and will wait until the environment is saved. If creating the new environment fails, this activity throws a LabDeploymentProcessException exception.  
  
 **Return value**  
  
 A <xref:System.String?qualifyHint=False> that specifies the url of the new environment.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentName**|Name for saved environment. If this property is null or is empty, the environment name will be used.|  
|**LabEnvironmentUri**|URI of the environment to be saved. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the URI of the environment. Required.|  
|**TeamProjectLibraryShareName**|Library share where environment is stored. If the specified library share is not found, a NoTeamProjectLibraryShareFoundException exception is thrown. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_SetLabEnvironmentInuseMarker"></a> SetLabEnvironmentInuseMarker  
 Sets the In Use marker on environment.  
  
 **Properties**  
  
|||  
|-|-|  
|**Comment**|Comment written when the marker is set.|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_SnapshotLabEnvironment"></a> SnapshotLabEnvironment  
 Takes a snapshot of an environment. This is a long-running activity and will wait until the snapshot of environment is created. If creating the snapshot fails, this activity throws a LabDeploymentProcessException exception.  
  
 **Return value**  
  
 A <xref:System.Int64?qualifyHint=False> that specifies the ID of the snapshot.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of environment whose snapshot has to be taken. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
|**SnapshotChainId**|Returns the snapshot chain ID.|  
|**SnapshotName**|Name of the snapshot to be taken. If this property is null, the current DateTime value is used as the snapshot name.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_StartLabEnvironment"></a> StartLabEnvironment  
 Starts the environment. This is a long-running activity and will wait until the environment starts. If starting the environment fails, the activity throws a LabDeploymentProcessException exception.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_StopLabEnvironment"></a> StopLabEnvironment  
 Stops the environment. This is a long-running activity and will wait until the environment stops. If stopping the environment fails, the activity throws a LabDeploymentProcessException exception.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_WaitForTestCapabilityServices"></a> WaitForTestCapabilityServices  
 Waits the specified maximum time for the testing capability of environment to be ready. If the test capability is not ready at the end of the wait time, a time-out exception is thrown. If the **RepairCapabilityBeforeWaitBegins** property is set, the repair capability is invoked before waiting for capability to be ready. The maximum wait time can be configured by using the **MaxWaitTime** property.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
|**MaxWaitTime**|A System.TimeSpan object that specifies the maximum wait time for capability to be ready. A time-out exception is thrown at the end of specified time-out duration. The default value is 0 (zero), which means wait indefinitely.|  
|**RepairCapabilityBeforeWaitBegins**|If this value is true, an attempt to repair capability will be done before waiting.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_WaitForWorkflow"></a> WaitForWorkflow  
 Waits for the queued build to complete for a given maximum wait time. If the build workflow does not finish in the given maximum time TimeOut Exception is thrown. The activity checks the queued build status periodically to determine which builds are finished. This interval is configured by using the **RefreshInterval** property.  
  
 **Return value**  
  
 A [T: Microsoft.TeamFoundation.Build.Client.BuildStatus](assetId:///T: Microsoft.TeamFoundation.Build.Client.BuildStatus?qualifyHint=False&autoUpgrade=True) enumerated value that indicates the status of the workflow.  
  
 **Properties**  
  
|||  
|-|-|  
|**AllowPartiallySucceededBuild**|If true, partially succeeded is treated as success.|  
|**BuildDetails**|A Microsoft.TeamFoundation.Build.Client.IBuildDetail object that contains queued build details on the build server. This is an out argument.|  
|**LabWorkflowType**|The type of workflow.|  
|**MaxConsecutiveFailuresToIgnoreDuringWaitForCompletion**|Maximum number of consecutive failures that should be ignored while it waits for the workflow to finish. The default value of this is 3. This property can be used to increase the robustness of workflow.|  
|**MaxWaitTime**|A System.TimeSpan object that specifies the maximum wait time for the workflow to finish. A time-out exception is thrown at the end of specified time-out duration. The default value is 0 (zero) which means wait indefinitely.|  
|**QueueBuildId**|The ID of the queued build. Required.|  
|**RefreshInterval**|A System.TimeSpan object that specifies the interval after which the status of the workflow is refreshed. The default value of this interval is 60 seconds.|  
|**ThrowOnError**|If true, throws an exception if build fails.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_WaitForWorkflowCapabilityServices"></a> WaitForWorkflowCapabilityServices  
 Waits the specified time for the workflow capability of environment to be ready. If the workflow capability is not ready at the end of the wait time, throws a time-out exception. If the **RepairCapabilityBeforeWaitBegins** property is set, the repair capability is invoked before waiting for the capability to be ready. The maximum wait time can be configured by using the **MaxWaitTime** property.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabEnvironmentUri**|URI of the environment. Use the [GetLabEnvironmentUri](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity to get the environment URI. Required.|  
|**MaxWaitTime**|A System.TimeSpan object that specifies the maximum wait time for capability to be ready. A time-out exception is thrown at the end of specified time-out duration. Default value is 0 (zero), which means wait indefinitely.|  
|**RepairCapabilityBeforeWaitBegins**|If this value is true, an attempt to repair the capability will be done before waiting.|  
|**WaitForComputerNames**|If this value is true, waits until the computer names of all the virtual machines of the environment are available.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_WriteDeploymentInformation"></a> WriteDeploymentInformation  
 Writes deployment information that is included in the build summary. Deployment information section has three sub sections: Build, Deployment, and Test. You can add deployment information to a particular subsection by using the **DeploymentInformationType** property. Links can be added to deployment information by using the **Url** property.  
  
 **Properties**  
  
|||  
|-|-|  
|**Message**|Message to be displayed in the summary. Required.|  
|**Url**|Optional URL or link to add to the message.|  
|**DeploymentInformationType**|Specifies the subsection of the deployment information for this information message. Use one of the following values:<br /><br /> -   Build<br />-   Deploy<br />-   Test|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
##  <a name="BKMK_LabManagementArgumentsAndObjects"></a> Lab Management Classes  
 The following table summarizes Lab management classes that you can use in the Workflow Designer to customize a build, deploy, and test process. The classes are part of the **Microsoft.TeamFoundation.Lab.Workflow.Activities** namespace.  
  
|Object|Description|  
|------------|-----------------|  
|[LabWorkflowDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabWorkflowDetailsClass)|The LabWorkflowDetails class contains the configuration data from the Lab Workflow Parameters wizard. The LabWorkflowDetails object contains BuildDetails, RunTestDetails, and ScriptDetails objects.|  
|[BuildDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_BuildDetailsObject)|Stores the build details for a build, deploy, and test scenario.|  
|[DeploymentDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_DeploymentDetailsObject)|Stores the test parameter details that are required to create the automated test run in the build, deploy, and test workflow|  
|[LabEnvironmentDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabEnvironmentDetailsObject)|Stores the information required to identify the lab environment in build, deploy and test scenario|  
|[LabEnvironmentInUseMarker](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabEnvironmentInUseMarker)|Stores details of the In Use marker of an environment.|  
|[LabEnvironmentState](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabEnvironmentState)|Specifies the current state of the environment.|  
|[RunTestDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RunTestDetailsObject)|Stores the test parameter details that are required to create the automated test run.|  
|[ScriptDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_ScriptDetailsObject)|Stores the deployment script details that are required for a build, deploy, and test scenario.|  
|[ScriptDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_ScriptDetailsObject)|Stores details of a test run.|  
  
###  <a name="BKMK_LabWorkflowDetailsClass"></a> LabWorkflowDetails  
 The LabWorkflowDetails class contains the configuration data from the Lab Workflow Parameters wizard. In the LabDefaultTemplate, the LabWorkflowDetails object of a workflow is contained in the **LabWorkflowParameters** argument. The LabWorkflowDetails class contains the following properties:  
  
|||  
|-|-|  
|**BuildDetails**|A [BuildDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_BuildDetailsObject) object that is created by the workflow wizard and that stores the build details for a build, deploy, and test scenario.|  
|**DeploymentDetails**|A [LabEnvironmentDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabEnvironmentDetailsObject) object that is created by the workflow wizard and that stores the information that is required for the deployment of a build in a build, deploy, and test scenario.|  
|**EnvironmentDetails**|A [LabEnvironmentDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_LabEnvironmentDetailsObject) object that is created by the workflow wizard and that stores the information that identifies the environment to use for a build, deploy, and test scenario.|  
|**TestParameters**|A [RunTestDetails](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RunTestDetailsObject) object that is created by the workflow wizard and that stores the test parameter details that are required to create the automated test run.|  
  
###  <a name="BKMK_BuildDetailsObject"></a> BuildDetails  
 BuildDetails stores the build details for a build, deploy, and test scenario.  
  
 **Properties**  
  
|||  
|-|-|  
|**IsTeamSystemBuild**|A <xref:System.Boolean?qualifyHint=False> that indicates whether the build used is Team Build type.|  
|**BuildDefinitionUri**|A <xref:System.Uri?qualifyHint=False> that specifies the uri of the build definition.|  
|**BuildDefinitionName**|A <xref:System.String?qualifyHint=False> that specifies the name of the build definition|  
|**QueueNewBuild**|A <xref:System.Boolean?qualifyHint=False> that indicates whether the new build has to be queued.|  
|**BuildUri**|A <xref:System.Uri?qualifyHint=False> that specifies the uri of the build, if the build is a Team Build type,|  
|**CustomBuildPath**|A <xref:System.String?qualifyHint=False> that specifies the path to the build, if the build is not a Team Build type.|  
|**Configuration**||  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_DeploymentDetailsObject"></a> DeploymentDetails  
 DeploymentDetails stores the test parameter details that are required to create the automated test run in the build, deploy, and test workflow. You can access the DeploymentDetails object that is created by the Lab Management wizard by using the **DeploymentDetails** property of the [LabWorkflowParameters argument](#BKMK_LabWorkflowDetailsClass).  
  
 **Properties**  
  
|||  
|-|-|  
|**PostDeploymentSnapshotPath**|A <xref:System.String?qualifyHint=False> that contains the path to store post deployment snapshot.|  
|**PostDeploymentSnapshotName**|A <xref:System.String?qualifyHint=False> that specifies the name of the snapshot taken after deployment.|  
|**TakePostDeploymentSnapshot**|A <xref:System.Boolean?qualifyHint=False> that specifies whether a post deployment snapshot is needed.|  
|**Scripts**|A <xref:Microsoft.TeamFoundation.Build.Workflow.Activities.StringList?qualifyHint=False> object that contains a list of virtual machines with corresponding deployment scripts.|  
|**DeploymentNeeded**|A <xref:System.Boolean?qualifyHint=False> that specifies whether deployment needs to be done.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_LabEnvironmentDetailsObject"></a> LabEnvironmentDetails  
 A LabEnvironmentDetails stores the information required to identify the lab environment in build, deploy and test scenario. You can access the LabEnvironmentDetails object that is created by the Lab Management workflow wizard by using the **EnvironmentDetails** property of the[LabWorkflowParameters argument](#BKMK_LabWorkflowDetailsClass).  
  
 **Properties**  
  
|||  
|-|-|  
|**ProjectName**|A <xref:System.String?qualifyHint=False> that specifies the name of the team project|  
|**LabEnvironmentName**|A <xref:System.String?qualifyHint=False> that specifies the name of the lab environment|  
|**NewLabEnvironmentName**|A <xref:System.String?qualifyHint=False> that specifies the name of the lab environment to create.|  
|**HostGroupName**|A <xref:System.String?qualifyHint=False> that specifies the name of the host group where the environment is deployed.|  
|**LabLibraryShareName**|A <xref:System.String?qualifyHint=False> that specifies the name of the library share that contains the stored lab environment template.|  
|**RevertToSnapshot**|A <xref:System.Boolean?qualifyHint=False> that indicates whether the environment should be rolled back to a snapshot.|  
|**SnapshotName**|A <xref:System.String?qualifyHint=False> that specifies the name of the environment snapshot to roll back to.|  
|**TfsUrl**|A <xref:System.String?qualifyHint=False> that specifies the url of the Team Foundation Server.|  
|**LabEnvironmentUri**|A <xref:System.Uri?qualifyHint=False> that specifies the uri of the selected environment.|  
|**Disposition**|A  **LabEnvironmentDisposition** enumerated value that indicates the status of the environment. The values are:<br /><br /> **Unknown** - the status of the environment is not known.<br /><br /> **Active** - the environment is deployed on a host and can be started and run.<br /><br /> **Stored** - the environment is stored in a library share and cannot be used until it is deployed.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_RunTestDetailsObject"></a> RunTestDetails  
 RunTestDetails stores the test parameter details that are required to create the automated test run in the build, deploy, and test workflow. You can access the RunTestDetails object that is created by the Lab Management wizard by using the **TestParameters** property of the [LabWorkflowParameters argument](#BKMK_LabWorkflowDetailsClass).  
  
 **Properties**  
  
|||  
|-|-|  
|**TfsUrl**|A <xref:System.String?qualifyHint=False> that specifies the URL of the Team Foundation Server.|  
|**Project name**|A <xref:System.String?qualifyHint=False> that specifies the name of the team project.|  
|**TestConfigurationId**|A <xref:System.Int32?qualifyHint=False> that specifies the id of the test configuration for the test run.|  
|**TestPlanId**|A <xref:System.Int32?qualifyHint=False> that specifies the id of the test plan|  
|**TestSuiteIdList**|A Systems.Collections.Generic.List<int\> that contains the numeric ids of the test suites to run|  
|**TestSettingsId**|A <xref:System.Int32?qualifyHint=False> that specifies the id of the test settings for the test run.|  
|**RunTest**|A <xref:System.Boolean?qualifyHint=False> that specifies whether to run the test.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_ScriptDetailsObject"></a> ScriptDetails  
 Provides details for deploy scripts. A ScriptDetails object is required when you add a [RunDeploymentScript](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_RunDeploymentScript) activity to the workflow designer. The [InitializeAgentSpecAndEnvironmentVariables](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_InitializeAgentSpecAndEnvironmentVariables) returns a ScriptDetails object.  
  
 **Properties**  
  
|||  
|-|-|  
|**LabSystemName**|A <xref:System.String?qualifyHint=False> that specifies the name of the lab environment.|  
|**AgentSpec**|A <xref:Microsoft.TeamFoundation.Build.Workflow.Activities.AgentReservationSpec?qualifyHint=False> object that contains tags that are associated with a build agent in the lab system.|  
|**FileName**|A <xref:System.String?qualifyHint=False> that specifies the name of the deployment script file.|  
|**Arguments**|A <xref:System.String?qualifyHint=False> that specifies the arguments to pass to the deployment script.|  
|**WorkingDirectory**|A <xref:System.String?qualifyHint=False> that specifies the working directory for the deployment script on the lab system.|  
|**EnvironmentVariables**|A System.Collection.Generic.IDictionary<String,String> that contains the environment variable name/value pairs.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_TestRunStatisticsClass"></a> TestRunStatistics  
 Stores details of a test run. A TestRunStatistics object is returned by the [ExecuteRemoteTestRun](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_ExecuteRemoteTestRun) activity.  
  
 **Properties**  
  
|||  
|-|-|  
|**TotalTests**|An <xref:System.Int32?qualifyHint=False> that specifies the total number of tests in the test run.|  
|**PassedTests**|An <xref:System.Int32?qualifyHint=False> that specifies the number of tests that passed in the test run.|  
|**FailedTests**|An <xref:System.Int32?qualifyHint=False> that specifies the number of tests that failed  in the test run.|  
|**InconclusiveTests**|An <xref:System.Int32?qualifyHint=False> that specifies the number of tests that were inconclusive  in the test run.|  
|**PendingTests**|An <xref:System.Int32?qualifyHint=False> that specifies the number of tests that have not yet run in the test run.|  
|**AbortedTests**|An <xref:System.Int32?qualifyHint=False> that specifies the number of tests that were aborted  in the test run.|  
|**InProgressTests**|An <xref:System.Int32?qualifyHint=False> that specifies the number of tests that have are currently running in the test run.|  
|**TestRunStatus**|A <xref:Microsoft.TeamFoundation.TestManagement.Client.TestRunState?qualifyHint=False> enumerated value that specifies the status of the test run.|  
|**TestRunId**|An <xref:System.Int32?qualifyHint=False> that specifies the identifier of the test run.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_LabEnvironmentInUseMarker"></a> LabEnvironmentInUseMarker  
 Stores details of the In Use marker of an environment. Use the [GetLabEnvironmentInUseMarker](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_GetLabEnvironmentInUseMarker) activity to return a LabEnvironmentInUseMarker object.  
  
 **Properties**  
  
|||  
|-|-|  
|**User**|A <xref:System.String?qualifyHint=False> that specifies the user who marked the environment.|  
|**Timestamp**|A <xref:System.DateTime?qualifyHint=False> that specifies time that the user marked the environment.|  
|**Comment**|A <xref:System.String?qualifyHint=False> that is specified by the user who marked the environment.|  
  
 [Back to top](../dv_TeamTestALM/Lab-management-workflow-activities.md#BKMK_Top)  
  
###  <a name="BKMK_LabEnvironmentState"></a> LabEnvironmentState  
 An enumeration that specifies the current state of the environment. The state of a lab environment is mostly determined by the states of the virtual machines it contains. If all the virtual machines are in a consistent stable state, the LabEnvironmentState value matches that state. Otherwise, the value is **Mixed** or **Failed**. When an operation is in progress on the environment, the lab environment is in a transitioning state, which indicates the ongoing operation.  
  
 LabEnvironmentState has the following values:  
  
 **Unknown**  
  
 **Creating**  
  
 **CreateFailed**  
  
 **CreateCancelling**  
  
 **Updating**  
  
 **Stored**  
  
 **Starting**  
  
 **Running**  
  
 **Pausing**  
  
 **Paused**  
  
 **Stopping**  
  
 **Stopped**  
  
 **CreatingSnapshot**  
  
 **DeletingSnapshot**  
  
 **RestoringSnapshot**  
  
 **Deleting**  
  
 **DeleteFailed**  
  
 **Deleted**  
  
 **Mixed**  
  
 **Failed**  
  
 **UnderMigration**  
  
## See Also  
 [LabDefaultTemplate workflow activities](../dv_TeamTestALM/LabDefaultTemplate-workflow-activities.md)