public class ContaCorrente // Classe
{
   public string Titular;
   public int Numero;
   public int Agencia;
   public double Saldo;


public ContaCorrente (string Titular, int Agencia, int Numero, double Saldo)  // Construtor
{
   this.Titular = Titular;
   this.Agencia = Agencia;
   this.Numero = Numero;
   this.Saldo = Saldo;
}

//Construtuor nao tem retorno

public bool Sacar (double valorSaque) // Metodo
{
   if (this.Saldo >= valorSaque)
   {
      this.Saldo = this.Saldo - valorSaque;
      return true;
   }
   return false;
}


}