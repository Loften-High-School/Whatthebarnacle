using UnityEngine;

public class TriggerSpawner : MonoBehaviour
{
    public GameObject blockPrefab; 
    public Transform spawnPoint;   
    public float shootForce = 2000f;
    
    public float fireRate = 0.5f; 
    private float nextFireTime = 0f;

    void Update()
    {
        // Now checks for the Trigger OR the Z key
        bool triggerPressed = Input.GetAxis("ShootTrigger") > 0.5f;
        bool zKeyPressed = Input.GetKey(KeyCode.Z);

        if ((triggerPressed || zKeyPressed) && Time.time > nextFireTime)
        {
            ShootBlock();
            nextFireTime = Time.time + fireRate;
        }
    }

    void ShootBlock()
    {
        GameObject newBlock = Instantiate(blockPrefab, spawnPoint.position, spawnPoint.rotation);

        Rigidbody rb = newBlock.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddForce(spawnPoint.forward * shootForce);
        }

        Destroy(newBlock, 5f);
    }
}
