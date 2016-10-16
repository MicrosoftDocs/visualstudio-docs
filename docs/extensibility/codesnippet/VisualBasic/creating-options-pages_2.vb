<PackageRegistration(UseManagedResourcesOnly:=True)> _
<DefaultRegistryRoot("Software\Microsoft\VisualStudio\9.0")> _
<InstalledProductRegistration(False, "#110", "#112", "1.0", IconResourceID:=400)> _
<ProvideLoadKey("Standard", "1.0", "Package Name", "Company", 1)> _
<ProvideMenuResource(1000, 1)> _
<Guid(GuidList.guidPkgString)> _
<ProvideOptionPage(GetType(HelloWorldOptions), "Hello World Category", "Hello World Page", 1000, 1001, False)> _
Public NotInheritable Class UIUserSettingsToolsOptionsPagesPackage
    Inherits Package