# Down-targeting to Visual Studio 2019

When you create a new VSIX project using Dev17, the project is created from a template
that targets Dev17.
If you want to target Visual Studio 2019, you must modify the created project.

Consider using [shared projects](shared-projects.md) to target Visual Studio 2019 and Dev17 while sharing most or all the code in your extension.

Follow these steps on the VSIX project that should target Dev16:

1. Edit the `source.extension.vsixmanifest` file to remove the `ProductArchitecture` element and the version range:

    ```diff
    -<InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[17.0,18.0)">
    +<InstallationTarget Id="Microsoft.VisualStudio.Community" Version="[16.0,17.0)">
    -  <ProductArchitecture>amd64</ProductArchitecture>
     </InstallationTarget>
    ```

   Also update the prerequisite:

    ```diff
    -<Prerequisite Id="Microsoft.VisualStudio.Component.CoreEditor" Version="[17.0,18.0)" DisplayName="Visual Studio core editor" />
    +<Prerequisite Id="Microsoft.VisualStudio.Component.CoreEditor" Version="[16.0,17.0)" DisplayName="Visual Studio core editor" />
    ```

    Review the file for any other updates that may be necessary.

1. Change the versions of the VS SDK packages that you reference in your project file:

    ```diff
    -<PackageReference Include="Microsoft.VisualStudio.SDK" Version="17.0.0-preview.1" />
    +<PackageReference Include="Microsoft.VisualStudio.SDK" Version="16.0.206" />
    -<PackageReference Include="Microsoft.VSSDK.BuildTools" Version="17.0.63-preview.1" />
    +<PackageReference Include="Microsoft.VSSDK.BuildTools" Version="16.10.32" />
    ```
