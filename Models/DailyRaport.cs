using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class DailyRaport
    {
        private IDbSetLine Context { get; set; }
        private DbProduction ContextProd { get; set; }
        private string Shift1 => "1";
        private string Shift2 => "2";
        private string Shift3 => "3";
        public DataRaport LineWs1Cnh { get; set; } = new DataRaport();
        //public DataRaport LineWs1V50 { get; set; } = new DataRaport();
        public DataRaport LineWs2 { get; set; } = new DataRaport();
        public DataRaport LineWS2HR18 { get; set; } = new DataRaport();
        public DataRaport LineWs3 { get; set; } = new DataRaport();
        public DataRaport LineWs8_Bja { get; set; } = new DataRaport();
        public DataRaport LineWs8_Gpf { get; set; } = new DataRaport();
        public DataRaport LineWs4M260 { get; set; } = new DataRaport();
        public DataRaport LineWs5 { get; set; } = new DataRaport();
        public DataRaport LineWs6 { get; set; } = new DataRaport();
        public DataRaport LineWeil { get; set; } = new DataRaport();
        public DataRaport LineWs7 { get; set; } = new DataRaport();
        public DataRaport LineSdf { get; set; } = new DataRaport();
        public DateTime DateTime { get; set; }

        public void GetDailyRaport (DateTime dateTime)
        {
            Context = new DbSetLine();
            ContextProd = new DbProduction(new DataBase.ProductionDbContext());

            dateTime = dateTime.Date;
            dateTime = dateTime.AddHours(6);

            //ws1 cnh
            LineWs1Cnh.Line = LineDescription.LineWS1;
            LineWs1Cnh.Model = "CNH";

            int[] shifts = Context.GetDailyReport(LineDescription.LineWS1CNH, dateTime);

            LineWs1Cnh.Shift1 = shifts[0];
            LineWs1Cnh.Shift2 = shifts[1];
            LineWs1Cnh.Shift3 = shifts[2];
            //target
            LineWs1Cnh.TargetShift1 = LineWs1Cnh.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineDescription.LineWS1CNH, Shift1) : 0;
            LineWs1Cnh.TargetShift2 = LineWs1Cnh.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineDescription.LineWS1CNH, Shift2) : 0;
            LineWs1Cnh.TargetShift3 = LineWs1Cnh.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineDescription.LineWS1CNH, Shift3) : 0;

            ////ws1 v50
            //LineWs1V50.Line = LineDescription.LineWS1;
            //LineWs1V50.Model = "V50";

            //shifts = Context.GetDailyReport(LineDescription.LineWS1V50, dateTime);

            //LineWs1V50.Shift1 = shifts[0];
            //LineWs1V50.Shift2 = shifts[1];
            //LineWs1V50.Shift3 = shifts[2];
            ////target
            //LineWs1V50.TargetShift1 = LineWs1V50.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineDescription.LineWS1V50, Shift1) : 0;
            //LineWs1V50.TargetShift2 = LineWs1V50.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineDescription.LineWS1V50, Shift2) : 0;
            //LineWs1V50.TargetShift3 = LineWs1V50.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineDescription.LineWS1V50, Shift3) : 0;

            //ws2 hr16
            LineWs2.Line = LineDescription.LineWS2;
            LineWs2.Model = "HR16";

            shifts = Context.GetDailyReport(LineDescription.LineWS2, dateTime);

            LineWs2.Shift1 = shifts[0];
            LineWs2.Shift2 = shifts[1];
            LineWs2.Shift3 = shifts[2];
            //target
            LineWs2.TargetShift1 = LineWs2.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs2.Line, Shift1) : 0;
            LineWs2.TargetShift2 = LineWs2.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs2.Line, Shift2) : 0;
            LineWs2.TargetShift3 = LineWs2.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs2.Line, Shift3) : 0;

            //ws2 hr18
            LineWS2HR18.Line = LineDescription.LineWS2HR18;
            LineWS2HR18.Model = "HR18";

            shifts = Context.GetDailyReport(LineDescription.LineWS2HR18, dateTime);

            LineWS2HR18.Shift1 = shifts[0];
            LineWS2HR18.Shift2 = shifts[1];
            LineWS2HR18.Shift3 = shifts[2];
            //target
            LineWS2HR18.TargetShift1 = LineWS2HR18.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWS2HR18.Line, Shift1) : 0;
            LineWS2HR18.TargetShift2 = LineWS2HR18.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWS2HR18.Line, Shift2) : 0;
            LineWS2HR18.TargetShift3 = LineWS2HR18.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWS2HR18.Line, Shift3) : 0;

            //ws3 hr10
            LineWs3.Line = LineDescription.LineWS3;
            LineWs3.Model = "HR10";

            shifts = Context.GetDailyReport(LineDescription.LineWS3, dateTime);

            LineWs3.Shift1 = shifts[0];
            LineWs3.Shift2 = shifts[1];
            LineWs3.Shift3 = shifts[2];
            //target
            LineWs3.TargetShift1 = LineWs3.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs3.Line, Shift1) : 0;
            LineWs3.TargetShift2 = LineWs3.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs3.Line, Shift2) : 0;
            LineWs3.TargetShift3 = LineWs3.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs3.Line, Shift3) : 0;

            //ws2B bja
            LineWs8_Bja.Line = LineDescription.LineWS8_BJA;
            LineWs8_Bja.Model = "BR10 BJA";


            shifts = Context.GetDailyReport(LineDescription.LineWS8_BJA, dateTime);

            LineWs8_Bja.Shift1 = shifts[0];
            LineWs8_Bja.Shift2 = shifts[1];
            LineWs8_Bja.Shift3 = shifts[2];
            //target
            LineWs8_Bja.TargetShift1 = LineWs8_Bja.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs8_Bja.Line, Shift1) : 0;
            LineWs8_Bja.TargetShift2 = LineWs8_Bja.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs8_Bja.Line, Shift2) : 0;
            LineWs8_Bja.TargetShift3 = LineWs8_Bja.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs8_Bja.Line, Shift3) : 0;

            //ws8 gpf
            LineWs8_Gpf.Line = LineDescription.LineWS8_GPF;
            LineWs8_Gpf.Model = "BR10 GPF";

            shifts = Context.GetDailyReport(LineDescription.LineWS8_GPF, dateTime);

            LineWs8_Gpf.Shift1 = shifts[0];
            LineWs8_Gpf.Shift2 = shifts[1];
            LineWs8_Gpf.Shift3 = shifts[2];
            //target
            LineWs8_Gpf.TargetShift1 = LineWs8_Gpf.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs8_Gpf.Line, Shift1) : 0;
            LineWs8_Gpf.TargetShift2 = LineWs8_Gpf.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs8_Gpf.Line, Shift2) : 0;
            LineWs8_Gpf.TargetShift3 = LineWs8_Gpf.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs8_Gpf.Line, Shift3) : 0;

            //ws4 m260
            LineWs4M260.Line = LineDescription.LineWS4M260;
            LineWs4M260.Model = "M260A";

            shifts = Context.GetDailyReport(LineDescription.LineWS4M260, dateTime);
            LineWs4M260.Shift1 = shifts[0];
            LineWs4M260.Shift2 = shifts[1];
            LineWs4M260.Shift3 = shifts[2];
            //target
            LineWs4M260.TargetShift1 = LineWs4M260.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs4M260.Line, Shift1) : 0;
            LineWs4M260.TargetShift2 = LineWs4M260.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs4M260.Line, Shift2) : 0;
            LineWs4M260.TargetShift3 = LineWs4M260.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs4M260.Line, Shift3) : 0;

            //ws5
            LineWs5.Line = LineDescription.LineWS5;
            LineWs5.Model = "CNH 537";

            shifts = Context.GetDailyReport(LineDescription.LineWS5, dateTime);

            LineWs5.Shift1 = shifts[0];
            LineWs5.Shift2 = shifts[1];
            LineWs5.Shift3 = shifts[2];
            //target
            LineWs5.TargetShift1 = LineWs5.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs5.Line, Shift1) : 0;
            LineWs5.TargetShift2 = LineWs5.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs5.Line, Shift2) : 0;
            LineWs5.TargetShift3 = LineWs5.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs5.Line, Shift3) : 0;

            //ws6
            LineWs6.Line = LineDescription.LineWS6;
            LineWs6.Model = "CNH 529";

            shifts = Context.GetDailyReport(LineDescription.LineWS6, dateTime);

            LineWs6.Shift1 = shifts[0];
            LineWs6.Shift2 = shifts[1];
            LineWs6.Shift3 = shifts[2];
            //target
            LineWs6.TargetShift1 = LineWs6.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs6.Line, Shift1) : 0;
            LineWs6.TargetShift2 = LineWs6.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs6.Line, Shift2) : 0;
            LineWs6.TargetShift3 = LineWs6.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs6.Line, Shift3) : 0;

            //weil
            LineWeil.Line = LineDescription.LineShell ;
            LineWeil.Model = LineDescription.LineWeil;

            shifts = Context.GetDailyReport(LineDescription.LineWeil, dateTime);

            LineWeil.Shift1 = shifts[0];
            LineWeil.Shift2 = shifts[1];
            LineWeil.Shift3 = shifts[2];
            //target
            LineWeil.TargetShift1 = LineWeil.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWeil.Model, Shift1) : 0;
            LineWeil.TargetShift2 = LineWeil.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWeil.Model, Shift2) : 0;
            LineWeil.TargetShift3 = LineWeil.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWeil.Model, Shift3) : 0;

            //ws7
            LineWs7.Line = LineDescription.LineWS7;
            LineWs7.Model = "CNH 537";

            shifts = Context.GetDailyReport(LineDescription.LineWS7, dateTime);

            LineWs7.Shift1 = shifts[0];
            LineWs7.Shift2 = shifts[1];
            LineWs7.Shift3 = shifts[2];
            //target
            LineWs7.TargetShift2 = LineWs7.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs7.Line, Shift2) : 0;
            LineWs7.TargetShift1 = LineWs7.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs7.Line, Shift1) : 0;
            LineWs7.TargetShift3 = LineWs7.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineWs7.Line, Shift3) : 0;

            //sdf
            LineSdf.Line = LineDescription.LineWS6;
            LineSdf.Model = "SDF";

            shifts = Context.GetDailyReport(LineDescription.LineSDF, dateTime);

            LineSdf.Shift1 = shifts[0];
            LineSdf.Shift2 = shifts[1];
            LineSdf.Shift3 = shifts[2];
            //target
            LineSdf.TargetShift2 = LineSdf.Shift2 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineSdf.Model, Shift2) : 0;
            LineSdf.TargetShift1 = LineSdf.Shift1 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineSdf.Model, Shift1) : 0;
            LineSdf.TargetShift3 = LineSdf.Shift3 > 0 ? ContextProd.CheckDailyTarget(dateTime, LineSdf.Model, Shift3) : 0;
        }
    }

    public class DataRaport
    {
        public string Line { get; set; }
        public string Model { get; set; }
        public int Shift1 { get; set; }
        public int Shift2 { get; set; }
        public int Shift3 { get; set; }
        public int ShiftsSum => Shift1 + Shift2 + Shift3;
        public int TargetShift1 { get; set; }
        public int TargetShift2 { get; set; }
        public int TargetShift3 { get; set; }
        public int TargetSuma
        {
            get
            {
                int target1 = Shift1 > 0 ? TargetShift1 : 0;
                int target2 = Shift2 > 0 ? TargetShift2 : 0;
                int target3 = Shift3 > 0 ? TargetShift3 : 0;


                return target1 + target2 + target3;
            }
        }
    }
}
