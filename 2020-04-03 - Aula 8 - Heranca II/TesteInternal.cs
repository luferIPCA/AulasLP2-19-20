/*
 * Herança de Classes
 * 
 * Classe Base (classe Pai)
 * Classe Derivada  (classe Filho)
 * 
 * i)   Construtores não são herdados. Cada sub-classe tem de ter o seu construtor!
 * ii)  uso de "this" : utilizar método/atributo do objecto  corrente
 * iii) uso de "base":  utilizar método/atributo do Pai
 * iv)  uso de new: alerta compilador do interesse em esconder ("hidding") o método Pai
 * v)   uso de virtual: permite especialização de método (ou property) na classe derivada
 * vi)  sealed: classe que não pode ser derivada
 *
 * Protected internal (Protected union Internal): O tipo ou membro pode ser acedido por qualquer 
 * código no assembly (Library) no qual ele está declarado ou de uma classe derivada em outro assembly!
 * 
 * Ref: C# Unleashed
 * Ver: https://msdn.microsoft.com/pt-BR/library/ms173121.aspx
 * Ver: https://msdn.microsoft.com/pt-br/library/6csyy24x(v=vs.90).aspx
 * Ver: https://msdn.microsoft.com/pt-br/library/1zzat272(v=vs.90).aspx
 * Ver: https://www.dotnetbull.com/2013/10/public-protected-private-internal-access-modifier-in-c.html
 * Ler sobre:
 *  - FamilyAndAssembly
 *  - FamilyOrAssembly
 *  
 * lufer
 * */


namespace HerancaLib
{
    /// <summary>
    /// Classe para demonstrar Modificadores de Acesso
    /// </summary>
    public class TesteInternal
    {
        protected bool eProtected;      //acedido na definição da classe derivada!
        protected internal bool eProtectedInternal;
        internal bool eInternal;
        public int x;                   //disponível para todos

        /// <summary>
        /// Propriedade para gerir eInternal
        /// </summary>
        public bool EInternal
        {
            get { return eInternal; }
            set { eInternal = value; }
        }

        public virtual int X()
        {            
            return 1;
        }
    }


    /// <summary>
    /// Testar Modificadores de Acesso
    /// </summary>
    public class Outra : TesteInternal
    {
        int x;      

        /// <summary>
        /// Construtor
        /// </summary>
        public Outra()
        {
            TesteInternal t = new TesteInternal();
            //t.eProtected = true;      //não pode ser usado por uma instância da classe pai..apenas em herança!

            t.x = 20;                   //ok pois x é public
            t.eInternal = true;         //sim pois eInternal é internal!
            t.EInternal = true;         //ok pois EInternal é internal
                        
            base.eProtected = true;     //ok pois esta classe é subclass
            this.eProtected = true;     //ok pois esta classe é sub-class

            //t.eProtected=true;        //não permitido porquê?
        }

        /// <summary>
        /// Reescreve metodo da classe pai
        /// </summary>
        /// <returns></returns>
        public override int X()
        {
            return 2;
        }
    }

    /// <summary>
    /// Uma outra classe da mesmo Assembly (DLL) pode usar "internal"...neste caso a propriedade "EIntenal"
    /// </summary>
    internal class Outra2 : TesteInternal
    {
        Outra2 o = new Outra2();

        public Outra2()
        {
            
            o.EInternal = true;

            o.eProtected = false;

            o.eProtectedInternal = false;

            //Outra o = new Outra();

            //o.
            
        }

        public  void X()
        {
            //o.
            

        }
    }

    /// <summary>
    /// Qual o problema com esta classe?
    /// </summary>
    public class Outra3 : TesteInternal
    {
        Outra3 o = new Outra3();        

        public Outra3()
        {
            Outra2 a = new Outra2();
            a.eInternal = true;
            a.eProtectedInternal = true;
            o.eProtectedInternal = true;
        }
    }
}
