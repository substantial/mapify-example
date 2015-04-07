using UnityEngine;
using System;
using System.Collections;
using System.Linq;

public class LevelDefinition {
  public string[] Map { get; private set; }

  public static LevelDefinition Read(TextAsset asset) {
    var dd = new LevelDefinition();
    var lines = asset.text.SplitOnNewline();

    dd.Map = lines.ToArray();
    Array.Reverse(dd.Map);

    return dd;
  }
}
