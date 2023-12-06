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


            damage = (distance);
            if (distance == 0)
            {
                damage = 100;
            } 
            else
        {
            // Faz a pontuação ser inversamente proporcional à distância.
            damage = 100 / distance;

            // Adiciona uma faixa gradativa de pontuações positivas e negativas.
            damage -= distance;
        }

            damage = Mathf.Clamp(damage, 0, 100);
            Debug.Log("Damage: " + damage);
        }

    }
}
