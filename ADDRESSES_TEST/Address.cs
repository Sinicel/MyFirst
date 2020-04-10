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

        public static string PR_BKIS_ADDRESS_STREET_FILTER_BAK_20191028(int location_id , string street, int building = 1)
        {
            Query = @"     SELECT  TOP 10 * " +
                "  FROM   LP_ADR_STREETS LEFT JOIN LP_ADR_BUILDINGS ON build_street_id = street_id where   street_locality_id = 44";// +
                //"AND build_number = 31 ";
            //+ building +
               // "LEFT JOIN LP_ADR_POSTCODES ON code_id = build_postcode_id AND code_post_id = 7121 end";// +
                //"WHERE street_locality_id = " +location_id +
                //" AND ('" + street + "' IS NULL OR street_name LIKE '" + street + "%') " +
                //" AND street_valid_date IS NULL " +
                //"ORDER BY 2, 4"+
                //" END";
            
            
            
            
            
            
            // +
                //",street_name" +
                //",build_id as building_id" +
                //",build_number as building_number" +
                ////", build_postcode_id as post_code_id" +
                //", code_name as post_code" +
                //"" +
                //"     FROM   LP_ADR_STREETS  LEFT JOIN LP_ADR_BUILDINGS  ON" +
                //"		build_street_id = street_id AND build_number = " + building  +
                //"          LEFT JOIN LP_ADR_POSTCODES         ON" +
                //"   		code_id = build_postcode_id     WHERE 			street_locality_id = "+location_id+"" +
                //"         AND ('" + street + "' IS NULL OR street_name LIKE '" + street + "%')" +
                //"         AND street_valid_date IS NULL     ORDER BY 2, 4 END" ;


            return Query;
        }





    }
}
