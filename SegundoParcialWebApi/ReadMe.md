# La arqitectura que ese usó es la arquitectura limpia. 
	Se seleccionó porque nos brinda un modelo que nos ayuda a ordenar los archivos de la aplicación de modo que las dependencias estén bien controladas, los cambios sean más fáciles de hacer y la lógica de negocio quede aislada de detalles tecnológicos (bases de datos, frameworks, etc.). Esta tendría las siguientes capas: 
	El dominio (los modelos), luego los 
	La aplicación (los DTOs y servicios)
	La infraestructura (AppDbContext)
	La presentación o API 
	En resumen, el proyecto se hace mucho más entendible y modificable