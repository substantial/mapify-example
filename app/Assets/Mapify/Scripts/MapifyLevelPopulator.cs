using UnityEngine;
using System;
using System.Collections;

public class MapifyLevelPopulator {
  private MapifyMapIterator mapIterator;
  private MapifyTileRepository tileRepository;
  private Transform container;

  public MapifyLevelPopulator(MapifyMapIterator mapIterator, MapifyTileRepository tileRepository, Transform container) {
    this.mapIterator = mapIterator;
    this.tileRepository = tileRepository;
    this.container = container;
  }

  public void Populate() {
    mapIterator.Iterate((character, localPosition) => {
        var worldPosition = container.TransformPoint(localPosition);
        if (tileRepository.HasKey(character)) {
          var tile = tileRepository.Find(character);
          MapifyTileSpawner.Create(tile, worldPosition, container);
        }
    });
  }
}
