using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerClamp : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -7f, 7f), Mathf.Clamp(transform.position.y, -3.7f, 2f), transform.position.z);
    }
}
