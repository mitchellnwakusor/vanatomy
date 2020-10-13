using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateObject : MonoBehaviour
{
    public GameObject obj;
    public float rotationSpeed = 0.5f;
    public bool rotate = false;
    void Update()
    {
             if(rotate){
                  obj.transform.Rotate(0, rotationSpeed, 0);
             }
             else{
                  obj.transform.Rotate(0, 0, 0);
                  obj.transform.rotation = Quaternion.identity;
             }
    }

    public void play(){
          rotate = true;
    }

    public void stop(){
          rotate = false;
    }
}
