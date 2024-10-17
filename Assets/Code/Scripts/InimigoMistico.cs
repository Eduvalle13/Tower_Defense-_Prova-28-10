using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMistico : MonoBehaviour, ITipoInimigo//implementa a interface ITipoInimigo. Isso significa que a classe InimigoMistico precisa fornecer as implementações dos membros definidos na interface ITipoInimigo.
{
    public string Nome//Essa propriedade tem apenas um  (get), que retorna a string "Mitico". Isso significa que, sempre que chamar o nome do tipo de inimigo, o valor "Mitico" será retornado.
    {
        get { return "Mitico"; }
    }
}
