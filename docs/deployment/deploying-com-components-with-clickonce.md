---
title: "Deploying COM Components with ClickOnce"
description: Learn about steps necessary to deploy .NET applications in ClickOnce that contain legacy COM components.
ms.date: "11/04/2016"
ms.topic: install-set-up-deploy
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "registration-free COM deployment"
  - "ClickOnce deployment, COM components"
  - "COM components, deploying"
  - "deploying applications [ClickOnce], COM components"
  - "components, deploying"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Deploy COM components with ClickOnce

Deployment of legacy COM components has traditionally been a difficult task. Components need to be globally registered and thus can cause undesirable side effects between overlapping applications. This situation is generally not a problem in .NET Framework applications because components are completely isolated to an application or are side-by-side compatible. Visual Studio allows you to deploy isolated COM components on the Windows operating system.

 ClickOnce provides an easy and safe mechanism for deploying your .NET applications. However, if your applications use legacy COM components, you will need to take additional steps for deploying them. This topic describes how to deploy isolated COM components and reference native components (for example, from Visual Basic 6.0 or Visual C++).

 For more information on deploying isolated COM components, see [Simplify App Deployment with ClickOnce and Registration-Free COM](https://web.archive.org/web/20050326005413/msdn.microsoft.com/msdnmag/issues/05/04/RegFreeCOM/default.aspx).

## Registration-free COM
 Registration-free COM is a new technology for deploying and activating isolated COM components. It works by putting all the component's type-library and registration information that is typically installed into the system registry into an XML file called a manifest, stored in the same folder as the application.

 Isolating a COM component requires that it be registered on the developer's machine, but it does not have to be registered on the end user's computer. To isolate a COM component, all you need to do is set its reference's **Isolated** property to **True**. By default, this property is set to **False**, indicating that it should be treated as a registered COM reference. If this property is **True**, it causes a manifest to be generated for this component at build time. It also causes the corresponding files to be copied to the application folder during installation.

 When the manifest generator encounters an isolated COM reference, it enumerates all of the `CoClass` entries in the component's type library, matching each entry with its corresponding registration data, and generating manifest definitions for all the COM classes in the type library file.

## Deploy registration-free COM components using ClickOnce
 ClickOnce deployment technology is well-suited for deploying isolated COM components, because both ClickOnce and registration-free COM require that a component have a manifest in order to be deployed.

 Typically, the author of the component should provide a manifest. If not, however, Visual Studio is capable of generating a manifest automatically for a COM component. The manifest generation is performed during the ClickOnce Publish process; for more information, see [Publishing ClickOnce Applications](../deployment/publishing-clickonce-applications.md). This feature also allows you to leverage legacy components that you authored in earlier development environments such as Visual Basic 6.0.

 There are two ways that ClickOnce deploys COM components:

- Use the bootstrapper to deploy your COM components; this works on all supported platforms.

- Use native component isolation (also known as registration-free COM) deployment.

### Example of isolating and deploying a simple COM component
 In order to demonstrate registration-free COM component deployment, this example will create a Windows-based application in Visual Basic that references an isolated native COM component created using Visual Basic 6.0, and deploy it using ClickOnce.

 First you will need to create the native COM component:

##### To create a native COM component

1. Using Visual Basic 6.0, from the **File** menu, click **New**, then **Project**.

2. In the **New Project** dialog box, select the **Visual Basic** node and select an **ActiveX DLL** project. In the **Name** box, type `VB6Hello`.

    > [!NOTE]
    > Only ActiveX DLL and ActiveX Control project types are supported with registration-free COM; ActiveX EXE and ActiveX Document project types are not supported.

3. In **Solution Explorer**, double-click **Class1.vb** to open the text editor.

4. In Class1.vb, add the following code after the generated code for the `New` method:

    ```vb
    Public Sub SayHello()
       MsgBox "Message from the VB6Hello COM component"
    End Sub
    ```

5. Build the component. From the **Build** menu, click **Build Solution**.

> [!NOTE]
> Registration-free COM supports only DLLs and COM controls project types. You cannot use EXEs with registration-free COM.

 Now you can create a Windows-based application and add a reference to the COM component to it.

##### To create a Windows-based application using a COM component

1. Using Visual Basic, from the **File** menu, click **New**, then **Project**.

2. In the **New Project** dialog box, select the **Visual Basic** node and select **Windows Application**. In the **Name** box, type `RegFreeComDemo`.

3. In **Solution Explorer**, click the **Show All Files** button to display the project references.

4. Right-click the **References** node and select **Add Reference** from the context menu.

5. In the **Add Reference** dialog box, click the **Browse** tab, navigate to VB6Hello.dll, then select it.

    A **VB6Hello** reference appears in the references list.

6. Point to the **Toolbox**, select a **Button** control, and drag it to the **Form1** form.

7. In the **Properties** window, set the button's **Text** property to **Hello**.

8. Double-click the button to add handler code, and in the code file, add code so that the handler reads as follows:

   ```vb
   Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
       Dim VbObj As New VB6Hello.Class1
       VbObj.SayHello()
   End Sub
   ```

9. Run the application. From the **Debug** menu, click **Start Debugging**.

   Next you need to isolate the control. Each COM component that your application uses is represented in your project as a COM reference. These references are visible under the **References** node in the **Solution Explorer** window. (Notice that you can add references either directly using the **Add Reference** command on the **Project** menu, or indirectly by dragging an ActiveX control onto your form.)

   The following steps show how to isolate the COM component and publish the updated application containing the isolated control:

##### To isolate a COM component

1. In **Solution Explorer**, in the **References** node, select the **VB6Hello** reference.

2. In the **Properties** window, change the value of the **Isolated** property from **False** to **True**.

3. From the **Build** menu, click **Build Solution**.

   Now, when you press F5, the application works as expected, but it is now running under registration-free COM. In order to prove this, try unregistering the VB6Hello.dll component and running RegFreeComDemo1.exe outside of the Visual Studio IDE. This time when the button is clicked, it still works. If you temporarily rename the application manifest, it will again fail.

> [!NOTE]
> You can simulate the absence of a COM component by temporarily unregistering it. Open a command prompt, go to your system folder by typing `cd /d %windir%\system32`, then unregister the component by typing `regsvr32 /u VB6Hello.dll`. You can register it again by typing `regsvr32 VB6Hello.dll`.

 The final step is to publish the application using ClickOnce:

##### To publish an application update with an isolated COM component

1. From the **Build** menu, click **Publish RegFreeComDemo**.

    The Publish Wizard appears.

2. In the Publish Wizard, specify a location on the local computer's disk where you can access and examine the published files.

3. Click **Finish** to publish the application.

   If you examine the published files, you will note that the sysmon.ocx file is included. The control is totally isolated to this application, meaning that if the end user's machine has another application using a different version of the control, it cannot interfere with this application.

## Reference native assemblies
 Visual Studio supports references to native Visual Basic 6.0 or C++ assemblies; such references are called native references. You can tell whether a reference is native by verifying that its **File Type** property is set to **Native** or **ActiveX**.

 To add a native reference, use the **Add Reference** command, then browse to the manifest. Some components place the manifest inside the DLL. In this case, you can simply choose the DLL itself and Visual Studio will add it as a native reference if it detects that the component contains an embedded manifest. Visual Studio will also automatically include any dependent files or assemblies listed in the manifest if they are in the same folder as the referenced component.

 COM control isolation makes it easy to deploy COM components that do not already have manifests. However, if a component is supplied with a manifest, you can reference the manifest directly. In fact, you should always use the manifest supplied by the author of the component wherever possible rather than using the **Isolated** property.

## Limitations of registration-free COM component deployment
 Registration-free COM provides clear advantages over traditional deployment techniques.

 Not every component is a suitable candidate for registration-free COM. A component is not a suitable if any of the following are true:

- The component is an out-of-process server. EXE servers are not supported; only DLLs are supported.

- The component is part of the operating system, or is a system component, such as XML, a browser component, or Microsoft Data Access Components (MDAC). You should follow the redistribution policy of the component author; check with your vendor.

- The component is part of an application, such as Microsoft Office. For example, you should not attempt to isolate Microsoft Excel Object Model. This is part of Office and can only be used on a computer with the full Office product installed.

- The component is intended for use as an add-in or a snap-in, for example an Office add-in or a control in a Web browser. Such components typically require some kind of registration scheme defined by the hosting environment that is beyond the scope of the manifest itself.

- The component manages a physical or virtual device for the system, for example, a device driver for a print spooler.

- The component is a Data Access redistributable. Data applications generally require a separate Data Access redistributable to be installed before they can run. You should not attempt to isolate components such as the Microsoft ADO Data Control, Microsoft OLE DB, or Microsoft Data Access Components (MDAC). Instead, if your application uses MDAC or SQL Server Express, you should set them as prerequisites; see [How to: Install Prerequisites with a ClickOnce Application](../deployment/how-to-install-prerequisites-with-a-clickonce-application.md).

  In some cases, it may be possible for the developer of the component to redesign it for registration-free COM. If this is not possible, you can still build and publish applications that depend on them through the standard registration scheme using the Bootstrapper. For more information, see [Creating Bootstrapper Packages](../deployment/creating-bootstrapper-packages.md).

  A COM component can only be isolated once per application. For example, you can't isolate the same COM component from two different **Class Library** projects that are part of the same application. Doing so will result in a build warning, and the application will fail to load at run time. In order to avoid this problem, Microsoft recommends that you encapsulate COM components in a single class library.

  There are several scenarios in which COM registration is required on the developer's machine, even though the application's deployment does not require registration. The `Isolated` property requires that the COM component be registered on the developer's machine in order to auto-generate the manifest during the build. There are no registration-capturing capabilities that invoke the self-registration during the build. Also, any classes not explicitly defined in the type library will not be reflected in the manifest. When using a COM component with a pre-existing manifest, such as a native reference, the component may not need to be registered at development time. However, registration is required if the component is an ActiveX control and you want to include it in the **Toolbox** and the Windows Forms designer.

## Related content
- [ClickOnce security and deployment](../deployment/clickonce-security-and-deployment.md)
