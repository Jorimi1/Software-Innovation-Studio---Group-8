using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zidan : MonoBehaviour
{
    // Start is called before the first frame update
    public int Thisone;
    void Start()
    {
        Destroy(this.gameObject, 10);
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector2.right * Time.deltaTime * 10);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (Thisone == 0 && collision.tag == "Monster")
        {
            Destroy(this.gameObject);
            collision.GetComponent<Monster>().HP -= 10;
        }
        if (Thisone == 1 && collision.tag == "Player")
        {
            //Destroy(this.gameObject);
            //collision.GetComponent<PlayerMovement>().HP -= 10;
        }
    }

}
