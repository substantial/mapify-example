using UnityEngine;
using System.Collections;

public enum MapifyLayout
{
  Horizontal,
  Vertical
};

public class Mapify {
  public static void Generate(string map, Transform container, MapifyTileRepository tileRepository, float tileOffset, MapifyLayout layout) {
    var localPositionCalculator = new MapifyLocalPositionCalculator(tileOffset, layout);
    var iterator = new MapifyMapIterator(map.SplitOnNewline(), localPositionCalculator);
    new MapifyLevelPopulator(iterator, tileRepository, container).Populate();
  }
}
