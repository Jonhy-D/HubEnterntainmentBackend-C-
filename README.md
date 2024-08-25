# Hub Backend

## Description

This is the backend repository of [Hub Entertainment Mega](https://github.com/Jonhy-D/hub-entertainment-mega), it's main function is the storage and processing of application data also defines what the rules and workflow will be like and how essential security is.

## Technical requirements

This project was generated with **ASP.NET** and **C#**, for the deployment of virtual applications at the operating system level use **Docker** and for deployment automation, scaling, and container management use **Kubernetes**.

## How to install the project

### First Step: 

You need to have the .NET SDK in order to run the project in dev, run the following command: `dotnet` to confirm that you have the .NET SDK installed and thus be able to launch the project.

### Second Step: 

Clone repository with this command:
` git clone "URL repository"`

### Third Step:

Once the repository is cloned you will have to create a file in the root of the project called **appsettings.json** with the next requirements:

```
{
  "Logging": {
    "LogLevel": {
      "Default": "Information",
      "Microsoft.AspNetCore": "Warning"
    }
  },
  "AllowedHosts": "*",
  "ConnectionStrings": {
    "DefaultConnection": "Server= "SERVER-NAME";Database="DATABASE-NAME";Uid="DATABASE-USER";Password="DATABASE-PASSWORD";TrustServerCertificate=True" 
  }
}
```

### Final Step

Run `dotnet run` to run the project at the specified port.

### Remember need a database

The database is in the file called **HubEnterntainment.dacpac**

## Endpoints

This endpoint is for creating users:

`POST /users` 

This endpoint is to verify that the user exists:

`POST /auth `

This endpoint is to get all the stored movies:

`GET /movies`

This endpoint is to get all the stored series:

`GET /series`

This endpoint is to get all the stored favorite movies section:

`POST /addFavMov`

This endpoint is to get all the stored favorite series section:

`POST /addFavSer`

# Sprint 6

### Goals

#### Implement a productive project with Kubernetes.

- Kubernetes Deployment
- Docker Deployment
- API in ASP.net or net core - MVC
- Complete documentation
- Possible future improvements

## Entity-Relationship Diagram

This is the entity relationship diagram of the hub entertainment mega project database according to my point of view.

![Entity-Relationship Diagram Image](/public/Entity-Relationship.webp)

## Images Docker Desktop

### Frontend and Backend Images 

![Frontend and Backend Images](/public/Images-Docker.webp)

### Containers

![Containers](/public/Containers_Docker.webp)

## Pods

![Pods](/public/Pods.webp)

## Process

- The first step was to build the **dockerfile** and **deployment** files
- The second step is to build your project both the frontend and the backend.
- Since we have the builds, we move on to creating the images to upload them to the minikube.
- After we have the images uploaded, we can now proceed to deploy them with the **.yaml** file. This file must be configured according to the needs of the application or, as in this case, simply make it work.
- But since we have to do it in the backend and in the frontend then we have to repeat all the previous steps.
- The steps that were complex were getting the image with the deployment because I don't know why I got errors about anything, I solved one error and another one came out, I don't know if it's because it works on Windows, but it was very complex.

## Issues

- The first problem I encountered was that I was typing a command wrong and, as always happens when there is an error due to a single letter, it takes longer than with an error that you don't know about because the fact of thinking that it is correct makes it difficult to find the error.
- The second error was the image with the deployment that did not want to find the image for some reason I don't know why it did not want to find the image for no reason because the commands were correct.
- I also had a problem migrating the database from Node to C# because there were things I had never done in C#, so it was a challenge to figure out how to do what I was doing with Node.js.

## Table Sprint Review

| **What was done well?** | **What can I do differently?** | **What didn't go well?** |
------------------|----------------------------|-----------------------
| Recreating the database in C# was one of the parts that was really good because I was comparing the different ways of doing things in each language and I liked absorbing the information and trying to remember that, I like it. | Manage my time a little better solving the errors because I would get so frustrated with a mistake that I would spend my time just thinking about it instead of going out to clear my head and try again. | Trying to fix or debug code without checking any documentation or searching the internet for how to resolve the error would have saved me a lot of time, but even when I tried to search for it, it was still difficult for me to find a way to resolve the errors. |

## Possible future improvements

- Make the backend more extensive so that the application could do more things.
- Complete the person's profile section.
- Improve the frontend with Media queries in many places that I couldn't do due to lack of time.
