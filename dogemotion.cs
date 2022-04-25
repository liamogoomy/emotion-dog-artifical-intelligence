using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogemotion : MonoBehaviour
{
    bool canmove = true;
    bool canmovey = false;
    float speed;
    float directionx = -1.0f;
    float directiony = -1.0f;
    public int count;
    public bool startcount;
    public int stop = 0;
    public int emotion = 2; // 1-sad 2- happy
    public GameObject walkingup;
    public GameObject sitting;
    public GameObject happy;
    public GameObject sad;
    public GameObject emotionsad;
    public GameObject emotionhappy; 
    public GameObject building1;
    public GameObject path1;
    public GameObject dog1;
    public GameObject emotions1;
    public GameObject building2;
    public GameObject path2;
    public GameObject path3;
    public GameObject dog2;
    public GameObject emotions2;
    public GameObject busstop1;
    public GameObject people1;
    public GameObject building3;
    public GameObject building4;
    int speedupdown;

    float posx;
    float posy;
    bool speedchange = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (emotion == 1 && speedchange)
        {
            speedupdown = Random.Range(-10, 10);
            if (speedupdown > -11 && speedupdown < 1)
            {
                speed = 0.02f;
            }
            if (speedupdown > 0 && speedupdown < 8)
            {
                speed = 0.04f;
            }
            if (speedupdown > 7 && speedupdown < 11)
            {
                speed = 0.06f;
            }
            speedchange = false;
        }
        if (emotion == 2 && speedchange)
        {
            
        }
        speedupdown = Random.Range(-10, 10);
        if (speedupdown > -11 && speedupdown < -7)
        {
            speed = 0.02f;
        }
        if (speedupdown > -8 && speedupdown < 0)
        {
            speed = 0.04f;
        }
        if (speedupdown > -1 && speedupdown < 11)
        {
            speed = 0.06f;
        }
        speedchange = false;
        if (canmove)
        {
            Vector3 position = transform.localPosition; // creates a vector3 variable called position and sets it to transform.localPosition
            position.x += speed * directionx; // sets position.x to position.x + speed * direction
            posx = position.x;
            posy = position.y;
            transform.localPosition = position;
        }
        if (canmovey)
        {
            Vector3 position = transform.localPosition; // creates a vector3 variable called position and sets it to transform.localPosition
            position.y += speed * directiony; // sets position.x to position.x + speed * direction
            posx = position.x;
            posy = position.y;
            transform.localPosition = position;
        }
        if (startcount)
        {
            count += 1;
        }
        if (posx < 124.0f && stop == 0)
        {
            count = 0;
            canmove = false;
            startcount = true;
            stop = 1;
            walkingup.gameObject.SetActive(false);
            sitting.gameObject.SetActive(true);
        }

        if (posy < 41.0f && stop == 1)
        {
            count = 0;
            canmovey = false;
            startcount = true;
            stop = 2;
            
        }
        if (count == 500 && stop == 1)
        {
            count = 0;
            startcount = false;
            sitting.gameObject.SetActive(false);
            happy.gameObject.SetActive(true);
            canmovey = true;
        }
        if (count == 4000 && stop == 2)
        {
            count = 0;
            emotion = 1;
            happy.gameObject.SetActive(false);
            emotionsad.gameObject.SetActive(true);
            emotionhappy.gameObject.SetActive(false);
            sad.gameObject.SetActive(true);
            stop = 3;
        }
        if (count == 1000 && stop == 3)
        {
            building1.gameObject.SetActive(false);
            path1.gameObject.SetActive(false);
            dog1.gameObject.SetActive(false);
            emotions1.gameObject.SetActive(false);
            building3.gameObject.SetActive(false);
            building4.gameObject.SetActive(false);
            busstop1.gameObject.SetActive(false);
            people1.gameObject.SetActive(false);
            building2.gameObject.SetActive(true);
            path2.gameObject.SetActive(true);
            path3.gameObject.SetActive(true); 
            dog2.gameObject.SetActive(true);
            emotions2.gameObject.SetActive(true);
        }
    }
}
