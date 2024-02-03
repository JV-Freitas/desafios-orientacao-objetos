class Conta
{
    public int Numero { get; set; }
    //public string? Titular { get; set; }
    public int Saldo { get; set; }
    public int Senha { get; set; }
    public Titular Titular { get; set; }

    public void Extrato()
    {
        Console.WriteLine($"Titular: {Titular.Nome}\nDocumento: {Titular.Documento} \nEndereco:{Titular.Endereco} \nSaldo:{Saldo}");
    }
}