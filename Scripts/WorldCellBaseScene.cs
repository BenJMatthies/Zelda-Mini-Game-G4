using Godot;
using System;

public partial class WorldCellBaseScene : Node2D
{
    static class WorldCellBiome 
    {
        //Biome
        // private static Globals.E_Biomes _innerBiome;
        // private static Globals.E_Biomes _outerBiome;
        // private static Globals.E_Biomes _groundBiome;
        // private static bool _isSand;

        public static Globals.E_Biomes InnerBiome { get; private set; }
        public static Globals.E_Biomes OuterBiome { get; private set; }
        public static Globals.E_Biomes GroundBiome { get; private set; }
        public static bool IsSand { get; private set; }

        //ultimately want this to get the Biome data from an outer source, but not sure what that is yet
        static WorldCellBiome()//Globals.E_Biomes innerBiome, Globals.E_Biomes outerBiome, Globals.E_Biomes groundBiome, bool isSand)
        {
            InnerBiome = Globals.E_Biomes.GRAVE_CLASSIC;//innerBiome;
            OuterBiome = Globals.E_Biomes.MTN_CLASSIC;//outerBiome;
            GroundBiome = Globals.E_Biomes.MTN_GREEN;//groundBiome;
            IsSand = true;//isSand;
            // _innerBiome = innerBiome;
            // _outerBiome = outerBiome;
            // _groundBiome = groundBiome;
            // _isSand = isSand;
        }
    }
    
    private Sprite2D _background;
    //private WorldCellBiome _biome;

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        _background = GetNode("Background") as Sprite2D;
        //_biome = new WorldCellBiome();//GetNode("Biome") as Biome;
        setBackground();
    }

    public void setBackground()
    {
        Globals.E_Biomes groundBiome = WorldCellBiome.GroundBiome;
        bool isSand = WorldCellBiome.IsSand;
        string assetPath = Globals.getStaticMapBackgroundPath(Globals.E_AssetType.BACKGROUND, groundBiome, isSand);
        _background.Texture = GD.Load(assetPath) as Texture2D;
    }

}
