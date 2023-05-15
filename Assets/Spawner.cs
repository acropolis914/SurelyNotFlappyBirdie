using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float maxTime = 1;
    private float timer = 0;
    public GameObject brick;
    public float minHeight;
    public float maxHeight;
    private bool hasStarted = false;

    // Start is called before the first frame update
    void Start()
    {
        // Do nothing on start
    }

    // Update is called once per frame
    void Update()
    {
        if (hasStarted)
        {
            if (timer > maxTime)
            {
                GameObject newBrick = Instantiate(brick);
                float randomHeight = Random.Range(minHeight, maxHeight);
                newBrick.transform.position = transform.position + new Vector3(0, randomHeight, 0);
                Destroy(newBrick, 5);
                timer = 0;

                // Adjust the maximum time with a random value
                maxTime = Random.Range(2f, 4f);
            }
            timer += Time.deltaTime;
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                hasStarted = true;
            }
        }
    }
}
