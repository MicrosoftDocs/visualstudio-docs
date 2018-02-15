//<Snippet8>
using EnvDTE;
using System;
using System.IO;
using System.Runtime.InteropServices;

namespace ProjectTemplateWizard
{
    internal class ProjectSigningManager
    {
        private const string KEY_FILENAME = "key.snk";
        private byte[] keyBuffer;
        private bool strongNameGenerated = false;

        #region Methods used by the project wizard

        internal void GenerateKeyFile()
        {
            if (!strongNameGenerated)
            {
                keyBuffer = CreateNewKeyPair();
                strongNameGenerated = true;
            }
        }

        internal void AddKeyFile(Project project)
        {
            if (strongNameGenerated)
            {
                AddKeyFileToProject(project);
            }
        }

        #endregion

        #region Private members

        private byte[] CreateNewKeyPair()
        {
            IntPtr buffer = IntPtr.Zero;
            uint bufferSize;
            byte[] keyBuffer;

            try
            {
                if (0 == NativeMethods.StrongNameKeyGen(IntPtr.Zero, 0, out buffer, out bufferSize))
                {
                    Marshal.ThrowExceptionForHR(NativeMethods.StrongNameErrorInfo());
                }

                if (buffer == IntPtr.Zero)
                {
                    throw new InvalidOperationException("Cannot generate the strong name key.");
                }

                // Copy generated key to managed memory.
                keyBuffer = new byte[bufferSize];
                Marshal.Copy(buffer, keyBuffer, 0, (int)bufferSize);
            }
            finally
            {
                // Free native resources.
                NativeMethods.StrongNameFreeBuffer(buffer);
            }

            return keyBuffer;
        }

        private void AddKeyFileToProject(Project project)
        {
            // Save the key to a file.
            if (keyBuffer != null)
            {
                try
                {
                    string destinationDirectory = Path.GetDirectoryName(project.FullName);
                    string keySavePath = Path.Combine(destinationDirectory, KEY_FILENAME);

                    File.WriteAllBytes(keySavePath, keyBuffer);
                    project.ProjectItems.AddFromFile(keySavePath);

                    // Add properties in the project to use the key for signing.
                    EnvDTE.Properties projProps = project.Properties;
                    projProps.Item("SignAssembly").Value = true;
                    projProps.Item("AssemblyOriginatorKeyFile").Value = KEY_FILENAME;
                }
                catch (Exception e)
                {
                    throw new Exception("Cannot add the strong name key to the project. " + e.Message, e);
                }
            }
        }

        private static class NativeMethods
        {
            [DllImport("mscoree.dll")]
            internal extern static int StrongNameFreeBuffer(IntPtr pbMemory);

            [DllImport("mscoree.dll", CharSet = CharSet.Unicode, ExactSpelling = true)]
            internal static extern int StrongNameKeyGen(IntPtr wszKeyContainer, uint dwFlags, out IntPtr KeyBlob, 
                out uint KeyBlobSize);

            [DllImport("mscoree.dll", CharSet = CharSet.Unicode)]
            internal static extern int StrongNameErrorInfo();
        }

        #endregion
    }
}
//</Snippet8>
