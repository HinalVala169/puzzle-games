using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class GridGenerator : MonoBehaviour
{
    public int gridSizeX;
    public int gridSizeY;
    public Sprite gridCellSprite;
    public Image imagePrefab;
    private float offset;

    private float spacing = 0.6f;
    private Vector2 gridCenter;
    [SerializeField]
    private List<Image> gridCells = new List<Image>();

    private void Awake()
    {
        offset = imagePrefab.rectTransform.sizeDelta.x;
        CalculateGridCenter();
    }

    void Start()
    {
        CreateGrid();
    }

    void CalculateGridCenter()
    {
        float screenWidth = Screen.width;
        float screenHeight = Screen.height;

        float gridWidth = gridSizeX * offset * spacing;
        float gridHeight = gridSizeY * offset * spacing;

        float centerX = screenWidth / 2f;
        float centerY = screenHeight / 2f;

        gridCenter = new Vector2(centerX, centerY);
    }

    void CreateGrid()
    {
        for (int x = 0; x < gridSizeX; x++)
        {
            for (int y = 0; y < gridSizeY; y++)
            {
                float posX = gridCenter.x + (x - (gridSizeX - 1) / 2f) * (offset * spacing);
                float posY = gridCenter.y + (y - (gridSizeY - 1) / 2f) * (offset * spacing);
                Image gridCell = Instantiate(imagePrefab, transform);
                RectTransform rectTransform = gridCell.rectTransform;
                rectTransform.position = new Vector3(posX, posY, 0f);
                gridCell.sprite = gridCellSprite;

                gridCells.Add(gridCell); 
            }
        }
    }

}
