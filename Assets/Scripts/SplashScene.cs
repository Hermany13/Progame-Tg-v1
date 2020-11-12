using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SplashScene : MonoBehaviour
{
    public float _tempoInicial = 5;
    public Text _contadorRegressivo;

    // Start is called before the first frame update
    void Start()
    {
        _contadorRegressivo.text = _tempoInicial.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        if(_tempoInicial >= 0)
        {
            _tempoInicial = _tempoInicial - Time.deltaTime;
            _contadorRegressivo.text = "0" + Mathf.Round(_tempoInicial).ToString();
        }

        Invoke("ChamaCena", 5f);
    }

    public void ChamaCena()
    {
        SceneManager.LoadScene("fase1");
    }
}
