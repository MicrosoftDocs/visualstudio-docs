---
title: Wizard Interface (IDTWizard)
description: The IDE uses the IDTWizard interface to communicate with wizards. Wizards must implement this interface to be installed in the IDE.
ms.date: 11/04/2016
ms.topic: reference
helpviewer_keywords:
- IDTWizard interface
- wizards, interface
author: tinaschrepfer
ms.author: tinali
manager: mijacobs
ms.subservice: extensibility-integration
---
# Wizard Interface (IDTWizard)

The integrated development environment (IDE) uses the <xref:EnvDTE.IDTWizard> interface to communicate with wizards. Wizards must implement this interface in order to be installed in the IDE.

 The <xref:EnvDTE.IDTWizard.Execute%2A> method is the only method associated with the <xref:EnvDTE.IDTWizard> interface. Wizards implement this method and the IDE calls the method on the interface. The following example shows the signature of the method.

```
/* IDTWizard Method */
STDMETHOD(Execute)(THIS_
   /* [in] */ IDispatch *Application,
   /* [in] */ long hwndOwner,
   /* [in] */ SAFEARRAY * *ContextParams,
   /* [in] */ SAFEARRAY * *CustomParams,
   /* [out] [in] */ wizardResult *RetVal
   );
```

 The start mechanism is similar for both the **New Project** and **Add New Item** wizards. To start either, you call the <xref:EnvDTE.IDTWizard> interface defined in Dteinternal.h. The only difference is the set of context and custom parameters that are passed to the interface when the interface is called.

 The following information describes the <xref:EnvDTE.IDTWizard> interface that wizards must implement to work in the Visual Studio IDE. The IDE calls the <xref:EnvDTE.IDTWizard.Execute%2A> method on the wizard, passing it the following:

- The DTE object

     The DTE object is the root of the Automation model.

- The handle to the window dialog box as shown in the code segment, `hwndOwner ([in] long)`.

     The wizard uses this `hwndOwner` as the parent for the wizard dialog box.

- Context parameters passed to the interface as variant for SAFEARRAY as shown in the code segment, `[in] SAFEARRAY (VARIANT)* ContextParams`.

     Context parameters contain an array of values that are specific to the kind of wizard being started and the current state of the project. The IDE passes  the context parameters to the wizard. For more information, see [Context Parameters](../../extensibility/internals/context-parameters.md).

- Custom parameters passed to the interface as a variant for SAFEARRAY as shown in the code segment, `[in] SAFEARRAY (VARIANT)* CustomParams`.

     Custom parameters contain an array of user-defined parameters. A .vsz file passes custom parameters to the IDE. The values are determined by the `Param=` statements. For more information, see [Custom Parameters](../../extensibility/internals/custom-parameters.md).

- Return values for the interface are

    ```
    wizardResultSuccess = -1,
    wizardResultFailure = 0
    wizardResultCancel = 1
    wizardResultBackout = 2
    ```

## See also
- [Context Parameters](../../extensibility/internals/context-parameters.md)
- [Custom Parameters](../../extensibility/internals/custom-parameters.md)
- [Wizards](../../extensibility/internals/wizards.md)
- [Wizard (.Vsz) File](../../extensibility/internals/wizard-dot-vsz-file.md)
