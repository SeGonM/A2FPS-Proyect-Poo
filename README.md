# A2FPS - Proyecto POO

Sistema de una tienda de renta de videojuegos y consolas desarrollado como proyecto de Programación Orientada a Objetos (semestre 5).

## Descripción

Este proyecto implementa una aplicación de escritorio para gestionar la renta y el préstamo de videojuegos y consolas. Permite administrar clientes, proveedores, empleados y administradores, así como los inventarios, contratos de renta, devoluciones y reportes básicos.

La intención es aplicar conceptos de POO (clases, herencia, polimorfismo, encapsulación), patrones básicos de diseño y una interfaz gráfica con Windows Forms.

## Actores principales

- Clientes
- Proveedores
- Empleados
- Administradores

## Tecnologías

- Lenguaje: C#
- Interfaz: Windows Forms
- Entorno de desarrollo: Visual Studio
- Plataforma: .NET

## Requisitos

- Windows 10/11
- Visual Studio con soporte para Windows Forms y C#
- .NET Runtime/SDK según la versión del proyecto

## Instalación y ejecución

1. Clona el repositorio:

   git clone https://github.com/SeGonM/A2FPS-Proyect-Poo.git

2. Abre la solución (.sln) en Visual Studio.
3. Compila la solución (Build → Build Solution).
4. Ejecuta el proyecto principal (Start Debugging o Start Without Debugging).

## Funcionalidades (planificadas / implementadas)

- Registro y gestión de clientes
- Registro y gestión de proveedores
- Gestión de empleados y permisos
- Inventario de consolas y videojuegos
- Crear contratos de renta / devoluciones
- Búsqueda y filtrado de productos
- Reportes básicos (rentas activas, historial por cliente, stock bajo)

(Detalla en el código qué está implementado y qué está pendiente.)

## Estructura del repositorio

- /src - código fuente del proyecto (solución de Visual Studio)
- /docs - documentación adicional (si aplica)
- /docs/images - diagramas y mapas (añade aquí las imágenes: process.png, impact_map.png) (opcional)
- /tests - pruebas (si aplica)
- README.md - este archivo

Ajusta las carpetas según la estructura real del proyecto.

## Guía rápida de diseño (POO)

- Entidades principales: Cliente, Proveedor, Empleado, Administrador, Producto (Videojuego/Consola), Inventario, ContratoRenta
- Relación típica: Empleado/Administrador gestiona Inventario; Cliente crea ContratoRenta sobre Productos
- Usa herencia para tipos de usuario y composición para relacionar contratos con productos

## Mapas y diagramas

A continuación se incluyen los diagramas que contextualizan el flujo de operación y el mapa de impacto del proyecto. Añade los archivos de imagen en `/docs/images/` con los nombres recomendados para que se muestren correctamente si lo deseas.

### 1) Proceso de operación (diagrama por actores)

Resumen: Diagrama de flujo por actores (Cliente, Empleado, Administrador, Proveedor) que muestra los pasos principales desde la búsqueda de productos y creación de un alquiler hasta la devolución, verificación de estado y generación de multas si aplica. Indica también las interacciones con la base de datos y las decisiones críticas (producto disponible, retraso en la devolución).

## Objetivo, Alcance y Flujo de Operación

### Objetivo y alcance
- Objetivo: Ofrecer un servicio de alquiler de videojuegos y consolas eficiente, seguro y confiable que mejore la experiencia del cliente y permita una gestión clara del inventario y las transacciones.
- Alcance: Aplicación de escritorio para empleados/administradores y portal/login para clientes y proveedores. Funcionalidades principales: catálogo, alquileres, devoluciones, control de stock, generación de multas y reportes operativos.

### Flujo de operación (resumen por actor)

- Cliente:
  1. Iniciar sesión o registrarse.
  2. Buscar por categoría o plataforma.
  3. Ver detalle del producto (precio, estado, descripción).
  4. Si el producto está disponible: confirmar alquiler (fecha inicio/devolución).
  5. Consultar historial de alquileres.

- Empleado:
  1. Iniciar sesión.
  2. Consultar inventario y verificar disponibilidad.
  3. Registrar alquileres y entregar producto.
  4. Registrar devoluciones y verificar estado.
  5. Generar multas y registrar incidencias si hay retrasos o daños.

- Administrador:
  - Gestión completa de catálogo, categorías, alquileres, multas, promociones y reportes; administración de usuarios y permisos.

- Proveedor:
  - Registrar productos ofrecidos, actualizar stock y estado, y consultar el historial de productos suministrados.

### Convenciones (leyenda)
- Símbolos y convenciones en los diagramas: Inicio/Fin, acción del cliente/empleado/administrador/proveedor, decisión (ej. producto disponible), base de datos, flujo principal y consultas/actualizaciones a BD.
- Interacciones con la base de datos: registro de alquileres, devoluciones, multas, actualizaciones de stock, historial de clientes y productos.

## Impacto y entregables

- Entregables clave: catálogo de juegos y consolas, búsqueda y filtros por categoría/plataforma, proceso de alquiler simplificado, notificaciones, reportes (ventas, inventario, historial por cliente), control de inventario y gestión de usuarios/permisos.
- Impacto esperado: acelerar y organizar los procesos de alquiler y devolución, reducir errores de inventario, facilitar la toma de decisiones mediante reportes y mejorar la experiencia del cliente.

## Cómo contribuir

1. Crea una fork del repositorio.
2. Crea una rama con la nueva funcionalidad: `feature/nombre-funcionalidad`.
3. Haz commits claros y descriptivos.
4. Abre un pull request describiendo los cambios.

## Notas para la entrega

- Incluye un documento que explique las clases principales, diagramas simples (UML) y casos de uso.
- Indica qué funcionalidad está completa y qué está pendiente.

## Licencia

Indica aquí la licencia del proyecto (por ejemplo, MIT) o los términos que el curso requiera.

---

Proyecto desarrollado como ejercicio académico de Programación Orientada a Objetos (semestre 5).
