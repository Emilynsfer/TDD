using NewTalents;

namespace NewProjectTestes;

public class UnitTest1
{

    public Calculadora dataClasse()
    {
        string data = "20/05/2024";
        Calculadora calc = new Calculadora("20/05/2024");
        return calc;
    }

  [Theory]
  [InlineData(5, 6, 11)]
  [InlineData(3, 5, 8)]

  public void testeSomar(int num1, int num2, int resultado)
  {
    Calculadora calc = dataClasse();

    int resultadoCalculadora = calc.somar(num1, num2);
    
    Assert.Equal(resultado, resultadoCalculadora);
  }

  [Theory]
  [InlineData(11, 8, 3)]
  [InlineData(15, 5, 10)]

  public void testeSubtrair(int num1, int num2, int resultado)
  {
    Calculadora calc = dataClasse();

    int resultadoCalculadora = calc.subtrair(num1, num2);
    
    Assert.Equal(resultado, resultadoCalculadora);
  }

  [Theory]
  [InlineData(5, 6, 30)]
  [InlineData(2, 2, 4)]

  public void testeMultiplicar(int num1, int num2, int resultado)
  {
    Calculadora calc = dataClasse();

    int resultadoCalculadora = calc.multiplicar(num1, num2);
    
    Assert.Equal(resultado, resultadoCalculadora);
  }

   [Theory]
  [InlineData(10, 2, 5)]
  [InlineData(20, 5, 4)]

  public void testeDividir(int num1, int num2, int resultado)
  {
    Calculadora calc = dataClasse();

    int resultadoCalculadora = calc.dividir(num1, num2);
    
    Assert.Equal(resultado, resultadoCalculadora);
  }

}
