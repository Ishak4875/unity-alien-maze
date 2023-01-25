using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heart : MonoBehaviour
{
    public static int heart;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "trap")
        {
            GameObject.Find("Hurt Sound").GetComponent<AudioSource>().Play();
            if (heart > 0)
            {
                heart--;
            }
            GameObject.Find("Heart Text").GetComponent<Text>().text = heart.ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        heart = 3;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
