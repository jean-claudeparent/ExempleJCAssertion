using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using JCAssertionCore;

namespace ExempleJCAssertion
{
    [TestClass]
    public class Exenple
    {
        /// <summary>
        /// exemple d'utilisation du client oracle
        /// pour un test
        /// </summary>
        [TestMethod]
        public void Exemple()
        {
            JCASQLClient SQLClient = new JCASQLClient();
            // Utiliser le user et password oracle de la bd de débveloppement jcassertion
            // mettez votre connection pour la remplacer
            // Comme ion ne spécifie pas de serveur
            // ce sera localhost
            SQLClient.InitConnection("JCA","JCA");
            Assert.IsTrue(SQLClient.SQLAssert(
                "select count(*) from JCATest where IDTEST ='existepas'", 0));
            
        }
    }
}
