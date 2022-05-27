using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{   public GameObject trailobject;
    // Start is called before the first frame update
    void Start()
    {   trailobject.SetActive (false);
        
    }
    public void ActivateTrail () {
        trailobject.SetActive (true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
