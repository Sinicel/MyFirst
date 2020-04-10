using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADDRESSES_TEST
{
    class Address
    {
        static string Query;

        public static string PR_BKIS_ADDRESS_STREET_FILTER_BAK_20191028(int location_id, string street, string building )
        {
            Query = @"     SELECT  TOP 10 * " +
                "  FROM   LP_ADR_STREETS LEFT JOIN LP_ADR_BUILDINGS ON build_street_id = street_id" +
                " LEFT JOIN LP_ADR_POSTCODES " +
                "            ON  code_id = build_postcode_id " +
                " where   street_locality_id = 44  and code_post_id = 7121 and street_name LIKE '" + street + "%'";

            return Query;
        }

       public static string Vnl_26_adresai()
        {
            Query = @"     SELECT   * " +
                "  FROM   LP_ADR_STREETS LEFT JOIN LP_ADR_BUILDINGS ON build_street_id = street_id" +
                " LEFT JOIN LP_ADR_POSTCODES " +
                "            ON  code_id = build_postcode_id " +
                " where   street_locality_id = 44  and code_post_id = 7121";

            return Query;
        }



    }
}
