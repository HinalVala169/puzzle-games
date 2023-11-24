using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GenerateColorCells : MonoBehaviour
{
    [SerializeField]
    private List<Color> colors = new List<Color>();
    [SerializeField]
    private List<Transform> spawnPoints = new List<Transform>();
    [SerializeField]
    private List<Image> colorCells = new List<Image>();
    public Sprite gridCellSprite;
    public Image imagePrefab;

    private void Start()
    {
        CreateCell();
    }

    void CreateCell()
    {
        int cellNumberCount = Random.Range(0, spawnPoints.Count);

        for (int x = 0; x < cellNumberCount; x++)
        {
            Image gridCell = Instantiate(imagePrefab, transform);
            RectTransform rectTransform = gridCell.rectTransform;
            int spawnIndex = Mathf.Clamp(x, 0, spawnPoints.Count - 1);
            Vector3 spawnPosition = spawnPoints[spawnIndex].position;
            rectTransform.position = new Vector3(spawnPosition.x, spawnPosition.y, 0f);
            gridCell.sprite = gridCellSprite;
            int colIndex = Random.Range(0, colors.Count);
            gridCell.color = colors[colIndex];
            gridCell.rectTransform.sizeDelta = new Vector2(200, 200);
            colorCells.Add(gridCell);
        }
    }
}
