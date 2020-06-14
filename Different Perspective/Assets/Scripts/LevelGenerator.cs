using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Texture2D LevelMap;
    public SpriteInfo[] sprites;


    void Start()
    {
        LevelGenerate();
    }

    void LevelGenerate() {
        for (int x = 0; x < LevelMap.width; x++) {
            for (int y = 0; y < LevelMap.height; y++) {
                GenerateSprite(x, y);
            }
        }
    }

    void GenerateSprite(int x, int y) {
        Color color = LevelMap.GetPixel(x, y);

        if (color.a == 0) {
            return;
        }
        foreach(SpriteInfo sprite in sprites) {
            
            if (sprite.color.Equals(color)) {
                
                Vector2 pos = new Vector2(x, y);
                Instantiate(sprite.prefab, pos, Quaternion.identity, transform);
                
            }
        }
    }
}
