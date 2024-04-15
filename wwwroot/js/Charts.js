
$('.myCanvas').ready(function (e) {
    var tag = $(this);
    console.log(tag);
    var ds = document.getElementById('ds').value;

    var pn = document.getElementById('pn' + ds).value;
    var wt = document.getElementById('wt' + ds).value;
    var sr = document.getElementById('sr' + ds).value;
    var cz = document.getElementById('cz' + ds).value;
    var pt = document.getElementById('pt' + ds).value;
    var sb = document.getElementById('sb' + ds).value;
    var nd = document.getElementById('nd' + ds).value;

    console.log('Wartosc:' + pn);
    console.log('Wartosc:' + wt);
    console.log('Wartosc:' + sr);
    console.log('Wartosc:' + cz);
    console.log('Wartosc:' + pt);
    console.log('Wartosc:' + sb);
    console.log('Wartosc:' + nd);

    var xValues = ["Poniedziałek", "Wtorek", "Środa", "Czwartek", "Piątek", "Sobota", "Niedziela"];
    var yValues = [pn, wt, sr, cz, pt, sb, nd];
    var barColors = ["red", "green", "blue", "orange", "brown", "yellow", "gray"];

    var name = 'myChart' + ds;

    console.log(name);

    new Chart(name, {
        type: "bar",
        data: {
            labels: xValues,
            datasets: [{
                backgroundColor: barColors,
                data: yValues
            }]
        },
        options: {
            legend: { display: false },
            title: {
                display: true,
                text: "Wykaz produkcji w ciągu tygodnia"
            }
        }
    });
})
