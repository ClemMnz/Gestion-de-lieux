using BO;
using DAL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class LieuBLL : IcrudBLL<Lieu>
    {
        /// <summary>
        /// représente la fonction  qui permet de creer un Lieu 
        /// fait appel à la DAL qui utilise le singleton 
        /// retourne un booléen
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Create(Lieu item)
        {
            return LieuDAL.GetInstance().Create(item); 
        }


        /// <summary>
        /// Représente la fonction qui permet de supprimer un lieu créé
        /// Fait apprel à la DAL  qui utilise le singleton pour la suppression
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Lieu item)
        {
            return LieuDAL.GetInstance().Delete(item); 

        }


        /// <summary>
        /// Représente la fonction qui permet de modifier un lieu créé
        /// Retourne un booléen
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Lieu item)
        {
            return LieuDAL.GetInstance().Update(item);
        }

        /// <summary>
        /// Représente la fonction qui lit une liste de lieux créés
        /// fait appel à la DAL qui utilise le singleton 
        /// </summary>
        /// <returns></returns>
        public List<Lieu> Get()
        {
            return LieuDAL.GetInstance().Get();
        }

        /// <summary>
        /// Représente la fonction qui lit un lieu créé
        /// Fait appel à la Dal qui utilise le singleton 
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public Lieu Get(Lieu item)
        {
            return LieuDAL.GetInstance().Get(item);
        }

       

        #region Singleton
        /// <summary>
        /// Représente l'objet vide du singleton
        /// </summary>

        private static LieuBLL instance= null; 


        /// <summary>
        /// Représente le constructeur du singleton
        /// </summary>
        private LieuBLL()
        {


        }

        /// <summary>
        /// Fonction qui permet de créer un nouvel objet 
        /// </summary>
        /// <returns></returns>
        public static  LieuBLL GetInstance()
        {
            if (instance == null)
            {
                instance = new LieuBLL();

            }
            return instance; 
        }

        /// <summary>
        /// Fonction qui permet de lire les données de l'objet créé 
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public Lieu itemBuilder(SqlDataReader dr)
        {
            return instance.itemBuilder(dr);
        }

        #endregion Singleton 

    }
}
