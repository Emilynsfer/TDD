namespace NewTalents;

public class Calculadora 
{

    private List<string> listaHistorico; 
    private string data;

    public Calculadora(string data)
    {
        listaHistorico = new List<string>();
        this.data = data;
    }
    public int somar(int num1, int num2)
    {
        int valor = num1 + num2;
        listaHistorico.Insert(0, "Valor: " + valor + " - data: " + data);
        return valor;
    }
    
      public int subtrair(int num1, int num2)
    {
        int valor = num1 - num2;   
        listaHistorico.Insert(0, "Valor: " + valor + " - data: " + data);
        return valor;
    }

      public int multiplicar(int num1, int num2)
    {
        int valor = num1 * num2;
        listaHistorico.Insert(0, "Valor: " + valor + " - data: " + data);
        return valor;
    }

      public int dividir(int num1, int num2)
    {
        int valor = num1 / num2;
        listaHistorico.Insert(0, "Valor: " + valor + " - data: " + data);
        return valor;
    }

      public List<string> historico()
    {
        List<string> valor; 
        listaHistorico.RemoveRange(3, listaHistorico.Count - 2);
        return listaHistorico;
    }

}