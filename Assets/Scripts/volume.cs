using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Audio;

public class volume : MonoBehaviour
{
    public AudioMixer controleSom;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetVolume (float volume)
    {
        controleSom.SetFloat("music", volume);
    }
}
