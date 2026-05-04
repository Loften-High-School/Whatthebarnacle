using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathRespawn : MonoBehaviour
{
   public float threshold;
   public string Respawn;

          public Return()
          {
           yield return new WaitForSeconds(5);
          }
    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
       
          transform.position = new Vector3(1f, 9.1f, 38.7f);
        }
 
         SceneManager.LoadScene("WigmunnsDungeon");

        }
    }

