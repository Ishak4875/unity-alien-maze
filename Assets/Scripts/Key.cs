using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Key : MonoBehaviour
{
    public static int key;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "key")
        {
            GameObject.Find("Getting Key Sound").GetComponent<AudioSource>().Play();
            key++;
            GameObject.Find("Key Text").GetComponent<Text>().text = key.ToString() + "/2";
            Destroy(other.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        key = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
