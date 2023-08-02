# Tariff Comparison Task

Simple implementation of an ASP.NET Core Web API project for tariff calculation and comparison

For simplicity-sake, I chose to keep it simple and stick to what was requested in the task only. I skipped more real-world scenario features such as data access and erron handling.

The language, framework and libraries used are:

    .NET 7.0
    C#.NET 11
    Swagger

## Build and Run
Assuming it's being run in a Linux Environment as requested in the task

 
- Run the following script in the root folder `setup.sh`

> The script will handle the installation of .NET Core SDK and build the project, all in one go. It ensures that the required dependencies are installed.
> 
**Note:** this script assumes you are running the project on a Linux-based system, but I didn't use Linux to build the project, therefore I have no way to test the script functionality. You might need to adjust the script, the package manager and package names accordingly.

if everything runs correctly you should see Swagger UI page that allows you to test the service. See below example
![image](https://github.com/CMolero/Tariff-Comparison-Verivox/assets/5658513/c575e932-b0a0-400d-b808-dab8f7c38e0c)
![image](https://github.com/CMolero/Tariff-Comparison-Verivox/assets/5658513/63fb25bc-4f13-4526-9a14-9f55ed27b377)
