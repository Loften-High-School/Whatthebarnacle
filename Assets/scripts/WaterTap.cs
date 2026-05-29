using UnityEngine;

public class WaterTap : MonoBehaviour
{

    public GameObject openText;
    public GameObject closeText;

    public ParticleSystem RunningWater;

    private bool inReach;
    private bool isOpen;
    private bool isClosed;
   
   public void ReachSet(bool inUse)
   {

        if (inUser)
        {
            if (isClosed)
            {
                inReach = true;
                openText.SetActive(true);

            }

            if (isOpen)
            {
                inReach = true;
                closeText.SetActive(true);
            }

        
        }
       else
       {
           inReach = false;
           isClosed = true;
           isOpen = false;
           closeText.SetActive(false);
           openText.SetActive(false);
           RunningWater.Stop();

       }
   }

    void Start()
    {
        inReach = false;
        isClosed = true;
        isOpen = false;
        closeText.SetActive(false);
        openText.SetActive(false);
        RunningWater.Stop();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(new Vector3(Screen.width / 2f, Screen.height / 2f, 0f));
        RaycastHit hit;
        if (Physics.Raycast(ray, out hit, 2.5f/*, layermask*/))
        {
           Debug.DrawRay(ray.origin, ray.direction * hit.distance, Color.red);
           if (hit.collider.CompareTag("interactable") && hit.distance <= 2.5f)
           {
              ReachSet(true);
              Debug.log("Object is interactable");
           }
           else
           {
             ReachSet(false);
           }
        }
        else
        {
            ReachSet(false);
        }


        if (inReach && isClosed && Input.GetButtonDown("Interact"))
        {
            Tap.Setbool("Open", true);
            Tap.Setbool("Closed", false);
            openText.SetActive(false);
            isOpen = true;
            isClosed = false;
            RunningWater.Play();
        }

        else if (inReach && isOpen && Input.GetButtonDown("Interact"))  
        {
            Tap.Setbool("Open", false);
            Tap.Setbool("Closed", true);
            closeText.SetActive(false);
            isOpen = false;
            isClosed = true;
            RunningWater.Stop();
        }  
    }
    
}
