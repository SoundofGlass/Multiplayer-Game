using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderCounter : MonoBehaviour
{
    public static ColliderCounter colliderCounter;
    public List<GameObject> gameObjects;
    public List<float> timers;

    public bool plat;
    public float timeCounter = 0;
    
    void Start()
    {
        colliderCounter = this;
    }
    public void OnTriggerEnter(Collider collider)
    {
        transform.parent = null; //when the player leaves the collider it removes the parent from the platform
        if (collider.tag == "ObsticlePlatform" && !collider.isTrigger)// for GameObjects with tag "ObsticlePlatform" set the bool 'plat' equal to true, and if the gameobjects collider isn't in the list, add to list
        {
            plat = true;
            if (!gameObjects.Contains(collider.gameObject))
            {
                gameObjects.Add(collider.gameObject);
            }
        }

    }

    public void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "ObsticlePlatform" && !collider.isTrigger)// when leaving the gameObject, stop counter, add to the list and reset it.
        {
            
            plat = false;
            timers.Add(timeCounter);
            timeCounter = 0;
        }

    }
    // make and on trigger enter that starts a timer, then on trigger exit stops the time and adds timer to a list

    public void Update()
    {

        if (plat)
        {// if ontriggerenter  sets plat = true, add to a timer
            timeCounter += Time.deltaTime;

        }
    }
}
