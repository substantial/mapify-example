using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MapifyTileRepository : MonoBehaviour {
  public MapifyTile[] MapifyTiles;
  private Dictionary<char, MapifyTile> lookupTable = new Dictionary<char, MapifyTile>();

  private void Awake() {
    foreach (var tile in MapifyTiles) {
      lookupTable[tile.Character] = tile;
    }
  }

  public bool HasKey(char character) {
    return lookupTable.ContainsKey(character);
  }

  public MapifyTile Find(char character) {
    return lookupTable[character];
  }
}
