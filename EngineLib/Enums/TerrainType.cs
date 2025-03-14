
namespace PvZCards.Engine;

public enum TerrainType
{
    [JsonStringEnumMemberName("PvZCards.Engine.Components.GrassTerrain, EngineLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
    Grass,

    [JsonStringEnumMemberName("PvZCards.Engine.Components.HighgroundTerrain, EngineLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
    Highground,

    [JsonStringEnumMemberName("PvZCards.Engine.Components.WaterTerrain, EngineLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
    Water,

    [JsonStringEnumMemberName("PvZCards.Engine.Components.Graveyard, EngineLib, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null")]
    Graveyard
}
