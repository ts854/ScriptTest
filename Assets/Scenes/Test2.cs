using UnityEngine;
using System.Collections;

public class Test2: MonoBehaviour
{

    void Start()
    {
        int[] points = { 10, 20, 30, 40, 50 };
        for (int i = 4; i >= 0; i--)

        {
            Debug.Log(points[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
