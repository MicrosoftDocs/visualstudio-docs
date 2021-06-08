# Testing your extension with Dev17

This document assumes you already have a building Dev17-targeted extension.

To test an extension that targets Dev17 you will need to have Dev17 installed.
You will not be able to run 64-bit extensions on versions of Visual Studio prior to Dev17.

> [!NOTE] At the time of writing, the Dev17 installer is not yet available. Testing cannot happen without that.

You can use Dev17 to build and test your extensions whether they target Dev17 or an earlier version.
When launching a VSIX project from Dev17 an experimental instance of VS will be launched.

We strongly recommend you test with each version of Visual Studio that
you intend the extension to support.

Now you're ready to [publish your extension](Publishing).
