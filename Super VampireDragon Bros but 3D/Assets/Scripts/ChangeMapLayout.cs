using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMapLayout : MonoBehaviour
{
    public GameObject path;

    [SerializeField]
    private Map map;
    
   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(map.LevelsComplete == 1)
        {
            path.SetActive(true);
        } 
        else 
        {
            path.SetActive(false);
        }
    }
}
