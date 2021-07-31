using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walking : MonoBehaviour
{
    public GameObject Model_1;
    public GameObject Model_2;

    public int Level;

    // Start is called before the first frame update
    void Start()
    {
        Model_2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(ChangeModel());

        if(Input.GetKey("right"))
        {
            for (int i = 0; i < 2f; i++)
            {
                transform.Translate(Vector3.right * -6, Space.World);
            }
        }

        if(Input.GetKey("left"))
        {
            for (int i = 0; i < 2f; i++)
            {
                transform.Translate(Vector3.left * -6, Space.World);
            }
        }
    }

    public IEnumerator ChangeModel()
    {
        yield return new WaitForSeconds(1f);
        Model_1.SetActive(true);
        Model_2.SetActive(false);
        yield return new WaitForSeconds(1f);
        Model_1.SetActive(false);
        Model_2.SetActive(true);
    }


}
