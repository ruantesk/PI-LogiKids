using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textos : MonoBehaviour
{
    public static string  NivelAtual = "0" ;
    public static string FaseAtual = "0";
    public static int JaJogouAntes = 0;

    //Textos de ajuda
    public static string Ajuda01_01 = "Arraste os itens que representam cada ação da sua rotina da manhã de acordo com a ordem que você realiza em sua casa";
    public static string Ajuda01_02 = "Agora sua tarefa é colocar a ordem das imagens dentro do fluxograma";
    public static string Ajuda01_03 = "Você está se saindo muito  bem! Mas na próxima fase você terá uma pergunta para analisar qual a melhor opção de " +
        "calçado para se usar naquela determinada ocasião. Essa pergunta é chamada de condição, e nós só podemos respondê-la com: SIM ou Não.";
    public static string Ajuda02_01 = "Agora o desafio é você relacionar cada imagem que está na barra amarela com as ações que estão em baixo.";
    public static string Ajuda02_02 = "Você Evoluiu! A partir de agora você usará palavras para expressar cada ação.";
    public static string Ajuda02_03 = "Que tal trabalhar só com a escrita? Será que você consegue?";
    public static string Ajuda03_01 = "Bem-vindo (a) para o Nível 3! A atividade que você vai realizar não é muito diferente da anterior, mas preste bem atenção!" +
        "Arraste cada verbo para o espaço em branco. De acordo com a sequência da sua rotina. Seja organizado!";
    public static string Ajuda03_02 = "Você está indo bem! Nessa próxima fase você terá que adicionar as palavras que estão acima da página, dentro dos parênteses(), que estão ao lado de cada ação.";
    public static string Ajuda03_03 = "Cuidado! Agora você tem que fazer a escolha certa de acordo com a condição que o jogo está propondo a você.Fique esperto (a)! ";

    //Textos de informação
    public static string Info01_01 = "Ele é um conjunto de ações que realizam uma atividade. Como por exemplo: Uma receita de bolo é um algoritmo! " +
        "Você precisa seguir os  passos direitinho para fazer um bolo bem gostoso!";
    public static string Info01_02 = "Ele serve para você entender melhor o seu algoritmo. Coloca cada passo dentro de uma forma geométrica, " +
        "e cada forma geométrica significa um tipo de ação!";
    public static string Info01_03 = "";
    public static string Info02_01 = " É algo que deve ser feito uma ou várias vezes, sempre que for necessário para " +
        "se obter um resultado.";
    public static string Info02_02 = "Um método é o mesmo que uma função. Eles são um conjunto de algoritmos que servem para " + 
        "realizar uma determinada tarefa.";
    public static string Info02_03 = "É através deles que definimos os tipos de dados que vamos usar no nosso método ou na nossa função. " +
        "Por exemplo, quando for usado um número inteiro como o 2 usamos o parâmetro int ou quando usamos um número quebrado como o 2,5 usamos o parâmetro float. ";
    public static string Info03_01 = "Você, mini-programador, deve sempre deixar ser algoritmo organizado, porque é mais fácil para você e outras pessoas " +
        "entenderem o que você escreveu...";
    public static string Info03_02 = "Uma linguagem de programação é tipo um idioma, como o Inglês, Português, Espanhol… ela tem as suas " +
        "próprias regras e modo de escrever! Aqui você está usando um pouco de Portugol! Mas existem muitas por aí...";
    public static string Info03_03 = "A função “Se”, em outras linguagens de programação é chamada de “If”, porque é a sua tradução para o inglês! ";

    //Textos de informação principal
    public static string InfoPrinc01_01 = "O que é um algoritmo?";
    public static string InfoPrinc01_02 = "O que é um fluxograma? ";
    public static string InfoPrinc01_03 = "Fluxogramas, suas formas e significados:";
    public static string InfoPrinc02_01 = "Você já ouviu falar em função? Não? Vem ver o que é isso!";
    public static string InfoPrinc02_02 = "Vamos aprender o que é um método. ";
    public static string InfoPrinc02_03 = "O que são parâmetros?";
    public static string InfoPrinc03_01 = "Organização!";
    public static string InfoPrinc03_02 = "Linguagens de Programação";
    public static string InfoPrinc03_03 = "Curiosidade!";

    //Textos de Erro
    public static string Erro01_01 = "Você está indo para a fase 01 - Isso é um teste";
    public static string Erro01_02 = "Você está indo para a fase 02 - Isso é um teste";
    public static string Erro01_03 = "Você está indo para a fase 03 - Isso é um teste";
    public static string Erro02_01 = "Você está indo para a fase 01 Nível 02 - Isso é um teste";
    public static string Erro02_02 = "Você está indo para a fase 02 Nível 02 - Isso é um teste";
    public static string Erro02_03 = "Você está indo para a fase 03 Nível 02 - Isso é um teste";
    public static string Erro03_01 = "Você está indo para a fase 01 Nível 03 - Isso é um teste";
    public static string Erro03_02 = "Você está indo para a fase 02 Nível 03 - Isso é um teste";
    public static string Erro03_03 = "Você está indo para a fase 03 Nível 03 - Isso é um teste";

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
