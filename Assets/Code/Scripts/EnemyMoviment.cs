using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyMoviment : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;

    [SerializeField] private float velocidade = 2f;

    private Transform alvo;
    private int caminhoIndex = 0;
    SpawnManager spawnManager;

    private void Start()
    {
        alvo = LevelManager.principal.caminho[caminhoIndex];
        spawnManager = GameObject.FindObjectOfType<SpawnManager>();
    }

    private void Update()
    {
        if (Vector2.Distance(alvo.position, transform.position) <= 0.1f)
        {
            caminhoIndex++;

            if (caminhoIndex == LevelManager.principal.caminho.Length)
            {
                spawnManager.inimigosVivos--;
                Destroy(gameObject);
                return;
            }
            else
            {
                alvo = LevelManager.principal.caminho[caminhoIndex];
            }
        }
    }

    private void FixedUpdate()
    {
        Vector2 direction = (alvo.position - transform.position).normalized;

        rb.velocity = direction * velocidade;
    }
}