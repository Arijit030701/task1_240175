using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameController controller;
    void OnTriggerEnter()
    {
        controller.CompleteLevel();
    }
}
