using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        print(Input.GetAxis("Horizontal"));
        float hMover = Input.GetAxis("Horizontal");
        float vMover = Input.GetAxis("Vertical");
        transform.Translate(0f * Time.deltaTime, 1f * Time.deltaTime*hMover, 1f*Time.deltaTime*vMover);
    }
}