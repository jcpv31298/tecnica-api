# 📚 Reto Técnico - API REST Book Management

Este repositorio está destinado a la entrega de un **ejercicio práctico** de desarrollo.  
El objetivo es que el candidato implemente una **API REST** para gestionar un recurso `Book`, siguiendo buenas prácticas de diseño y desarrollo de software.

---

## 📝 Instrucciones del reto

El candidato debe crear un API REST que gestione un recurso **Book**, con los siguientes campos mínimos:

- **Id** (GUID)  
- **Title** (string, obligatorio)  
- **Author** (string, obligatorio)  
- **ISBN** (string, opcional)  
- **PublishedDate** (DateTime, opcional)  
- **Summary** (string, opcional)  

La persistencia puede implementarse **en memoria** o mediante una colección simulada.

Tendrás la libertad de elegir los nombres y definición de clases, variables y métodos, demostrando tu estilo y buenas prácticas.

Podrás aplicar sus conocimientos sobre diseño de API REST, estándares de la industria, y buenas 
prácticas de desarrollo. 

---

## 🔧 Requisitos mínimos

La API debe exponer los siguientes **endpoints CRUD**:

- **Listar todos los libros**
- **Obtener un libro por Id** 
- **Crear un libro**  
- **Actualizar totalmente un libro**
- **Eliminar un libro** 

### Consideraciones adicionales
- Implementa validaciones básicas para los campos obligatorios
- Manejo adecuado de errores con mensajes claros.  
- Uso de **códigos de estado HTTP** apropiados:
  - `200 OK`, `201 Created`, `400 Bad Request`, `404 Not Found`, `500 Internal Server Error`. 
- Documentación mínima de la API (ej. comentarios en el código, uso de **Swagger/OpenAPI** si el tiempo lo permite).  

---

## ⏱️ Tiempo estimado

El ejercicio debe realizarse en aproximadamente **30 - 40 minutos**.  
Al finalizar, se debe **subir el código fuente a este repositorio**.

Repositorio original: [https://github.com/eMaresSW/tecnica-api](https://github.com/eMaresSW/tecnica-api)  

---

## 📌 Notas para el candidato

- Este repositorio se entrega vacío.  
- Se espera que agregues tu **solución completa** dentro de este repositorio (proyecto, código fuente y archivos necesarios para compilar y ejecutar).  
- Se evaluará principalmente:
  - Correcta implementación del CRUD.  
  - Buenas prácticas de desarrollo y estilo de código.  
  - Manejo de errores y validaciones.  
  - Claridad en la estructura del proyecto y documentación mínima.  

---
