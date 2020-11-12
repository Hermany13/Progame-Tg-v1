using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SplashScene1 : MonoBehaviour
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
            _contadorRegressivo.text = Mathf.Round(_tempoInicial).ToString();
        }

    }

}
