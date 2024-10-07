/*
 * Inject CSV  INSEE DATABASE
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
using System.Xml.Linq;
using System.Text.RegularExpressions;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace InseeInject
{
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int i = 0;
            int j = 0;
            

            StreamReader reader;

            string line = "";

            string[] files = {
           /*
            * Télécharger les fichiers dans votre ordinateur depuis :
            * https://www.data.gouv.fr/en/datasets/base-sirene-des-entreprises-et-de-leurs-etablissements-siren-siret/#/resources
            * et indiquez ici, les liens vers les fichiers comme ceci ou créer un Form1.cs pour le faire automatiquement
            * 
            * Les fichiers étant YowZa plus de 1GO
            * 
            */
            
            "C:\\Users\\Desktop\\StockEtablissement_utf8\\StockEtablissement_utf8.csv__27.csv",
            "C:\\Users\\Desktop\\StockEtablissement_utf8\\StockEtablissement_utf8.csv__28.csv",
            "C:\\Users\\Desktop\\StockEtablissement_utf8\\StockEtablissement_utf8.csv__29.csv",
            "C:\\Users\\Desktop\\StockEtablissement_utf8\\StockEtablissement_utf8.csv__30.csv"
            };

            foreach(string file in files) { 

            FileStream myStream = new FileStream(file, FileMode.Open);
            {
                    using (myStream)
                    {

                        reader = new StreamReader(myStream, Encoding.Default);



                        while (reader.Peek() >= 0)
                        {


                            string[] data = reader.ReadLine().Split(',');

                            if (data.Length<47) { continue; i++; }
                            else
                            {
                                                           
                                line += "INSERT INTO insee (siren,nic,siret,statutDiffusionEtablissement," +
                                "dateCreationEtablissement,trancheEffectifsEtablissement," +
                                "anneeEffectifsEtablissement,activitePrincipaleRegistreMetiersEtablissement," +
                                "dateDernierTraitementEtablissement,etablissementSiege,nombrePeriodesEtablissement," +
                                "complementAdresseEtablissement,numeroVoieEtablissement," +
                                "indiceRepetitionEtablissement,typeVoieEtablissement," +
                                "libelleVoieEtablissement,codePostalEtablissement,libelleCommuneEtablissement," +
                                "libelleCommuneEtrangerEtablissement,distributionSpecialeEtablissement," +
                                "codeCommuneEtablissement,codeCedexEtablissement,libelleCedexEtablissement," +
                                "codePaysEtrangerEtablissement,libellePaysEtrangerEtablissement," +
                                "complementAdresse2Etablissement,numeroVoie2Etablissement," +
                                "indiceRepetition2Etablissement,typeVoie2Etablissement," +
                                "libelleVoie2Etablissement,codePostal2Etablissement,libelleCommune2Etablissement," +
                                "libelleCommuneEtranger2Etablissement,distributionSpeciale2Etablissement," +
                                "codeCommune2Etablissement,codeCedex2Etablissement,libelleCedex2Etablissement," +
                                "codePaysEtranger2Etablissement,libellePaysEtranger2Etablissement, dateDebut," +
                                " etatAdministratifEtablissement, enseigne1Etablissement, enseigne2Etablissement," +
                                " enseigne3Etablissement, denominationUsuelleEtablissement," +
                                " activitePrincipaleEtablissement, nomenclatureActivitePrincipaleEtablissement," +
                                " caractereEmployeurEtablissement) values ('"+
                                data[0].Replace("'","''") + "', '"+
                                data[1].Replace("'","''") + "', '" +
                                data[2].Replace("'","''") + "', '" +
                                data[3].Replace("'","''") + "', '" +
                                data[4].Replace("'","''") + "', '" +
                                data[5].Replace("'","''") + "', '" +
                                data[6].Replace("'","''") + "', '" +
                                data[7].Replace("'","''") + "', '" +
                                data[8].Replace("'","''") + "', '" +
                                data[9].Replace("'","''") + "', '" +
                                data[10].Replace("'","''") + "', '" +
                                data[11].Replace("'","''") + "', '" +
                                data[12].Replace("'","''") + "', '" +
                                data[13].Replace("'","''") + "', '" +
                                data[14].Replace("'","''") + "', '" +
                                data[15].Replace("'","''") + "', '" +
                                data[16].Replace("'","''") + "', '" +
                                data[17].Replace("'","''") + "', '" +
                                data[18].Replace("'","''") + "', '" +
                                data[19].Replace("'","''") + "', '" +
                                data[20].Replace("'","''") + "', '" +
                                data[21].Replace("'","''") + "', '" +
                                data[22].Replace("'","''") + "', '" +
                                data[23].Replace("'","''") + "', '" +
                                data[24].Replace("'","''") + "', '" +
                                data[25].Replace("'","''") + "', '" +
                                data[26].Replace("'","''") + "', '" +
                                data[27].Replace("'","''") + "', '" +
                                data[28].Replace("'","''") + "', '" +
                                data[29].Replace("'","''") + "', '" +
                                data[30].Replace("'","''") + "', '" +
                                data[31].Replace("'","''") + "', '" +
                                data[32].Replace("'","''") + "', '" +
                                data[33].Replace("'","''") + "', '" +
                                data[34].Replace("'","''") + "', '" +
                                data[35].Replace("'","''") + "', '" +
                                data[36].Replace("'","''") + "', '" +
                                data[37].Replace("'","''") + "', '" +
                                data[38].Replace("'","''") + "', '" +
                                data[39].Replace("'","''") + "', '" +
                                data[40].Replace("'","''") + "', '" +
                                data[41].Replace("'","''") + "', '" + 
                                data[42].Replace("'","''") + "', '" +
                                data[43].Replace("'","''") + "', '" +
                                data[44].Replace("'","''") + "', '" +
                                data[45].Replace("'","''") + "', '" +
                                data[46].Replace("'","''") + "', '" +
                                data[47].Replace("'","''") + "');\r\n"; i++;

                            }

                            if (i == 5000)
                            {


                                j++;
                                save(line, file,j); line = "";
                                i = 0;
                            }
       
                                i++;

                                Console.WriteLine(file.Replace("C:\\Users\\phil\\Desktop\\StockEtablissement_utf8\\","")+" "+ i.ToString());
                                read(data);
                            }
                        }
                        }
                    }
                }
               // Console.WriteLine("Importation de terminée");
        }
                

        private static void save(string data, string fileName, int j)
        {
          //  Console.WriteLine(data+" \r\r\r\r\n");   

            FileStream fs = File.OpenWrite(fileName.Replace(".csv","__"+ j.ToString()+".csv"));

            byte[] bytes = Encoding.UTF8.GetBytes(data);

            fs.Write(bytes, 0, bytes.Length);
        }


            private static void read(string[] data)
        {
            try { 
            SqlConnection connection = new SqlConnection("Data Source=JAMES\\SQLEXPRESS;Initial Catalog=bodac;Integrated Security=True;Connect Timeout=10;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            connection.Open();

            /*
           SqlCommand cmd = new SqlCommand("SELECT count(id) FROM insee where siret=@Siret", connection);
                                                 SqlParameter param = new SqlParameter();
                                                 param.ParameterName = "@Siret";
                                                  param.Value = data[2];
                                                 cmd.Parameters.Add(param);


              int count = (int)cmd.ExecuteScalar();

              if (count > 0) { connection.Close(); }
              else
              */
                    {

                    //insert
                    SqlCommand cmd = new SqlCommand("INSERT INTO insee (siren,nic,siret,statutDiffusionEtablissement,dateCreationEtablissement,trancheEffectifsEtablissement,anneeEffectifsEtablissement,activitePrincipaleRegistreMetiersEtablissement,dateDernierTraitementEtablissement,etablissementSiege,nombrePeriodesEtablissement,complementAdresseEtablissement,numeroVoieEtablissement,indiceRepetitionEtablissement,typeVoieEtablissement,libelleVoieEtablissement,codePostalEtablissement,libelleCommuneEtablissement,libelleCommuneEtrangerEtablissement,distributionSpecialeEtablissement,codeCommuneEtablissement,codeCedexEtablissement,libelleCedexEtablissement,codePaysEtrangerEtablissement,libellePaysEtrangerEtablissement,complementAdresse2Etablissement,numeroVoie2Etablissement,indiceRepetition2Etablissement,typeVoie2Etablissement,libelleVoie2Etablissement,codePostal2Etablissement,libelleCommune2Etablissement,libelleCommuneEtranger2Etablissement,distributionSpeciale2Etablissement,codeCommune2Etablissement,codeCedex2Etablissement,libelleCedex2Etablissement,codePaysEtranger2Etablissement,libellePaysEtranger2Etablissement, dateDebut, etatAdministratifEtablissement, enseigne1Etablissement, enseigne2Etablissement, enseigne3Etablissement, denominationUsuelleEtablissement, activitePrincipaleEtablissement, nomenclatureActivitePrincipaleEtablissement, caractereEmployeurEtablissement) values(@Siren,@Nic,@Siret,@StatutDiffusionEtablissement,@DateCreationEtablissement,@TrancheEffectifsEtablissement,@AnneeEffectifsEtablissement,@ActivitePrincipaleRegistreMetiersEtablissement,@DateDernierTraitementEtablissement,@EtablissementSiege,@NombrePeriodesEtablissement,@ComplementAdresseEtablissement,@NumeroVoieEtablissement,@IndiceRepetitionEtablissement,@TypeVoieEtablissement,@LibelleVoieEtablissement,@CodePostalEtablissement,@LibelleCommuneEtablissement,@LibelleCommuneEtrangerEtablissement,@DistributionSpecialeEtablissement,@CodeCommuneEtablissement,@CodeCedexEtablissement,@LibelleCedexEtablissement,@CodePaysEtrangerEtablissement,@LibellePaysEtrangerEtablissement,@ComplementAdresse2Etablissement,@NumeroVoie2Etablissement,@IndiceRepetition2Etablissement,@TypeVoie2Etablissement,@LibelleVoie2Etablissement,@CodePostal2Etablissement,@LibelleCommune2Etablissement,@LibelleCommuneEtranger2Etablissement,@DistributionSpeciale2Etablissement,@CodeCommune2Etablissement,@CodeCedex2Etablissement,@LibelleCedex2Etablissement,@CodePaysEtranger2Etablissement,@LibellePaysEtranger2Etablissement,@DateDebut,@EtatAdministratifEtablissement,@Enseigne1Etablissement,@Enseigne2Etablissement,@Enseigne3Etablissement,@DenominationUsuelleEtablissement,@ActivitePrincipaleEtablissement,@NomenclatureActivitePrincipaleEtablissement,@CaractereEmployeurEtablissement)", connection);
                    SqlParameter param = new SqlParameter();
                        param.ParameterName = "@Siren";
                        param.Value = data[0];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@Nic";
                        param.Value = data[1];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@Siret";
                        param.Value = data[2];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@StatutDiffusionEtablissement";
                        param.Value = data[3];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@DateCreationEtablissement";
                        param.Value = data[4];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@TrancheEffectifsEtablissement";
                        param.Value = data[5];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@AnneeEffectifsEtablissement";
                        param.Value = data[6];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@ActivitePrincipaleRegistreMetiersEtablissement";
                        param.Value = data[7];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@DateDernierTraitementEtablissement";
                        param.Value = data[8];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@EtablissementSiege";
                        param.Value = data[9];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@NombrePeriodesEtablissement";
                        param.Value = data[10];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@ComplementAdresseEtablissement";
                        param.Value = data[11];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@NumeroVoieEtablissement";
                        param.Value = data[12];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@IndiceRepetitionEtablissement";
                        param.Value = data[13];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@TypeVoieEtablissement";
                        param.Value = data[14];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleVoieEtablissement";
                        param.Value = data[15];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodePostalEtablissement";
                        param.Value = data[16];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleCommuneEtablissement";
                        param.Value = data[17];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleCommuneEtrangerEtablissement";
                        param.Value = data[18];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@DistributionSpecialeEtablissement";
                        param.Value = data[19];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodeCommuneEtablissement";
                        param.Value = data[20];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodeCedexEtablissement";
                        param.Value = data[21];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleCedexEtablissement";
                        param.Value = data[22];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodePaysEtrangerEtablissement";
                        param.Value = data[23];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibellePaysEtrangerEtablissement";
                        param.Value = data[24];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@ComplementAdresse2Etablissement";
                        param.Value = data[25];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@NumeroVoie2Etablissement";
                        param.Value = data[26];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@IndiceRepetition2Etablissement";
                        param.Value = data[27];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@TypeVoie2Etablissement";
                        param.Value = data[28];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleVoie2Etablissement";
                        param.Value = data[29];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodePostal2Etablissement";
                        param.Value = data[30];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleCommune2Etablissement";
                        param.Value = data[31];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleCommuneEtranger2Etablissement";
                        param.Value = data[32];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@DistributionSpeciale2Etablissement";
                        param.Value = data[33];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodeCommune2Etablissement";
                        param.Value = data[34];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodeCedex2Etablissement";
                        param.Value = data[35];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibelleCedex2Etablissement";
                        param.Value = data[36];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CodePaysEtranger2Etablissement";
                        param.Value = data[37];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@LibellePaysEtranger2Etablissement";
                        param.Value = data[38];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@DateDebut";
                        param.Value = data[39];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@EtatAdministratifEtablissement";
                        param.Value = data[40];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@Enseigne1Etablissement";
                        param.Value = data[41];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@Enseigne2Etablissement";
                        param.Value = data[42];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@Enseigne3Etablissement";
                        param.Value = data[43];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@DenominationUsuelleEtablissement";
                        param.Value = data[44];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@ActivitePrincipaleEtablissement";
                        param.Value = data[45];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@NomenclatureActivitePrincipaleEtablissement";
                        param.Value = data[46];
                        cmd.Parameters.Add(param);

                        param = new SqlParameter();
                        param.ParameterName = "@CaractereEmployeurEtablissement";
                        param.Value = data[47];
                        cmd.Parameters.Add(param);

                        cmd.ExecuteNonQuery();
                    
                }

                connection.Close();
            }

            catch (Exception ex) { Console.WriteLine("\r\n[[[[[["+ ex.Message+"]]]]]]\r\n"); }
        }
    }
}