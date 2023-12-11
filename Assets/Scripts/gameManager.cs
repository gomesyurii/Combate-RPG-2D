using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class scoreMeter : MonoBehaviour
{
    // essa clsse irá comparar se os dois pontos estão na mesma posição, e baseado nisso irá definir o score, quando o usuário clicar na tela, caso ele clique na tela e os pontos estejam proximos a pontuacao sera alta, e de acordo com o aumento da distancia, a pontuacao ira se tornar gradualmente menor

    public GameObject PlayerDot;
    public GameObject FirstDot;
    private bool gameEnded = false;
    private float damage;
    public Character hero = new Character();
    public Character enemy = new Character();





    void Start()
    {
        damage = 0;


    }

    void Update()
    {
        if (gameEnded)
        {
            return;
        }
        calculateDamage();
        endGame();
    }


    void endGame()
    {
        if (hero.currentHealth <= 0)
        {
            hero.currentHealth = 0;
            Debug.Log("You lose");
            gameEnded = true;

        }

        if (enemy.currentHealth <= 0)
        {

            Debug.Log("You win");
            gameEnded = true;
        }
    }


    private void calculateDamage()
    {

        if (Input.GetMouseButtonDown(0) && PlayerDot.GetComponent<Dot>().isMoving == true && FirstDot.GetComponent<Dot>().isMoving == true)
        {
            float distance = Mathf.Abs(PlayerDot.transform.position.x - FirstDot.transform.position.x);
            float totalDistance = 9;
            float percentage = (distance / totalDistance) * 100;
            damage = 100 - percentage;
            float reflectedDamage = damage / 2; 
            hero.currentHealth -= (int)reflectedDamage;
            if (hero.currentHealth < 0)
            {
                hero.currentHealth = 0;
            }
            enemy.currentHealth -= (int)damage;
            if (enemy.currentHealth < 0)
            {
                enemy.currentHealth = 0;
            }
            Debug.Log("Hero HP: " + hero.currentHealth);
            Debug.Log("Enemy HP: " + enemy.currentHealth);
            PlayerDot.GetComponent<Dot>().isMoving = false;
            FirstDot.GetComponent<Dot>().isMoving = false;
        }

        if (Input.GetMouseButtonDown(1))
        {
            PlayerDot.GetComponent<Dot>().isMoving = true;
            FirstDot.GetComponent<Dot>().isMoving = true;
        }
    }

}
