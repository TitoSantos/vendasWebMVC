using System;
using VendasWebMVC.Models.Enums;

namespace VendasWebMVC.Models
{
    public class RegistrosdeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Montante { get; set; }
        public StatusVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RegistrosdeVendas()
        {

        }

        public RegistrosdeVendas(int id, DateTime data, double montante, StatusVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Montante = montante;
            Status = status;
            Vendedor = vendedor;
        }
    }
}
