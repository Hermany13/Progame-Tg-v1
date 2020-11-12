using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class black : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Invoke("ChamaCena", 1f);
    }

    public void ChamaCena()
    {
        SceneManager.LoadScene("fase1_splash");
    }
}
