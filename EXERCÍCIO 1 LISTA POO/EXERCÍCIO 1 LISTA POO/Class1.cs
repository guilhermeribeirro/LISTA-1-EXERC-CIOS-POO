using ProjetoAluno;

var aluno = new Aluno();


for (int i = 1; i <= 10; i++)
{

    aluno = new Aluno();

    new Aluno().ReceberDados();
    new Aluno().CalcularMedia();
    new Aluno().CalcularNotaFinal();
    new Aluno().ImprimirNotaFinal();
}