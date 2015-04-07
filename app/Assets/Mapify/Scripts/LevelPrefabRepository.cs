using UnityEngine;
using System.Collections;

public class LevelPrefabRepository : MonoBehaviour {
  public GameObject LevelPrefab;

  private static LevelPrefabRepository instance;
  public static LevelPrefabRepository Instance {
    get {
      if (instance == null) {
        instance = GameObject.Find("/LevelLoader/LevelPrefabRepository").GetComponent<LevelPrefabRepository>();
      }

      return instance;
    }
  }
}
