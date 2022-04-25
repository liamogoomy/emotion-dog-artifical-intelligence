using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oldpersonp : MonoBehaviour
{
    public GameObject sad;
    public GameObject happy;
    public GameObject dog;
    public int emotion = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        emotion = dog.gameObject.GetComponent<dogemotion>().emotion;
        if (emotion == 1)
        {
            sad.gameObject.SetActive(true);
            happy.gameObject.SetActive(false);
        }
        if (emotion == 2)
        {
            sad.gameObject.SetActive(false);
            happy.gameObject.SetActive(true);
        }
    }
}
