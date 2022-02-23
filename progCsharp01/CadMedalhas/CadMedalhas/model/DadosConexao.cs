﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadMedalhas.model
{
    public class DadosConexao
    {
        //Atributos
        public string host { get; set; }
        public string usuario { get; set; }
        public string senha { get; set; }
        public string dataBase { get; set; }
        public int porta { get; set; }

        //Construtor
        public DadosConexao(string host, string usuario, string senha, string dataBase, int porta)
        {
            this.host = host;
            this.usuario = usuario;
            this.senha = senha;
            this.dataBase = dataBase;
            this.porta = porta;
        }
        /// <summary>
        /// Dados de conexão para MySQL com a porta padrão 3306
        /// </summary>
        /// <param name="host">Host de conexão</param>
        /// <param name="usuario">Usuário de conexão</param>
        /// <param name="senha">Senha</param>
        /// <param name="dataBase">Nome do banco de dados</param>
        public DadosConexao(string host, string usuario, string senha, string dataBase)
        {
            this.host = host;
            this.usuario = usuario;
            this.senha = senha;
            this.dataBase = dataBase;
            this.porta = 3306;
        }

        //métodos:
        public string ToString()
        {
            string resposta = "host: "     + this.host     + "\n" +
                              "usuario: "  + this.usuario  + "\n" +
                              "senha: "    + this.senha    + "\n" +
                              "dataBase: " + this.dataBase + "\n" +
                              "porta: "    + this.porta;
            return resposta;
        }
    }
}
