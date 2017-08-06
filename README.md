# Star Citizen API

![Build status](https://ci.appveyor.com/api/projects/status/32pxjo4lkh5h3peq?svg=true)

## Development Principles

1. User experience comes first.
2. Build it at enterprise standards.
3. Aim for zero network footprint.
4. Make no assumptions on behalf of the user.
5. Do not trouble the Star Citizen developers.

## Nuget Packages

| Nuget Package Name          | Nuget Package URL                                                            |
|-----------------------------|------------------------------------------------------------------------------|
| StarCitizenApi              | https://www.myget.org/feed/agabani/package/nuget/StarCitizenApi              |
| StarCitizenApi.FileSystem   | https://www.myget.org/feed/agabani/package/nuget/StarCitizenApi.FileSystem   |
| StarCitizenApi.WindowsAzure | https://www.myget.org/feed/agabani/package/nuget/StarCitizenApi.WindowsAzure |

## ARK Starmap

- **Description:** SDK for Star Citizen's ARK Starmap
- **Motivation:** Intergration with Star Citizen business process systems
- **Reference:** https://robertsspaceindustries.com/starmap

| Feature                      | Status                   | Nuget Package               |
|------------------------------|--------------------------|-----------------------------|
| SDK                          | First iteration complete | StarCitizenApi              |
| File Local Caching           | First iteration complete | StarCitizenApi.FileSystem   |
| Azure Blob Storage Caching   | First iteration complete | StarCitizenApi.WindowsAzure |
| Discrepancies Detection Tool | First iteration complete |                             |
| Wiki for getting started     | Pending                  |                             |
