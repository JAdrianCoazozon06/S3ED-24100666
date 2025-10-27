# Investigación sobre Tipos de Estructuras de Datos
<br>

##  ¿Qué son las Estructuras de Datos?
Las estructuras de datos son formas organizadas de almacenar y gestionar información dentro de un programa, para que pueda ser utilizada de manera eficiente.
Permiten realizar operaciones como búsqueda, inserción, eliminación o modificación de datos de forma más rápida y ordenada.

Existen dos tipos principales:
* Estructuras de datos estáticas: tienen un tamaño fijo (por ejemplo, un array).
* Estructuras de datos dinámicas: pueden crecer o reducirse en tiempo de ejecución (por ejemplo, listas enlazadas, pilas o colas).
<br><br>

## Estructura de Datos Lineales

## 1. Arreglos
Definición:
Un arreglo es una colección de elementos del mismo tipo, almacenados en ubicaciones contiguas de memoria. Cada elemento se accede mediante un índice, comenzando generalmente desde cero.

Características:
* Homogeneidad: Todos los elementos deben ser del mismo tipo de dato.
* Acceso directo: Se puede acceder a cualquier elemento en tiempo constante usando su índice.
* Tamaño fijo: Una vez creado, no se puede cambiar su tamaño sin crear un nuevo arreglo.
* Eficiencia en lectura: Muy rápidos para leer datos, pero menos eficientes para insertar o eliminar elementos.

Ventajas:
* Simplicidad en la implementación.
* Acceso rápido a cualquier posición.
* Uso eficiente de memoria si el tamaño es conocido.

Desventajas:
* No se puede redimensionar dinámicamente.
* Insertar o eliminar elementos implica mover muchos datos.
* No es flexible para estructuras dinámicas.

## 2. Pilas (Stacks)
Definición:
Una pila es una estructura de tipo LIFO (Last In, First Out), donde el último elemento en entrar es el primero en salir. Se utiliza comúnmente para manejar operaciones reversibles o temporales.

Características:
* Operaciones básicas: push (insertar), pop (eliminar), peek (ver el tope).
* Acceso restringido: Solo se puede interactuar con el elemento en la cima.
* Uso en programación: Muy útil en algoritmos recursivos, evaluación de expresiones, y navegación de historial.

Ventajas:
* Control claro del flujo de datos.
* Ideal para tareas reversibles (como deshacer acciones).
* Fácil de implementar con listas o arreglos.

Desventajas:
* No permite acceso aleatorio a elementos internos.
* Limitada para estructuras que requieren más flexibilidad.
* Puede causar desbordamiento si no se gestiona bien el tamaño.

## 3. Colas (Queues)
Definición:
Una cola es una estructura FIFO (First In, First Out), donde el primer elemento en entrar es el primero en salir. Se utiliza en sistemas que requieren procesamiento ordenado.

Características:
* Operaciones principales: enqueue (agregar al final), dequeue (eliminar del frente).
* Acceso secuencial: Solo se puede acceder al primer elemento.
* Aplicaciones comunes: Gestión de procesos, impresión, atención al cliente.

Ventajas:
* Procesamiento justo y ordenado.
* Ideal para sistemas en tiempo real.
* Fácil de implementar con listas enlazadas o arreglos circulares.

Desventajas:
* No permite acceso aleatorio.
* Puede llenarse si no se gestiona correctamente.
* Inserciones y eliminaciones pueden ser costosas si no se usa una estructura eficiente.

## 4. Listas Enlazadas
Definición:
Una lista enlazada es una colección de nodos, donde cada nodo contiene un dato y una referencia (puntero) al siguiente nodo. Existen variantes como simplemente enlazada, doblemente enlazada y circular.

Características:
* Dinámicas: Pueden crecer o reducirse en tiempo de ejecución.
* Flexibilidad: Permiten inserciones y eliminaciones en cualquier parte de la lista.

Tipos:
* Simplemente enlazada: cada nodo apunta al siguiente.
* Doblemente enlazada: cada nodo apunta al anterior y al siguiente.
* Circular: el último nodo apunta al primero.

Ventajas:
* No requieren tamaño fijo.
* Eficientes para operaciones en medio de la lista.
* Buen rendimiento en inserciones y eliminaciones.

Desventajas:
* Acceso secuencial (no se puede acceder directamente a un nodo).
* Mayor uso de memoria por los punteros.
* Más complejas de implementar y mantener que los arreglos.

## Estructuras de Datos No Lineales
## 5. Grafos
Definición:
Un grafo es una estructura compuesta por nodos (vértices) y conexiones entre ellos (aristas). Puede ser dirigido (con sentido en las conexiones) o no dirigido.

Características:
* Representación de relaciones: Ideal para modelar redes, rutas, dependencias.

Tipos:
* Dirigido: las aristas tienen dirección.
* No dirigido: las aristas no tienen dirección.
* Ponderado: las aristas tienen un valor (peso).
* Almacenamiento: Se puede representar mediante listas de adyacencia o matrices de adyacencia.

Ventajas:
* Muy flexibles para modelar sistemas complejos.
* Permiten aplicar algoritmos como Dijkstra, BFS, DFS.
* Útiles en inteligencia artificial, redes sociales, mapas.

Desventajas:
* Complejos de implementar y visualizar.
* Requieren estructuras auxiliares para recorrerlos.
* Consumen más memoria si no se optimizan bien.

## 6. Árboles
Definición:
Un árbol es una estructura jerárquica donde cada nodo tiene cero o más hijos, y existe un único nodo raíz. No hay ciclos, y cada nodo tiene un único padre (excepto la raíz).

Características:
* Organización jerárquica: Ideal para representar estructuras como directorios o jerarquías.
Tipos comunes:
* Árbol binario: cada nodo tiene como máximo dos hijos.
* Árbol AVL: árbol binario balanceado.
* Árbol B: usado en bases de datos.

Recorridos: preorden, inorden, postorden.

Ventajas:
* Búsqueda eficiente en árboles balanceados.
* Representación clara de relaciones jerárquicas.
* Facilita operaciones como inserción, eliminación y búsqueda.

Desventajas:
* Difíciles de mantener balanceados.
* Inserciones y eliminaciones pueden requerir reestructuración.
* Mayor complejidad en implementación que listas o arreglos.

## Estructuras de Datos Abstractas
## 7. Conjunto (Set)
Definición:
Un conjunto es una colección de elementos únicos, sin orden específico. No permite duplicados y se basa en operaciones matemáticas de teoría de conjuntos.

Características:
* Unicidad: No se pueden repetir elementos.
* Operaciones comunes: unión, intersección, diferencia, pertenencia.
* Implementación: Se puede usar tablas hash o árboles balanceados.

Ventajas:
* Ideal para verificar si un elemento existe.
* Operaciones matemáticas eficientes.
* Útil en problemas de lógica y teoría de conjuntos.

Desventajas:
* No garantiza orden de los elementos.
* No permite duplicados, lo que puede ser una limitación.
* Puede consumir más memoria si se usa hashing.

8. Diccionario (Map)
Definición:
Un diccionario es una estructura que almacena pares clave-valor, donde cada clave es única y se asocia a un valor. Es muy útil para búsquedas rápidas.

Características:
* Acceso por clave: Se puede obtener el valor asociado a una clave en tiempo constante (con hashing).
* Claves únicas: No se pueden repetir.
* Aplicaciones: bases de datos, configuración, almacenamiento de propiedades.

Ventajas:
* Búsqueda rápida y eficiente.
* Organización clara de datos.
* Flexible para representar relaciones.

Desventajas:
* Mayor uso de memoria por estructuras internas.
* No garantiza orden de inserción (a menos que se use un diccionario ordenado).
* Puede ser complejo si se requiere ordenamiento o búsqueda por valor.