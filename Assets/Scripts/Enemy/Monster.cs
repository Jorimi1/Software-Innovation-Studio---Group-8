using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Monster : MonoBehaviour
{
    // Start is called before the first frame update\
    public Vector2 StartVec;
    public int Thisone;
    float Shoottime;
    public GameObject ZiDan;
    public Slider slider;
    public float HP;
    void Start()
    {
        StartVec = this.transform.position;
        HP = 100;
        slider.maxValue = HP;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = HP;
        if (HP <= 0)
        {
            Destroy(this.gameObject);
        }
        if (Thisone == 0)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, StartVec - new Vector2(10, 0), Time.deltaTime * 2);
            if (Vector2.Distance(this.transform.position, StartVec - new Vector2(10, 0)) <= 0.5f)
            {
                Thisone = 1;
                this.transform.localEulerAngles = new Vector3(0, 180, 0);
            }
        }
        else
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, StartVec + new Vector2(10, 0), Time.deltaTime * 2);
            if (Vector2.Distance(this.transform.position, StartVec + new Vector2(10, 0)) <= 0.5f)
            {
                Thisone = 0;
                this.transform.localEulerAngles = new Vector3(0, 0, 0);
            }
        }
        Shoottime += Time.deltaTime;
        if (Shoottime >= 3)
        {
            Shoottime = 0;
            GameObject.Instantiate(ZiDan);
            ZiDan.transform.position = this.transform.position;
            ZiDan.transform.GetComponent<Zidan>().Thisone = 1;
            ZiDan.transform.right = -this.transform.right;
        }
    }
}
