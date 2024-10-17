using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Classe para os inimigos
public class Monster : MonoBehaviour, IDamageble
{
    public int vidaAtual = 100;  // Valor inicial da vida do monstro

    // Implementa o m�todo da interface IDamageble
    public void TakeDamage(int dano) //A fun��o desse m�todo � subtrair o valor dedanoda vida
    {
        vidaAtual -= dano; // a vida do inimigo � reduzida pela quantidade de dano recebido

        Debug.Log("Inimigo tomou dano: " + dano + ", Vida restante: " + vidaAtual); //A quantidade de dano que o inimigo acabou de receber(dano).
                                                                                    //A quantidade de vida restante do inimigo(vidaAtual).

        if (vidaAtual <= 0) //O m�todo verifica se a vida atual do inimigo(vidaAtual) � menor ou igual a 0.Se for, isso significa que o inimigo n�o tem mais vida suficiente para continuar no jogo.
        {
            Morrer();  // Chama o m�todo Morrer quando a vida chegar a zero
        }
    }

    private void Morrer()//Ometodo Morrer. Lida com a remo��o do inimigo do jogo, como a destrui��o do objeto,
    {
        SpawnManager.instance.InimigoDestruido();
        Debug.Log("Inimigo morreu!");  // Mensagem de depura��o para confirmar a morte
        Destroy(gameObject);  // Destr�i o inimigo
    }

    /*
     O script controla a vida do inimigo, permitindo que ele receba dano e, quando sua vida chegar a zero,
     o inimigo � destruido
     */
}
