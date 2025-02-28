# Catálogo de Videojuegos

Este proyecto es una aplicación de escritorio desarrollada en C# con Windows Forms que simula un catálogo de videojuegos. Permite a los usuarios explorar y adquirir juegos, y a los administradores gestionar el catálogo y los usuarios.

## Funcionalidades

* **Usuarios:**
    * Iniciar sesión con usuario y contraseña.
    * Explorar el catálogo de videojuegos.
    * Ver detalles de un juego.
    * Comprar juegos.
    * Ver la biblioteca de juegos adquiridos ("Mis juegos").
* **Administradores:**
    * Iniciar sesión con usuario y contraseña de administrador.
    * Gestionar usuarios (crear, buscar).
    * Gestionar el catálogo de juegos (agregar, editar, eliminar).

## Tecnologías utilizadas

* C#
* Windows Forms (.NET Framework)
* MySQL (base de datos)
* Git (control de versiones)
* Visual Studio

## Instalación

1.  Clonar el repositorio:

    ```bash
    git clone URL_DEL_REPOSITORIO
    ```

2.  Abrir la solución `CatalogoJuegos.sln` con Visual Studio.
3.  Restaurar los paquetes NuGet necesarios.
4.  Configurar la conexión a la base de datos MySQL en el archivo `DatabaseHelper.cs`.
5.  Compilar y ejecutar la aplicación.

## Uso

* Consulta el [Manual de usuario](MANUAL_USUARIO.md) para obtener instrucciones detalladas sobre cómo utilizar la aplicación.

## Contribución

Si deseas contribuir a este proyecto, sigue estos pasos:

1.  Haz un fork del repositorio.
2.  Crea una rama para tu contribución:

    ```bash
    git checkout -b nombre-de-la-rama
    ```

3.  Realiza los cambios y haz un commit:

    ```bash
    git commit -m "Descripción de los cambios"
    ```

4.  Sube los cambios a tu fork:

    ```bash
    git push origin nombre-de-la-rama
    ```

5.  Crea un pull request.

## Licencia

Este proyecto está bajo la licencia \[LICENCIA].

## Contacto

Si tienes alguna pregunta o sugerencia, no dudes en contactarme a través de
