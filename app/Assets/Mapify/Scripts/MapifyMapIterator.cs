using UnityEngine;
using System;
using System.Collections;

public class MapifyMapIterator {
  private string[] map;
  private float tileOffset;
  private float halfTileOffset;
  private MapifyLayout mapifyLayout;

  public MapifyMapIterator(string[] map, float tileOffset, MapifyLayout mapifyLayout) {
    this.map = map;
    this.tileOffset = tileOffset;
    this.halfTileOffset = tileOffset / 2;
    this.mapifyLayout = mapifyLayout;
  }

  public void Iterate(Action<char, Vector3> callback) {
    for (var y = 0; y < map.Length; y++) {
      var line = map[y];
      var centerYOffset = CenterOffset(map.Length);
      for (var x = 0; x < line.Length; x++) {
        var character = line[x];
        var centerXOffset = CenterOffset(line.Length);
        var position = CalculatePosition(
            x * tileOffset + centerXOffset + halfTileOffset, 
            y * tileOffset + centerYOffset + halfTileOffset);
        callback(character, position);
      }
    }
  }

  private Vector3 CalculatePosition(float x, float y) {
    if (mapifyLayout == MapifyLayout.Horizontal) {
      return new Vector3(x, 0, y);
    } 
    return new Vector3(x, y, 0);
  }

  private float CenterOffset(int cellsInRow) {
    return -tileOffset * cellsInRow / 2;
  }
}
