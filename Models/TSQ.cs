using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebMonitoring.Models
{
    public class TSQ
    {
        private IDbSetLine context { get; set; }

        public DataRaport LineWs1Cnh { get; set; } = new DataRaport();
        public DataRaport LineWs1V50 { get; set; } = new DataRaport();
        public DataRaport LineWs2 { get; set; } = new DataRaport();
        public DataRaport LineWS2HR18 { get; set; } = new DataRaport();
        public DataRaport LineWs3A_0LP1 { get; set; } = new DataRaport();
        public DataRaport LineWs3A_1LP2_Rurki { get; set; } = new DataRaport();
        public DataRaport LineWs3A_2LP1 { get; set; } = new DataRaport();
        public DataRaport LineWs3A_2LP2 { get; set; } = new DataRaport();
        public DataRaport LineWs3A_1LP1Gpf { get; set; } = new DataRaport();
        public DataRaport LineWs3A_2LP1Gpf { get; set; } = new DataRaport();
        public DataRaport LineWs3 { get; set; } = new DataRaport();
        public DataRaport LineWs8_Bja { get; set; } = new DataRaport();
        public DataRaport LineWs8_Gpf { get; set; } = new DataRaport();
        public DataRaport LineWs4M260A { get; set; } = new DataRaport();
        public DataRaport LineWs5 { get; set; } = new DataRaport();
        public DataRaport LineWs6 { get; set; } = new DataRaport();
        public DataRaport LineStf3 { get; set; } = new DataRaport();
        public DataRaport LineStf3M260 { get; set; } = new DataRaport();
        public DataRaport LineStf4 { get; set; } = new DataRaport();
        public DataRaport LineStf4Hr10 { get; set; } = new DataRaport();
        public DataRaport LineStf5 { get; set; } = new DataRaport();
        public DataRaport LineStf6 { get; set; } = new DataRaport();
        public DataRaport LineStf6Hr16 { get; set; } = new DataRaport();
        public DataRaport LineWeil { get; set; } = new DataRaport();
        public DataRaport LineWs7 { get; set; } = new DataRaport();

        public DateTime DateTime { get; set; }


        public void GetDailyRaport (DateTime dateTime)
        {
            context = new DbSetLine();
            var dpContext = new DbSetLineWS3(new DataBase.ProductionDbContext());

            dateTime = dateTime.Date;
            dateTime = dateTime.AddHours(6);

            //ws1 cnh
            LineWs1Cnh.Line = LineDescription.LineWS1;
            LineWs1Cnh.Model = "CNH";

            int[] shifts = context.GetDailyReport(LineDescription.LineWS1CNH, dateTime);

            LineWs1Cnh.Shift1 = shifts[0];
            LineWs1Cnh.Shift2 = shifts[1];
            LineWs1Cnh.Shift3 = shifts[2];

            //ws1 v50
            LineWs1V50.Line = LineDescription.LineWS1;
            LineWs1V50.Model = "V50";

            shifts = context.GetDailyReport(LineDescription.LineWS1V50, dateTime);

            LineWs1V50.Shift1 = shifts[0];
            LineWs1V50.Shift2 = shifts[1];
            LineWs1V50.Shift3 = shifts[2];

            //ws2 hr16
            LineWs2.Line = LineDescription.LineWS2;
            LineWs2.Model = "HR16";

            shifts = context.GetDailyReport(LineDescription.LineWS2, dateTime);

            LineWs2.Shift1 = shifts[0];
            LineWs2.Shift2 = shifts[1];
            LineWs2.Shift3 = shifts[2];

            //ws2 hr18
            LineWS2HR18.Line = LineDescription.LineWS2HR18;
            LineWS2HR18.Model = "HR18";

            shifts = context.GetDailyReport(LineDescription.LineWS2HR18, dateTime);

            LineWS2HR18.Shift1 = shifts[0];
            LineWS2HR18.Shift2 = shifts[1];
            LineWS2HR18.Shift3 = shifts[2];

            //ws3A hr10
            LineWs3A_0LP1.Line = LineDescription.LineWS3A + " Cela 0Lp1";
            LineWs3A_0LP1.Model = "HR10";

            shifts = dpContext.GetDailyRaportDaneProdukcyjne(dateTime, "Cela0Lp1");

            LineWs3A_0LP1.Shift1 = shifts[0];
            LineWs3A_0LP1.Shift2 = shifts[1];
            LineWs3A_0LP1.Shift3 = shifts[2];

            //
            LineWs3A_1LP2_Rurki.Line = LineDescription.LineWS3A + " Cela 1Lp2 Rurki";
            LineWs3A_1LP2_Rurki.Model = "HR10";

            shifts = dpContext.GetDailyRaportDaneProdukcyjne(dateTime, "Cela1Lp2Rurki");

            LineWs3A_1LP2_Rurki.Shift1 = shifts[0];
            LineWs3A_1LP2_Rurki.Shift2 = shifts[1];
            LineWs3A_1LP2_Rurki.Shift3 = shifts[2];

            //
            LineWs3A_2LP1.Line = LineDescription.LineWS3A + " Cela 2Lp1";
            LineWs3A_2LP1.Model = "HR10";

            shifts = dpContext.GetDailyRaportDaneProdukcyjne(dateTime, "Cela2Lp1");

            LineWs3A_2LP1.Shift1 = shifts[0];
            LineWs3A_2LP1.Shift2 = shifts[1];
            LineWs3A_2LP1.Shift3 = shifts[2];

            //
            LineWs3A_2LP2.Line = LineDescription.LineWS3A + " Cela 2Lp2";
            LineWs3A_2LP2.Model = "HR10";

            shifts = dpContext.GetDailyRaportDaneProdukcyjne(dateTime, "Cela2Lp2");

            LineWs3A_2LP2.Shift1 = shifts[0];
            LineWs3A_2LP2.Shift2 = shifts[1];
            LineWs3A_2LP2.Shift3 = shifts[2];

            //
            LineWs3A_1LP1Gpf.Line = LineDescription.LineWS3A + " Cela Gpf 1Lp1";
            LineWs3A_1LP1Gpf.Model = "HR10";

            shifts = dpContext.GetDailyRaportDaneProdukcyjne(dateTime, "CelaGpf1Lp1");

            LineWs3A_1LP1Gpf.Shift1 = shifts[0];
            LineWs3A_1LP1Gpf.Shift2 = shifts[1];
            LineWs3A_1LP1Gpf.Shift3 = shifts[2];

            //
            LineWs3A_2LP1Gpf.Line = LineDescription.LineWS3A + " Cela Gpf 2Lp1";
            LineWs3A_2LP1Gpf.Model = "HR10";

            shifts = dpContext.GetDailyRaportDaneProdukcyjne(dateTime, "CelaGpf2Lp1");

            LineWs3A_2LP1Gpf.Shift1 = shifts[0];
            LineWs3A_2LP1Gpf.Shift2 = shifts[1];
            LineWs3A_2LP1Gpf.Shift3 = shifts[2];

            //ws3 hr10
            LineWs3.Line = LineDescription.LineWS3;
            LineWs3.Model = "HR10";

            shifts = context.GetDailyReport(LineDescription.LineWS3, dateTime);

            LineWs3.Shift1 = shifts[0];
            LineWs3.Shift2 = shifts[1];
            LineWs3.Shift3 = shifts[2];

            //ws4 bja
            LineWs8_Bja.Line = LineDescription.LineWS8_BJA;
            LineWs8_Bja.Model = "BR10 BJA";

            shifts = context.GetDailyReport(LineDescription.LineWS8_BJA, dateTime);

            LineWs8_Bja.Shift1 = shifts[0];
            LineWs8_Bja.Shift2 = shifts[1];
            LineWs8_Bja.Shift3 = shifts[2];

            //ws4 gpf
            LineWs8_Gpf.Line = LineDescription.LineWS8_GPF;
            LineWs8_Gpf.Model = "BR10 GPF";

            shifts = context.GetDailyReport(LineDescription.LineWS8_GPF, dateTime);

            LineWs8_Gpf.Shift1 = shifts[0];
            LineWs8_Gpf.Shift2 = shifts[1];
            LineWs8_Gpf.Shift3 = shifts[2];

            //ws4 m260a
            LineWs4M260A.Line = LineDescription.LineWS4;
            LineWs4M260A.Model = "M260A";

            shifts = context.GetDailyReport(LineDescription.LineWS4M260, dateTime);

            LineWs4M260A.Shift1 = shifts[0];
            LineWs4M260A.Shift2 = shifts[1];
            LineWs4M260A.Shift3 = shifts[2];

            //ws5
            LineWs5.Line = LineDescription.LineWS5;
            LineWs5.Model = "CNH 537";

            shifts = context.GetDailyReport(LineDescription.LineWS5, dateTime);

            LineWs5.Shift1 = shifts[0];
            LineWs5.Shift2 = shifts[1];
            LineWs5.Shift3 = shifts[2];

            //ws6
            LineWs6.Line = LineDescription.LineWS6;
            LineWs6.Model = "CNH 529";

            shifts = context.GetDailyReport(LineDescription.LineWS6, dateTime);

            LineWs6.Shift1 = shifts[0];
            LineWs6.Shift2 = shifts[1];
            LineWs6.Shift3 = shifts[2];

            //stf3
            LineStf3.Line = LineDescription.LineSTF3;
            LineStf3.Model = "HR16";

            shifts = context.GetDailyReport(LineDescription.LineSTF3, dateTime);

            LineStf3.Shift1 = shifts[0];
            LineStf3.Shift2 = shifts[1];
            LineStf3.Shift3 = shifts[2];

            //stf3
            LineStf3M260.Line = LineDescription.LineSTF3M260;
            LineStf3M260.Model = "M260";

            shifts = context.GetDailyReport(LineDescription.LineSTF3M260, dateTime);

            LineStf3M260.Shift1 = shifts[0];
            LineStf3M260.Shift2 = shifts[1];
            LineStf3M260.Shift3 = shifts[2];

            //stf4
            LineStf4.Line = LineDescription.LineSTF4;
            LineStf4.Model = "BR10";

            shifts = context.GetDailyReport(LineDescription.LineSTF4, dateTime);

            LineStf4.Shift1 = shifts[0];
            LineStf4.Shift2 = shifts[1];
            LineStf4.Shift3 = shifts[2];

            //stf4
            LineStf4Hr10.Line = LineDescription.LineSTF4;
            LineStf4Hr10.Model = "HR10";

            shifts = context.GetDailyReport(LineDescription.LineSTF4HR10, dateTime);

            LineStf4Hr10.Shift1 = shifts[0];
            LineStf4Hr10.Shift2 = shifts[1];
            LineStf4Hr10.Shift3 = shifts[2];

            //stf5
            LineStf5.Line = LineDescription.LineSTF5;
            LineStf5.Model = "HR10";

            shifts = context.GetDailyReport(LineDescription.LineSTF5, dateTime);

            LineStf5.Shift1 = shifts[0];
            LineStf5.Shift2 = shifts[1];
            LineStf5.Shift3 = shifts[2];

            //stf6
            LineStf6.Line = LineDescription.LineSTF6;
            LineStf6.Model = "HR10";

            shifts = context.GetDailyReport(LineDescription.LineSTF6HR10, dateTime);

            LineStf6.Shift1 = shifts[0];
            LineStf6.Shift2 = shifts[1];
            LineStf6.Shift3 = shifts[2];

            //stf6
            LineStf6Hr16.Line = LineDescription.LineSTF6;
            LineStf6Hr16.Model = "HR16";

            shifts = context.GetDailyReport(LineDescription.LineSTF6, dateTime);

            LineStf6Hr16.Shift1 = shifts[0];
            LineStf6Hr16.Shift2 = shifts[1];
            LineStf6Hr16.Shift3 = shifts[2];

            //weil
            LineWeil.Line = LineDescription.LineShell;
            LineWeil.Model = LineDescription.LineWeil;

            shifts = context.GetDailyReport(LineDescription.LineWeil, dateTime);

            LineWeil.Shift1 = shifts[0];
            LineWeil.Shift2 = shifts[1];
            LineWeil.Shift3 = shifts[2];

            //ws7
            LineWs7.Line = LineDescription.LineWS7;
            LineWs7.Model = "CNH 537";

            shifts = context.GetDailyReport(LineDescription.LineWS7, dateTime);

            LineWs7.Shift1 = shifts[0];
            LineWs7.Shift2 = shifts[1];
            LineWs7.Shift3 = shifts[2];
        }
    }
}
