using UnityEngine;
using TMPro;

public class EnemyFollow : MonoBehaviour
{
     [SerializeField] private float timer = 5;
    private float bulletTime;

 public float elapsedTime = 0;
public float timeRandomMin;
    public float timeRandomMax;
      public float range;

       public TextMeshProUGUI heartText;

 public UnityEngine.AI.NavMeshAgent enemy;
    public Transform player;
    public GameObject enemyBullet;
    public Transform spawnPoint;
    public float enemySpeed;
    public Transform targetObj;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(this.transform.position, targetObj.position, 10 * Time.deltaTime);
        float distance = range;
        float dist = Vector3.Distance(enemy.transform.position, player.position);

	elapsedTime += Time.deltaTime;

        if (elapsedTime >= 45)
            {
                heartText.text = "Barnacle boy forgot his insulin and left";
                 Destroy(gameObject);
            }

   if(dist <= distance)
        {
            enemy.SetDestination(player.position);
            Invoke("setEnemy", Random.Range(timeRandomMin, timeRandomMax));
        }
    }


     void setEnemy()
    {
        ShootAtPlayer();
    }

    void ShootAtPlayer()
    {
        bulletTime -= Time.deltaTime;

        if (bulletTime > 0) return;

        bulletTime = timer;

        GameObject bulletObj = Instantiate(enemyBullet, spawnPoint.transform.position, spawnPoint.transform.rotation) as GameObject;
        Rigidbody bulletRig = bulletObj.GetComponent<Rigidbody>();
        bulletRig.AddForce(bulletRig.transform.forward * enemySpeed);
        Destroy(bulletObj, 5f);

    }

}
