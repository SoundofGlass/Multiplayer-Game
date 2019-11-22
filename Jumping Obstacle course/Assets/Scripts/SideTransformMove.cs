using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SideTransformMove : MonoBehaviour
{
     //public GameObject platform;
     Vector3  movePosition;
    Vector3 target;
    //public int translate;
    public float timer;
    public float switchDirection = 1;
    public float speed;
    [RangeAttribute(0, 10)]
    public float timerMin;
    [RangeAttribute(0, 10)]
    public float timerMax;
    private float timerNum;
    
    void Start()
    {
        //platform = GameObject.FindWithTag("ObsticlePlatform");
        //target = transform.position;
        // Transform platform = GetComponent<Transform>();
        //  StartCoroutine(MoveBackAndForth(movePosition, new Vector3(0.0f, 10f, 0f), 5f));
        timerNum = Random.Range(timerMin, timerMax);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            collider.gameObject.transform.parent = transform;
        }
    }
    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            // now the player doesn't leave being a child of the collider
            //collider.gameObject.transform.parent = null;
        }
    }
    public void FixedUpdate()
    {

        transform.position += Vector3.forward * Time.deltaTime * speed * switchDirection;
       //Debug.Log("AH." + timer);
        timer += Time.deltaTime;
        if (timer >= timerNum)
        {
            switchDirection *= -1;
            timer = 0;
         //   Debug.Log("Are you even seeing this?");
          //JustGo();
             //Debug.Log("I'm moving! " + timer);


        }


    }

 /* public void JustGo()
    {
 
        Debug.Log("Is this running?" + platform);
        switchDirection = !switchDirection;
        if (switchDirection)
        {
            
            //platform = GetComponent();
            
        }
        else
        {

            platform.transform.Translate(Vector3.back * Time.deltaTime);
        }

        Debug.Log("Can you see me? " + switchDirection);
    }*/

//    public IEnumerator MoveBackAndForth(Transform transform, Vector3 position, float moving)
//    {
        
//        movePosition = transform.position;
//        var i = 0f;
//        while(i <= 10)
//        {


//            i += Time.deltaTime / moving;
//            platform.transform.position = Vector3.Lerp(movePosition, position, i);
//            //platform.transform.Translate(Vector3.forward * Time.deltaTime);
//            yield return null;
//        } 

//    }
}
