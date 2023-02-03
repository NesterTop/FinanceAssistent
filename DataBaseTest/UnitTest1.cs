using Microsoft.VisualStudio.TestTools.UnitTesting;
using FinanceAssistent;
using System.Windows.Forms;
using System;

namespace DataBaseTest
{
    [TestClass]
    public class RegistrTest
    {
        [TestMethod]
        public void Registr_logAndpassAndname_FalseReturned()
        {
            string login = "";
            string password = "";
            string name = "";
            bool expected = false;
            bool actual;
            using (DataBase db = new DataBase())
            {
                db.Open();
                actual = db.InsertOrDeleteData(Queries.InsertQueries.GetUserInsertSQL(login, password, name));
            }
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Regist_NumsInName_FlaseReturned()
        {
            string str = "name123";
            bool expected = false;
            FormReg formReg = new FormReg();
            bool actual = formReg.CheckNumsInName(str);
            Assert.AreEqual(expected, actual);
        }

    }

    [TestClass]
    public class DataBaseConnectionTest
    {
        
    }
}
