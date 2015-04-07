using UnityEngine;
using System;
using System.Collections;
using System.Linq;

public class LevelDefinitionAssetRepository {
  private static TextAsset[] assets;

  public static TextAsset[] Assets {
    get {
      if (assets == null) {
        assets = Resources.LoadAll<TextAsset>("LevelDefinitions");
      }
      return assets;
    }
  }

  public static TextAsset Random {
    get { return Assets[UnityEngine.Random.Range(0, Assets.Length)]; }
  }

  public static TextAsset Find(string name) {
    try {
      return Assets.Single(asset => asset.name == name);
    } catch (Exception ex) {
      throw new Exception("Couldn't find level definition in /Assets/Resources/ named: " + name + " " + ex);
    }
  }
}
