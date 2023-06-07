using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecuirtyPurpose
{
    public class EncapsulationPayment
    {
        private string cardonwner, card_no, cvv, card_type, card_mon, card_exp;



        public String CO
        {

            get
            {
                return cardonwner;
            }

            set
            {
                cardonwner = value;
            }

        }

        public String Card_NO
        {

            get
            {
                return card_no;
            }

            set
            {
                card_no = value;
            }

        }

        public String Cvv
        {

            get
            {
                return cvv;
            }

            set
            {
                cvv = value;
            }

        }

        public String cardtype
        {

            get
            {
                return card_type;
            }

            set
            {
                card_type = value;
            }

        }

        public String CM
        {

            get
            {
                return card_mon;
            }

            set
            {
                card_mon = value;
            }

        }

        public String expc
        {

            get
            {
                return card_exp;
            }

            set
            {
                card_exp = value;
            }

        }



        ~EncapsulationPayment()
        {


        }


    }
}
