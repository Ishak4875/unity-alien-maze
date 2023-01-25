using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    bool getFinish;
    public static bool isFinished;
    public static bool notFinished;
    int key;

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            getFinish = true;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        getFinish = false;
        isFinished = false;
        notFinished = false;
    }

    // Update is called once per frame
    void Update()
    {
        key = Key.key;
        if(key == 2 && getFinish == true)
        {
            isFinished = true;
        }else if(key < 2 && getFinish == true)
        {
            notFinished = true;
            getFinish = false;
        }
        else
        {
            isFinished = false;
            notFinished = false;
        }
    }
}
