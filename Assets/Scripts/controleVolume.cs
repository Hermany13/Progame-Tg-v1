using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controleVolume : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject audioSourceGameObject = GameObject.Find("som do games");
        AudioSource source = audioSourceGameObject.GetComponent<AudioSource>();

        if (SceneManager.GetActiveScene().name == "fase1")
        {
            source.Play();
        }

        if (SceneManager.GetActiveScene().name == "black" || SceneManager.GetActiveScene().name == "fase1_splash")
        {
            source.Stop();
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
