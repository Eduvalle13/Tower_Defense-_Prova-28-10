using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InimigoMetal : MonoBehaviour, ITipoInimigo//implementa a interface ITipoInimigo. Isso significa que a classe InimigoMetal precisa fornecer as implementa��es dos membros definidos na interface ITipoInimigo.
{
    public string Nome//Essa propriedade tem apenas um  (get), que retorna a string "Metal". Isso significa que, sempre que chamar o nome do tipo de inimigo, o valor "Metal" ser� retornado.
    {
        get { return "Metal"; }
    }
}
