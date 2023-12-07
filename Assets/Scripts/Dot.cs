using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    [SerializeField] protected float speed;
    public bool isMoving;
    private float changeTimer = 0.0f;
    protected void Start()
    {
        Debug.Log("Dot Start" + gameObject.name);
        speed = 8;
        isMoving = true;
    }

    void Update()
    {
        Move();
    }

    protected virtual void Move()
    {

        // Obtém a posição atual do ponto.
        Vector3 position = transform.position;


        if (isMoving)
        {
            position.x += speed * Time.deltaTime;

            // Verifica se o ponto atingiu uma extremidade da barra.
            if (position.x <= -4.5f)
            {
                speed = (Random.Range(8, 12));
                position.x = -4.5f;
                changeTimer -= 0.3f;
            }
            else if (position.x >= 4.5f)
            {
                speed = -(Random.Range(8, 12));
                position.x = 4.5f;
                changeTimer -= 0.3f;
            }
            // Atualiza a posição do ponto.
            transform.position = position;

            changeTimer += Time.deltaTime;

            // Se passaram 2 segundos.
            if (changeTimer >= 1)
            {
                // Gera um número aleatório entre 0 e 100.
                float random = Random.Range(0, 100);

                // Se o número estiver dentro de 35% do intervalo.

                // Muda a velocidade e a direção.
                speed = Random.Range(8, 12) * (Random.Range(0, 2) * 2 - 1);


                // Reinicia o contador.
                changeTimer = 0.0f;
            }

        }
    }
}
