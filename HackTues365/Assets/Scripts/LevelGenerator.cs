using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public Texture2D LevelMap;



    void Start()
    {
        LevelGenerate();
    }

    void LevelGenerate() {
        for (int x = 0; x < LevelMap.width; x++) {
            for (int y = 0; y < LevelMap.height; y++) {

            }
        }
    }

    void GenerateSprite(int x, int y) {
        Color color = LevelMap.GetPixel(x, y);

        if (color.a == 0) {
            return;
        }
        //Check For pixel color and generate sprite
    }
}
