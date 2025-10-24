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
        public void MenuPrincipal()
        {
            while(true) 
            {
                Console.Clear();
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
                Console.Clear();
                Console.WriteLine("\n ========== GERENCIAMENTO DE LIVROS ==========");
                Console.WriteLine("1. Adicionar Livros");
                Console.WriteLine("2. Listar Livros");
                Console.WriteLine("3. Atualizar Livros");
                Console.WriteLine("4. Remover Livro");
                Console.WriteLine("0. Voltar");
                Console.WriteLine("Escolha: ");
                string opcao = Console.ReadLine();

                //switch (opcao)
                //{
                //    case "1": AdicionarLivro(); break;
                //    case "2": ListarLivros(); break;
                //    case "3": AtualizarLivro(); break;
                //    case "4": RemoverLivro(); break;
                //    case "0": return;
                //    default: Console.WriteLine("Opção invalida."); break;
                //}
            }
        }
    
        private void MenuUsuarios()
        {
            while (true)
            {
                Console.Clear();
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
                Console.Clear();
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
    }
}
