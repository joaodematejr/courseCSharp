using System;
using System.Globalization;

namespace Curso.Entities
{
    class Invoice
    {
        public double BasicPaymet { get; set; }
        public double Tax { get; set; }

        public double TotalPayment
        {
            get { return BasicPaymet + Tax; }
        }

        public Invoice(double basicPayment, double tax)
        {
            BasicPaymet = basicPayment;
            Tax = tax;
        }

        public override string ToString()
        {
            return "Basic payment: "
                + BasicPaymet.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTax: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTotal payment: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
