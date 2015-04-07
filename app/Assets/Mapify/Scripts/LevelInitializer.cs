using UnityEngine;
using System.Collections;

public class LevelInitializer : MonoBehaviour {
  public LevelPopulator LevelPopulator;

  public void Initialize(LevelDefinition levelDefinition) {
    LevelPopulator.Populate(levelDefinition);
  }
}
