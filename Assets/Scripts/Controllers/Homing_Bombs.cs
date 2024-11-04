using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Homing_Bombs : MonoBehaviour
{
    Vector3 moveDirection = Vector3.up;
    bool lockOn = false;
    public List<GameObject> Objects;

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Objects.Capacity; i++)
        {
            Debug.Log(i);
        }
        transform.position += moveDirection * Time.deltaTime;
    }
}
