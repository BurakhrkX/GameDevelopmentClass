using UnityEngine;

public class GridObject : MonoBehaviour
{
   bool isPlayer = false;
    [SerializeField] Material playerMat, enemyMat;
    public void SetEnemy()
    {
        GetComponent<MeshRenderer>().material = enemyMat;

    }
    public void SetPlayer()
    {
        isPlayer = true;
        GetComponent<MeshRenderer>().material = playerMat;
    }
}
