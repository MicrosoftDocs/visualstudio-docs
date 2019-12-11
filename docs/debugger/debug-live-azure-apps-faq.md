---
title: "FAQ for snapshot debugging | Microsoft Docs"
ms.date: "11/07/2017"
ms.topic: "reference"
helpviewer_keywords:
  - "debugger"
ms.assetid: 944f1eb0-a74b-4d28-ae2b-a370cd869add
author: "mikejo5000"
ms.author: "mikejo"
manager: jillfra
ms.workload:
  - "multiple"
---
# Frequently Asked Questions for snapshot debugging in Visual Studio

Here is a list of questions that might come up when debugging live Azure applications using the Snapshot Debugger.

#### What is the performance cost of taking a snapshot?

When the Snapshot Debugger captures a snapshot of your app, it forks the app's process and suspends the forked copy. When you debug a snapshot, you're debugging against the forked copy of the process. This process takes only 10-20 milliseconds but doesn't copy the full heap of the app. Instead, it copies only the page table and sets pages to copy on write. If some of your app's objects on the heap change, their respective pages are then copied. That's whey each snapshot has a small in-memory cost (on the order of hundreds of kilobytes for most apps).

#### What happens if I have a scaled-out Azure App Service (multiple instances of my app)?

When you have multiple instances of your app, snappoints get applied to every single instance. Only the first snappoint to hit with the conditions specified creates a snapshot. If you have multiple snappoints, later snapshots come from the same instance that created the first snapshot. Logpoints sent to the output window will only show messages from one instance, while logpoints sent to application logs send messages from every instance.

#### How does the Snapshot Debugger load symbols?

The Snapshot Debugger requires that you have the matching symbols for your application either local or deployed to your Azure App Service. (Embedded PDBs are currently not supported.) The Snapshot Debugger automatically downloads symbols from your Azure App Service. Starting with Visual Studio 2017 version 15.2, deploying to Azure App Service also deploys your app's symbols.

#### Does the Snapshot Debugger work against release builds of my application?

Yes - the Snapshot Debugger is intended to work against release builds. When a snappoint is placed in a function, the function is recompiled back to a debug version, making it debuggable. Stopping the Snapshot Debugger returns functions to the version of the release build.

#### Can logpoints cause side effects in my production application?

No - any log messages you add to your app are evaluated virtually. They can't cause any side effects in your application. However, some native properties may not be accessible with logpoints.

#### Does the Snapshot Debugger work if my server is under load?

Yes, snapshot debugging can work for servers under load. The Snapshot Debugger throttles and doesn't capture snapshots in situations where there's a low amount of free memory on your server.

#### How do I uninstall the Snapshot Debugger?

You can uninstall the Snapshot Debugger site extension on your App Service with the following steps:

1. Turn off your App Service either through the Cloud Explorer in Visual Studio or the Azure portal.
1. Navigate to your App Service's Kudu site (that is, yourappservice.**scm**.azurewebsites.net) and navigate to **Site extensions**.
1. Click the X on the Snapshot Debugger site extension to remove it.

#### Why are ports opened during a Snapshot Debugger session?

Snapshot Debugger needs to open a set of ports in order to debug the snapshots taken in Azure, these are the same ports required for remote debugging. [You can find the list of ports here](../debugger/remote-debugger-port-assignments.md).

#### How do I disable the Remote Debugger extension?

For App Services:
1. Disable Remote Debugger extension via the Azure portal for your App Service.
2. Azure portal > your Application Service resource blade > *Application Settings*
3. Navigate to the *Debugging* section and click the *Off* button for *Remote debugging*.

For AKS:
1. Update your Dockerfile to remove the sections corresponding to the [Visual Studio Snapshot Debugger on Docker images](https://github.com/Microsoft/vssnapshotdebugger-docker).
2. Rebuild and redeploy the modified Docker image.

For virtual machine/virtual machine scale sets remove the Remote Debugger extension, Certificates, KeyVaults and InBound NAT pools as follows:

1. Remove Remote Debugger extension

   There are several ways to disable the Remote Debugger for virtual machines and virtual machine scale sets:

      - Disable the Remote Debugger through Cloud Explorer

         - Cloud Explorer > your virtual machine resource > Disable Debugging (Disabling Debugging does not exist for virtual machine scale set on Cloud Explorer).

      - Disable the Remote Debugger with PowerShell Scripts/Cmdlets

         For virtual machine:

         ```powershell
         Remove-AzVMExtension -ResourceGroupName $rgName -VMName $vmName -Name Microsoft.VisualStudio.Azure.RemoteDebug.VSRemoteDebugger
         ```

         For virtual machine scale sets:

         ```powershell
         $vmss = Get-AzVmss -ResourceGroupName $rgName -VMScaleSetName $vmssName
         $extension = $vmss.VirtualMachineProfile.ExtensionProfile.Extensions | Where {$_.Name.StartsWith('VsDebuggerService')} | Select -ExpandProperty Name
         Remove-AzVmssExtension -VirtualMachineScaleSet $vmss -Name $extension
         ```

      - Disable the Remote Debugger through the Azure portal
         - Azure portal > your virtual machine/virtual machine scale sets resource blade > Extensions
         - Uninstall Microsoft.VisualStudio.Azure.RemoteDebug.VSRemoteDebugger extension

         > [!NOTE]
         > Virtual machine scale sets - The portal does not allow removing the DebuggerListener ports. You will need to use Azure PowerShell. See below for details.

2. Remove Certificates and Azure KeyVault

   When installing the Remote Debugger extension for virtual machine or virtual machine scale sets, both client and server certificates are created to authenticate the VS client with the Azure Virtual Machine/virtual machine scale sets resources.

   - The Client Cert

      This cert is a self-signed certificate located in Cert:/CurrentUser/My/

      ```
      Thumbprint                                Subject
      ----------                                -------

      1234123412341234123412341234123412341234  CN=ResourceName
      ```

      One way to remove this certificate from your machine is via PowerShell

      ```powershell
      $ResourceName = 'ResourceName' # from above
      Get-ChildItem -Path Cert:\CurrentUser\My | Where-Object {$_.Subject -match $ResourceName} | Remove-Item
      ```

   - The Server Certificate
      - The corresponding server certificate thumbprint is deployed as a secret to Azure KeyVault. VS will attempt to find or create a KeyVault with prefix MSVSAZ* in the region corresponding to the virtual machine or virtual machine scale sets resource. All virtual machine or virtual machine scale sets resources deployed to that region therefore will share the same KeyVault.
      - To delete the server certificate thumbprint secret, go to the Azure portal and find the MSVSAZ* KeyVault in the same region that's hosting your resource. Delete the secret which should be labeled `remotedebugcert<<ResourceName>>`
      - You will also need to delete the server secret from your resource via PowerShell.

      For virtual machines:

      ```powershell
      $vm.OSProfile.Secrets[0].VaultCertificates.Clear()
      Update-AzVM -ResourceGroupName $rgName -VM $vm
      ```

      For virtual machine scale sets:

      ```powershell
      $vmss.VirtualMachineProfile.OsProfile.Secrets[0].VaultCertificates.Clear()
      Update-AzVmss -ResourceGroupName $rgName -VMScaleSetName $vmssName -VirtualMachineScaleSet $vmss
      ```

3. Remove all DebuggerListener InBound NAT pools (virtual machine scale set only)

   The Remote Debugger introduces DebuggerListener in-bound NAT pools that are applied to your scaleset's load balancer.

   ```powershell
   $inboundNatPools = $vmss.VirtualMachineProfile.NetworkProfile.NetworkInterfaceConfigurations.IpConfigurations.LoadBalancerInboundNatPools
   $inboundNatPools.RemoveAll({ param($pool) $pool.Id.Contains('inboundNatPools/DebuggerListenerNatPool-') }) | Out-Null

   if ($LoadBalancerName)
   {
      $lb = Get-AzLoadBalancer -ResourceGroupName $ResourceGroup -name $LoadBalancerName
      $lb.FrontendIpConfigurations[0].InboundNatPools.RemoveAll({ param($pool) $pool.Id.Contains('inboundNatPools/DebuggerListenerNatPool-') }) | Out-Null
      Set-AzLoadBalancer -LoadBalancer $lb
   }
   ```

#### How do I disable Snapshot Debugger?

For App Service:
1. Disable Snapshot Debugger via the Azure portal for your App Service.
2. Azure portal > your Application Service resource blade > *Application Settings*
3. Delete the following App settings in the Azure portal and save your changes.
   - INSTRUMENTATIONENGINE_EXTENSION_VERSION
   - SNAPSHOTDEBUGGER_EXTENSION_VERSION

   > [!WARNING]
   > Any changes to Application Settings will initiate an app restart. For more information about Application Settings, see [Configure an App Service app in the Azure portal](/azure/app-service/web-sites-configure).

For AKS:
1. Update your Dockerfile to remove the sections corresponding to the [Visual Studio Snapshot Debugger on Docker images](https://github.com/Microsoft/vssnapshotdebugger-docker).
2. Rebuild and redeploy the modified Docker image.

For virtual machine/virtual machine scale sets:

There are several ways to disable the Snapshot Debugger:
- Cloud Explorer > your virtual machine/virtual machine scale set resource > Disable Diagnostics

- Azure portal > your virtual machine/virtual machine scale set resource blade > Extensions > Uninstall Microsoft.Insights.VMDiagnosticsSettings extension

- PowerShell Cmdlets from [Az PowerShell](/powershell/azure/overview)

   Virtual machine:

   ```powershell
      Remove-AzVMExtension -ResourceGroupName $rgName -VMName $vmName -Name Microsoft.Insights.VMDiagnosticsSettings
   ```

   Virtual machine scale sets:

   ```powershell
      $vmss = Get-AzVmss -ResourceGroupName $rgName -VMScaleSetName $vmssName
      Remove-AzVmssExtension -VirtualMachineScaleSet $vmss -Name Microsoft.Insights.VMDiagnosticsSettings
   ```

## See also

- [Debugging in Visual Studio](../debugger/index.yml)
- [Debug live ASP.NET apps using the Snapshot Debugger](../debugger/debug-live-azure-applications.md)
- [Debug live ASP.NET Azure Virtual Machines\Virtual Machines scale sets using the Snapshot Debugger](../debugger/debug-live-azure-virtual-machines.md)
- [Debug live ASP.NET Azure Kubernetes using the Snapshot Debugger](../debugger/debug-live-azure-kubernetes.md)
- [Troubleshooting and known issues for snapshot debugging](../debugger/debug-live-azure-apps-troubleshooting.md)
