using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoreM_InfoTest {
    public class BoreM_Lavoratore : BoreM_Candidato {
        private byte _boreM_esperienze;

        public BoreM_Lavoratore() : this(0, "", 0) {
        }
        public BoreM_Lavoratore(int matr, string nome, byte esperienze) : base(matr, nome) {
            BoreM_esperienze = esperienze;
        }
        /*properties*/
        public byte BoreM_esperienze {
            get {
                return _boreM_esperienze;
            }
            set {
                if (value < 6) {
                    _boreM_esperienze = value;
                } else {
                    throw new Exception("Inserire un massimo di 5 esperienze");
                }
            }
        }

        public override int Punteggio() {
            return (20 * BoreM_esperienze);
        }

        public override bool IsIdoneo() {
            return (Punteggio() >= 60);
        }
    }
}
