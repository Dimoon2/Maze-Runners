using System;
using System.Drawing;
using Microsoft.VisualBasic;
public class Maze
{
    public static int size = 7;
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
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
            {Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle,Boxes.path,Boxes.obstacle},
            {Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle,Boxes.obstacle },
        };
        Mask[,] mask =
        {
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
            {Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall,Mask.unvisited,Mask.wall},
            {Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall,Mask.wall },
        };

        //2. creacion de lista de habitaciones no visitadas:
        List<int[]> unvisited = PathList(maze);

        //KILL MODE:
        //3. seleccion de habitacion random de la lista de visitadas:
        Random randomIndex = new Random();
        int index = randomIndex.Next(unvisited.Count);
        int[] selectedCell = unvisited[index];

        //4.Marcar la random como visitada:
        unvisited.RemoveAt(index);
        mask[selectedCell[0], selectedCell[1]] = Mask.visited;

        //5.array direccional para acceder a un vecino random adyacente:

        //crear lista de direcciones:
        List<int[]> Direction = new List<int[]>();
        Direction.Add(new int[] { -1, 0 });
        Direction.Add(new int[] { 1, 0 });
        Direction.Add(new int[] { 0, -1 });
        Direction.Add(new int[] { 0, 1 });

        //6.seleccionar un vecino random adyacente:
        while (unvisited.Count > 0)
        {

            //7.Verificar limites:



            //8. Comprobar que el seleccionado pertenezca a la lista de no visitados.
            while (Direction.Count > 0)
            {
                int indexOfDir = randomIndex.Next(Direction.Count);
                int[] Dir = Direction[indexOfDir];

                int[] adjacentCell = [selectedCell[0] + Dir[0] + Dir[0], selectedCell[1] + Dir[1] + Dir[1]];
                if (adjacentCell[0] >= 1 && adjacentCell[0] < size - 2 && adjacentCell[1] >= 1 && adjacentCell[1] < size - 2)
                {
                    for (int i = 0; i < unvisited.Count; i++)
                    {
                        //9.Romper la pared de por medio:
                        if (adjacentCell[0] == unvisited[i][0] && adjacentCell[1] == unvisited[i][1])
                        {
                            maze[selectedCell[0] + Dir[0], selectedCell[1] + Dir[1]] = Boxes.path;

                            //10.Marcar adjacentCell como visitada:
                            unvisited.RemoveAt(i);
                            mask[adjacentCell[0], adjacentCell[1]] = Mask.visited;


                            //11.Me muevo para la celda vecina:
                            selectedCell[0] = adjacentCell[0];
                            selectedCell[1] = adjacentCell[1];

                            //vaciar lista de Direction
                            for (int j = 0; j < Direction.Count; j++)
                            {
                                Direction.RemoveAt(j);
                            }
                            //la llenamos:
                            Direction.Add(new int[] { -1, 0 });
                            Direction.Add(new int[] { 1, 0 });
                            Direction.Add(new int[] { 0, -1 });
                            Direction.Add(new int[] { 0, 1 });
                            break;
                        }
                        if (!(adjacentCell[0] == unvisited[i][0] && adjacentCell[1] == unvisited[i][1]) && i == unvisited.Count - 1)
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

            }
            bool found = false;
            //Hunt mode:
            while (Direction.Count == 0)
            {
                for (int i = 1; i < size - 1; i++)
                {
                    for (int j = 1; j < size - 1; j++)
                    {
                        //revisar si tiene algun vecino como visitada para cavar la pared:
                        if (mask[i, j] == Mask.unvisited)
                        {
                            if (i - 2 >= 1 && i - 2 < size - 2 && j >= 1 && j < size - 2)
                            {
                                if (mask[i - 2, j] == Mask.visited)
                                {
                                    maze[i - 1, j] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    found = true;
                                    break;
                                }
                            }
                            else if (i + 2 >= 1 && i + 2 < size - 2 && j >= 1 && j < size - 2)
                            {
                                if (mask[i + 2, j] == Mask.visited)
                                {
                                    maze[i + 1, j] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    found = true;
                                    break;
                                }
                            }
                            else if (i >= 1 && i < size - 2 && j - 2 >= 1 && j - 2 < size - 2)
                            {
                                if (mask[i, j - 2] == Mask.visited)
                                {
                                    maze[i, j - 1] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
                                    found = true;
                                    break;
                                }
                            }
                            else if (i >= 1 && i < size - 2 && j + 2 >= 1 && j + 2 < size - 2)
                            {
                                if (mask[i, j + 2] == Mask.visited)
                                {
                                    maze[i, j + 1] = Boxes.path;
                                    mask[i, j] = Mask.visited;
                                    selectedCell[0] = i;
                                    selectedCell[1] = j;
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
            continue;

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

