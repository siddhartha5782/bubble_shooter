using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shootScript : MonoBehaviour
{

    public GameObject arCamera;
    public GameObject smoke;
    public Text ScoreText;
    private int shootgot = 0;

    public void shoot()
    {
        RaycastHit hit;
        if (Physics.Raycast(arCamera.transform.position, arCamera.transform.forward, out hit))
        {
            if (hit.transform.name == "balloon1(Clone)" || hit.transform.name == "balloon2(Clone)" || hit.transform.name == "balloon3(Clone)" || hit.transform.name == "balloon4(Clone)")
            {
                Destroy(hit.transform.gameObject);
                Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));
                shootgot++;

            }
        }
    }
    void Update()
    {
        ScoreText.text = shootgot.ToString();
    }
}
