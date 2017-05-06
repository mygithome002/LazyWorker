using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MountPetGenerator
{
    class TitleGenerator
    {
        public static void GenerateTitle(string TitleNameMale, string TitleNameFemale, int ID, string Format)
        {
            string frFR, enGB, esES, deDE, enUS, esMX, ruRU; // Cache;
            string result;

            frFR = File.ReadAllText(@".\Titles\\Modified\\frFR\\CharTitles.dbc.csv");
            enGB = File.ReadAllText(@".\Titles\\Modified\\enGB\\CharTitles.dbc.csv");
            esES = File.ReadAllText(@".\Titles\\Modified\\esES\\CharTitles.dbc.csv");
            deDE = File.ReadAllText(@".\Titles\\Modified\\deDE\\CharTitles.dbc.csv");
            enUS = File.ReadAllText(@".\Titles\\Modified\\enUS\\CharTitles.dbc.csv");
            esMX = File.ReadAllText(@".\Titles\\Modified\\esMX\\CharTitles.dbc.csv");
            ruRU = File.ReadAllText(@".\Titles\\Modified\\ruRU\\CharTitles.dbc.csv");

            //if (File.Exists(@".\Titles\Modified\Cache\frFR\Chartitles.text"))
            //    Cache = File.ReadAllText(@".\Titles\Modified\Cache\frFR\Chartitles.text");

            result = "";

            result += ID;
            result += ",";
            result += "REPLACETHIS1";
            result += "\"" + TitleNameMale + "\"";
            result += "REPLACETHIS2";
            result += "\"" + TitleNameFemale + "\"";
            result += "REPLACETHIS3";
            result += ID;
            result += "\n";

            File.WriteAllText("./Titles/Modified/frFR/CharTitles.dbc.csv", frFR.ToString() + result.Replace("REPLACETHIS1", "0,0,0,").Replace("REPLACETHIS2", ",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,").Replace("REPLACETHIS3", ",0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,"));
            File.WriteAllText("./Titles/Modified/enGB/CharTitles.dbc.csv", enGB.ToString() + result.Replace("REPLACETHIS1", "0,").Replace("REPLACETHIS2", ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,").Replace("REPLACETHIS3", ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,"));
            File.WriteAllText("./Titles/Modified/esES/CharTitles.dbc.csv", esES.ToString() + result.Replace("REPLACETHIS1", "0,0,0,0,0,0,0,").Replace("REPLACETHIS2", ",0,0,0,0,0,0,0,0,0,16712190,0,0,0,0,0,0,").Replace("REPLACETHIS3", ",0,0,0,0,0,0,0,0,0,16712190,"));
            File.WriteAllText("./Titles/Modified/deDE/CharTitles.dbc.csv", deDE.ToString() + result.Replace("REPLACETHIS1", "0,0,0,0,").Replace("REPLACETHIS2", ",0,0,0,0,0,0,0,0,0,0,0,0,16712190,0,0,0,").Replace("REPLACETHIS3", ",0,0,0,0,0,0,0,0,0,0,0,0,16712190,"));
            File.WriteAllText("./Titles/Modified/enUS/CharTitles.dbc.csv", enUS.ToString() + result.Replace("REPLACETHIS1", "0,").Replace("REPLACETHIS2", ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,").Replace("REPLACETHIS3", ",0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,16712190,"));
            File.WriteAllText("./Titles/Modified/esMX/CharTitles.dbc.csv", esMX.ToString() + result.Replace("REPLACETHIS1", "0,0,0,0,0,0,0,0,").Replace("REPLACETHIS2", ",0,0,0,0,0,0,0,0,16712190,0,0,0,0,0,0,0,").Replace("REPLACETHIS3", ",0,0,0,0,0,0,0,0,16712190,"));
            File.WriteAllText("./Titles/Modified/ruRU/CharTitles.dbc.csv", ruRU.ToString() + result.Replace("REPLACETHIS1", "0,0,0,0,0,0,0,0,0,").Replace("REPLACETHIS2", ",0,0,0,0,0,0,0,16712190,0,0,0,0,0,0,0,0,").Replace("REPLACETHIS3", ",0,0,0,0,0,0,0,16712190,"));
        }

        public static void TitleMergeToDbc()
        {
            Process.Start(@".\Titles\Modified\WoWParser2_CSV_to_DBC.exe");
            Thread.Sleep(5000);

            if (File.Exists("./Titles/Modified/frFR/CharTitles.dbc") || File.Exists("./Titles/Modified/enGB/CharTitles.dbc") || File.Exists("./Titles/Modified/esES/CharTitles.dbc") || File.Exists("./Titles/Modified/deDE/CharTitles.dbc") ||
                File.Exists("./Titles/Modified/enUS/CharTitles.dbc") || File.Exists("./Titles/Modified/esMX/CharTitles.dbc") || File.Exists("./Titles/Modified/ruRU/CharTitles.dbc"))
            {
                File.Delete("./Titles/Modified/frFR/CharTitles.dbc");
                File.Delete("./Titles/Modified/enGB/CharTitles.dbc");
                File.Delete("./Titles/Modified/esES/CharTitles.dbc");
                File.Delete("./Titles/Modified/deDE/CharTitles.dbc");
                File.Delete("./Titles/Modified/enUS/CharTitles.dbc");
                File.Delete("./Titles/Modified/esMX/CharTitles.dbc");
                File.Delete("./Titles/Modified/ruRU/CharTitles.dbc");
            }
            File.Move("./Titles/Modified/frFR/CharTitles.dbc.csv.dbc", "./Titles/Modified/frFR/CharTitles.dbc");
            File.Move("./Titles/Modified/enGB/CharTitles.dbc.csv.dbc", "./Titles/Modified/enGB/CharTitles.dbc");
            File.Move("./Titles/Modified/esES/CharTitles.dbc.csv.dbc", "./Titles/Modified/esES/CharTitles.dbc");
            File.Move("./Titles/Modified/deDE/CharTitles.dbc.csv.dbc", "./Titles/Modified/deDE/CharTitles.dbc");
            File.Move("./Titles/Modified/enUS/CharTitles.dbc.csv.dbc", "./Titles/Modified/enUS/CharTitles.dbc");
            File.Move("./Titles/Modified/esMX/CharTitles.dbc.csv.dbc", "./Titles/Modified/esMX/CharTitles.dbc");
            File.Move("./Titles/Modified/ruRU/CharTitles.dbc.csv.dbc", "./Titles/Modified/ruRU/CharTitles.dbc");

            foreach (var process in Process.GetProcessesByName("WoWParser2_CSV_to_DBC"))
            {
                process.Kill();
            }
        }
    }
}
