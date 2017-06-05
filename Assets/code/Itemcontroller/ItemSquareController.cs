using UnityEngine;
using System.Collections;

public class ItemSquareController : MonoBehaviour {

    public static int kiemtravacham = 0;
    public float speed;
    private Rigidbody2D mybody;
    [SerializeField]
    private GameObject particle;

    void Start () {
        mybody = GetComponent<Rigidbody2D>();
	}
	
	void MoveItem()
    {
        mybody.velocity = new Vector2(0, -speed);
    }
	void Update () {
       
            MoveItem();
        if(kiemtravacham == 1)
        {
            GameObject[] arryob = GameObject.FindGameObjectsWithTag("squares");
            foreach (GameObject n in arryob)
            {
                n.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 0);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag== "destroy")
        {
            Destroy(gameObject);
        }
        if(target.tag == "car")
        {
            Destroy(gameObject);
            Vector3 temp = transform.position;
            temp.y = temp.y + 0.2f;
            Instantiate(particle, temp, target.gameObject.transform.rotation);

           
            kiemtravacham = 1;
            if (GameController.ins != null)
            {
                GameController.ins.LoadPanelGameover();
            }
        }
    }
   
}
