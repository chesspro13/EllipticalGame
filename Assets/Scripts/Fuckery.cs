using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuckery : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        var angles = transform.rotation.eulerAngles;
        angles.y += Time.deltaTime;
        transform.rotation = Quaternion.Euler(angles);
    }
}
