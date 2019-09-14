using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBoxScript : MonoBehaviour
{
    // Start is called before the first frame update
    public float moveSpeed = 1f;
    void Start()
    {
        print("Running!");
    }

    // Update is called once per frame
    void Update () 
 {
  transform.Translate(moveSpeed*Input.GetAxis("Horizontal")*Time.deltaTime,0f,moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime); 
 }
}
