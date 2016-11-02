---
title: "LabDefaultTemplate workflow activities"
ms.custom: na
ms.date: "10/03/2016"
ms.prod: "visual-studio-tfs-dev14"
ms.reviewer: na
ms.suite: na
ms.tgt_pltfrm: na
ms.topic: "article"
ms.assetid: 1175495c-f52e-45a3-914c-6ece94471644
caps.latest.revision: 21
ms.author: "ahomer"
manager: "douge"
translation.priority.ht: 
  - "cs-cz"
  - "de-de"
  - "es-es"
  - "fr-fr"
  - "it-it"
  - "ja-jp"
  - "ko-kr"
  - "pl-pl"
  - "pt-br"
  - "ru-ru"
  - "tr-tr"
  - "zh-cn"
  - "zh-tw"
---
# LabDefaultTemplate workflow activities
This topic describes the Windows Workflow activities in the LabDefaultTemplate.11.xaml file. LabDefaultTemplate defines the Lab Management workflow process that enables you build, deploy, and test your application in a lab environment. To learn more about Windows Workflow, see this page [A Developer's Introduction to Windows Workflow Foundation (WF) in .NET 4](http://go.microsoft.com/fwlink/?LinkId=200470) on the MSDN website.  
  
 **Requirements**  
  
-   Visual Studio Enterprise, [!INCLUDE[vstsTestEssLong](../test/includes/vststestesslong_md.md)]  
  
## Initializing the Workflow  
 ![Process root activity](../test/media/lm-ldt-process.png "LM-LDT-Process")  
  
 The root of the LabDefaultTemplate is the TfsBuild.Process activity. This \<xref:System.Activities.ActivityBuilder> initializes the global arguments for the workflow build definition from the input supplied in the Build Definition window and in the Lab Workflow Parameters wizard.  
  
### Arguments  
 The `LabWorkflowParameters` argument contains the data that is supplied in the Lab Workflow Parameters wizard. This argument is a [LabWorkflowDetails](../test/lab-management-workflow-activities.md#BKMK_LabWorkflowDetailsClass) object that contains the following objects:  
  
|||  
|-|-|  
|`BuildDetails`|A [BuildDetails](../test/lab-management-workflow-activities.md#BKMK_BuildDetailsObject) object that stores the build details for the build, deploy, and test workflow.|  
|`DeploymentDetails`|A [LabEnvironmentDetails](../test/lab-management-workflow-activities.md#BKMK_LabEnvironmentDetailsObject) object that stores the information that is required for the deployment of a build in the workflow.|  
|`EnvironmentDetails`|A [LabEnvironmentDetails](../test/lab-management-workflow-activities.md#BKMK_LabEnvironmentDetailsObject) object that stores the information that identifies the environment to use for a build, deploy, and test scenario.|  
|`TestParameters`|A [RunTestDetails](../test/lab-management-workflow-activities.md#BKMK_RunTestDetailsObject) object that stores the test parameter details that are required to create the automated test run.|  
  
 The following arguments are also declared at the global scope:  
  
|Argument|Type|  
|--------------|----------|  
|`Metadata`|\<xref:Microsoft.TeamFoundation.Build.Workflow.ProcessParameter>MetadataCollection|  
|**`Verbosity`**|A \<xref:Microsoft.TeamFoundation.Build.Workflow.Verbosity> enumerated value that specifies the amount of information that is written to the log.|  
|`BuildNumberFormat`|A \<xref:System.String> that specifies format of the build number.|  
|`SupportedReasons`|A \<xref:Microsoft.TeamFoundation.Build.Client.BuildReason>enumerated value that specifies the reason for the build.|  
  
## Application Deployment Workflow Sequence  
  
|||  
|-|-|  
|![Application deployment workflow](../test/media/lm-ldt-appdeploywf.png "LM-LDT-AppDeployWF")|The **Application Deployment Workflow** sequence controls the entire build, deploy, and test scenario.<br /><br /> **Application Deployment Workflow** declares the following variables:<br /><br /> -   `BuildDetail`: A \<xref:Microsoft.TeamFoundation.Build.Client.IBuildDetail> object.<br />-   `LabEnvironmnetUri`: A \<xref:System.String> that specifies the uri of the environment on which the build is deployed.<br />-   `BuildLocation`: A \<xref:System.String> that specifies the location of the build.<br />-   `SnapshotId`: A \<xref:System.String> that specifies the identifier of a virtual machine snapshot.<br />-   `QueueBuildId`: A \<xref:System.Int32> that specifies the identifier of the build in the queue.|  
  
## Running the Build  
  
|||  
|-|-|  
|**Update Build Number**|**Update Build Number** expands and returns the build number in the `BuildNumberFormat` argument. **Update Build Number** is a [Microsoft.TeamFoundation.Build.Workflow.Activities.UpdateBuildNumber](../Topic/Team%20Foundation%20Build%20activities.md#Activity_UpdateBuildNumber) activity.|  
|**Get Build Details**|**Get Build Details** returns the data that is required to run or access the build that was specified in the Workflow Wizard. The IBuildDetail object is stored in the `BuildDetail` variable.<br /><br /> **Get Build Details** is a [Microsoft.TeamFoundation.Build.Workflow.Activities.GetBuildDetail](../Topic/Team%20Foundation%20Build%20activities.md#Activity_GetBuildDetail) activity. The template sets the following properties:<br /><br /> -   **Result** returns an IBuildDetail object to the `BuildDetail` variable.|  
|![If Build is Needed activity](../test/media/lm-ldt-ifbuildneded.png "LM-LDT-IfBuildNeded")|**If Build is needed** determines whether a new build is needed for a Team System build process. If the conditions are met, the workflow runs the **Do Build** sequence.|  
|![Do build activity](../test/media/lm-ldt-dobuild.png "LM-LDT-DoBuild")|The **Do Build** sequence initiates the build, waits for the build to complete, and then sets the build location.|  
|**Start Build Workflow**|**Start Build Workflow** queues a new build on the specified build controller and returns the id of the queued build in the **QueueBuildId** variable. **Start Build Workflow** is a [RunWorkflow](../test/lab-management-workflow-activities.md#BKMK_RunWorkflow) activity. The template sets the following properties:<br /><br /> -   **BuildDefinition** is set to the  `BuildDetails.BuildDefinitionName` property of the  `LabWorkflowParameters` argument.<br />-   The **ProjectName** argument is set to the `TeamProject` property of the  `BuildDetail`variable.|  
|**Wait For Build To Complete**|**Wait For Build To Complete**  suspends execution until the build is complete or a timeout interval is elapsed. The activity throws an exception if the timeout is reached. The activity returns the status of the build in the `BuildStatus` variable, and data about the new build in the `ChildBuildDetail` variable. **Wait For Build To Complete** is a [WaitForWorkflow](../test/lab-management-workflow-activities.md#BKMK_WaitForWorkflow) activity. The template sets the following property values:<br /><br /> -   **AllowPartiallySucceededBuild** is set to true<br />-   **BuildDetails** returns the new build data to the `ChildBuildDetail` variable.<br />-   **MaxWaitTime** is set to infinite.<br />-   **QueueBuildId** returns the queue id of the build  `QueueBuildId` variable.|  
|**Set Build Location**|**Set Build Location** assigns the location of the build from the `ChildBuildDetail` variable to the `BuildDetails.BuildUri` property of the `LabWorkflowParameters` argument.|  
  
## Deploying the Application  
  
|||  
|-|-|  
|**Update Deployment Summary**|**Update Deployment Summary** writes the name of the deployment target environment to the build page. **Update Deployment Summary** is a [WriteDeploymentInformation](../test/lab-management-workflow-activities.md#BKMK_WriteDeploymentInformation) activity.|  
|**GetBuildLocationAndBuildNumber**|**GetBuildLocationAndBuildNumber** returns the drop location for the build to **BuildLocation** variable. **GetBuildLocationAndBuildNumber** is a [GetBuildLocationAndBuildNumber](../test/lab-management-workflow-activities.md#BKMK_GetBuildLocationAndBuildNumber) activity. The template sets the following properties:<br /><br /> -   **BuildDetails** is set to the `BuildDetails` object that is contained in the `LabWorkflowParameters` argument<br />-   **BuildNumber** returns the build number to the `BuildNumber` variable.<br />-   **Result** returns the location of the build to the `BuildLocation` variable<br />-   **SelectedBuild** returns a \<xref:Microsoft.TeamFoundation.Build.Client.IBuildDetail> object to the `SelectedBuildDetail` variable that contains the build data on the build server.|  
|![Compute build location needed activity](../test/media/lm-ldt-compbldloc.png "LM-LDT-CompBldLoc")|If the **Compute build location needed** conditions are met, **Compute build path** adds platform and build configuration subfolders to the drop location.|  
|![If user selected stored environment activity](../test/media/lm-ldt-ifuserselectedstoredenv.png "LM-LDT-IfUserselectedstoredenv")|**If user selected stored environment** checks that the environment is deployed, and **Indicate error** throws an exception if the environment is stored in the library.|  
|**Get Lab Environment**|**Get Lab Environment** returns the uri of the environment to the `LabEnvironmentUri` variable. **Get Lab Environment** is a [GetLabEnvironmentUri](../test/lab-management-workflow-activities.md#BKMK_GetLabEnvironmentUri) activity. The template sets the following properities:<br /><br /> -   **LabEnvironmentName** is set to the value of the `EnvironmentDetails.LabEnvironmentName` property of the `LabWorkflowParameters` argument.<br />-   **ProjectName** is set to the value of the `TeamProject` property of the `BuildDetail` variable.<br />-   **Result** returns the uri of the lab environment to the `LabEnvironmentUri` variable.<br />-   **TeamProjectLabLocationName** is set to the value of the `EnvironmentDetails.HostGroupName` property of the `LabWorkflowParameters` argument.<br />-   **TfsServerUrl** is set to null.|  
|![If Restore Snapshot activity](../test/media/lm-ldt-ifrestoresnapshot.png "LM-LDT-IfRestoreSnapshot")|**If Restore Snapshot** determines whether the user requested that the environment be restored to a clean snapshot. If the condition is met, the **Restore Snapshot** sequence is run; otherwise **Clean snapshot not specified** writes a warning message to the build summary.|  
|![Restore Snapshot activity](../test/media/lm-ldt-restoresnapshot.png "LM-LDT-RestoreSnapshot")|In the **Restore Snapshot** sequence, **Get Snapshot Details** calculates the id of the snapshot, and **Restore Lab Environment to Snapshot** performs the restoration.|  
|**Get Snapshot Details**|**Get Snapshot Details** is a [GetLabEnvironmentSnapshotId](../test/lab-management-workflow-activities.md#BKMK_GetLabEnvironmentSnapshotId) activity. The template sets the following properties:<br /><br /> -   **LabEnvironmentUri** is set to the value of the `LabEnvironmentUri` variable.<br />-   **Result** returns the id of the snapshot to the `SnapshotId` variable.<br />-   **SnapshotName** is set to the `EnvironmentDetails.SnapshotName`  property of the `LabWorkflowParameters` argument.|  
|**Restore Lab Environment to Snapshot**|**Restore Lab Environment to Snapshot** is a [RestoreLabEnvironment](../test/lab-management-workflow-activities.md#BKMK_RestoreLabEnvironment) activity. The template sets the following properties:<br /><br /> -   **LabEnvironmentUri** is set to the value of the `LabEnvironmentUri`variable.<br />-   **SnapshotId** is set to the value of the `SnapshotId`variable.|  
|![If Deployment needed activity](../test/media/lm-ldt-ifdeployneeded.png "LM-lDT-IfDeployNeeded")|**If deployment needed** determines whether the user has requested a deployment.|  
|![Do Deployment activity](../test/media/lm-ldt-dodeployment.png "LM-LDT-DoDeployment")|If the condition is met, the **Do deployment** sequence is run.|  
|**Wait For Workflow Capability To be Ready**|**Wait For Workflow Capability To be Ready** suspends execution until the workflow capability of the environment is ready or a timeout interval is reached. If the timeout interval is exceeded an exception is thrown. **Wait For Workflow Capability To be Ready** is a [WaitForWorkflowCapabilityServices](../test/lab-management-workflow-activities.md#BKMK_WaitForWorkflowCapabilityServices) activity. The template sets the following properties:<br /><br /> -   **LabEnvironmentUri** is set to the value of the **LabEnvironmentUri** variable.<br />-   **MaxWaitTime** is set to 20 minutes<br />-   **RepairCapabilityBeforeWaitBegins** is set to false.|  
|![Run Deployment Script activity](../test/media/lm-ldt-rundeploymentscript.png "LM-LDT-RunDeploymentScript")|**Run Deployment scripts** executes the **Run Script On Lab System** sequence on each deployment script that is contained in the `DeploymentDetails.Scripts` property list of the `LabWorkflowParameters` argument.|  
|![Run Script on Lab System activity](../test/media/lm-ldt-runscriptonlabsystem.png "LM-LDT-RunScriptonLabSystem")|The **Run Scripts on Lab System** sequence executes the specified script on a virtual machine in the environment. **Run Scripts on Lab System** declares the following variables:<br /><br /> -   `scriptDetails`: [ScriptDetails](../test/lab-management-workflow-activities.md#BKMK_ScriptDetailsObject)|  
|**Initialize Agent Tags and deployment script**|**Initialize Agent Tags and deployment script** expands the macros and tags of the script and returns the results in a [ScriptDetails](../test/lab-management-workflow-activities.md#BKMK_ScriptDetailsObject) object. **Initialize Agent Tags and deployment script** is a [InitializeAgentSpecAndEnvironmentVariables](../test/lab-management-workflow-activities.md#BKMK_InitializeAgentSpecAndEnvironmentVariables) activity. The template sets the following values:<br /><br /> -   **BuildLocation** is set to the value of the `BuildLocation` variable.<br />-   **DeploymentScriptDetails** is set to the value of the iterated `DeploymentDetails.Scripts` string.<br />-   **LabEnvironmentUri** set to the value of the `LabEnvironmentUri` variable.<br />-   **Result** returns the expanded script to the `scriptDetails` variable.|  
|**Lab Agent Scope**|**Lab Agent Scope** determines whether the lab agent is installed and running on the target virtual machine and then calls **Running Deployment Script** to execute the script. An exception is thrown if any of the scripts fail on a machine. **Lab Agent Scope** is a [Microsoft.TeamFoundation.Build.Workflow.Activities.AgentScope](../Topic/Team%20Foundation%20Build%20activities.md#Activity_AgentScope)activity. The template sets the following properties:<br /><br /> -   **MaxExecutionTime** is set to infinite.<br />-   **MaxWaitTime** is set to 5 minutes.<br />-   **ReservationSpec** is set to the Microsoft.Te:amFoundation.Build.Client.BuildAgentSpec object that is the `AgentSpec` property of the `scriptDetails` variable.|  
|**Running Deployment Script**|**Running Deployment Script** executes the deployment script on the target virtual machine. **Running Deployment Script** is a [RunDeploymentScript](../test/lab-management-workflow-activities.md#BKMK_RunDeploymentScript) activity. The template sets the following values:<br /><br /> -   **ScriptDetails** is set to the value of the `scriptDetails` variable.<br />-   **ThrowOnError** is set to true.<br />-   **SharedLocationForNetUse** is set to the value of the `BuildLocation` variable.|  
|**Application Deployment Succeeded**|**Application Deployment Succeeded** writes information to the build summary. **Application Deployment Succeeded** is a [WriteDeploymentInformation](../test/lab-management-workflow-activities.md#BKMK_WriteDeploymentInformation) activity.|  
|![Post Deployment Snapshot](../test/media/lm-ldt-postdeploysnap.png "LM-LDT-PostDeploySnap")|**Post Deployment Snapshot**  determines whether the user has requested that a snapshot of the environment is to be saved after the deployment. If this condition is met, the **Take Post Deployment Snapshot** sequence is executed. Otherwise, **Post deployment snapshot not specified** writes a warning message to the log.|  
|![Take Post&#45;Deloyment Snapshot activity](../test/media/lm-ldt-take-post-deployment-snapshot.png "LM-LDT-Take-post-deployment-snapshot")|**Take Post Deployment Snapshot** sequence<br /><br /> **Take Post Deployment Snapshot** declares the following variables:<br /><br /> -   `PostDeploymentSnapshotChainId`: \<xref:System.Int64><br />-   `PostDeploymentSnapshotName`: \<xref:System.String> The template sets the default value to the value of the `BuildNumber` property of the `BuildDetails` variable.|  
|![Check snapshot name activity](../test/media/lm-ldt.png "LM-LDT")|**Check Snapshot Name** determines whether a snapshot name has been specified. If the condition is met, the specified name is used; otherwise the default value is used.|  
|**Taking Post Deployment snapshot**|**Taking Post Deployment snapshot** is a [SnapshotLabEnvironment](../test/lab-management-workflow-activities.md#BKMK_SnapshotLabEnvironment) activity that creates the snapshot. The template sets the following properties:<br /><br /> -   **LabEnvironmentUri** is set to the value of the `LabEnvironmentUri` variable.<br />-   **SnapshotChainId** returns the id of the snapshot to the `PostDeploymentSnapshotChainId` variable.<br />-   **SnapshotName** is set to the value of the `PostDeploymentSnapshotName` variable.|  
|**Taking Snapshot succeeded**|**Taking Snapshot succeeded** writes the snapshot name to the build summary. **Taking Snapshot succeeded** is a [WriteDeploymentInformation](../test/lab-management-workflow-activities.md#BKMK_WriteDeploymentInformation) activity.|  
|**Added connection link to the Snapshot**|**Added connection link to the Snapshot** writes the url of the snapshot to the build summary. **Added connection link to the Snapshot** is a [WriteDeploymentInformation](../test/lab-management-workflow-activities.md#BKMK_WriteDeploymentInformation) activity.|  
  
## Running Tests  
  
|||  
|-|-|  
|![Run Tests On Environment activity](../test/media/lm-ldt-run-tests-on-environment.png "LM-LDT-Run-tests-on-environment")|**Run Tests on Environment** determines whether automated tests were requested. If the condition is met, the **Run Tests** sequence is executed.|  
|![Run Tests activity](../test/media/lm-ldt-run-tests.png "LM-LDT-Run-Tests")|**Run Tests**<br /><br /> **Run Tests** declares the following variables:<br /><br /> -   `TestCapabilityInfo`: Microsoft.TeamFoundation.Lab.Client.TestingCapabilityInformation.<br />-   `TestResults`: Microsoft.TeamFoundation.Lab.Workflow.Activities.TestRunStatistics. The template sets the default value to a new TestRunStatistics object.|  
|**Wait For Test Capabilities to be ready**|**Wait For Test Capabilities to be ready** suspends execution until the testing capability of the environment is ready or a timeout interval is reached. If the timeout interval is exceeded an exception is thrown.<br /><br /> **Wait For Test Capabilities to be ready** is a [WaitForTestCapabilityServices](../test/lab-management-workflow-activities.md#BKMK_WaitForTestCapabilityServices) activity. The template sets the following properties:<br /><br /> -   **LabEnvironmentUri** is set to the value of the `LabEnvironmentUri` variable.<br />-   **MaxWaitTime** is set to 20 minutes.<br />-   **RepairCapabilityBeforeWaitBegins** is set to false.|  
|**Running Tests**|**Running Tests** executes the tests and returns the test results. **Running Tests** is an [ExecuteRemoteTestRun](../test/lab-management-workflow-activities.md#BKMK_ExecuteRemoteTestRun) activity. The template sets the following values:<br /><br /> -   **MaxWaitTime** is set to infinite.<br />-   **BuildNumber** is set to the value of the `BuildNumber` variable.<br />-   **TestDirectory** is set to the value of the `BuildLocation` variable.<br />-   **LabEnvironmentUri** is set to the value of the `LabEnvironmentUri` variable.<br />-   **TestParameters** is set to `TestParameters` object that is contained in the `LabWorkflowParameters` object.<br />-   **Result** returns Microsoft.TeamFoundation.Lab.Workflow.Activities.RunTestDetails object that contains the test results to the `TestResults` variable.<br />-   **Title** sets the name of the test run to the value of the `BuildNumber` property of the `BuildDetail` variable.|  
|![If All Tests Have Not Passed activity](../test/media/lm-ldt-iftestsnotpassed.png "LM-LDT-IfTestsNotPassed")|**If all tests have not passed** determines whether any tests have failed and executes **Set build status** if the condition is met.|  
|**Set build status**|**Set build status** determines whether the workflow includes the build or deployment of the application. If this condition is met, **Partially succeded** sets the workflow status to the \<xref:Microsoft.TeamFoundation.Build.Client.BuildStatus>`.PartiallySucceeded` value. Otherwise, **Failed** sets the `BuildStatus` variable to `Failed`.|  
  
## See Also  
 [Lab management workflow activities](../test/lab-management-workflow-activities.md)