# Maze-Runners
# INFORME: THE SPIRIT TRAIL

## ❄️ UNO: Requerimientos para que el juego funcione correctamente
- Hecho en Windows, con .NET versión 9.0.100.
- Agregué una única librería: NAudio (para agregarla se utiliza el comando: dotnet add newpackage NAudio).
- Las funcionalidades de audio solo funcionan para Windows.

## ❄️ DOS: Funcionalidad
El objetivo del juego es enfrentarte al jefe que se encuentra en el medio del laberinto. Para ello, el token debe recoger uno de los objetos esparcidos aleatoriamente en el mapa.

1. Descripción de la historia del juego: Se debe ingresar el nombre de los dos jugadores permitidos.
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
  
### 4. Maze
- Archivo: Maze.cs
- Contiene la clase Maze, encargada de generar y gestionar la estructura del laberinto.
  
#### Métodos:
- GenerateMaze: Crea el laberinto de forma procedimental usando el algoritmo Hunt and Kill.
- Métodos adicionales para recorrer la matriz y contar caminos libres y trampas.

### 5. Menu
- Archivo: Menu.cs
- Contiene la clase Menu con métodos para mostrar introducciones:
  - MainMenu
  - Intro

### 6. Methods
- Archivo: GameActions.cs
- Define métodos como:
  - fellInTrap: Activa cuando un token cae en una trampa.
  - PrintMaze: Imprime el laberinto en la consola con símbolos específicos.
  
### 7. Player
- Archivo: Player.cs
- Define la clase Player, que representa a un jugador en el laberinto.

#### Componentes Principales:
1. Propiedades:
   - Nombre del jugador.
   - Tokens seleccionados.
   - Turno del jugador.

2. Constructor:
   - Inicializa propiedades y lista de tokens seleccionados.

#### Métodos Clave:
- AddToken
- DisplayTokens
- ValidPosition
- SelectedAction

### 8. Tokens
- Archivo: Tokens.cs
- Define la clase principal Token con propiedades y métodos relevantes.

#### Subclases:
Incluyen características únicas y sobrescriben métodos clave.

### 9. Trap
- Archivo: Trap.cs
- Define clases relacionadas con trampas en el laberinto.

#### Clases que heredan:
1. Clase Boom
2. Clase Teleport
3. Clase BadLuck

### 10. Program 
Aquí se encuentra la funcionalidad del juego, donde se llaman a los métodos e inicializan los objetos, imprimiendo mensajes y visualizaciones en consola como el método PrintMaze.
