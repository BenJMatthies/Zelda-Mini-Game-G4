using Godot;
using System;

//How can I make this inheritable?  
public partial class Biome : Node
{
    private Globals.E_Biomes _innerBiome;
    private Globals.E_Biomes _outerBiome;
    private Globals.E_Biomes _groundBiome;
    private bool _isSand;

    public Globals.E_Biomes InnerBiome { get; private set; }
    public Globals.E_Biomes OuterBiome { get; private set; }
    public Globals.E_Biomes GroundBiome { get; private set; }
    public bool IsSand { get; private set; }

    public override void _Ready()
    {
        InnerBiome = Globals.E_Biomes.GRAVE_CLASSIC;//innerBiome;
        OuterBiome = Globals.E_Biomes.MTN_CLASSIC;//outerBiome;
        GroundBiome = Globals.E_Biomes.MTN_GREEN;//groundBiome;
        IsSand = true;//isSand;
    }

    /* Call from _Ready() in the derived classes on each individual world cell to set the Biomes */
    public void setWorldCellBiome(Globals.E_Biomes innerBiome, Globals.E_Biomes outerBiome, Globals.E_Biomes groundBiome, bool isSand)
    {
        InnerBiome = Globals.E_Biomes.GRAVE_CLASSIC;//innerBiome;
        OuterBiome = outerBiome;
        GroundBiome = Globals.E_Biomes.MTN_GREEN;//groundBiome;
        IsSand = true;//isSand;
    }

    // public GlobalBiomes.E_Biomes[] getFullWorldCellBiome()
    // {
    // 	return new GlobalBiomes.E_Biomes[] {InnerBiome, OuterBiome, GroundBiome, IsSand};
    // }
}
