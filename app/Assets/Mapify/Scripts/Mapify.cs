using UnityEngine;
using System.Collections;

public enum MapifyLayout
{
  Horizontal,
  Vertical
};

public class Mapify {
  private const float DEFAULT_TILE_OFFSET = 1.0f;
  private const MapifyLayout DEFAULT_LAYOUT = MapifyLayout.Horizontal;

  public static void Generate(string map, Transform container, MapifyTileRepository tileRepository, float tileOffset, MapifyLayout mapifyLayout) {
    new MapifyLevelPopulator(map, container, tileRepository, tileOffset, mapifyLayout).Populate();
  }
}
