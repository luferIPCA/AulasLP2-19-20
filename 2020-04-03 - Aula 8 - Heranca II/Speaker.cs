/*
lufer
Classe inheritance

*/

namespace HerancaLib
{    
    /// <summary>
    /// Orador de Conferência
    /// </summary>
    public class Speaker : Person
    {
        //public string nameSpeaker;
        //public int ageSpeaker;
        //public string addressSpeaker;

        public string instSpeacker;

        public Speaker()
        {            
            base.vencimento = base.vencimento * 10;
        }

        #region RESTO

        public override string ToString()
        {
            return base.ToString() + " Institui =" + instSpeacker.ToString();
        }
        #endregion
    }


    /// <summary>
    /// Participante de conferencia
    /// </summary>
    public class Participant : Person
    {
        //public string nameParticipant;
        //public int ageParticipant;
        //public string addressParticipant;

        public int numberParticipant;

        #region METODOS

        /// <summary>
        /// Construtor por defeito/omissão
        /// </summary>
        public Participant()
        {
            numberParticipant = 1;
            base.address = "";
            base.age = 1;
            //base.name = ""; //NÂO - é privado no Pai
            vencimento = 100;
        }


        public Participant(string n, int i, string m, int np) : base(n,i,m)
        {
            numberParticipant = np;
        }


        public override string ToString()
        {
            return base.ToString() + " Number="+numberParticipant.ToString();
        }

        #endregion
    }



}
