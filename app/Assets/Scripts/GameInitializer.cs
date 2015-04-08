using UnityEngine;
using System.Collections;
using Substantial;

public class GameInitializer : MonoBehaviour {
  public TextAsset LevelAsset;
  public TileRepository TileRepository;
  public Transform LevelContainer;
  public float TileOffset = 1.0f;

  private void Start() {
    Mapify.Generate(LevelAsset.text, LevelContainer, TileRepository, TileOffset, MapifyLayout.Vertical);
  }
}
