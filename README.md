# CAPIEH
Centralized API Exception handler

[![Build status](https://dev.azure.com/DavidVanderheyden/CAPIEH%20(Centralized%20API%20Exception%20Handler)/_apis/build/status/CAPIEH%20(Centralized%20API%20Exception%20Handler)-ASP.NET%20Core-CI)](https://dev.azure.com/DavidVanderheyden/CAPIEH%20(Centralized%20API%20Exception%20Handler)/_build/latest?definitionId=11)


CAPIEH is a package to centralize all the exception handling and create a unified response format.

It's build around a middleware that places a big try catch on your pipeline. If an error is caught, it will invoke your delegated ExceptionHandler to handle your exception the way you want.

It gives the benifit to add translations to your message, make use of error codes, set error types, set exception identifiers to track in your logging, and more ...


## Get it on Nuget

The main package on [nuget.org](https://www.nuget.org/packages/SpecificatR/):
``` csharp
PM> Install-Package CAPIEH.Core
```

The abstractions containing apiResponse wrapping models:
``` csharp
Coming Soon
```

## Usage
### Registering dependencies
Registering the dependencies in an ASP.NET Core application, using Microsoft.Extensions.DependencyInjection, is pretty simple:

### Set-up the ExceptionHandler Delegate

You propagate how how exceptions should be handled and / or returned as a response, by creating and pluging your own ExceptionHandler Delegate. You set this up as followed:
``` csharp
// EXAMPLE
``` 

### Example of Generic API Response

A generic response message will look like this
```json
{
  "data": {
   ... Your data model
  },
  "error": {
    "id": "Identifier to track inside the logging",
    "message": "A generic or custom message",
    "type": "exception types (application exception, validation exception, ... whatever you can make up)",
    "code": "an exception code that can be used on the client to set/translate exception messages client side",
    "info": object (optional object to add custom data to your client),
  },
  "status": "string",
  "statusCode": 100 // HttpStatusCode
}
```




