using kursss;


namespace UnitTest
{

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]

        public void CypherTestMethod1()
        {
            Atbash atbash = new Atbash();
            string slovo = "ÌÀÌÁÅÒ";
            string reverse = "ÒßÒÞÚÌ";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);
        }

    }
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]

        public void CypherTestMethod2()
        {
            Atbash atbash = new Atbash();
            string slovo = "ÒßÒÞÚÌ";
            string reverse = "ÌÀÌÁÅÒ";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);           
        }
    }
    [TestClass]
    public class UnitTest3
    {
        [TestMethod]

        public void CypherTestMethod3()
        {
            Atbash atbash = new Atbash();
            string slovo = "õîëîä";
            string reverse = "éðóðû";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);
        }
    }
    [TestClass]
    public class UnitTest4
    {
        [TestMethod]

        public void CypherTestMethod4()
        {
            Atbash atbash = new Atbash();
            string slovo = "éðóðû";
            string reverse = "õîëîä";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);
        }
    }
    [TestClass]
    public class UnitTest5
    {
        [TestMethod]

        public void CypherTestMethod5()
        {
            Atbash atbash = new Atbash();
            string slovo = "HANDA";
            string reverse = "SZMWZ";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);
        }
    }
    [TestClass]
    public class UnitTest6
    {
        [TestMethod]

        public void CypherTestMethod6()
        {
            Atbash atbash = new Atbash();
            string slovo = "SZMWZ";
            string reverse = "HANDA";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);
        }
    }
    [TestClass]
    public class UnitTest7
    {
        [TestMethod]

        public void CypherTestMethod7()
        {
            Atbash atbash = new Atbash();
            string slovo = "handa";
            string reverse = "szmwz";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);
        }
    }
    [TestClass]
    public class UnitTest8
    {
        [TestMethod]

        public void CypherTestMethod8()
        {
            Atbash atbash = new Atbash();
            string slovo = "szmwz";
            string reverse = "handa";
            AtbashShifer n = new AtbashShifer();
            slovo = n.ChifrA(slovo);
            Assert.AreEqual(slovo, reverse);
        }
    }
    [TestClass]
    public class UnitTest9
    {
        [TestMethod]

        public void DBTestMethod9()
        {
            Form1 atbash = new Form1();
            bool Authorizated = true;
            string loginField = "boss";
            string passField = "123";
            DB db = new DB();
            Assert.AreEqual(Authorizated, db.CheckUser1(loginField, passField));
        }
    }
    [TestClass]
    public class UnitTest10
    {
        [TestMethod]

        public void DBTestMethod10()
        {
            Form1 atbash = new Form1();
            bool Authorizated = false;
            string loginField = "boss";
            string passField = "123";
            DB db = new DB();
            Assert.AreEqual(Authorizated, db.CheckUser2(loginField, passField));
        }
    }
}