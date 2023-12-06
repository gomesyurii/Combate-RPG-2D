using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerDot : MonoBehaviour
{
    [SerializeField] private float speed;
    public bool isMoving;
    private int score;
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        speed = 3;
        score = 0;
        isMoving = true;
    }

    void Update()
    {
        // Obtém a posição atual do ponto.
        Vector3 position = transform.position;

        // Atualiza a posição do ponto.
        position.x += speed * Time.deltaTime;

        // Verifica se o ponto atingiu uma extremidade da barra.
        if (position.x <= -4.5f)
        {
            speed = (Random.Range(3, 9));
            position.x = -4.5f;
        }
        else if (position.x >= 4.5f)
        {
            speed = -(Random.Range(3, 9));
            position.x = 4.5f;
        }

        // Atualiza a posição do ponto.
        transform.position = position;

    }
}
