
using UnityEngine;
using System.Collections.Generic; 

public class Key : MonoBehaviour
{
    public List<GameObject> objectsToDestroy;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            DestroyTargetObjects();
        
            Destroy(gameObject);
        }
    }

    private void DestroyTargetObjects()
    {
        
        foreach (GameObject obj in objectsToDestroy)
        {
            if (obj != null) 
            {
                Destroy(obj);
            }
        }
    }
}