using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GTIT
{
    public class GrammarRules
        // Hora e data
    {
        public static IList<string> WhatTimeIS = new List<string>()
        {
           "Sistema quantas horas",
           "Quantas horas",
           "Q T R Sistema"
            
        };
    public static IList<string> WhatDateIS = new List<string>()
        {
           "Sistema que dia é hoje"
            
        };
        public static IList<string> GTITStartListening = new List<string>()
        {
           "Q A P Sistema"
        };
        public static IList<string> GTITStopListening = new List<string>()
        {
           "T K S descançar",
           "Para com isso",
           "Descansar Sistema"
        };
        // Comandos tamanho da janela
        public static IList<string> MinimizeWindow = new List<string>()
        {
           "Minimizar"
        };
        public static IList<string> MaximizaWindow = new List<string>()
        {
           "Maximizar"
        };
        public static IList<string> NormalizaWindow = new List<string>()
        {
           "Tamanho normal"
        };
        // Comando da voz
        public static IList<string> ChangeVoice = new List<string>()
        {
           "Alterar voz"
        };
        // Abrir navegador e video do VS
        public static IList<string> OpenProgram = new List<string>()
        {
            "Navegador",
            "Video",
            
            
            
        };
        //Abrir explorador de arquivos
        public static IList<string> MediaPlayComands = new List<string>()
        {
            "Abrir arquivo"
        };
        // Códigos Q, numericos e alfabeto
        public static IList<string> CodeQComands = new List<string>()
        {
            "Sistema código Q"
        };
        public static IList<string> TabNumComands = new List<string>()
        {
            "Sistema tabela de números"
        };
        public static IList<string> TabCodAlfInt = new List<string>()
        {
            "Sistema código do alfabeto"
        };
        // Comando das conversas troll
        public static IList<string> CalaBoca = new List<string>() // Comando do cala a boca
        {
            "Sistema Cala a boca",
            "Cala a boca"
        };
        public static IList<string> VaiSerapagada = new List<string>() // Comando do delete
        {
            "Mas você vai junto"
        };
        public static IList<string> TrollComand = new List<string>() //Comando do troll
        {
            "sistema eu sou bonito"
        };
        // Abir programas
        public static List<string> AbrirVSCode = new List<string>()
        {
            "Sistema abre o v s code",
            "Abrir V S Code"
        };
        public static List<string> AbrirVS = new List<string>()
        {
            "Sistema abre o visual studio",
            "Abrir Visual Studio"
        };
        public static List<string> AbrirNotas = new List<string>()
        {
            "Abrir bloco de notas",
            "Abrir bloco de nota",
            "Fazer anotações"
        };
        public static List<string> FecharNotas = new List<string>()
        {
            "Fechar bloco de notas",
            "Fechar anotações"
        };
        //Internet
        public static List<string> PesquisaGoogle = new List<string>()
        {
            "Abrir google",
            "Fazer pesquiza no google",
            "Google",
            "Visualizar google"
        };
        public static List<string> FecharGoogle = new List<string>()
        {
            "Fechar Google",
            "Fechar Edge",
            "Fechar internet"
        };
        public static List<string> OpenBrowser = new List<string>()
        {
            "Abrir internet",
            "Internet",
            "Sistema abre o Edge",
            "Quero acessar a internet"
        };
    }
}