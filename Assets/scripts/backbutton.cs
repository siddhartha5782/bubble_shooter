using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class backbutton : MonoBehaviour
{
    // Start is called before the first frame update
    public void Backbutton()
    {
        SceneManager.LoadScene(0);
    }
}
