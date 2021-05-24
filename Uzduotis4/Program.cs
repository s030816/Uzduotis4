using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uzduotis4
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
            //Application.Run(new Form1());
        }
    }
}
// Register function
// Clipboard copy +
// Delete function +
// Searchbox +
// Random pw generator +
// Hide/unhide pw
// Accounts as separate txt files in working directory
// Dump data to .txt file


/*
 Privalomos slapta�od�i� valdymo sistemos funkcijos:

    Paleidus sistem� pirm� kart� sukuriamas .csv arba .txt failas. I�jungiant sistem� �is failas turi b�ti u��ifruojamas AES algoritmu. Kit� kart� paleidus sistem� failas yra de�ifruojamas. (4 ta�kai)
    //Naujo slapta�od�io i�saugojimas: u�pild�ius form� (pavadinimas, slapta�odis, URL/aplikacija, komentaras), visa jos informacija saugojama .csv arba .txt faile. Slapta�od�iui pritaikomas �ifravimo algoritmas (pvz.: AES, DES ar RSA. Renkat�s savo nuo�i�ra). (3 ta�kai)
    //Slapta�od�io paie�ka pagal pavadinim�. (2 ta�kai)
    Slapta�od�io atnaujinimas pagal pavadinim�: suradus tinkam� slapta�od� jis pakei�iamas naujai �vestu. Naujam slapta�od�iui taip pat turi b�ti pritaikytas �ifravimo algoritmas. (2 ta�kai) 
    //Slapta�od�io i�trynimas pagal pavadinim�: suradus tinkam� slapta�od� visa informacija apie j� i�trinama i� .csv arba .txt failo. (2 ta�kai)

Papildomos funkcijos:

    Paleidus sistem� pirm� kart� reikalinga vartotojo paskyros suk�rimo forma: slapyvardis, slapta�odis (�ifruojamas PBKDF2, Bcrypt, Scrypt, Argon2 arba pasirenkant mai�os funkcij�). 
Kuriant vartotojo paskyr� yra sugeneruojamas ir vartotojui priskiriamas .csv arba .txt failas. Failas yra u��ifruojamas AES algoritmu. (3 ta�kai)

    //Prisijungimas prie sistemos: vartotojui prijungus failas de�ifruojamas. (3 ta�kai)
    //Atsitiktinio slapta�od�io generavimo funkcija (panaudojama kuriant nauj� slapta�od�). (2 ta�kai)
    Papildoma funkcija slapta�od�io paie�kai pagal pavadinim�: suradus tinkam� slapta�od� jis i�kart nerodomas, pateikiamas tik jo u��ifruotas rezultatas. 
Paspaudus mygtuk� rodyti parodomas slapta�odis. (2 ta�kai)
 */