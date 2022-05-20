using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    private Text ScoreText;
    public GameObject arCamera;
    //public GameObject smoke;
    private int shootgot;
    void Start()
    {
        shootgot = 0;
    }
    public void shoot()
    {
        RaycastHit hit;

        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)" || hit.transform.name == "balloon4(Clone)")
            {

                    shootgot++;
                
                //Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                //return shootgot;
            }

        }

    }
    void Update()
    {
        ScoreText.text = shootgot.ToString();
    }

}
