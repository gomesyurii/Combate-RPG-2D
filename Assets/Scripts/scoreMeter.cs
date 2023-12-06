using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scoreMeter : MonoBehaviour
{
    // essa clsse irá comparar se os dois pontos estão na mesma posição, e baseado nisso irá definir o score, quando o usuário clicar na tela, caso ele clique na tela e os pontos estejam proximos a pontuacao sera positiva, e de acordo com o aumento da distancia, a pontuacao ira se tornar gradualmente negativa

    // Start is called before the first frame update
    public GameObject playerDot;
    public GameObject firstDot;
    private float damage;




    void Start()
    {
        damage = 0;

    }

    void Update()
    {
        damage = 0;
        if (Input.GetMouseButtonDown(0))
        {
            float distance = Mathf.Abs(playerDot.transform.position.x - firstDot.transform.position.x);
             float totalDistance = 10; // Substitua isso pela distância total

        // Calcula a porcentagem que a distância representa em relação à distância total.
        damage = (distance / totalDistance) * 100;
        damage = 100 - damage;

        Debug.Log("Damage: " + damage);
        }

    }
}
