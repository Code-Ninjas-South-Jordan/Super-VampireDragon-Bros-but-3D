using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TitleScreen : MonoBehaviour
{
    public float YV = 0f;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0f, 360f, 0f);
        Title();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Title()
    {
        YV = 0f;
        for(int i = 0; i < 17f; i++)
        {
            YV = YV - 1.05f;
            transform.position = new Vector3(0f, YV, 0f);
        }
        YV = 5;
        for(int i = 0; i < 9f; i++)
        {
            YV = YV -1f;
            transform.position = new Vector3(0f, YV, 0f);
        }
    }
}
