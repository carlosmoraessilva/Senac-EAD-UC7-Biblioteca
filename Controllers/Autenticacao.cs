using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Biblioteca.Models;
using System.Linq;
using System.Collections.Generic;

namespace Biblioteca.Controllers

{
public class Autenticacao

    {

        public static void CheckLogin(Controller controller)

        {   

            if(string.IsNullOrEmpty(controller.HttpContext.Session.GetString("login")))

            {

                controller.Request.HttpContext.Response.Redirect("/Home/Login");

            }

        }

    public static bool verificaLoginSenha(string login, string senha, Controller controller)

        {

            using(BibliotecaContext bc = new BibliotecaContext())

            {

                verificaSeUsuarioAdminExiste(bc);



                senha = Criptografia.GerarMD5(senha);



                IQueryable<Usuario> UsuarioEncontrado = bc.Usuarios.Where(u => u.login==login && u.senha==senha);

                List<Usuario>ListaUsuarioEncontrado = UsuarioEncontrado.ToList();



                if(ListaUsuarioEncontrado.Count==0)

                {

                    return false;

                }

                else

                {

                    controller.HttpContext.Session.SetString("login",ListaUsuarioEncontrado[0].login);

                    controller.HttpContext.Session.SetString("Nome",ListaUsuarioEncontrado[0].Nome);

                    controller.HttpContext.Session.SetInt32("tipo",ListaUsuarioEncontrado[0].tipo);

                    return true;

                }

            }

        }

        public static void verificaSeUsuarioAdminExiste(BibliotecaContext bc)

        {

            IQueryable<Usuario> userEncontrado = bc.Usuarios.Where(u => u.login=="admin");



                if(userEncontrado.ToList().Count==0)

                {
                    
                    Usuario admin = new Usuario();

                    admin.login = "admin";

                    admin.senha = Criptografia.GerarMD5("123");

                    admin.tipo = Usuario.ADMIN;

                    admin.Nome = "Administrador";

                    

                    bc.Usuarios.Add(admin);

                    bc.SaveChanges();

                }

        }



        public static void verificaSeUsuarioEAdmin(Controller controller)

        {

            if(!(controller.HttpContext.Session.GetInt32("tipo")==Usuario.ADMIN))

            {

                controller.Request.HttpContext.Response.Redirect("/Usuarios/NeedAdmin");

            }

        }

    }

}