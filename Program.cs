using System;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Configuration;
using Dapper.Teste.Teste;

namespace DapperTest
{
    class MainClass
    {
        static void Main(params string[] paramaters)
        {
			
			SqlConnection conn = new SqlConnection();
			conn.ConnectionString = "Data Source=127.0.0.1,1433;Network Library= DBMSSOCN; Initial Catalog = gabriel;User ID = sa; Password = reallyStrongPwd123";
                                    
            //try
            //{
            conn.Open();
            Console.WriteLine("Connection Open ! ");
            // insert conn.Execute
            //List<Pessoas> resultado = conn.Query<Pessoas>("select * from pessoas").ToList();
            //resultado.ForEach((pessoa) => {
            //    Console.WriteLine(pessoa.Nome);

            //});

            string query = "select* from funcionarios";
            //string query2 = "select count(nome),cidade from funcionarios group by cidade";

            //EXEC FUNCIONANDO
            //Funcionarios Teste = new Funcionarios();
            //Teste.Nome = "loucura";
            //Teste.Cidade = "loucura maior ainda";
            //conn.Execute("INSERT INTO funcionarios VALUES (@Nome, @Cidade)", Teste);

            List<Funcionarios> resultado2 = conn.Query<Funcionarios>(query).ToList();
            resultado2.ForEach((funcionarios) => {
                //Console.WriteLine(funcionarios.Nome);
                Console.WriteLine(funcionarios.Cidade);
                Console.WriteLine(funcionarios.Nome);
            });
            Console.WriteLine(" ");

			//var flavio = resultado2
   //             .OrderBy((item) =>
			//{
   //             //return item.Nome.Contains('gabriel');
   //             return item.Cidade;
			//})
   //             .Select((teste) => {
   //                 return teste.Cidade;
   //         }).ToList();
			
			//flavio.ForEach((item) =>
			//{
			//	Console.WriteLine(item);
			//});

			

            //var flavio = resultado.Select((item) =>
            //{
            //    return item.Nome = "gabriel";

            //}).GroupBy();




                
                //.Distinct()
                //.Select();

            //select, groupby, distinct


                conn.Close();
            //}
            //catch
            //{
            //    Console.WriteLine("Can not open connection ! ");
            //}
			
			
        }
    }
}

