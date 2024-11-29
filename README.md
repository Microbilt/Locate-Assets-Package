# Locate Assets Package Client

A .NET client for consuming the Microbilt Property Search API.

API page - https://developer.microbilt.com/api/PropertySearch

# Installation

`composer require Microbilt/Locate-Assets-Package`

# Quick Start

```
LocateAssetsPackageClient locateAssetsPackageClient = new LocateAssetsPackageClient("client_id", "client_secret");
```
# Configuration

`client_id` required

`client_secret` required

`EnvironmentType` optional (defaults to Production). Other option is Sandbox. 

# Usage
See https://developer.microbilt.com/api/PropertySearch for the necessary parameters to pass in to each function.
For report created request model 
```
PropertySearchRequestModel reqModel = new PropertySearchRequestModel()
{
     OwnerInfo = new OwnerInfo() {
        PersonName = new PersonName() {
            FirstName = "LORENZO A",
            LastName = "FOSTER"
        }
    },
      PropertyAddress = new PostAddr() {
        Addr1 = "530 EAKER WAY",
        City = "ANTIOCH",
        StateProv = "CA",
        PostalCode = "94509"
      }
};
```
You can Serialize model for use with extension method ```.ToJson()``` in 'Extensions.cs'

All responses for all requests 'JsonObject', for get JSON string You can use ```.ToString()``` method