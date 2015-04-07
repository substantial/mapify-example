using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LevelElementRepository : MonoBehaviour {
  public LevelElement[] LevelElements;
  private Dictionary<char, LevelElement> lookupTable = new Dictionary<char, LevelElement>();

  private static LevelElementRepository instance;
  public static LevelElementRepository Instance {
    get {
      if (instance == null) {
        instance = GameObject.Find("/LevelLoader/LevelElementRepository").GetComponent<LevelElementRepository>();
      }

      return instance;
    }
  }

  private void Awake() {
    foreach (var dungeonElement in LevelElements) {
      lookupTable[dungeonElement.Character] = dungeonElement;
    }
  }

  public bool HasKey(char character) {
    return lookupTable.ContainsKey(character);
  }

  public LevelElement Find(char character) {
    return lookupTable[character];
  }
}
