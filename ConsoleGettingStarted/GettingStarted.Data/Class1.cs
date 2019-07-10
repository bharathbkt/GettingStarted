using System;
using System.Linq;
using System.Collections.Generic;

namespace GettingStarted.Data
{
    public class GetData
    {
        List<GettingStarted.Entities.Class1> lstClass1 = new List<Entities.Class1>();
        /// <summary>
        /// Used this to demonstrate object initializer and constructor.
        /// </summary>
        public void LoadDataToSimulateDataFromDB()
        {
            for (int i = 0; i < 10; ++i)
            {
                if((i%2).Equals(0))
                    lstClass1.Add(new Entities.Class1 { intField1 = i, intField2 = i, stringField1 = "testData" + i.ToString(), stringField2 = "testData" + i.ToString() });
                else
                    //TODO:- Replace below with a constrtuctor.
                    lstClass1.Add(new Entities.Class1 { intField1 = i, intField2 = i, stringField1 = "testData" + i.ToString(), stringField2 = "testData" + i.ToString() });
            }

        }

        public GettingStarted.Entities.Class1 SimulateGetFromDB(int i)
        {
            return lstClass1.Where(x => x.intField1 == i).FirstOrDefault();
        }
    }
}
