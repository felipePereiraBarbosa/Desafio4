using System;

namespace Desafio4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Nome,DataDeNascimento, Altura, CPF, EstadoCivil

            Pessoa _pessoa = new Pessoa();
            Console.Write("Informe o Nome da pessoa: ");
            _pessoa.Nome = Convert.ToString(Console.ReadLine());
            Console.Write("Informe a Data de nascimento da pessoa: ");
            _pessoa.DataDeNascimento = Convert.ToString(Console.ReadLine());
            Console.Write("Informe a Altura da pessoa: ");
            _pessoa.Altura = Convert.ToString(Console.ReadLine());
            Console.Write("Informe o CPF da pessoa: ");
            _pessoa.CPF = Convert.ToString(Console.ReadLine());
            Console.Write("Informe o estado civil da pessoa: ");
            _pessoa.EstadoCivil = Convert.ToString(Console.ReadLine());

            //Cor, datadenascimento, cor dos olhos e porte

            Cachorro _cachorro = new Cachorro();
            Console.Write("Informe a cor do cachorro: ");
            _cachorro.Cor = Convert.ToString(Console.ReadLine());
            Console.Write("Informe a data de nascimento do cachorro: ");
            _cachorro.DataDeNascimento = Convert.ToString(Console.ReadLine());
            Console.Write("Informe a cor dos olhos do cachorro: ");
            _cachorro.CorDosOlhos = Convert.ToString(Console.ReadLine());
            Console.Write("Informe o porte do cachorro: ");
            _cachorro.Porte = Convert.ToString(Console.ReadLine());

            //cor, combustivel, cilindrada, modelo

            Moto _moto = new Moto();
            Console.Write("Informe a cor da moto: ");
            _moto.Cor = Convert.ToString(Console.ReadLine());
            Console.Write("Informe o combustivel da moto: ");
            _moto.Combustivel = Convert.ToString(Console.ReadLine());
            Console.Write("Informe o cilindrada da moto: ");
            _moto.Cilindrada = Convert.ToString(Console.ReadLine());
            Console.Write("Informe o modelo da moto: ");
            _moto.Modelo = Convert.ToString(Console.ReadLine());

            Console.WriteLine(_pessoa.Nome);
            Console.WriteLine(_pessoa.DataDeNascimento);
            Console.WriteLine(_pessoa.Altura);
            Console.WriteLine(_pessoa.CPF);
            Console.WriteLine(_pessoa.EstadoCivil);

            Console.WriteLine(_cachorro.Cor);
            Console.WriteLine(_cachorro.DataDeNascimento);
            Console.WriteLine(_cachorro.CorDosOlhos);
            Console.WriteLine(_cachorro.Porte);

            Console.WriteLine(_moto.Cor);
            Console.WriteLine(_moto.Combustivel);
            Console.WriteLine(_moto.Cilindrada);
            Console.WriteLine(_moto.Modelo);

            Console.ReadKey();

        }
    }
}
