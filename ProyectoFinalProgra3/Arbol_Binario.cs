using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Drawing;
using System.Windows.Forms;

namespace ProyectoFinalProgra3
{
    class Arbol_Binario
    {
        public Nodo_Arbol Raiz;
        public Nodo_Arbol aux;
        public Nodo_Arbol trabajo;

        private int alturaMax;
        public int AlturaMax { get => alturaMax; set => alturaMax = value; }

        private string numeroNodos;
        public string NumeroNodos { get => numeroNodos; set => numeroNodos = value; }

        private string iteracionPreOrder;
        private string iteracionInOrder;
        private string iteracionPostOrder;
        public string IteracionPreOrder { get => iteracionPreOrder; set => iteracionPreOrder = value; }
        public string IteracionInOrder { get => iteracionInOrder; set => iteracionInOrder = value; }
        public string IteracionPostOrder { get => iteracionPostOrder; set => iteracionPostOrder = value; }

        public List<int> identificadorAreasNodos = new List<int>();
        public List<Rectangle> areasNodos = new List<Rectangle>();

        public Rectangle areaNodoInfo;

        public int infoNodoClick = 0;

        public Arbol_Binario()
        {
            aux = new Nodo_Arbol();
        }
        public Arbol_Binario(Nodo_Arbol nueva_raiz)
        {
            Raiz = nueva_raiz;
        }
        public void Insertar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
                Raiz.nivel = 0;
            }
            else
            {
                Raiz = Raiz.Insertar(x, Raiz, Raiz.nivel);
            }
        }
        public void Eliminar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
            }
            else
            {
                Raiz.Eliminar(x, ref Raiz);
            }
        }

        public void Buscar(int x)
        {
            if (Raiz == null)
            {
                Raiz = new Nodo_Arbol(x, null, null, null);
            }
            else
            {
                Raiz.buscar(x, Raiz);

                
            }
        }

        public void DibujarArbol(Graphics grafo,Font fuente,Brush Relleno,Brush RellenoFuente,Pen Lapiz, Brush encuentro)
        {
            int x = 400;
            int y = 75;
            if (Raiz == null)
            {
                return;
            }
            Raiz.PosicionNodo(ref x, y);
            Raiz.DibujarRamas(grafo, Lapiz);
            Raiz.DibujarNodo(grafo, fuente, Relleno, RellenoFuente, Lapiz, encuentro);
        }
        /**********************/
        public int x1 = 400;
        public int y2 = 75;

        // Función para Colorear los nodos 
        public void colorear(Graphics grato, Font fuente, Brush Relleno, Brush RellenoFuente, Pen Lapiz, Nodo_Arbol Raiz, bool post, bool inor, bool preor)
        {
            Brush entorno = Brushes.Red;
            if (inor == true)
            {
                if (Raiz != null)
                {
                    colorear(grato, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    Raiz.colorear(grato, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos 
                    Raiz.colorear(grato, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grato, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if (preor == true)
            {
                if (Raiz != null)
                {
                    Raiz.colorear(grato, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos 
                    Raiz.colorear(grato, fuente, Relleno, RellenoFuente, Lapiz);
                    colorear(grato, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grato, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                }
            }
            else if (post == true)
            {
                if (Raiz != null)
                {
                    colorear(grato, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Izquierdo, post, inor, preor);
                    colorear(grato, fuente, Relleno, RellenoFuente, Lapiz, Raiz.Derecho, post, inor, preor);
                    Raiz.colorear(grato, fuente, entorno, RellenoFuente, Lapiz);
                    Thread.Sleep(1000); // pausar la ejecución 1000 milisegundos 
                    Raiz.colorear(grato, fuente, Relleno, RellenoFuente, Lapiz);
                }
            }
        }

        /**********************/

        public void TransversaPreOrder(Nodo_Arbol nodo)
        {
            // caso base
            if (nodo == null)
            {
                return;
            }

            // Central
            iteracionPreOrder += nodo.info.ToString() + " ,";

            // procesamos el izquierdo
            if (nodo.Izquierdo != null)
            {
                TransversaPreOrder(nodo.Izquierdo);
            }

            // procesamos el derecho
            if (nodo.Derecho != null)
            {
                TransversaPreOrder(nodo.Derecho);
            }
        }

        public void TransversaInOrder(Nodo_Arbol nodo)
        {
            if (nodo == null)
            {
                return;
            }

            // procesamos la izquierda
            if (nodo.Izquierdo != null)
            {
                TransversaInOrder(nodo.Izquierdo);
            }

            // procesamos el centra
            iteracionInOrder += nodo.info.ToString() + " ,";

            // procesamos la derecha
            if (nodo.Derecho != null)
            {
                TransversaInOrder(nodo.Derecho);
            }
        }

        public void TransversaPostOrder(Nodo_Arbol nodo)
        {
            if (nodo == null)
            {
                return;
            }

            // procesamos la izquierda
            if (nodo.Izquierdo != null)
            {
                TransversaPostOrder(nodo.Izquierdo);
            }

            // procesamos la derecha
            if (nodo.Derecho != null)
            {
                TransversaPostOrder(nodo.Derecho);
            }

            // procesamos el centra
            iteracionPostOrder += nodo.info.ToString() + " ,";
        }

        public void TransversaAltura(Nodo_Arbol nodo)
        {
            // Hacemos una transversa para comparar las alturas de los nodos

            //caso base
            if (nodo == null)
            {
                return;
            }

            // miramos el lado izquierdo y comparamos cual tiene el nivel mas alto
            if (nodo.Izquierdo != null)
            {
                if (alturaMax < nodo.Izquierdo.nivel)
                {
                    alturaMax = nodo.Izquierdo.nivel;
                }
                TransversaAltura(nodo.Izquierdo);    
            }

            // miramos el lado de la derecha y hacemos lo mismo
            if (nodo.Derecho != null)
            {

                if (alturaMax < nodo.Derecho.nivel)
                {
                    alturaMax = nodo.Derecho.nivel;
                }
                TransversaAltura(nodo.Derecho);
            }
        }

        public int ValorPequeño(Nodo_Arbol nodo)
        {
            // caso base
            if (nodo == null)
            {
                return 0;
            }

            trabajo = nodo;
            int minimo = trabajo.info;

            // sabemos que por las reglas de un arbol binario de busqueda; el valor más pequeño va a estar hasta abajo hasta la izquierda
            while (trabajo.Izquierdo != null)
            {
                trabajo = trabajo.Izquierdo;
                minimo = trabajo.info;
            }

            return minimo;
        }

        public int ValorGrande(Nodo_Arbol nodo)
        {
            // caso base
            if (nodo == null)
            {
                return 0;
            }

            trabajo = nodo;
            int maximo = trabajo.info;

            // al igual que el anterior solo que el valor mas grande va a estar hasta la derecha en la parte de abajo
            while (trabajo.Derecho != null)
            {
                trabajo = trabajo.Derecho;
                maximo = trabajo.info;
            }

            return maximo;
        }

        public Nodo_Arbol BuscarPadre(int dato, Nodo_Arbol nodo)
        {
            Nodo_Arbol temp = null;

            if (nodo == null)
            {
                return null;
            }

            // dos casos base para verificar el nodo padre
            if (nodo.Izquierdo != null)
            {
                if (nodo.Izquierdo.info == dato)
                {
                    return nodo;
                }
            }

            if (nodo.Derecho != null)
            {
                if (nodo.Derecho.info == dato)
                {
                    return nodo;
                }
            }

            // recursivo a la izquierda
            if (nodo.Izquierdo != null && dato < nodo.info)
            {
                temp = BuscarPadre(dato, nodo.Izquierdo);
            }


            // recursivo a la dercha
            if (nodo.Derecho != null && dato > nodo.info)
            {
                temp = BuscarPadre(dato, nodo.Derecho);
            }

            return temp;
        }

        public Nodo_Arbol TransversaColorear(int infoId, Nodo_Arbol nodo)
        {
            // Nodo_Arbol temp = null;

            if (nodo == null)
            {
                return null;
            }

            if (nodo.info == infoId)
            {
                trabajo = nodo;
                return trabajo;
            }

            if (nodo.Izquierdo != null)
            {
                if (infoId == nodo.Izquierdo.info)
                {
                    trabajo = nodo.Izquierdo;
                    return trabajo;
                }
                TransversaColorear(infoId, nodo.Izquierdo);
            }

            if (nodo.Derecho != null)
            {

                if (infoId == nodo.Derecho.info)
                {
                    trabajo = nodo.Derecho;
                    return trabajo;
                }
                TransversaColorear(infoId, nodo.Derecho);
            }

            return trabajo;
        }

        public void AreaNodo(Nodo_Arbol nodo)
        {
            // usamos una transversa para conseguir las medidas de cada nodo y agregarlas a una lista
            // ademas de guardar las posiciones de cada uno tenemos que guardar que nodo es cual asi que guardamos la informacion en otra lista por aparte

            if (nodo.Izquierdo != null)
            {
                areasNodos.Add(nodo.Izquierdo.conseguirMedidasNodo());
                identificadorAreasNodos.Add(nodo.Izquierdo.info);

            }

            if (nodo.Derecho != null)
            {
                areasNodos.Add(nodo.Derecho.conseguirMedidasNodo());
                identificadorAreasNodos.Add(nodo.Derecho.info);
            }

            areasNodos.Add(nodo.conseguirMedidasNodo());
            identificadorAreasNodos.Add(nodo.info);

            if (nodo == null)
            {
                return;
            }
        }

        public int encontrarInfoNodo(Nodo_Arbol nodo, MouseEventArgs e)
        {
            if (nodo == null)
            {
                return 0;
            }

            if (nodo.circulo.Contains(e.Location))
            {
                infoNodoClick = nodo.info;
                return infoNodoClick;
            }

            if (nodo.Izquierdo != null)
            {
                if (nodo.Izquierdo.circulo.Contains(e.Location))
                {
                    infoNodoClick = nodo.Izquierdo.info;
                    return infoNodoClick;
                }
                encontrarInfoNodo(nodo.Izquierdo, e);

            }

            if (nodo.Derecho != null)
            {
                if (nodo.Derecho.circulo.Contains(e.Location))
                {
                    infoNodoClick = nodo.Derecho.info;
                    return infoNodoClick;
                }
                encontrarInfoNodo(nodo.Derecho, e);
            }

            return infoNodoClick;
        }

        public void TransversaNumeroNodos(Nodo_Arbol nodo)
        {
            // hacemos una transversa y colocamos el valor de cada nodo en un string separados por comas
            // al finalizar dependiendo de cuantos valores tengamos sabremos cuantos nodos existen
            // hay otras formas de saber cuantos nodos hay pero esta fue la que escogimos

            // caso base
            if (nodo == null)
            {
                return;
            }

            // Central
            numeroNodos += nodo.info.ToString() + ",";

            // procesamos el izquierdo
            if (nodo.Izquierdo != null)
            {
                TransversaNumeroNodos(nodo.Izquierdo);
            }

            // procesamos el derecho
            if (nodo.Derecho != null)
            {
                TransversaNumeroNodos(nodo.Derecho);
            }
        }

        public int RevisionNumeroNodos(string iteracionNumeroNodos)
        {
            if (iteracionNumeroNodos.EndsWith(","))
            {
                iteracionNumeroNodos = iteracionNumeroNodos.Remove(iteracionNumeroNodos.Length - 2);
            }

            string[] listaNumNodos = iteracionNumeroNodos.Split(',');
            return listaNumNodos.Length;
        }
    }
}
