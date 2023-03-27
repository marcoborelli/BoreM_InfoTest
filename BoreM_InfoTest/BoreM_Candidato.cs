using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoreM_InfoTest {
    public abstract class BoreM_Candidato {
        private int _boreM_matricola;
        private string _boreM_nome;

        /*costruttore*/
        public BoreM_Candidato() : this(0, "") {
        }
        public BoreM_Candidato(int mat) : this(mat, "") {
        }
        public BoreM_Candidato(string nome) : this(0, nome) {
        }
        public BoreM_Candidato(int matr, string nome) {
            BoreM_matricola = matr;
            BoreM_nome = nome;
        }

        /*properties*/
        public int BoreM_matricola {
            get {
                return _boreM_matricola;
            }
            set {
                _boreM_matricola = value;
            }
        }
        public string BoreM_nome {
            get {
                return _boreM_nome;
            }
            set {
                _boreM_nome = value;
            }
        }
        /*properties*/

        public abstract bool IsIdoneo();
        public abstract int Punteggio();
        
    }
}
