using Godot;
using System;

public partial class Armos : StaticMapAssetBase
{
    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
        base._Ready();
        setSprite(Globals.E_AssetType.ARMOS);
    }
}
