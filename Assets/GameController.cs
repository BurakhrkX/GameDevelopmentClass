using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
   [SerializeField]  int columnCount;
    [SerializeField] int rowCount;
    [SerializeField] TMP_InputField rowInputField,columnInputField;  
    GridController gridController;
    [SerializeField] GameObject gridPanel;

    TurnController turnController;
    private void Awake()
    {
        gridController= this.gameObject.GetComponent<GridController>();
        turnController = this.gameObject.GetComponent<TurnController>();
    }

   public void GetGridValues()
    {
         rowCount = int.Parse(rowInputField.text);
        columnCount = int.Parse(columnInputField.text);
       
    }

    public void CreateGrid()
    {
        gridController.CreateGrid(rowCount,columnCount);
        gridPanel.SetActive(false);
        PlayerChooseGrid();
    }

    void PlayerChooseGrid()
    {
        turnController.ChooseGridPlayer();
    }
}
