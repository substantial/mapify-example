using UnityEngine;
using System.Collections;

public class Mapify {
  public static GameObject Create(LevelDefinition levelDefinition) {
    var position = Vector3.zero;
    return Create(levelDefinition, position);
  }

  public static GameObject Create(LevelDefinition levelDefinition, Vector3 position) {
    var instance = GameObject.Instantiate(Prefab, position, Quaternion.identity) as GameObject;
    instance.GetComponent<LevelInitializer>().Initialize(levelDefinition);
    return instance;
  }

  private static GameObject Prefab {
    get { return LevelPrefabRepository.Instance.LevelPrefab; }
  }
}
