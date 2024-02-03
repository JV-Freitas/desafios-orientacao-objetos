using System.Net.Http.Headers;

class Lambda
{
    public int Somar(int a, int b)
    {
        int resultado = a + b;
        return resultado;
    }

    public int Somar2(int a, int b) => a + b;
}