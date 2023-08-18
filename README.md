# UserGetCreate

Este proyecto es un ejemplo de cómo utilizar la biblioteca HttpClient de .NET para crear y obtener usuarios a través de una API REST local.

## Descripción

El proyecto muestra cómo realizar solicitudes HTTP utilizando HttpClient para interactuar con una API REST local que permite la creación y obtención de usuarios. El proyecto está escrito en C# y utiliza patrones de diseño y arquitectura de capas para organizar el código.

## Funcionalidades

- Creación de usuarios mediante solicitud HTTP POST.
- Obtención de todos los usuarios existentes mediante solicitud HTTP GET.
- Uso de HttpClient para realizar solicitudes HTTP a una API local.

## Requisitos Previos

- .NET 6 SDK instalado (puedes descargarlo [aquí](https://dotnet.microsoft.com/download/dotnet/6.0)).
- Conocimiento básico de C# y APIs REST.

## Instrucciones de Uso

1. Clona este repositorio en tu máquina local.

bash
git clone https://github.com/JDCen/UserGetCreate.git

Abre el proyecto en tu IDE preferido (Visual Studio, Visual Studio Code, etc.).

Ejecuta la aplicación para crear y obtener usuarios.

## Estructura del Proyecto
UserGetCreate/Controllers/UsersController.cs: Controlador que utiliza HttpClient para interactuar con la API de usuarios.
UserGetCreate/Models/Users.cs: Definición del modelo de usuarios.
UserGetCreate/Services/UserApiClient.cs: Clase que encapsula las llamadas HTTP a la API de usuarios.
UserGetCreate/Program.cs: Punto de entrada de la aplicación.
Contribuciones
Las contribuciones son bienvenidas. Si deseas agregar nuevas características, corregir errores o mejorar la documentación, por favor crea un pull request.


¡Disfruta utilizando HttpClient para interactuar con tu API local de usuarios! Si tienes alguna pregunta o inquietud, no dudes en crear un issue en este repositorio.