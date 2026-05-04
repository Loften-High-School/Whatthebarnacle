using UnityEngine;

public class Death : MonoBehaviour
{

   public float threshold;


    void FixedUpdate()
    {
        if(transform.position.y < threshold)
        {
          transform.position = new Vector3(1f, 9.1f, 38.7f);
        }
    }


}
