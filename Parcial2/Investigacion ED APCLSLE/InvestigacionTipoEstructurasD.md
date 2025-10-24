# Investigación sobre Tipos de Estructuras de Datos
<br>

## 1. ¿Qué son las Estructuras de Datos?
Las estructuras de datos son formas organizadas de almacenar y gestionar información dentro de un programa, para que pueda ser utilizada de manera eficiente.
Permiten realizar operaciones como búsqueda, inserción, eliminación o modificación de datos de forma más rápida y ordenada.

Existen dos tipos principales:
* Estructuras de datos estáticas: tienen un tamaño fijo (por ejemplo, un array).
* Estructuras de datos dinámicas: pueden crecer o reducirse en tiempo de ejecución (por ejemplo, listas enlazadas, pilas o colas).
<br><br>

## 2. Array (Arreglo)
<br>
Definición:
Un array es una colección de elementos del mismo tipo (por ejemplo, todos enteros o todos caracteres), almacenados en posiciones contiguas de memoria.

Funcionamiento:
Cada elemento se identifica por un índice, que indica su posición dentro del arreglo.
Ejemplo en pseudocódigo:
array numeros[5] = [10, 20, 30, 40, 50]
numeros[0] = 10
numeros[1] = 20

Ventajas:
Acceso rápido a los elementos mediante el índice.
Fácil de recorrer con bucles.

Desventajas:
Tamaño fijo.
Insertar o eliminar elementos es costoso, ya que hay que mover datos.

Usos comunes:
Almacenar listas de datos como nombres, notas o edades.
<br><br>

## 3. Pilas (Stacks)
<br>
Definición:
Una pila es una estructura de datos LIFO (Last In, First Out), donde el último elemento que entra es el primero que sale.

Funcionamiento:
Solo se puede insertar o eliminar un elemento por el extremo llamado tope (top).

Operaciones básicas:
push: agrega un elemento al tope.
pop: elimina el elemento del tope.
peek o top: muestra el elemento del tope sin eliminarlo.

Ejemplo de funcionamiento:

Pila: [ ]
push(10) → [10]
push(20) → [10, 20]
pop()    → [10] (sale el 20)


Usos comunes:
Deshacer acciones en programas (Ctrl+Z).
Manejo de llamadas a funciones (pila de ejecución).
Evaluación de expresiones matemáticas.
<br><br>

## 4. Colas (Queues)
<br>
Definición:
Una cola es una estructura FIFO (First In, First Out), donde el primer elemento en entrar es el primero en salir.

Funcionamiento:
Tiene dos extremos:
Frente (front): donde se elimina el elemento.
Final (rear): donde se inserta un nuevo elemento.

Operaciones básicas:
enqueue: agrega un elemento al final.
dequeue: elimina el elemento del frente.

Ejemplo de funcionamiento:
Cola: [ ]
enqueue(5) → [5]
enqueue(10) → [5, 10]
dequeue() → [10] (sale el 5)


Usos comunes:
Control de procesos en sistemas operativos.
Colas de impresión o atención de clientes.
Transmisión de datos en redes.
<br><br>

## 5. Listas Simples y Enlazadas
<br>
Definición:
Una lista enlazada es una estructura de datos dinámica formada por nodos.
Cada nodo contiene:
Un dato.
Una referencia (puntero) al siguiente nodo.

Tipos:
Lista simple: cada nodo apunta al siguiente.
Lista doblemente enlazada: cada nodo apunta al anterior y al siguiente.
Lista circular: el último nodo apunta al primero.
Funcionamiento de una lista simple:

[Dato | Apuntador] → [Dato | Apuntador] → [Dato | -1 o null]


Ventajas:
Tamaño dinámico (crece o se reduce).
Insertar o eliminar elementos es más fácil que en un array.

Desventajas:
Acceso secuencial (no se puede acceder por índice).
Mayor uso de memoria por los punteros.

Usos comunes:
Manejo de memoria dinámica.
Implementar pilas o colas.
Representar listas de tareas o elementos enlazados.

Conclusión

Las estructuras de datos son esenciales en la programación, ya que determinan la eficiencia del código y el uso óptimo de la memoria.
Cada estructura tiene un propósito distinto:
Arrays: almacenamiento ordenado y acceso rápido.
Pilas: control de orden inverso (LIFO).
Colas: procesamiento en orden (FIFO).
Listas enlazadas: manejo flexible de datos dinámicos.