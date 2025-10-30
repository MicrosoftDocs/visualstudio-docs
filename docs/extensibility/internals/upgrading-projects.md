---
title: Upgrading Projects
description: Learn about the interfaces that the Visual Studio SDK provides to implement upgrade support in your projects.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- upgrading VSPackages
- upgrading applications, strategies
- VSPackages, upgrade support
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Upgrading Projects

Changes to the project model from one version of Visual Studio to the next may require that projects and solutions be upgraded so that they can run on the newer version. The Visual Studio SDK provides interfaces that can be used to implement upgrade support in your own projects.

## Upgrade Strategies

To support an upgrade, your project system implementation must define and implement an upgrade strategy. In determining your strategy, you can choose to support side-by-side (SxS) backup, copy backup, or both.

- SxS backup means that a project copies only those files that need upgrading in place, adding a suitable file name suffix, for example, ".old".

- Copy backup means that a project copies all project items to a user-provided backup location. The relevant files at the original project location are then upgraded.

## How Upgrade Works

When a solution created in an earlier version of Visual Studio is opened in a newer version, the IDE checks the solution file to determine if it needs to be upgraded. If upgrading is required, the **Upgrade Wizard** is automatically launched to walk the user through the upgrade process.

When a solution needs upgrading, it queries each project factory for its upgrade strategy. The strategy determines whether the project factory supports copy backup or SxS backup. The information is sent to the **Upgrade Wizard**, which collects the information required for the backup and presents the applicable options to the user.

### Multi-Project Solutions

If a solution contains multiple projects and the upgrade strategies differ, such as when a C++ project that only supports SxS backup and a Web project that only support copy backup, the project factories must negotiate the upgrade strategy.

The solution queries each project factory for <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory>. It then calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject_CheckOnly%2A> to see if global project files need upgrading and to determine the supported upgrade strategies. The **Upgrade Wizard** is then invoked.

After the user completes the wizard, <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> is called on each project factory to perform the actual upgrade. To facilitate backup, IVsProjectUpgradeViaFactory methods provide the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUpgradeLogger> service to log the details of the upgrade process. This service cannot be cached.

After updating all relevant global files, each project factory can choose to instantiate a project. The project implementation must support <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade>. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> method is then called to upgrade all relevant project items.

> [!NOTE]
> The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> method does not provide the SVsUpgradeLogger service. This service can be obtained by calling <xref:Microsoft.VisualStudio.OLE.Interop.IServiceProvider.QueryService%2A>.

## Best Practices

Use the <xref:Microsoft.VisualStudio.Shell.Interop.SVsQueryEditQuerySave> service to check if you can edit a file before editing it, and can save it before saving it. This will help your backup and upgrade implementations handle project files under source control, files with insufficient permissions, and so forth.

Use the <xref:Microsoft.VisualStudio.Shell.Interop.SVsUpgradeLogger> service during all phases of backup and upgrade to provide information on the success or failure of the upgrade process.

For more information about backing up and upgrading projects, see the comments for IVsProjectUpgrade in vsshell2.idl.

## <a name="upgrading-custom-projects"></a> Upgrading Custom Projects

If you change the information persisted in the project file between different Visual Studio versions of your product, then you need to support upgrading your project file from the old to the new version. To support upgrading that allows you to participate in the **Visual Studio Conversion Wizard**, implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory> interface. This interface contains the only mechanism available for copy upgrading. The upgrading of the project happens as a part of the solution opens. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory> interface is implemented by the project factory, or should at least be obtainable from the project factory.

The old mechanism that uses the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade> interface is still supported, but conceptually upgrades the project system as a part of the project open. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade> interface is therefore called by the Visual Studio environment even if the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory> interface is called or implemented. This approach allows you to use <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory> to implement the copy and project only portions of the upgrade, and delegate the rest of the work to be done in-place (possibly at the new location) by the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade> interface.

For a sample implementation of <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade>, see [VSSDK Samples](https://github.com/Microsoft/VSSDK-Extensibility-Samples).

The following scenarios arise with project upgrades:

- If the file is of a newer format than the project can support, then it must return an error stating this. This assumes that the older version of your product includes code to check for the version.

- If the <xref:Microsoft.VisualStudio.Shell.Interop.__VSPPROJECTUPGRADEVIAFACTORYFLAGS.PUVFF_SXSBACKUP> flag is specified in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> method, the upgrade is going to be implemented as an in-place upgrade prior to the opening of the project.

- If the <xref:Microsoft.VisualStudio.Shell.Interop.__VSPPROJECTUPGRADEVIAFACTORYFLAGS.PUVFF_COPYBACKUP> flag is specified in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> method, the upgrade is implemented as a copy upgrade.

- If the <xref:Microsoft.VisualStudio.Shell.Interop.__VSUPGRADEPROJFLAGS.UPF_SILENTMIGRATE> flag is specified in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> call, then the user has been prompted by the environment to upgrade the project file as an in-place upgrade, after the project is opened. For example, the environment prompts the user to upgrade when the user opens an older version of the solution.

- If the <xref:Microsoft.VisualStudio.Shell.Interop.__VSUPGRADEPROJFLAGS.UPF_SILENTMIGRATE> flag is not specified in the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> call, then you must prompt the user to upgrade the project file.

     The following is an example upgrade prompt message:

     "The project '%1' was created with an older version of Visual Studio. If you open it with this version of Visual Studio, you may not be able to open it with older versions of Visual Studio. Do you want to continue and open this project?"

### To implement IVsProjectUpgradeViaFactory

1. Implement the method of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory> interface, specifically the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> method in your project factory implementation, or make the implementations callable from your project factory implementation.

2. If you want to do an in-place upgrade as a part of the solution opening, supply the flag <xref:Microsoft.VisualStudio.Shell.Interop.__VSPPROJECTUPGRADEVIAFACTORYFLAGS.PUVFF_SXSBACKUP> as the `VSPUVF_FLAGS` parameter in your <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> implementation.

3. If you want to do an in-place upgrade as a part of the solution opening, supply the flag <xref:Microsoft.VisualStudio.Shell.Interop.__VSPPROJECTUPGRADEVIAFACTORYFLAGS.PUVFF_COPYBACKUP> as the `VSPUVF_FLAGS` parameter in your <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> implementation.

4. For both the steps 2 and 3, the actual file upgrade steps, using <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2>, can be implemented as described in the "Implementing `IVsProjectUpgade`" section below, or you can delegate the actual file upgrade to <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade>.

5. Use the methods of <xref:Microsoft.VisualStudio.Shell.Interop.IVsUpgradeLogger> to post upgrade related messages for the user using Visual Studio Migration Wizard.

6. <xref:Microsoft.VisualStudio.Shell.Interop.IVsFileUpgrade> interface is used to implement any kind of file upgrade that needs to happen as part of project upgrade. This interface is not called from <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory>, but is supplied as a mechanism to upgrade files that are part of the project system, but the main project system might not be directly aware of. For example, this situation could arise if the compiler related files and properties are not handled by the same development team that handles the rest of the project system.

### IVsProjectUpgrade Implementation

If your project system implements <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade> only, it can't participate in the **Visual Studio Conversion Wizard**. However, even if you implement the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory> interface, you can still delegate the file upgrade to <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade> implementation.

#### To implement IVsProjectUpgrade

1. When a user attempts to open a project, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> method is called by the environment after the project is opened and before any other user action can be taken on the project. If the user had already been prompted to upgrade the solution, then the <xref:Microsoft.VisualStudio.Shell.Interop.__VSUPGRADEPROJFLAGS.UPF_SILENTMIGRATE> flag is passed in the `grfUpgradeFlags` parameter. If the user opens a project directly, such as by using the **Add Existing Project** command, then the <xref:Microsoft.VisualStudio.Shell.Interop.__VSUPGRADEPROJFLAGS.UPF_SILENTMIGRATE> flag is not passed and the project needs to prompt the user to upgrade.

2. In response to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> call, the project must evaluate whether the project file is upgraded. If the project does not need to upgrade the project type to a new version, then it can simply return the <xref:Microsoft.VisualStudio.VSConstants.S_OK> flag.

3. If the project needs to upgrade the project type to a new version, then it must determine whether the project file can be modified by calling the <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> method and passing in a value of <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditFlags> for the `rgfQueryEdit` parameter. The project then needs to do the following:

    - If the `VSQueryEditResult` value returned in the `pfEditCanceled` parameter is <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResult.QER_EditOK>, then the upgrade can proceed because the project file can be written.

    - If the `VSQueryEditResult` value returned in the `pfEditCanceled` parameter is <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResult.QER_EditNotOK> and the `VSQueryEditResult` value has the <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResultFlags.QER_ReadOnlyNotUnderScc> bit set, then <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> must return failure, because users should resolve the permissions issue themselves. The project should then do the following:

         Report the error to the user by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsUIShell.ReportErrorInfo%2A> and return the <xref:Microsoft.VisualStudio.Shell.Interop.VSErrorCodes.VS_E_PROJECTMIGRATIONFAILED> error code to <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade>.

    - If the `VSQueryEditResult` value is <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResult.QER_EditNotOK> and the `VSQueryEditResultFlags` value has the <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResultFlags.QER_ReadOnlyUnderScc> bit set, then the project file should be checked out by calling <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> (<xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditFlags.QEF_ForceEdit_NoPrompting>, <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditFlags.QEF_DisallowInMemoryEdits>,...).

4. If the <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> call on the project file causes the file to be checked out, and the latest version to be retrieved, then the project is unloaded and reloaded. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> method is called again once another instance of the project is created. On this second call, the project file can be written to disk; it is recommended that the project save a copy of the project file in the previous format with an .OLD extension, make its necessary upgrade changes, and save the project file in the new format. Again, if any part of the upgrade process fails, the method must indicate failure by returning <xref:Microsoft.VisualStudio.Shell.Interop.VSErrorCodes.VS_E_PROJECTMIGRATIONFAILED>. This causes the project to be unloaded in Solution Explorer.

     It is important to understand the complete process that occurs in the environment for the case in which the call to the <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> method (specifying a value of ReportOnly) returns the <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResult.QER_EditNotOK> and the <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResultFlags.QER_ReadOnlyUnderScc> flags.

5. The user attempts to open the project file.

6. The environment calls your <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CanCreateProject%2A> implementation.

7. If <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CanCreateProject%2A> returns `true`, then the environment calls your <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectFactory.CanCreateProject%2A> implementation.

8. The environment calls your <xref:Microsoft.VisualStudio.Shell.Interop.IPersistFileFormat.Load%2A> implementation to open the file and initialize the project object, for example, Project1.

9. The environment calls your `IVsProjectUpgrade::UpgradeProject` implementation to determine whether the project file needs to be upgraded.

10. You call <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> and pass in a value of <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditFlags.QEF_ReportOnly> for the `rgfQueryEdit` parameter.

11. The environment returns <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResult.QER_EditNotOK> for `VSQueryEditResult` and the <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResultFlags.QER_ReadOnlyUnderScc> bit is set in `VSQueryEditResultFlags`.

12. Your <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade> implementation calls `IVsQueryEditQuerySave::QueryEditFiles` (<xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditFlags.QEF_ForceEdit_NoPrompting>, <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditFlags.QEF_DisallowInMemoryEdits>).

This call may cause a new copy of your project file to be checked out and the latest version retrieved, as well as a need to reload your project file. At this point, one of two things happen:

- If you handle your own project reload, then the environment calls your <xref:Microsoft.VisualStudio.Shell.Interop.IVsPersistHierarchyItem2.ReloadItem%2A> (VSITEMID_ROOT) implementation. When you receive this call, reload the first instance of your project (Project1) and continue upgrading your project file. The environment knows that you handle your own project reload if you return `true` for <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> (<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_HandlesOwnReload>).

- If you do not handle your own project reload, then you return `false` for <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.GetProperty%2A> (<xref:Microsoft.VisualStudio.Shell.Interop.__VSHPROPID.VSHPROPID_HandlesOwnReload>). In this case, before <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A>(QEF_ForceEdit_NoPrompting, QEF_DisallowInMemoryEdits) returns, the environment creates another new instance of your project, for example, Project2, as follows:

    1. The environment calls <xref:Microsoft.VisualStudio.Shell.Interop.IVsHierarchy.Close%2A> on your first project object, Project1, thus placing this object in the inactive state.

    2. The environment calls your `IVsProjectFactory::CreateProject` implementation to create a second instance of your project, Project2.

    3. The environment calls your `IPersistFileFormat::Load` implementation to open the file and initialize the second project object, Project2.

    4. The environment calls `IVsProjectUpgrade::UpgradeProject` for a second time to determine whether the project object should be upgraded. However, this call is made on a new, second, instance of the project, Project2. This is the project that is opened in the solution.

        > [!NOTE]
        > In the instance that your first project, Project1, is placed in the inactive state, then you must return <xref:Microsoft.VisualStudio.VSConstants.S_OK> from the first call to your <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgrade.UpgradeProject%2A> implementation.

    5. You call <xref:Microsoft.VisualStudio.Shell.Interop.IVsQueryEditQuerySave2.QueryEditFiles%2A> and pass in a value of <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditFlags.QEF_ReportOnly> for the `rgfQueryEdit` parameter.

    6. The environment returns <xref:Microsoft.VisualStudio.Shell.Interop.tagVSQueryEditResult.QER_EditOK> and the upgrade can proceed because the project file can be written.

If you fail to upgrade, return <xref:Microsoft.VisualStudio.Shell.Interop.VSErrorCodes.VS_E_PROJECTMIGRATIONFAILED> from `IVsProjectUpgrade::UpgradeProject`. If no upgrade is necessary or you choose not to upgrade, treat the `IVsProjectUpgrade::UpgradeProject` call as a no-op. If you return <xref:Microsoft.VisualStudio.Shell.Interop.VSErrorCodes.VS_E_PROJECTMIGRATIONFAILED>, a placeholder node is added to the solution for your project.

## Upgrading Project Items

If you add or manage items inside project systems you do not implement, you may need to participate in the project upgrade process. Crystal Reports is an example of an item that can be added to the project system.

Typically, project item implementers want to leverage an already fully instantiated and upgraded project because they need to know what the project references are and what other project properties are there to make an upgrade decision.

### To get the project upgrade notification

1. Set the <xref:Microsoft.VisualStudio.Shell.Interop.UIContextGuids80.SolutionOrProjectUpgrading> flag (defined in vsshell80.idl) in your project item implementation. This causes your project item VSPackage to auto load when the Visual Studio shell determines that a project system is in the process of upgrading.

2. Advise the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEventsProjectUpgrade> interface via the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolution2.AdviseSolutionEvents%2A> method.

3. The <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEventsProjectUpgrade> interface is fired after the project system implementation has completed its upgrade operations and the new upgraded project is created. Depending on the scenario, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEventsProjectUpgrade> interface is fired after the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterOpenSolution%2A>, the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterOpenProject%2A>, or the <xref:Microsoft.VisualStudio.Shell.Interop.IVsSolutionEvents3.OnAfterLoadProject%2A> methods.

### To upgrade the project item files

1. You must carefully manage the file backup process in your project item implementation. This applies in particular for a side-by-side backup, where the `fUpgradeFlag` parameter of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsProjectUpgradeViaFactory.UpgradeProject%2A> method is set to <xref:Microsoft.VisualStudio.Shell.Interop.__VSPPROJECTUPGRADEVIAFACTORYFLAGS.PUVFF_SXSBACKUP>, where files that had been backed up are placed along side files that are designated as ".old". The backed up files older than the system time when the project was upgraded can be designated as stale. Furthermore, they might be overwritten unless you take specific steps to prevent this.

2. At the time your project item gets a notification of the project upgrade, the **Visual Studio Conversion Wizard** is still displayed. Therefore, you should use the methods of the <xref:Microsoft.VisualStudio.Shell.Interop.IVsUpgradeLogger> interface to provide upgrade messages to the wizard UI.

## Related content

- [Projects](../../extensibility/internals/projects.md)
