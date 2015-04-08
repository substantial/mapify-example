using UnityEngine;
using System.Collections;

public enum MapifyLayout
{
  Horizontal,
  Vertical
};

public class Mapify {
  public static void Generate(string map, Transform container, MapifyTileRepository tileRepository, float tileOffset, MapifyLayout mapifyLayout) {
    var iterator = new MapifyMapIterator(map.SplitOnNewline(), tileOffset, mapifyLayout);
    new MapifyLevelPopulator(iterator, tileRepository, container).Populate();
  }
}
