using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Izveidojam aplikāciju, kas pieprasa lietotājam ievadīt kādu vārdu, un vārdnīcā sameklē visus vārdus, ko iespējams saveidot no ievadītā vārda burtiem. 
//(vārdnīcas fails pieejams https://github.com/dwyl/english-words un arī citās vietās)
	
	// palūdzam lietotājam ievadīt vārdu, kura burtus izmantot meklēšanai
	// ielādējam visus vārdus no vārdnīcas faila
	// izmantojot ciklu apstrādājam katru vārdu no vārdnīcas faila
		// izveidojam mainīgo, kurā piefiksēsim to, vai vārdā ir kādi nevajadzīgi burti 
		// izmantojot ciklu, apstrādājam katru burtu lietotāja ievadītajā vārdā
			// pārbaudam, vai burts atrodas vārdnīcas vārdā
				// ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
		// izmantojot ciklu, apstrādājam katru burtu vārdnīcas vārdā
			// pārbaudām, vai burts ir atrasts lietotāja ievadītajā vārdā
				// ja neatrodas, tad piefiksējam, ka lieks burts ir atrasts
		// kad vārdu apstrāde pa burtiem beigusies,
		// pārbaudām vai vārdnīcas vārdā ir atrasti nevajadzīgi burti
			// ja nav, tad izvadām vārdu uz ekrāna

namespace VārduKārtošanasApp
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
