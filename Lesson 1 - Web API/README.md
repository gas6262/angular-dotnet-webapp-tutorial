To start the web app, you must have [dotnetcore 5 installed](https://dotnet.microsoft.com/download/dotnet/5.0), You can follow this [tutroal here](https://dgaspard.com/KubernetesAITutorial2/)

## Prerequisites
+  [Visual Studio Code](https://code.visualstudio.com/download) for development
+  Basic programming/website knowledge (not algorithmic)
+  [Some basic C# experience](https://docs.microsoft.com/en-us/dotnet/csharp/tour-of-csharp/tutorials/hello-world?tutorial-step=1) to create the Webapi (backend)
+  [Dotnet core and dotnet CLI](https://dotnet.microsoft.com/download/dotnet/3.1)
+  [Docker](https://docs.docker.com/get-docker/) to [containerize](https://cloud.google.com/containers#:~:text=Containerization%20provides%20a%20clean%20separation,configurations%20specific%20to%20the%20app.) the web application. Just trust me on this one
+  [Postman](https://www.postman.com/downloads/) to test the webapi
+  [Google chrome](https://www.google.com/chrome/) or Microsoft edge chromium

**Start API using dotnet CLI**
From the terminal, run the following command
```shell
dotnet run
```
Open browser to http://localhost:5000/helloworld. You should see 'Hello World'

**Build API container image using Docker**
From the termianl run
```shell
docker build -t webapi:v1
```
Build may take a while but logs should be verbose. At the end, you should see a success status

**Run the container image**
```shell
docker run -it --rm -p 8080:5000 webapi:v1
```
Navigate your browser to http://localhost:8080/helloworld to access the web api