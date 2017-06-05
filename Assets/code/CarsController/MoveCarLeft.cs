using UnityEngine;
using System.Collections;

public class MoveCarLeft : MonoBehaviour {

    public float toadox1, toadox2;
    int dem1 = 1;
    // Use this for initialization
    void Start () {
	
	}
    void MoveTouchCars()
    {
        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began) // cham li vao mang hinh 
            {
                if (touch.position.x < Screen.width * 0.5f) // duy chuyen ve ben trai 
                {
                    dem1++;
                    if (dem1 % 2 == 0)
                    {
                        transform.position = Vector2.MoveTowards(transform.position, new Vector2(toadox1, transform.position.y), 2);
                    }
                    else
                    {
                        transform.position = Vector2.MoveTowards(transform.position, new Vector2(toadox2, transform.position.y), 2);
                    }

                }
                
            }

        }
    }
    // Update is called once per frame
    void Update () {
        MoveTouchCars();

    }
}
