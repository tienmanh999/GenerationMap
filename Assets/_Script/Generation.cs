using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GenerationTileMap
{
    public enum GenMode
    {
        TopLeft,
        TopRight,
        BotLeft,
        BotRight
    }
    public class Generation
    {
        private static int width;
        private static int heigh;
        private static float cellSize;
    
        public static void ShowMap(TextAsset rawData, GameObject[] tiles, GenMode mode = GenMode.TopLeft)
        {
            string[] data = Read(rawData);
            SetUpData(data, tiles);
            GenerationByMode(mode, tiles, data, width, heigh, cellSize);
        }
        public static void ShowMap(TextAsset rawData, GameObject[] tiles, GenerationLogic logic)
        {
            string[] data = Read(rawData);
            SetUpData(data, tiles);
            GenerationMap(logic, tiles, data, width, heigh, cellSize);
        }
        
        private static void SetUpData(string[] data, GameObject[] tiles)
        {
            cellSize = SizeDefault(tiles);
            width = data[0].ToCharArray().Length;
            heigh = data.Length;
        }

        private static void GenerationByMode(GenMode mode, GameObject[] tiles, string[] data, int w, int h, float cellSize)
        {
            GenerationLogic currentLogic;
            switch (mode)
            {
                case GenMode.TopLeft:
                    currentLogic = Resources.Load<GenerationLogic>("_SO/Logic/TopLeft");
                    GenerationMap(currentLogic, tiles, data, w, h, cellSize);
                    break;

                case GenMode.TopRight:
                    currentLogic = Resources.Load<GenerationLogic>("_SO/Logic/TopRight");
                    GenerationMap(currentLogic, tiles, data, w, h, cellSize);
                    break;
       
                case GenMode.BotLeft:
                    currentLogic = Resources.Load<GenerationLogic>("_SO/Logic/BotLeft");
                    GenerationMap(currentLogic, tiles, data, w, h, cellSize);
                    break;
                    
                case GenMode.BotRight:
                    currentLogic = Resources.Load<GenerationLogic>("_SO/Logic/BotRight");
                    GenerationMap(currentLogic, tiles, data, w, h, cellSize);
                    break;                    
            }
        }
       
        private static void GenerationMap(GenerationLogic logic, GameObject[] tiles,string[] data, int w, int h, float cellSize)
        {
            logic.Init(tiles,data, w, h, cellSize);
        }
        private static float SizeDefault(GameObject[] tiles)
        {
            return tiles[0].GetComponent<SpriteRenderer>().sprite.bounds.size.x;
        }

        private static string[] Read(TextAsset rawData)
        {
            string data = rawData.text.Replace(Environment.NewLine, string.Empty);

            return data.Split('-');
        }
    }
}

