$(document).ready(function () {

    var divTagMain = $('#idDivCheckBox');

    var divLoading = $('#divLoading');
    divLoading.css('visibility', 'hidden');

    var divTables = $('#divTables');

    var parentWidth = divTagMain.parent().width();

    var textArea = $('#textArea');

    var submit = $('#submitClick');
    var widthSubmit = $('#submitClick').width();
    var widthTdSubmit = $('#widthTdSubmit').width();
    var marginSubmit = (widthTdSubmit - widthSubmit) / 2;

    var widthDiv = divTagMain.width();
    var widthTextArea = textArea.width();

    var marginLeft = (widthDiv - widthTextArea) / 3;

    //ustawianie marginesów
    textArea.css('margin-left', marginLeft + 'px');

    submit.css('margin-left', marginSubmit + 'px');

    divTagMain.css('visibility', 'visible');

    $('#submitClick').click(function () {
        var marginDivLoading = (parentWidth - divLoading.width()) / 2;
        divLoading.css('margin-left', marginDivLoading + 'px');
        divLoading.css('visibility', 'visible');

        divTables.css('visibility', 'hidden');
    });
})