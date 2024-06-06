//  Aplicación CRUD con ASP.NET Core y Razor Pages

//  Descripción
// Este repositorio contiene una aplicación completa CRUD (Crear, Leer, Actualizar, Eliminar) construida 
// utilizando ASP.NET Core con Razor Pages. Está diseñada para proporcionar una comprensión completa de la 
// estructura de un proyecto ASP.NET Core, los fundamentos del desarrollo con Razor Pages, las migraciones 
// de bases de datos y más.

//  Características
// - Operaciones CRUD: Implementación de funcionalidades de Crear, Leer, Actualizar y Eliminar.
// - Estructura del Proyecto ASP.NET Core: Conocimiento sobre la organización y gestión de un proyecto ASP.NET Core.
// - Fundamentos de Razor Pages: Conceptos y prácticas esenciales para desarrollar aplicaciones utilizando Razor Pages.
// - Migraciones de Bases de Datos: Uso de Entity Framework Core para migraciones y gestión de esquemas de bases de datos.
// - Integración con SQL Server: Construcción e integración de la aplicación con SQL Server, específicamente utilizando 
//   Microsoft SQL LocalDB.
// - Contextos, Modelos y Migraciones: Comprensión e implementación de DbContext, modelos de datos y migraciones.
// - Enfoque Code First: Desarrollo de la base de datos a partir del código utilizando el enfoque Code First de Entity 
//   Framework Core.
// - Extensiones Necesarias: Instalación y configuración de las extensiones de Visual Studio necesarias para un desarrollo 
//   eficiente.

//  Primeros Pasos

//  Prerrequisitos
// - [.NET SDK](https://dotnet.microsoft.com/download)
// - [Visual Studio](https://visualstudio.microsoft.com/) con la carga de trabajo de desarrollo de ASP.NET y web
// - [SQL Server](https://www.microsoft.com/es-es/sql-server/sql-server-downloads) o Microsoft SQL LocalDB

//  Instalación
// 1. Clonar el repositorio:
//    bash
//    https://github.com/Vleiva220503/FUNDAMENTOS-DE-NET-8-RAZOR.git
//    cd aspnetcore-crud-razorpages
//    
// 2. Abrir la solución en Visual Studio.
// 3. Restaurar los paquetes NuGet:
//    bash
//    dotnet restore
//    
// 4. Aplicar las migraciones para crear la base de datos:
//    bash
//    dotnet ef database update
//    
// 5. Ejecutar la aplicación:
//    bash
//    dotnet run

//  Estructura del Proyecto
// - Models: Contiene los modelos de datos utilizados por Entity Framework Core.
// - Data: Incluye la clase DbContext y los archivos de migraciones de la base de datos.
// - Pages: Páginas Razor para las operaciones CRUD.
// - wwwroot: Archivos estáticos como CSS, JavaScript e imágenes.

//  Objetivos de Aprendizaje
// - Comprender la estructura y componentes de un proyecto ASP.NET Core.
// - Desarrollar Razor Pages para implementar funcionalidades CRUD.
// - Gestionar el esquema de la base de datos utilizando migraciones.
// - Integrar aplicaciones .NET Core con SQL Server.
// - Utilizar DbContext y modelos de datos para operaciones de bases de datos.
// - Seguir el enfoque Code First para el desarrollo de bases de datos.

//  Extensiones
// - Extensiones de Visual Studio:
//   - Desarrollo de ASP.NET y web
//   - Herramientas de Entity Framework Core

