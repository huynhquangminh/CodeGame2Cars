using UnityEngine;
using System.Collections;

public class Cars_Controller : MonoBehaviour {


    public float speed;
    int dem1 = 1;
    [SerializeField]
    private AudioClip music1;
    [SerializeField]
    private AudioClip music2;
    [SerializeField]
    private AudioSource audio;
    public float toadox1, toadox2;
    public KeyCode key;
    private Rigidbody2D rb;
	// Use this for initialization
	void Start () {
        ItemSquareController.kiemtravacham = 0;
        rb = GetComponent<Rigidbody2D>();
	}


    void MoveCars()
    {
        if(Input.GetKeyDown(key))
        {
            dem1 = dem1 + 1;
            if(dem1 % 2 == 0)
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(toadox1, transform.position.y), 2);
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, new Vector2(toadox2, transform.position.y), 2);
            }
        }
        
    }

    

	void Update () {
        MoveCars();

    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "circle")
        {
           
            audio.PlayOneShot(music1);
        }
        if(target.tag == "squares")
        {
            Debug.Log("da cham");
            audio.PlayOneShot(music2);
        }
    }
    
}
