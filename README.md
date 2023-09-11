# SendGrid Email Web API
This project is an example of a Web API developed using .NET Core 6.0. It facilitates email sending using SendGrid and can be easily containerized with Docker.
## Technologies
.NET Core 6.0
SendGrid (used for email sending) 

Docker (used for containerization)
## Gereksinimler
Requirements
To run this Mail Sender Web API application, you'll need the following requirements:

- .NET Core 6.0 SDK: Make sure you have .NET Core 6.0 SDK installed. You can download it from Microsoft's .NET Download page.

- SendGrid API Key: You need a SendGrid API key to send emails. Obtain an API key by signing up for a SendGrid account and creating a new API key in the SendGrid dashboard.

- SendGrid NuGet Package: The SendGrid library is required for email sending functionality. You can add it to your project using the NuGet Package Manager. Run the following command in the NuGet Package Manager Console to install the SendGrid package:

```csharp
Install-Package SendGrid
```



  
## Usage Instructions
1-Clone this repository or 
[download it as a ZIP file.](https://github.com/AybukeSanall/MailSender.git)  
2-Visit the SendGrid website and obtain an API key.

3-You need to define your API key in the "appsettings.json" file located in the root directory of your project. The content of the file should look like this:

```json
{
  "AppSettings": {
    "SendGridApiKey": "your-api-key"
  }
}
```
Docker must be installed. If it's not installed, you can 
[download Docker from here.](https://www.docker.com/products/docker-desktop/)

## Docker Deployment
To deploy and run the project using Docker, follow these steps:

1-Open a terminal in the project folder.

2-Build the Docker container with the following command:

```bash
docker build -t my-dotnet-app .
```
3-Start the Docker container with the following command:
```bash
docker run -d -p 5000:80 --name my-app my-dotnet-app
```
This command will run the Docker container on port 5000.
