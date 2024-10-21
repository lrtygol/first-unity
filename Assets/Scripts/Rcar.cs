using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rcar : MonoBehaviour
{
    public int speed = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    async void Update()
    {
        if (transform.position.z > -24 && transform.position.x < 5)
        {
            transform.rotation = Quaternion.Euler(0, 180, 0);
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        
        }
        else if (transform.position.x < 38 && transform.position.z < -24)
        {
            transform.rotation = Quaternion.Euler(0, 90, 0);
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        else if (transform.position.z < 72)
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
        else if (transform.position.x > 4)
        {
            transform.rotation = Quaternion.Euler(0, 270, 0);
            transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime * speed);
        }
    }
}
