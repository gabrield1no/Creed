using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textotTimer;
    [SerializeField] float tempoRestante;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (tempoRestante > 0)
	{
	    tempoRestante = tempoRestante - Time.deltatime;
    	}
	int minutos = Mathf.FloorToInt(tempoRestante / 60);
	int segundos = Mathf.FloorToInt(tempoRestante % 60);
	textoTimer.text = string.Format("{0:00}:{1:00}",minutos,segundos);
	else
	{
	tempoRestante = 0;
	textoTimer.color = Color.red;
	//GamerOver();
	}
    }
}
