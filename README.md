# Notes

Publish container for Blazor SSR + Blazor WebAssembly in the same web app.

Url https://delicate-dael-wisebits.koyeb.app

Generate image:

`dotnet publish BlazorApp/BlazorApp.csproj -p:PublishProfile=DefaultContainer -c Release`

Run locally:

`docker run -p 8080:8080 netdefender/blazor-ssr:1.0.0`

Push:

`docker login -u netdefender -p <Access Token>`
`docker image push netdefender/blazor-ssr:1.0.0`