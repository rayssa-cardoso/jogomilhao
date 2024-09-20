namespace JogoMilhao;

public class Gerenciador{

List<Questao> listaQuestoes = new List<Questao>();
    List<int> listaQuestaoRespondida = new List<int>();
    Questao questaoAtual;
    public Gerenciador(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        CriarQuestoes(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
    }

    void CriarQuestoes(Label labelPergunta, Button buttonResposta01, Button buttonResposta02, Button buttonResposta03, Button buttonResposta04, Button buttonResposta05){
        var q1 = new Questao();

        q1.Pergunta = "Quanto é 2 + 2";
        q1.Resposta1 = "Bolsonaro";
        q1.Resposta2 = "13";
        q1.Resposta3 = "4";
        q1.Resposta4 = "6";
        q1.Resposta5 = "0";

        q1.RespostaCerta = 3;
        q1.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q1);

        var q2 = new Questao();
        q2.Pergunta = "Qual a capital da França?";
        q2.Resposta1 = "Berlim";
        q2.Resposta2 = "Paris";
        q2.Resposta3 = "Madrid";
        q2.Resposta4 = "Lisboa";
        q2.Resposta5 = "Roma";

        q2.RespostaCerta = 2;
        q2.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q2);

        var q3 = new Questao();
        q3.Pergunta = "Qual é a cor do céu em um dia limpo?";
        q3.Resposta1 = "Verde";
        q3.Resposta2 = "Azul";
        q3.Resposta3 = "Amarelo";
        q3.Resposta4 = "Vermelho";
        q3.Resposta5 = "Preto";

        q3.RespostaCerta = 2;
        q3.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q3);

        var q4 = new Questao();
        q4.Pergunta = "Qual é o maior planeta do sistema solar?";
        q4.Resposta1 = "Terra";
        q4.Resposta2 = "Marte";
        q4.Resposta3 = "Júpiter";
        q4.Resposta4 = "Saturno";
        q4.Resposta5 = "Netuno";

        q4.RespostaCerta = 3;
        q4.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q4);

        var q5 = new Questao();
        q5.Pergunta = "Quem escreveu 'Dom Casmurro'?";
        q5.Resposta1 = "Machado de Assis";
        q5.Resposta2 = "José de Alencar";
        q5.Resposta3 = "Jorge Amado";
        q5.Resposta4 = "Clarice Lispector";
        q5.Resposta5 = "Graciliano Ramos";

        q5.RespostaCerta = 1;
        q5.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q5);

        var q6 = new Questao();
        q6.Pergunta = "Quantos continentes existem?";
        q6.Resposta1 = "5";
        q6.Resposta2 = "6";
        q6.Resposta3 = "7";
        q6.Resposta4 = "4";
        q6.Resposta5 = "8";

        q6.RespostaCerta = 3;
        q6.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q6);

        var q7 = new Questao();
        q7.Pergunta = "Qual é a fórmula da água?";
        q7.Resposta1 = "H2O";
        q7.Resposta2 = "O2";
        q7.Resposta3 = "CO2";
        q7.Resposta4 = "NaCl";
        q7.Resposta5 = "C6H12O6";

        q7.RespostaCerta = 1;
        q7.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q7);

        var q8 = new Questao();
        q8.Pergunta = "Qual é a língua mais falada do mundo?";
        q8.Resposta1 = "Inglês";
        q8.Resposta2 = "Mandarim";
        q8.Resposta3 = "Espanhol";
        q8.Resposta4 = "Francês";
        q8.Resposta5 = "Árabe";

        q8.RespostaCerta = 2;
        q8.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q8);

        var q9 = new Questao();
        q9.Pergunta = "Quem pintou a Mona Lisa?";
        q9.Resposta1 = "Vincent van Gogh";
        q9.Resposta2 = "Leonardo da Vinci";
        q9.Resposta3 = "Pablo Picasso";
        q9.Resposta4 = "Claude Monet";
        q9.Resposta5 = "Michelangelo";

        q9.RespostaCerta = 2;
        q9.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q9);

        var q10 = new Questao();
        q10.Pergunta = "Qual é o maior oceano do mundo?";
        q10.Resposta1 = "Oceano Atlântico";
        q10.Resposta2 = "Oceano Índico";
        q10.Resposta3 = "Oceano Pacífico";
        q10.Resposta4 = "Oceano Ártico";
        q10.Resposta5 = "Oceano Antártico";

        q10.RespostaCerta = 3;
        q10.ConfiguraEstruturaDesenho(labelPergunta, buttonResposta01, buttonResposta02, buttonResposta03, buttonResposta04, buttonResposta05);
        listaQuestoes.Add(q10);

}
}       

