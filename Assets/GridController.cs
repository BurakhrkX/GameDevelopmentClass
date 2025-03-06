 
using UnityEngine;
using System;
using Unity;
using System.Collections.Generic;
public class GridController : MonoBehaviour
{
   [SerializeField]  GameController gameController;
    float tileSize=1.5f;
    [SerializeField] GameObject tilePrefab;
   [SerializeField] List<GameObject> tiles; 

    public void CreateGrid(int rowCount, int columnCount)
    {
        ClearPrevious();
        for (int x = 0; x < columnCount; x++)
        {
            for (int y = 0; y < rowCount; y++)
            {
                Vector3 position = new Vector3(x * tileSize, 0, y * tileSize);
                GameObject go;
                go = Instantiate(tilePrefab, position, Quaternion.identity, transform);
               go.GetComponent<GridObject>().SetPlayer();
                tiles.Add(go);
               
            }
        }
    }
    void ClearPrevious()
    {
        foreach (var item in tiles)
        {
            Destroy(item);
        }
    }
    
}
