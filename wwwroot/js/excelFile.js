function exportExcel(line, date, shift1, shift2, shift3) {

    console.log(line);
    console.log(date);
    console.log(shift1);
    console.log(shift2);
    console.log(shift3);

    //Import dependecies
    const XLSX = require('xlsx');

    //create Date 
    var time = new Date();
    //var dateTime = time.getFullYear() + '-' + ((time.getMonth() < 10) ? '0' + time.getMonth() : time.getMonth()) + '-' + ((time.getDate() < 10) ? '0' + time.getDate() : time.getDate());
    var month = time.getFullYear() + '-' + ((time.getMonth() < 10) ? '0' + time.getMonth() : time.getMonth());

    //file path
    const pathFile = "C:\\Users\\piotr\\Desktop\\Monitoring_" + month + ".xlsx";
    //const pathFile = "C:\\Users\\piotr\\Desktop\\Monitoring.xlsx";

    line = "Output Details " + line;

    //screate sheets
    //var sheets = new Array(
    //    "Output Details WS1 V50",
    //    "Output Details WS2 HR16",
    //    "Output Details WS3B",
    //    "Output Details WS4",
    //    "Output Details WS5 CNH",
    //    "Output Details WS3A",
    //    "Output Details WS6 CNH",
    //    "Output Details STF3",
    //    "Output Details STF4",
    //    "Output Details STF5",
    //    "Output Details STF6"
    //);

    try {
        // Read the file into memory
        const workbook = XLSX.readFile(pathFile, { cellDates: true });

        // Convert the XLSX to JSON
        let worksheets = {};
        var ws = workbook.Sheets[line];

        for (const sheetName of workbook.SheetNames) {
            worksheets[sheetName] = XLSX.utils.sheet_to_json(workbook.Sheets[sheetName]);
            //sheets.push(sheetName);
        }

        // Modify the XLSX
        addRow(worksheets, date, shift1, shift2, shift3);

        // update the XLSX file    
        //XLSX.utils.sheet_add_json(workbook.Sheets[sheets[0]], [{ A: 711 }], { skipHeader: true, origin: "H95" });
        XLSX.utils.sheet_add_json(workbook.Sheets[line], worksheets[line]);
        XLSX.writeFile(workbook, pathFile);

        ws = workbook.Sheets[line];
        console.log(ws);

    }
    catch {
        // Create the file
        const newBook = XLSX.utils.book_new();
        const newSheet = XLSX.utils.json_to_sheet(createRow(date, shift1, shift2, shift3));
        XLSX.utils.book_append_sheet(newBook, newSheet, line);
        XLSX.writeFile(newBook, pathFile);
    }
}


function addRow(ws, line, date, description, shift1, shift2, shift3) {

    ws[line].push({
        "Date": date,
        "description": description,
        "Shift": 1,
        "Amount": shift1
    });

    ws[line].push({
        "Date": date,
        "description": description,
        "Shift": 2,
        "Amount": shift2
    });

    ws[line].push({
        "Date": date,
        "description": description,
        "Shift": 3,
        "Amount": shift3
    });
}

function createRow(date, description, shift1, shift2, shift3) {
    var schema = [
        {
            "Date": date,
            "description": description,
            "Shift": 1,
            "Amount": shift1
        },
        {
            "Date": date,
            "description": description,
            "Shift": 2,
            "Amount": shift2
        },
        {
            "Date": date,
            "description": description,
            "Shift": 3,
            "Amount": shift3
        }
    ];

    return schema;
}


