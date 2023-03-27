using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoreM_InfoTest {
    public abstract class BoreM_Candidato : IEquatable<BoreM_Candidato>, IComparable<BoreM_Candidato> {
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

        public override string ToString() {
            return $"{BoreM_matricola}; {BoreM_nome}";
        }
        public bool Equals(BoreM_Candidato c) {
            if (c == null) {
                return false;
            } else if (c == this) {
                return true;
            }
            return (c.BoreM_matricola == this.BoreM_matricola && c.BoreM_nome == this.BoreM_nome);
        }
        public int CompareTo(BoreM_Candidato c) {
            if (c == null)
                return 1;

            int tmpC = c.Punteggio();
            int tmpT = this.Punteggio();
            if (tmpC < tmpT) {
                return 1;
            } else if (tmpC == tmpT) {
                return 0;
            }
            return -1;
        }
        public override int GetHashCode() => (BoreM_matricola, BoreM_nome).GetHashCode();
    }
}
