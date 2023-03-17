using System;

namespace Pizzas.API
{
    public class marca
    {
        private int _IdPizza;
        private string _Nombre;
        private string _LibreDeGluten;
        private float _importe;
        private string _descripcion;


         public pizza(int IdPizza, string Nombre, string LibreDeGluten, float importe, string descripcion)
        {
           _IdPizza = IdPizza;
            _Nombre = Nombre;
            _LibreDeGluten = LibreDeGluten;
            _importe = importe;
            _descripcion = descripcion;
        }
         public pizza()
        {
           _IdPizza= 0;
            _Nombre = "";
            _LibreDeGluten = "";
            _importe = "";
            _descripcion = "";
        }        
        
        public string Nombre
        {
            get{return _Nombre;}
            set{_Nombre = value;}
        }
        public int IdPizza
        {
            get{return _IdPizza;}
            set{_IdPizza= value;}
        }
        public string LibreDeGluten 
        {
            get{return _LibreDeGluten;}
            set{_LibreDeGluten = value;}
        }
        public string importe
        {
            get{return _importe1;}
            set{_importe = value;}
        }
        public string descripcion
        {
            get{return _descripcion}
            set{_descripcion = value}
        }
    
    }

}