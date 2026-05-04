using UnityEngine;
using UnityEngine.SceneManagement;

public class TrueGame : MonoBehaviour

{
    public void OnSTartClick()
    {
        SceneManager.LoadScene("WigmunnsDungeon");
    }
}

