using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameAI : MonoBehaviour
{
    //accesses the lists created in collider logs it
    public List<float> timeCounters;
    public List<GameObject> listofGameObjects;
public void Update()
    {
        
        timeCounters = ColliderCounter.colliderCounter.timers;
        listofGameObjects = ColliderCounter.colliderCounter.gameObjects;

    }



}
