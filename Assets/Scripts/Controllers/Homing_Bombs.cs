using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Homing_Bombs : MonoBehaviour
{
    Vector3 moveDirection = Vector3.up;
    public GameObject apple;
    bool lockOn = false;
    public List<GameObject> objects;

    // Update is called once per frame
    void Update()
    {
        if (!lockOn)
        {
            apple = GameObject.Find("Bombs");
            /*new List<Vector3> apple.transform.position;*/
        }
        for (int i = 0; i < objects.Capacity; i++)
        {
            Debug.Log(i);
        }
        transform.position += moveDirection * Time.deltaTime;
    }
}
