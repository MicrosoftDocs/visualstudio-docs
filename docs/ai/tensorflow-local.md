
# Run a TensorFlow model locally 

In this quickstart, we will run a TensorFlow model with the [MNIST](http://yann.lecun.com/exdb/mnist/) dataset locally in AI Tools. 
The MNIST database has a training set of 60,000 examples, and a test set of 10,000 examples of handwritten digits. 

## Prerequisites

Before you begin, ensure you have the following installed:

### Google TensorFlow 

Run the following command in a terminal. 
```cmd
C:\>pip.exe install tensorflow==1.2.1
```

### NumPy and SciPy 
Install [NumPy](https://www.lfd.uci.edu/~gohlke/pythonlibs/#numpy) and [SciPy](https://www.lfd.uci.edu/~gohlke/pythonlibs/#scipy). 

### Download sample code
Download this [GitHub repository](https://github.com/Microsoft/samples-for-ai) containing samples for getting started with deep learning across TensorFlow, CNTK, Theano and more. 

## Load and run model 

- Launch Visual Studio and select **File > Open > Project/Solution**.

- Select the **Tensorflow Examples** folder from the samples repository dowloaded and open the **TensorflowExamples.sln** file. 

![Open project](media\tensorflow-local\open-project.png)

![Open solution](media\tensorflow-local\open-solution.png)

- Find the MNIST Project in the **Solution Explorer**, right click and select **Set as StartUp Project**.

- Click **Start**. 

- The output will be printed in the console.

![Sample output from console](media\tensorflow-local\console-output.png)

> [!div class="nextstepaction"]
> [Run a TensorFlow model in the cloud](tensorflow-vm.md)