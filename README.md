# Oct2016DataPoints
October 2016 MSDN Mag Data Points samples

The Full .NET project was created in Visual Studio 2015 Update 3 on Windows.

The EFCoreCLR project was built in Visual Studio Code on a Mac. While the dependencies are different, the EF Code is the same in both places as they use the same exact EFCore APIs.

On windows, the EFCoreCLR project.json may require a runtimes section into project.json ala 

"runtimes": {
        "win10-x64": {}
 }
