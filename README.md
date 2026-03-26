# Proyecto integrador en C# .NET

## Descripción general

Este repositorio contiene un **proyecto integrador de consola desarrollado en C#**.  
Su finalidad es simular un **formulario de inscripción de alumnos** y la posterior **selección de cursadas**, aplicando contenidos introductorios de programación vistos de manera progresiva.

Se trata de un material adecuado para **estudio, repaso y práctica**, ya que concentra conceptos fundamentales como:

- variables
- entrada y salida por consola
- estructuras condicionales
- estructuras repetitivas
- arreglos
- métodos auxiliares
- organización básica de un programa

---

## Objetivo académico

El propósito del proyecto es construir una solución simple, incremental y comprensible que permita:

1. registrar los datos básicos de un alumno;
2. confirmar la información ingresada;
3. seleccionar cursos desde un menú;
4. evitar la duplicación de cursadas;
5. emitir una constancia final por consola.

---

## Contexto del ejercicio

El sistema representa un prototipo de inscripción académica en formato consola.  
La elección de este formato responde a un enfoque inicial de aprendizaje, priorizando:

- rapidez de implementación;
- facilidad de prueba;
- claridad en la lógica;
- comprensión de los fundamentos del lenguaje.

---

## Tecnologías utilizadas

- **C#**
- **.NET**
- **Visual Studio**

---

## Estructura del repositorio

### Descripción de carpetas

- `integrador/`: contiene el código fuente principal del proyecto.
- `modules/`: material complementario de estudio en formato PDF.
- `README.md`: documentación general del repositorio.

---

## Funcionamiento del programa

El flujo principal de la aplicación es el siguiente:

1. Se solicita al usuario:
   - nombre
   - apellido
   - edad
   - correo electrónico

2. Se muestran los datos ingresados para su confirmación.

3. Si la confirmación es positiva, se habilita un menú de selección de cursadas:
   - `1. Programación .NET`
   - `2. Programación JAVA`
   - `3. Programación PHP`
   - `0. Salir`

4. El sistema registra las cursadas elegidas.

5. Se evita seleccionar la misma cursada más de una vez.

6. Finalmente, se imprime una constancia con los datos del alumno y las cursadas registradas.

---

## Conceptos de programación aplicados

### 1. Variables y tipos de datos
Se utilizan variables para almacenar información personal del alumno y opciones del sistema.

### 2. Entrada y salida por consola
La interacción se realiza mediante `Console.Write`, `Console.WriteLine` y `Console.ReadLine`.

### 3. Condicionales
Se usa `if` para validar confirmaciones y `switch` para resolver opciones del menú.

### 4. Bucles
Se emplea `do while` para repetir el menú hasta que el usuario decida salir.

### 5. Arreglos
Se utilizan arreglos para:
- definir los cursos disponibles;
- almacenar las cursadas seleccionadas.

### 6. Métodos auxiliares
La clase `Helper` incorpora un método para ubicar una posición libre dentro del arreglo de cursadas.

---

## Evolución del desarrollo

El repositorio refleja una construcción por etapas:

### Etapa 1
Captura de datos del alumno y visualización por consola.

### Etapa 2
Incorporación del menú de selección de cursadas.

### Etapa 3
Control de duplicados y asignación de cursos en espacios disponibles.

---

## Aspectos positivos del proyecto

- Presenta una lógica clara y lineal.
- Permite practicar fundamentos esenciales de C#.
- Es apropiado como ejercicio introductorio.
- Muestra una evolución progresiva del desarrollo.

---

## Aspectos a mejorar

Desde un enfoque académico, este proyecto puede enriquecerse con las siguientes mejoras:

- validar entradas numéricas con `int.TryParse`;
- validar respuestas vacías o nulas;
- separar responsabilidades en más métodos;
- mejorar nombres de métodos según convención de C#;
- evitar imprimir la constancia si la inscripción fue cancelada;
- reemplazar arreglos fijos por colecciones más flexibles;
- incorporar comentarios técnicos o documentación XML.

---

## Ejecución

1. Abrir la solución o proyecto en **Visual Studio**.
2. Ejecutar la aplicación de consola.
3. Ingresar los datos solicitados.
4. Confirmar la información.
5. Seleccionar las cursadas deseadas.
6. Finalizar y revisar la constancia generada.

---

## Valor de estudio

Este proyecto resulta útil para estudiar:

- sintaxis básica de C#;
- control de flujo;
- manipulación de arreglos;
- interacción por consola;
- descomposición elemental de lógica en métodos.

Es especialmente conveniente como base para luego avanzar hacia:

- validaciones robustas;
- orientación a objetos;
- listas y colecciones;
- manejo de excepciones;
- capas de aplicación más organizadas.

---

## Conclusión

El proyecto constituye un **buen ejercicio integrador de nivel inicial**, centrado en la construcción de una aplicación de consola simple pero funcional.  
Su principal valor académico reside en que permite observar de forma concreta cómo se combinan estructuras básicas del lenguaje para resolver un problema de inscripción y selección de cursadas.