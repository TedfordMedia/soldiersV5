using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera_mover : MonoBehaviour {
    float timeLeft = 6.0f; 
    public GameObject[] targetArray;
    int i = 0;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            Debug.Log("timer got to zero so now move to position "+i+" "+ targetArray[i].name);
            transform.position = targetArray[i].transform.position;
            transform.rotation = targetArray[i].transform.rotation;
            transform.parent = targetArray[i].transform.parent;
            timeLeft = 10.0f;
            i++;
            if (i == targetArray.Length) {
                i = 0;
            }

            //   ovrcamera.transform.parent = steeringwheel.transform;
        }
    }
}
