using UnityEngine;
using System;
using System.Collections;

public class LevelElementFactory {
  public static GameObject Create(char chr, Vector3 position, Transform parent) {
    if (!LevelElementRepository.Instance.HasKey(chr)) {
      return null;
    }

    var dungeonElement = LevelElementRepository.Instance.Find(chr);
    return Create(dungeonElement, position, parent);
  }

  public static GameObject Create(LevelElement dungeonElement, Vector3 position, Transform parent) {
    var instance = GameObject.Instantiate(dungeonElement.Prefab, position + dungeonElement.LocalPosition, dungeonElement.Rotation) as GameObject;
    if (dungeonElement.IsStatic) {
      instance.transform.parent = parent;
    }

    var initializer = instance.GetComponent<LevelElementInitializer>();
    if (initializer) {
      initializer.Initialize();
    }

    return instance;
  }
}
