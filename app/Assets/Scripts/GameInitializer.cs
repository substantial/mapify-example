using UnityEngine;
using System.Collections;

public class GameInitializer : MonoBehaviour {
  public TextAsset LevelAsset;
  public MapifyTileRepository MapifyTileRepository;
  public Transform LevelContainer;
  public float TileOffset = 1.0f;

  private void Start() {
    Mapify.Generate(LevelAsset.text, LevelContainer, MapifyTileRepository, TileOffset, MapifyLayout.Horizontal);
  }
}
