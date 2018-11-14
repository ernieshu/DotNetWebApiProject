# DotNetWebApiProject
Repo for a DotNetWebAPI project.  Putting into Github for Azure DevOps / Pipelines visibility.

# What's been done
* code
  * using .NET Core 2.1
  * In memory database for persistence
    * Endpoints implemented via `AspCoreNet.Mvc` namespace
  * Implemented SwaggerUI / OpenAPI pages for API test exposure
* build
  * Visual Studio
  * local (via `dotnet build`)
  * Azure DevOps Pipeline (https://dev.azure.com)
* resource allocation
  * via manual resource allocation
  * via Resource Templates
    * Reference templates can be found [here](https://azure.microsoft.com/en-ca/resources/templates/)
* deployment in:
  * azure via Visual Studio (right click)
  * azure via FTP / Git push (configuration and git push)

# What could be expanded
* Deployment via Azure DevOps / Azure Pipelines [in progress]
* Addition of unit tests

# Build Status
[![Build Status](https://dev.azure.com/ernieshu/TodoAPI/_apis/build/status/ernieshu.DotNetWebApiProject)](https://dev.azure.com/ernieshu/TodoAPI/_build/latest?definitionId=1)
