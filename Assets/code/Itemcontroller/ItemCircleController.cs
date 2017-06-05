using UnityEngine;
using System.Collections;

public class ItemCircleController : MonoBehaviour {


    public float speed;
    int score;
   
    private Rigidbody2D mybody;

    private void Awake()
    {
        mybody = GetComponent<Rigidbody2D>();
    }
    void Start () {
	
	}
	
    void MoveItem()
    {
        mybody.velocity = new Vector2(0, -speed);
    }
	void Update () {
       
            MoveItem();
        if(ItemSquareController.kiemtravacham == 1)
        {
            GameObject[] arryob = GameObject.FindGameObjectsWithTag("circle");
            foreach (GameObject n in arryob)
            {
                n.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }
        

    }
    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "destroy")
        {
            if (GameController.ins != null)
            {
                GameController.ins.LoadPanelGameover();
               
            }
            ItemSquareController.kiemtravacham = 1;
        }
        if(target.tag == "car")
        {
            
            score++;
            if(GameController.ins!= null)
            {
                GameController.ins.CountScore(score);
            }
            Destroy(gameObject);
        }

    }
}
