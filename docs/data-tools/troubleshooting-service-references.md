---
title: Troubleshooting Service References
ms.date: 11/04/2016
ms.topic: troubleshooting
f1_keywords:
  - "msvse_wcf.Err.ReferenceGroup_NamespaceConflictsOther"
  - "msvse_wcf.Err.AddSvcRefDlg_NothingSelectedOnGo"
  - "msvse_wcf.Err.ErrorOnOK"
  - "msvse_wcf.cfg.ConfigurationErrorsException"
helpviewer_keywords:
  - "service references [Visual Studio], troubleshooting"
  - "WCF services, troubleshooting"
ms.assetid: 3b531120-1325-4734-90c6-6e6113bd12ac
author: jillre
ms.author: jillfra
manager: jillfra
ms.workload:
  - "data-storage"
---
# Troubleshoot service references

This topic lists common issues that may occur when you are working with Windows Communication Foundation (WCF) or WCF Data Services references in Visual Studio.

## Error returning data from a service

When you return a `DataSet` or `DataTable` from a service, you may receive a "The maximum size quota for incoming messages has been exceeded" exception. By default, the `MaxReceivedMessageSize` property for some bindings is set to a relatively small value to limit exposure to denial-of-service attacks. You can increase this value to prevent the exception. For more information, see <xref:System.ServiceModel.HttpBindingBase.MaxReceivedMessageSize%2A>.

To fix this error:

1. In **Solution Explorer**, double-click the *app.config* file to open it.

2. Locate the `MaxReceivedMessageSize` property and change it to a larger value.

## Cannot find a service in my solution

When you click the **Discover** button in the **Add Service References** dialog box, one or more WCF Service Library projects in the solution do not appear in the services list. This can occur if a Service Library has been added to the solution but has not yet been compiled.

To fix this error:

- In **Solution Explorer**, right-click the WCF Service Library project and click **Build**.

## Error accessing a service over a remote desktop

When a user accesses a Web-hosted WCF service over a remote desktop connection and the user does not have administrative permissions, NTLM authentication is used. If the user does not have administrative permissions, the user may receive the following error message: "The HTTP request is unauthorized with client authentication scheme 'Anonymous'. The authentication header received from the server was 'NTLM'."

To fix this error:

1. In the website project, open the **Properties** pages.

2. On the **Start Options** tab, clear the **NTLM Authentication** check box.

    > [!NOTE]
    > You should turn off NTLM authentication only for websites that exclusively contain WCF services. Security for WCF services is managed through the configuration in the *web.config* file. This makes NTLM authentication unnecessary.

## Access level for generated classes setting has no effect

Setting the **Access level for generated classes** option in the **Configure Service References** dialog box to **Internal** or **Friend** may not always work. Even though the option appears to be set in the dialog box, the resulting support classes are generated with an access level of `Public`.

This is a known limitation of certain types, such as those serialized using the <xref:System.Xml.Serialization.XmlSerializer>.

## Error debugging service code

When you step into the code for a WCF service from client code, you may receive an error related to missing symbols. This can occur when a service that was part of your solution was moved or removed from the solution.

When you first add a reference to a WCF service that is part of the current solution, an explicit build dependency is added between the service project and the service client project. This guarantees that the client always accesses up-to-date service binaries, which is especially important for debugging scenarios such as stepping from client code into service code.

If the service project is removed from the solution, this explicit build dependency is invalidated. Visual Studio can no longer guarantee that the service project is rebuilt as necessary.

To fix this error, you have to manually rebuild the service project:

1. On the **Tools** menu, click **Options**.

2. In the **Options** dialog box, expand **Projects and Solutions**, and then select **General**.

3. Make sure that the **Show advanced build configurations** check box is selected, and then click **OK**.

4. Load the WCF service project.

5. In the **Configuration Manager** dialog box, set the **Active solution configuration** to **Debug**. For more information, see [How to: Create and edit configurations](../ide/how-to-create-and-edit-configurations.md).

6. In **Solution Explorer**, select the WCF service project.

7. On the **Build** menu, click **Rebuild** to rebuild the WCF service project.

## WCF Data Services do not display in the browser

When it attempts to view an XML representation of data in a [!INCLUDE[ss_data_service](../data-tools/includes/ss_data_service_md.md)], Internet Explorer may misinterpret the data as an RSS feed. Make sure that the option to display RSS feeds is disabled.

To fix this error, disable RSS feeds:

1. In Internet Explorer, on the **Tools** menu, click **Internet Options**.

2. On the **Content** tab, in the **Feeds** section, click **Settings**.

3. In the **Feed Settings** dialog box, clear the **Turn on feed reading view** check box, and then click **OK**.

4. Click **OK** to close the **Internet Options** dialog box.

## See also

- [Windows Communication Foundation Services and WCF Data Services in Visual Studio](../data-tools/windows-communication-foundation-services-and-wcf-data-services-in-visual-studio.md)