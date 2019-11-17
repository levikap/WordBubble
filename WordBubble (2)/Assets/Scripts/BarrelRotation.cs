using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BarrelRotation : MonoBehaviour
{

    private Camera mainCam;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = mainCam.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        transform.up = direction;
    }
}
