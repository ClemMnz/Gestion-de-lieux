using BO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class LieuDAL : Icrud<Lieu>
    {


        /// <summary>
        /// représentent les requêtes qui sont affectés dans des constantes.
        /// </summary>
        public const string INSERT = "INSERT INTO LIEUX VALUES (@Nom,@Ville,@Cp, @DatedeVisite)";
        public const string DELETE = "DELETE LIEUX WHERE Id = @Id";
        public const string UPDATE = "UPDATE LIEUX SET Nom = @Nom ,Ville= @Ville, Cp= @Cp, DatedeVisite= @DatedeVisite WHERE Id=@Id";
        public const string SELECT_BY_ID = "SELECT * FROM LIEUX WHERE Id =@Id";
        public const string SELECT = "SELECT * FROM LIEUX";

        /// <summary>
        /// Nom des colonnes de notre table Lieu
        /// </summary>
        private const string COL_ID = "Id";
        private const string COL_NOM = "Nom";
        private const string COL_VILLE = "Ville";
        private const string COL_CP = "Cp";
        private const string COL_DATE_DE_VISITE = "DatedeVisite";



        /// <summary>
        /// Fonction qui crée une nouvelle ligne(nouvel objet) dans la bdd 
        /// retourne un booléen
        /// renvoie une exception si requête non effectuée
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>

        public bool Create(Lieu item)
        {
            bool resultat = false;

            try
            {
                using (SqlConnection cnx = SqlUtils.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = INSERT;
                    rqt.Parameters.AddWithValue("@Nom", item.Nom);
                    rqt.Parameters.AddWithValue("@Ville", item.Ville);
                    rqt.Parameters.AddWithValue("@Cp", item.Cp);
                    rqt.Parameters.AddWithValue("@DatedeVisite", item.DatedeVisite);

                    resultat = (rqt.ExecuteNonQuery() > 0);

                }

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);

            }
            return resultat;

        }

        /// <summary>
        /// Fonction  qui permet de supprimer une ligne(un objet) de notre bdd
        /// retourne un booléen
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Delete(Lieu item)
        {
            bool resultat = false;
            try
            {
                using (SqlConnection cnx = SqlUtils.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = DELETE;
                    rqt.Parameters.AddWithValue("@Id", item.Id);

                    resultat = (rqt.ExecuteNonQuery() > 0);

                }

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);

            }
            return resultat;



        }

        /// <summary>
        /// Fonction qui permet de modifier une ligne / un objet de notre bdd
        /// retourne un booléen
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public bool Update(Lieu item)
        {
            bool resultat = false;
            try
            {
                using (SqlConnection cnx = SqlUtils.GetConnection())
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = UPDATE;
                    rqt.Parameters.AddWithValue("@Id", item.Id);
                    rqt.Parameters.AddWithValue("@Nom", item.Nom);
                    rqt.Parameters.AddWithValue("@Ville", item.Ville);
                    rqt.Parameters.AddWithValue("@Cp", item.Cp);
                    rqt.Parameters.AddWithValue("@DatedeVisite", item.DatedeVisite);

                    resultat = (rqt.ExecuteNonQuery() > 0);


                }

            }
            catch (Exception ex)
            {
                Console.Error.WriteLine(ex.Message);

            }
            return resultat;

        }

        /// <summary>
        /// fonction qui lit une liste de Lieux
        /// </summary>
        /// <returns></returns>
        public List<Lieu> Get()
        {
            List<Lieu> liste = new List<Lieu>();
            try
            {
                using (SqlConnection cnx = SqlUtils.GetConnection())
                {

                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = SELECT;
                    SqlDataReader dr = rqt.ExecuteReader();

                    while (dr.Read())
                    {
                        liste.Add(ItemBuilder(dr));

                    }
                }
                
            }
            catch(Exception ex)
            {
                Console.Error.WriteLine(ex.Message);

            }

            return liste;
            
        }

        /// <summary>
        /// Fonction  qui lit ds la bdd un objet Lieu
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>

        public Lieu Get(Lieu item)
        {

            Lieu resultat = null;
            try
            {
                using (SqlConnection cnx = SqlUtils.GetConnection()) //using =>évite d'avoir à "fermer la connection"
                {
                    SqlCommand rqt = cnx.CreateCommand();
                    rqt.CommandText = SELECT_BY_ID;
                    rqt.Parameters.AddWithValue("@Id", item.Id);

                    SqlDataReader dr = rqt.ExecuteReader();

                    if (dr.Read())
                    {
                        resultat = ItemBuilder(dr);
                    }

                }

            }
            catch (Exception ex)
            {

                Console.Error.WriteLine(ex.Message);
            }
            return resultat;
        }



        /// <summary>
        /// Permet de lire les données d'un nouveau lieu créé
        /// </summary>
        /// <param name="dr"></param>
        /// <returns></returns>
        public Lieu ItemBuilder(SqlDataReader dr)
        {
            Lieu item = new Lieu(); 
            item.Id =dr.GetInt32(dr.GetOrdinal(COL_ID));
            item.Nom = dr.GetString(dr.GetOrdinal(COL_NOM));
            item.Ville=dr.GetString(dr.GetOrdinal(COL_VILLE));
            item.Cp =dr.GetInt32(dr.GetOrdinal(COL_CP));
            item.DatedeVisite = dr.GetDateTime(dr.GetOrdinal(COL_DATE_DE_VISITE));
            return item;
        }

        /// <summary>
        /// Représente l'objet vide du singleton 
        /// </summary>

        private static LieuDAL instance = null;
        /// <summary>
        /// Représente le constructeur du singleton 
        /// </summary>
        private LieuDAL()
        {
            
        }

        /// <summary>
        /// Représente la fonction GetInstance du Singleton
        /// Permet de creer un nouvel objet 
        /// </summary>
        /// <returns></returns>
        public static LieuDAL GetInstance()
        {
            if (instance == null)
            {
                instance = new LieuDAL();

            }
            return instance;

        }

        
    }
}
