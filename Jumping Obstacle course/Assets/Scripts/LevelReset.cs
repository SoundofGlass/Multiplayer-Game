using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelReset : MonoBehaviour
{
    //[SerializeField] private Scene loadlevel;
    public Scene loadlevel;
    public void Start()
    {
         Debug.Log("Notice me");
    }
   
 public void OnTriggerEnter(Collider other)
    { 
       
            Debug.Log("Scene Loaded");
            SceneManager.LoadScene(SceneManager.GetActiveScene ().buildIndex);
           
        
    }
}
