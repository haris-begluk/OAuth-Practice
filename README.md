# OAuth-Practice
Configuration OAuth2 and OpenID Connect

Create certificate using powershell: 
New-SelfSignedCertificate -Subject "CN=HadesSigninCertificate" -CertStoreLocation "cert:\LocalMachine\My"
Create migrations for identity server: 
add-migration -name InitialIdentityServerConfiguration -context ConfigurationDbContext
add-migration -name InitialIdentityServerOperational -context PersistedGrantDbContext
