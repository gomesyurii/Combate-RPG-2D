using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dot : MonoBehaviour
{
    [SerializeField] protected float speed;
    public bool isMoving;
    protected void Start()
    {
        Debug.Log("Dot Start" + gameObject.name);
        speed = 3;
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
