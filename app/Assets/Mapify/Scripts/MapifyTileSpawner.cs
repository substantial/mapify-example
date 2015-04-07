using UnityEngine;
using System;
using System.Collections;

public class MapifyTileSpawner {
  public static GameObject Create(MapifyTile tile, Vector3 position, Transform parent) {
    var instance = GameObject.Instantiate(tile.Prefab, position + tile.LocalPosition, tile.Rotation) as GameObject;
    if (tile.IsStatic) {
      instance.transform.parent = parent;
    }

    return instance;
  }
}
