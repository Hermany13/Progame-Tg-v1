using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSegue : MonoBehaviour
{
    public GameObject player;       //Referencia A quem camera vai segui.


    private Vector3 offset;         //Variável privada para armazenar a distância de deslocamento entre o player e a câmera

    void Start()
    {
        //Calcule e armazene o valor do deslocamento, obtendo a distância entre a posição do jogador e a posição da câmera.
        offset = transform.position - player.transform.position;
    }
    void LateUpdate()
    {
        // Defina a posição da transformação da câmera como igual à do jogador, mas compensada pela distância calculada da compensação.
        transform.position = player.transform.position + offset;
    }

    float deltaTime = 0.0f;

    void Update()
    {
        deltaTime += (Time.unscaledDeltaTime - deltaTime) * 0.1f;
    }

    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;

        GUIStyle style = new GUIStyle();

        Rect rect = new Rect(300, 0, w, h * 2 / 30);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 30;
        style.normal.textColor = new Color(255f, 59f, 54f, 1.0f);
        float msec = deltaTime * 1000.0f;
        float fps = 1.0f / deltaTime;
    }

}
