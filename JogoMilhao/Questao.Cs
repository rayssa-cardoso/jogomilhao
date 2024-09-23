namespace JogoMilhao;

public class Questao
{
    public string Pergunta;

    public string Resposta1;

    public string Resposta2;
 
    public string Resposta3;

    public string Resposta4;

    public string Resposta5;

    public int RespostaCerta;

    public int nivel;

    Label labelpergunta;

    Button buttonResposta1;

    Button buttonResposta2;

    Button buttonResposta3;

    Button buttonResposta4;
    Button buttonResposta5;
    
    public void Desenhar()
    { 
        labelpergunta.Text = pergunta;
         buttonResposta1.Text =  resposta1;
         buttonResposta2.Text =  resposta2;
         buttonResposta3.Text =  resposta3;
         buttonResposta4.Text =  resposta4;
         buttonResposta5.Text =  resposta5;

    }
     public void ConfiguraEstruturaDesenho (Label labelpergunta, Button button1, Button button2, Button button3, Button button4, Button button5){
        LabelPergunta = labelpergunta;
        ButtonResposta1 = button1;
        ButtonResposta2 = button2;
        ButtonResposta3 = button3;
        ButtonResposta4 = button4;
        ButtonResposta5 = button5;
    }

 }