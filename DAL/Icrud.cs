using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    /// <summary>
    /// Représente l'interface de la DAL 
    /// </summary>
    /// <typeparam name="Truc"></typeparam>
    interface Icrud<Truc>
    {
        /// <summary>
        /// Représente la fonction CREATe de l'interface
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Create(Truc item);

        /// <summary>
        /// Représente la fonction Delete de l'interface
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        bool Delete(Truc item );

        /// <summary>
        /// Représente la fonction Update de l'interface
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>

        bool Update(Truc item);


        /// <summary>
        /// Représente la fonction de l'interface qui lit l'objet
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        Truc Get(Truc item );
        

        /// <summary>
        /// Représente la fonction  qui  lit une liste d'objets
        /// </summary>
        /// <returns></returns>
        List<Truc> Get();


        /// <summary>
        /// Représente la fonction qui lit une liste d'objet 
        /// </summary>
        /// <returns></returns>
        Truc ItemBuilder(SqlDataReader dr);  
       
    }
}
