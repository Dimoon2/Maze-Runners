using System;
using System.Drawing;
using Microsoft.VisualBasic;
public class Maze
{
    public static int size = 23;
    public Boxes[,] GenerateMaze()
    {

        //     Boxes[,] maze = {
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path, Boxes.path, Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.path, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path, Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle, Boxes.obstacle, Boxes.obstacle,Boxes.path,Boxes.path,Boxes.trap,Boxes.Astharoth,Boxes.path, Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.trap,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.trap,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.path,Boxes.obstacle,Boxes.trap,Boxes.path,Boxes.path,Boxes.obstacle},
        //     {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle},

        //       };
        //     return maze;

        //HUNT AND KILL :)
        //INITIALIZATION:
        //1. laberinto generico dividido por habitaciones:
        Boxes[,] maze =
        {
            {Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall, Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle, Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.wall },
            {Boxes.wall,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle, Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.wall},
            {Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall, Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall,Boxes.wall },


        };
        //mascara para facilitar el algoritmo:
        Mask[,] mask =
        {
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },


        };
        int Count = 0;
        //Lista de caminos no visitados:
        List<int[]> unvisited = new List<int[]>();
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (maze[i, j] == Boxes.path)
                //esto es una habitacion
                {
                    Count++;
                    unvisited.Add(new int[] { i, j });

                }
            }
        }


        //KILL MODE:
        //3. seleccion de habitacion random de la lista de visitadas:
        Random randomIndex = new Random();
        int index = randomIndex.Next(unvisited.Count);

        int[] selectedCell = unvisited[index];

        //4.Marcar la random como visitada:
        mask[selectedCell[0], selectedCell[1]] = Mask.visited;
        Count--;

        //crear lista de direcciones:
        List<int[]> Direction = new List<int[]>();
        Direction.Add(new int[] { -1, 0 });
        Direction.Add(new int[] { 1, 0 });
        Direction.Add(new int[] { 0, -1 });
        Direction.Add(new int[] { 0, 1 });

        //5.seleccionar un vecino random adyacente:
        while (Count > 0)
        {

            //escojo random direction para moverme
            int indexOfDir = randomIndex.Next(Direction.Count);
            int[] Dir = Direction[indexOfDir];

            //este es el vecino
            int[] adjacentCell = [selectedCell[0] + Dir[0] + Dir[0], selectedCell[1] + Dir[1] + Dir[1]];


            //6.Verificar limites:
            if (adjacentCell[0] >= 1 && adjacentCell[0] < size - 1 && adjacentCell[1] >= 1 && adjacentCell[1] < size - 1)
            {

                //7. Comprobar que el seleccionado pertenezca a la lista de no visitados.
                while (Direction.Count > 0)
                {


                    //ver si elvecino es no visitado
                    if (mask[adjacentCell[0], adjacentCell[1]] == Mask.unvisited)
                    {
                        //7.rompo pared entre donde estoy y mi vecino
                        maze[selectedCell[0] + Dir[0], selectedCell[1] + Dir[1]] = Boxes.path;

                        //8.Marcar adjacentCell como visitada:
                        mask[adjacentCell[0], adjacentCell[1]] = Mask.visited;
                        Count--;

                        //9.Me muevo para la celda vecina:
                        selectedCell[0] = adjacentCell[0];
                        selectedCell[1] = adjacentCell[1];

                        //vaciar lista de Direction
                        Direction = new List<int[]>();
                        //la lleno:
                        Direction.Add(new int[] { -1, 0 });
                        Direction.Add(new int[] { 1, 0 });
                        Direction.Add(new int[] { 0, -1 });
                        Direction.Add(new int[] { 0, 1 });
                        break;
                    }
                    else
                    {
                        Direction.RemoveAt(indexOfDir);
                        break;
                    }


                }
            }
            else
            {
                Direction.RemoveAt(indexOfDir);
            }

            //booleano false para saber cuando parar el hunt mode:
            bool found = false;
            //HUNT MODE:
            while (Direction.Count == 0)
            {
                for (int i = 1; i < size - 1; i++)
                {
                    for (int j = 1; j < size - 1; j++)
                    {
                        //buscamos un unvisited y revisamos q tenga algun vecino como visitado para cavar la pared:
                        if (mask[i, j] == Mask.unvisited)
                        {
                            if (i - 2 >= 1 && i - 2 < size - 2 && j >= 1 && j < size - 2)
                            {
                                if (mask[i - 2, j] == Mask.visited)
                                {
                                    //rompo pared en el medio
                                    maze[i - 1, j] = Boxes.path;
                                    //la escojo y marco como visited
                                    mask[i, j] = Mask.visited;
                                    Count--;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;


                                    found = true;
                                    break;
                                }
                            }
                            if (i + 2 >= 1 && i + 2 < size - 2 && j >= 1 && j < size - 2)
                            {
                                if (mask[i + 2, j] == Mask.visited)
                                {
                                    maze[i + 1, j] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    Count--;

                                    found = true;
                                    break;
                                }
                            }
                            if (i >= 1 && i < size - 2 && j - 2 >= 1 && j - 2 < size - 2)
                            {
                                if (mask[i, j - 2] == Mask.visited)
                                {
                                    maze[i, j - 1] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    Count--;

                                    found = true;
                                    break;
                                }
                            }
                            if (i >= 1 && i < size - 2 && j + 2 >= 1 && j + 2 < size - 2)
                            {
                                if (mask[i, j + 2] == Mask.visited)
                                {
                                    maze[i, j + 1] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    Count--;

                                    found = true;
                                    break;
                                }
                            }



                        }

                    }
                    if (found == true)
                    {
                        break;
                    }
                }
                break;
            }

            if (Direction.Count == 0)
            {
                Direction.Add(new int[] { -1, 0 });
                Direction.Add(new int[] { 1, 0 });
                Direction.Add(new int[] { 0, -1 });
                Direction.Add(new int[] { 0, 1 });
            }
            if (Count == 0)
            {
                break;
            }

        }
        return maze;
    }
    //metodo que recorre la matriz y que agrega a una lista los caminos libres
    public List<int[]> PathList(Boxes[,] maze)
    {
        List<int[]> paths = new List<int[]>();

        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (maze[i, j] == Boxes.path)
                {
                    paths.Add(new int[] { i, j });
                }
            }
        }
        return paths;
    }

    int traps;
    public int NumTraps(Boxes[,] maze)
    {
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                if (maze[i, j] == Boxes.trap)
                {
                    traps++;
                }
            }
        }
        return traps;
    }
}

