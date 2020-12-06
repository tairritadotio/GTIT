using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Diagnostics.Eventing;
namespace GTIT
{
   
   public class Runner
    {
       private static string _retorno = "";
        //Fala nenhum mal
        public static void WhatTimeIS()
        {
            _retorno = DateTime.Now.ToShortTimeString();
            SPEAKER.Speak(_retorno);
        }
        public static void WhatDateIS()
        {
           _retorno = DateTime.Now.ToShortDateString();
           SPEAKER.Speak(_retorno);
        }
        public string resposta()
        {
            return _retorno;
        }
        public void setresposta(string r)
        {
            _retorno = r;
        }
        //Abrir Programas
        public static void AbrirVS()
        {
            SPEAKER.Speak("Por favor configure o atalho em runner");
            System.Diagnostics.Process.Start("https://www.google.com");

        }
        public static void AbrirVSCode()
        {
            SPEAKER.Speak("Por favor configure o atalho em runner");
            System.Diagnostics.Process.Start("https://www.google.com");

        }
        public static void AbirNota()
        {
            SPEAKER.Speak("Entendido: bloco de notas");
            System.Diagnostics.Process.Start("notepad.exe");
        }
        public static void FecharNotas()
        {
            foreach (var process in Process.GetProcessesByName("notepad"))
            {
                process.CloseMainWindow();
                SPEAKER.Speak("Fechado");

            }


        }
        //Internet
        public static void OpenBrowser()
        {
            SPEAKER.Speak("Por favor configure o atalho em runner");
            System.Diagnostics.Process.Start("https://www.google.com");

        }
        public static void PesquisaGoogle()
        {
            SPEAKER.Speak("Por favor configure o atalho em runner");
            System.Diagnostics.Process.Start("https://www.google.com");

        }
        public static void FecharGoogle()
        {
            foreach (var process in Process.GetProcessesByName(""))
            {
                process.CloseMainWindow();
            }


        }


    }
}