using Godot;
using System;


public partial class Globals : Node
{
    //paths
    private static string _staticMapAssetFolder = "res://Assets/StaticMapAssets/";

    /**************/
    /****BIOMES****/
    /**************/

    /* Each world Cell has a Full Biome made up of three parts:
	* Outer Biome - The boundaries around the edges of the cell (Cliffs, Bushes, etc)
	* Inner Biome - All of the obstacle objects inside the cell (Inner bushes, rocks, gravestones, etc)
	* Background/Ground Biome - The background, including an isSand boolean to determine if it is speckled
	*/

    /*Enum to strongly type Biomes*/
    public enum E_Biomes
    {
        CAVE_CLASSIC,
        FOREST_BROWN, FOREST_CLASSIC,
        GRAVE_CLASSIC, GRAVE_ALTERNATE,
        MTN_CLASSIC, MTN_GREEN, MTN_ORANGE, //MTN_BROWN,
        DEATH_CLASSIC
    }

    /***ASSET TYPES***/
    public enum E_AssetType
    {
        ARMOS,
        BACKGROUND,
        BUSH,
        DOCK,
        DUNGEON_CYCLOPS,
        DUNGEON_NORMAL,
        DUNGEON_PILLAR,
        DUNGEON_WIDE,
        GRAVE,
        PASSAGE,
        ROCK,
        TREE_BIG,
        TREE_SMALL
    }

    //Returns a string with the path to a sprite asset based on asset type and biome
    public static string getStaticMapAssetPath(E_AssetType assetType, E_Biomes biome)
    {
        return buildStaticMapAssetPathBase(assetType, biome) + ".png";
    }

    //Returns a string with the path to a background sprite asset based on asset type, biome, and isSand
    public static string getStaticMapBackgroundPath(E_AssetType assetType, E_Biomes biome, bool isSand)
    {
        if(isSand)
        {
            return buildStaticMapAssetPathBase(assetType, biome) + "_SAND.png";
        }
        else
        {
            return buildStaticMapAssetPathBase(assetType, biome) + ".png";
        }
    }

    //Returns a string with the front of the path to an asset based on asset type and biome; 
    //(the end is completed by the calling function, depending on whether it is a sand background or not)
    private static string buildStaticMapAssetPathBase(E_AssetType assetType, E_Biomes biome)
    {
        return _staticMapAssetFolder + E_AssetType.GetName(assetType) + "/" + E_Biomes.GetName(biome);
    }


    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    // Called every frame. 'delta' is the elapsed time since the previous frame.
    public override void _Process(double delta)
    {
    }
}
