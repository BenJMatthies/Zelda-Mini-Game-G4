using Godot;
using System;

public partial class StaticMapAssetBase : Node
{
    private Sprite2D _sprite;
    private WorldCellBaseScene _parentWorldCell;
    private Biome _parentWorldCellBiome;

    public override void _Ready()
    {
        _sprite = GetNode("Sprite2D") as Sprite2D;
        _parentWorldCell = GetParent() as WorldCellBaseScene;
        Console.WriteLine(_parentWorldCell.ToString());
        _parentWorldCellBiome = _parentWorldCell.GetNode("Biome") as Biome;
    }

    public void setSprite(Globals.E_AssetType assetType)
    {
        Globals.E_Biomes innerBiome = _parentWorldCellBiome.InnerBiome;
        string assetPath = Globals.getStaticMapAssetPath(assetType, innerBiome);
        _sprite.Texture = GD.Load(assetPath) as Texture2D;
    }
}
