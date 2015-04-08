using UnityEngine;
using System.Collections;

public class GameInitializer : MonoBehaviour {
  public TextAsset LevelAsset;
  public Substantial.TileRepository TileRepository;
  public Transform LevelContainer;
  public float TileOffset = 1.0f;

  private void Start() {
    Mapify.Generate(LevelAsset.text, LevelContainer, TileRepository, TileOffset, Substantial.Layout.Vertical);
  }
}
