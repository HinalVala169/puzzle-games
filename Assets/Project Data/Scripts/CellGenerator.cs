using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CellGenerator : MonoBehaviour
{
    private int count = 5;

    public Image cellPrefab;
    // Start is called before the first frame update
    void Start()
    {
        CreateCell();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void CreateCell()
    {
        for (int x = 0; x < count; x++)
        { 
          Image cell =  Instantiate(cellPrefab, transform.parent);
          
          cell.transform.localPosition = new Vector2(0, y : cell.transform.localPosition.y + 10);
        }
    }
}
