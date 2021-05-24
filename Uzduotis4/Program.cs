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
 Privalomos slaptaþodþiø valdymo sistemos funkcijos:

    Paleidus sistemà pirmà kartà sukuriamas .csv arba .txt failas. Iðjungiant sistemà ðis failas turi bûti uþðifruojamas AES algoritmu. Kità kartà paleidus sistemà failas yra deðifruojamas. (4 taðkai)
    //Naujo slaptaþodþio iðsaugojimas: uþpildþius formà (pavadinimas, slaptaþodis, URL/aplikacija, komentaras), visa jos informacija saugojama .csv arba .txt faile. Slaptaþodþiui pritaikomas ðifravimo algoritmas (pvz.: AES, DES ar RSA. Renkatës savo nuoþiûra). (3 taðkai)
    //Slaptaþodþio paieðka pagal pavadinimà. (2 taðkai)
    Slaptaþodþio atnaujinimas pagal pavadinimà: suradus tinkamà slaptaþodá jis pakeièiamas naujai ávestu. Naujam slaptaþodþiui taip pat turi bûti pritaikytas ðifravimo algoritmas. (2 taðkai) 
    //Slaptaþodþio iðtrynimas pagal pavadinimà: suradus tinkamà slaptaþodá visa informacija apie já iðtrinama ið .csv arba .txt failo. (2 taðkai)

Papildomos funkcijos:

    Paleidus sistemà pirmà kartà reikalinga vartotojo paskyros sukûrimo forma: slapyvardis, slaptaþodis (ðifruojamas PBKDF2, Bcrypt, Scrypt, Argon2 arba pasirenkant maiðos funkcijà). 
Kuriant vartotojo paskyrà yra sugeneruojamas ir vartotojui priskiriamas .csv arba .txt failas. Failas yra uþðifruojamas AES algoritmu. (3 taðkai)

    //Prisijungimas prie sistemos: vartotojui prijungus failas deðifruojamas. (3 taðkai)
    //Atsitiktinio slaptaþodþio generavimo funkcija (panaudojama kuriant naujà slaptaþodá). (2 taðkai)
    Papildoma funkcija slaptaþodþio paieðkai pagal pavadinimà: suradus tinkamà slaptaþodá jis iðkart nerodomas, pateikiamas tik jo uþðifruotas rezultatas. 
Paspaudus mygtukà rodyti parodomas slaptaþodis. (2 taðkai)
 */