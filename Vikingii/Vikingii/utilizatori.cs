using System;
using System.Collections.Generic;
using System.Text;

namespace Imperiul_Britanic
{
    class utilizatori
    {
        public static string gen;
        public static string mail;
        public static string nume;
        public static string img;
        public static string clasa;
        public static string id;
        public static string tip;
        public static string acceptat;
        public static bool logat = false;
        public static int[] insigne = new int[20];
        public static int test = 0;
        public utilizatori()
        {

        }

        public static void deconectare()
        {
            utilizatori.logat = false;
            utilizatori.gen = "";
            utilizatori.nume = "";
            utilizatori.mail = "";
            utilizatori.clasa = "";
            utilizatori.img = "";
            utilizatori.id = "";
            utilizatori.tip = "";
            utilizatori.acceptat = "";
            for (int i = 0; i < insigne.Length; i++)
                insigne[i] = 0;
        }
    }
}
