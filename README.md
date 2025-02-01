# Maze-Runners
# INFORME: THE SPIRIT TRAIL

## ❄️ UNO: Requerimientos para que el juego funcione correctamente
- Hecho en Windows, con .NET versión 9.0.100.
- Agregué librería: NAudio (para agregarla se utiliza el comando: dotnet add newpackage NAudio).
- Y librería: System.Threading (dotnet add new package System.Threading)
- Las funcionalidades de audio solo funcionan para Windows.
- Recomendable cargar el juego desde el escritorio para mejor funcionalidad de audio.

## ❄️ DOS: Funcionalidad
El objetivo del juego es enfrentarte al jefe que se encuentra en el medio del laberinto. Para ello, el token debe recoger uno de los objetos esparcidos aleatoriamente en el mapa.

1. Capacidad de jugadores: Se debe ingresar el nombre de los dos jugadores permitidos.
2. Selección de tokens: Cada jugador debe seleccionar tres tokens.
   - Para seleccionar un token, se utilizan las teclas: ⬆️⬇️ para moverse hacia arriba o abajo y luego se presiona Enter para seleccionar.
3. Mensajes en la consola: A medida que avanza el juego, aparecen mensajes que indican lo que se espera que haga el jugador.
4. Condición de victoria: Ocurre solamente cuando la vida del boss es cero.

## ❄️ TRES: Descripción de Componentes

### 1. Boss
- Archivo: Boss.cs
- Descripción: Define la clase Boss, que representa al enemigo principal del juego, Astharoth.
- Propiedades:
  - name
  - life
  - attack
  - position

#### Métodos implementados:
- Power: Describe el ataque especial del jefe, mostrando mensajes en la consola sobre su efecto en los jugadores.
- PresentationBoss: Presenta al jefe al jugador con advertencias sobre su peligrosidad.
- Fight Methods: Manejan ataques entre el jugador y el jefe, calculando daño e informando sobre la victoria.

### 2. Boxes
- Archivo: Boxes.cs
- Define dos enums para el laberinto:
  - Boxes: Incluye paths, obstacles, traps, etc.
  - Mask: Utilizado para generar el laberinto (walls, visited, unvisited).

### 3. Magic
- Archivo: Magic.cs
- Define la clase Magic con cuatro métodos:  
  - Sword
  - Elixir
  - Parchment
  - Charm
    En los cuales creo los beneficios que da recoger un objeto para derrotar al jefe, ademas tengo al metodo implementMagic donde implemento los objetos en el mapa
  
### 4. Maze
Este archivo .cs contiene la clase Maze, que se encarga de generar y gestionar la estructura del laberinto en el juego.
- Propiedad size: Define el tamaño del laberinto.

 #### Métodos:
- GenerateMaze: Crea el laberinto de forma procedimental usando el algoritmo Hunt and Kill.
- Métodos adicionales para recorrer la matriz y contar caminos libres y trampas (PathList) y (NumTraps).


### 5. Menu
- Archivo: Menu.cs
- Contiene la clase Menu con métodos para mostrar introducciones:
  - MainMenu
  - Intro

### 6. Methods
Este archivo .cs contiene la clase GameActions, que define los siguientes metodos:
- 1. Método fellInTrap: Este método se activa cuando un token cae en una trampa dentro del laberinto. La lógica principal incluye: Generar una lista de trampas posibles y seleccionar una al azar.
- 2.PrintMaze: Este método imprime el laberinto en la consola, utilizando símbolos específicos para representar diferentes tipos de casillas (como caminos, obstáculos y trampas). Esto proporciona una visualización clara del estado actual del laberinto.
- 3.DisplaySound: Se utiliza para agregarle audio 

  
### 7. Player
El archivo Player.cs define la clase Player, que representa a un jugador en un juego basado en un laberinto. Esta clase gestiona los tokens seleccionados por el jugador, su turno de juego 
y las interacciones con el entorno del laberinto. A continuación, se describen los componentes y la lógica detrás de cada uno.

#### Componentes Principales:
- 1. Propiedades de la Clase Player
Nombre: Almacena el nombre del jugador, lo que permite personalizar la experiencia de juego.
Tokens Seleccionados: Una lista que contiene los tokens que el jugador ha elegido para usar durante el juego.
Turno del Jugador: Un booleano que indica si es el turno del jugador actual, lo que es crucial para la secuencia de jugabilidad.
- 2. Constructor
El constructor inicializa las propiedades del jugador, asignando un nombre y estableciendo su turno. También inicializa la lista de tokens seleccionados como vacía.

#### Métodos Clave:
- 1. AddToken
Este método permite al jugador agregar un token a su lista de tokens seleccionados.
- 2. DisplayTokens
Este método muestra en la consola todos los tokens que el jugador ha seleccionado.
- 3. ValidPosition
Este método verifica si una posición específica en el laberinto es válida para moverse. Evalúa si la celda correspondiente en la matriz del laberinto permite el movimiento (por ejemplo, si es un camino, trampa o contiene objetos especiales). Esto asegura que el jugador no intente moverse a una posición no permitida.
- 4. SelectedAction
Este método gestiona las acciones del jugador basadas en la entrada proporcionada (W, A, S, D para moverse y E para usar habilidades del token). Calcula la nueva posición del token según la acción elegida y devuelve las coordenadas finales. Si se ingresa una acción no válida, lanza una excepción.


### 8. Tokens
El archivo Tokens.cs define una clase principal llamada Token, que representa una ficha en un juego. Esta clase incluye varias propiedades y métodos que permiten gestionar las características y habilidades de cada token. A continuación, se detallan los aspectos más relevantes:

#### Propiedades de la Clase Token:
- 1. Nombre y Tipo: Cada token tiene un nombre y un tipo que lo identifican.
- 2. Atributos: Incluye atributos como vida (life), ataque (attack), velocidad (speed), y habilidades especiales (ability).
- 3. Estado: Propiedades booleanas que indican el estado del token, como si está atrapado (trapped), si tiene magia, espada, elixir, entre otros.
- 4. Posición Actual: Un arreglo que guarda la posición actual del token en el juego.

#### Entre los metodos se encuentran:
- 1. DisplayInfo(): Muestra información sobre el token en la consola, incluyendo su nombre, tipo, vida, ataque y habilidades.
- 2. CanISuper: Devuelve true o false dependiendo de si un token puede usar su super o no
- 3. Attack(): Método estático que permite a un token atacar a un enemigo (en este caso, de "Astharoth"), gestionando el daño que hace.
- 4. GetDamage: Metodo estatico que gestiona la vida del token dependiendo del daño recibido del Boss.
- 5. Método Clave
Power(): Método virtual que permite a los tokens usar habilidades especiales.

En Tokens tambien hay subclases que heredan de Token, cada una sobrescribe el metodo clave para implementar su propia lógica para estas habilidades
### Subclases:
Force, Shield, Vous, Vitality, Crow y Cass.


### 9. Trap
El archivo Trap.cs define una estructura de clases relacionadas con trampas dentro de un laberinto. Estas trampas interactúan con los tokens y afectan su progreso en el laberinto. A continuación, se describe brevemente cada componente:

- Existe una Clase Base: Trap
La clase principal Trap representa una trampa genérica en el laberinto, contiene los siguientes métodos y lógica básica para activar trampas y distribuirlas aleatoriamente en el mapa:
1. Método Activate: Es un método virtual que define la lógica que ocurre cuando un token cae en una trampa. Las clases derivadas pueden sobrescribir este método para implementar trampas específicas.
2. Método implementedTraps: Coloca trampas en posiciones aleatorias del laberinto, asegurándose de que no estén adyacentes entre sí.

#### Clases que heredan:
Las siguientes clases heredan de Trap y representan tipos específicos de trampas, cada una con efectos únicos sobre los tokens:
1. Clase Boom: Representa una trampa explosiva que reduce la vida del token en 5 puntos si tiene suficiente vida. Si la vida es muy baja, el token es enviado a su punto de inicio para recuperarse.
2. Clase Teleport: Simula un teletransporte causado por un ave gigante. El token retrocede 5 pasos en su registro de movimientos o es enviado a su punto de inicio si no hay suficientes pasos registrados.
3. Clase BadLuck: El token es teletransportado directamente al punto de inicio del laberinto.

- Otros Componentes:
Interacción con el Laberinto (Boxes[,]): El archivo utiliza una matriz bidimensional para representar el laberinto. Las trampas se colocan en celdas específicas de esta matriz.
Interacción con Tokens: Las trampas afectan propiedades clave del token, como su vida, posición actual y estado (por ejemplo, si está atrapado).


### 10. Program 
Aquí se encuentra la funcionalidad del juego, donde se llaman a los métodos e inicializan los objetos, imprimiendo mensajes y visualizaciones en consola como el método PrintMaze.
