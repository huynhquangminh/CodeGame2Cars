using UnityEngine;
using System.Collections;

public class spanwer : MonoBehaviour {

    public float vtri1, vitri2, t1, t2;
    [SerializeField]
    private GameObject itemcircle, itemsquare;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(spawneritem());
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator spawneritem()
    {
        yield return new WaitForSeconds(Random.Range(t1, t2));
        Vector3 temp = new Vector3();
        temp.y = 5.4f;
        int rd = Random.Range(1, 5);

        if (rd == 1)
        {
            temp.x = vtri1;
            Instantiate(itemcircle, temp, Quaternion.identity);
        }
        if (rd == 2)
        {
            temp.x = vtri1;
            Instantiate(itemsquare, temp, Quaternion.identity);
        }
        if (rd == 3)
        {
            temp.x = vitri2;
            Instantiate(itemcircle, temp, Quaternion.identity);
        }
        if (rd == 4)
        {
            temp.x = vitri2;
            Instantiate(itemsquare, temp, Quaternion.identity);
        }

        if (ItemSquareController.kiemtravacham == 0)
        {
            StartCoroutine(spawneritem());
        }
       
    }
}
