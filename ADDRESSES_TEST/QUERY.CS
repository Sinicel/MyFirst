using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESSES_TEST
{

    public class QUERY
    {


        static string Query;

        static public string LP_ADR_AREAS()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_AREAS ; SELECT COUNT (*) FROM LP_ADR_AREAS";


            return Query;
        }
        public static string GetMailID(string bk)
        {
            Query = ("SELECT * " +
                "FROM LP_BAR_CODES WITH(NOLOCK) INNER JOIN LP_MAIL_BAR_CODES WITH(NOLOCK) ON " +
                "LP_BAR_CODES.bcode_id = LP_MAIL_BAR_CODES.mailbcode_bcode_id " +
                "WHERE(LP_BAR_CODES.bcode_value ='" + bk + "')");

            return Query;
        }

        public static string GetMailKortele(string mail_id)
        {
            Query = "PR_BKIS_MAIL_ITEM_DATA_READ_BAK_20200120 " + mail_id;

            return Query;
        }
        public static string SP_RPSPrekesKortele(string mailid)
        {

            Query = "EXEC SP_RPSPrekesKortele " + mailid;

            return Query;

        }
        static public string LP_ADR_BUILDINGS()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_BUILDINGS ; SELECT COUNT (*) FROM LP_ADR_BUILDINGS";


            return Query;
        }
        static public string LP_ADR_DELIVERY_AREA()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_DELIVERY_AREA ; SELECT COUNT (*) FROM LP_ADR_DELIVERY_AREA";


            return Query;
        }

        static public string LP_ADR_DISTRICT_ACP()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_DISTRICT_ACP ; SELECT COUNT (*) FROM LP_ADR_DISTRICT_ACP";


            return Query;
        }

        static public string LP_ADR_DISTRICTS()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_DISTRICTS ; SELECT COUNT (*) FROM LP_ADR_DISTRICTS";


            return Query;
        }

        static public string LP_ADR_KLSF_LOCALITY_TYPES()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_KLSF_LOCALITY_TYPES ; SELECT COUNT (*) FROM LP_ADR_KLSF_LOCALITY_TYPES";


            return Query;
        }

        static public string LP_ADR_KLSF_POST_OFFICE_TYPES()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_KLSF_POST_OFFICE_TYPES ; SELECT COUNT (*) FROM LP_ADR_KLSF_POST_OFFICE_TYPES";


            return Query;
        }

        static public string LP_ADR_KLSF_STREET_TYPES()
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_KLSF_STREET_TYPES ; SELECT COUNT (*) FROM LP_ADR_KLSF_STREET_TYPES";


            return Query;
        }

        static public string LP_ADR_LOCALITIES(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_LOCALITIES WHERE local_name = '" + name + "'  ;  SELECT COUNT (*) FROM LP_ADR_LOCALITIES";


            return Query;
        }

        static public string LP_ADR_LOCALITIES_DELIVERY_ZONES(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_LOCALITIES_DELIVERY_ZONES  ;  SELECT COUNT (*) FROM LP_ADR_LOCALITIES_DELIVERY_ZONES";


            return Query;
        }

        static public string LP_ADR_LOCALITIES_FOR_AR(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_LOCALITIES_FOR_AR  ;  SELECT COUNT (*) FROM LP_ADR_LOCALITIES_FOR_AR";


            return Query;
        }

        static public string LP_ADR_MUNICIPALITIES(string name)
        {
            Query = "SELECT  * FROM LP_ADR_MUNICIPALITIES  ;  SELECT COUNT (*) FROM LP_ADR_MUNICIPALITIES";


            return Query;
        }

        static public string LP_ADR_POSTCODE_TYPES(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_POSTCODE_TYPES  ;  SELECT COUNT (*) FROM LP_ADR_POSTCODE_TYPES";


            return Query;
        }


        static public string LP_ADR_POSTCODES(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_POSTCODES  ;  SELECT COUNT (*) FROM LP_ADR_POSTCODES";


            return Query;
        }

        static public string LP_ADR_POSTCODES_HIST(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_POSTCODES_HIST  ;  SELECT COUNT (*) FROM LP_ADR_POSTCODES_HIST";


            return Query;
        }

        static public string LP_ADR_REGIONS(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_REGIONS  ;  SELECT COUNT (*) FROM LP_ADR_REGIONS";


            return Query;
        }

        static public string LP_ADR_STREETS(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_STREETS  ;  SELECT COUNT (*) FROM LP_ADR_STREETS";


            return Query;
        }

        static public string LP_ADR_STREETS_FOR_AR(int street_locality_id, string street_name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_STREETS_FOR_AR WHERE street_locality_id = " + street_locality_id + " AND street_name LIKE '%" + street_name + "%'  ;  SELECT COUNT (*) FROM LP_ADR_STREETS_FOR_AR";


            return Query;
        }

        static public string LP_ADR_STREETS_FOR_AR_EXTRA(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_STREETS_FOR_AR_EXTRA  ;  SELECT COUNT (*) FROM LP_ADR_STREETS_FOR_AR_EXTRA";


            return Query;
        }

        static public string LP_ADR_STREETS_FOR_AR_EXTRA_V2(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_STREETS_FOR_AR_EXTRA_V2  ;  SELECT COUNT (*) FROM LP_ADR_STREETS_FOR_AR_EXTRA_V2";


            return Query;
        }

        static public string LP_ADR_SUBDISTRICTS(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_SUBDISTRICTS  ;  SELECT COUNT (*) FROM LP_ADR_SUBDISTRICTS";


            return Query;
        }

        static public string LP_ARCH_ACTIONS(string name)
        {
            Query = "SELECT TOP 100 * FROM LP_ARCH_ACTIONS  ;  SELECT COUNT (*) FROM LP_ARCH_ACTIONS";


            return Query;
        }

        static public string LP_EMPLOYEES(string emp_fname)
        {
            Query = "SELECT TOP 100 * FROM LP_EMPLOYEES where emp_fname LIKE '%" + emp_fname + "%'  ;  SELECT COUNT (*) FROM LP_EMPLOYEES";


            return Query;
        }

        static public string LP_INTPOST_ADMS(string emp_fname)
        {
            Query = "SELECT TOP 100 * FROM LP_INTPOST_ADMS  ;  SELECT COUNT (*) FROM LP_INTPOST_ADMS";


            return Query;
        }

        static public string LP_POST_SECTORS(string sector_post_id)
        {
            Query = "SELECT TOP 100 * FROM LP_POST_SECTORS WHERE sector_post_id = " + sector_post_id + " ;  SELECT COUNT (*) FROM LP_POST_SECTORS";


            return Query;
        }

        static public string LP_POST_OFFICES(string post_name)
        {
            Query = "SELECT TOP 100 * FROM LP_POST_OFFICES WHERE post_name LIKE '%" + post_name + "%' ;  SELECT COUNT (*) FROM LP_POST_OFFICES";


            return Query;
        }

        static public string UPDV_ADR_RAJONAS(string emp_fname)
        {
            Query = "SELECT TOP 100 * FROM UPDV_ADR_RAJONAS   ;  SELECT COUNT (*) FROM UPDV_ADR_RAJONAS";


            return Query;
        }

        static public string BKIS_KLSF_POST_OFFICE_SEARCH_SCOPE(string any)
        {
            Query = "SELECT TOP 100 * FROM BKIS_KLSF_POST_OFFICE_SEARCH_SCOPE   ;  SELECT COUNT (*) FROM BKIS_KLSF_POST_OFFICE_SEARCH_SCOPE";


            return Query;
        }

        static public string LP_KLSF_POST_RELATIONS(string any)
        {
            Query = "SELECT TOP 100 * FROM LP_KLSF_POST_RELATIONS   ;  SELECT COUNT (*) FROM LP_KLSF_POST_RELATIONS";


            return Query;
        }

        static public string LP_ADR_KLSF_POST_OFFICE_TYPES(string any)
        {
            Query = "SELECT TOP 100 * FROM LP_ADR_KLSF_POST_OFFICE_TYPES   ;  SELECT COUNT (*) FROM LP_ADR_KLSF_POST_OFFICE_TYPES";


            return Query;
        }

        static public string LP_KLSF_POST_OFFICE_RETAIL_TYPE(string any)
        {
            Query = "SELECT TOP 100 * FROM LP_KLSF_POST_OFFICE_RETAIL_TYPE   ;  SELECT COUNT (*) FROM LP_KLSF_POST_OFFICE_RETAIL_TYPE";


            return Query;
        }

        static public string UPDV_SYSTEM_ONLINE_USERS(string Login)
        {
            Query = " SELECT   *  FROM UPDV_SYSTEM_ONLINE_USERS where PostCode = 12001 ";//and Login = '" + Login + "'";


            return Query;
        }


        /// <summary>
        /// Pateikia siuntų su praėjusiu saugojimo pašte terminu sąrašą
        /// pagal nurodytą kategoriją.
        /// </summary>
        /// <param name="current_post_id">einamojo pašto ID</param>
        /// <param name="current_sector_id">einamojo sektoriaus ID</param>
        /// <param name="current_emp_id">einamojo naudotojo ID</param>
        /// <param name="category_code">siuntų su praėjusiu saugojimo terminu kategorijos kodas 
        /// (žr. dbo.PR_BKIS_GET_OUTDATED_MAILS_CATEGORIES_LIST)</param>
        /// <param name="for_user">ar reikia atrinkti tik tas siuntas, kurios yra nurodyto naudotojo atsakomybėje.</param>
        /// <returns name = "dfdf"> Graz.reiksme: recordset - kuris grąžina siuntų sąrašą.</returns>
        static public string PR_BKIS_GET_OUTDATED_MAILS_LIST(string current_post_id, string current_sector_id, string current_emp_id, string category_code, string for_user)
        {


            Query = " PR_BKIS_GET_OUTDATED_MAILS_LIST '" + current_post_id + "', '" + current_sector_id + "', '" + current_emp_id + "', '" + category_code + "', '" + for_user + "'";


            return Query;
        }

        //static public string LP_KLSF_POST_RELATIONS(string any)
        //{
        //    Query = "SELECT TOP 100 * FROM LP_ADR_DISTRICT_ACP   ;  SELECT COUNT (*) FROM LP_ADR_DISTRICT_ACP";


        //    return Query;
        //}

    }
}
