using UnityEngine;
using UnityEngine.SceneManagement;
public class LvlComplete : MonoBehaviour
{
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex +1);
    }
}
