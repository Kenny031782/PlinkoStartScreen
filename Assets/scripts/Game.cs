using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;
    private static bool isGameStarted = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }
    
    public void OnStartButtonClick()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
        isGameStarted = true;
    }

    public static bool IsGameStarted()
    {
        return isGameStarted;
    }
    // Update is called once per frame
    
}
