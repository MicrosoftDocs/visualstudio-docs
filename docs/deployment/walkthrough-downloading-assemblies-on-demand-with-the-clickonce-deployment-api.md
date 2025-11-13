---
title: "Download assemblies on demand (ClickOnce API)"
description: Learn how to mark certain assemblies in your ClickOnce application as optional and download them when the common language runtime needs them.
ms.date: "11/04/2016"
ms.topic: how-to
dev_langs:
  - "VB"
  - "CSharp"
  - "C++"
helpviewer_keywords:
  - "assemblies, downloading [ClickOnce]"
  - "ClickOnce deployment, on-demand download"
  - "on-demand assemblies, ClickOnce"
author: mikejo5000
ms.author: mikejo
manager: mijacobs
ms.subservice: deployment
---
# Walkthrough: Download assemblies on demand with the ClickOnce deployment API

By default, all of the assemblies included in a ClickOnce application are downloaded when the application is first run. However, you may have parts of your application that are used by a small set of your users. In this case, you want to download an assembly only when you create one of its types. The following walkthrough demonstrates how to mark certain assemblies in your application as "optional", and how to download them by using classes in the <xref:System.Deployment.Application> namespace when the common language runtime (CLR) demands them.

 [!INCLUDE[ndptecclick](../deployment/includes/dotnet-support-application-deployment-api.md)]

> [!NOTE]
> Your application will have to run in full trust to use this procedure.

## Prerequisites
 You will need one of the following components to complete this walkthrough:

- The Windows SDK. The Windows SDK can be downloaded from the Microsoft Download Center.

- Visual Studio.

## Create the projects

#### To create a project that uses an on-demand assembly

1. Create a directory named ClickOnceOnDemand.

2. Open the Windows SDK Command Prompt or the Visual Studio Command Prompt.

3. Change to the ClickOnceOnDemand directory.

4. Generate a public/private key pair using the following command:

   ```cmd
   sn -k TestKey.snk
   ```

5. Using Notepad or another text editor, define a class named `DynamicClass` with a single property named `Message`.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../snippets/csharp/VS_Snippets_Winforms/ClickOnceLibrary/CS/Class1.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../snippets/visualbasic/VS_Snippets_Winforms/ClickOnceLibrary/VB/Class1.vb" id="Snippet1":::
    ---

6. Save the text as a file named *ClickOnceLibrary.cs* or *ClickOnceLibrary.vb*, depending on the language you use, to the *ClickOnceOnDemand* directory.

7. Compile the file into an assembly.

   ### [C#](#tab/csharp)
   ```csharp
   csc /target:library /keyfile:TestKey.snk ClickOnceLibrary.cs
   ```

   ### [VB](#tab/vb)
   ```vb
   vbc /target:library /keyfile:TestKey.snk ClickOnceLibrary.vb
   ```
   ---

8. To get the public key token for the assembly, use the following command:

   ```cmd
   sn -T ClickOnceLibrary.dll
   ```

9. Create a new file using your text editor and enter the following code. This code creates a Windows Forms application that downloads the ClickOnceLibrary assembly when it is required.

    ### [C#](#tab/csharp)
    :::code language="csharp" source="../snippets/csharp/VS_Snippets_Winforms/ClickOnceOnDemandCmdLine/CS/Form1.cs" id="Snippet1":::

    ### [VB](#tab/vb)
    :::code language="vb" source="../snippets/visualbasic/VS_Snippets_Winforms/ClickOnceOnDemandCmdLine/VB/Form1.vb" id="Snippet1":::
    ---

10. In the code, locate the call to <xref:System.Reflection.Assembly.LoadFile%2A>.

11. Set `PublicKeyToken` to the value that you retrieved earlier.

12. Save the file as either *Form1.cs* or *Form1.vb*.

13. Compile it into an executable using the following command.

    ### [C#](#tab/csharp)
    ```csharp
    csc /target:exe /reference:ClickOnceLibrary.dll Form1.cs
    ```

    ### [VB](#tab/vb)
    ```vb
    vbc /target:exe /reference:ClickOnceLibrary.dll Form1.vb
    ```
    ---

## Mark assemblies as optional

#### To mark assemblies as optional in your ClickOnce application by using MageUI.exe

1. Using *MageUI.exe*, create an application manifest as described in [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). Use the following settings for the application manifest:

    - Name the application manifest `ClickOnceOnDemand`.

    - On the **Files** page, in the *ClickOnceLibrary.dll* row, set the **File Type** column to **None**.

    - On the **Files** page, in the *ClickOnceLibrary.dll* row, type `ClickOnceLibrary.dll` in the **Group** column.

2. Using *MageUI.exe*, create a deployment manifest as described in [Walkthrough: Manually deploy a ClickOnce application](../deployment/walkthrough-manually-deploying-a-clickonce-application.md). Use the following settings for the deployment manifest:

    - Name the deployment manifest `ClickOnceOnDemand`.

## Testing the new assembly

#### To test your on-demand assembly

1. Upload your ClickOnce deployment to a Web server.

2. Start your application deployed with ClickOnce from a Web browser by entering the URL to the deployment manifest. If you call your ClickOnce application `ClickOnceOnDemand`, and you upload it to the root directory of adatum.com, your URL would look like this:

   ```
   http://www.adatum.com/ClickOnceOnDemand/ClickOnceOnDemand.application
   ```

3. When your main form appears, press the <xref:System.Windows.Forms.Button>. You should see a string in a message box window that reads "Hello, World!".

## Related content
- <xref:System.Deployment.Application.ApplicationDeployment>
