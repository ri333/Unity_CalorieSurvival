using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalorieUI : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        Vector3 velocity = Vector3.up * 1.0f;
        transform.Translate(velocity * Time.deltaTime);
        transform.LookAt(Camera.main.transform);
        transform.Rotate(new Vector3(0, -180f, 0));
    }
}
