using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Homing_Bombs : MonoBehaviour
{
    Vector3 moveDirection = Vector3.up * 3;
    public GameObject apple;
    bool lockOn = false;
    public List<GameObject> objects;

    // Update is called once per frame
    void Update()
    {
        if (!lockOn)
        {
            for(int i = 0; i < objects.Capacity; i++)
            {
                if ((objects[i].transform.position - transform.position).magnitude < 2.5f)
                {
                    Debug.Log((objects[i].transform.position - transform.position).magnitude);
                    lockOn = true;
                }
            }
        }
        for (int i = 0; i < objects.Capacity; i++)
        {
            /*Debug.Log(i);*/
        }
        transform.position += moveDirection * Time.deltaTime;
    }
}
