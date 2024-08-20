using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebMonitoring.Search;

namespace WebMonitoring.Controllers
{
    public class SearchDataController : Controller
    {

        string[] Desctription = new string[]
      {
             "Wyszukiwanie - Linia WS1 CNH",//0
             "Wyszukiwanie - Linia WS1 V50",//1
             "Wyszukiwanie - Linia WS2 HR16",//2
             "Wyszukiwanie - Linia WS3 HR10",//3
             "Wyszukiwanie - Linia WS4 BR10",//4
             "Wyszukiwanie - Linia WS4 BR10 BJA",//5
             "Wyszukiwanie - Linia WS5 CNH 537",//6
             "Wyszukiwanie - Linia WS6 CNH 529",//7
             "Wyszukiwanie - Linia STF 3,4,5,6",//8
             "Wyszukiwanie - Linia STF 1",//9
             "Wyszukiwanie - Linia STF 2",//10
                "Wyszukiwanie - Linia WS7",//11
          "Wyszukiwanie - Linia WS2 HR18"//12
      };


        [HttpGet]
        public IActionResult LineWs1Cnh()
        {

            ViewBag.TitleNavBar = Desctription[0];
            return View();
        }

        [HttpPost]
        public IActionResult LineWs1Cnh(CheckBoxLineWs1Cnh ws)
        {
            ViewBag.TitleNavBar = Desctription[0];
            bool checkboxChecked = ws.VisualStation || ws.FLT || ws.Czyszczenie || ws.PetlaKJ;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));


            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs1Cnh.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs1Cnh.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult LineWs2()
        {

            ViewBag.TitleNavBar = Desctription[2];
            return View();
        }

        [HttpPost]
        public IActionResult LineWs2(CheckBoxLineWs2 ws)
        {
            ViewBag.TitleNavBar = Desctription[2];
            bool checkboxChecked = ws.CeleSpawalnicza1_2 || ws.PLT || ws.CeleSpawalnicza3 || ws.FLT || ws.FG || ws.Odkurzacz || ws.PetlaKJ;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));


            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs2.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs2.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult LineWS3()
        {

            ViewBag.TitleNavBar = Desctription[3];
            return View();
        }

        [HttpPost]
        public IActionResult LineWS3(CheckBoxLineWs3 ws)
        {
            ViewBag.TitleNavBar = Desctription[3];

            bool checkboxChecked = ws.CeleSpawalnicza3 || ws.Enkapsulacja || ws.FG || ws.FLT || ws.Homologacja || ws.Odkurzacz || ws.PetlaKJ || ws.PLT || ws.Wkretak;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));

            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs3.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs3.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult LineWS4()
        {

            ViewBag.TitleNavBar = Desctription[4];
            return View();
        }

        [HttpPost]
        public IActionResult LineWS4(CheckBoxLineWs4 ws)
        {
            ViewBag.TitleNavBar = Desctription[4];
            bool checkboxChecked = ws.Wiremash || ws.SizerBja || ws.CeleSpawalnicza5 || ws.LT || ws.Enkapsulacja || ws.Odkurzacz || ws.Wkretak || ws.FG || ws.PetlaKJ;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));


            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs4.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs4.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult LineWs5()
        {

            ViewBag.TitleNavBar = Desctription[6];
            return View();
        }

        [HttpPost]
        public IActionResult LineWs5(CheckBoxLineWs5 ws)
        {
            ViewBag.TitleNavBar = Desctription[6];
            bool checkboxChecked = ws.Etap1 || ws.Etap2 || ws.Etap3 || ws.Etap4 || ws.PLT || ws.FLT || ws.FG || ws.PetlaKJ;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));


            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs5.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs5.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult LineWs6()
        {

            ViewBag.TitleNavBar = Desctription[7];
            return View();
        }

        [HttpPost]
        public IActionResult LineWs6(CheckBoxLineWs6 ws)
        {
            ViewBag.TitleNavBar = Desctription[7];
            bool checkboxChecked = ws.Etap1 || ws.Etap2 || ws.Etap3 || ws.Etap4 || ws.PLTA || ws.PLTB || ws.FLT || ws.FG || ws.PetlaKJ;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));
            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs6.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs6.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult LineWs7()
        {

            ViewBag.TitleNavBar = Desctription[11];
            return View();
        }

        [HttpPost]
        public IActionResult LineWs7(CheckBoxLineWs7 ws)
        {
            ViewBag.TitleNavBar = Desctription[11];
            bool checkboxChecked = ws.Mixer || ws.OP290 || ws.OP300 || ws.OP310 || ws.OP320 || ws.OP330 || ws.OP325 || ws.OP360 || ws.FLT || ws.Marking || ws.OP380 || ws.OP390 || ws.FG || ws.CL;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));


            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs7.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs7.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Stf_3_6()
        {
            ViewBag.TitleNavBar = Desctription[8];
            return View();
        }

        [HttpPost]
        public IActionResult Stf_3_6(Stf_3_6 stf)
        {
            ViewBag.TitleNavBar = Desctription[8];

            if (!string.IsNullOrEmpty(stf.TextArea))
                stf.FindData = new List<string>(
                                     stf.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));

            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if (stf.FindData?.Count > 0 && stf.SelectCode)
                {
                    if (stf.Stf3Cpt)
                    {
                        stf.GetDataFromSqlStf3Cpt(stf.FindData);
                    }
                    else
                    {
                        stf.GetDataFromSql(stf.FindData);
                    }

                    return View(stf);
                }
                else if (stf.SelectDate && stf.DateTime != null)
                {
                    if (stf.DateTime != null)
                    {
                        if (stf.All)
                        {
                            stf.GetDataFromSqlAll((DateTime)stf.DateTime);
                            return View(stf);
                        }
                        else if (stf.Stf3)
                        {
                            stf.GetDataFromSqlStf3((DateTime)stf.DateTime);
                            return View(stf);
                        }
                        else if (stf.Stf3Cpt)
                        {
                            stf.GetDataFromSqlStf3Cpt((DateTime)stf.DateTime);
                            return View(stf);
                        }
                        else if (stf.Stf4)
                        {
                            stf.GetDataFromSqlStf4((DateTime)stf.DateTime);
                            return View(stf);
                        }
                        else if (stf.Stf5)
                        {
                            stf.GetDataFromSqlStf5((DateTime)stf.DateTime);
                            return View(stf);
                        }
                        else if (stf.Stf6)
                        {
                            stf.GetDataFromSqlStf6((DateTime)stf.DateTime);
                            return View(stf);
                        }
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if (stf.FindData?.Count > 0 && stf.SelectCode)
                {
                    stf.GetDataFromSql(stf.FindData, true);
                    return File(stf.Table, "text/csv", "LineSTF.csv");
                }
                else if (stf.SelectDate && stf.DateTime != null)
                {
                    if (stf.DateTime != null)
                    {
                        if (stf.All)
                        {
                            stf.GetDataFromSqlAll((DateTime)stf.DateTime, true);
                            return File(ConvertStringToByte(stf.Table), "text/csv", "LineSTF_all.csv");
                        }
                        else if (stf.Stf3)
                        {
                            stf.GetDataFromSqlStf3((DateTime)stf.DateTime, true);
                            return File(ConvertStringToByte(stf.Table), "text/csv", "LineSTF3.csv");
                        }
                        else if (stf.Stf3Cpt)
                        {
                            stf.GetDataFromSqlStf3Cpt((DateTime)stf.DateTime, true);
                            return File(ConvertStringToByte(stf.Table), "text/csv", "LineSTF3_CPT.csv");
                        }
                        else if (stf.Stf4)
                        {
                            stf.GetDataFromSqlStf4((DateTime)stf.DateTime, true);
                            return File(ConvertStringToByte(stf.Table), "text/csv", "LineSTF4.csv");
                        }
                        else if (stf.Stf5)
                        {
                            stf.GetDataFromSqlStf5((DateTime)stf.DateTime, true);
                            return File(ConvertStringToByte(stf.Table), "text/csv", "LineSTF5.csv");
                        }
                        else if (stf.Stf6)
                        {
                            stf.GetDataFromSqlStf6((DateTime)stf.DateTime, true);
                            return File(ConvertStringToByte(stf.Table), "text/csv", "LineSTF6.csv");
                        }
                    }
                }
            }

            return View();
        }

        private byte[] ConvertStringToByte(string table)
        {
            return Encoding.UTF8.GetBytes(table);
        }

        [HttpGet]
        public IActionResult Stf1()
        {
            Stf1 stf = new Stf1();
            ViewBag.TitleNavBar = Desctription[9];
            return View(stf);
        }

        [HttpPost]
        public IActionResult Stf1(Stf1 stf)
        {
            ViewBag.TitleNavBar = Desctription[9];

            if (!string.IsNullOrEmpty(stf.TextArea))
                stf.FindData = new List<string>(
                                     stf.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));

            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if (stf.FindData?.Count > 0 && stf.SelectCode)
                {
                    stf.GetDataFromSql(stf.FindData);

                    if (stf.HtmlTable?.Count > 0)
                    {
                        return View(stf);
                    }
                }
                else if (stf.SelectDate && stf.DateTime != null)
                {
                    if (stf.DateTime != null)
                    {
                        stf.GetDataFromSql((DateTime)stf.DateTime);

                        if (stf.HtmlTable?.Count > 0)
                            return View(stf);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if (stf.FindData?.Count > 0 && stf.SelectCode)
                {
                    stf.GetDataFromSql(stf.FindData, true);

                    if (stf.Table?.Count > 0)
                    {
                        return File(ExtensionMethod.GenerationFile(stf.Table, stf.FileName), "application/zip", "LineStf1.zip");
                    }
                }
                else if (stf.SelectDate && stf.DateTime != null)
                {
                    if (stf.DateTime != null)
                    {
                        stf.GetDataFromSql((DateTime)stf.DateTime, true);

                        if (stf.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(stf.Table, stf.FileName), "application/zip", "LineStf1.zip");
                    }
                }
            }

            return View();
        }

        [HttpGet]
        public IActionResult Stf2()
        {
            Stf2 stf = new Stf2();
            ViewBag.TitleNavBar = Desctription[10];
            return View(stf);
        }

        [HttpPost]
        public IActionResult Stf2(Stf2 stf)
        {
            ViewBag.TitleNavBar = Desctription[10];

            if (!string.IsNullOrEmpty(stf.TextArea))
                stf.FindData = new List<string>(
                                     stf.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));

            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if (stf.FindData?.Count > 0 && stf.SelectCode)
                {
                    stf.GetDataFromSql(stf.FindData);

                    if (stf.HtmlTable?.Count > 0)
                    {
                        return View(stf);
                    }
                }
                else if (stf.SelectDate && stf.DateTime != null)
                {
                    if (stf.DateTime != null)
                    {
                        stf.GetDataFromSql((DateTime)stf.DateTime);

                        if (stf.HtmlTable?.Count > 0)
                            return View(stf);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if (stf.FindData?.Count > 0 && stf.SelectCode)
                {
                    stf.GetDataFromSql(stf.FindData, true);

                    if (stf.Table?.Count > 0)
                    {
                        return File(ExtensionMethod.GenerationFile(stf.Table, stf.FileName), "application/zip", "LineStf2.zip");
                    }
                }
                else if (stf.SelectDate && stf.DateTime != null)
                {
                    if (stf.DateTime != null)
                    {
                        stf.GetDataFromSql((DateTime)stf.DateTime, true);

                        if (stf.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(stf.Table, stf.FileName), "application/zip", "LineStf2.zip");
                    }
                }
            }

            return View();
        }
        [HttpGet]
        public IActionResult LineWs2HR18()
        {

            ViewBag.TitleNavBar = Desctription[12];
            return View();
        }

        [HttpPost]
        public IActionResult LineWs2HR18(CheckBoxLineWS2HR18 ws)
        {
            ViewBag.TitleNavBar = Desctription[12];
            bool checkboxChecked = ws.Cela_spawalnicza || ws.Tester_szczelności || ws.Sprawdzian_geometrii || ws.Odkurzacz || ws.ControlLoop_KJ;

            if (!string.IsNullOrEmpty(ws.TextArea))
                ws.FindData = new List<string>(
                                     ws.TextArea.Split(new string[] { "\r\n" },
                                     StringSplitOptions.RemoveEmptyEntries));


            if (!string.IsNullOrEmpty(Request.Form["wyszukiwanie"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode();
                    return View(ws);
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode();
                        return View(ws);
                    }
                }
            }
            else if (!string.IsNullOrEmpty(Request.Form["pobierz"]))
            {
                if ((ws.FindData?.Count > 0 && (ws.SelectCode || ws.SelectPzzw)) && checkboxChecked)
                {
                    ws.GetDataCode(true);

                    if (ws.Table?.Count > 0)
                        return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs2HR18.zip");
                }
                else if (ws.SelectDate && checkboxChecked && ws.DateTime != null)
                {
                    if (ws.DateTime != null)
                    {
                        ws.GetDataCode(true);

                        if (ws.Table?.Count > 0)
                            return File(ExtensionMethod.GenerationFile(ws.Table, ws.FileName), "application/zip", "LineWs2HR18.zip");
                    }
                }
            }

            return View();
        }
    }
}
    
    
