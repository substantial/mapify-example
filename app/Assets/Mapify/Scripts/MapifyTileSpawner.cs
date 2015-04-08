using UnityEngine;
using System;
using System.Collections;

public class MapifyTileSpawner {
  public static GameObject Create(MapifyTile tile, Vector3 position, Transform parent) {
    return GameObject.Instantiate(tile.Prefab, position, tile.Rotation) as GameObject;
  }
}
