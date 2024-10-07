/*
 * Inject XML INSEE DATABASE
 * 
 * Copyright@PhilAnalogKid
 * 
 */
 using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Collections.ObjectModel;

namespace Bodacc_search
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }

        private static void start()
        {


            string search = "35410";//35135
            string result = "false";

            string dirLoc = "C:\\Users\\";
            string[] dirs = Directory.GetDirectories(dirLoc);


            foreach (string dir in dirs)
            {

                string[] files = Directory.GetFiles(dir);

                foreach (string file in files)
                {
                    try
                    {

                       // Console.WriteLine(file);

                        //MessageBox.Show(sitemap);
                        // new xdoc instance 
                        XmlDocument doc = new XmlDocument();

                        //load up the xml from the location 
                        doc.Load(file);
                        string denomination = "";
                     
                        string administration = "";//liquidateur
                        string numeroIdentification = "";


                        string activite = "";
                        string adresse = "";

                        XmlNodeList nodes = doc.GetElementsByTagName("avis");

                        foreach (XmlNode node in nodes)
                        {
                            denomination = "";
                            numeroIdentification = "";
                             administration = "";
                         
                            activite = "";
                            adresse = "";

                            foreach (XmlNode child in node.ChildNodes)
                            {
                                if (child.Name == "personnes")
                                {
                                    foreach (XmlNode child1 in child)
                                    {
                                        if (child1.Name == "personne")
                                        {
                                            foreach (XmlNode child2 in child1.ChildNodes)
                                            {
                                                if (child2.Name == "adresse")
                                                {
                                                    foreach (XmlNode child3 in child2.ChildNodes)
                                                    {
                                                        foreach (XmlNode child4 in child3.ChildNodes)
                                                        {

                                                            if (child4.Name == "numeroImmatriculation")
                                                            {
                                                                foreach (XmlNode child5 in child4.ChildNodes)
                                                                {
                                                                    if (child5.Name == "numeroIdentification")
                                                                    {
                                                                        numeroIdentification = child5.InnerText.Replace(" ", "").Trim();
                                                                    }
                                                                }
                                                            }

                                                            if (child4.Name == "numeroVoie")
                                                            {
                                                                adresse = child4.InnerText;
                                                            }
                                                            if (child4.Name == "typeVoie")
                                                            {
                                                                adresse += " " + child4.InnerText;
                                                            }
                                                            if (child4.Name == "nomVoie")
                                                            {
                                                                adresse += " " + child4.InnerText;
                                                            }
                                                            if (child4.Name == "complGeographique")
                                                            {
                                                                adresse += " " + child4.InnerText;
                                                            }

                                                            if (child4.Name == "codePostal")
                                                            {

                                                                if (child4.InnerText == search) { result = "true"; } else { result = "false"; }

                                                                adresse += " " + child4.InnerText;
                                                            }
                                                            if (child4.Name == "ville")
                                                            {
                                                                adresse += " " + child4.InnerText;
                                                            }
                                                        }
                                                    }
                                                }

                                                if (child2.Name == "personnePhysique")
                                                {
                                                    foreach (XmlNode child4 in child2.ChildNodes)
                                                    {

                                                        if (child4.Name == "numeroImmatriculation")
                                                        {
                                                            foreach (XmlNode child5 in child4.ChildNodes)
                                                            {
                                                                if (child5.Name == "numeroIdentification")
                                                                {                                                              
                                                                    numeroIdentification = child5.InnerText.Replace(" ", "").Trim();
                                                                }
                                                            }
                                                        }
                                                        if (child4.Name == "nom")
                                                        {
                                                            denomination = child4.InnerText;
                                                        }
                                                        if (child4.InnerText == "prenom")
                                                        {
                                                            denomination += child4.InnerText;
                                                        }
                                                        if (child4.Name == "numeroVoie")
                                                        {
                                                            adresse = child4.InnerText;
                                                        }
                                                        if (child4.Name == "typeVoie")
                                                        {
                                                            adresse += " " + child4.InnerText;
                                                        }
                                                        if (child4.Name == "nomVoie")
                                                        {
                                                            adresse += " " + child4.InnerText;
                                                        }
                                                        if (child4.Name == "codePostal")
                                                        {

                                                            if (child4.InnerText == search) { result = "true"; } else { result = "false"; }

                                                            adresse += " " + child4.InnerText;
                                                        }
                                                        if (child4.Name == "ville")
                                                        {
                                                            adresse += " "+child4.InnerText;
                                                        }

                                                    }
                                                }

                                                if (child2.Name == "personneMorale")
                                                {
                                                    foreach (XmlNode child4 in child2.ChildNodes)
                                                    {

                                                        if (child4.Name == "numeroImmatriculation")
                                                        {
                                                            foreach (XmlNode child5 in child4.ChildNodes)
                                                            {
                                                                if (child5.Name == "numeroIdentification")
                                                                {
                                                                    numeroIdentification = child5.InnerText.Replace(" ","").Trim();
                                                                }
                                                            }
                                                        }

                                                        if (child4.Name == "denomination")
                                                        {
                                                            denomination = child4.InnerText;
                                                        }
                                                        if (child4.InnerText == "prenom")
                                                        {
                                                            denomination += child4.InnerText;
                                                        }
                                                        if (child4.Name == "numeroVoie")
                                                        {
                                                            adresse = child4.InnerText;
                                                        }
                                                        if (child4.Name == "typeVoie")
                                                        {
                                                            adresse += " " + child4.InnerText;
                                                        }
                                                        if (child4.Name == "nomVoie")
                                                        {
                                                            adresse += " " + child4.InnerText;
                                                        }
                                                        if (child4.Name == "codePostal")
                                                        {

                                                            if (child4.InnerText == search) { result = "true"; } else { result = "false"; }

                                                            adresse += " " + child4.InnerText;
                                                        }
                                                        if (child4.Name == "ville")
                                                        {
                                                            adresse += " " + child4.InnerText;
                                                        }

                                                    }
                                                }


                                                foreach (XmlNode child3 in child2.ChildNodes)
                                                {

                                                    if (child3.Name == "denomination")
                                                    {
                                                        denomination = child3.InnerText;
                                                    }

                                                    if (child3.Name == "administration")
                                                    {
                                                        administration = child3.InnerText;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }

                                else {

                                    foreach (XmlNode child1 in node.ChildNodes)
                                    {
                                        if (child1.Name == "etablissement")
                                        {
                                            foreach (XmlNode child4 in child1.ChildNodes)
                                            {
                                                if (child4.Name == "activite")
                                                {
                                                    activite = child4.InnerText;
                                                }

                                                if (child4.Name == "enseigne")
                                                {
                                                    denomination = child4.InnerText;
                                                }


                                                if (child4.Name == "adresse")
                                                {

                                                    adresse = child4.InnerText;

                                                    if (adresse.IndexOf(search) >-1)
                                                    {

                                                        result = "true";
                                                    }
                                                    else
                                                    {

                                                        result = "false";
                                                    }

                                                }
                                            }
                                        }
                                    }
                                    
                                }
                            }

                            if (result == "true" && administration.IndexOf("liquidateur")<0 
                                && activite!="" && denomination.IndexOf("sci")==-1 &&
                                denomination.IndexOf("s.c.i")==-1 && denomination.IndexOf("SCI")==-1 &&
                                denomination.IndexOf("S.C.I.") == -1 && activite.IndexOf("location")==-1 &&
                                activite.IndexOf("vente") == -1 && activite.IndexOf("acquisition") == -1 &&
                                activite.IndexOf("immeuble") == -1 && activite.IndexOf("gestion") == -1 &&
                                activite.IndexOf("holding") == -1 && activite.IndexOf("participation") == -1)
                            {                                                                                               

                                string res = denomination + "|" + adresse.Trim() + "|" + administration + "|" + activite+"|"+numeroIdentification+"|"+file+"\r\n";
                                                 

                                StreamWriter file2 = new StreamWriter(@"C:\Users\phil\Desktop\bodacc"+"_"+search+".txt", true);
                                file2.WriteLine(res);
                                file2.Close();

                                Console.WriteLine(res);
                            }
                       

                        }
                    }
                    catch (Exception ex) { }
                }
            }
            Console.WriteLine("Recherche terminée");
        }
    }
}
