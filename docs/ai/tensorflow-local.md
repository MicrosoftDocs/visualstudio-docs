
# Run a TensorFlow model locally 
In the quickstart, we will the MNIST project locally. Before you start, ensure you have the following installed:  

## NVIDIA GPU card, driver, CUDA 8.0 and cuDNN 5.1 (Optional)

Part of this section is excerpted from <https://www.tensorflow.org/install/install_windows>.

To speed up local Deep Learning experiences, the following NVIDIA hardware and software must be installed on your system:

1.  GPU card with CUDA Compute Capability 3.0 or higher.
    See [NVIDIA’s documentation](https://developer.nvidia.com/cuda-gpus) for a list of supported GPU cards.

2.  CUDA® Toolkit 8.0. For details, see [NVIDIA's documentation](http://docs.nvidia.com/cuda/cuda-installation-guide-microsoft-windows/).

    a.  There are two CUDA installers on Windows. One is for Windows 10/Server 2016, and the other is for Windows 7/8.1/Server 2012 R2.

    b.  Ensure to install **Runtime**-&gt;**Libraries**:
    ><center>![](images/image12.png)</center>
    ><center>Figure: Install CUDA.</center>
    <br>

    c.  Suppose CUDA is installed in "C:\\Program Files\\NVIDIA GPU Computing Toolkit\\CUDA\\v8.0".
    Ensure relevant CUDA paths such as "C:\\Program Files\\NVIDIA GPU Computing Toolkit\\CUDA\\v8.0\\bin" are added to the %PATH% environment variable as described in the NVIDIA documentation.

3.  The NVIDIA drivers associated with CUDA Toolkit 8.0.

4.  cuDNN v5.1. For details, see [NVIDIA's documentation](https://developer.nvidia.com/cudnn).

    a.  There are two cuDNN packages on Windows.
        One is for Windows 10/Server 2016, and the other is for Windows 7/8.1/Server 2012 R2.

    b.  For manual installation, we recommend installing cuDNN under CUDA directory.
        If you install cuDNN in a different location from the other CUDA DLLs, ensure that you add the directory where you installed the cuDNN DLL to your %PATH% environment variable.

## Google TensorFlow 1.2.1 

Please refer to [here](https://www.tensorflow.org/install/install_windows) for detailed installation of TensorFlow on Windows.

You must choose whether to install TensorFlow with CPU support only, or TensorFlow with GPU support. Users cannot install both through pip command.

To install TensorFlow with CPU support only, run the following command in a terminal:

```cmd
C:\>pip.exe install tensorflow==1.2.1
```

To install TensorFlow with GPU support, please first install NVIDIA drivers, CUDA® Toolkit 8.0, cuDNN 5.1 and ensure that you add the directories where you installed the CUDA and cuDNN binaries to your %PATH% environment variable. Then run the following command in a terminal:

```cmd
C:\>pip.exe install tensorflow-gpu==1.2.1
```

## NumPy 1.13.1 and SciPy 0.19.1 

NumPy is a general-purpose array-processing package designed to efficiently manipulate large multi-dimensional arrays of arbitrary records without sacrificing too much speed for small multi-dimensional arrays.
SciPy (pronounced "Sigh Pie") is open-source software for mathematics, science, and engineering, depending on NumPy.

Because SciPy has no official prebuilt package on Windows, you need to install both [NumPy](https://www.lfd.uci.edu/~gohlke/pythonlibs/#numpy) and [SciPy](https://www.lfd.uci.edu/~gohlke/pythonlibs/#scipy) from a third party [web site](http://www.lfd.uci.edu/~gohlke/pythonlibs/).

## Load and run model 

1. Launch Visual Studio and select **File > Open > Project/Solution**.

2. Select the folder containing the samples dowloaded earlier.

3. Find the MNIST Project in the **Solution Explorer**, right click on the **convolution.py** file and select **Set as Startup File**.

4. Click **Start**. 