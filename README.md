# OAuth-Practice
Configuration OAuth2 and OpenID Connect

## OAuth OpenId Connect: 
Navigate to the solution than add OAuth asp.net core template with command: 
```bash
dotnet new is4empty -n ServerName 
```
## Add User Interface /UI for OAuth server by navigating to the Auth server folder and than execute command: 
```bash
dotnet new is4ui 
```
## Create certificate using powershell: 
```bash
New-SelfSignedCertificate -Subject "CN=HadesSigninCertificate" -CertStoreLocation "cert:\LocalMachine\My"
```

## Create migrations for identity server: 
```bash
add-migration -name InitialIdentityServerConfiguration -context ConfigurationDbContext
```
```bash
add-migration -name InitialIdentityServerOperational -context PersistedGrantDbContext
```

