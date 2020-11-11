using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Lieu
    {
        /// <summary>
        /// Représente l'identifiant du lieu
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Représente le nom du lieu
        /// </summary>
        public string Nom { get; set; }

        /// <summary>
        /// Représente la ville du lieu 
        /// </summary>
        public string Ville { get; set; }

        /// <summary>
        /// Représente le code postal du lieu 
        /// </summary>
        public int Cp { get; set;  }

        /// <summary>
        /// Représente la date de visite du lieu
        /// </summary>
        public DateTime DatedeVisite { get; set; }

        /// <summary>
        /// Représente le constructeur vide de l'objet Lieu
        /// </summary>
        public Lieu()
        {

        }

        /// <summary>
        /// Représente le constructeur surchargé de l'objet lieu
        /// +Chainage de constructeur
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nom"></param>
        /// <param name="ville"></param>
        /// <param name="cp"></param>
        /// <param name="dateDeVisite"></param>
        public Lieu(int id , string nom, string ville, int cp, DateTime dateDeVisite): this()
        {
            this.Id = id;
            this.Nom = nom;
            this.Ville = ville;
            this.Cp = cp;
            this.DatedeVisite = dateDeVisite; 

        }


        /// <summary>
        /// Représente la fonction d'affichage de l'objet Lieu
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return string.Format("Id: {0} ,Nom: {1}, Ville: {2}, Code Postal : {3}, Date de visite: {4}", Id, Nom, Ville , Cp, DatedeVisite );
        }




    }
}
