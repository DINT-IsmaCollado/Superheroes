using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class Superheroe : INotifyPropertyChanged
    {
        private string nombre;
        private string enemigo;
        private string foto;
        private bool vengador;

        public string Nombre
        {
            get { return this.nombre; }
            set
            {
                if (this.nombre != value)
                {
                    this.nombre = value;
                    this.NotifyPropertyChanged("Nombre");
                }
            }
        }
        public string Enemigo
        {
            get { return this.enemigo; }
            set
            {
                if (this.enemigo != value)
                {
                    this.enemigo = value;
                    this.NotifyPropertyChanged("Enemigo");
                }
            }
        }
        public string Foto
        {
            get { return this.foto; }
            set
            {
                if (this.foto != value)
                {
                    this.foto = value;
                    this.NotifyPropertyChanged("Foto");
                }
            }
        }
        public bool Vengador
        {
            get { return this.vengador; }
            set
            {
                if (this.vengador != value)
                {
                    this.vengador = value;
                    this.NotifyPropertyChanged("Vengador");
                }
            }
        }


        public Superheroe()
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void NotifyPropertyChanged(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static Superheroe GetSample()
        {
            Superheroe heroe = new Superheroe();
            heroe.Nombre = "Daredevil";
            heroe.Enemigo = "Kingping";
            heroe.Foto = @"https://dam.smashmexico.com.mx/wp-content/uploads/2018/08/27150601/daredevilbio_portada.jpg";
            heroe.Vengador = false;

            return heroe;
        }
    }
}
