Terrain[,] map = new Terrain[4, 8]
{
    { Terrain.Water,    Terrain.Land,     Terrain.City,     Terrain.Land, Terrain.Water,    Terrain.Land,  Terrain.Water, Terrain.Water },
    { Terrain.Mountain, Terrain.Land,     Terrain.Land,     Terrain.Land, Terrain.Water,    Terrain.Land,  Terrain.Land,  Terrain.Water },
    { Terrain.Water,    Terrain.Mountain, Terrain.Land,     Terrain.Land, Terrain.Land,     Terrain.Land,  Terrain.Land,  Terrain.Land  },
    { Terrain.Water,    Terrain.Water,    Terrain.Mountain, Terrain.City, Terrain.Mountain, Terrain.Water, Terrain.Water, Terrain.Water }
};

DrawMap(map);


void DrawMap(Terrain[,] map)
{
    for (int row = 0; row < map.GetLength(0); row++)
    {
        for (int column = 0; column < map.GetLength(1); column++)
            Console.Write(GetText(map[row, column]));
        Console.WriteLine();
    }
}

string GetText(Terrain terrain) => terrain switch
{
    Terrain.Water    => "~~",
    Terrain.City     => "()",
    Terrain.Mountain => "^^",
    _                => "  "
};

enum Terrain { Water, Land, Mountain, City }
