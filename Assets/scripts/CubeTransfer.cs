using UnityEngine;
using UnityEngine.SceneManagement;

public class CubeTransfer : MonoBehaviour
{
    // When Enemy colldies with
    public void OnCollisionEnter(Collision other)
    {
        SceneManager.LoadScene("WigmunnsDungeon");
    }



}
