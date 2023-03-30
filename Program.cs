using System;
namespace SistArruda
{
    class Program
    {
        static void Main (string[]args)
        {
            float ValPag = 0.0F;
            Console.WriteLine("Informe o nome: ");
            string VarNome = Console.ReadLine();
            Console.WriteLine("Informe seu endereço: ");
            string VarEnd =  (Console.ReadLine());
            Console.WriteLine("Por favor informe se é Pessoa Fisica \"(F)\" ou Pessoa Jurídica \"(J)\".");
            string VarTipo = Console.ReadLine();

            if(VarTipo == "f")
            {
                //----Pessoa física------
                PessoaFisica pf = new PessoaFisica();
                
                pf.Nome = VarNome;
                pf.Endereco = VarEnd;
                Console.WriteLine("Informe o seu CPF: ");
                pf.Cpf = Console.ReadLine();
                Console.WriteLine("Informe o seu RG ");
                pf.Rg = Console.ReadLine();
                Console.WriteLine("Digite o valor da Compra: ");
                ValPag = float.Parse(Console.ReadLine());
                pf.PagarImposto(ValPag);
                
                Console.WriteLine("------------Pessoa Fisica------------");
                Console.WriteLine("Nome............... " +pf.Nome);
                Console.WriteLine("Endereço........... " +pf.Endereco);
                Console.WriteLine("CPF................ " +pf.Cpf);
                Console.WriteLine("RG................. " +pf.Rg);
                Console.WriteLine("Valor da Compra: " +pf.Valor.ToString("C"));
                Console.WriteLine("Imposto............ " +pf.ValorImposto.ToString("C"));
                Console.WriteLine("Total a pagar...... " +pf.Total.ToString("C"));
            }
             if(VarTipo == "j")
            {
                //------Pessoa Jurídica----------
                PessoaJuridica pj = new PessoaJuridica();
                
                pj.Nome = VarNome;
                pj.Endereco = VarEnd;
                Console.WriteLine("Informe CNPJ: ");
                pj.Cnpj = Console.ReadLine();
                Console.WriteLine("Informe IE: ");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informe o valor da compra: ");
                ValPag = float.Parse(Console.ReadLine());
                pj.PagarImposto(ValPag);
                
                Console.WriteLine("-----------Pessoa Juridica------------");
                Console.WriteLine("Nome................. " +pj.Nome);
                Console.WriteLine("Endereço............. " +pj.Endereco);
                Console.WriteLine("CNPJ................. " +pj.Cnpj);
                Console.WriteLine("IE................... " +pj.ie);
                Console.WriteLine("Valor da compra...... " +pj.Valor.ToString("C"));
                Console.WriteLine("Imposto.............. " +pj.ValorImposto.ToString("C"));
                Console.WriteLine("Total................ " +pj.Total.ToString("C"));
            }
            if ((VarTipo != "f") && (VarTipo != "j"))
            {
                Console.WriteLine("Opção Invalida");
                Console.ReadKey();
            }
        }
    }
}

