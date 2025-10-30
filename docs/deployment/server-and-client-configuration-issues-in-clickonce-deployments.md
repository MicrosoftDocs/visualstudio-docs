---
title: "Server/client configuration issues (ClickOnce)"
description: Review possible issues with the server and client configuration that can affect the deployment of your ClickOnce application.
ms.date: "11/04/2016"
ms.topic: article
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "deploying applications, ClickOnce"
  - "troubleshooting ClickOnce deployments"
  - "ClickOnce deployment, troubleshooting"
  - "Windows applications, ClickOnce deployments"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Server and client configuration issues in ClickOnce deployments

If you use Internet Information Services (IIS) on Windows Server, and your deployment contains a file type that Windows doesn't recognize, such as a Microsoft Word file, IIS will refuse to transmit that file, and your deployment won't succeed.

 Additionally, some Web servers and Web application software, such as ASP.NET, contain a list of files and file types that you can't download. For example, ASP.NET prevents the download of all *Web.config* files. These files may contain sensitive information such as user names and passwords.

 Although this restriction should cause no problems for downloading core ClickOnce files such as manifests and assemblies, this restriction may prevent you from downloading data files included as part of your ClickOnce application. In ASP.NET, you can resolve this error by removing the handler that prohibits downloading of such files from the IIS configuration manager. See the IIS server documentation for additional details.

 Some Web servers might block files with extensions such as *.dll*, *.config*, and *.mdf*. Windows-based applications typically include files with some of these extensions. If a user attempts to run a ClickOnce application that accesses a blocked file on a Web server, an error will result. Rather than unblocking all file extensions, ClickOnce publishes every application file with a *.deploy* file extension by default. Therefore, the administrator only needs to configure the Web server to unblock the following three file extensions:

- *.application*

- *.manifest*

- *.deploy*

  However, you can disable this option by clearing the **Use ".deploy" file extension** option on the [Publish Options Dialog Box](/previous-versions/visualstudio/visual-studio-2010/7z83t16a(v=vs.100)), in which case you must configure the Web server to unblock all file extensions used in the application.

 You'll have to configure *.manifest*, *.application*, and *.deploy*, for example, if you're using IIS where you haven't installed the .NET Framework, or if you're using another Web server (for example, Apache).

## ClickOnce and Secure Sockets Layer (SSL)
 A ClickOnce application will work fine over SSL, except when the browser raises a prompt about the SSL certificate. The prompt can be raised when there's something wrong with the certificate, such as when the site names do not match or the certificate has expired. To make ClickOnce work over an SSL connection, make sure that the certificate is up-to-date, and that the certificate data matches the site data.

## ClickOnce and proxy authentication
 ClickOnce provides support for Windows Integrated proxy authentication starting in .NET Framework 3.5. No specific machine.config directives are required. ClickOnce doesn't provide support for other authentication protocols such as Basic or Digest.

 You can also apply a hotfix to .NET Framework 2.0 to enable this feature. For more information, see [FIX: Error message when you try to install a ClickOnce application that you created in the .NET Framework 2.0 onto a client computer that is configured to use a proxy server: "Proxy authentication required"](https://support.microsoft.com/help/917952/fix-error-message-when-you-try-to-install-a-clickonce-application-that).

 For more information, see [\<defaultProxy> element (network settings)](/dotnet/framework/configure-apps/file-schema/network/defaultproxy-element-network-settings).

## ClickOnce and Web browser compatibility
 Currently, ClickOnce installations will launch only if the URL to the deployment manifest is opened using the browser. A deployment whose URL is launched from another application, such as Microsoft Office Outlook, will launch successfully only if Internet Explorer is set as the default Web browser.

> [!NOTE]
> Mozilla Firefox is supported if the deployment provider isn't blank or the Microsoft .NET Framework Assistant extension is installed. This extension is packaged with .NET Framework 3.5 SP1. For XBAP support, the NPWPF plug-in is activated when needed.

## Activate ClickOnce applications through browser scripting
 If you have developed a custom Web page that launches a ClickOnce application using Active Scripting, you may find that the application won't launch on some machines. The browser contains a setting such as **Automatic prompting for file downloads**, which affects this behavior. This browser setting is typically listed underneath the **Downloads** category, and is enabled by default. When this setting is disabled, any attempt to activate a ClickOnce application programmatically (for example, by assigning its URL to the `document.location` property) will be blocked. Under this circumstance, users can launch applications only through a user-initiated download, for example, by clicking a hyperlink set to the application's URL.

## Additional server configuration issues

##### Administrator permissions required
 You must have Administrator permissions on the target server if you're publishing with HTTP. IIS requires this permissions level. If you're not publishing using HTTP, you only need write permission on the target path.

##### Server authentication issues
 When you publish to a remote server that has "Anonymous Access" turned off, you'll receive the following warning:

```
"The files could not be downloaded from http://<remoteserver>/<myapplication>/.  The remote server returned an error: (401) Unauthorized."
```

> [!NOTE]
> You can make NTLM (NT challenge-response) authentication work if the site prompts for credentials other than your default credentials, and, in the security dialog box, you click **OK** when you're prompted if you want to save the supplied credentials for future sessions. However, this workaround won't work for basic authentication.

## Use third-party Web servers
 If you're deploying a ClickOnce application from a Web server other than IIS, you may experience a problem if the server is returning the incorrect content type for key ClickOnce files, such as the deployment manifest and application manifest. To resolve this problem, see your Web server's Help documentation about how to add new content types to the server, and make sure that all the file name extension mappings listed in the following table are in place.

|File name extension|Content type|
|-------------------------|------------------|
|`.application`|`application/x-ms-application`|
|`.manifest`|`application/x-ms-manifest`|
|`.deploy`|`application/octet-stream`|
|`.msu`|`application/octet-stream`|
|`.msp`|`application/octet-stream`|

## ClickOnce and mapped drives
 If you use Visual Studio to publish a ClickOnce application, you can't specify a mapped drive as the installation location. However, you can modify the ClickOnce application to install from a mapped drive by using the Manifest Generator and Editor (Mage.exe and MageUI.exe). For more information, see [Mage.exe (Manifest Generation and Editing Tool)](/dotnet/framework/tools/mage-exe-manifest-generation-and-editing-tool) and [MageUI.exe (Manifest Generation and Editing Tool, Graphical Client)](/dotnet/framework/tools/mageui-exe-manifest-generation-and-editing-tool-graphical-client).

## FTP protocol not supported for installing applications
 ClickOnce supports installing applications from any HTTP 1.1 Web server or file server. FTP, the File Transfer Protocol, isn't supported for installing applications. You can use FTP to publish applications only. The following table summarizes these differences:

| URL Type | Description |
|----------| - |
| ftp:// | You can publish a ClickOnce application by using this protocol. |
| http:// | You can install a ClickOnce application by using this protocol. |
| https:// | You can install a ClickOnce application by using this protocol. |
| file:// | You can install a ClickOnce application by using this protocol. |

## Windows Firewall
 By default, Windows enables the Windows Firewall. If you're developing your application on a computer that has Windows installed, you're still able to publish and run ClickOnce applications from the local server that is running IIS. However, you can't access that server that is running IIS from another computer unless you open the Windows Firewall. See Windows Help for instructions on managing the Windows Firewall.

## Windows Server: Enable FrontPage server extensions
 FrontPage Server Extensions from Microsoft is required for publishing applications to a Windows Web server that uses HTTP.

 By default, Windows Server doesn't have FrontPage Server Extensions installed. If you want to use Visual Studio to publish to a Windows Server Web server that uses HTTP with FrontPage Server Extensions, you must install FrontPage Server Extensions first. You can perform the installation by using the Manage Your Server administration tool in Windows Server.

## Windows Server: Locked-down content types
 IIS on Windows Server 2003 locks down all file types except for certain known content types (for example, *.htm*, *.html*, *.txt*, and so on). To enable deployment of ClickOnce applications using this server, you need to change the IIS settings to allow downloading files of type *.application*, *.manifest*, and any other custom file types used by your application.

 If you deploy using an IIS server, run *inetmgr.exe* and add new File Types for the default Web page:

- For the *.application* and *.manifest* extensions, the MIME type should be "application/x-ms-application." For other file types, the MIME type should be "application/octet-stream."

- If you create a MIME type with extension "\<em>" and the MIME type "application/octet-stream," it will allow files of unblocked file type to be downloaded. (However, blocked file types such as *\*.aspx* and *\*.asmx* can't be downloaded.)

  For specific instructions on configuring MIME types on Windows Server, see [How to add a MIME type to a Web site or application](/iis/configuration/system.webserver/staticcontent/mimemap#how-to-add-a-mime-type-to-a-web-site-or-application).

## Content type mappings
 When publishing over HTTP, the content type (also known as MIME type) for the *.application* file should be "application/x-ms-application." If you have .NET Framework 2.0 installed on the server, this will be set for you automatically. If this isn't installed, then you need to create a MIME type association for the ClickOnce application vroot (or entire server).

 If you deploy using an IIS server, run <em>inetmgr.</em>exe and add a new content type of "application/x-ms-application" for the *.application* extension.

## HTTP compression issues
 With ClickOnce, you can perform downloads that use HTTP compression, a Web server technology that uses the GZIP algorithm to compress a data stream before sending the stream to the client. The client—in this case, ClickOnce—decompresses the stream before reading the files.

 If you're using IIS, you can easily enable HTTP compression. However, when you enable HTTP compression, it is only enabled for certain file types—namely, HTML and text files. To enable compression for assemblies (*.dll*), XML (*.xml*), deployment manifests (*.application*), and application manifests (*.manifest*), you must add these file types to the list of types for IIS to compress. Until you add the file types to your deployment, only text and HTML files will be compressed.

 For detailed instructions for IIS, see [How to specify additional document types for HTTP compression](/troubleshoot/iis/content-types-http-compression).

## Related content
- [Troubleshoot ClickOnce deployments](../deployment/troubleshooting-clickonce-deployments.md)
- [Choose a ClickOnce deployment strategy](../deployment/choosing-a-clickonce-deployment-strategy.md)
- [Application deployment prerequisites](../deployment/application-deployment-prerequisites.md)
