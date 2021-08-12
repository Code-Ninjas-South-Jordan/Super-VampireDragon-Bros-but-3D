using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public GameObject Model_1;
    public GameObject Model_2;
    public GameObject Character;

    public int Level;
    public int LevelsComplete;

    public Map map;

    // Start is called before the first frame update
    void Start()
    {
        Model_2.SetActive(false);
        Level = 1;
        LevelsComplete = 0;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ChangeModel());

        if(Level == LevelsComplete || Level < LevelsComplete)
        {
            if(Input.GetKey("right"))
                StartCoroutine(DelayCoroutine());
        }

        if(Level > 1)
        {
            if(Input.GetKey("left"))
            {
                Character.transform.localEulerAngles = new Vector3(0f, -180f, 0f);
                for (int i = 0; i < 18f; i++)
                {
                    Character.transform.Translate(Vector3.left * -0.1f, Space.World);
                }
                Level--;
                map.enabled = false;
            }
        }
    }
    
    IEnumerator ChangeModel()
    {
        yield return new WaitForSeconds(1f);
        Model_1.SetActive(true);
        Model_2.SetActive(false);
        yield return new WaitForSeconds(1f);
        Model_1.SetActive(false);
        Model_2.SetActive(true);
    }

    IEnumerator DelayCoroutine()
    {
        Character.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        for (int i = 0; i < 2f; i++)
        {
            Character.transform.Translate(Vector3.right * -2f, Space.World);
            yield return new WaitForSeconds(0.1f);
            
        }
        Level++;
        map.enabled = false;
    }
}