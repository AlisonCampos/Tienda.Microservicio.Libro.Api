# Tienda.Microservicio.Libro.Api

Microservicio para la gestión de autores de libros, desarrollado con ASP.NET Core (.NET 9), MediatR, Entity Framework Core y AutoMapper.

## Características

- Listado de autores
- Búsqueda de autores por nombre o GUID
- Creación de nuevos autores
- Validación de datos con FluentValidation
- Arquitectura limpia y desacoplada usando MediatR

## Requisitos

- [.NET 9 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- SQL Server (o modificar la cadena de conexión para otro proveedor)
- Visual Studio 2022 o superior

## Configuración

- 1. Clona el repositorio:
- git clone https://github.com/tu-usuario/tu-repositorio.git cd tu-repositorio

- 2. Configura la cadena de conexión en `appsettings.json`:
- "ConnectionStrings": { "DefaultConnection": "Server=TU_SERVIDOR;Database=AutoresDb;Trusted_Connection=True;MultipleActiveResultSets=true" }

- 3. Aplica las migraciones de la base de datos:
- dotnet ef database update

## Ejecución

- Para iniciar el microservicio:
- dotnet run --project Tienda.Microservicio.Libro.Api

- El API estará disponible en: `https://localhost:5001` (o el puerto configurado).

## Endpoints principales

- `GET /api/autor` — Lista todos los autores
- `GET /api/autor/nombre/{nombre}` — Busca un autor por nombre
- `GET /api/autor/filtro?autorGuid={guid}` — Busca un autor por GUID
- `POST /api/autor` — Crea un nuevo autor

## Tecnologías utilizadas

- ASP.NET Core (.NET 9)
- MediatR
- Entity Framework Core
- AutoMapper
- FluentValidation
- Swagger (Swashbuckle)

## Contribuciones

Las contribuciones son bienvenidas. Por favor, abre un issue o un pull request para sugerencias o mejoras.

