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
- Entorno de desarrollo: Visual Studio (abrir la solución con la versión que prefieras; Visual Studio 2019/2022 recomendado)
- Plataforma: .NET (la versión exacta está indicada en la solución/proyecto)

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
- /tests - pruebas (si aplica)
- README.md - este archivo

Ajusta las carpetas según la estructura real del proyecto.

## Guía rápida de diseño (POO)

- Entidades principales: Cliente, Proveedor, Empleado, Administrador, Producto (Videojuego/Consola), Inventario, ContratoRenta
- Relación típica: Empleado/Administrador gestiona Inventario; Cliente crea ContratoRenta sobre Productos
- Usa herencia para tipos de usuario y composición para relacionar contratos con productos

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