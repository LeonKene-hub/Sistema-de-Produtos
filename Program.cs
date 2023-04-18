//----------------- variaveis e arrays ----------------------
string[] nome = new string[10];
float[] preco = new float[10];
bool[] promocao = new bool[10];

bool fecharMenu = false;

//--------------------------- sistema -----------------------------------
do
{
//menu
Console.WriteLine(@$"
----------------------------------------
|    Seja bem vindo ao mercado Mota    |
|                                      |
|   o que deseja:                      |
|                                      |
| (1) Cadastrar produto                |
| (2) Listar produtos                  |
| (0) Sair                             |
|                                      |
----------------------------------------
");
int opcoes = int.Parse(Console.ReadLine());

switch (opcoes)
{
    case 1:
        Console.WriteLine($"Cadastro de produtos");
        Cadastrar();
        break;

    case 2:
        Console.WriteLine($"Lista de produtos registrados");
        Listar();
        break;

    case 0:
        Console.WriteLine($"Sair, encerrar programa");
        fecharMenu = true;
        break;

    default:
    fecharMenu = true;
        break;
}
} while (fecharMenu == false);

//------------------------------------------------------ funcoes -----------------------------------------------


//cadastrar produtos no sistema
void Cadastrar()
{
    int posicao = 0;
    bool concluido = false;

    do
    {
        Console.WriteLine($"Informe o nome do produto:");
        nome[posicao] = Console.ReadLine();
        
        Console.WriteLine($"Digite o preco atual do produto:");
        preco[posicao] = int.Parse(Console.ReadLine());

        Console.WriteLine($"O produto esta em promocao? (s para sim / n para nao)");
        string resposta = Console.ReadLine();
        
        if (resposta == "s")
        {
            promocao[posicao] = true;
        }
        else if (resposta == "n")
        {
            promocao[posicao] = false;
        }
        else
        {
            Console.WriteLine($"Dado invalido, sera cadastrado como nao!");
            promocao[posicao] = false;
        }
        posicao++;

        Console.WriteLine($"Deseja cadastrar outro produto? (s para sim / n para nao)");
        string resposta2 = Console.ReadLine();
        
        if (resposta2 == "n")
        {
            concluido = true;
        }
        else if (resposta2 == "s")
        {
            concluido = false;
        }
        else
        {
            concluido = true;
        }
    } while (concluido == false);
}


//listar produtos salvos no sistema
void Listar()
{
    string[] emPromocao = new string[10];


    for (int i = 0; i < promocao.Length; i++)
    {
        if (promocao[i] == true)
        {
            emPromocao[i] = "Em promocao!";
        }
        else if(promocao[i] == false)
        {
            emPromocao[i] = "fora da promocao";
        }
    }

    for (int i = 0; i < nome.Length; i++)
    {
        Console.WriteLine($"{nome[i]} {preco[i]} {emPromocao[i]}");
    }
}