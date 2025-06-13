---
title: Registering and Unregistering VSPackages
description: Learn about registering and unregistering your VSPackages, including the attributes you use and the .pkgdef file.
ms.date: 11/04/2016
ms.topic: how-to
helpviewer_keywords:
- registration, VSPackages
- VSPackages, registering
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Register and unregister VSPackages

You use attributes to register a VSPackage, but

## Register a VSPackage
 You can use attributes to control the registration of managed VSPackages. All registration information is contained in a *.pkgdef* file. For more information on file-based registration, see [CreatePkgDef utility](../extensibility/internals/createpkgdef-utility.md).

 The following code shows how to use the standard registration attributes to register your VSPackage.

```csharp
[PackageRegistration(UseManagedResourcesOnly = true)]
[Guid("0B81D86C-0A85-4f30-9B26-DD2616447F95")]
public sealed class BasicPackage : Package
{
    // ...
}
```

## Unregister an extension
 If you have been experimenting with a lot of different VSPackages and want to remove them from the experimental instance, you can just run the **Reset** command. Look for **Reset the Visual Studio Experimental Instance** on the start page of your computer, or run this command from the command line:

```cmd
<location of Visual Studio 2015 install>\"Microsoft Visual Studio 14.0\VSSDK\VisualStudioIntegration\Tools\Bin\CreateExpInstance.exe" /Reset /VSInstance=14.0 /RootSuffix=Exp
```

 If you want to uninstall an extension that you have installed on your development instance of Visual Studio, go to **Tools** > **Extensions and Updates**, find the extension, and click **Uninstall**.

 If for some reason neither of these methods succeeds at uninstalling the extension, you can unregister the VSPackage assembly from the command line as follows:

```cmd
<location of Visual Studio 2015 install>\"Microsoft Visual Studio 14.0\VSSDK\VisualStudioIntegration\Tools\Bin\regpkg" /unregister <pathToVSPackage assembly>
```

<a name="using-a-custom-registration-attribute-to-register-an-extension"></a>

## Use a custom registration attribute to register an extension

In certain cases you may need to create a new registration attribute for your extension. You can use registration attributes to add new registry keys or to add new values to existing keys. The new attribute must derive from <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute>, and it must override the <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.Register%2A> and <xref:Microsoft.VisualStudio.Shell.RegistrationAttribute.Unregister%2A> methods.

### Create a custom attribute

The following code shows how to create a new registration attribute.

```csharp
[AttributeUsage(AttributeTargets.Class, Inherited = true, AllowMultiple = false)]
public class CustomRegistrationAttribute : RegistrationAttribute
{
}
```

 The <xref:System.AttributeUsageAttribute> is used on attribute classes to specify the program element (class, method, etc.) to which the attribute pertains, whether it can be used more than once, and whether it can be inherited.

### Create a registry key

In the following code, the custom attribute creates a **Custom** subkey under the key for the VSPackage that is being registered.

```csharp
public override void Register(RegistrationAttribute.RegistrationContext context)
{
    Key packageKey = null;
    try
    {
        packageKey = context.CreateKey(@"Packages\{" + context.ComponentType.GUID + @"}\Custom");
        packageKey.SetValue("NewCustom", 1);
    }
    finally
    {
        if (packageKey != null)
            packageKey.Close();
    }
}

public override void Unregister(RegistrationContext context)
{
    context.RemoveKey(@"Packages\" + context.ComponentType.GUID + @"}\Custom");
}
```

### Create a new value under an existing registry key

You can add custom values to an existing key. The following code shows how to add a new value to a VSPackage registration key.

```csharp
public override void Register(RegistrationAttribute.RegistrationContext context)
{
    Key packageKey = null;
    try
    {
        packageKey = context.CreateKey(@"Packages\{" + context.ComponentType.GUID + "}");
        packageKey.SetValue("NewCustom", 1);
    }
    finally
    {
        if (packageKey != null)
            packageKey.Close();
    }
}

public override void Unregister(RegistrationContext context)
{
    context.RemoveValue(@"Packages\" + context.ComponentType.GUID, "NewCustom");
}
```

## Related content
- [VSPackages](../extensibility/internals/vspackages.md)
