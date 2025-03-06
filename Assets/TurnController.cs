using UnityEngine;

public class TurnController : MonoBehaviour
{
    bool isPlacingShip;
    public void ChooseGridPlayer()
    {
        isPlacingShip = true;
    }

    private void Update()
    {
        if(isPlacingShip)
        {
            if (Input.GetMouseButtonDown(0))
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit))
                {

                    Debug.Log(hit.collider.gameObject.name);
                    isPlacingShip = false;
                }
            }
        } 
    }
}
