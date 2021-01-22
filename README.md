-----------------------------------------------------
---------------------  READ ME  ---------------------
-----------------------------------------------------

Requisitos:
- Disponer de Docker instalado en el equipo

A continuación se explican los pasos a seguir para ejecutar el servicio web:


	Arrancar la aplicación:
	-----------------------

		1 - Entrar en la carpeta "source"
		2 - Abrir un terminal en esta carpeta
		3 - Lanzar el comando "docker-compose up" y esperar a su lanzamiento (suele tardar unos 10 minutos)
		4 - La aplicacion se ha desplegado en el puerto 8085 de la maquina, formas de acceder:
			4.1 - URL base: https://localhost:8085
			4.2 - URL swagger: https://localhost:8085/swagger/index.html


	Como obtener el token JWT:
	--------------------------

		1- Generar el token: realizar una llamada POST, el cual tiene dos parámetros, usuario y password. Actualmente no existe ninguna validación de este login así que cualquier combinación de usuario y contraseña generara el token JWT. 

			- Endpoint: https://localhost:8085/v1/auth/login
			- Ejemplo de llamada: https://localhost:8085/v1/auth/login?user=user&password=password
			- Ejemplo de curl: curl -X POST "https://localhost:8085/v1/auth/login?user=user&password=password" -H  "accept: text/plain" -d ""

		2- Uso del token: Será necesario utilizar dicho token en todas las llamadas, para ello:
			
			- Mediante swagger: Existe un botón en la parte superior derecha (justo arriba de los endpoints) que pone "Authorize", clicando ahí nos aparecerá una ventana, en la cual escribiremos lo siguiente en el campo de value: "Bearer {token_generado_previamente}"
				- Ejemplo: Bearer eyJhbGciOiJIUzUxMiIsInR5cCI6IkpXVCJ9.eyJyb2xlIjoiRGV2b25TYW1wbGVVc2VyUm9sZSIsInVuaXF1ZV9uYW1lIjoidXNlciIsIm5hbWVpZCI6IjM3NjEyZmFjLWExN2MtNDE0YS1iYjFiLWNmMjQwYjllMGZlMyIsIm5iZiI6MTYxMTMxMjcyMiwiZXhwIjoxNjExMzEzMDIyLCJpYXQiOjE2MTEzMTI3MjIsImlzcyI6ImRldm9uNE5ldCIsImF1ZCI6ImRldm9uNE5ldCJ9.Sv1X4UaU6xC8GzHDEJHhTDgq2iCrKkyXc0zrMSUeOw6GPYuL9HdpgM8c5axXrMml319F5Zexpqurh9txu9d7-Q

			- Uso de otras herramientas: Se añadirá el siguiente header en la llamada:
				Authorization Bearer {token_generado_previamente}


	Acceder a la base de datos:
	---------------------------

		- Puerto: 5902
		- Nombre de la base de datos: AEL
		- Usuario de la base de datos: postgres
		- Password de la base de datos: changeme