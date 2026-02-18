using UnityEngine;
using UnityEngine.InputSystem;
public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject BallPrefab;
    
    // Update is called once per frame
    void Update()
    {
        print("Updating BallDropper");
        // if the left mouse button was pressed
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            DropBall();
        }
            
    }

    private void DropBall()
    {
        // pick a position to start at
        Vector3 spawnPosition = GetSpawnPosition();
        // create a ball at that position
        Instantiate(BallPrefab, spawnPosition, Quaternion.identity); // what to create, where to create, how to rotate   
        // Quaternion mean dont rotate
    }

    private Vector3 GetSpawnPosition()
    {
        Vector3 leftedge = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, Camera.main.nearClipPlane));
        Vector3 rightedge = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, Camera.main.nearClipPlane));

        float randomx = Random.Range(leftedge.x + 1, rightedge.x - 1);
        Vector3 spawnPosition = new Vector3(randomx, 4.5f, 0f);
        
        return spawnPosition;
    }
}
