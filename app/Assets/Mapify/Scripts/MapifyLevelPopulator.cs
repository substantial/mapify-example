using UnityEngine;
using System;
using System.Collections;

public class MapifyLevelPopulator {
  private MapifyTileRepository tileRepository;
  private float tileOffset;
  private MapifyLayout mapifyLayout;
  private string[] map;
  private Transform container;

  public MapifyLevelPopulator(string map, Transform container, MapifyTileRepository tileRepository, float tileOffset, MapifyLayout mapifyLayout) {
    this.map = map.SplitOnNewline();
    this.container = container;
    this.tileRepository = tileRepository;
    this.tileOffset = tileOffset;
    this.mapifyLayout = mapifyLayout;
  }

  public void Populate() {
    var halfCellOffset = tileOffset / 2;

    for (var y = 0; y < map.Length; y++) {
      var line = map[y];
      var centerYOffset = CenterOffset(map.Length);
      for (var x = 0; x < line.Length; x++) {
        var character = line[x];
        var centerXOffset = CenterOffset(line.Length);
        var position = container.TransformPoint(
            x * tileOffset + centerXOffset + halfCellOffset, 
            y * tileOffset + centerYOffset + halfCellOffset,
            0);
        var tile = tileRepository.Find(character);
        if (tile != null) {
          MapifyTileSpawner.Create(tile, position, container);
        }
      }
    }
  }

  private float CenterOffset(int cellsInRow) {
    return -tileOffset * cellsInRow / 2;
  }
}
