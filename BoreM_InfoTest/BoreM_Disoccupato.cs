using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoreM_InfoTest {
    public class BoreM_Disoccupato : BoreM_Candidato, IEquatable<BoreM_Disoccupato>, IComparable<BoreM_Disoccupato> {
        private byte _boreM_voto;
        private bool _boreM_lode; /*true= lode, false= non lode*/

        public BoreM_Disoccupato() : this(0, "", 0, false) {
        }
        public BoreM_Disoccupato(int matr, string nome, byte voto, bool lode) : base(matr, nome) {
            BoreM_voto = voto;
            BoreM_lode = lode;
        }
        /*properties*/
        public byte BoreM_voto {
            get {
                return _boreM_voto;
            }
            set {
                if (value < 111) { /*non serve maggiore di 0 perchè è byte [0-255]*/
                    _boreM_voto = value;
                } else {
                    throw new Exception("Inserire un voto valido");
                }
            }
        }
        public bool BoreM_lode {
            get {
                return _boreM_lode;
            }
            set {
                if (BoreM_voto == 110) { /*se è 110 può essere sia lode che no*/
                    _boreM_lode = value;
                } else { /*se sono qui deve per forza essere false perchè non posso prendere 109 e lode*/
                    if (value) {
                        throw new Exception("Non si può mettere la lode se il voto non è il masismo");
                    }
                    /*qui value è per forza false*/
                    _boreM_lode = value;
                }
            }
        }

        public override int Punteggio() {
            int tmp = BoreM_voto * 100 / 110;
            if (BoreM_lode) {
                return tmp + 5;
            }
            return tmp;
        }

        public override bool IsIdoneo() {
            if (Punteggio() >= 72) {
                return true;
            }
            return false;
        }

        public override string ToString() {
            return $"{base.ToString()};{BoreM_voto};{BoreM_lode}";
        }
        public bool Equals(BoreM_Disoccupato d) {
            return ((base.Equals((BoreM_Candidato)d)) && (d.BoreM_voto == this.BoreM_voto) && (d.BoreM_lode == this.BoreM_lode));
        }
        public int CompareTo(BoreM_Disoccupato l) {
            return (base.CompareTo((BoreM_Candidato)l));
        }
    }
}
