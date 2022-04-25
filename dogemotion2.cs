using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dogemotion2 : MonoBehaviour
{
    bool canmove = false;
    bool canmovey = true;
    float speed;
    float directionx = -1.0f;
    float directiony = -1.0f;
    int speedupdown;
    public GameObject sademotion;
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
        sademotion.gameObject.SetActive(true);
        if (speedchange)
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
        if (posy < -34.0f)
        {
            canmovey = false;
            canmove = true;
        }
    }
}
