using System;
using System.Collections.Generic;
using System.Text;

namespace B2MyLibForUT.Services {
    public class MathsService 
    {


        public MathsService() {

        }
        public  int NbCall { get; set; } = 0;
        public int Add(int num1, int num2) {
            NbCall++;
            return num1 + num2;
        }

        public decimal Divise(decimal num1, decimal num2) {
            NbCall++;
            throw new Exception("Ca plante ici parceque num2 est égal à 0");
            return num1 / num2; 
        }


        public static int Add3Nombres(int num1, int num2, int num3) {
            return num1 + num2 + num3;
        }

    }



}
