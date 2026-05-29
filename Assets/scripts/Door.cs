using UnityEngine;

public class Door : MonoBehaviour
{
   
       public void OnColliderEnter()
       {
         if (gameObject.CompareTag("canPickUp"))
         {
            Destroy(gameObject);
         }
       }

}
