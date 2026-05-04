using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour

{
    public void OnSTartClick()
    {
        SceneManager.LoadScene("SampleScene");
    }
}

