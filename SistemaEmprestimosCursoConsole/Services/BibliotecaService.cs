using SistemaEmprestimosCursoConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaEmprestimosCursoConsole.Services
{
    internal class BibliotecaService
    {   
        private List<Livro> livros = new List<Livro>();
        private List<Usuario> usuarios = new List<Usuario>();
        private List<Emprestimo> emprestimos = new List<Emprestimo>();

        private int livroIdConter = 1;
        private int usuarioIdConter = 1;
        private int emprestimoIdConter = 1;
         
        public void MenuPrincipal()
        {
            while(true) 
            {
                Console.WriteLine("\n ========== MENU BIBLIOTECA ==========");
                Console.WriteLine("1. Gerenciar Livros");
                Console.WriteLine("2. Gerenciar Usuários");
                Console.WriteLine("3. Gerenciar Empréstimos");
                Console.WriteLine("0. Sair");
                Console.WriteLine("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": MenuLivros(); break;
                    case "2": MenuUsuarios(); break;
                    case "3": MenuEmprestimos(); break;
                    case "0": return;
                    default: Console.WriteLine("Opção invalida."); break;
                }
            }
        }
    
        private void MenuLivros()
        {
            while (true)
            {
                Console.WriteLine("\n ========== GERENCIAMENTO DE LIVROS ==========");
                Console.WriteLine("1. Adicionar Livros");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Atualizar Livros");
                Console.WriteLine("4. Remover Livro");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("Escolha: ");
                string opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1": AdicionarLivro(); break;
                    case "2": ListarLivros(); break;
                    case "3": AtualizarLivro(); break;
                    case "4": RemoverLivro(); break;
                    case "0": return;
                    default: Console.WriteLine("Opção invalida."); break;
                }
            }
        }
    
        private void MenuUsuarios()
        {
            while (true)
            {
                Console.WriteLine("\n ========== GERENCIAMENTO DE USUÁRIOS ==========");
                Console.WriteLine("1. Adicionar Usuário");
                Console.WriteLine("2. Listar Usuário");
                Console.WriteLine("3. Atualizar Usuário");
                Console.WriteLine("4. Remover Usuário");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("Escolha: ");
                string opcao = Console.ReadLine();

                //switch (opcao)
                //{
                //    case "1": AdicionarUsuario(); break;
                //    case "2": ListarUsuarios(); break;
                //    case "3": AtualizarUsuario(); break;
                //    case "4": RemoverUsuario(); break;
                //    case "0": return;
                //    default: Console.WriteLine("Opção invalida."); break;
                //}
            }
        }
    
        private void MenuEmprestimos()
        {
            while (true)
            {
                Console.WriteLine("\n ========== GERENCIAMENTO DE EMPRÉSTIMOS ==========");
                Console.WriteLine("1. Adicionar Empréstimo");
                Console.WriteLine("2. Listar Empréstimos Ativos");
                Console.WriteLine("3. Devolver Livro");
                Console.WriteLine("4. Histórico de Empréstimos por Usuários");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("Escolha: ");
                string opcao = Console.ReadLine();

                //switch (opcao)
                //{
                //    case "1": AdicionarEmprestimo(); break;
                //    case "2": ListarEmprestimosAtivos(); break;
                //    case "3": DevolverLivro(); break;
                //    case "4": HistoricoEmprestimosUsuarios(); break;
                //    case "0": return;
                //    default: Console.WriteLine("Opção invalida."); break;
                //}
            }
        }
    
        //Métodos Livros

        private void AdicionarLivro()
        {
            Console.Write("Título: ");
            string titulo = Console.ReadLine();

            Console.Write("Autor: ");
            string autor = Console.ReadLine();

            livros.Add(new Livro { Id = livroIdConter, Titulo = titulo, Autor = autor});
            Console.WriteLine("Livro adicionado com sucesso!");
        }
    
        private void ListarLivros()
        {
            Console.WriteLine("\n Lista de livros: ");

            foreach (Livro livro in livros)
            {
                string status = livro.Disponivel ? "Disponivel" : "Emprestado";
                Console.WriteLine($" {livro.Id} | Título: {livro.Titulo} | Autor: {livro.Autor} | {status}");
            }
        }
        
        private void AtualizarLivro()
        {
            Console.Write("Id do livro a atualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Livro livro = livros.FirstOrDefault( l => l.Id == id );

            if ( livro != null )
            {
                Console.Write("Novo Título: ");
                livro.Titulo = Console.ReadLine();

                Console.Write("Novo Autor: ");
                livro.Autor = Console.ReadLine();

                Console.WriteLine("Livro atualizado");
            }
            else
            {
                Console.WriteLine("Livro não localizado!");
            }
        }

        private void RemoverLivro()
        {
            Console.Write("Id do livro a atualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            livros.RemoveAll(l => l.Id == id);
            Console.WriteLine("Livro removido!");
        }
    }
}
