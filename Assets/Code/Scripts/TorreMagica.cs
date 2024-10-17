using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
using UnityEngine;

//Classe TorreMagica : Defina uma torre mágica

//Interface ITorreDano: classe TorreMagica que implementa essa interface, o que indica que ela possui funcionalidades relacionadas a causar danos a inimigos
public class TorreMagica : ITorreDano
{
    public string Nome { get;  set; } // propriedade que armazena o nome da torre. Ela pode ser lida ou escrita por outras classes

    public TorreMagica() //Inicializa uma instância da torre. O nome da torre é definido como "Mitica". Toda vez que uma nova torre mágica for criada, ela terá esse nome.
    {
        Nome = "Mitica";
    }
    public int Dano => 35; //Uma propriedade somente leitura (get), que retorna o valor fixo de 25. Esse valor representa o dano que a torre mágica causa ao atacar inimigos.
    public float Alcance => 2f; //Uma propriedade somente leitura (get), que define o alcance da torre como 2. Isso significa que a torre só pode atacar inimigos que estejam a uma distância de 2 ou menos.

    public void Atacar(IDamageble alvo) //Esse é o método principal da torre, que recebe como parâmetro um inimigo ( alvo), que deve implementar uma interface IDamageble
    {
        if (alvo != null) //O método primeiro verifica se o alvo é válido (ou seja, se não é null)
        {
            Debug.Log($"{Nome} ataca o inimigo com {Dano} de dano."); //Se o alvo for válido, ele registra no console (Debug.Log) uma mensagem que a torre está atacando o inimigo com o valor de Dano

            alvo.TakeDamage(Dano); //Em seguida, o método chama o TakeDamage(Dano)no alvo, o que aplica o dano ao inimigo.
        }
    }

    /*
     Este script define o comportamento de uma torre mágica que ataca inimigos dentro do seu alcance. 
     A torre tem um nome ("Mitica"), um dano fixo de 25 e um alcance de 2 unidades. Quando um inimigo 
     está dentro desse alcance, o método Atacaré chamado, aplicando o dano ao inimigo.
    */
}
