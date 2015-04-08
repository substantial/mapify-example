using UnityEngine;
using System.Collections;

public class MapifyLocalPositionCalculator {
  private float tileOffset;
  private float halfTileOffset;
  private MapifyLayout layout;

  public MapifyLocalPositionCalculator(float tileOffset, MapifyLayout layout) {
    this.tileOffset = tileOffset;
    this.halfTileOffset = tileOffset / 2.0f;
    this.layout = layout;
  }

  public Vector3 Calculate(int x, int y, int maxX, int maxY) {
    var position = AdjustToLayout(
        x * tileOffset + CenterOffset(maxX) + halfTileOffset, 
        y * tileOffset + CenterOffset(maxY) + halfTileOffset);
    return position;
  }

  private Vector3 AdjustToLayout(float x, float y) {
    if (layout == MapifyLayout.Horizontal) {
      return new Vector3(x, 0, y);
    } 
    return new Vector3(x, y, 0);
  }

  private float CenterOffset(int cellCount) {
    return -tileOffset * cellCount / 2;
  }
}
