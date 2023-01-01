# SistemaPuntoVenta
Este es un sistema de punto de venta desarrollado en **C#** y con una base de datos en **SQL Server**.

## Descripción del proyecto
Este proyecto está diseñado para llevar el control de ventas y existencias de un negocio. Permite realizar ventas, generar reportes y llevar un registro de los productos y categorías disponibles en el inventario.

## Características principales
Registro de ventas
Registro de productos y categorías
Generación de reportes de ventas
Llevar el control de existencias de los productos
Gestión de usuarios y permisos de acceso

## Requisitos
Para poder utilizar este sistema, necesitarás tener instalado:

C# y .NET Framework
SQL Server

## Instrucciones de instalación
Descarga o clona el repositorio en tu equipo.
Abre el proyecto en Visual Studio.
En la carpeta `Database`, encontrarás el script de creación de la base de datos. Ejecútalo en SQL Server para crear la base de datos.
En la carpeta `App_Data`, encontrarás el archivo `config.json`. Abre este archivo y configura la cadena de conexión a la base de datos creada en el paso anterior.
Compila y ejecuta el proyecto en Visual Studio.

## Funcionalidades
A continuación se detallan algunas de las funcionalidades disponibles en el sistema:

### Registro de ventas
El sistema permite realizar ventas y llevar un registro de ellas. Se puede seleccionar el producto a vender, ingresar la cantidad y el sistema calculará el precio total de la venta.

### Registro de productos y categorías
Se pueden agregar, modificar y eliminar productos y categorías en el inventario. Para cada producto se puede ingresar información como el nombre, la categoría, el precio y la cantidad disponible en el inventario.

### Generación de reportes
El sistema permite generar reportes de ventas. Se puede filtrar por fecha y ver el monto total de ventas realizadas en ese rango de tiempo.

### Control de existencias
El sistema lleva un control de las existencias de los productos. Cuando se realiza una venta, se actualiza la cantidad disponible del producto. También se puede realizar un ajuste manual de las existencias de un producto.

### Gestión de usuarios
El sistema permite crear y eliminar usuarios y asignar permisos de acceso. Existen diferentes niveles de permisos, desde usuarios con acceso limitado hasta administradores con acceso total al sistema.

## Diseño y tecnologías utilizadas
El sistema está desarrollado en C# y utiliza .NET Framework como plataforma. Se ha utilizado la arquitectura MVC (Modelo-Vista-Controlador) para separar la lógica de negocio de la interfaz de usuario.

Para la base de datos se ha utilizado SQL Server y se ha utilizado Entity Framework como ORM (Mapeador de Objetos-Relacional) para facilitar la comunicación entre el sistema y la base de datos.

## Contribuciones
Si deseas contribuir al proyecto, puedes hacerlo a través de pull requests en el repositorio. Asegúrate de seguir las pautas de estilo y de documentar adecuadamente tus cambios.
