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
    public Animator animator;

    private bool right = true;

    // Start is called before the first frame update
    void Start()
    {
        Level = 1;
        LevelsComplete = 0;
        Model_2.SetActive(false);
        StartCoroutine(ChangeModel());
    }

    // Update is called once per frame
    void Update()
    {
        if(Level == LevelsComplete || Level < LevelsComplete)
        {
            if(Input.GetKey("right") && right == true) {
                right = false;
                StartCoroutine(DelayCoroutine());
            }

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

        if(Input.GetKey("space"))
        {
            Model_1.SetActive(false);
            Model_2.SetActive(true);
            animator.SetBool("spaceKey", true);
            animator.Play("Jump");
        }
    }
    
    IEnumerator ChangeModel()
    {
        yield return new WaitForSeconds(0.3f);
        Model_1.SetActive(true);
        Model_2.SetActive(false);
        yield return new WaitForSeconds(0.3f);
        Model_1.SetActive(false);
        Model_2.SetActive(true);
        StartCoroutine(ChangeModel());
    }

    IEnumerator DelayCoroutine()
    {
        Character.transform.localEulerAngles = new Vector3(0f, 0f, 0f);
        for (int i = 0; i < 20f; i++)
        {
            Character.transform.Translate(Vector3.right * -3f, Space.World);
            yield return new WaitForSeconds(0.01f);
            
        }
        right = true;
        Level++;
        map.enabled = false;
        yield return new WaitForSeconds(0.5f);
        Character.SetActive(false);
    }
}