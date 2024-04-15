$(document).ready(function () {

    var divTagMain = $('#idDivCheckBox');

    var divLoading = $('#divLoading');
    divLoading.css('visibility', 'hidden');

    var divTables = $('#divTables');

    var parentWidth = divTagMain.parent().width();

    var textArea = $('#textArea');

    var submit = $('#submitClick');
    var pobierz = $('#idPobierz');

    //pozycja button
    var widthSubmit = submit.width();
    var widthPobierz = pobierz.width();

    var widthTdSubmit = $('#widthTdSubmit').width();
    var marginSubmit = (widthTdSubmit - widthSubmit) / 2;
    var marginPobierz = (widthTdSubmit - widthSubmit + 40) / 2;

    var widthDiv = divTagMain.width();
    var widthTextArea = textArea.width();

    var marginLeft = (widthDiv - widthTextArea) / 3;

    //ustawianie marginesów
    textArea.css('margin-left', marginLeft + 'px');

    submit.css('margin-left', marginSubmit + 'px');
    pobierz.css('margin-left', marginPobierz + 'px');


    divTables.css('width', '850px');

    //divTagMain.css('position', 'relative');
    //divTagMain.css('top', '0');
    //divTagMain.css('left', '0');
    //divTagMain.css('width', '850px');
    divTagMain.css('visibility', 'visible');
   

    $('#submitClick').click(function () {
        var marginDivLoading = (parentWidth - divLoading.width()) / 2;
        divLoading.css('margin-left', marginDivLoading + 'px');
        divLoading.css('visibility', 'visible');

        divTables.css('visibility', 'hidden');
    });

    if (divTables.children().length > 0) {
        divTables.css('visibility', 'visible');
    }

    //divLoading.css('margin-left', '200px');
    //button.css('margin-left', '200px');
})
