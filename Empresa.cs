using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinoteca
{
    internal class Empresa
    {
        public List<Vino> ListaVinos  { get; private set; }
        public List<Vino> ListaTemp { get; private set; }
        List<Venta> listaVendidos = new List<Venta>();

        private int idVinos;
        public Empresa()
        {
            idVinos = 0;
            ListaVinos = new List<Vino>(); 
        }

        private void ordenar()
        {
            ListaVinos.Sort();
        }

        public List<Vino> filtrar(string filtro)
        {
           // List<Vino> lista = ListaVinos.Where(x => x.Nombre.Contains(filtro)).ToList();
            List<Vino> lista = ListaVinos.Where(x => x.Nombre.IndexOf(filtro, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
            return lista;
        }

        public void ReservarVino(int id)
        {
            --ListaVinos.Find(x => x.Id == id).Cantidad;
            //ListaTemp.Add();
        }

        public void AgregarVino(int cant, string bodega, string vino, string tipo, double precio)
        {
            ListaVinos.Add(new Vino(++idVinos, cant, bodega, vino, tipo, precio));
        }

        public void CambiarPrecio(int id, double precioNuevo, int cant)
        {
            Vino v = ListaVinos.Find(x => x.Id == id);
            if (v != null)
            {
                v.Precio = precioNuevo;
                v.Cantidad = cant;
            }
        }
        
        public void QuitarVino(int id)
        {
            Vino v = ListaVinos.Find(x => x.Id == id);
            ListaVinos.Remove(v);
        }

        public void AgregarVinosRandom()
        {
            for (int i = 0; i < 5000; i++)
                AgregarVino(5, "Bodega"+i, "Vino"+GenerarCodigo(), "Tipo"+i, 0);
        }
        Random random = new Random();
        public string GenerarCodigo()
        {
            const string letras = "abcdefghijklmnopqrstuvwxyz0123456789";
            string resultado = "";

            for (int i = 0; i < 5; i++)
            {
                int indice = random.Next(0, letras.Length);
                resultado += letras[indice];
            }
            return resultado;
        }
    }
}
