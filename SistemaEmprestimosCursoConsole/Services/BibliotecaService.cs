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

                switch (opcao)
                {
                    case "1": AdicionarUsuario(); break;
                    case "2": ListarUsuarios(); break;
                    case "3": AtualizarUsuario(); break;
                    case "4": RemoverUsuario(); break;
                    case "0": return;
                    default: Console.WriteLine("Opção invalida."); break;
                }
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

                switch (opcao)
                {
                    case "1": AdicionarEmprestimo(); break;
                    case "2": ListarEmprestimosAtivos(); break;
                    case "3": DevolverLivro(); break;
                    case "4": HistoricoEmprestimosUsuarios(); break;
                    case "0": return;
                    default: Console.WriteLine("Opção invalida."); break;
                }
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
    
        //Métodos Usuários

        private void AdicionarUsuario()
        {
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            usuarios.Add(new Usuario { Id = usuarioIdConter++, Nome = nome , Email = email });

            Console.WriteLine("Usuário cadastrado!");
        }

        private void ListarUsuarios()
        {
            Console.WriteLine("\n Lista de Usuários: ");

            foreach (Usuario usuario in usuarios)
            {
                Console.WriteLine($"ID: {usuario.Id} | Nome: {usuario.Nome} | Email: {usuario.Email}");
            }
        }

        private void AtualizarUsuario()
        {
            Console.WriteLine("Id do usuário a atuluzar: ");
            int id = Convert.ToInt32(Console.ReadKey());

            Usuario usuario = usuarios.First(u => u.Id == id);

            if(usuario != null)
            {
                Console.Write("Novo nome do usuário: ");
                usuario.Nome = Console.ReadLine();

                Console.Write("Novo emials do usuário: ");
                usuario.Email = Console.ReadLine();

                Console.WriteLine("Usuário atualizado!");
            } 
            else
            {
                Console.WriteLine("Usuário não encontrado!");
            }
        }
    
        private void RemoverUsuario()
        {
            Console.Write("Id do usuário a atualizar: ");
            int id = Convert.ToInt32(Console.ReadLine());

            usuarios.RemoveAll(l => l.Id == id);
            Console.WriteLine("Usário removido!");
        }

        //Métodos Empréstimos

        private void AdicionarEmprestimo()
        {
            Console.Write("Id do livro: ");
            int livroId = Convert.ToInt32(Console.ReadLine());

            Livro livro = livros.FirstOrDefault(l => l.Id == livroId && l.Disponivel);

            if (livro == null)
            {
                Console.WriteLine("Livro não disponivel ou não encontrado!");
                return;
            }

            Console.Write("Id do usuário: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());

            if (!usuarios.Any(u => u.Id == usuarioId))
            {
                Console.WriteLine("Usuário não disponivel ou não encontrado!");
                return;
            }

            emprestimos.Add(new Emprestimo { Id = emprestimoIdConter++, LivroId = livroId, UsuarioId = usuarioId });

            livro.Disponivel = false;

            Console.WriteLine("Emprestimo registrado!");
        }

        private void ListarEmprestimosAtivos()
        {
            List<Emprestimo> ativos = emprestimos.Where(e => e.DataDevolucao == null).ToList();

            foreach (Emprestimo emprestimo in ativos)
            {
                Usuario usuario = usuarios.FirstOrDefault(u => u.Id == emprestimo.UsuarioId);
                Livro livro = livros.FirstOrDefault(u => u.Id == emprestimo.LivroId);

                Console.WriteLine($"Id Emprestimo: {emprestimo.Id} | Livro: {livro.Titulo} | Usuário: {usuario.Nome} | Data Empréstimo: {emprestimo.DataEmprestimo.ToShortDateString()}");
            }
        }

        private void DevolverLivro()
        {
            Console.Write("Id do Empréstimo: ");
            int id = Convert.ToInt32(Console.ReadLine());

            Emprestimo emprestimo = emprestimos.FirstOrDefault(e => e.Id == id && e.DataDevolucao == null);

            if (emprestimo == null)
            {
                Console.WriteLine("Empréstimo não encontrado ou já devolvido");
                return;
            }

            emprestimo.DataDevolucao = DateTime.Now;
            Livro livro = livros.FirstOrDefault(l => l.Id == emprestimo.LivroId);
            livro.Disponivel = true;

            Console.WriteLine("Livro devolvido com sucesso!");
        }

        private void HistoricoEmprestimosUsuarios()
        {
            Console.Write("Id do Usuário: ");
            int usuarioId = Convert.ToInt32(Console.ReadLine());

            List<Emprestimo> historico = emprestimos.Where(e => e.UsuarioId == usuarioId).ToList();

            foreach(Emprestimo emprestimo in historico)
            {
                Livro livro = livros.FirstOrDefault(l => l.Id == emprestimo.LivroId);

                string devolucao = emprestimo.DataDevolucao.HasValue ? emprestimo.DataDevolucao?.ToShortDateString() : "Em aberto";

                Console.WriteLine($"Livro: {livro.Titulo} | Empréstimo: {emprestimo.DataEmprestimo.ToShortDateString()} | Devolução: {devolucao}");
            }
        }
    }
}