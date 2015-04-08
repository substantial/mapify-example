# mapify-example

An example of using Mapify in an Unity app.

# Spoilers!

# GameInitializer.cs
```
using UnityEngine;
using System.Collections;
using Substantial;

public class GameInitializer : MonoBehaviour {
  public TextAsset LevelAsset;
  public TileRepository TileRepository;
  public Transform LevelContainer;
  public float TileSize = 1.0f;

  private void Start() {
    Mapify.Generate(LevelAsset.text, LevelContainer, TileRepository, TileSize, MapifyLayout.Vertical);
  }
}
```

# test.txt map
```
xxxxxxxxxxxxx
x           x
x xxxxxxxxx x
x x       x x
x x xxxxx x x
x x x   x x x
x x x 1 x x x
x x x   x x x
x x xx xx x x
x x  x    x x
x xx xxxxxx x
x  x        x
xxxxxxxxxxxxx
```
test.txt

# Results screenshot

![Screenshot]()
