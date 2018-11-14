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
    * Pipeline build file constructed in azure-pipelines.yml
* resource allocation
  * via manual resource allocation
  * via Resource Templates
    * Reference templates can be found [here](https://azure.microsoft.com/en-ca/resources/templates/)
* deployment in:
  * azure via Visual Studio (right click)
  * azure via FTP / Git push (configuration and git push)
* Enable authentication via Azure Active Directory + Google (currently disabled)
* Deployment Slots enabled
  * just move a currently deployed artifact from one environment to another
  * via UI or CLI
  * operations: create / swap / delete
    * similiar to Green / Blue deployments

# What could be expanded
* Deployment via Azure DevOps / Azure Pipelines [in progress]

# Build Status
[![Build Status](https://dev.azure.com/ernieshu/TodoAPI/_apis/build/status/ernieshu.DotNetWebApiProject)](https://dev.azure.com/ernieshu/TodoAPI/_build/latest?definitionId=1)
