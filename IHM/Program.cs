using BLL;
using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IHM
{
    public class Program
    {
        static void Main(string[] args)
        {
           
            //Création de nouveaux objets lieux

            Lieu lieu1 = new Lieu(1, "maVille", "Rennes", 35200, DateTime.Parse("01 / 09 / 2012"));
            Lieu lieu2 = new Lieu(2, "Ville2", "Brest", 29200, DateTime.Parse("01 / 07/ 1988"));
            Lieu lieu3 = new Lieu(3, "Ville3", "Nantes", 44000, DateTime.Parse("01/04/2009"));


            //
            LieuBLL.GetInstance().Create(lieu1);
            LieuBLL.GetInstance().Create(lieu2);
            LieuBLL.GetInstance().Delete(lieu2);
            LieuBLL.GetInstance().Create(lieu3);
            lieu3.Nom = "NouvelleVille"; 
            LieuBLL.GetInstance().Update(lieu3);

            List<Lieu> liste = new List<Lieu>();
            liste.Add(lieu1);
            liste.Add(lieu2);
            liste.Add(lieu3);
            liste.ToString();
            LieuBLL.GetInstance().Get();





            Console.ReadKey(); 
        }
    }
}
