using UnityEngine;
using System;
using System.Collections;

public class LevelPopulator : MonoBehaviour {
  public float CellScale = 1.0f;

  public void Populate(LevelDefinition levelDefinition) {
    var map = levelDefinition.Map;
    var halfCellScale = CellScale / 2;

    for (var y = 0; y < map.Length; y++) {
      var line = map[y];
      var centerYOffset = CenterOffset(map.Length);
      for (var x = 0; x < line.Length; x++) {
        var character = line[x];
        var centerXOffset = CenterOffset(line.Length);
        var position = transform.TransformPoint(
            x * CellScale + centerXOffset + halfCellScale, 
            y * CellScale + centerYOffset + halfCellScale,
            0);
        LevelElementFactory.Create(character, position, transform);
      }
    }
  }

  private float CenterOffset(int cellsInRow) {
    return -CellScale * cellsInRow / 2;
  }
}
