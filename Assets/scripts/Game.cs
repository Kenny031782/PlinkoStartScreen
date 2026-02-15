using UnityEngine;

public class Game : MonoBehaviour
{
    public CanvasGroup StartMenuCanvasGroup;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CanvasGroupDisplayer.Show(StartMenuCanvasGroup);
    }
    
    private bool hasGameStarted = false;
    public void OnStartButtonClick()
    {
        CanvasGroupDisplayer.Hide(StartMenuCanvasGroup);
        hasGameStarted = true;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
