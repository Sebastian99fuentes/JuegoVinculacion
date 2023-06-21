using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float totalTime = 5f; // Tiempo total en segundos
    private float currentTime; // Tiempo actual
    private bool gameStarted = false; // Indicador si el juego ha comenzado

    public GameObject panel;
    public TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = totalTime;
        Time.timeScale = 0f; // Pausar el tiempo al inicio
    }

    // Update is called once per frame
    void Update()
    {
        if (!gameStarted)
        {
            // Actualizar el tiempo actual
            currentTime -= Time.unscaledDeltaTime;

            // Actualizar el texto de la cuenta regresiva
            countdownText.text = currentTime.ToString("0");

            // Comprobar si el tiempo ha terminado
            if (currentTime < 1f)
            {
                gameStarted = true;
                StartGame();
            }
        }
    }
    void StartGame()
    {
        // Aquí puedes agregar el código para iniciar tu juego
        panel.SetActive(false);
        Time.timeScale = 1f; // Reanudar el tiempo para que los otros componentes puedan comenzar a actuar
    }
}
